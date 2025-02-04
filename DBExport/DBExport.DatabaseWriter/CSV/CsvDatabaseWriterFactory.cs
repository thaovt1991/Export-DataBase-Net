using DBExport.DatabaseWriter.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBExport.DatabaseWriter.CSV
{
    public class CsvDatabaseWriterFactory : IDataWriterFactory
    {
        public CsvDatabaseWriterFactory()
        {
        }

        public CsvDataWriter GetDataWriter()
        {
            return new CsvDataWriter();
        }
    }
}
