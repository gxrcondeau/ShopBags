using System.Data;

namespace ShopBags.Views
{
    public interface ICartView
    {
        event EventHandler FetchOrders;

        void ShowError(string message);
    }

    public partial class CartView : Form, ICartView
    {
        public event EventHandler FetchOrders;
        public CartView()
        {
            InitializeComponent();
        }
        public void ShowError(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void CartView_Load(object sender, EventArgs e)
        {
            FetchOrders?.Invoke(this, EventArgs.Empty);
        }

        public void DisplayOrders(DataTable dataTable)
        {
            dgvOrders.DataSource = dataTable;
        }
    }
}
