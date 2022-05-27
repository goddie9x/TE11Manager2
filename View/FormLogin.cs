using System;
using System.Windows.Forms;
using TE11Manager.Controller;

namespace TE11Manager.View
{
    public partial class FormLogin : Form
    {
        public static FormLogin Instance;
        public FormLogin()
        {
            InitializeComponent();
            FormLogin.Instance = this;
        }
        private void LoginBtn_Click(object sender, EventArgs e)
        {
            string userName = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            if (userName == "" || password == "")
            {
                MessageBox.Show("User name and password must not be empty");
                return;
            }
            LoginController.instance.Login(userName, password);
        }
    }
}
