namespace Pharmacy_Desktop_App.Admin
{
    partial class Profile
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
            UserNameLabel = new Label();
            EmailLabel = new Label();
            MobileLabel = new Label();
            UserNameText = new TextBox();
            EmailText = new TextBox();
            MobileText = new TextBox();
            SuspendLayout();
            // 
            // UserNameLabel
            // 
            UserNameLabel.Anchor = AnchorStyles.Left;
            UserNameLabel.AutoSize = true;
            UserNameLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UserNameLabel.Location = new Point(165, 32);
            UserNameLabel.Name = "UserNameLabel";
            UserNameLabel.Size = new Size(131, 31);
            UserNameLabel.TabIndex = 0;
            UserNameLabel.Text = "User Name";
            // 
            // EmailLabel
            // 
            EmailLabel.Anchor = AnchorStyles.Left;
            EmailLabel.AutoSize = true;
            EmailLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EmailLabel.Location = new Point(175, 119);
            EmailLabel.Name = "EmailLabel";
            EmailLabel.Size = new Size(73, 31);
            EmailLabel.TabIndex = 1;
            EmailLabel.Text = "Email";
            // 
            // MobileLabel
            // 
            MobileLabel.Anchor = AnchorStyles.Left;
            MobileLabel.AutoSize = true;
            MobileLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MobileLabel.Location = new Point(175, 192);
            MobileLabel.Name = "MobileLabel";
            MobileLabel.Size = new Size(90, 31);
            MobileLabel.TabIndex = 2;
            MobileLabel.Text = "Mobile";
            // 
            // UserNameText
            // 
            UserNameText.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            UserNameText.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UserNameText.Location = new Point(324, 25);
            UserNameText.Name = "UserNameText";
            UserNameText.ReadOnly = true;
            UserNameText.Size = new Size(341, 38);
            UserNameText.TabIndex = 3;
            // 
            // EmailText
            // 
            EmailText.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            EmailText.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EmailText.Location = new Point(324, 112);
            EmailText.Name = "EmailText";
            EmailText.ReadOnly = true;
            EmailText.Size = new Size(341, 38);
            EmailText.TabIndex = 4;
            // 
            // MobileText
            // 
            MobileText.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            MobileText.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MobileText.Location = new Point(324, 189);
            MobileText.Name = "MobileText";
            MobileText.ReadOnly = true;
            MobileText.Size = new Size(341, 38);
            MobileText.TabIndex = 5;
            // 
            // Profile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(MobileText);
            Controls.Add(EmailText);
            Controls.Add(UserNameText);
            Controls.Add(MobileLabel);
            Controls.Add(EmailLabel);
            Controls.Add(UserNameLabel);
            MaximizeBox = false;
            MinimumSize = new Size(818, 497);
            Name = "Profile";
            Text = "Profile";
            WindowState = FormWindowState.Maximized;
            Load += Profile_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label UserNameLabel;
        private Label EmailLabel;
        private Label MobileLabel;
        private TextBox UserNameText;
        private TextBox EmailText;
        private TextBox MobileText;
    }
}