using ShopBags.Views;
using System.Data.SqlClient;

namespace ShopBags.Helpers
{
    internal static class CategoriesHelper
    {
        private const string DB_SERVER = "localhost";
        private const string DB_NAME = "test";

        private static string connectionString = $"Server={DB_SERVER};Database={DB_NAME};Trusted_Connection=True;";

        public static void LoadCategoriesData(PanelView view)
        {
            List<Models.Category> categories = new List<Models.Category>();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Load size data from the Sizes table
                    string query = "SELECT id, name FROM Categories";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                // Assuming you have a class named SizeItem with properties Id and Value
                                Models.Category categoryItem = new Models.Category()
                                {
                                    Id = reader.GetInt32(0),
                                    Name = reader.GetString(1)
                                };

                                // Add the sizeItem to the ComboBox
                                categories.Add(categoryItem);
                            }
                            view.DisplayCategoriesCB(categories);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                view.ShowError(ex.Message);
            }
        }

        public static int GetCategoryId(string name)
        {
            int id = -1;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Load size data from the Sizes table
                string query = $"SELECT id FROM Categories WHERE name = '{name}'";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            id = reader.GetInt32(0);
                        }
                        return id;
                    }
                }
            }
        }

        public static void LoadCategoriesData(DataGridViewComboBoxColumn categoryColumn)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Load Size data from the Sizes table
                    string query = "SELECT Id, Name FROM Categories";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                // Add each Size to the ComboBoxColumn
                                categoryColumn.Items.Add(new Models.Category
                                {
                                    Id = reader.GetInt32(0),
                                    Name = reader.GetString(1)
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions
                MessageBox.Show($"Error loading category data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
