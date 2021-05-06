namespace DummyFileMaker
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.lblOutputDirectory = new System.Windows.Forms.Label();
            this.txtDestinationFolder = new System.Windows.Forms.TextBox();
            this.cboFileSize = new System.Windows.Forms.ComboBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSeperate1 = new System.Windows.Forms.Label();
            this.lblFileName = new System.Windows.Forms.Label();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.lblFileSize = new System.Windows.Forms.Label();
            this.lblSeperate2 = new System.Windows.Forms.Label();
            this.nupFileSize = new System.Windows.Forms.NumericUpDown();
            this.prgProgress = new System.Windows.Forms.ProgressBar();
            this.btnViVN = new System.Windows.Forms.Button();
            this.btnEnUS = new System.Windows.Forms.Button();
            this.btnShowOutput = new System.Windows.Forms.Button();
            this.btnQuickMake = new System.Windows.Forms.Button();
            this.btnMake = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.grbLog = new System.Windows.Forms.GroupBox();
            this.rtxMessage = new System.Windows.Forms.RichTextBox();
            this.chkOverwriteFile = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.nupFileSize)).BeginInit();
            this.grbLog.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblOutputDirectory
            // 
            this.lblOutputDirectory.AutoSize = true;
            this.lblOutputDirectory.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblOutputDirectory.Location = new System.Drawing.Point(12, 83);
            this.lblOutputDirectory.Name = "lblOutputDirectory";
            this.lblOutputDirectory.Size = new System.Drawing.Size(114, 19);
            this.lblOutputDirectory.TabIndex = 6;
            this.lblOutputDirectory.Text = "Output Directory";
            // 
            // txtDestinationFolder
            // 
            this.txtDestinationFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDestinationFolder.Enabled = false;
            this.txtDestinationFolder.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtDestinationFolder.Location = new System.Drawing.Point(135, 80);
            this.txtDestinationFolder.Name = "txtDestinationFolder";
            this.txtDestinationFolder.Size = new System.Drawing.Size(519, 25);
            this.txtDestinationFolder.TabIndex = 7;
            // 
            // cboFileSize
            // 
            this.cboFileSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboFileSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFileSize.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboFileSize.FormattingEnabled = true;
            this.cboFileSize.Location = new System.Drawing.Point(660, 111);
            this.cboFileSize.Name = "cboFileSize";
            this.cboFileSize.Size = new System.Drawing.Size(121, 25);
            this.cboFileSize.TabIndex = 9;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(96)))), ((int)(((byte)(138)))));
            this.lblTitle.Location = new System.Drawing.Point(-1, -1);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(793, 58);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "Dummy File Maker";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // lblSeperate1
            // 
            this.lblSeperate1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSeperate1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(96)))), ((int)(((byte)(138)))));
            this.lblSeperate1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lblSeperate1.Location = new System.Drawing.Point(-3, 55);
            this.lblSeperate1.Name = "lblSeperate1";
            this.lblSeperate1.Size = new System.Drawing.Size(798, 2);
            this.lblSeperate1.TabIndex = 11;
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblFileName.Location = new System.Drawing.Point(12, 114);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(69, 19);
            this.lblFileName.TabIndex = 6;
            this.lblFileName.Text = "File Name";
            // 
            // txtFileName
            // 
            this.txtFileName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFileName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtFileName.Location = new System.Drawing.Point(135, 111);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(331, 25);
            this.txtFileName.TabIndex = 7;
            // 
            // lblFileSize
            // 
            this.lblFileSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFileSize.AutoSize = true;
            this.lblFileSize.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblFileSize.Location = new System.Drawing.Point(472, 114);
            this.lblFileSize.Name = "lblFileSize";
            this.lblFileSize.Size = new System.Drawing.Size(105, 19);
            this.lblFileSize.TabIndex = 6;
            this.lblFileSize.Text = "Output File Size";
            // 
            // lblSeperate2
            // 
            this.lblSeperate2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSeperate2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(96)))), ((int)(((byte)(138)))));
            this.lblSeperate2.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lblSeperate2.Location = new System.Drawing.Point(-3, 174);
            this.lblSeperate2.Name = "lblSeperate2";
            this.lblSeperate2.Size = new System.Drawing.Size(798, 2);
            this.lblSeperate2.TabIndex = 11;
            // 
            // nupFileSize
            // 
            this.nupFileSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nupFileSize.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.nupFileSize.Location = new System.Drawing.Point(583, 111);
            this.nupFileSize.Name = "nupFileSize";
            this.nupFileSize.Size = new System.Drawing.Size(71, 25);
            this.nupFileSize.TabIndex = 12;
            this.nupFileSize.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // prgProgress
            // 
            this.prgProgress.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.prgProgress.Location = new System.Drawing.Point(0, 301);
            this.prgProgress.Name = "prgProgress";
            this.prgProgress.Size = new System.Drawing.Size(793, 23);
            this.prgProgress.TabIndex = 13;
            // 
            // btnViVN
            // 
            this.btnViVN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnViVN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnViVN.FlatAppearance.BorderSize = 0;
            this.btnViVN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViVN.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnViVN.Image = global::DummyFileMaker.Properties.Resources.btn_viVN;
            this.btnViVN.Location = new System.Drawing.Point(745, 25);
            this.btnViVN.Name = "btnViVN";
            this.btnViVN.Size = new System.Drawing.Size(36, 24);
            this.btnViVN.TabIndex = 10;
            this.btnViVN.UseVisualStyleBackColor = false;
            this.btnViVN.Click += new System.EventHandler(this.btnViVN_Click);
            // 
            // btnEnUS
            // 
            this.btnEnUS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEnUS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEnUS.FlatAppearance.BorderSize = 0;
            this.btnEnUS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnUS.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnEnUS.Image = global::DummyFileMaker.Properties.Resources.btn_enUS;
            this.btnEnUS.Location = new System.Drawing.Point(711, 25);
            this.btnEnUS.Name = "btnEnUS";
            this.btnEnUS.Size = new System.Drawing.Size(36, 24);
            this.btnEnUS.TabIndex = 10;
            this.btnEnUS.UseVisualStyleBackColor = false;
            this.btnEnUS.Click += new System.EventHandler(this.btnEnUS_Click);
            // 
            // btnShowOutput
            // 
            this.btnShowOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShowOutput.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnShowOutput.Image = global::DummyFileMaker.Properties.Resources.btn_open_output;
            this.btnShowOutput.Location = new System.Drawing.Point(466, 188);
            this.btnShowOutput.Name = "btnShowOutput";
            this.btnShowOutput.Size = new System.Drawing.Size(101, 101);
            this.btnShowOutput.TabIndex = 10;
            this.btnShowOutput.Text = "Open Output";
            this.btnShowOutput.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnShowOutput.UseVisualStyleBackColor = true;
            this.btnShowOutput.Click += new System.EventHandler(this.btnShowOutput_Click);
            // 
            // btnQuickMake
            // 
            this.btnQuickMake.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuickMake.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnQuickMake.Image = global::DummyFileMaker.Properties.Resources.btn_quick_make;
            this.btnQuickMake.Location = new System.Drawing.Point(573, 188);
            this.btnQuickMake.Name = "btnQuickMake";
            this.btnQuickMake.Size = new System.Drawing.Size(101, 101);
            this.btnQuickMake.TabIndex = 10;
            this.btnQuickMake.Text = "Quick";
            this.btnQuickMake.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnQuickMake.UseVisualStyleBackColor = true;
            this.btnQuickMake.Click += new System.EventHandler(this.btnMake_Click);
            // 
            // btnMake
            // 
            this.btnMake.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMake.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnMake.Image = global::DummyFileMaker.Properties.Resources.btn_make;
            this.btnMake.Location = new System.Drawing.Point(680, 188);
            this.btnMake.Name = "btnMake";
            this.btnMake.Size = new System.Drawing.Size(101, 101);
            this.btnMake.TabIndex = 10;
            this.btnMake.Text = "Make";
            this.btnMake.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnMake.UseVisualStyleBackColor = true;
            this.btnMake.Click += new System.EventHandler(this.btnMake_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowse.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnBrowse.Image = global::DummyFileMaker.Properties.Resources.btn_browse;
            this.btnBrowse.Location = new System.Drawing.Point(660, 79);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(121, 27);
            this.btnBrowse.TabIndex = 8;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // grbLog
            // 
            this.grbLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbLog.Controls.Add(this.rtxMessage);
            this.grbLog.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.grbLog.Location = new System.Drawing.Point(12, 188);
            this.grbLog.Name = "grbLog";
            this.grbLog.Size = new System.Drawing.Size(448, 101);
            this.grbLog.TabIndex = 15;
            this.grbLog.TabStop = false;
            this.grbLog.Text = "Log";
            // 
            // rtxMessage
            // 
            this.rtxMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtxMessage.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rtxMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxMessage.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.rtxMessage.Location = new System.Drawing.Point(6, 33);
            this.rtxMessage.Name = "rtxMessage";
            this.rtxMessage.ReadOnly = true;
            this.rtxMessage.Size = new System.Drawing.Size(436, 62);
            this.rtxMessage.TabIndex = 14;
            this.rtxMessage.Text = "";
            // 
            // chkOverwriteFile
            // 
            this.chkOverwriteFile.AutoSize = true;
            this.chkOverwriteFile.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.chkOverwriteFile.Location = new System.Drawing.Point(135, 142);
            this.chkOverwriteFile.Name = "chkOverwriteFile";
            this.chkOverwriteFile.Size = new System.Drawing.Size(165, 23);
            this.chkOverwriteFile.TabIndex = 16;
            this.chkOverwriteFile.Text = "Overwrite existing files";
            this.chkOverwriteFile.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(793, 324);
            this.Controls.Add(this.chkOverwriteFile);
            this.Controls.Add(this.grbLog);
            this.Controls.Add(this.prgProgress);
            this.Controls.Add(this.nupFileSize);
            this.Controls.Add(this.lblSeperate2);
            this.Controls.Add(this.lblSeperate1);
            this.Controls.Add(this.btnViVN);
            this.Controls.Add(this.btnEnUS);
            this.Controls.Add(this.btnShowOutput);
            this.Controls.Add(this.btnQuickMake);
            this.Controls.Add(this.btnMake);
            this.Controls.Add(this.cboFileSize);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblFileSize);
            this.Controls.Add(this.lblFileName);
            this.Controls.Add(this.lblOutputDirectory);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.txtDestinationFolder);
            this.Controls.Add(this.btnBrowse);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dummy File Maker v0.7.1";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nupFileSize)).EndInit();
            this.grbLog.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOutputDirectory;
        private System.Windows.Forms.TextBox txtDestinationFolder;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.ComboBox cboFileSize;
        private System.Windows.Forms.Button btnMake;
        private System.Windows.Forms.Button btnEnUS;
        private System.Windows.Forms.Button btnViVN;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSeperate1;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Label lblFileSize;
        private System.Windows.Forms.Button btnQuickMake;
        private System.Windows.Forms.Label lblSeperate2;
        private System.Windows.Forms.NumericUpDown nupFileSize;
        private System.Windows.Forms.ProgressBar prgProgress;
        private System.Windows.Forms.Button btnShowOutput;
        private System.Windows.Forms.GroupBox grbLog;
        private System.Windows.Forms.RichTextBox rtxMessage;
        private System.Windows.Forms.CheckBox chkOverwriteFile;
    }
}