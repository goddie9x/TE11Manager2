using System;
using System.Windows.Forms;

namespace TE11Manager.View
{
    public partial class FormUsers : Form
    {
        public static FormUsers Instance;
        public FormUsers()
        {
            InitializeComponent();
            FormUsers.Instance = this;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
