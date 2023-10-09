using Data;
using Data.Models;
using Microsoft.EntityFrameworkCore;

namespace ProductCRUD
{
    public partial class ProductForm : Form
    {
        public ProductRepository ProductRepository;
        public CategoryRepository CategoryRepository;

        public ProductForm()
        {
            CategoryRepository = new CategoryRepository();
            ProductRepository = new ProductRepository();

            InitializeComponent();

            //get all products and category link to its via category id
            LoadData();

            //get all category and add to combobox
            var listCategory = CategoryRepository.GetAll().ToList();
            if (listCategory.Count <= 0) return;
            cbCategory.DataSource = listCategory;
            cbCategory.DisplayMember = "CategoryName";
            cbCategory.ValueMember = "Id";
            //set default value for combobox
            cbCategory.SelectedIndex = 0;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            btnCreate.Enabled = false;

            var (name, code, price) = GetInputData(txtProductName, txtProductCode, txtPrice);
            if (name == "" || code == "" || price == 0)
            {
                btnCreate.Enabled = true;
                return;
            }

            if (cbCategory.SelectedItem is Category category)
            {
                var product = new Product()
                {
                    ProductName = name.Trim(),
                    ProductCode = code.Trim(),
                    Price = price,
                    DateCreate = DateTime.Now,
                    CategoryId = category.Id
                };

                ProductRepository.Add(product);
            }

            LoadData();
            ClearText();
            btnCreate.Enabled = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ControlBtnCreateOn();

            var (name, code, price) = GetInputData(txtProductName, txtProductCode, txtPrice);
            if (name == "" || code == "" || price == 0)
            {
                ControlBtnCreateOff();
                return;
            }

            var id = int.Parse(txtId.Text);
            var product = ProductRepository.GetAll().FirstOrDefault(p => p.Id == id);

            //update data
            if (product != null)
            {
                product.ProductName = name.Trim();
                product.ProductCode = code.Trim();
                product.Price = price;
                //not allow to change date create
                product.CategoryId = (int)cbCategory.SelectedValue;

                ProductRepository.Update(product);
            }

            LoadData();
            ClearText();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show(@"Are you sure?", @"Warning",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (res != DialogResult.Yes) return;
            ControlBtnCreateOn();

            var id = int.Parse(txtId.Text);
            var (name, code, price) = GetInputData(txtProductName, txtProductCode, txtPrice);
            if (name == "" || code == "" || price == 0)
            {
                ControlBtnCreateOn();
                return;
            }

            var product = ProductRepository.GetAll().FirstOrDefault(p => p.Id == id);
            if (product != null)
            {
                ProductRepository.Delete(product);
            }

            LoadData();
            ClearText();
        }

        private void dgvListProducts_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ControlBtnCreateOff();

            // Get all data of selected row and put it to text box
            var row = dgvListProducts.Rows[e.RowIndex];
            txtId.Text = row.Cells[0].Value.ToString();
            txtProductName.Text = row.Cells[1].Value.ToString()?.Trim();
            txtProductCode.Text = row.Cells[2].Value.ToString()?.Trim();
            txtPrice.Text = row.Cells[3].Value.ToString();
            cbCategory.Text = row.Cells[5].Value.ToString();
        }

        private void LoadData()
        {
            var source = new BindingSource();
            source.DataSource = ProductRepository
                .GetAll()
                .Include(p => p.Category)
                .Select(p => new
                {
                    p.Id,
                    p.ProductName,
                    p.ProductCode,
                    p.Price,
                    p.DateCreate,
                    Category = p.Category.CategoryName
                })
                .ToList();

            dgvListProducts.DataSource = source.DataSource;
        }

        private static bool IsValidDecimal(string input)
        {
            //check valid decimal and decimal must larger than 0
            return decimal.TryParse(input, out var result) && result > 0;
        }

        private static bool CheckDecimal(Control txt)
        {
            if (IsValidDecimal(txt.Text) && txt.Text != "") return true;
            ShowErrorMessageBox("Please input decimal data, make sure it > 0 !", txt.Name);
            return false;
        }

        private static bool CheckedTextBox(Control txt)
        {
            //check if text box is empty or have only space
            if (txt.Text.Trim() != "") return true;

            ShowErrorMessageBox("Please input data!", txt.Name);
            return false;
        }

        private static bool CheckProductCode(Control txt)
        {
            //check if product code not null
            if (CheckedTextBox(txt) == false) return false;
            //check if product code have length = 4 characters and not contain any number
            if (txt.Text.Length == 4 && txt.Text.All(char.IsLetter)) return true;
            ShowErrorMessageBox("Product code must have 4 characters and not contain any number!", txt.Name);
            return false;
        }

        private static (string, string, decimal) GetInputData(Control txtProductName, Control txtProductCode,
            Control txtPrice)
        {
            if (CheckedTextBox(txtProductName) == false
                || CheckProductCode(txtProductCode) == false
                || CheckDecimal(txtPrice) == false)
            {
                return ("", "", 0);
            }

            // convert product code to upper case
            txtProductCode.Text = txtProductCode.Text.ToUpper();

            return (txtProductName.Text, txtProductCode.Text, decimal.Parse(txtPrice.Text));
        }

        private static void ShowErrorMessageBox(string message, string errorLocation)
        {
            MessageBox.Show("Error at " + errorLocation + "\n" + message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ClearText()
        {
            txtId.Text = "";
            txtProductName.Text = "";
            txtProductCode.Text = "";
            txtPrice.Text = "";
        }

        private void ControlBtnCreateOn()
        {
            btnUpdate.Enabled = false;
            btnCreate.Enabled = true;
            btnDelete.Enabled = false;
        }

        private void ControlBtnCreateOff()
        {
            btnDelete.Enabled = true;
            btnCreate.Enabled = false;
            btnUpdate.Enabled = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //search products by product code value in textbox then return result list on datagridview
            var source = new BindingSource();
            source.DataSource = ProductRepository
                .GetAll()
                .Include(p => p.Category)
                .Where(p => p.ProductCode.Contains(txtSearch.Text))
                .Select(p => new
                {
                    p.Id,
                    p.ProductName,
                    p.ProductCode,
                    p.Price,
                    p.DateCreate,
                    Category = p.Category.CategoryName
                })
                .ToList();

            dgvListProducts.DataSource = source.DataSource; 
        }
    }
}