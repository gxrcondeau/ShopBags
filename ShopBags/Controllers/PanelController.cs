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
            _view.FetchUsers += FetchUsers;
            _view.UpdateUsers += UpdateUsers;
            _view.FetchProducts += FetchProducts;
            _view.CreateProduct += CreateProduct;
            _view.UpdateProducts += UpdateProduct;
            _view.FetchSizes += FetchSizesCB;
            _view.FetchBrandsHelper += FetchBrandsCB;
            _view.FetchCategoriesHelper += FetchCategoriesCB;
        }

        private void UpdateBrands(object? sender, EventArgs e)
        {
            DataTable updatedData = ((DataTable)_view.dgvBrands.DataSource).GetChanges();
            if (updatedData != null)
            {
                foreach(DataRow row in updatedData.Rows)
                {
                    int id = (int)(row["ID"]);
                    string name = (string)(row["Name"]);
                    int isActive = Convert.ToInt32(row["isActive"]);

                    string query = $"UPDATE Brands SET name = @Name, isActive = @IsActive WHERE id = @Id";

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
            string query = "SELECT id, name, isActive FROM Brands";

            DataTable dataTable = DatabaseHelper.ExecuteReader(query, null);
            _view.DisplayBrands(dataTable);
        }

        private void CreateBrand(object? sender, EventArgs e)
        {
            string title = _view.BrandTitle;

            if (title.Length > 0)
            {
                DataTable table = new DataTable();

                string query = $"INSERT INTO Brands (name) VALUES ('{title}')";

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
            string query = "SELECT id, name, isActive FROM Categories";

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

                    string query = $"UPDATE Categories SET name = @Name, isActive = @IsActive WHERE id = @Id";

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
            string name = _view.CategoryTitle;

            if (name.Length > 0)
            {
                DataTable table = new DataTable();

                string query = $"INSERT INTO Categories (name) VALUES ('{name}')";

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

        private void FetchUsers(object? sender, EventArgs e)
        {
            string query = "SELECT id, username, email, isAdmin, isEditor, isActive FROM Users";

            DataTable dataTable = DatabaseHelper.ExecuteReader(query, null);

            _view.DisplayUsers(dataTable);
        }

        private void UpdateUsers(object? sender, EventArgs e)
        {
            DataTable updatedData = ((DataTable)_view.dgvUsers.DataSource).GetChanges();
            if (updatedData != null)
            {
                foreach (DataRow row in updatedData.Rows)
                {
                    int id = (int)(row["ID"]);
                    string name = (string)(row["Name"]);
                    int isActive = Convert.ToInt32(row["isActive"]);
                    string email = (string)(row["Email"]);
                    int isAdmin = (int)(row["IsAdmin"]);
                    int isEditor= (int)(row["IsEditor"]);

                    string query = $"UPDATE Users SET username = @Name, isActive = @IsActive, email = @Email, isEditor = @IsEditor, isAdmin = @IsAdmin WHERE id = @Id";

                    SqlParameter[] parameters =
                    {
                        new SqlParameter("@Id", id),
                        new SqlParameter("@Name", name),
                        new SqlParameter("@Email", email),
                        new SqlParameter("@IsActive", isActive),
                        new SqlParameter("@IsAdmin", isAdmin),
                        new SqlParameter("@IsEditor", isEditor),
                    };
                    try
                    {
                        var result = DatabaseHelper.ExecuteNonQuery(query, parameters);

                        if (result != 1)
                        {
                            _view.ShowError("Error updating user");
                        }
                        else
                        {
                            _view.ShowInfo("User updated successfully");
                        }
                    }
                    catch (Exception ex)
                    {

                        _view.ShowError(ex.ToString());
                    }
                }
            }
        }

        private void FetchProducts(object? sender, EventArgs e)
        {
            string query = "SELECT " +
                "bag.id as 'Id', " +
                "bag.name as 'Name', " +
                "bag.isActive as 'Active', " +
                "brand.name as 'Brand', " +
                "cat.name as 'Category', " +
                "bag.fk_size_id as 'SizeId', " +
                "bag.fk_brand_id as 'BrandId', " +
                "bag.fk_category_id as 'CategoryId', " +
                "size.value as 'Value' " +
                "FROM Bags bag " +
                "LEFT JOIN Brands brand ON brand.id = bag.fk_brand_id " +
                "LEFT JOIN Categories cat ON cat.id = bag.fk_category_id " +
                "LEFT JOIN Sizes size ON size.id = bag.fk_size_id";

            DataTable dataTable = DatabaseHelper.ExecuteReader(query, null);

            _view.DisplayProducts(dataTable);
        }

        private void CreateProduct(object? sender, EventArgs e)
        {
            string name = _view.ProductTitle;
            int size = SizesHelper.GetSizeId(_view.ProductSize);
            int brand = BrandsHelper.GetBrandId(_view.ProductBrand);
            int category = CategoriesHelper.GetCategoryId(_view.ProductCategory);

            if (name.Length > 0)
            {
                if (size >= 0)
                {
                    if (brand >= 0)
                    {
                        if (category >= 0)
                        {
                            DataTable table = new DataTable();

                            string query = $"INSERT INTO Bags (name, fk_size_id, fk_brand_id, fk_category_id, isActive) VALUES ('{name}', '{size}','{brand}','{category}',0)";

                            try
                            {
                                var result = DatabaseHelper.ExecuteNonQuery(query, null);
                                if (result != 1)
                                {
                                    _view.ShowError("Error creating new category");
                                }
                                else
                                {
                                    _view.ShowInfo("Product created successfully");
                                    FetchProducts(sender, e);
                                }
                            }
                            catch (Exception ex)
                            {

                                _view.ShowError(ex.ToString());
                            }
                        }
                        else
                        {
                            _view.ShowError("Please enter product category");
                        }
                    }
                    else
                    {
                        _view.ShowError("Please enter product brand");
                    }
                }
                else
                {
                    _view.ShowError("Please enter product size");
                }
            }
            else
            {
                _view.ShowError("Please enter product title");
            }
        }

        private void UpdateProduct(object? sender, EventArgs e)
        {
            DataTable updatedData = ((DataTable)_view.dgvProducts.DataSource).GetChanges();
            if (updatedData != null)
            {
                foreach (DataRow row in updatedData.Rows)
                {
                    int id = (int)(row["ID"]);
                    string name = (string)(row["Name"]);
                    int isActive = Convert.ToInt32(row["Active"]);
                    int size = (int)(row["SizeId"]);
                    int brand = (int)(row["BrandId"]);
                    int category = (int)(row["CategoryId"]);

                    string query = $"UPDATE Bags SET name = @Name, isActive = @IsActive, fk_size_id = @Size, fk_brand_id = @Brand, fk_category_id = @Category WHERE id = @Id";

                    SqlParameter[] parameters =
                    {
                        new SqlParameter("@Id", id),
                        new SqlParameter("@Name", name),
                        new SqlParameter("@Size", size),
                        new SqlParameter("@IsActive", isActive),
                        new SqlParameter("@Brand", brand),
                        new SqlParameter("@Category", category),
                    };
                    try
                    {
                        var result = DatabaseHelper.ExecuteNonQuery(query, parameters);

                        if (result != 1)
                        {
                            _view.ShowError("Error updating product");
                        }
                        else
                        {
                            _view.ShowInfo("Product updated successfully");
                        }
                    }
                    catch (Exception ex)
                    {

                        _view.ShowError(ex.ToString());
                    }
                }
            }
        }

        private void FetchSizesCB(object? sender, EventArgs e)
        {
            SizesHelper.LoadSizeData(_view);
        }

        private void FetchBrandsCB(object? sender, EventArgs e)
        {
            BrandsHelper.LoadBrandsData( _view);
        }

        private void FetchCategoriesCB(object? sender, EventArgs e)
        {
            CategoriesHelper.LoadCategoriesData(_view);
        }
    }
}
