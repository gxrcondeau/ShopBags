using ShopBags.Helpers;
using ShopBags.Sessions;
using ShopBags.Views;
using System.Data;

namespace ShopBags.Controllers
{
    internal class CartController
    {
        private readonly CartView _view;

        public CartController(CartView cartView)
        {
            _view = cartView;
            WireUpEvents();
        }

        private void WireUpEvents()
        {
            _view.FetchOrders += FetchOrders;
        }

        private void FetchOrders(object? sender, EventArgs e)
        {
            string query = "SELECT " +
                "o.id as 'ID', " +
                "status.value as 'Status', " +
                "bag.name as 'Product' " +
                "FROM Orders o " +
                "LEFT JOIN Status status ON status.id = o.fk_status_id " +
                "LEFT JOIN Bags bag ON bag.id = o.fk_bag_id " +
                $"WHERE o.fk_user_id = {UserSession.Instance.id}";

            DataTable dataTable = DatabaseHelper.ExecuteReader(query, null);

            _view.DisplayOrders(dataTable);
        }
    }
}
