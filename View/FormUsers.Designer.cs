namespace TE11Manager.View
{
    partial class FormUsers
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
            this.UsersGrid = new System.Windows.Forms.DataGridView();
            this.ColSelect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAcc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColUserrole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.UsersGrid)).BeginInit();
            this.PaginationPanel.SuspendLayout();
            this.PaginationNavPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(44, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Users";
            // 
            // UsersGrid
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.UsersGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.UsersGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UsersGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColSelect,
            this.ColName,
            this.ColAcc,
            this.ColUserrole});
            this.UsersGrid.Location = new System.Drawing.Point(50, 74);
            this.UsersGrid.Margin = new System.Windows.Forms.Padding(2);
            this.UsersGrid.Name = "UsersGrid";
            this.UsersGrid.RowHeadersWidth = 5;
            this.UsersGrid.RowTemplate.Height = 28;
            this.UsersGrid.Size = new System.Drawing.Size(905, 325);
            this.UsersGrid.TabIndex = 1;
            // 
            // ColSelect
            // 
            this.ColSelect.HeaderText = "Select";
            this.ColSelect.MinimumWidth = 8;
            this.ColSelect.Name = "ColSelect";
            this.ColSelect.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColSelect.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColSelect.Width = 60;
            // 
            // ColName
            // 
            this.ColName.HeaderText = "Full name";
            this.ColName.MinimumWidth = 8;
            this.ColName.Name = "ColName";
            this.ColName.Width = 300;
            // 
            // ColAcc
            // 
            this.ColAcc.HeaderText = "Account";
            this.ColAcc.MinimumWidth = 8;
            this.ColAcc.Name = "ColAcc";
            this.ColAcc.Width = 300;
            // 
            // ColUserrole
            // 
            this.ColUserrole.HeaderText = "User role";
            this.ColUserrole.MinimumWidth = 8;
            this.ColUserrole.Name = "ColUserrole";
            this.ColUserrole.Width = 300;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.ForeColor = System.Drawing.Color.White;
            this.checkBox1.Location = new System.Drawing.Point(50, 50);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(69, 17);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Select all";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button1.Location = new System.Drawing.Point(133, 41);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 26);
            this.button1.TabIndex = 3;
            this.button1.Text = "Ban";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PaginationPanel
            // 
            this.PaginationPanel.Controls.Add(this.PaginationNavPanel);
            this.PaginationPanel.Controls.Add(this.label2);
            this.PaginationPanel.Controls.Add(this.PerPageSelect);
            this.PaginationPanel.Location = new System.Drawing.Point(50, 404);
            this.PaginationPanel.Name = "PaginationPanel";
            this.PaginationPanel.Size = new System.Drawing.Size(503, 46);
            this.PaginationPanel.TabIndex = 10;
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
            this.SwicthStoreBtn.Location = new System.Drawing.Point(535, 41);
            this.SwicthStoreBtn.Name = "SwicthStoreBtn";
            this.SwicthStoreBtn.Size = new System.Drawing.Size(75, 23);
            this.SwicthStoreBtn.TabIndex = 11;
            this.SwicthStoreBtn.Text = "SwicthStoreBtn";
            this.SwicthStoreBtn.UseVisualStyleBackColor = false;
            // 
            // FormUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1000, 450);
            this.Controls.Add(this.SwicthStoreBtn);
            this.Controls.Add(this.PaginationPanel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.UsersGrid);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormUsers";
            this.Text = "FormUsers";
            ((System.ComponentModel.ISupportInitialize)(this.UsersGrid)).EndInit();
            this.PaginationPanel.ResumeLayout(false);
            this.PaginationPanel.PerformLayout();
            this.PaginationNavPanel.ResumeLayout(false);
            this.PaginationNavPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView UsersGrid;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColSelect;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColAcc;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColUserrole;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel PaginationPanel;
        private System.Windows.Forms.Panel PaginationNavPanel;
        private System.Windows.Forms.TextBox PageInputField;
        private System.Windows.Forms.Button PageFirstBtn;
        private System.Windows.Forms.Button PrevPageBtn;
        private System.Windows.Forms.Button MoveToEndPageBtn;
        private System.Windows.Forms.Button MoveToPageBtn;
        private System.Windows.Forms.Button NextPageBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox PerPageSelect;
        private System.Windows.Forms.Button SwicthStoreBtn;
    }
}