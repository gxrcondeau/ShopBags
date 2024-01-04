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
            btnUpdateBrands = new Button();
            txtNewBrand = new TextBox();
            btnCreateBrand = new Button();
            dgvBrands = new DataGridView();
            brandBindingSource = new BindingSource(components);
            tabPage2 = new TabPage();
            txtNewCategory = new TextBox();
            btnCreateCategory = new Button();
            dgvCategories = new DataGridView();
            tabPage3 = new TabPage();
            tabPage4 = new TabPage();
            tabPage5 = new TabPage();
            btnUpdateCategories = new Button();
            tcPanel.SuspendLayout();
            tabBrands.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBrands).BeginInit();
            ((System.ComponentModel.ISupportInitialize)brandBindingSource).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategories).BeginInit();
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
            txtNewBrand.Location = new Point(89, 21);
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
            // txtNewCategory
            // 
            txtNewCategory.Location = new Point(89, 20);
            txtNewCategory.MinimumSize = new Size(0, 24);
            txtNewCategory.Name = "txtNewCategory";
            txtNewCategory.Size = new Size(100, 24);
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
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1256, 653);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Products";
            tabPage3.UseVisualStyleBackColor = true;
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
            tabPage5.Location = new Point(4, 24);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(3);
            tabPage5.Size = new Size(1256, 653);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "Users";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // btnUpdateCategories
            // 
            btnUpdateCategories.Image = (Image)resources.GetObject("btnUpdateBrands.Image");
            btnUpdateCategories.Location = new Point(1212, 20);
            btnUpdateCategories.MinimumSize = new Size(32, 32);
            btnUpdateCategories.Name = "btnUpdateCategories";
            btnUpdateCategories.Size = new Size(32, 32);
            btnUpdateCategories.TabIndex = 6;
            btnUpdateCategories.UseVisualStyleBackColor = true;
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
    }
}