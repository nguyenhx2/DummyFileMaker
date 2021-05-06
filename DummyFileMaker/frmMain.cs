using DummyFileMaker.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

namespace DummyFileMaker
{
    public partial class frmMain : Form
    {
        CultureInfo culture;
        private string EXCUTE_FOLDER_PATH = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, AppDomain.CurrentDomain.RelativeSearchPath ?? "");
        private int total = 1;
        private BackgroundWorker bw = new BackgroundWorker();

        public frmMain()
        {
            culture = CultureInfo.CurrentCulture;
            InitializeComponent();
            SetLanguage("vi-VN");
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            InitialFileSizeCombobox();
            bw.DoWork += bw_DoWork;
            bw.RunWorkerCompleted += bw_RunWorkerCompleted;
            bw.ProgressChanged += bw_ProgressChanged;
            bw.WorkerReportsProgress = true;

        }

        private void InitialFileSizeCombobox()
        {
            List<FileSize> lstFileSize = new List<FileSize>();
            FileSize[] fileSize = new FileSize[]{
                new FileSize("Byte", 1),
                new FileSize("KB (kilobyte)", 1024),
                new FileSize("MB (megabyte)", 1048576),
                new FileSize("GB (gigabyte)", 1073741824),
            };
            lstFileSize.AddRange(fileSize);

            cboFileSize.DisplayMember = "UnitName";
            cboFileSize.ValueMember = "UnitValue";
            cboFileSize.DataSource = lstFileSize;
            cboFileSize.SelectedIndex = 2;
        }

        private void btnMake_Click(object sender, EventArgs e)
        {
            try
            {
                AppendMessage(string.Format("Start making file..."), Color.Purple, rtxMessage);
                DisableFormControls();
                bw.RunWorkerAsync();
            }
            catch (Exception ex)
            {
                AppendMessage(string.Format("Error: {0}", ex.Message), Color.Red, rtxMessage);
            }

            //using (var fs = new FileStream(fileName, FileMode.Create, FileAccess.Write, FileShare.None))
            //{
            //    fs.SetLength(1000 * 1024 * 1024);
            //}
        }

        void bw_DoWork(object sender, DoWorkEventArgs e)
        {
            decimal fileSize = nupFileSize.Value;
            string filePath = EXCUTE_FOLDER_PATH;

            string fileName = "";
            string arguments = "";

            if (String.IsNullOrEmpty(txtFileName.Text))
            {
                cboFileSize.Invoke((MethodInvoker)(() => fileName = "File " + fileSize.ToString() + cboFileSize.Text + ".txt"));

            }
            else
            {
                fileName = txtFileName.Text;
            }

            if (String.IsNullOrEmpty(txtDestinationFolder.Text))
            {
                filePath = EXCUTE_FOLDER_PATH;
            }
            else
            {
                filePath = txtDestinationFolder.Text;
            }

            cboFileSize.Invoke((MethodInvoker)(() => fileSize = nupFileSize.Value * (int)cboFileSize.SelectedValue));
            using (Process process = new Process())
            {
                AppendMessage(string.Format("Making {0}", Path.Combine(filePath, fileName)), Color.Purple, rtxMessage);
                process.StartInfo.WorkingDirectory = EXCUTE_FOLDER_PATH;
                process.StartInfo.FileName = "fsutil.exe";
                process.StartInfo.CreateNoWindow = true;
                arguments = string.Format("file createnew {0} {1}", @"""" + Path.Combine(filePath, fileName) + @"""", fileSize.ToString());
                process.StartInfo.Arguments = arguments;
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.RedirectStandardOutput = true;
                process.Start();
                string returnedMessage = RemoveEmptyLines(process.StandardOutput.ReadToEnd());
                AppendMessage(string.Format(returnedMessage), returnedMessage.Contains("Error") ? Color.Red : Color.Purple, rtxMessage);
                process.WaitForExit();
                process.Close();
                process.Dispose();
                bw.ReportProgress(1);
            }
        }


        private string RemoveEmptyLines(string lines)
        {
            return Regex.Replace(lines, @"^\s*$\n|\r", string.Empty, RegexOptions.Multiline).TrimEnd();
        }

        private void bw_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            MethodInvoker action = delegate
            {
                try
                {
                    prgProgress.Maximum = total;
                    prgProgress.Value = e.ProgressPercentage;
                }
                catch { throw; }
            };
            prgProgress.BeginInvoke(action);
        }

