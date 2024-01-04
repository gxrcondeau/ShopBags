namespace ShopBags.Views
{
    partial class StoreView
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dataGridView1 = new DataGridView();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descriptionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            Size = new DataGridViewTextBoxColumn();
            Category = new DataGridViewTextBoxColumn();
            Brand = new DataGridViewTextBoxColumn();
            Action = new DataGridViewButtonColumn();
            Count = new DataGridViewComboBoxColumn();
            bagBindingSource2 = new BindingSource(components);
            bagBindingSource = new BindingSource(components);
            bagBindingSource1 = new BindingSource(components);
            panel1 = new Panel();
            panel2 = new Panel();
            imgUserIcon = new PictureBox();
            lblEmail = new Label();
            lblUsername = new Label();
            btnAccount = new Button();
            btnPanel = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bagBindingSource2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bagBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bagBindingSource1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgUserIcon).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.BackgroundColor = SystemColors.ButtonFace;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.ButtonFace;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { nameDataGridViewTextBoxColumn, descriptionDataGridViewTextBoxColumn, Size, Category, Brand, Action, Count });
            dataGridView1.DataSource = bagBindingSource2;
            dataGridView1.Dock = DockStyle.Right;
            dataGridView1.GridColor = Color.Gray;
            dataGridView1.Location = new Point(199, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridView1.RowTemplate.Height = 30;
            dataGridView1.Size = new Size(1065, 681);
            dataGridView1.TabIndex = 0;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // Size
            // 
            Size.HeaderText = "Size";
            Size.Name = "Size";
            Size.ReadOnly = true;
            // 
            // Category
            // 
            Category.HeaderText = "Category";
            Category.Name = "Category";
            Category.ReadOnly = true;
            // 
            // Brand
            // 
            Brand.HeaderText = "Brand";
            Brand.Name = "Brand";
            Brand.ReadOnly = true;
            // 
            // Action
            // 
            Action.HeaderText = "Action";
            Action.Name = "Action";
            Action.ReadOnly = true;
            // 
            // Count
            // 
            Count.HeaderText = "Count";
            Count.Name = "Count";
            Count.ReadOnly = true;
            // 
            // bagBindingSource2
            // 
            bagBindingSource2.DataSource = typeof(Models.Bag);
            // 
            // bagBindingSource
            // 
            bagBindingSource.DataSource = typeof(Models.Bag);
            // 
            // bagBindingSource1
            // 
            bagBindingSource1.DataSource = typeof(Models.Bag);
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(199, 681);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 192, 192);
            panel2.Controls.Add(btnPanel);
            panel2.Controls.Add(btnAccount);
            panel2.Controls.Add(imgUserIcon);
            panel2.Controls.Add(lblEmail);
            panel2.Controls.Add(lblUsername);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(199, 102);
            panel2.TabIndex = 3;
            // 
            // imgUserIcon
            // 
            imgUserIcon.BorderStyle = BorderStyle.FixedSingle;
            imgUserIcon.Image = Assets.Resource.icon_user;
            imgUserIcon.Location = new Point(3, 12);
            imgUserIcon.Name = "imgUserIcon";
            imgUserIcon.Padding = new Padding(3);
            imgUserIcon.Size = new Size(48, 48);
            imgUserIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            imgUserIcon.TabIndex = 0;
            imgUserIcon.TabStop = false;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(57, 12);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(38, 15);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "label1";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(57, 27);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(38, 15);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "label1";
            // 
            // btnAccount
            // 
            btnAccount.Location = new Point(3, 66);
            btnAccount.Name = "btnAccount";
            btnAccount.Size = new Size(92, 23);
            btnAccount.TabIndex = 2;
            btnAccount.Text = "Account";
            btnAccount.UseVisualStyleBackColor = true;
            btnAccount.Click += btnAccount_Click;
            // 
            // btnPanel
            // 
            btnPanel.Location = new Point(101, 66);
            btnPanel.Name = "btnPanel";
            btnPanel.Size = new Size(92, 23);
            btnPanel.TabIndex = 3;
            btnPanel.Text = "Admin Panel";
            btnPanel.UseVisualStyleBackColor = true;
            btnPanel.Visible = false;
            btnPanel.Click += btnPanel_Click;
            // 
            // StoreView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 681);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Name = "StoreView";
            Text = "StoreView";
            FormClosed += StoreView_FormClosed;
            Load += StoreView_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bagBindingSource2).EndInit();
            ((System.ComponentModel.ISupportInitialize)bagBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)bagBindingSource1).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imgUserIcon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Size;
        private DataGridViewTextBoxColumn Category;
        private DataGridViewTextBoxColumn Brand;
        private DataGridViewButtonColumn Action;
        private DataGridViewComboBoxColumn Count;
        private BindingSource bagBindingSource2;
        private BindingSource bagBindingSource;
        private BindingSource bagBindingSource1;
        private Panel panel1;
        private PictureBox imgUserIcon;
        private Label lblEmail;
        private Label lblUsername;
        private Panel panel2;
        private Button btnAccount;
        private Button btnPanel;
    }
}