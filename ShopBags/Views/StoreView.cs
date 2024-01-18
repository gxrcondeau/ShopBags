using ShopBags.Sessions;
using System.Data;

namespace ShopBags.Views
{
    public interface IStoreView
    {
        event EventHandler OpenCart;
        event EventHandler OpenPanel;
        event EventHandler FetchProducts;
        event EventHandler FetchProductsWithFilters;
        event EventHandler FetchSizesHelper;
        event EventHandler FetchBrandsHelper;
        event EventHandler FetchCategoriesHelper;
        event DataGridViewCellEventHandler BuyProduct;

        string NameFilter { get; }
        string BrandFilter { get; }
        string CategoryFilter { get; }
        string SizeFilter { get; }
        
        void ShowError(string message);
        void ShowInfo(string message);
    }

    public partial class StoreView : Form, IStoreView
    {
        public StoreView()
        {
            InitializeComponent();
        }

        public string NameFilter => txtNameFilter.Text;
        public string BrandFilter => cbBrandFilter.Text;
        public string CategoryFilter => cbCategoryFilter.Text;
        public string SizeFilter => cbSizeFilter.Text;

        public event EventHandler OpenCart;
        public event EventHandler OpenPanel;
        public event EventHandler FetchProducts;
        public event EventHandler FetchProductsWithFilters;
        public event EventHandler FetchSizesHelper;
        public event EventHandler FetchBrandsHelper;
        public event EventHandler FetchCategoriesHelper;
        public event DataGridViewCellEventHandler BuyProduct;

        public void ShowError(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ShowInfo(string message)
        {
            MessageBox.Show(message, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void StoreView_Load(object sender, EventArgs e)
        {

            lblUsername.Text = UserSession.Instance.username;
            lblEmail.Text = UserSession.Instance.email;
            lblOrdersCounter.Text = UserSession.Instance.ordersCnt.ToString();

            if (lblOrdersCounter.Text == "0")
            {
                lblOrdersCounter.Visible = false;
            }

            // Check if user has admin role and enable access to panel
            if (UserSession.Instance.isAdmin)
            {
                btnPanel.Visible = true;
            }
            else if (UserSession.Instance.isEditor)
            {
                btnPanel.Text = "Editor panel";
                btnPanel.Visible = true;
            }
            else
            {
                btnPanel.Visible = false;
            }

            FetchProducts?.Invoke(this, EventArgs.Empty);
            FetchBrandsHelper?.Invoke(this, EventArgs.Empty);
            FetchSizesHelper?.Invoke(this, EventArgs.Empty);
            FetchCategoriesHelper?.Invoke(this, EventArgs.Empty);
        }

        private void StoreView_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnPanel_Click(object sender, EventArgs e)
        {
            OpenPanel?.Invoke(this, EventArgs.Empty);
        }

        private void btnShowCart_Click(object sender, EventArgs e)
        {
            OpenCart?.Invoke(this, EventArgs.Empty);
        }

        private void DeleteColumn(string column)
        {
            if (dgvStore.Columns.Cast<DataGridViewColumn>().Any(col => col.Name == column))
            {
                dgvStore.Columns.Remove(dgvStore.Columns[column]);
            }

        }

        // Products methods
        public void DisplayProducts(DataTable dataTable)
        {
            dgvStore.DataSource = dataTable;

            dgvStore.Columns["ID"].Visible = false;
            dgvStore.Columns["Action"].DisplayIndex = dgvStore.ColumnCount - 1;

            DeleteColumn("SizeId");
            DeleteColumn("BrandId");
            DeleteColumn("CategoryId");
        }

        public void DisplayProductsWithFilters(DataTable dataTable)
        {
            dgvStore.DataSource = dataTable;

            DeleteColumn("SizeId");
            DeleteColumn("BrandId");
            DeleteColumn("CategoryId");
        }

        public void DisplaySizesCB(List<Models.Size> sizes)
        {
            foreach (Models.Size item in sizes)
            {
                cbSizeFilter.Items.Add(item.Value.ToString());
            }
        }

        public void DisplayBrandsCB(List<Models.Brand> brands)
        {
            foreach (Models.Brand item in brands)
            {
                cbBrandFilter.Items.Add(item.Name.ToString());
            }
        }

        public void DisplayCategoriesCB(List<Models.Category> categories)
        {
            foreach (Models.Category item in categories)
            {
                cbCategoryFilter.Items.Add(item.Name.ToString());
            }
        }

        private void btnApplyFilters_Click(object sender, EventArgs e)
        {
            FetchProductsWithFilters?.Invoke(this, EventArgs.Empty);
        }

        private void btnResetFilters_Click(object sender, EventArgs e)
        {
            txtNameFilter.Text = "";
            FetchProducts?.Invoke(this, EventArgs.Empty);
        }

        private void dgvStore_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            BuyProduct?.Invoke(this, e);
        }
    }
}
