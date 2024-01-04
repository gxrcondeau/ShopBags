using System.Data;
using System.Data.SqlClient;


namespace ShopBags.Helpers
{
    internal class DatabaseHelper
    {
        private const string DB_SERVER = "localhost";
        private const string DB_NAME = "test";

        private static string connectionString = $"Server={DB_SERVER};Database={DB_NAME};Trusted_Connection=True;";

        public static int ExecuteNonQuery(string query, SqlParameter[] parameters)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters);
                    }

                    return command.ExecuteNonQuery();
                }
            }
        }

        public static DataTable ExecuteReader(string query, SqlParameter[] parameters)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters);
                    }

                    DataTable dt = new DataTable();
                    dt.Load(command.ExecuteReader());
                    return dt;
                }
            }
        }
    }
}
