namespace Pharmacy_Desktop_App.Admin
{
    partial class ViewUsers
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridOFAllUsers = new DataGridView();
            AllUsersLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)DataGridOFAllUsers).BeginInit();
            SuspendLayout();
            // 
            // DataGridOFAllUsers
            // 
            DataGridOFAllUsers.AllowUserToAddRows = false;
            DataGridOFAllUsers.AllowUserToDeleteRows = false;
            DataGridOFAllUsers.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            DataGridOFAllUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGridOFAllUsers.BackgroundColor = SystemColors.Window;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            DataGridOFAllUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            DataGridOFAllUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            DataGridOFAllUsers.DefaultCellStyle = dataGridViewCellStyle2;
            DataGridOFAllUsers.Location = new Point(12, 71);
            DataGridOFAllUsers.Name = "DataGridOFAllUsers";
            DataGridOFAllUsers.ReadOnly = true;
            DataGridOFAllUsers.RowHeadersWidth = 51;
            DataGridOFAllUsers.Size = new Size(776, 303);
            DataGridOFAllUsers.TabIndex = 0;
            // 
            // AllUsersLabel
            // 
            AllUsersLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            AllUsersLabel.AutoSize = true;
            AllUsersLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AllUsersLabel.Location = new Point(324, 7);
            AllUsersLabel.Name = "AllUsersLabel";
            AllUsersLabel.Size = new Size(141, 41);
            AllUsersLabel.TabIndex = 1;
            AllUsersLabel.Text = "All Users";
            // 
            // ViewUsers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(AllUsersLabel);
            Controls.Add(DataGridOFAllUsers);
            MaximizeBox = false;
            MinimumSize = new Size(818, 497);
            Name = "ViewUsers";
            Text = "ViewUsers";
            WindowState = FormWindowState.Maximized;
            Load += ViewUsers_Load;
            ((System.ComponentModel.ISupportInitialize)DataGridOFAllUsers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DataGridOFAllUsers;
        private Label AllUsersLabel;
    }
}