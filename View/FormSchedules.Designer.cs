using System.Windows.Forms;

namespace TE11Manager.View
{
    partial class FormSchedules
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.SchedluleGrid = new System.Windows.Forms.DataGridView();
            this.ColSelect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColRoom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDayOfWeek = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPartOfDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDayStart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDayEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaginationPanel = new System.Windows.Forms.Panel();
            this.PaginationNavPanel = new System.Windows.Forms.Panel();
            this.PageInputField = new System.Windows.Forms.TextBox();
            this.PageFirstBtn = new System.Windows.Forms.Button();
            this.PrevPageBtn = new System.Windows.Forms.Button();
            this.MoveToEndPageBtn = new System.Windows.Forms.Button();
            this.MoveToPageBtn = new System.Windows.Forms.Button();
            this.NextPageBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.PerPageSelect = new System.Windows.Forms.ComboBox();
            this.SwicthStoreBtn = new System.Windows.Forms.Button();
            this.RestoreBtn = new System.Windows.Forms.Button();
            this.ManagerPanel = new System.Windows.Forms.Panel();
            this.ExportBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SchedluleGrid)).BeginInit();
            this.PaginationPanel.SuspendLayout();
            this.PaginationNavPanel.SuspendLayout();
            this.ManagerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(16, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Schedules";
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.DeleteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteBtn.Location = new System.Drawing.Point(464, 4);
            this.DeleteBtn.Margin = new System.Windows.Forms.Padding(2);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(78, 27);
            this.DeleteBtn.TabIndex = 2;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // SchedluleGrid
            // 
            this.SchedluleGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SchedluleGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColSelect,
            this.ColName,
            this.ColRoom,
            this.ColTime,
            this.ColDayOfWeek,
            this.ColPartOfDay,
            this.ColDayStart,
            this.ColDayEnd,
            this._id});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.SchedluleGrid.DefaultCellStyle = dataGridViewCellStyle1;
            this.SchedluleGrid.Location = new System.Drawing.Point(22, 64);
            this.SchedluleGrid.MaximumSize = new System.Drawing.Size(900, 500);
            this.SchedluleGrid.Name = "SchedluleGrid";
            this.SchedluleGrid.RowHeadersVisible = false;
            this.SchedluleGrid.RowHeadersWidth = 5;
            this.SchedluleGrid.Size = new System.Drawing.Size(800, 310);
            this.SchedluleGrid.TabIndex = 3;
            this.SchedluleGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SchedluleGrid_CellClick);
            // 
            // ColSelect
            // 
            this.ColSelect.HeaderText = "Select";
            this.ColSelect.Name = "ColSelect";
            this.ColSelect.Width = 50;
            // 
            // ColName
            // 
            this.ColName.HeaderText = "Name";
            this.ColName.Name = "ColName";
            this.ColName.Width = 125;
            // 
            // ColRoom
            // 
            this.ColRoom.HeaderText = "Room";
            this.ColRoom.Name = "ColRoom";
            this.ColRoom.Width = 125;
            // 
            // ColTime
            // 
            this.ColTime.HeaderText = "Time";
            this.ColTime.Name = "ColTime";
            this.ColTime.Width = 125;
            // 
            // ColDayOfWeek
            // 
            this.ColDayOfWeek.HeaderText = "Day of week";
            this.ColDayOfWeek.Name = "ColDayOfWeek";
            this.ColDayOfWeek.Width = 115;
            // 
            // ColPartOfDay
            // 
            this.ColPartOfDay.HeaderText = "Part of day";
            this.ColPartOfDay.Name = "ColPartOfDay";
            this.ColPartOfDay.Width = 115;
            // 
            // ColDayStart
            // 
            this.ColDayStart.HeaderText = "Day start";
            this.ColDayStart.Name = "ColDayStart";
            this.ColDayStart.Width = 115;
            // 
            // ColDayEnd
            // 
            this.ColDayEnd.HeaderText = "Day end";
            this.ColDayEnd.Name = "ColDayEnd";
            this.ColDayEnd.Width = 115;
            // 
            // _id
            // 
            this._id.HeaderText = "_id";
            this._id.Name = "_id";
            this._id.Visible = false;
            // 
            // PaginationPanel
            // 
            this.PaginationPanel.Controls.Add(this.PaginationNavPanel);
            this.PaginationPanel.Controls.Add(this.label2);
            this.PaginationPanel.Controls.Add(this.PerPageSelect);
            this.PaginationPanel.Location = new System.Drawing.Point(22, 390);
            this.PaginationPanel.Name = "PaginationPanel";
            this.PaginationPanel.Size = new System.Drawing.Size(503, 46);
            this.PaginationPanel.TabIndex = 4;
            // 
            // PaginationNavPanel
            // 
            this.PaginationNavPanel.Controls.Add(this.PageInputField);
            this.PaginationNavPanel.Controls.Add(this.PageFirstBtn);
            this.PaginationNavPanel.Controls.Add(this.PrevPageBtn);
            this.PaginationNavPanel.Controls.Add(this.MoveToEndPageBtn);
            this.PaginationNavPanel.Controls.Add(this.MoveToPageBtn);
            this.PaginationNavPanel.Controls.Add(this.NextPageBtn);
            this.PaginationNavPanel.Location = new System.Drawing.Point(17, 3);
            this.PaginationNavPanel.Name = "PaginationNavPanel";
            this.PaginationNavPanel.Size = new System.Drawing.Size(326, 36);
            this.PaginationNavPanel.TabIndex = 12;
            // 
            // PageInputField
            // 
            this.PageInputField.Location = new System.Drawing.Point(106, 10);
            this.PageInputField.Name = "PageInputField";
            this.PageInputField.Size = new System.Drawing.Size(66, 20);
            this.PageInputField.TabIndex = 5;
            this.PageInputField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PageInputField.TextChanged += new System.EventHandler(this.PageInputField_TextChanged);
            // 
            // PageFirstBtn
            // 
            this.PageFirstBtn.BackColor = System.Drawing.Color.White;
            this.PageFirstBtn.Location = new System.Drawing.Point(6, 9);
            this.PageFirstBtn.Name = "PageFirstBtn";
            this.PageFirstBtn.Size = new System.Drawing.Size(44, 23);
            this.PageFirstBtn.TabIndex = 0;
            this.PageFirstBtn.Text = "<<";
            this.PageFirstBtn.UseVisualStyleBackColor = false;
            this.PageFirstBtn.Click += new System.EventHandler(this.PageFirstBtn_Click);
            // 
            // PrevPageBtn
            // 
            this.PrevPageBtn.BackColor = System.Drawing.Color.White;
            this.PrevPageBtn.Location = new System.Drawing.Point(56, 9);
            this.PrevPageBtn.Name = "PrevPageBtn";
            this.PrevPageBtn.Size = new System.Drawing.Size(44, 23);
            this.PrevPageBtn.TabIndex = 9;
            this.PrevPageBtn.Text = "<";
            this.PrevPageBtn.UseVisualStyleBackColor = false;
            this.PrevPageBtn.Click += new System.EventHandler(this.PrevPageBtn_Click);
            // 
            // MoveToEndPageBtn
            // 
            this.MoveToEndPageBtn.BackColor = System.Drawing.Color.White;
            this.MoveToEndPageBtn.Location = new System.Drawing.Point(278, 8);
            this.MoveToEndPageBtn.Name = "MoveToEndPageBtn";
            this.MoveToEndPageBtn.Size = new System.Drawing.Size(44, 23);
            this.MoveToEndPageBtn.TabIndex = 6;
            this.MoveToEndPageBtn.Text = ">>";
            this.MoveToEndPageBtn.UseVisualStyleBackColor = false;
            this.MoveToEndPageBtn.Click += new System.EventHandler(this.MoveToEndPageBtn_Click);
            // 
            // MoveToPageBtn
            // 
            this.MoveToPageBtn.BackColor = System.Drawing.Color.White;
            this.MoveToPageBtn.Location = new System.Drawing.Point(178, 8);
            this.MoveToPageBtn.Name = "MoveToPageBtn";
            this.MoveToPageBtn.Size = new System.Drawing.Size(44, 23);
            this.MoveToPageBtn.TabIndex = 8;
            this.MoveToPageBtn.Text = "Go";
            this.MoveToPageBtn.UseVisualStyleBackColor = false;
            this.MoveToPageBtn.Click += new System.EventHandler(this.MoveToPageBtn_Click);
            // 
            // NextPageBtn
            // 
            this.NextPageBtn.BackColor = System.Drawing.Color.White;
            this.NextPageBtn.Location = new System.Drawing.Point(228, 8);
            this.NextPageBtn.Name = "NextPageBtn";
            this.NextPageBtn.Size = new System.Drawing.Size(44, 23);
            this.NextPageBtn.TabIndex = 7;
            this.NextPageBtn.Text = ">";
            this.NextPageBtn.UseVisualStyleBackColor = false;
            this.NextPageBtn.Click += new System.EventHandler(this.NextPageBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(366, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Per page:";
            // 
            // PerPageSelect
            // 
            this.PerPageSelect.FormattingEnabled = true;
            this.PerPageSelect.Location = new System.Drawing.Point(425, 12);
            this.PerPageSelect.Name = "PerPageSelect";
            this.PerPageSelect.Size = new System.Drawing.Size(69, 21);
            this.PerPageSelect.TabIndex = 10;
            this.PerPageSelect.SelectedIndexChanged += new System.EventHandler(this.PerPageSelect_SelectedIndexChanged);
            // 
            // SwicthStoreBtn
            // 
            this.SwicthStoreBtn.BackColor = System.Drawing.Color.Cyan;
            this.SwicthStoreBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SwicthStoreBtn.Location = new System.Drawing.Point(3, 6);
            this.SwicthStoreBtn.Name = "SwicthStoreBtn";
            this.SwicthStoreBtn.Size = new System.Drawing.Size(75, 23);
            this.SwicthStoreBtn.TabIndex = 5;
            this.SwicthStoreBtn.Text = "SwicthStoreBtn";
            this.SwicthStoreBtn.UseVisualStyleBackColor = false;
            this.SwicthStoreBtn.Click += new System.EventHandler(this.SwicthStoreBtn_Click);
            // 
            // RestoreBtn
            // 
            this.RestoreBtn.BackColor = System.Drawing.Color.LightSteelBlue;
            this.RestoreBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RestoreBtn.Location = new System.Drawing.Point(300, 6);
            this.RestoreBtn.Name = "RestoreBtn";
            this.RestoreBtn.Size = new System.Drawing.Size(75, 23);
            this.RestoreBtn.TabIndex = 6;
            this.RestoreBtn.Text = "Restore";
            this.RestoreBtn.UseVisualStyleBackColor = false;
            this.RestoreBtn.Visible = false;
            this.RestoreBtn.Click += new System.EventHandler(this.RestoreBtn_Click);
            // 
            // ManagerPanel
            // 
            this.ManagerPanel.Controls.Add(this.ExportBtn);
            this.ManagerPanel.Controls.Add(this.SwicthStoreBtn);
            this.ManagerPanel.Controls.Add(this.RestoreBtn);
            this.ManagerPanel.Controls.Add(this.DeleteBtn);
            this.ManagerPanel.Location = new System.Drawing.Point(217, 22);
            this.ManagerPanel.Name = "ManagerPanel";
            this.ManagerPanel.Size = new System.Drawing.Size(566, 36);
            this.ManagerPanel.TabIndex = 7;
            // 
            // ExportBtn
            // 
            this.ExportBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ExportBtn.Location = new System.Drawing.Point(152, 6);
            this.ExportBtn.Name = "ExportBtn";
            this.ExportBtn.Size = new System.Drawing.Size(72, 23);
            this.ExportBtn.TabIndex = 7;
            this.ExportBtn.Text = "Export";
            this.ExportBtn.UseVisualStyleBackColor = false;
            this.ExportBtn.Click += new System.EventHandler(this.ExportBtn_Click);
            // 
            // FormSchedules
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(839, 450);
            this.Controls.Add(this.ManagerPanel);
            this.Controls.Add(this.PaginationPanel);
            this.Controls.Add(this.SchedluleGrid);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormSchedules";
            this.Text = " ";
            this.Load += new System.EventHandler(this.FormSchedules_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SchedluleGrid)).EndInit();
            this.PaginationPanel.ResumeLayout(false);
            this.PaginationPanel.PerformLayout();
            this.PaginationNavPanel.ResumeLayout(false);
            this.PaginationNavPanel.PerformLayout();
            this.ManagerPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button DeleteBtn;
        private DataGridViewTextBoxColumn ColId;
        private DataGridView SchedluleGrid;
        private Panel PaginationPanel;
        private Button MoveToPageBtn;
        private Button NextPageBtn;
        private Button MoveToEndPageBtn;
        private TextBox PageInputField;
        private Button PageFirstBtn;
        private Label label2;
        private ComboBox PerPageSelect;
        private Button PrevPageBtn;
        private Button SwicthStoreBtn;
        private Panel PaginationNavPanel;
        private DataGridViewCheckBoxColumn ColSelect;
        private DataGridViewTextBoxColumn ColName;
        private DataGridViewTextBoxColumn ColRoom;
        private DataGridViewTextBoxColumn ColTime;
        private DataGridViewTextBoxColumn ColDayOfWeek;
        private DataGridViewTextBoxColumn ColPartOfDay;
        private DataGridViewTextBoxColumn ColDayStart;
        private DataGridViewTextBoxColumn ColDayEnd;
        private DataGridViewTextBoxColumn _id;
        private Button RestoreBtn;
        private Panel ManagerPanel;
        private Button ExportBtn;
    }
}