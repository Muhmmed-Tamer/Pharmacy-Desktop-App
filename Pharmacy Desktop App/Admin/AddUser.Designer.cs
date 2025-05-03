namespace Pharmacy_Desktop_App
{
    partial class AddUserButton
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
            button1 = new Button();
            UserNameLabel = new Label();
            EmailLabel = new Label();
            MobileNumberLabel = new Label();
            PasswordLabel = new Label();
            UserNameText = new TextBox();
            EmailText = new TextBox();
            MobileNumberText = new TextBox();
            PasswordText = new TextBox();
            RolesBox = new ComboBox();
            RoleLabel = new Label();
            AddUserLabel = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(257, 337);
            button1.Name = "button1";
            button1.Size = new Size(337, 43);
            button1.TabIndex = 0;
            button1.Text = "Add User";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // UserNameLabel
            // 
            UserNameLabel.Anchor = AnchorStyles.Left;
            UserNameLabel.AutoSize = true;
            UserNameLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UserNameLabel.Location = new Point(67, 71);
            UserNameLabel.Name = "UserNameLabel";
            UserNameLabel.Size = new Size(131, 31);
            UserNameLabel.TabIndex = 1;
            UserNameLabel.Text = "User Name";
            // 
            // EmailLabel
            // 
            EmailLabel.Anchor = AnchorStyles.Left;
            EmailLabel.AutoSize = true;
            EmailLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EmailLabel.Location = new Point(67, 120);
            EmailLabel.Name = "EmailLabel";
            EmailLabel.Size = new Size(73, 31);
            EmailLabel.TabIndex = 2;
            EmailLabel.Text = "Email";
            // 
            // MobileNumberLabel
            // 
            MobileNumberLabel.Anchor = AnchorStyles.Left;
            MobileNumberLabel.AutoSize = true;
            MobileNumberLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MobileNumberLabel.Location = new Point(67, 173);
            MobileNumberLabel.Name = "MobileNumberLabel";
            MobileNumberLabel.Size = new Size(184, 31);
            MobileNumberLabel.TabIndex = 3;
            MobileNumberLabel.Text = "Mobile Number";
            // 
            // PasswordLabel
            // 
            PasswordLabel.Anchor = AnchorStyles.Left;
            PasswordLabel.AutoSize = true;
            PasswordLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PasswordLabel.Location = new Point(67, 270);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(114, 31);
            PasswordLabel.TabIndex = 4;
            PasswordLabel.Text = "Password";
            PasswordLabel.TextAlign = ContentAlignment.TopRight;
            // 
            // UserNameText
            // 
            UserNameText.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            UserNameText.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UserNameText.Location = new Point(257, 68);
            UserNameText.Name = "UserNameText";
            UserNameText.Size = new Size(337, 38);
            UserNameText.TabIndex = 5;
            // 
            // EmailText
            // 
            EmailText.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            EmailText.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EmailText.Location = new Point(257, 117);
            EmailText.Name = "EmailText";
            EmailText.Size = new Size(337, 38);
            EmailText.TabIndex = 6;
            // 
            // MobileNumberText
            // 
            MobileNumberText.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            MobileNumberText.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MobileNumberText.Location = new Point(257, 173);
            MobileNumberText.Name = "MobileNumberText";
            MobileNumberText.Size = new Size(337, 38);
            MobileNumberText.TabIndex = 7;
            // 
            // PasswordText
            // 
            PasswordText.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            PasswordText.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PasswordText.Location = new Point(257, 267);
            PasswordText.Name = "PasswordText";
            PasswordText.PasswordChar = '*';
            PasswordText.Size = new Size(337, 38);
            PasswordText.TabIndex = 8;
            // 
            // RolesBox
            // 
            RolesBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            RolesBox.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RolesBox.FormattingEnabled = true;
            RolesBox.Location = new Point(257, 217);
            RolesBox.Name = "RolesBox";
            RolesBox.Size = new Size(337, 39);
            RolesBox.TabIndex = 9;
            // 
            // RoleLabel
            // 
            RoleLabel.Anchor = AnchorStyles.Left;
            RoleLabel.AutoSize = true;
            RoleLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RoleLabel.Location = new Point(67, 220);
            RoleLabel.Name = "RoleLabel";
            RoleLabel.Size = new Size(61, 31);
            RoleLabel.TabIndex = 10;
            RoleLabel.Text = "Role";
            // 
            // AddUserLabel
            // 
            AddUserLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            AddUserLabel.AutoSize = true;
            AddUserLabel.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddUserLabel.Location = new Point(302, 9);
            AddUserLabel.Name = "AddUserLabel";
            AddUserLabel.Size = new Size(167, 46);
            AddUserLabel.TabIndex = 11;
            AddUserLabel.Text = "Add User";
            // 
            // AddUserButton
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(AddUserLabel);
            Controls.Add(RoleLabel);
            Controls.Add(RolesBox);
            Controls.Add(PasswordText);
            Controls.Add(MobileNumberText);
            Controls.Add(EmailText);
            Controls.Add(UserNameText);
            Controls.Add(PasswordLabel);
            Controls.Add(MobileNumberLabel);
            Controls.Add(EmailLabel);
            Controls.Add(UserNameLabel);
            Controls.Add(button1);
            MaximizeBox = false;
            MinimumSize = new Size(818, 497);
            Name = "AddUserButton";
            Text = "AddUser";
            WindowState = FormWindowState.Maximized;
            Load += AddUserButton_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label UserNameLabel;
        private Label EmailLabel;
        private Label MobileNumberLabel;
        private Label PasswordLabel;
        private TextBox UserNameText;
        private TextBox EmailText;
        private TextBox MobileNumberText;
        private TextBox PasswordText;
        private ComboBox RolesBox;
        private Label RoleLabel;
        private Label AddUserLabel;
    }
}