namespace Pharmacy_Desktop_App.Admin
{
    partial class DeleteUserBoard
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
            DeleteUserButton = new Button();
            emailOfUserLabel = new Label();
            EamilOfUserTextBox = new TextBox();
            SuspendLayout();
            // 
            // DeleteUserButton
            // 
            DeleteUserButton.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            DeleteUserButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DeleteUserButton.Location = new Point(167, 222);
            DeleteUserButton.Name = "DeleteUserButton";
            DeleteUserButton.Size = new Size(474, 42);
            DeleteUserButton.TabIndex = 0;
            DeleteUserButton.Text = "Delete User";
            DeleteUserButton.UseVisualStyleBackColor = true;
            DeleteUserButton.Click += DeleteUserButton_Click;
            // 
            // emailOfUserLabel
            // 
            emailOfUserLabel.Anchor = AnchorStyles.Left;
            emailOfUserLabel.AutoSize = true;
            emailOfUserLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            emailOfUserLabel.Location = new Point(33, 103);
            emailOfUserLabel.Name = "emailOfUserLabel";
            emailOfUserLabel.Size = new Size(162, 31);
            emailOfUserLabel.TabIndex = 1;
            emailOfUserLabel.Text = "Email OF User";
            // 
            // EamilOfUserTextBox
            // 
            EamilOfUserTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            EamilOfUserTextBox.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EamilOfUserTextBox.Location = new Point(201, 96);
            EamilOfUserTextBox.Name = "EamilOfUserTextBox";
            EamilOfUserTextBox.Size = new Size(561, 38);
            EamilOfUserTextBox.TabIndex = 2;
            EamilOfUserTextBox.KeyUp += KeyUpToWriteEmailOFUser;
            // 
            // DeleteUserBoard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(EamilOfUserTextBox);
            Controls.Add(emailOfUserLabel);
            Controls.Add(DeleteUserButton);
            MinimizeBox = false;
            Name = "DeleteUserBoard";
            Text = "DeleteUserBoard";
            WindowState = FormWindowState.Maximized;
            Load += DeleteUserBoard_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button DeleteUserButton;
        private Label emailOfUserLabel;
        private TextBox EamilOfUserTextBox;
    }
}