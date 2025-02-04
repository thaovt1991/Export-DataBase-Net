﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DBExport.Options.Model
{
    public class DatabaseExportOptions
    {
        public DatabaseOptions DatabaseOptions { get; set; } = new();
        public ExportOptions ExportOptions { get; set; } = new();
    }
}
