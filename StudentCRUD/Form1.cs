using Data;
using Microsoft.EntityFrameworkCore;

namespace StudentCRUD
{
    public partial class Form1 : Form
    {
        public List<Student> Students = new List<Student>();
        public ProductRepository ProductRepository;
        public CategoryRepository CategoryRepository;
        public Form1()
        {
            CategoryRepository = new CategoryRepository();
            ProductRepository = new ProductRepository();
            InitializeComponent();
            var category = CategoryRepository.GetAll()
                .Include(p => p.Products).FirstOrDefault(p => p.Id == 1);

            if(category != null)
            {
                var listProduct = category.Products.ToList();
                dgvListStudents.DataSource = listProduct;
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            btnCreate.Enabled = false;

            var student = new Student();

            var (name, age) = GetInputedData(txtName, txtAge);
            if (name == "" || age == 0)
            {
                btnCreate.Enabled = true;
                return;
            }

            /*if (Students.Any(student => student.Id == Id))
            {
                MessageBox.Show("Student with the same ID already exists. Please choose a different ID.");
                return;
            }*/

            /*student.Id = Id;*/
            student.Name = name;
            student.Age = age;

            Students.Add(student);

            LoadData();

            ClearText();
            btnCreate.Enabled = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ControlbtnUpdate();

            var id = txtId.Text;
            var (name, age) = GetInputedData(txtName, txtAge);
            if (name == "" || age == 0)
            {
                ControlbtnUpdate();
                return;
            }

            var curStudent = Students.FirstOrDefault(p => p.Id.Equals(id));

            if (curStudent != null)
            {
                curStudent.Age = age;
                curStudent.Name = name;
            }

            /*var student = Students.FirstOrDefault(student => student.Id == id);
            if (student == null)
            {
                MessageBox.Show("Student with this ID can not found");
                return;
            }*/

            dgvListStudents.Refresh();
            ClearText();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure?", "Warning",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                ControlbtnDelete();

                var id = txtId.Text;
                var (name, age) = GetInputedData(txtName, txtAge);
                if (name == "" || age == 0)
                {
                    ControlbtnDelete();
                    return;
                }

                var curStudent = Students.FirstOrDefault(p => p.Id.Equals(id));
                if (curStudent != null)
                {
                    Students.Remove(curStudent);
                }

                /*var student = Students.FirstOrDefault(student => student.Id == Id);
                if (student == null)
                {
                    MessageBox.Show("Student with this ID can not found");
                    return;
                }*/

                LoadData();
                ClearText() ;
            }
        }

        private void dgvListStudents_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnCreate.Enabled = false;
            btnDelete.Enabled = true;
            btnUpdate.Enabled = true;

            var data = Students[e.RowIndex];

            txtAge.Text = data.Age.ToString();
            txtId.Text = data.Id.ToString();
            txtName.Text = data.Name.ToString();
        }

        private void LoadData()
        {
            BindingSource source = new BindingSource();
            source.DataSource = Students;
            dgvListStudents.DataSource = source;
        }

        private bool IsValidInteger(string input)
        {
            return int.TryParse(input, out _);
        }

        private bool CheckedInteger(TextBox txt)
        {
            if (!IsValidInteger(txt.Text) || txt.Text == "")
            {
                ShowErrorMessageBox("Please input integer data!", txt.Name);
                return false;
            }
            return true;
        }

        private bool CheckedTextBox(TextBox txt)
        {
            if (txt.Text == "")
            {
                ShowErrorMessageBox("Please input data!", txt.Name);
                return false;
            }
            return true;
        }

        private (string, int) GetInputedData(TextBox txtName, TextBox txtAge)
        {
            if (CheckedTextBox(txtName) == false || CheckedInteger(txtAge) == false)
            {
                return ("", 0);
            }

            var name = txtName.Text;
            var age = int.Parse(txtAge.Text);
            return (name, age);
        }

        private void ShowErrorMessageBox(string message, string errorLocation)
        {
            MessageBox.Show("Error at " + errorLocation + "\n" + message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ClearText()
        {
            txtId.Text = "";
            txtName.Text = "";
            txtAge.Text = "";
        }

        private void ControlbtnUpdate()
        {
            btnUpdate.Enabled = false;
            btnCreate.Enabled = true;
            btnDelete.Enabled = false;
        }

        private void ControlbtnDelete()
        {
            btnDelete.Enabled = false;
            btnCreate.Enabled = true;
            btnUpdate.Enabled = false;
        }
    }
}