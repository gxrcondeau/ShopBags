using ShopBags.Helpers;
using ShopBags.Views;
using System.Data;
using System.Data.SqlClient;

namespace ShopBags.Controllers
{
    internal class PanelController
    {
        private readonly PanelView _view;

        public PanelController(PanelView panelView)
        {
            _view = panelView;
            WireUpEvents();
        }

        private void WireUpEvents()
        {
            _view.FetchBrands += FetchBrands;
            _view.CreateBrand += CreateBrand;
            _view.UpdateBrands += UpdateBrands;
            _view.FetchCategories += FetchCategories;
            _view.CreateCategory += CreateCategory;
            _view.UpdateCategories += UpdateCategories;
        }

        private void UpdateBrands(object? sender, EventArgs e)
        {
            DataTable updatedData = ((DataTable)_view.dgvBrands.DataSource).GetChanges();
            if (updatedData != null)
            {
                foreach(DataRow row in updatedData.Rows)
                {
                    int id = (int)(row["ID"]);
                    string name = (string)(row["Title"]);
                    int isActive = Convert.ToInt32(row["isActive"]);

                    string query = $"UPDATE [Brand] SET title = @Name, isActive = @IsActive WHERE id = @Id";

                    SqlParameter[] parameters =
                    {
                        new SqlParameter("@Name", name),
                        new SqlParameter("@IsActive", isActive),
                        new SqlParameter("@Id", id)
                    };
                    try
                    {
                        var result = DatabaseHelper.ExecuteNonQuery(query, parameters);

                        if (result != 1)
                        {
                            _view.ShowError("Error updating brand");
                        }
                        else
                        {
                            _view.ShowInfo("Brand updated successfully");
                        }
                    }
                    catch (Exception ex)
                    {

                        _view.ShowError(ex.ToString());
                    }
                }
            }
        }

        private void FetchBrands(object? sender, EventArgs e)
        {
            string query = "SELECT id, title, isActive FROM [Brand]";

            DataTable dataTable = DatabaseHelper.ExecuteReader(query, null);
            _view.DisplayBrands(dataTable);
        }

        private void CreateBrand(object? sender, EventArgs e)
        {
            string title = _view.BrandTitle;

            if (title.Length > 0)
            {
                DataTable table = new DataTable();

                string query = $"INSERT INTO [Brand](title) VALUES ('{title}')";

                try
                {
                    var result = DatabaseHelper.ExecuteNonQuery(query, null);
                    if (result != 1)
                    {
                        _view.ShowError("Error creating new brand");
                    }
                    else
                    {
                        _view.ShowInfo("Brand created successfully");
                        FetchBrands(sender, e);
                    }
                }
                catch (Exception ex)
                {

                    _view.ShowError(ex.ToString());
                }
            }
            else
            {
                _view.ShowError("Please enter brand title");
            }
        }

        private void FetchCategories(object? sender, EventArgs e)
        {
            string query = "SELECT id, name, isActive FROM [Category]";

            DataTable dataTable = DatabaseHelper.ExecuteReader(query, null);
            _view.DisplayCategories(dataTable);
        }

        private void UpdateCategories(object? sender, EventArgs e)
        {
            DataTable updatedData = ((DataTable)_view.dgvCategories.DataSource).GetChanges();
            if (updatedData != null)
            {
                foreach (DataRow row in updatedData.Rows)
                {
                    int id = (int)(row["ID"]);
                    string name = (string)(row["Name"]);
                    int isActive = Convert.ToInt32(row["isActive"]);

                    string query = $"UPDATE [Category] SET name = @Name, isActive = @IsActive WHERE id = @Id";

                    SqlParameter[] parameters =
                    {
                        new SqlParameter("@Name", name),
                        new SqlParameter("@IsActive", isActive),
                        new SqlParameter("@Id", id)
                    };
                    try
                    {
                        var result = DatabaseHelper.ExecuteNonQuery(query, parameters);

                        if (result != 1)
                        {
                            _view.ShowError("Error updating category");
                        }
                        else
                        {
                            _view.ShowInfo("Category updated successfully");
                        }
                    }
                    catch (Exception ex)
                    {

                        _view.ShowError(ex.ToString());
                    }
                }
            }
        }

        private void CreateCategory(object? sender, EventArgs e)
        {
            string title = _view.CategoryTitle;

            if (title.Length > 0)
            {
                DataTable table = new DataTable();

                string query = $"INSERT INTO [Category](name) VALUES ('{title}')";

                try
                {
                    var result = DatabaseHelper.ExecuteNonQuery(query, null);
                    if (result != 1)
                    {
                        _view.ShowError("Error creating new category");
                    }
                    else
                    {
                        _view.ShowInfo("Category created successfully");
                        FetchCategories(sender, e);
                    }
                }
                catch (Exception ex)
                {

                    _view.ShowError(ex.ToString());
                }
            }
            else
            {
                _view.ShowError("Please enter category title");
            }
        }
    }
}
