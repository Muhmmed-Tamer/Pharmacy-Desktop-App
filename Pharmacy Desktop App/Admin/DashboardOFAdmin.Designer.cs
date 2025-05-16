namespace Pharmacy_Desktop_App.Admin
{
    partial class DashboardOFAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardOFAdmin));
            AddUserButton = new Button();
            ViewUsersButton = new Button();
            ProfileButton = new Button();
            LogOutButton = new Button();
            PictureOFAdmin = new PictureBox();
            GenerateReportButton = new Button();
            DeleteUserButton = new Button();
            ((System.ComponentModel.ISupportInitialize)PictureOFAdmin).BeginInit();
            SuspendLayout();
            // 
            // AddUserButton
            // 
            AddUserButton.Anchor = AnchorStyles.Left;
            AddUserButton.BackColor = SystemColors.ScrollBar;
            AddUserButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddUserButton.Location = new Point(31, 28);
            AddUserButton.Name = "AddUserButton";
            AddUserButton.Size = new Size(219, 52);
            AddUserButton.TabIndex = 0;
            AddUserButton.Text = "Add User";
            AddUserButton.UseVisualStyleBackColor = false;
            AddUserButton.Click += AddUserButton_Click;
            // 
            // ViewUsersButton
            // 
            ViewUsersButton.Anchor = AnchorStyles.Left;
            ViewUsersButton.BackColor = SystemColors.ScrollBar;
            ViewUsersButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ViewUsersButton.Location = new Point(31, 97);
            ViewUsersButton.Name = "ViewUsersButton";
            ViewUsersButton.Size = new Size(219, 47);
            ViewUsersButton.TabIndex = 1;
            ViewUsersButton.Text = "View Users";
            ViewUsersButton.UseVisualStyleBackColor = false;
            ViewUsersButton.Click += ViewUsersButton_Click;
            // 
            // ProfileButton
            // 
            ProfileButton.Anchor = AnchorStyles.Left;
            ProfileButton.BackColor = SystemColors.ScrollBar;
            ProfileButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ProfileButton.Location = new Point(31, 164);
            ProfileButton.Name = "ProfileButton";
            ProfileButton.Size = new Size(219, 53);
            ProfileButton.TabIndex = 2;
            ProfileButton.Text = "Profile";
            ProfileButton.UseVisualStyleBackColor = false;
            ProfileButton.Click += ProfileButton_Click;
            // 
            // LogOutButton
            // 
            LogOutButton.Anchor = AnchorStyles.Left;
            LogOutButton.BackColor = SystemColors.ScrollBar;
            LogOutButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LogOutButton.Location = new Point(31, 370);
            LogOutButton.Name = "LogOutButton";
            LogOutButton.Size = new Size(219, 42);
            LogOutButton.TabIndex = 3;
            LogOutButton.Text = "Log Out";
            LogOutButton.UseVisualStyleBackColor = false;
            LogOutButton.Click += LogOutButton_Click;
            // 
            // PictureOFAdmin
            // 
            PictureOFAdmin.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PictureOFAdmin.Image = (Image)resources.GetObject("PictureOFAdmin.Image");
            PictureOFAdmin.Location = new Point(275, 12);
            PictureOFAdmin.Name = "PictureOFAdmin";
            PictureOFAdmin.Size = new Size(513, 426);
            PictureOFAdmin.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureOFAdmin.TabIndex = 4;
            PictureOFAdmin.TabStop = false;
            // 
            // GenerateReportButton
            // 
            GenerateReportButton.Anchor = AnchorStyles.Left;
            GenerateReportButton.BackColor = SystemColors.ScrollBar;
            GenerateReportButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GenerateReportButton.Location = new Point(31, 232);
            GenerateReportButton.Name = "GenerateReportButton";
            GenerateReportButton.Size = new Size(219, 53);
            GenerateReportButton.TabIndex = 6;
            GenerateReportButton.Text = "Generate Report";
            GenerateReportButton.UseVisualStyleBackColor = false;
            GenerateReportButton.Click += GenerateReportButton_Click;
            // 
            // DeleteUserButton
            // 
            DeleteUserButton.Anchor = AnchorStyles.Left;
            DeleteUserButton.BackColor = SystemColors.ScrollBar;
            DeleteUserButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DeleteUserButton.Location = new Point(31, 301);
            DeleteUserButton.Name = "DeleteUserButton";
            DeleteUserButton.Size = new Size(219, 45);
            DeleteUserButton.TabIndex = 7;
            DeleteUserButton.Text = "Delete User";
            DeleteUserButton.UseVisualStyleBackColor = false;
            DeleteUserButton.Click += DeleteUserButton_Click;
            // 
            // DashboardOFAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(DeleteUserButton);
            Controls.Add(GenerateReportButton);
            Controls.Add(PictureOFAdmin);
            Controls.Add(LogOutButton);
            Controls.Add(ProfileButton);
            Controls.Add(ViewUsersButton);
            Controls.Add(AddUserButton);
            MaximizeBox = false;
            Name = "DashboardOFAdmin";
            Text = "DashboardOFAdmin";
            WindowState = FormWindowState.Maximized;
            FormClosed += ViewLoginForm;
            Load += DashboardOFAdmin_Load;
            ((System.ComponentModel.ISupportInitialize)PictureOFAdmin).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button AddUserButton;
        private Button ViewUsersButton;
        private Button ProfileButton;
        private Button LogOutButton;
        private PictureBox PictureOFAdmin;
        private Button GenerateReportButton;
        private Button DeleteUserButton;
    }
}