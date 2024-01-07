using System.Data.SqlClient;

namespace ShopBags.Helpers
{
    internal static class BootstrapHelper
    {
        private const string DB_SERVER = "localhost";
        private const string DB_NAME = "ShopBags";

        private static string connectionString = $"Server={DB_SERVER};Database={DB_NAME};Trusted_Connection=True;";
        public static void Execute()
        {
            // Step 1: Create the database if it doesn't exist
            CreateDatabase($"Server={DB_SERVER};Trusted_Connection=True;");

            // Step 2: Create tables if they don't exist
            CreateTable(connectionString, "Users",
                "id INT PRIMARY KEY IDENTITY," +
                "username VARCHAR(50) NOT NULL," +
                "email VARCHAR(50) UNIQUE NOT NULL," +
                "password VARCHAR(50) NOT NULL," +
                "isAdmin BIT NOT NULL DEFAULT 0," +
                "isEditor BIT NOT NULL DEFAULT 0," +
                "isActive BIT NOT NULL DEFAULT 0");
            CreateTable(connectionString, "Sizes",
                "id INT PRIMARY KEY IDENTITY," +
                "value VARCHAR(8) UNIQUE NOT NULL");
            CreateTable(connectionString, "Brands",
                "id INT PRIMARY KEY IDENTITY," +
                "name VARCHAR(32) UNIQUE NOT NULL," +
                "isActive BIT NOT NULL DEFAULT 0");
            CreateTable(connectionString, "Categories",
                "id INT PRIMARY KEY IDENTITY," +
                "name VARCHAR(24) UNIQUE NOT NULL," +
                "isActive BIT NOT NULL DEFAULT 0");
            CreateTable(connectionString, "Bags",
                "id INT PRIMARY KEY IDENTITY," +
                "name VARCHAR(32) NOT NULL," +
                "isActive BIT NOT NULL DEFAULT 0," +
                "fk_brand_id INT," +
                "fk_category_id INT," +
                "fk_size_id INT," +
                "FOREIGN KEY (fk_brand_id) REFERENCES Brands(id)," +
                "FOREIGN KEY (fk_category_id) REFERENCES Categories(id)," +
                "FOREIGN KEY (fk_size_id) REFERENCES Sizes(id)");
            CreateTable(connectionString, "Status",
                "id INT PRIMARY KEY IDENTITY," +
                "value VARCHAR(25) NOT NULL," +
                "UNIQUE (value)");
            CreateTable(connectionString, "Orders",
                "id INT PRIMARY KEY IDENTITY," +
                "fk_user_id INT," +
                "fk_bag_id INT," +
                "fk_status_id INT," +
                "FOREIGN KEY (fk_user_id) REFERENCES Users(id)," +
                "FOREIGN KEY (fk_bag_id) REFERENCES Bags(id)," +
                "FOREIGN KEY (fk_status_id) REFERENCES Status(id)");

            // Step 3: Add admin user if it doesn't exist
            AddAdminUser(connectionString);

            // Step 4: Add sizes if doesn't exist
            AddSizes(connectionString, "S");
            AddSizes(connectionString, "M");
            AddSizes(connectionString, "L");
            AddSizes(connectionString, "XL");

            // Step 5: Add sttatuses if doesn't exist
            AddStatus(connectionString, "Created");
            AddStatus(connectionString, "Pending");
            AddStatus(connectionString, "Done");
        }

        private static void CreateDatabase(string connectionString)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Check if the database exists
                string checkDatabaseQuery = $"SELECT COUNT(*) FROM master.dbo.sysdatabases WHERE name = '{DB_NAME}'";
                SqlCommand checkDatabaseCommand = new SqlCommand(checkDatabaseQuery, connection);
                int databaseExists = (int)checkDatabaseCommand.ExecuteScalar();

                if (databaseExists == 0)
                {
                    // Create the database
                    string createDatabaseQuery = $"CREATE DATABASE {DB_NAME}";
                    SqlCommand createDatabaseCommand = new SqlCommand(createDatabaseQuery, connection);
                    createDatabaseCommand.ExecuteNonQuery();
                }
            }
        }

        private static void CreateTable(string connectionString, string tableName, string tableDefinition)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Check if the table exists
                string checkTableQuery = $"SELECT COUNT(*) FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = '{tableName}'";
                SqlCommand checkTableCommand = new SqlCommand(checkTableQuery, connection);
                int tableExists = (int)checkTableCommand.ExecuteScalar();

                if (tableExists == 0)
                {
                    // Create the table
                    string createTableQuery = $"CREATE TABLE {tableName} ({tableDefinition})";
                    SqlCommand createTableCommand = new SqlCommand(createTableQuery, connection);
                    createTableCommand.ExecuteNonQuery();
                }
            }
        }

        private static void AddAdminUser(string connectionString)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Check if the admin user exists
                string checkAdminUserQuery = "SELECT COUNT(*) FROM Users WHERE username = 'admin'";
                SqlCommand checkAdminUserCommand = new SqlCommand(checkAdminUserQuery, connection);
                int adminUserExists = (int)checkAdminUserCommand.ExecuteScalar();

                if (adminUserExists == 0)
                {
                    // Add the admin user
                    string addAdminUserQuery = "INSERT INTO Users (username, email, password, isAdmin, isEditor, isActive) VALUES ('admin', 'admin@admin.com', 'admin', 1, 0, 1)";
                    SqlCommand addAdminUserCommand = new SqlCommand(addAdminUserQuery, connection);
                    addAdminUserCommand.ExecuteNonQuery();
                }
            }
        }

        private static void AddSizes(string connectionString, string sizeValue)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Check if the size exists
                string checkSizeQuery = $"SELECT COUNT(*) FROM Sizes WHERE value = '{sizeValue}'";
                SqlCommand checkSizeCommand = new SqlCommand(checkSizeQuery, connection);
                int sizeExists = (int)checkSizeCommand.ExecuteScalar();

                if (sizeExists == 0)
                {
                    // Add the size
                    string addSizeQuery = $"INSERT INTO Sizes (value) VALUES ('{sizeValue}')";
                    SqlCommand addSizeCommand = new SqlCommand(addSizeQuery, connection);
                    addSizeCommand.ExecuteNonQuery();
                }
            }
        }

        private static void AddStatus(string connectionString, string statusValue)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Check if the size exists
                string checkStatusQuery = $"SELECT COUNT(*) FROM Status WHERE value = '{statusValue}'";
                SqlCommand checkStatusCommand = new SqlCommand(checkStatusQuery, connection);
                int sizeExists = (int)checkStatusCommand.ExecuteScalar();

                if (sizeExists == 0)
                {
                    // Add the size
                    string addStatusQuery = $"INSERT INTO Status (value) VALUES ('{statusValue}')";
                    SqlCommand addStatusCommand = new SqlCommand(addStatusQuery, connection);
                    addStatusCommand.ExecuteNonQuery();
                }
            }

        }
    }
}
