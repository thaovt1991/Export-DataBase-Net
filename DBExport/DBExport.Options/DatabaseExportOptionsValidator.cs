using DBExport.Options.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBExport.Options
{
    public class DatabaseExportOptionsValidator : IDatabaseExportOptionsValidator
    {
        public static readonly DatabaseExportOptionsValidator Instance = new(); // normally we only need exactly 1 instance
        public void Validate(DatabaseExportOptions options)
        {
            ArgumentNullException.ThrowIfNull(options, nameof(options));

            if (!(string.IsNullOrWhiteSpace(options.DatabaseOptions.SelectQuery) ^ string.IsNullOrWhiteSpace(options.DatabaseOptions.TableNames)))
            {
                throw new ArgumentException("Only SelectQuery or TableNames can be set");
            }
        }

      
    }
}
