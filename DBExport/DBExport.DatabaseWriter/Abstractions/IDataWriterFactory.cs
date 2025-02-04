using DBExport.DatabaseWriter.CSV;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBExport.DatabaseWriter.Abstractions
{
    public interface IDataWriterFactory
    {
        CsvDataWriter GetDataWriter();
    }
}
