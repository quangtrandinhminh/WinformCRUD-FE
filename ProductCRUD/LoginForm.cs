using System.Xml.Linq;
using Data;
using Data.Models;

namespace ProductCRUD;

public partial class LoginForm : Form
{
    public UserRepository UserRepository;

    public List<User> Users;
    public LoginForm()
    {
        UserRepository = new UserRepository();
        InitializeComponent();
        Users = UserRepository.GetAll().ToList();
    }

    private void btnLogin_Click(object sender, EventArgs e)
    {
        var (username, password) = GetInputData(txtUserName, txtPassword);
        if (username == "" || password == "")
        {
            return;
        }

        try
        {
            //check if username and password exists
            var user = Users.FirstOrDefault(u => u.UserName == username && u.Password == password);
            if (user == null || user.UserRole > 2)
            {
                ShowErrorMessageBox("Sorry, you are not allowed to access", "Permission");
                return;
            }

            ClearText();

            Hide();
            //run product form
            var productForm = new ProductForm();
            productForm.Show();
        }
        catch (Exception exception)
        {
            Console.WriteLine(exception);
            throw;
        }
    }

    private void btnExit_Click(object sender, EventArgs e)
    {
        //exit program
        System.Windows.Forms.Application.Exit();
    }

    private bool CheckedTextBox(TextBox txt)
    {
        if (txt.Text.Trim() != "") return true;
        ShowErrorMessageBox("Please input data!", txt.Name);
        return false;
    }

    private (string, string) GetInputData(TextBox txtUsername, TextBox txtPassword)
    {
        if (CheckedTextBox(txtUsername) == false || CheckedTextBox(txtPassword) == false)
        {
            return ("", "");
        }

        return (txtUsername.Text, txtPassword.Text);
    }

    private void ShowErrorMessageBox(string message, string errorLocation)
    {
        MessageBox.Show("Error at " + errorLocation + "\n" + message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }

    private void ClearText()
    {
        txtUserName.Text = "";
        txtPassword.Text = "";
    }
}