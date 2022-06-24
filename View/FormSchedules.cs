using System.Data;
using System.Linq;
using System.Windows.Forms;
using TE11Manager.Controller;
using TE11Manager.DataType;
using TE11Manager.Util;

namespace TE11Manager.View
{
    public partial class FormSchedules : Form
    {
        private MainController controller = new MainController();
        private Schedules scheduleInfo;
        public readonly string[] DaysOfWeek = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
        public readonly string[] PartsOfDay = { "Morning", "Afternoon", "Evening" };
        public readonly int[] PerPages = { 5, 10, 20, 50 };
        private int currentPage;
        private int perPage;
        private int totalRecord;
        private int totalPage = 0;
        private bool isFirstPage = false;
        private bool isEndPage = false;
        private bool isNeedToGetSchedule = true;
        private bool isInStorage = true;
        private int rowSelectedIndex;
        private bool canManager = FormLogin.user.role < 2;

        public bool IsInStorage
        {
            get { return isInStorage; }
            set
            {
                isInStorage = value;
                DeleteBtn.Text = isInStorage ? "Detete" : "Force delete";
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
                NextPageBtn.Visible = !isEndPage;
                MoveToEndPageBtn.Visible = !isEndPage;
            }
        }
        public int CurrentPage
        {
            get { return currentPage; }
            set { 
                currentPage = value;
                isNeedToGetSchedule = true;
                if (currentPage < 1&& totalRecord>0)
                {
                    MessageBox.Show("We are on the first page");
                    currentPage = 1;
                    isNeedToGetSchedule = false;
                }
                if (currentPage > TotalPage && totalRecord > 0)
                {
                    MessageBox.Show("We are on the last page");
                    currentPage = TotalPage;
                    isNeedToGetSchedule = false;
                }
                IsFirstPage = currentPage == 1;
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
                TotalPage = totalRecord % perPage!=0? tempTotal + 1: tempTotal;
            }
        }
        public FormSchedules()
        {
            Cursor.Current = Cursors.WaitCursor;
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
            Cursor.Current = Cursors.WaitCursor;
            if (canManager)
            {
                scheduleInfo = controller.GetDataWithPostMethod<Schedules>("schedules/"+ (IsInStorage ? "stored": "trash") + "?page=" + (currentPage-1) + "&perPage=" + perPage);
            }
            else
            {
                scheduleInfo = controller.GetDataWithPostMethod<Schedules>("schedules/"+ "?page=" + currentPage + "&perPage=" + perPage);

            }
            if (scheduleInfo != null)
            {
                RenderSchedules();
            }
            else
            {
                MessageBox.Show("Something went wrong, please try again latter");
            }
            Cursor.Current = Cursors.Default;
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
                if (currentPage < 1 && totalRecord > 0)
                {
                    MessageBox.Show("You are enter out of page range");
                    currentPage = 1;
                }
                if (currentPage > TotalPage  && totalRecord > 0)
                {
                    MessageBox.Show("You are enter out of page range");
                    currentPage = TotalPage;
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
            CurrentPage = 1;
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
            CurrentPage = TotalPage;
        }

        private void SwicthStoreBtn_Click(object sender, System.EventArgs e)
        {
            IsInStorage = !IsInStorage;
            RestoreBtn.Visible = !IsInStorage;
            CurrentPage = 1;
        }

        private void SchedluleGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowSelectedIndex = e.RowIndex;
        }

        private void DeleteBtn_Click(object sender, System.EventArgs e)
        {
            if(rowSelectedIndex!= null)
            {
                Schedule schedule = scheduleInfo.schedules[rowSelectedIndex];
                if(controller.DeleteDataForType("schedules/" + (IsInStorage ? "stored" : "trash") + "/", schedule._id))
                {
                    GetSchedules();
                }
                else
                {
                    MessageBox.Show("Something went wrong");
                }
            }
            else
            {
                MessageBox.Show("You are not select any row");
            }
        }

        private void FormSchedules_Load(object sender, System.EventArgs e)
        {
            CurrentPage = 1;
            ManagerPanel.Visible = canManager;
        }

        private void RestoreBtn_Click(object sender, System.EventArgs e)
        {
            if (rowSelectedIndex != null)
            {
                Schedule schedule = scheduleInfo.schedules[rowSelectedIndex];
                if (controller.RestoreDataForType("schedules/restore/",schedule._id))
                {
                    GetSchedules();
                }
                else
                {
                    MessageBox.Show("Something went wrong");
                }
            }
            else
            {
                MessageBox.Show("You are not select any row");
            }
        }

        private void ExportBtn_Click(object sender, System.EventArgs e)
        {
            DataTable scheduleDT = new DataTable();
            scheduleDT.Columns.AddRange(new[] { "Name", "Room", "Time", "DaysOfWeek", "PartOfDay", "DayStart", "DayEnd" }.Select(s => new DataColumn(s)).ToArray());
            foreach (Schedule schedule in scheduleInfo.schedules)
            {
                scheduleDT.Rows.Add(
                    schedule.Name, schedule.Room, schedule.Time,
                    DaysOfWeek[schedule.DayOfWeek], PartsOfDay[schedule.PartOfDay],
                    schedule.DayStart, schedule.DayEnd);
            }
            ExcelHandle.ExportExcelByDataTable(scheduleDT, true, "schedules.xlsx");
        }
    }
}
