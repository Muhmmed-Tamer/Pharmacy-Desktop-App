namespace Pharmacy_Desktop_App.Pharmacist
{
    partial class ViewMedicines
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
            MedicineNameTextWouldToSearch = new TextBox();
            MedicineNameLabel = new Label();
            AllMedicines = new DataGridView();
            DeleteMedicineButton = new Button();
            ((System.ComponentModel.ISupportInitialize)AllMedicines).BeginInit();
            SuspendLayout();
            // 
            // MedicineNameTextWouldToSearch
            // 
            MedicineNameTextWouldToSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            MedicineNameTextWouldToSearch.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MedicineNameTextWouldToSearch.Location = new Point(231, 78);
            MedicineNameTextWouldToSearch.Name = "MedicineNameTextWouldToSearch";
            MedicineNameTextWouldToSearch.Size = new Size(526, 38);
            MedicineNameTextWouldToSearch.TabIndex = 0;
            MedicineNameTextWouldToSearch.KeyUp += SearchAboutMedicineWhenKeyUp;
            // 
            // MedicineNameLabel
            // 
            MedicineNameLabel.AutoSize = true;
            MedicineNameLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MedicineNameLabel.Location = new Point(43, 81);
            MedicineNameLabel.Name = "MedicineNameLabel";
            MedicineNameLabel.Size = new Size(182, 31);
            MedicineNameLabel.TabIndex = 1;
            MedicineNameLabel.Text = "Medicine Name";
            // 
            // AllMedicines
            // 
            AllMedicines.AllowUserToAddRows = false;
            AllMedicines.AllowUserToDeleteRows = false;
            AllMedicines.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            AllMedicines.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            AllMedicines.BackgroundColor = SystemColors.Window;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            AllMedicines.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            AllMedicines.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AllMedicines.Location = new Point(43, 157);
            AllMedicines.Name = "AllMedicines";
            AllMedicines.ReadOnly = true;
            AllMedicines.RowHeadersWidth = 100;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AllMedicines.RowsDefaultCellStyle = dataGridViewCellStyle2;
            AllMedicines.Size = new Size(714, 226);
            AllMedicines.TabIndex = 2;
            // 
            // DeleteMedicineButton
            // 
            DeleteMedicineButton.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            DeleteMedicineButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DeleteMedicineButton.Location = new Point(165, 397);
            DeleteMedicineButton.Name = "DeleteMedicineButton";
            DeleteMedicineButton.Size = new Size(467, 41);
            DeleteMedicineButton.TabIndex = 3;
            DeleteMedicineButton.Text = "Delete Medicine";
            DeleteMedicineButton.UseVisualStyleBackColor = true;
            DeleteMedicineButton.Click += DeleteMedicineButton_Click;
            // 
            // ViewMedicines
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(DeleteMedicineButton);
            Controls.Add(AllMedicines);
            Controls.Add(MedicineNameLabel);
            Controls.Add(MedicineNameTextWouldToSearch);
            MaximizeBox = false;
            MinimumSize = new Size(818, 497);
            Name = "ViewMedicines";
            Text = "ViewMedicines";
            WindowState = FormWindowState.Maximized;
            Load += ViewMedicines_Load;
            ((System.ComponentModel.ISupportInitialize)AllMedicines).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox MedicineNameTextWouldToSearch;
        private Label MedicineNameLabel;
        private DataGridView AllMedicines;
        private Button DeleteMedicineButton;
    }
}