        void bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //button1.Enabled = true;
            AppendMessage(string.Format("Making dummy file successfully."), Color.DarkGreen, rtxMessage);
            EnableFormControls();
        }

        private void LaunchApplicationFromLocalAppFolder()
        {
            string localApplicationDataPath = System.Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            string resourceName = "";
            // Get embedded resource then copy to file stream
            Assembly asm = Assembly.GetExecutingAssembly();
            string res = string.Format("{0}.Resources." + resourceName, asm.GetName().Name);
            Stream stream = asm.GetManifestResourceStream(res);

            try
            {
                using (Stream file = File.Create(localApplicationDataPath + @"\" + resourceName))
                {
                    CopyStream(stream, file);
                }
                Process.Start(localApplicationDataPath + @"\" + resourceName);
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void CopyStream(Stream input, Stream output)
        {
            byte[] buffer = new byte[8 * 1024];
            int len;
            while ((len = input.Read(buffer, 0, buffer.Length)) > 0)
            {
                output.Write(buffer, 0, len);
            }
        }

        private void DisableFormControls()
        {
            foreach (Control c in this.Controls)
            {
                if (c.Name == "rtxMessage")
                    c.Enabled = true;
                else
                    c.Enabled = false;
            }
        }

        private void EnableFormControls()
        {
            foreach (Control c in this.Controls)
            {
                c.Enabled = true;
            }
        }

        private void SetLanguage(string cultureName)
        {
            culture = CultureInfo.CreateSpecificCulture(cultureName);
            ResourceManager resourceManager = new ResourceManager("DummyFileMaker.Language.Resource", typeof(frmMain).Assembly);

            btnMake.Text = resourceManager.GetString("make", culture);
            btnBrowse.Text = resourceManager.GetString("browse", culture);
            btnQuickMake.Text = resourceManager.GetString("quick", culture);
            btnShowOutput.Text = resourceManager.GetString("showOutput", culture);
            lblOutputDirectory.Text = resourceManager.GetString("outputDirectory", culture);
            lblFileName.Text = resourceManager.GetString("fileName", culture);
            lblFileSize.Text = resourceManager.GetString("fileSize", culture);
        }

        private void btnEnUS_Click(object sender, EventArgs e)
        {
            SetLanguage("en-US");
        }

        private void btnViVN_Click(object sender, EventArgs e)
        {
            SetLanguage("vi-VN");
        }

        public void AppendMessage(string Message, [Optional] Color cClolor, RichTextBox rickTextBox, string stackTrace = "")
        {
            MethodInvoker action = delegate
            {
                if (cClolor == null) cClolor = Color.Black;
                rickTextBox.SelectionColor = cClolor;
                var txt = string.Concat(DateTime.Now.ToString(), ": ", Message);
                rickTextBox.AppendText(txt + Environment.NewLine);
                rickTextBox.ScrollToCaret();
            };

            rickTextBox.BeginInvoke(action);
            string logString = string.IsNullOrEmpty(stackTrace) ? Message : Message + Environment.NewLine + stackTrace;
        }

        public bool CheckFileIsExisted(string filePath)
        {
            return File.Exists(filePath);
        }

        private void DeleteFileFromFolder(string filePath)
        {
            try
            {
                if (File.Exists(filePath))
                {
                    File.Delete(filePath);
                }

            }
            catch (IOException ex)
            {
                AppendMessage(string.Format("Error: {0}", ex.Message), Color.Red, rtxMessage);
            }
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            folderDlg.ShowNewFolderButton = true;
            DialogResult result = folderDlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtDestinationFolder.Text = folderDlg.SelectedPath;
            }
        }

        static void OpenInExplorer(string path)
        {
            string cmd = "explorer.exe";
            string arg = "/select, " + path;
            Process.Start(cmd, arg);
        }

        private void OpenSubfolder(string folder)
        {
            var psi = new ProcessStartInfo();
            psi.FileName = @"explorer.exe";
            psi.Arguments = folder;
            Process.Start(psi);
        }

        private void btnShowOutput_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtDestinationFolder.Text))
            {
                OpenSubfolder(EXCUTE_FOLDER_PATH);
            }
            else
            {
                OpenSubfolder(txtDestinationFolder.Text);
            }
        }
    }
}
