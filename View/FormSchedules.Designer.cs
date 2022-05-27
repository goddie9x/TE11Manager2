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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ColSelect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDayofweek = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPartofday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColRoom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDaystart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDayend = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColLinkmeet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColLinkclass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Schedules";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColSelect,
            this.ColName,
            this.ColDayofweek,
            this.ColPartofday,
            this.ColRoom,
            this.ColDaystart,
            this.ColDayend,
            this.ColTime,
            this.ColLinkmeet,
            this.ColLinkclass});
            this.dataGridView1.Location = new System.Drawing.Point(20, 121);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1397, 501);
            this.dataGridView1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button1.Location = new System.Drawing.Point(20, 74);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 41);
            this.button1.TabIndex = 2;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(1366, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(51, 41);
            this.button2.TabIndex = 3;
            this.button2.Text = "x";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // ColSelect
            // 
            this.ColSelect.HeaderText = "Select";
            this.ColSelect.MinimumWidth = 8;
            this.ColSelect.Name = "ColSelect";
            this.ColSelect.Width = 55;
            // 
            // ColName
            // 
            this.ColName.HeaderText = "Name";
            this.ColName.MinimumWidth = 8;
            this.ColName.Name = "ColName";
            this.ColName.Width = 150;
            // 
            // ColDayofweek
            // 
            this.ColDayofweek.HeaderText = "Day of week";
            this.ColDayofweek.MinimumWidth = 8;
            this.ColDayofweek.Name = "ColDayofweek";
            this.ColDayofweek.Width = 150;
            // 
            // ColPartofday
            // 
            this.ColPartofday.HeaderText = "Part of day";
            this.ColPartofday.MinimumWidth = 8;
            this.ColPartofday.Name = "ColPartofday";
            this.ColPartofday.Width = 150;
            // 
            // ColRoom
            // 
            this.ColRoom.HeaderText = "Room";
            this.ColRoom.MinimumWidth = 8;
            this.ColRoom.Name = "ColRoom";
            this.ColRoom.Width = 70;
            // 
            // ColDaystart
            // 
            this.ColDaystart.HeaderText = "Day start";
            this.ColDaystart.MinimumWidth = 8;
            this.ColDaystart.Name = "ColDaystart";
            this.ColDaystart.Width = 150;
            // 
            // ColDayend
            // 
            this.ColDayend.HeaderText = "Day end";
            this.ColDayend.MinimumWidth = 8;
            this.ColDayend.Name = "ColDayend";
            this.ColDayend.Width = 150;
            // 
            // ColTime
            // 
            this.ColTime.HeaderText = "Time";
            this.ColTime.MinimumWidth = 8;
            this.ColTime.Name = "ColTime";
            this.ColTime.Width = 150;
            // 
            // ColLinkmeet
            // 
            this.ColLinkmeet.HeaderText = "Link meet";
            this.ColLinkmeet.MinimumWidth = 8;
            this.ColLinkmeet.Name = "ColLinkmeet";
            this.ColLinkmeet.Width = 150;
            // 
            // ColLinkclass
            // 
            this.ColLinkclass.HeaderText = "Link classroom";
            this.ColLinkclass.MinimumWidth = 8;
            this.ColLinkclass.Name = "ColLinkclass";
            this.ColLinkclass.Width = 155;
            // 
            // FormSchedules
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1429, 634);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSchedules";
            this.Text = "FormSchedules";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColSelect;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDayofweek;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPartofday;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColRoom;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDaystart;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDayend;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColLinkmeet;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColLinkclass;
    }
}