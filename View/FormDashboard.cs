using System;
using System.Windows.Forms;
using TE11Manager.DataType;

namespace TE11Manager.View
{
    public partial class FormDashboard : Form
    {
        public static FormDashboard Instance;
        public FormDashboard()
        {
            InitializeComponent();
            FormDashboard.Instance = this;
        }
        private void SetDashBoardData()
        {
            
        }
    }
}
