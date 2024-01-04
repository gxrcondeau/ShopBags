using ShopBags.Sessions;

namespace ShopBags.Views
{
    public interface IStoreView
    {
        event EventHandler OpenPanel;
        
        void ShowError(string message);
    }

    public partial class StoreView : Form, IStoreView
    {
        public StoreView()
        {
            InitializeComponent();
        }

        public event EventHandler OpenPanel;

        public void ShowError(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void StoreView_Load(object sender, EventArgs e)
        {

            lblUsername.Text = UserSession.Instance.username;
            lblEmail.Text = UserSession.Instance.email;

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
        }

        private void StoreView_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnPanel_Click(object sender, EventArgs e)
        {
            OpenPanel?.Invoke(this, EventArgs.Empty);
        }
    }
}
