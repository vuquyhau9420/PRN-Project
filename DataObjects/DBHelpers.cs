using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObjects {
    public class DBHelpers {
        static DbProviderFactory factory = DbProviderFactories.GetFactory("System.Data.SqlClient");
        private string connectionString { get; set; }

        public DBHelpers() {
            connectionString = ConfigurationManager.ConnectionStrings[0].ConnectionString;
        }

        public IEnumerable<T> Read<T>(string sql, Func<IDataReader, T> make, params object[] parms) {
            using (var connection = CreateConnection()) {
                using (var command = CreateCommand(sql, connection, parms)) {
                    using (var reader = command.ExecuteReader()) {
                        while (reader.Read()) {
                            yield return make(reader);
                        }
                    }
                }
            }
        }

        public int Insert(string sql, params object[] parms) {
            using (var connection = CreateConnection()) {
                using (var command = CreateCommand(sql + ";SELECT SCOPE_IDENTITY();", connection, parms)) {
                    return int.Parse(command.ExecuteScalar().ToString());
                }
            }
        }

        public int Update(string sql, params object[] parms) {
            using (var connection = CreateConnection()) {
                using (var command = CreateCommand(sql, connection, parms)) {
                    return command.ExecuteNonQuery();
                }
            }
        }

        DbConnection CreateConnection() {
            var connection = factory.CreateConnection();
            connection.ConnectionString = connectionString;
            connection.Open();
            return connection;
        }

        DbCommand CreateCommand(string sql, DbConnection conn, params object[] parms) {
            var command = factory.CreateCommand();
            command.Connection = conn;
            command.CommandText = sql;
            command.AddParameters(parms);
            return command;
        }

        DbDataAdapter CreateAdapter(DbCommand command) {
            // ** Factory pattern in action

            var adapter = factory.CreateDataAdapter();
            adapter.SelectCommand = command;
            return adapter;
        }


    }

    public static class DbExtentions {
        public static void AddParameters(this DbCommand command, object[] parms) {
            if (parms != null && parms.Length > 0) {

                // ** Iterator pattern

                // NOTE: processes a name/value pair at each iteration

                for (int i = 0; i < parms.Length; i += 2) {
                    string name = parms[i].ToString();

                    // no empty strings to the database

                    if (parms[i + 1] is string && (string)parms[i + 1] == "")
                        parms[i + 1] = null;

                    // if null, set to DbNull

                    object value = parms[i + 1] ?? DBNull.Value;

                    // ** Factory pattern

                    var dbParameter = command.CreateParameter();
                    dbParameter.ParameterName = name;
                    dbParameter.Value = value;

                    command.Parameters.Add(dbParameter);
                }
            }
        }
    }
}
}
