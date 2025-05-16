namespace Pharmacy_Desktop_App
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            LoginButton = new Button();
            UserNameText = new TextBox();
            UserName = new Label();
            Password = new Label();
            PasswordText = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // LoginButton
            // 
            LoginButton.Anchor = AnchorStyles.None;
            LoginButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LoginButton.Location = new Point(259, 284);
            LoginButton.Name = "LoginButton";
            LoginButton.Padding = new Padding(2);
            LoginButton.Size = new Size(283, 51);
            LoginButton.TabIndex = 0;
            LoginButton.Text = "Login";
            LoginButton.UseVisualStyleBackColor = true;
            LoginButton.Click += LoginButton_Click_1;
            // 
            // UserNameText
            // 
            UserNameText.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            UserNameText.BackColor = SystemColors.Window;
            UserNameText.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UserNameText.Location = new Point(259, 159);
            UserNameText.Name = "UserNameText";
            UserNameText.Size = new Size(283, 38);
            UserNameText.TabIndex = 1;
            // 
            // UserName
            // 
            UserName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            UserName.AutoSize = true;
            UserName.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UserName.Location = new Point(98, 159);
            UserName.Name = "UserName";
            UserName.Size = new Size(131, 31);
            UserName.TabIndex = 2;
            UserName.Text = "User Name";
            // 
            // Password
            // 
            Password.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            Password.AutoSize = true;
            Password.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Password.Location = new Point(98, 221);
            Password.Name = "Password";
            Password.Size = new Size(114, 31);
            Password.TabIndex = 3;
            Password.Text = "Password";
            // 
            // PasswordText
            // 
            PasswordText.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            PasswordText.BorderStyle = BorderStyle.FixedSingle;
            PasswordText.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PasswordText.Location = new Point(259, 218);
            PasswordText.Name = "PasswordText";
            PasswordText.PasswordChar = '*';
            PasswordText.Size = new Size(283, 38);
            PasswordText.TabIndex = 4;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(204, 29);
            label1.Name = "label1";
            label1.Size = new Size(389, 60);
            label1.TabIndex = 5;
            label1.Text = "Pharmacy System";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(PasswordText);
            Controls.Add(Password);
            Controls.Add(UserName);
            Controls.Add(UserNameText);
            Controls.Add(LoginButton);
            MaximizeBox = false;
            MinimumSize = new Size(818, 497);
            Name = "Login";
            Text = "Login";
            WindowState = FormWindowState.Maximized;
            FormClosed += ClosedLoginForm;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button LoginButton;
        private TextBox UserNameText;
        private Label UserName;
        private Label Password;
        private TextBox PasswordText;
        private Label label1;
    }
}
