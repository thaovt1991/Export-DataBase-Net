using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBExport.DatabaseBuilders.SqlServer;
using DBExport.DatabaseObjects;
using DBExport.Options.Enum;


namespace DBExport.DatabaseBuilders
{
    public class DatabaseBuilderFactory
    {
        public static IExportSourceBuilder? Connect(ServerTypes serverType, string connectionString)
        {
            return serverType switch
            {
                ServerTypes.SqlServer => new SqlServerDatabaseBuilder(connectionString),
                _ => null,
            };
        }
    }
}
