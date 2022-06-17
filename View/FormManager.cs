using System.Windows.Forms;
using TE11Manager.Controller;
using TE11Manager.DataType;

namespace TE11Manager.View
{
    public partial class FormManager : Form
    {
        private MainController controller = new MainController();
        private Schedules scheduleInfo;
        public readonly string[] DaysOfWeek = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
        public readonly string[] PartsOfDay = { "Morning", "Afternoon", "Evening" };
        public readonly int[] PerPages = { 5, 10, 20, 50 };
        private int currentPage;
        private int perPage;
        private int totalRecord = 0;
        private int totalPage = 0;
        private bool isFirstPage = false;
        private bool isEndPage = false;
        private bool isNeedToGetSchedule = true;
        private bool isInStorage = true;
        private int rowSelectedIndex;

        public bool IsInStorage
        {
            get { return isInStorage; }
            set
            {
                isInStorage = value;
                GetSchedules();
            }
        }
        public bool IsFirstPage
        {
            get { return isFirstPage; }
            set
            {
                isFirstPage = value;
                PageFirstBtn.Visible = !isFirstPage;
                PrevPageBtn.Visible = !isFirstPage;
            }
        }
        public bool IsEndPage
        {
            get { return isEndPage; }
            set
            {
                isEndPage = value;
                NextPageBtn.Visible = !isFirstPage;
                MoveToEndPageBtn.Visible = !isFirstPage;
            }
        }
        public int CurrentPage
        {
            get { return currentPage; }
            set { 
                currentPage = value;
                isNeedToGetSchedule = true;
                if (currentPage < 1)
                {
                    MessageBox.Show("We are on the first page");
                    currentPage = 1;
                    isNeedToGetSchedule = false;
                }
                if (currentPage > TotalPage+1)
                {
                    MessageBox.Show("We are on the last page");
                    currentPage = TotalPage+1;
                    isNeedToGetSchedule = false;
                }
                IsFirstPage = currentPage == 0;
                IsEndPage = currentPage == totalPage;
                PageInputField.Text = ""+currentPage;
                if (isNeedToGetSchedule)
                {
                    GetSchedules();
                }
            }
        }
        public int PerPage
        {
            get { return perPage; }
            set
            {
                perPage = value;
                GetSchedules();
            }
        }

        public int TotalPage
        {
            get { return totalPage; }
            set
            {
                totalPage = value;
                PaginationNavPanel.Visible = totalPage!=1;
            }
        }
        public int TotalRecord
        {
            get { return totalRecord; }
            set
            {
                totalRecord = value;
                int tempTotal = totalRecord / perPage;
                TotalPage = TotalPage % perPage==0? tempTotal: tempTotal + 1;
            }
        }
        public FormManager()
        {
            InitializeComponent();
            perPage = PerPages[0];
            foreach(int PerPage in PerPages)
            {
                PerPageSelect.Items.Add(PerPage);
            }
            PerPageSelect.SelectedItem = PerPageSelect.Items[0];
        }
        private void GetSchedules()
        {
            scheduleInfo = controller.GetData<Schedules>("schedules/"+ (IsInStorage ? "stored": "trash") + "?page=" + (currentPage-1) + "&perPage=" + perPage);
            if (scheduleInfo != null)
            {
                RenderSchedules();
            }
            else
            {
                MessageBox.Show("Something went wrong or you have no permission");
            }
        }
        private void FormManager_Shown(object sender, System.EventArgs e)
        {
            CurrentPage = 1;
        }
        private void RenderSchedules()
        {
            SchedluleGrid.Rows.Clear();
            foreach (Schedule schedule in scheduleInfo.schedules)
            {
                SchedluleGrid.Rows.Add(
                    false,
                    schedule.Name, schedule.Room, schedule.Time,
                    DaysOfWeek[schedule.DayOfWeek], PartsOfDay[schedule.PartOfDay],
                    schedule.DayStart, schedule.DayEnd);
            }
            TotalRecord = scheduleInfo.countCurrentStored;
            SwicthStoreBtn.Text = (IsInStorage ? "Trash" : "Store") + " (" + scheduleInfo.countOpositeStored + ")";
        }
        private void PerPageSelect_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            PerPage = (int)PerPageSelect.SelectedItem;
        }

        private void PageInputField_TextChanged(object sender, System.EventArgs e)
        {
            int tempCrrPage;
            if (!int.TryParse(PageInputField.Text, out tempCrrPage))
            {
                MessageBox.Show("Please enter a number");
            }
            else{
                currentPage = tempCrrPage;
                if (currentPage < 1)
                {
                    MessageBox.Show("You are enter out of total page");
                    currentPage = 1;
                }
                if (currentPage > TotalPage + 1)
                {
                    MessageBox.Show("You are enter out of total page");
                    currentPage = TotalPage + 1;
                }
                PageInputField.Text = "" + currentPage;
            }
        }

        private void MoveToPageBtn_Click(object sender, System.EventArgs e)
        {
            GetSchedules();
        }

        private void PageFirstBtn_Click(object sender, System.EventArgs e)
        {
            CurrentPage = 0;
        }

        private void PrevPageBtn_Click(object sender, System.EventArgs e)
        {
            CurrentPage = CurrentPage - 1;
        }

        private void NextPageBtn_Click(object sender, System.EventArgs e)
        {
            CurrentPage = CurrentPage + 1;
        }

        private void MoveToEndPageBtn_Click(object sender, System.EventArgs e)
        {
            CurrentPage = TotalPage - 1;
        }

        private void SwicthStoreBtn_Click(object sender, System.EventArgs e)
        {
            IsInStorage = !IsInStorage;
        }

        private void SchedluleGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            rowSelectedIndex = e.RowIndex;
        }

        private void DeleteBtn_Click(object sender, System.EventArgs e)
        {
            if(rowSelectedIndex!= null)
            {
                Schedule schedule = scheduleInfo.schedules[rowSelectedIndex];
                if(controller.DeleteDataForType("schedules/" + (IsInStorage ? "stored" : "trash") + "/", schedule.Id))
                {
                    GetSchedules();
                }
                else
                {
                    MessageBox.Show("Something went wrong");
                }
            }
        }

        private void FormManager_Load(object sender, System.EventArgs e)
        {
            CurrentPage = 1;
        }
    }
}
