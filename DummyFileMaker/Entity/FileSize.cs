using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DummyFileMaker.Entity
{
    class FileSize
    {
        public FileSize(string unitName, int unitValue)
        {
            UnitName = unitName;
            UnitValue = unitValue;
        }

        public string UnitName { get; set; }
        public int UnitValue { get; set; }
    }
}
