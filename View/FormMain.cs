using System;
using System.Drawing;
using System.Windows.Forms;
using FontAwesome.Sharp;
using TE11Manager.Controller;

namespace TE11Manager.View
{
    public partial class FormMain : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        private MainController controller = new MainController();
        public static FormMain instance;
        public FormMain()
        {
            Cursor.Current = Cursors.WaitCursor;
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);
            //Form
            this.Text = string.Empty;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            OpenChildForm(new FormDashboard());
            InitUserInfo();
            instance = this;
        } 
        private void InitUserInfo()
        {
            if (FormLogin.user != null)
            {
                UserFullNameLabel.Text = (FormLogin.user.fullName!=""&& FormLogin.user.fullName !=null) ? FormLogin.user.fullName: "No name";
                AvatarImage.ImageLocation = FormLogin.user.image;
            }
            Cursor.Current = Cursors.Default;
        }
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }
        private void ActivateButton(object senderBtn, Color color)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
            }
            Cursor.Current = Cursors.Default;
        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(31, 30, 68);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
        private void OpenChildForm(Form childForm)
        {
            //open only form
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            //End
            childForm.TopLevel = false;
            childForm.AutoScroll = true;
            childForm.FormBorderStyle = FormBorderStyle.None;
            //childForm.Dock = DockStyle.Fill; f* this shit
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
        }
        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            Reset();
        }

        private void btndashboard_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new FormDashboard());
        }

        

        private void btnschedule_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new FormSchedules());
        }

        private void btnuser_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new FormUsers());

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            controller.Logout();
            this.Hide();
            Program.login.Show();
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void AvatarImage_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            FormInfomation formInfomation = new FormInfomation();
            this.Hide();
            Cursor.Current = Cursors.Default;
            formInfomation.ShowDialog();
        }
    }
}