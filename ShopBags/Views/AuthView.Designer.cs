namespace ShopBags.Views
{
    partial class AuthView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            btnRegister = new Button();
            txtName = new TextBox();
            lblAuthAction = new Label();
            lblEmail = new Label();
            lblPassword = new Label();
            lblName = new Label();
            btnChangeAuthAction = new Button();
            SuspendLayout();
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.Top;
            txtEmail.Location = new Point(220, 188);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(200, 23);
            txtEmail.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(220, 248);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(200, 23);
            txtPassword.TabIndex = 1;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(220, 363);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(200, 30);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(220, 363);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(200, 30);
            btnRegister.TabIndex = 3;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Visible = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(220, 308);
            txtName.Name = "txtName";
            txtName.Size = new Size(200, 23);
            txtName.TabIndex = 5;
            txtName.Visible = false;
            // 
            // lblAuthAction
            // 
            lblAuthAction.Dock = DockStyle.Top;
            lblAuthAction.Font = new Font("Segoe UI", 48F);
            lblAuthAction.Location = new Point(0, 0);
            lblAuthAction.Name = "lblAuthAction";
            lblAuthAction.Size = new Size(624, 95);
            lblAuthAction.TabIndex = 6;
            lblAuthAction.Text = "Login";
            lblAuthAction.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(220, 170);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(36, 15);
            lblEmail.TabIndex = 7;
            lblEmail.Text = "Email";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(220, 230);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(57, 15);
            lblPassword.TabIndex = 8;
            lblPassword.Text = "Password";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(220, 290);
            lblName.Name = "lblName";
            lblName.Size = new Size(39, 15);
            lblName.TabIndex = 9;
            lblName.Text = "Name";
            lblName.Visible = false;
            // 
            // btnChangeAuthAction
            // 
            btnChangeAuthAction.BackColor = SystemColors.ButtonFace;
            btnChangeAuthAction.FlatAppearance.BorderSize = 0;
            btnChangeAuthAction.FlatStyle = FlatStyle.Flat;
            btnChangeAuthAction.Location = new Point(220, 98);
            btnChangeAuthAction.Name = "btnChangeAuthAction";
            btnChangeAuthAction.Size = new Size(200, 23);
            btnChangeAuthAction.TabIndex = 10;
            btnChangeAuthAction.Text = "Don't have account? Register";
            btnChangeAuthAction.TextAlign = ContentAlignment.MiddleLeft;
            btnChangeAuthAction.UseVisualStyleBackColor = false;
            btnChangeAuthAction.Click += btnChangeAuthAction_Click;
            // 
            // AuthView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(624, 441);
            Controls.Add(btnChangeAuthAction);
            Controls.Add(lblName);
            Controls.Add(lblPassword);
            Controls.Add(lblEmail);
            Controls.Add(btnLogin);
            Controls.Add(txtEmail);
            Controls.Add(txtName);
            Controls.Add(txtPassword);
            Controls.Add(btnRegister);
            Controls.Add(lblAuthAction);
            Text = "AuthView";
            Load += AuthView_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtEmail;
        private TextBox txtPassword;
        private Button btnLogin;
        private Button btnRegister;
        private TextBox txtName;
        private Label lblAuthAction;
        private Label lblEmail;
        private Label lblPassword;
        private Label lblName;
        private Button btnChangeAuthAction;
    }
}