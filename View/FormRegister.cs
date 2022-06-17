using System;
using System.Windows.Forms;
using TE11Manager.Controller;
using TE11Manager.Util;

namespace TE11Manager.View
{
    public partial class FormRegister : Form
    {
        private AuthController controller;
        public FormRegister(AuthController controller)
        {
            InitializeComponent();
            this.controller = controller;
        }
        public void CheckUserLogged()
        {
            FormLogin.user = controller.GetUserData();
            if (FormLogin.user != null)
            {
                FormMain formMain = new FormMain();
                ThreadForm.ShowOtherFormAndHideCurrentForm(formMain, this, true);
            }
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            string userName = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            string confirmPassword = txtRePassword.Text.Trim();
            string email = txtEmail.Text.Trim();
            if (!Validation.IsEmail(email))
            {
                MessageBox.Show("Email is not valid");
                return;
            }
            if (password != confirmPassword)
            {
                MessageBox.Show("Password and confirm password must be same");
                return;
            }
            if (userName == "" || password == ""|| email=="")
            {
                MessageBox.Show("All fields must not be empty");
                return;
            }
            if(controller.Register(userName, password, email))
            {
                CheckUserLogged();
            }
            else
            {
                MessageBox.Show("Register failed");
            }
        }

        private void LoginLabel_Click(object sender, EventArgs e)
        {
            ThreadForm.ShowOtherFormAndHideCurrentForm(Program.login, this,true);
        }
    }
}
