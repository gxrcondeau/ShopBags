namespace ShopBags.Views
{
    public interface IAuthView
    {
        event EventHandler Login;
        event EventHandler Register;

        string Email { get; }
        string Password { get; }
        string Name { get; }

        void ShowError(string message);
        void ShowInfo(string message);
    }

    public partial class AuthView : Form, IAuthView
    {
        private bool isRegistering = false;

        public AuthView()
        {
            InitializeComponent();
        }

        public string Email => txtEmail.Text;
        public string Password => txtPassword.Text;
        public string Name => txtName.Text;

        public event EventHandler Login;
        public event EventHandler Register;

        public void ShowError(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ShowInfo(string message)
        {
            MessageBox.Show(message, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login?.Invoke(this, EventArgs.Empty);
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Register?.Invoke(this, EventArgs.Empty);
        }

        private void AuthView_Load(object sender, EventArgs e)
        {

        }

        private void btnChangeAuthAction_Click(object sender, EventArgs e)
        {
            ChangeAuthAction();
        }

        public void ChangeAuthAction()
        {
            if (!isRegistering)
            {
                btnLogin.Visible = false;
                btnRegister.Visible = true;
                btnChangeAuthAction.Text = "Already have account? Login";
                lblAuthAction.Text = "Register";
                txtName.Visible = true;
                lblName.Visible = true;

                isRegistering = true;
            }
            else
            {
                btnLogin.Visible = true;
                btnRegister.Visible = false;
                btnChangeAuthAction.Text = "Don't have account? Register";
                lblAuthAction.Text = "Login";
                txtName.Visible = false;
                lblName.Visible = false;

                isRegistering = false;
            }
        }
    }
}
