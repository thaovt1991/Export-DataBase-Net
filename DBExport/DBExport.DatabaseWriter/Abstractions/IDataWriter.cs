using DBExport.DatabaseObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBExport.DatabaseWriter.Abstractions
{
    public interface IDataWriter
    {
        void WriteData(ExportSource database, Stream stream);
    }
}
