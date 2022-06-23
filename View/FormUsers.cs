using System.Windows.Forms;
using TE11Manager.Controller;
using TE11Manager.DataType;

namespace TE11Manager.View
{
    public partial class FormUsers : Form
    {
        #region attributes
        private MainController controller = new MainController();
        private Users usersInfo;
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
        #endregion
        #region Getter Setter
        public bool IsInStorage
        {
            get { return isInStorage; }
            set
            {
                isInStorage = value;
                UnbanBtn.Visible = !isInStorage;
                BanBtn.Text = isInStorage ? "Ban" : "Permanently ban";
                GetUsers();
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
            set
            {
                currentPage = value;
                isNeedToGetSchedule = true;
                if (currentPage < 1 && totalRecord > 0)
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
                PageInputField.Text = "" + currentPage;
                if (isNeedToGetSchedule)
                {
                    GetUsers();
                }
            }
        }
        public int PerPage
        {
            get { return perPage; }
            set
            {
                perPage = value;
                GetUsers();
            }
        }

        public int TotalPage
        {
            get { return totalPage; }
            set
            {
                totalPage = value;
                PaginationNavPanel.Visible = totalPage != 1;
            }
        }
        public int TotalRecord
        {
            get { return totalRecord; }
            set
            {
                totalRecord = value;
                int tempTotal = totalRecord / perPage;
                TotalPage = totalRecord % perPage != 0 ? tempTotal + 1 : tempTotal;
            }
        }
        #endregion
        public FormUsers()
        {
            InitializeComponent();
            perPage = PerPages[0];
            foreach (int PerPage in PerPages)
            {
                PerPageSelect.Items.Add(PerPage);
            }
            PerPageSelect.SelectedItem = PerPageSelect.Items[0];
        }
        private void GetUsers()
        {
            usersInfo = controller.GetDataWithPostMethod<Users>("user/manager/?page=" + currentPage + "&perPage=" + perPage);
            if (usersInfo != null)
            {
                RenderUsers();
            }
            else
            {
                MessageBox.Show("You have no permission");
            }
        }
        private void RenderUsers()
        {
            UsersGrid.Rows.Clear();
            foreach (User user in usersInfo.users)
            {
                UsersGrid.Rows.Add(false, user.fullName, user.account, user.role);
            }
            TotalRecord = usersInfo.countCurrentStored;
            SwicthStoreBtn.Text = (IsInStorage ? "List baned" : "User") + " (" + usersInfo.countOpositeStored + ")";
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
            else
            {
                currentPage = tempCrrPage;
            }
        }

        private void MoveToPageBtn_Click(object sender, System.EventArgs e)
        {
            GetUsers();
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
            CurrentPage = 1;
        }

        private void SchedluleGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            rowSelectedIndex = e.RowIndex;
        }

        private void BanBtn_Click(object sender, System.EventArgs e)
        {
            if (rowSelectedIndex != null)
            {
                User user = usersInfo.users[rowSelectedIndex];
                if (controller.DeleteDataForType("user/" + (IsInStorage ? "ban" : "trash") + "/", user._id))
                {
                    GetUsers();
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

        private void FormUsers_Load(object sender, System.EventArgs e)
        {
            CurrentPage = 1;
        }

        private void SwicthStoreBtn_Click_1(object sender, System.EventArgs e)
        {
            IsInStorage = !IsInStorage;
        }

        private void UnbanBtn_Click(object sender, System.EventArgs e)
        {
            if (rowSelectedIndex != null)
            {
                User user = usersInfo.users[rowSelectedIndex];
                if (controller.DeleteDataForType("user/unban/", user._id))
                {
                    GetUsers();
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

        private void ViewBtn_Click(object sender, System.EventArgs e)
        {
            if (rowSelectedIndex != null)
            {
                FormInfomation formInfomation = new FormInfomation(usersInfo.users[rowSelectedIndex]._id);
                FormMain.instance.Hide();
                formInfomation.ShowDialog();
            }
            else
            {
                MessageBox.Show("You are not select any row");
            }
        }
    }
}
