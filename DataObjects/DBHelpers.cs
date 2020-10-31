using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObjects {
    public class DBHelpers {
        static DbProviderFactory factory = DbProviderFactories.GetFactory("System.Data.SqlClient");
        private string connectionString { get; set; }

        public DBHelpers() {
            connectionString = ConfigurationManager.ConnectionStrings["Project_PRN"].ConnectionString;
        }

        public IEnumerable<T> Read<T>(string storeProcedure, Func<IDataReader, T> make, params object[] parms) {
            using (var connection = CreateConnection()) {
                using (var command = CreateCommand(storeProcedure, connection, parms)) {
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

        DbCommand CreateCommand(string storeProcedure, DbConnection conn, params object[] parms) {
            var command = new SqlCommand();
            command.Connection = (SqlConnection)conn;
            command.CommandText = storeProcedure;
            command.CommandType = CommandType.StoredProcedure;
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

                for (int i = 0; i < parms.Length; i += 2) {
                    string name = parms[i].ToString();

                    if (parms[i + 1] is string && (string)parms[i + 1] == "")
                        parms[i + 1] = null;

                    object value = parms[i + 1] ?? DBNull.Value;

                    var dbParameter = command.CreateParameter();
                    dbParameter.ParameterName = name;
                    dbParameter.Value = value;

                    command.Parameters.Add(dbParameter);
                }
            }
        }
    }
}
