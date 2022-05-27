using System.Windows.Forms;

namespace TE11Manager.View
{
    public partial class FormSchedules : Form
    {
        public static FormSchedules Instance;
        public FormSchedules()
        {
            InitializeComponent();
            FormSchedules.Instance = this;
        }
    }
}
