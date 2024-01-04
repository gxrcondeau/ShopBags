using ShopBags.Sessions;
using System.Data.SqlClient;

namespace ShopBags.Services
{
    internal class UserService
    {
        private const string DB_SERVER = "localhost";
        private const string DB_NAME = "test";

        private static string connectionString = $"Server={DB_SERVER};Database={DB_NAME};Trusted_Connection=True;";

        public bool AuthenticateUser(string email, string password)
        {
            // Implement your authentication logic (e.g., check against the database)
            string query = $"SELECT id as 'Id', username as 'Name', email as 'Email', isAdmin as 'IsAdmin', isEditor as 'IsEditor' FROM Users WHERE email = @Email AND password = @Password AND isActive = 1";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Password", password);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            // User is authenticated, update UserSession with user data
                            reader.Read();
                            int userId = reader.GetInt32(reader.GetOrdinal("Id"));
                            string userName = reader.GetString(reader.GetOrdinal("Name"));
                            string userEmail = reader.GetString(reader.GetOrdinal("Email"));
                            bool isAdmin = reader.GetBoolean(reader.GetOrdinal("IsAdmin"));
                            bool isEditor = reader.GetBoolean(reader.GetOrdinal("IsEditor"));

                            UserSession.Instance.SetUserData(userId, userName, userEmail, isAdmin, isEditor);

                            return true;
                        }
                        else
                        {
                            return false; // Authentication failed
                        }
                    }
                }
            }
        }

        public string RegisterUser(string username, string password, string email)
        {
            // Check for unique email before proceeding with registration
            if (!IsEmailUnique(email))
            {
                return "Email is not unique"; // Registration failed - email is not unique
            }

            string query = "INSERT INTO Users (username, password, email, isActive) VALUES (@Username, @Password, @Email, @IsActive)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@IsActive", 1);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        // Registration successful, update UserSession with user data
                        return "Registration successful!";
                    }
                    else
                    {
                        return "Registration failed"; // Registration failed
                    }
                }
            }
        }
        private bool IsEmailUnique(string email)
        {
            string query = "SELECT COUNT(*) FROM Users WHERE Email = @Email";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Email", email);

                    int count = (int)command.ExecuteScalar();

                    return count == 0; // Email is unique if count is zero
                }
            }
        }
    }
}
