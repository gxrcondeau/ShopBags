using ShopBags.Helpers;
using ShopBags.Sessions;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ShopBags.Views
{
    public interface IPanelView
    {
        event EventHandler FetchBrands;
        event EventHandler UpdateBrands;
        event EventHandler CreateBrand;
        event EventHandler FetchCategories;
        event EventHandler UpdateCategories;
        event EventHandler CreateCategory;
        event EventHandler FetchUsers;
        event EventHandler UpdateUsers;
        event EventHandler FetchProducts;
        event EventHandler UpdateProducts;
        event EventHandler CreateProduct;
        event EventHandler FetchSizes;
        event EventHandler FetchBrandsHelper;
        event EventHandler FetchCategoriesHelper;

        string BrandTitle { get; }
        string CategoryTitle {  get; }
        string ProductTitle {  get; }
        string ProductSize {  get; }
        string ProductBrand {  get; }
        string ProductCategory {  get; }

        void ShowError(string message);
        void ShowInfo(string message);
    }

    public partial class PanelView : Form, IPanelView
    {
        public PanelView()
        {
            InitializeComponent();
        }

        public string BrandTitle => txtNewBrand.Text;
        public string CategoryTitle => txtNewCategory.Text;
        public string ProductTitle => txtNewProduct.Text;
        public string ProductSize => cbNewProductSize.Text;
        public string ProductBrand => cbNewProductBrand.Text;
        public string ProductCategory => cbNewProductCategory.Text;

        public event EventHandler FetchBrands;
        public event EventHandler UpdateBrands;
        public event EventHandler CreateBrand;
        public event EventHandler FetchCategories;
        public event EventHandler UpdateCategories;
        public event EventHandler CreateCategory;
        public event EventHandler FetchUsers;
        public event EventHandler UpdateUsers;
        public event EventHandler FetchProducts;
        public event EventHandler UpdateProducts;
        public event EventHandler CreateProduct;
        public event EventHandler FetchSizes;
        public event EventHandler FetchBrandsHelper;
        public event EventHandler FetchCategoriesHelper;

        public void ShowError(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ShowInfo(string message)
        {
            MessageBox.Show(message, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void PanelView_Load(object sender, EventArgs e)
        {
            FetchBrands?.Invoke(this, EventArgs.Empty);
            if (!UserSession.Instance.isAdmin)
            {
                tcPanel.TabPages.Remove(tabPage5);
            }
        }

        private void tcPanel_TabIndexChanged(object sender, EventArgs e)
        {
            switch (tcPanel.SelectedIndex)
            {
                case 0:
                    FetchBrands?.Invoke(this, EventArgs.Empty);
                    break;
                case 1:
                    FetchCategories?.Invoke(this, EventArgs.Empty);
                    break;
                case 2:
                    FetchSizes?.Invoke(this, EventArgs.Empty);
                    FetchBrandsHelper?.Invoke(this, EventArgs.Empty);
                    FetchCategoriesHelper?.Invoke(this, EventArgs.Empty);
                    FetchProducts?.Invoke(this, EventArgs.Empty);
                    break;
                case 4:
                    FetchUsers?.Invoke(this, EventArgs.Empty);
                    break;
                default:
                    break;
            }
        }

        private void DeleteColumn(string column)
        {
            if (dgvProducts.Columns.Cast<DataGridViewColumn>().Any(col => col.Name == column))
            {
                dgvProducts.Columns.Remove(dgvProducts.Columns[column]);
            }

        }

        private void AddColumn(DataGridViewComboBoxColumn column)
        {
            if (!dgvProducts.Columns.Cast<DataGridViewColumn>().Any(col => col.Name == column.Name))
            {
                dgvProducts.Columns.Add(column);
            }
        }

        // Brands methods
        public void DisplayBrands(DataTable dataTable)
        {
            dgvBrands.DataSource = dataTable;
            dgvBrands.Columns[0].HeaderText = "ID";
            dgvBrands.Columns[1].HeaderText = "Name";
            dgvBrands.Columns[2].HeaderText = "Active";
        }

        private void btnCreateBrand_Click(object sender, EventArgs e)
        {
            CreateBrand?.Invoke(this, EventArgs.Empty);
        }

        private void dgvBrands_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            UpdateBrands?.Invoke(this, EventArgs.Empty);
        }

        private void btnUpdateBrands_Click(object sender, EventArgs e)
        {
            FetchBrands?.Invoke(this, EventArgs.Empty);
        }

        // Categories methods
        public void DisplayCategories(DataTable dataTable)
        {
            dgvCategories.DataSource = dataTable;
            dgvCategories.Columns[0].HeaderText = "ID";
            dgvCategories.Columns[1].HeaderText = "Name";
            dgvCategories.Columns[2].HeaderText = "Active";
        }

        private void btnCreateCategory_Click(object sender, EventArgs e)
        {
            CreateCategory?.Invoke(this, EventArgs.Empty);
        }

        private void dgvCategories_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            UpdateCategories?.Invoke(this, EventArgs.Empty);
        }

        private void btnUpdateCategories_Click(object sender, EventArgs e)
        {
            FetchCategories?.Invoke(this, EventArgs.Empty);
        }

        // Users methods
        public void DisplayUsers(DataTable dataTable)
        {
            dgvUsers.DataSource = dataTable;
            dgvUsers.Columns[0].HeaderText = "ID";
            dgvUsers.Columns[1].HeaderText = "Name";
            dgvUsers.Columns[2].HeaderText = "Email";
            dgvUsers.Columns[3].HeaderText = "isActive";
            dgvUsers.Columns[4].HeaderText = "Role";
            dgvUsers.Columns[4].ReadOnly = true;
        }

        private void dgvUsers_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            UpdateUsers?.Invoke(this, EventArgs.Empty);
        }

        private void btnUpdateUsers_Click(object sender, EventArgs e)
        {
            FetchUsers?.Invoke(this, EventArgs.Empty);
        }

        // Product methods
        public void DisplayProducts(DataTable dataTable)
        {
            DataGridViewComboBoxColumn sizeColumn = new DataGridViewComboBoxColumn
            {
                Name = "SizeColumn",
                HeaderText = "Size",
                DataPropertyName = "SizeId", // Name of the property in your data source (Bag class's SizeId)
                DisplayMember = "Value", // Displayed in the ComboBox
                ValueMember = "Id", // Value associated with the selected item
            };

            DataGridViewComboBoxColumn brandColumn = new DataGridViewComboBoxColumn
            {
                Name = "BrandColumn",
                HeaderText = "Brand",
                DataPropertyName = "BrandId", // Name of the property in your data source (Bag class's SizeId)
                DisplayMember = "Name", // Displayed in the ComboBox
                ValueMember = "Id", // Value associated with the selected item
            };

            DataGridViewComboBoxColumn categoryColumn = new DataGridViewComboBoxColumn
            {
                Name = "CategoryColumn",
                HeaderText = "Category",
                DataPropertyName = "CategoryId", // Name of the property in your data source (Bag class's SizeId)
                DisplayMember = "Name", // Displayed in the ComboBox
                ValueMember = "Id", // Value associated with the selected item
            };

            SizesHelper.LoadSizeData(sizeColumn);
            BrandsHelper.LoadBrandData(brandColumn);
            CategoriesHelper.LoadCategoriesData(categoryColumn);

            dgvProducts.DataSource = dataTable;

            if (!AppSession.Instance.isDebug)
            {
                DeleteColumn("Value");
                DeleteColumn("SizeId");
                DeleteColumn("Brand");
                DeleteColumn("BrandId");
                DeleteColumn("Category");
                DeleteColumn("CategoryId");
            }

            AddColumn(sizeColumn);
            AddColumn(brandColumn);
            AddColumn(categoryColumn);
        }

        private void btnCreateProduct_Click(object sender, EventArgs e)
        {
            CreateProduct?.Invoke(this, EventArgs.Empty);
        }

        private void dgvProducts_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            UpdateProducts?.Invoke(this, EventArgs.Empty);
        }

        private void btnUpdateProducts_Click(object sender, EventArgs e)
        {
            FetchSizes?.Invoke(this, EventArgs.Empty);
            FetchBrands?.Invoke(this, EventArgs.Empty);
            FetchCategories?.Invoke(this, EventArgs.Empty);
            FetchBrandsHelper?.Invoke(this, EventArgs.Empty);
            FetchCategoriesHelper?.Invoke(this, EventArgs.Empty);
            FetchProducts?.Invoke(this, EventArgs.Empty);
        }

        public void DisplaySizesCB(List<Models.Size> sizes)
        {
            foreach (Models.Size item in sizes)
            {
                cbNewProductSize.Items.Add(item.Value.ToString());
            }
        }

        public void DisplayBrandsCB(List<Models.Brand> brands)
        {
            foreach (Models.Brand item in brands)
            {
                cbNewProductBrand.Items.Add(item.Name.ToString());
            }
        }

        public void DisplayCategoriesCB(List<Models.Category> categories)
        {
            foreach (Models.Category item in categories)
            {
                cbNewProductCategory.Items.Add(item.Name.ToString());
            }
        }

        private void btnForceUpdate_Click(object sender, EventArgs e)
        {
            UpdateProducts?.Invoke(this, EventArgs.Empty);
        }
    }
}
