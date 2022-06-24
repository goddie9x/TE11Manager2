using System;
using System.Windows.Forms;
using TE11Manager.Controller;
using TE11Manager.DataType;
using TE11Manager.Util;

namespace TE11Manager.View
{
    public partial class FormInfomation : Form
    {
        private User currUser;
        private User user;
        private MainController mainController = new MainController();
        private AuthController authController = new AuthController();
        private bool isEditing = false;
        public bool IsEditing
        {
            get
            {
                return isEditing;
            }
            set
            {
                isEditing = value;
                InfoPanel.Visible = !isEditing;
                InputPanel.Visible = isEditing;
                if (isEditing)
                {
                    InitEditInfo();
                }
            }
        }
        public FormInfomation(string _id)
        {
            InitializeComponent();
            currUser = authController.GetUserData();
            user = mainController.GetData<User>("user/profile/" + _id);
            if (user == null)
            {
                MessageBox.Show("Something went wrong, please try again latter");
                this.Hide();
                FormMain formMain = new FormMain();
                formMain.ShowDialog();
                return;
            }
            InitUserData();
            BanBtn.Visible = currUser.role < user.role;
        }
        public FormInfomation()
        {
            InitializeComponent();
            currUser = authController.GetUserData();
            user = currUser;
            InitUserData();
            EditBtn.Visible = true;
        }
        private void InitUserData()
        {
            UserAvatar.ImageLocation = user.image;
            UserNameLabel.Text = user.fullName;
            if (user.email.Length > 0) { 
                EmailLabel.Text = user.email[0];
            }
            if (user.phone.Length > 0)
            {
                PhoneLabel.Text = user.phone[0];
            }
            DateOfBirthLabel.Text = user.dateOfBirth;
            GenderLabel.Text = user.gender;
            DescriptionLabel.Text = user.address;
            SubDescriptionLabel.Text = user.subDescription;
            QuoteLabel.Text = user.quote;
            AddressLabel.Text = user.address;
        }
        private void InitEditInfo()
        {
            FullNameField.Text = user.fullName;
            AddressField.Text = user.address;
            if (user.email.Length > 0)
            {
                EmailField.Text = user.email[0];
            }
            if (user.phone.Length > 0)
            {
                PhoneField.Text = user.phone[0];
            }
            try
            {
                DateOfBirthPicker.Value = DateTime.ParseExact(user.dateOfBirth, "yyyy-MM-dd", null).Date;
            }
            catch(Exception e)
            {
                DateOfBirthPicker.Value = DateTime.ParseExact(user.dateOfBirth, "dd/MM/yyyy", null).Date;
            }
            DateOfBirthPicker.Update();
            GenderField.Text = user.gender;
            DescriptionField.Text = user.address;
            SubDescriptionField.Text = user.subDescription;
            QuoteField.Text = user.quote;
        }

        private void EditBtn_Click(object sender, System.EventArgs e)
        {
            IsEditing = true;
        }

        private void SetUserDataByFields()
        {
            user.fullName = UserNameLabel.Text;
            string email = EmailField.Text;
            string phone = PhoneField.Text;
            if (user.email.Length > 0)
            {
                user.email[0] = email;
            }
            else
            {
                user.email = new string[] { email };
            }
            if (user.phone.Length > 0)
            {
                user.phone[0] = phone;
            }
            else
            {
                user.phone = new string[] { phone };
            }
            user.dateOfBirth = DateOfBirthPicker.Value.ToString("dd/MM/yyyy");
            user.gender = GenderField.Text;
            user.address = DescriptionField.Text;
            user.subDescription = SubDescriptionField.Text;
            user.quote = QuoteField.Text;
            user.address = AddressField.Text;
        }
        private void ConfirmBtn_Click(object sender, System.EventArgs e)
        {
            if (Validate())
            {
                SetUserDataByFields();
                string userJsonData = JSONParse.convertStringToJson<User>(user);
                if(mainController.PatchDataForType("user/profile/", user._id, userJsonData))
                {
                    InitUserData();
                    MessageBox.Show("Update the infomation success!");
                    IsEditing = false;
                }
                else
                {
                    MessageBox.Show("Update the infomation Failed!");
                }
            }
        }
        private bool Validate()
        {
            string phone = PhoneField.Text;
            string email = EmailField.Text;
            bool isValid = true;
            if (!Validation.IsEmail(email))
            {
                isValid = false;
                MessageBox.Show("Email format is not correct");
            }
            if(!Validation.IsPhone(phone))
            {
                isValid = false;
                MessageBox.Show("Phone format is not correct");
            }
            return isValid;
        }

        private void BanBtn_Click(object sender, System.EventArgs e)
        {
            if (mainController.DeleteDataForType("user/ban/", user._id))
            {
                MessageBox.Show("Ban user success!");
            }
            else
            {
                MessageBox.Show("Something went wrong");
            }
        }
        private void ToMainForm()
        {
            this.Visible = false;
            if (FormMain.instance.Visible)
            {
                FormMain.instance.Visible = false;
            }
            FormMain.instance.Show();
        }
        private void BackBtn_Click(object sender, System.EventArgs e)
        {
            ToMainForm();
        }

        private void CancelBtn_Click(object sender, System.EventArgs e)
        {
            IsEditing = false;
        }

        private void FormInfomation_FormClosed(object sender, FormClosedEventArgs e)
        {
            ToMainForm();
        }
    }
}
