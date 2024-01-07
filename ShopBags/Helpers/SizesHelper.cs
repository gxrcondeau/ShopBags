using ShopBags.Views;
using System.Data.SqlClient;

namespace ShopBags.Helpers
{
    internal static class SizesHelper
    {
        private const string DB_SERVER = "localhost";
        private const string DB_NAME = "ShopBags";

        private static string connectionString = $"Server={DB_SERVER};Database={DB_NAME};Trusted_Connection=True;";

        public static void LoadSizeData(PanelView view)
        {
            List<Models.Size> sizes = new List<Models.Size>();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Load size data from the Sizes table
                    string query = "SELECT id, value FROM Sizes";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                // Assuming you have a class named SizeItem with properties Id and Value
                                Models.Size sizeItem = new Models.Size()
                                {
                                    Id = reader.GetInt32(0),
                                    Value = reader.GetString(1)
                                };

                                // Add the sizeItem to the ComboBox
                                sizes.Add(sizeItem);
                            }
                            view.DisplaySizesCB(sizes);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                view.ShowError(ex.Message);
            }
        }

        public static void LoadSizeData(StoreView view)
        {
            List<Models.Size> sizes = new List<Models.Size>();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Load size data from the Sizes table
                    string query = "SELECT id, value FROM Sizes";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                // Assuming you have a class named SizeItem with properties Id and Value
                                Models.Size sizeItem = new Models.Size()
                                {
                                    Id = reader.GetInt32(0),
                                    Value = reader.GetString(1)
                                };

                                // Add the sizeItem to the ComboBox
                                sizes.Add(sizeItem);
                            }
                            view.DisplaySizesCB(sizes);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                view.ShowError(ex.Message);
            }
        }

        public static int GetSizeId(string value)
        {
            int id = -1;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Load size data from the Sizes table
                string query = $"SELECT id FROM Sizes WHERE value = '{value}'";

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

        public static void LoadSizeData(DataGridViewComboBoxColumn sizeColumn)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT Id, Value FROM Sizes";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                sizeColumn.Items.Add(new Models.Size
                                {
                                    Id = reader.GetInt32(0),
                                    Value = reader.GetString(1)
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions
                MessageBox.Show($"Error loading size data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
