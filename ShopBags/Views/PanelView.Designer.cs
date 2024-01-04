namespace ShopBags.Views
{
    partial class PanelView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PanelView));
            tcPanel = new TabControl();
            tabBrands = new TabPage();
            label5 = new Label();
            btnUpdateBrands = new Button();
            txtNewBrand = new TextBox();
            btnCreateBrand = new Button();
            dgvBrands = new DataGridView();
            brandBindingSource = new BindingSource(components);
            tabPage2 = new TabPage();
            label6 = new Label();
            btnUpdateCategories = new Button();
            txtNewCategory = new TextBox();
            btnCreateCategory = new Button();
            dgvCategories = new DataGridView();
            tabPage3 = new TabPage();
            btnForceUpdate = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            cbNewProductCategory = new ComboBox();
            cbNewProductBrand = new ComboBox();
            txtNewProduct = new TextBox();
            cbNewProductSize = new ComboBox();
            btnCreateProduct = new Button();
            dgvProducts = new DataGridView();
            tabPage4 = new TabPage();
            tabPage5 = new TabPage();
            dgvUsers = new DataGridView();
            btnUpdateUsers = new Button();
            btnUpdateProducts = new Button();
            tcPanel.SuspendLayout();
            tabBrands.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBrands).BeginInit();
            ((System.ComponentModel.ISupportInitialize)brandBindingSource).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategories).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            SuspendLayout();
            // 
            // tcPanel
            // 
            tcPanel.Controls.Add(tabBrands);
            tcPanel.Controls.Add(tabPage2);
            tcPanel.Controls.Add(tabPage3);
            tcPanel.Controls.Add(tabPage4);
            tcPanel.Controls.Add(tabPage5);
            tcPanel.Dock = DockStyle.Fill;
            tcPanel.Location = new Point(0, 0);
            tcPanel.Name = "tcPanel";
            tcPanel.SelectedIndex = 0;
            tcPanel.Size = new Size(1264, 681);
            tcPanel.TabIndex = 0;
            tcPanel.SelectedIndexChanged += tcPanel_TabIndexChanged;
            tcPanel.TabIndexChanged += tcPanel_TabIndexChanged;
            // 
            // tabBrands
            // 
            tabBrands.Controls.Add(label5);
            tabBrands.Controls.Add(btnUpdateBrands);
            tabBrands.Controls.Add(txtNewBrand);
            tabBrands.Controls.Add(btnCreateBrand);
            tabBrands.Controls.Add(dgvBrands);
            tabBrands.Location = new Point(4, 24);
            tabBrands.Name = "tabBrands";
            tabBrands.Padding = new Padding(3);
            tabBrands.Size = new Size(1256, 653);
            tabBrands.TabIndex = 0;
            tabBrands.Text = "Brands";
            tabBrands.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(95, 20);
            label5.MinimumSize = new Size(0, 24);
            label5.Name = "label5";
            label5.Size = new Size(39, 24);
            label5.TabIndex = 3;
            label5.Text = "Name";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnUpdateBrands
            // 
            btnUpdateBrands.Image = (Image)resources.GetObject("btnUpdateBrands.Image");
            btnUpdateBrands.Location = new Point(1212, 16);
            btnUpdateBrands.MinimumSize = new Size(32, 32);
            btnUpdateBrands.Name = "btnUpdateBrands";
            btnUpdateBrands.Size = new Size(32, 32);
            btnUpdateBrands.TabIndex = 1;
            btnUpdateBrands.UseVisualStyleBackColor = true;
            btnUpdateBrands.Click += btnUpdateBrands_Click;
            // 
            // txtNewBrand
            // 
            txtNewBrand.Location = new Point(140, 20);
            txtNewBrand.MinimumSize = new Size(0, 24);
            txtNewBrand.Name = "txtNewBrand";
            txtNewBrand.Size = new Size(100, 23);
            txtNewBrand.TabIndex = 2;
            // 
            // btnCreateBrand
            // 
            btnCreateBrand.Location = new Point(8, 20);
            btnCreateBrand.MinimumSize = new Size(0, 24);
            btnCreateBrand.Name = "btnCreateBrand";
            btnCreateBrand.Size = new Size(75, 24);
            btnCreateBrand.TabIndex = 1;
            btnCreateBrand.Text = "Create new";
            btnCreateBrand.UseVisualStyleBackColor = true;
            btnCreateBrand.Click += btnCreateBrand_Click;
            // 
            // dgvBrands
            // 
            dgvBrands.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBrands.DataBindings.Add(new Binding("DataContext", brandBindingSource, "Id", true));
            dgvBrands.Location = new Point(0, 64);
            dgvBrands.Name = "dgvBrands";
            dgvBrands.Size = new Size(1244, 587);
            dgvBrands.TabIndex = 0;
            dgvBrands.CellEndEdit += dgvBrands_CellEndEdit;
            // 
            // brandBindingSource
            // 
            brandBindingSource.DataSource = typeof(Models.Brand);
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(btnUpdateCategories);
            tabPage2.Controls.Add(txtNewCategory);
            tabPage2.Controls.Add(btnCreateCategory);
            tabPage2.Controls.Add(dgvCategories);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1256, 653);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Categories";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(95, 20);
            label6.MinimumSize = new Size(0, 24);
            label6.Name = "label6";
            label6.Size = new Size(39, 24);
            label6.TabIndex = 7;
            label6.Text = "Name";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnUpdateCategories
            // 
            btnUpdateCategories.Image = (Image)resources.GetObject("btnUpdateCategories.Image");
            btnUpdateCategories.Location = new Point(1212, 16);
            btnUpdateCategories.MinimumSize = new Size(32, 32);
            btnUpdateCategories.Name = "btnUpdateCategories";
            btnUpdateCategories.Size = new Size(32, 32);
            btnUpdateCategories.TabIndex = 6;
            btnUpdateCategories.UseVisualStyleBackColor = true;
            btnUpdateCategories.Click += btnUpdateCategories_Click;
            // 
            // txtNewCategory
            // 
            txtNewCategory.Location = new Point(140, 20);
            txtNewCategory.MinimumSize = new Size(0, 24);
            txtNewCategory.Name = "txtNewCategory";
            txtNewCategory.Size = new Size(100, 23);
            txtNewCategory.TabIndex = 5;
            // 
            // btnCreateCategory
            // 
            btnCreateCategory.Location = new Point(8, 20);
            btnCreateCategory.MinimumSize = new Size(0, 24);
            btnCreateCategory.Name = "btnCreateCategory";
            btnCreateCategory.Size = new Size(75, 24);
            btnCreateCategory.TabIndex = 4;
            btnCreateCategory.Text = "Create new";
            btnCreateCategory.UseVisualStyleBackColor = true;
            btnCreateCategory.Click += btnCreateCategory_Click;
            // 
            // dgvCategories
            // 
            dgvCategories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategories.DataBindings.Add(new Binding("DataContext", brandBindingSource, "Id", true));
            dgvCategories.Location = new Point(0, 64);
            dgvCategories.Name = "dgvCategories";
            dgvCategories.Size = new Size(1244, 587);
            dgvCategories.TabIndex = 3;
            dgvCategories.CellEndEdit += dgvCategories_CellEndEdit;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(btnUpdateProducts);
            tabPage3.Controls.Add(btnForceUpdate);
            tabPage3.Controls.Add(label4);
            tabPage3.Controls.Add(label3);
            tabPage3.Controls.Add(label2);
            tabPage3.Controls.Add(label1);
            tabPage3.Controls.Add(cbNewProductCategory);
            tabPage3.Controls.Add(cbNewProductBrand);
            tabPage3.Controls.Add(txtNewProduct);
            tabPage3.Controls.Add(cbNewProductSize);
            tabPage3.Controls.Add(btnCreateProduct);
            tabPage3.Controls.Add(dgvProducts);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1256, 653);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Products";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnForceUpdate
            // 
            btnForceUpdate.Location = new Point(1111, 20);
            btnForceUpdate.Name = "btnForceUpdate";
            btnForceUpdate.Size = new Size(95, 23);
            btnForceUpdate.TabIndex = 10;
            btnForceUpdate.Text = "Force update";
            btnForceUpdate.UseVisualStyleBackColor = true;
            btnForceUpdate.Click += btnForceUpdate_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(616, 20);
            label4.MinimumSize = new Size(0, 24);
            label4.Name = "label4";
            label4.Size = new Size(55, 24);
            label4.TabIndex = 9;
            label4.Text = "Category";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(431, 20);
            label3.MinimumSize = new Size(0, 24);
            label3.Name = "label3";
            label3.Size = new Size(38, 24);
            label3.TabIndex = 8;
            label3.Text = "Brand";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(256, 20);
            label2.MinimumSize = new Size(0, 24);
            label2.Name = "label2";
            label2.Size = new Size(27, 24);
            label2.TabIndex = 7;
            label2.Text = "Size";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(95, 20);
            label1.MinimumSize = new Size(0, 24);
            label1.Name = "label1";
            label1.Size = new Size(39, 24);
            label1.TabIndex = 6;
            label1.Text = "Name";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cbNewProductCategory
            // 
            cbNewProductCategory.FormattingEnabled = true;
            cbNewProductCategory.Location = new Point(677, 20);
            cbNewProductCategory.Name = "cbNewProductCategory";
            cbNewProductCategory.Size = new Size(121, 23);
            cbNewProductCategory.TabIndex = 5;
            // 
            // cbNewProductBrand
            // 
            cbNewProductBrand.FormattingEnabled = true;
            cbNewProductBrand.Location = new Point(476, 20);
            cbNewProductBrand.Name = "cbNewProductBrand";
            cbNewProductBrand.Size = new Size(121, 23);
            cbNewProductBrand.TabIndex = 4;
            // 
            // txtNewProduct
            // 
            txtNewProduct.Location = new Point(140, 20);
            txtNewProduct.MinimumSize = new Size(100, 24);
            txtNewProduct.Name = "txtNewProduct";
            txtNewProduct.Size = new Size(100, 23);
            txtNewProduct.TabIndex = 3;
            // 
            // cbNewProductSize
            // 
            cbNewProductSize.FormattingEnabled = true;
            cbNewProductSize.Location = new Point(291, 20);
            cbNewProductSize.Name = "cbNewProductSize";
            cbNewProductSize.Size = new Size(121, 23);
            cbNewProductSize.TabIndex = 2;
            // 
            // btnCreateProduct
            // 
            btnCreateProduct.Location = new Point(8, 20);
            btnCreateProduct.MinimumSize = new Size(0, 24);
            btnCreateProduct.Name = "btnCreateProduct";
            btnCreateProduct.Size = new Size(75, 24);
            btnCreateProduct.TabIndex = 1;
            btnCreateProduct.Text = "Create new";
            btnCreateProduct.UseVisualStyleBackColor = false;
            btnCreateProduct.Click += btnCreateProduct_Click;
            // 
            // dgvProducts
            // 
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Location = new Point(0, 64);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.Size = new Size(1256, 589);
            dgvProducts.TabIndex = 0;
            dgvProducts.CellEndEdit += dgvProducts_CellEndEdit;
            // 
            // tabPage4
            // 
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(1256, 653);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Orders";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            tabPage5.Controls.Add(dgvUsers);
            tabPage5.Controls.Add(btnUpdateUsers);
            tabPage5.Location = new Point(4, 24);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(3);
            tabPage5.Size = new Size(1256, 653);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "Users";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // dgvUsers
            // 
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsers.Location = new Point(0, 64);
            dgvUsers.Name = "dgvUsers";
            dgvUsers.Size = new Size(1244, 587);
            dgvUsers.TabIndex = 5;
            dgvUsers.CellEndEdit += dgvUsers_CellEndEdit;
            // 
            // btnUpdateUsers
            // 
            btnUpdateUsers.Image = (Image)resources.GetObject("btnUpdateUsers.Image");
            btnUpdateUsers.Location = new Point(1212, 16);
            btnUpdateUsers.MinimumSize = new Size(32, 32);
            btnUpdateUsers.Name = "btnUpdateUsers";
            btnUpdateUsers.Size = new Size(32, 32);
            btnUpdateUsers.TabIndex = 4;
            btnUpdateUsers.UseVisualStyleBackColor = true;
            btnUpdateUsers.Click += btnUpdateUsers_Click;
            // 
            // btnUpdateProducts
            // 
            btnUpdateProducts.Image = (Image)resources.GetObject("btnUpdateProducts.Image");
            btnUpdateProducts.Location = new Point(1212, 16);
            btnUpdateProducts.MinimumSize = new Size(32, 32);
            btnUpdateProducts.Name = "btnUpdateProducts";
            btnUpdateProducts.Size = new Size(32, 32);
            btnUpdateProducts.TabIndex = 11;
            btnUpdateProducts.UseVisualStyleBackColor = true;
            btnUpdateProducts.Click += btnUpdateProducts_Click;
            // 
            // PanelView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 681);
            Controls.Add(tcPanel);
            Name = "PanelView";
            Text = "PanelView";
            Load += PanelView_Load;
            tcPanel.ResumeLayout(false);
            tabBrands.ResumeLayout(false);
            tabBrands.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBrands).EndInit();
            ((System.ComponentModel.ISupportInitialize)brandBindingSource).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategories).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tcPanel;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private TabPage tabBrands;
        public DataGridView dgvBrands;
        private Button btnCreateBrand;
        private TextBox txtNewBrand;
        private BindingSource brandBindingSource;
        private Button btnUpdateBrands;
        private TextBox txtNewCategory;
        private Button btnCreateCategory;
        public DataGridView dgvCategories;
        private Button btnUpdateCategories;
        private Button btnUpdateUsers;
        public DataGridView dgvUsers;
        public DataGridView dgvProducts;
        private TextBox txtNewProduct;
        private ComboBox cbNewProductSize;
        private Button btnCreateProduct;
        private ComboBox cbNewProductCategory;
        private ComboBox cbNewProductBrand;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label5;
        private Label label6;
        private Button btnForceUpdate;
        private Button btnUpdateProducts;
    }
}