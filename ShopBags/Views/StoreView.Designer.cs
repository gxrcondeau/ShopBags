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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            dgvStore = new DataGridView();
            panel1 = new Panel();
            btnShowCart = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnApplyFilters = new Button();
            txtNameFilter = new TextBox();
            cbSizeFilter = new ComboBox();
            label4 = new Label();
            cbBrandFilter = new ComboBox();
            label3 = new Label();
            cbCategoryFilter = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            btnPanel = new Button();
            imgUserIcon = new PictureBox();
            lblEmail = new Label();
            lblUsername = new Label();
            btnResetFilters = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvStore).BeginInit();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgUserIcon).BeginInit();
            SuspendLayout();
            // 
            // dgvStore
            // 
            dgvStore.BackgroundColor = SystemColors.ButtonFace;
            dgvStore.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.ButtonFace;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvStore.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvStore.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStore.Dock = DockStyle.Right;
            dgvStore.GridColor = Color.Gray;
            dgvStore.Location = new Point(199, 0);
            dgvStore.Name = "dgvStore";
            dgvStore.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvStore.RowTemplate.Height = 30;
            dgvStore.Size = new Size(1065, 681);
            dgvStore.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnShowCart);
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(btnResetFilters);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(199, 681);
            panel1.TabIndex = 1;
            // 
            // btnShowCart
            // 
            btnShowCart.BackgroundImage = Assets.Resource.icon_cart;
            btnShowCart.BackgroundImageLayout = ImageLayout.Zoom;
            btnShowCart.Dock = DockStyle.Bottom;
            btnShowCart.Location = new Point(0, 622);
            btnShowCart.Margin = new Padding(10);
            btnShowCart.Name = "btnShowCart";
            btnShowCart.Padding = new Padding(10);
            btnShowCart.Size = new Size(199, 59);
            btnShowCart.TabIndex = 5;
            btnShowCart.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(btnApplyFilters, 0, 9);
            tableLayoutPanel1.Controls.Add(txtNameFilter, 0, 2);
            tableLayoutPanel1.Controls.Add(cbSizeFilter, 0, 8);
            tableLayoutPanel1.Controls.Add(label4, 0, 7);
            tableLayoutPanel1.Controls.Add(cbBrandFilter, 0, 6);
            tableLayoutPanel1.Controls.Add(label3, 0, 5);
            tableLayoutPanel1.Controls.Add(cbCategoryFilter, 0, 4);
            tableLayoutPanel1.Controls.Add(label2, 0, 3);
            tableLayoutPanel1.Controls.Add(label1, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 102);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 10;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.Size = new Size(199, 283);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // btnApplyFilters
            // 
            btnApplyFilters.Dock = DockStyle.Fill;
            btnApplyFilters.Location = new Point(3, 255);
            btnApplyFilters.Name = "btnApplyFilters";
            btnApplyFilters.Size = new Size(193, 25);
            btnApplyFilters.TabIndex = 6;
            btnApplyFilters.Text = "Filter";
            btnApplyFilters.UseVisualStyleBackColor = true;
            btnApplyFilters.Click += btnApplyFilters_Click;
            // 
            // txtNameFilter
            // 
            txtNameFilter.Dock = DockStyle.Fill;
            txtNameFilter.Location = new Point(3, 59);
            txtNameFilter.Name = "txtNameFilter";
            txtNameFilter.Size = new Size(193, 23);
            txtNameFilter.TabIndex = 7;
            // 
            // cbSizeFilter
            // 
            cbSizeFilter.Dock = DockStyle.Fill;
            cbSizeFilter.FormattingEnabled = true;
            cbSizeFilter.Location = new Point(3, 227);
            cbSizeFilter.Name = "cbSizeFilter";
            cbSizeFilter.Size = new Size(193, 23);
            cbSizeFilter.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Location = new Point(3, 196);
            label4.Name = "label4";
            label4.Size = new Size(193, 28);
            label4.TabIndex = 14;
            label4.Text = "Size";
            label4.TextAlign = ContentAlignment.BottomLeft;
            // 
            // cbBrandFilter
            // 
            cbBrandFilter.Dock = DockStyle.Fill;
            cbBrandFilter.FormattingEnabled = true;
            cbBrandFilter.Location = new Point(3, 171);
            cbBrandFilter.Name = "cbBrandFilter";
            cbBrandFilter.Size = new Size(193, 23);
            cbBrandFilter.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Location = new Point(3, 140);
            label3.Name = "label3";
            label3.Size = new Size(193, 28);
            label3.TabIndex = 13;
            label3.Text = "Brand";
            label3.TextAlign = ContentAlignment.BottomLeft;
            // 
            // cbCategoryFilter
            // 
            cbCategoryFilter.Dock = DockStyle.Fill;
            cbCategoryFilter.FormattingEnabled = true;
            cbCategoryFilter.Location = new Point(3, 115);
            cbCategoryFilter.Name = "cbCategoryFilter";
            cbCategoryFilter.Size = new Size(193, 23);
            cbCategoryFilter.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Location = new Point(3, 84);
            label2.Name = "label2";
            label2.Size = new Size(193, 28);
            label2.TabIndex = 12;
            label2.Text = "Category";
            label2.TextAlign = ContentAlignment.BottomLeft;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(3, 28);
            label1.Name = "label1";
            label1.Size = new Size(193, 28);
            label1.TabIndex = 11;
            label1.Text = "Bag name";
            label1.TextAlign = ContentAlignment.BottomLeft;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 192, 192);
            panel2.Controls.Add(btnPanel);
            panel2.Controls.Add(imgUserIcon);
            panel2.Controls.Add(lblEmail);
            panel2.Controls.Add(lblUsername);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(199, 102);
            panel2.TabIndex = 3;
            // 
            // btnPanel
            // 
            btnPanel.Location = new Point(3, 66);
            btnPanel.Name = "btnPanel";
            btnPanel.Size = new Size(92, 23);
            btnPanel.TabIndex = 3;
            btnPanel.Text = "Admin Panel";
            btnPanel.UseVisualStyleBackColor = true;
            btnPanel.Visible = false;
            btnPanel.Click += btnPanel_Click;
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
            // btnResetFilters
            // 
            btnResetFilters.Location = new Point(3, 388);
            btnResetFilters.Name = "btnResetFilters";
            btnResetFilters.Size = new Size(190, 22);
            btnResetFilters.TabIndex = 15;
            btnResetFilters.Text = "Reset filters";
            btnResetFilters.UseVisualStyleBackColor = true;
            btnResetFilters.Click += btnResetFilters_Click;
            // 
            // StoreView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 681);
            Controls.Add(panel1);
            Controls.Add(dgvStore);
            Name = "StoreView";
            Text = "StoreView";
            FormClosed += StoreView_FormClosed;
            Load += StoreView_Load;
            ((System.ComponentModel.ISupportInitialize)dgvStore).EndInit();
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imgUserIcon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvStore;
        private Panel panel1;
        private PictureBox imgUserIcon;
        private Label lblEmail;
        private Label lblUsername;
        private Panel panel2;
        private Button btnPanel;
        private TableLayoutPanel tableLayoutPanel1;
        private ComboBox cbSize;
        private Button btnShowCart;
        private Button btnApplyFilters;
        private TextBox txtNameFilter;
        private ComboBox cbCategoryFilter;
        private ComboBox cbBrandFilter;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox cbSizeFilter;
        private Button btnResetFilters;
    }
}