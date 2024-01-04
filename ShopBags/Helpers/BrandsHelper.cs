using ShopBags.Views;
using System.Data.SqlClient;

namespace ShopBags.Helpers
{
    internal static class BrandsHelper
    {
        private const string DB_SERVER = "localhost";
        private const string DB_NAME = "test";

        private static string connectionString = $"Server={DB_SERVER};Database={DB_NAME};Trusted_Connection=True;";

        public static void LoadBrandsData(PanelView view)
        {
            List<Models.Brand> brands = new List<Models.Brand>();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Load brand data from the Brands table
                    string query = "SELECT id, name FROM Brands WHERE isActive = 1";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Models.Brand brandItem = new Models.Brand()
                                {
                                    Id = reader.GetInt32(0),
                                    Name = reader.GetString(1)
                                };

                                // Add the brand to the ComboBox
                                brands.Add(brandItem);
                            }
                            view.DisplayBrandsCB(brands);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                view.ShowError(ex.Message);
            }
        }

        public static int GetBrandId(string name)
        {
            int id = -1;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Load size data from the Sizes table
                string query = $"SELECT id FROM Brands WHERE name = '{name}'";

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

        public static void LoadBrandData(DataGridViewComboBoxColumn brandColumn)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT Id, Name FROM Brands";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                brandColumn.Items.Add(new Models.Brand
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
                MessageBox.Show($"Error loading brand data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}