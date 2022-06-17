using System;
using System.Windows.Forms;
using TE11Manager.Controller;
using TE11Manager.Util;
using TE11Manager.DataType;

namespace TE11Manager.View
{
    public partial class FormLogin : Form
    {
        private AuthController controller = new AuthController();
        public static User user;
        public FormLogin()
        {
            InitializeComponent();
            user = controller.GetUserData();
        }
        public bool CheckUserLogged()
        {
            if (user != null)
            {
                FormMain formMain = new FormMain();
                ThreadForm.ShowOtherFormAndHideCurrentForm(formMain, this);
                return true;
            }
            return false;
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
            controller.Login(userName, password);
            
            user = controller.GetUserData();
            if (!CheckUserLogged())
            {
                MessageBox.Show("User name or password is incorrect");
            }
        }

        private void RegisterLabel_Click(object sender, EventArgs e)
        {
            FormRegister formRegister = new FormRegister(controller);
            ThreadForm.ShowOtherFormAndHideCurrentForm(formRegister, this);
        }

        private void FormLogin_Shown(object sender, EventArgs e)
        {
            CheckUserLogged();
        }
    }
}
