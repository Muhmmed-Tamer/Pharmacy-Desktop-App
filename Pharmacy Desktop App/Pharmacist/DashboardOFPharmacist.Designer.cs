namespace Pharmacy_Desktop_App.Pharmacist
{
    partial class DashboardOFPharmacist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardOFPharmacist));
            AddMedicineButton = new Button();
            ViewMedicineButton = new Button();
            ModifyMedicineButton = new Button();
            ValidityCheckButton = new Button();
            SellMedicineButton = new Button();
            LogOutButton = new Button();
            pictureBox1 = new PictureBox();
            AllMedicineButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // AddMedicineButton
            // 
            AddMedicineButton.Anchor = AnchorStyles.Left;
            AddMedicineButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddMedicineButton.Location = new Point(12, 21);
            AddMedicineButton.Margin = new Padding(10);
            AddMedicineButton.Name = "AddMedicineButton";
            AddMedicineButton.Size = new Size(211, 41);
            AddMedicineButton.TabIndex = 0;
            AddMedicineButton.Text = "Add Medicine";
            AddMedicineButton.UseVisualStyleBackColor = true;
            AddMedicineButton.Click += AddMedicineButton_Click;
            // 
            // ViewMedicineButton
            // 
            ViewMedicineButton.Anchor = AnchorStyles.Left;
            ViewMedicineButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ViewMedicineButton.Location = new Point(12, 80);
            ViewMedicineButton.Margin = new Padding(10);
            ViewMedicineButton.Name = "ViewMedicineButton";
            ViewMedicineButton.Size = new Size(211, 39);
            ViewMedicineButton.TabIndex = 1;
            ViewMedicineButton.Text = "View Medicine";
            ViewMedicineButton.UseVisualStyleBackColor = true;
            ViewMedicineButton.Click += ViewMedicineButton_Click;
            // 
            // ModifyMedicineButton
            // 
            ModifyMedicineButton.Anchor = AnchorStyles.Left;
            ModifyMedicineButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ModifyMedicineButton.Location = new Point(12, 148);
            ModifyMedicineButton.Margin = new Padding(10);
            ModifyMedicineButton.Name = "ModifyMedicineButton";
            ModifyMedicineButton.Size = new Size(211, 39);
            ModifyMedicineButton.TabIndex = 2;
            ModifyMedicineButton.Text = "Modify Medicine";
            ModifyMedicineButton.UseVisualStyleBackColor = true;
            ModifyMedicineButton.Click += ModifyMedicineButton_Click;
            // 
            // ValidityCheckButton
            // 
            ValidityCheckButton.Anchor = AnchorStyles.Left;
            ValidityCheckButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ValidityCheckButton.Location = new Point(12, 213);
            ValidityCheckButton.Margin = new Padding(10);
            ValidityCheckButton.Name = "ValidityCheckButton";
            ValidityCheckButton.Size = new Size(211, 41);
            ValidityCheckButton.TabIndex = 3;
            ValidityCheckButton.Text = "Validity Check";
            ValidityCheckButton.UseVisualStyleBackColor = true;
            ValidityCheckButton.Click += ValidityCheckButton_Click;
            // 
            // SellMedicineButton
            // 
            SellMedicineButton.Anchor = AnchorStyles.Left;
            SellMedicineButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SellMedicineButton.Location = new Point(12, 273);
            SellMedicineButton.Margin = new Padding(10);
            SellMedicineButton.Name = "SellMedicineButton";
            SellMedicineButton.Size = new Size(211, 44);
            SellMedicineButton.TabIndex = 4;
            SellMedicineButton.Text = "Sell Medicine";
            SellMedicineButton.UseVisualStyleBackColor = true;
            SellMedicineButton.Click += SellMedicineButton_Click;
            // 
            // LogOutButton
            // 
            LogOutButton.Anchor = AnchorStyles.Left;
            LogOutButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LogOutButton.Location = new Point(12, 400);
            LogOutButton.Margin = new Padding(10);
            LogOutButton.MinimumSize = new Size(159, 29);
            LogOutButton.Name = "LogOutButton";
            LogOutButton.Size = new Size(211, 38);
            LogOutButton.TabIndex = 5;
            LogOutButton.Text = "Log Out";
            LogOutButton.UseVisualStyleBackColor = true;
            LogOutButton.Click += LogOutButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(229, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(585, 349);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // AllMedicineButton
            // 
            AllMedicineButton.Anchor = AnchorStyles.Left;
            AllMedicineButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AllMedicineButton.Location = new Point(12, 340);
            AllMedicineButton.Margin = new Padding(10);
            AllMedicineButton.Name = "AllMedicineButton";
            AllMedicineButton.Size = new Size(211, 43);
            AllMedicineButton.TabIndex = 7;
            AllMedicineButton.Text = "All Sell Medicine";
            AllMedicineButton.UseVisualStyleBackColor = true;
            AllMedicineButton.Click += AllMedicineButton_Click;
            // 
            // DashboardOFPharmacist
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(826, 450);
            Controls.Add(AllMedicineButton);
            Controls.Add(pictureBox1);
            Controls.Add(LogOutButton);
            Controls.Add(SellMedicineButton);
            Controls.Add(ValidityCheckButton);
            Controls.Add(ModifyMedicineButton);
            Controls.Add(ViewMedicineButton);
            Controls.Add(AddMedicineButton);
            MaximizeBox = false;
            Name = "DashboardOFPharmacist";
            Text = "DashboardOFPharmacist";
            WindowState = FormWindowState.Maximized;
            FormClosed += ViewLoginForm;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button AddMedicineButton;
        private Button ViewMedicineButton;
        private Button ModifyMedicineButton;
        private Button ValidityCheckButton;
        private Button SellMedicineButton;
        private Button LogOutButton;
        private PictureBox pictureBox1;
        private Button AllMedicineButton;
    }
}