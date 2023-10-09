namespace ProductCRUD
{
    partial class ProductForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblId = new Label();
            lblProductName = new Label();
            lblProductCode = new Label();
            lblPrice = new Label();
            lblCategoryId = new Label();
            txtId = new TextBox();
            txtProductCode = new TextBox();
            txtPrice = new TextBox();
            txtProductName = new TextBox();
            dgvListProducts = new DataGridView();
            btnCreate = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            cbCategory = new ComboBox();
            btnExit = new Button();
            txtSearch = new TextBox();
            btnSearch = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvListProducts).BeginInit();
            SuspendLayout();
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(12, 77);
            lblId.Name = "lblId";
            lblId.Size = new Size(28, 25);
            lblId.TabIndex = 0;
            lblId.Text = "Id";
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Location = new Point(12, 114);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(126, 25);
            lblProductName.TabIndex = 1;
            lblProductName.Text = "Product Name";
            // 
            // lblProductCode
            // 
            lblProductCode.AutoSize = true;
            lblProductCode.Location = new Point(12, 151);
            lblProductCode.Name = "lblProductCode";
            lblProductCode.Size = new Size(121, 25);
            lblProductCode.TabIndex = 2;
            lblProductCode.Text = "Product Code";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(12, 188);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(49, 25);
            lblPrice.TabIndex = 4;
            lblPrice.Text = "Price";
            // 
            // lblCategoryId
            // 
            lblCategoryId.AutoSize = true;
            lblCategoryId.Location = new Point(12, 225);
            lblCategoryId.Name = "lblCategoryId";
            lblCategoryId.Size = new Size(105, 25);
            lblCategoryId.TabIndex = 5;
            lblCategoryId.Text = "Category Id";
            // 
            // txtId
            // 
            txtId.Location = new Point(144, 71);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(222, 31);
            txtId.TabIndex = 6;
            // 
            // txtProductCode
            // 
            txtProductCode.Location = new Point(144, 145);
            txtProductCode.Name = "txtProductCode";
            txtProductCode.Size = new Size(222, 31);
            txtProductCode.TabIndex = 7;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(144, 182);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(222, 31);
            txtPrice.TabIndex = 9;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(144, 108);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(222, 31);
            txtProductName.TabIndex = 12;
            // 
            // dgvListProducts
            // 
            dgvListProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListProducts.Location = new Point(392, 31);
            dgvListProducts.Name = "dgvListProducts";
            dgvListProducts.RowHeadersWidth = 62;
            dgvListProducts.RowTemplate.Height = 33;
            dgvListProducts.Size = new Size(961, 508);
            dgvListProducts.TabIndex = 13;
            dgvListProducts.CellDoubleClick += dgvListProducts_CellContentDoubleClick;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(136, 273);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(112, 34);
            btnCreate.TabIndex = 14;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Enabled = false;
            btnUpdate.Location = new Point(254, 273);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(112, 34);
            btnUpdate.TabIndex = 15;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Enabled = false;
            btnDelete.Location = new Point(254, 313);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 34);
            btnDelete.TabIndex = 16;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // cbCategory
            // 
            cbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCategory.FormattingEnabled = true;
            cbCategory.Location = new Point(144, 225);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(222, 33);
            cbCategory.TabIndex = 17;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(1262, 547);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(112, 34);
            btnExit.TabIndex = 18;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(12, 31);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(236, 31);
            txtSearch.TabIndex = 19;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(254, 31);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(112, 34);
            btnSearch.TabIndex = 20;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // ProductForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1392, 590);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(btnExit);
            Controls.Add(cbCategory);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnCreate);
            Controls.Add(dgvListProducts);
            Controls.Add(txtProductName);
            Controls.Add(txtPrice);
            Controls.Add(txtProductCode);
            Controls.Add(txtId);
            Controls.Add(lblCategoryId);
            Controls.Add(lblPrice);
            Controls.Add(lblProductCode);
            Controls.Add(lblProductName);
            Controls.Add(lblId);
            Name = "ProductForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ProductForm";
            ((System.ComponentModel.ISupportInitialize)dgvListProducts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblId;
        private Label lblProductName;
        private Label lblProductCode;
        private Label lblPrice;
        private Label lblCategoryId;
        private TextBox txtId;
        private TextBox txtProductCode;
        private TextBox txtPrice;
        private TextBox txtProductName;
        private DataGridView dgvListProducts;
        private Button btnCreate;
        private Button btnUpdate;
        private Button btnDelete;
        private ComboBox cbCategory;
        private Button btnExit;
        private TextBox txtSearch;
        private Button btnSearch;
    }
}