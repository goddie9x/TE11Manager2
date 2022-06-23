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
            this.logoutBtn = new FontAwesome.Sharp.IconButton();
            this.btnuser = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.UserFullNameLabel = new System.Windows.Forms.Label();
            this.AvatarImage = new System.Windows.Forms.PictureBox();
            this.btnschedule = new FontAwesome.Sharp.IconButton();
            this.btndashboard = new FontAwesome.Sharp.IconButton();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AvatarImage)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panelMenu.Controls.Add(this.logoutBtn);
            this.panelMenu.Controls.Add(this.btnuser);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Controls.Add(this.btnschedule);
            this.panelMenu.Controls.Add(this.btndashboard);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(4);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(224, 600);
            this.panelMenu.TabIndex = 0;
            // 
            // logoutBtn
            // 
            this.logoutBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.logoutBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoutBtn.FlatAppearance.BorderSize = 0;
            this.logoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.logoutBtn.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.logoutBtn.IconChar = FontAwesome.Sharp.IconChar.Lock;
            this.logoutBtn.IconColor = System.Drawing.Color.White;
            this.logoutBtn.IconSize = 32;
            this.logoutBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logoutBtn.Location = new System.Drawing.Point(0, 508);
            this.logoutBtn.Margin = new System.Windows.Forms.Padding(4);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Padding = new System.Windows.Forms.Padding(10, 0, 24, 0);
            this.logoutBtn.Rotation = 0D;
            this.logoutBtn.Size = new System.Drawing.Size(225, 80);
            this.logoutBtn.TabIndex = 6;
            this.logoutBtn.Text = "Logout";
            this.logoutBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logoutBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.logoutBtn.UseVisualStyleBackColor = true;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // btnuser
            // 
            this.btnuser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnuser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnuser.FlatAppearance.BorderSize = 0;
            this.btnuser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnuser.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnuser.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnuser.ForeColor = System.Drawing.SystemColors.Control;
            this.btnuser.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.btnuser.IconColor = System.Drawing.Color.White;
            this.btnuser.IconSize = 32;
            this.btnuser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnuser.Location = new System.Drawing.Point(0, 415);
            this.btnuser.Margin = new System.Windows.Forms.Padding(4);
            this.btnuser.Name = "btnuser";
            this.btnuser.Padding = new System.Windows.Forms.Padding(10, 0, 24, 0);
            this.btnuser.Rotation = 0D;
            this.btnuser.Size = new System.Drawing.Size(225, 80);
            this.btnuser.TabIndex = 5;
            this.btnuser.Text = "Users";
            this.btnuser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnuser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnuser.UseVisualStyleBackColor = true;
            this.btnuser.Click += new System.EventHandler(this.btnuser_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.UserFullNameLabel);
            this.panelLogo.Controls.Add(this.AvatarImage);
            this.panelLogo.Location = new System.Drawing.Point(0, 4);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(4);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(224, 220);
            this.panelLogo.TabIndex = 0;
            // 
            // UserFullNameLabel
            // 
            this.UserFullNameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UserFullNameLabel.AutoSize = true;
            this.UserFullNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserFullNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(149)))));
            this.UserFullNameLabel.Location = new System.Drawing.Point(48, 168);
            this.UserFullNameLabel.Name = "UserFullNameLabel";
            this.UserFullNameLabel.Size = new System.Drawing.Size(114, 24);
            this.UserFullNameLabel.TabIndex = 1;
            this.UserFullNameLabel.Text = "User Name";
            this.UserFullNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AvatarImage
            // 
            this.AvatarImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AvatarImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AvatarImage.Image = ((System.Drawing.Image)(resources.GetObject("AvatarImage.Image")));
            this.AvatarImage.Location = new System.Drawing.Point(48, 42);
            this.AvatarImage.Name = "AvatarImage";
            this.AvatarImage.Size = new System.Drawing.Size(114, 123);
            this.AvatarImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AvatarImage.TabIndex = 0;
            this.AvatarImage.TabStop = false;
            this.AvatarImage.Click += new System.EventHandler(this.AvatarImage_Click);
            // 
            // btnschedule
            // 
            this.btnschedule.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnschedule.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnschedule.FlatAppearance.BorderSize = 0;
            this.btnschedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnschedule.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnschedule.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnschedule.ForeColor = System.Drawing.SystemColors.Control;
            this.btnschedule.IconChar = FontAwesome.Sharp.IconChar.IdCard;
            this.btnschedule.IconColor = System.Drawing.Color.White;
            this.btnschedule.IconSize = 32;
            this.btnschedule.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnschedule.Location = new System.Drawing.Point(0, 328);
            this.btnschedule.Margin = new System.Windows.Forms.Padding(4);
            this.btnschedule.Name = "btnschedule";
            this.btnschedule.Padding = new System.Windows.Forms.Padding(10, 0, 24, 0);
            this.btnschedule.Rotation = 0D;
            this.btnschedule.Size = new System.Drawing.Size(225, 80);
            this.btnschedule.TabIndex = 3;
            this.btnschedule.Text = "Schedule";
            this.btnschedule.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnschedule.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnschedule.UseVisualStyleBackColor = true;
            this.btnschedule.Click += new System.EventHandler(this.btnschedule_Click);
            // 
            // btndashboard
            // 
            this.btndashboard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btndashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btndashboard.FlatAppearance.BorderSize = 0;
            this.btndashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndashboard.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btndashboard.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndashboard.ForeColor = System.Drawing.SystemColors.Control;
            this.btndashboard.IconChar = FontAwesome.Sharp.IconChar.ChartBar;
            this.btndashboard.IconColor = System.Drawing.Color.White;
            this.btndashboard.IconSize = 32;
            this.btndashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btndashboard.Location = new System.Drawing.Point(0, 232);
            this.btndashboard.Margin = new System.Windows.Forms.Padding(4);
            this.btndashboard.Name = "btndashboard";
            this.btndashboard.Padding = new System.Windows.Forms.Padding(10, 0, 24, 0);
            this.btndashboard.Rotation = 0D;
            this.btndashboard.Size = new System.Drawing.Size(225, 80);
            this.btndashboard.TabIndex = 1;
            this.btndashboard.Text = "Dashboard";
            this.btndashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btndashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btndashboard.UseVisualStyleBackColor = true;
            this.btndashboard.Click += new System.EventHandler(this.btndashboard_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(224, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1005, 600);
            this.mainPanel.TabIndex = 1;
            this.mainPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // panelDesktop
            // 
            this.panelDesktop.AutoSize = true;
            this.panelDesktop.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDesktop.Location = new System.Drawing.Point(224, 0);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1005, 0);
            this.panelDesktop.TabIndex = 3;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1229, 600);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.panelMenu);
            this.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1200, 600);
            this.Name = "FormMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TE11 Panel";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AvatarImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton btnuser;
        private FontAwesome.Sharp.IconButton btnschedule;
        private FontAwesome.Sharp.IconButton btndashboard;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.PictureBox AvatarImage;
        private System.Windows.Forms.Label UserFullNameLabel;
        private FontAwesome.Sharp.IconButton logoutBtn;
    }
}

