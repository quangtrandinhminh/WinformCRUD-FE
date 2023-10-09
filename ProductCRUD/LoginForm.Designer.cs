using System.ComponentModel;

namespace ProductCRUD;

partial class LoginForm
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

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
        lblUserName = new Label();
        lblPassword = new Label();
        txtUserName = new TextBox();
        txtPassword = new TextBox();
        btnLogin = new Button();
        btnExit = new Button();
        SuspendLayout();
        // 
        // lblUserName
        // 
        lblUserName.AutoSize = true;
        lblUserName.Location = new Point(28, 79);
        lblUserName.Name = "lblUserName";
        lblUserName.Size = new Size(94, 25);
        lblUserName.TabIndex = 0;
        lblUserName.Text = "UserName";
        // 
        // lblPassword
        // 
        lblPassword.AutoSize = true;
        lblPassword.Location = new Point(28, 136);
        lblPassword.Name = "lblPassword";
        lblPassword.Size = new Size(87, 25);
        lblPassword.TabIndex = 1;
        lblPassword.Text = "Password";
        // 
        // txtUserName
        // 
        txtUserName.Location = new Point(148, 73);
        txtUserName.Name = "txtUserName";
        txtUserName.Size = new Size(298, 31);
        txtUserName.TabIndex = 2;
        // 
        // txtPassword
        // 
        txtPassword.Location = new Point(148, 130);
        txtPassword.Name = "txtPassword";
        txtPassword.PasswordChar = '*';
        txtPassword.Size = new Size(298, 31);
        txtPassword.TabIndex = 3;
        // 
        // btnLogin
        // 
        btnLogin.FlatAppearance.BorderColor = Color.DodgerBlue;
        btnLogin.Location = new Point(114, 208);
        btnLogin.Name = "btnLogin";
        btnLogin.Size = new Size(112, 34);
        btnLogin.TabIndex = 4;
        btnLogin.Text = "Login";
        btnLogin.UseVisualStyleBackColor = true;
        btnLogin.Click += btnLogin_Click;
        // 
        // btnExit
        // 
        btnExit.Location = new Point(248, 208);
        btnExit.Name = "btnExit";
        btnExit.Size = new Size(112, 34);
        btnExit.TabIndex = 5;
        btnExit.Text = "Exit";
        btnExit.UseVisualStyleBackColor = true;
        btnExit.Click += btnExit_Click;
        // 
        // LoginForm
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(484, 291);
        Controls.Add(btnExit);
        Controls.Add(btnLogin);
        Controls.Add(txtPassword);
        Controls.Add(txtUserName);
        Controls.Add(lblPassword);
        Controls.Add(lblUserName);
        Name = "LoginForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "LoginForm";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label lblUserName;
    private Label lblPassword;
    private TextBox txtUserName;
    private TextBox txtPassword;
    private Button btnLogin;
    private Button btnExit;
}