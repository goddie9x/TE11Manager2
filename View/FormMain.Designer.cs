namespace TE11Manager.View
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnuser = new FontAwesome.Sharp.IconButton();
            this.btnschedule = new FontAwesome.Sharp.IconButton();
            this.btndashboard = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.labelTitleChild = new System.Windows.Forms.Label();
            this.iconCurentChild = new FontAwesome.Sharp.IconPictureBox();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurentChild)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panelMenu.Controls.Add(this.btnuser);
            this.panelMenu.Controls.Add(this.btnschedule);
            this.panelMenu.Controls.Add(this.btndashboard);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(4);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(249, 641);
            this.panelMenu.TabIndex = 0;
            // 
            // btnuser
            // 
            this.btnuser.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnuser.FlatAppearance.BorderSize = 0;
            this.btnuser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnuser.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnuser.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnuser.ForeColor = System.Drawing.SystemColors.Control;
            this.btnuser.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.btnuser.IconColor = System.Drawing.Color.White;
            this.btnuser.IconSize = 32;
            this.btnuser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnuser.Location = new System.Drawing.Point(0, 378);
            this.btnuser.Margin = new System.Windows.Forms.Padding(4);
            this.btnuser.Name = "btnuser";
            this.btnuser.Padding = new System.Windows.Forms.Padding(10, 0, 24, 0);
            this.btnuser.Rotation = 0D;
            this.btnuser.Size = new System.Drawing.Size(249, 79);
            this.btnuser.TabIndex = 5;
            this.btnuser.Text = "Users";
            this.btnuser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnuser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnuser.UseVisualStyleBackColor = true;
            this.btnuser.Click += new System.EventHandler(this.btnuser_Click);
            // 
            // btnschedule
            // 
            this.btnschedule.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnschedule.FlatAppearance.BorderSize = 0;
            this.btnschedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnschedule.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnschedule.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnschedule.ForeColor = System.Drawing.SystemColors.Control;
            this.btnschedule.IconChar = FontAwesome.Sharp.IconChar.IdCard;
            this.btnschedule.IconColor = System.Drawing.Color.White;
            this.btnschedule.IconSize = 32;
            this.btnschedule.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnschedule.Location = new System.Drawing.Point(0, 299);
            this.btnschedule.Margin = new System.Windows.Forms.Padding(4);
            this.btnschedule.Name = "btnschedule";
            this.btnschedule.Padding = new System.Windows.Forms.Padding(10, 0, 24, 0);
            this.btnschedule.Rotation = 0D;
            this.btnschedule.Size = new System.Drawing.Size(249, 79);
            this.btnschedule.TabIndex = 3;
            this.btnschedule.Text = "Schedule";
            this.btnschedule.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnschedule.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnschedule.UseVisualStyleBackColor = true;
            this.btnschedule.Click += new System.EventHandler(this.btnschedule_Click);
            // 
            // btndashboard
            // 
            this.btndashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btndashboard.FlatAppearance.BorderSize = 0;
            this.btndashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndashboard.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btndashboard.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndashboard.ForeColor = System.Drawing.SystemColors.Control;
            this.btndashboard.IconChar = FontAwesome.Sharp.IconChar.ChartBar;
            this.btndashboard.IconColor = System.Drawing.Color.White;
            this.btndashboard.IconSize = 32;
            this.btndashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btndashboard.Location = new System.Drawing.Point(0, 220);
            this.btndashboard.Margin = new System.Windows.Forms.Padding(4);
            this.btndashboard.Name = "btndashboard";
            this.btndashboard.Padding = new System.Windows.Forms.Padding(10, 0, 24, 0);
            this.btndashboard.Rotation = 0D;
            this.btndashboard.Size = new System.Drawing.Size(249, 79);
            this.btndashboard.TabIndex = 1;
            this.btndashboard.Text = "Dashboard";
            this.btndashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btndashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btndashboard.UseVisualStyleBackColor = true;
            this.btndashboard.Click += new System.EventHandler(this.btndashboard_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.label1);
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(4);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(249, 220);
            this.panelLogo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(149)))));
            this.label1.Location = new System.Drawing.Point(48, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "User Name";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(71, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(114, 123);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panelTitleBar.Controls.Add(this.button1);
            this.panelTitleBar.Controls.Add(this.labelTitleChild);
            this.panelTitleBar.Controls.Add(this.iconCurentChild);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTitleBar.Location = new System.Drawing.Point(249, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(825, 641);
            this.panelTitleBar.TabIndex = 1;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(768, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 45);
            this.button1.TabIndex = 2;
            this.button1.Text = "x";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // labelTitleChild
            // 
            this.labelTitleChild.AutoSize = true;
            this.labelTitleChild.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitleChild.ForeColor = System.Drawing.SystemColors.Control;
            this.labelTitleChild.Location = new System.Drawing.Point(56, 26);
            this.labelTitleChild.Name = "labelTitleChild";
            this.labelTitleChild.Size = new System.Drawing.Size(79, 32);
            this.labelTitleChild.TabIndex = 1;
            this.labelTitleChild.Text = "Home";
            // 
            // iconCurentChild
            // 
            this.iconCurentChild.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.iconCurentChild.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.iconCurentChild.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconCurentChild.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.iconCurentChild.Location = new System.Drawing.Point(18, 26);
            this.iconCurentChild.Name = "iconCurentChild";
            this.iconCurentChild.Size = new System.Drawing.Size(32, 32);
            this.iconCurentChild.TabIndex = 0;
            this.iconCurentChild.TabStop = false;
            // 
            // panelDesktop
            // 
            this.panelDesktop.AutoSize = true;
            this.panelDesktop.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDesktop.Location = new System.Drawing.Point(249, 0);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(825, 0);
            this.panelDesktop.TabIndex = 3;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 641);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurentChild)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton btnuser;
        private FontAwesome.Sharp.IconButton btnschedule;
        private FontAwesome.Sharp.IconButton btndashboard;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelTitleBar;
        private FontAwesome.Sharp.IconPictureBox iconCurentChild;
        private System.Windows.Forms.Label labelTitleChild;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}

