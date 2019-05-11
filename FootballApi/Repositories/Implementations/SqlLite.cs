using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using FootballApi.Models;
using Microsoft.Data.Sqlite;

namespace FootballApi.Repositories.Implementations
{
    public class SqlLite {
        static string assemblyFile = Path.GetDirectoryName(new System.Uri(Assembly.GetExecutingAssembly().CodeBase).AbsolutePath);

        public static SqliteConnection GetConnection() {
            var connection = new SqliteConnection(
                new SqliteConnectionStringBuilder
                {
                    DataSource = Path.Join(assemblyFile, "../../../../sport.db")
                }.ToString()   
            );

            return connection;
        }
    }

}