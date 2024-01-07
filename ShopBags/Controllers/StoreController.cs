using ShopBags.Helpers;
using ShopBags.Views;
using System.Data;

namespace ShopBags.Controllers
{
    internal class StoreController
    {
        private readonly StoreView _view;
        private PanelView _panelView;

        public StoreController(StoreView view)
        {
            _view = view;
            WireUpEvents();
        }

        private void WireUpEvents()
        {
            _view.OpenPanel += OpenPanel;
            _view.FetchProducts += FetchProducts;
            _view.FetchProductsWithFilters += FetchProductsWithFilters;
            _view.FetchBrandsHelper += FetchBrandsCB;
            _view.FetchSizesHelper += FetchSizesCB;
            _view.FetchCategoriesHelper += FetchCategoriesCB;
        }

        private void OpenPanel(object sender, EventArgs e)
        {
            _panelView = new PanelView();
            PanelController panelController = new PanelController(_panelView);
            _panelView.Show();
        }

        private void FetchProducts(object? sender, EventArgs e)
        {
            string query = "SELECT " +
                "bag.name as 'Name', " +
                "brand.name as 'Brand', " +
                "cat.name as 'Category', " +
                "size.value as 'Size' " +
                "FROM Bags bag " +
                "LEFT JOIN Brands brand ON brand.id = bag.fk_brand_id " +
                "LEFT JOIN Categories cat ON cat.id = bag.fk_category_id " +
                "LEFT JOIN Sizes size ON size.id = bag.fk_size_id " +
                "WHERE bag.isActive = 1";

            DataTable dataTable = DatabaseHelper.ExecuteReader(query, null);

            _view.DisplayProducts(dataTable);
        }

        private void FetchProductsWithFilters(object? sender, EventArgs e)
        {
            string query = "SELECT " +
                "bag.name as 'Name', " +
                "brand.name as 'Brand', " +
                "cat.name as 'Category', " +
                "size.value as 'Size' " +
                "FROM Bags bag " +
                "LEFT JOIN Brands brand ON brand.id = bag.fk_brand_id " +
                "LEFT JOIN Categories cat ON cat.id = bag.fk_category_id " +
                "LEFT JOIN Sizes size ON size.id = bag.fk_size_id " +
                "WHERE bag.isActive = 1";

            if (_view.NameFilter != "" && _view.NameFilter != null)
            {
                query += $" AND bag.name = '{_view.NameFilter}'";
            }
            if (_view.BrandFilter != "" && _view.BrandFilter != null)
            {
                query += $" AND bag.fk_brand_id = {BrandsHelper.GetBrandId(_view.BrandFilter)}";
            }
            if (_view.CategoryFilter != "" && _view.CategoryFilter != null)
            {
                query += $" AND bag.fk_category_id = {CategoriesHelper.GetCategoryId(_view.CategoryFilter)}";
            }
            if (_view.SizeFilter != "" && _view.SizeFilter != null)
            {
                query += $" AND bag.fk_size_id = {SizesHelper.GetSizeId(_view.SizeFilter)}";
            }

            DataTable dataTable = DatabaseHelper.ExecuteReader(query, null);
            _view.DisplayProductsWithFilters(dataTable);
        }

        private void FetchSizesCB(object? sender, EventArgs e)
        {
            SizesHelper.LoadSizeData(_view);

        }

        private void FetchBrandsCB(object? sender, EventArgs e)
        {
            BrandsHelper.LoadBrandsData(_view);
        }

        private void FetchCategoriesCB(object? sender, EventArgs e)
        {
            CategoriesHelper.LoadCategoriesData(_view);
        }
    }
}