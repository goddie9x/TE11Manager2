using TE11Manager.DataType;
using TE11Manager.Controller;
using System.Windows.Forms;

namespace TE11Manager.View
{
    public partial class FormDashboard : Form
    {
        private MainController controller = new MainController();
        public Dashboard dashboard;
        public FormDashboard()
        {
            InitializeComponent();
        }
        private void SetDashBoardData()
        {
            dashboard = controller.GetDashboardData();
            if(dashboard!= null)
            {
                AmountPostsLabel.Text = dashboard.AmountPost.ToString();
                AmountSchedulesLabel.Text = dashboard.AmountSchedule.ToString();
                totalUserLoggedLabel.Text = dashboard.AmountConnectPerMonth.ToString();
                int amountWeek = dashboard.AmountConnectAnalyticsMonthByWeek.Length;
                for (int i = 0; i < amountWeek; i++)
                {
                    chartLoggedAnalystic.Series["Series1"].Points.AddXY(i+1, dashboard.AmountConnectAnalyticsMonthByWeek[i]);
                }
            }
        }

        private void FormDashboard_Load(object sender, System.EventArgs e)
        {
            SetDashBoardData();
        }
    }
}
