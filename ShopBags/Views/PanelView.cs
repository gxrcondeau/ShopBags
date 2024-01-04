using System.Data;

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

        string BrandTitle { get; }
        string CategoryTitle {  get; }

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

        public event EventHandler FetchBrands;
        public event EventHandler UpdateBrands;
        public event EventHandler CreateBrand;
        public event EventHandler FetchCategories;
        public event EventHandler UpdateCategories;
        public event EventHandler CreateCategory;

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
        }

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

        private void btnUpdateBrands_Click(object sender, EventArgs e)
        {
            FetchBrands?.Invoke(this, EventArgs.Empty);
        }

        private void dgvBrands_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            UpdateBrands?.Invoke(this, EventArgs.Empty);
        }

        private void btnCreateCategory_Click(object sender, EventArgs e)
        {
            CreateCategory?.Invoke(this, EventArgs.Empty);
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
                default:
                    break;
            }
        }

        public void DisplayCategories(DataTable dataTable)
        {
            dgvCategories.DataSource = dataTable;
            dgvBrands.Columns[0].HeaderText = "ID";
            dgvBrands.Columns[1].HeaderText = "Name";
            dgvBrands.Columns[2].HeaderText = "Active";
        }

    }
}
