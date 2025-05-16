namespace Pharmacy_Desktop_App.Pharmacist
{
    partial class VaildityCheck
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
            VaildateCheckCombobox = new ComboBox();
            CheckLabel = new Label();
            AllMedicineSearshWithValid = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)AllMedicineSearshWithValid).BeginInit();
            SuspendLayout();
            // 
            // VaildateCheckCombobox
            // 
            VaildateCheckCombobox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            VaildateCheckCombobox.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            VaildateCheckCombobox.FormattingEnabled = true;
            VaildateCheckCombobox.Location = new Point(166, 40);
            VaildateCheckCombobox.Name = "VaildateCheckCombobox";
            VaildateCheckCombobox.Size = new Size(515, 39);
            VaildateCheckCombobox.TabIndex = 0;
            VaildateCheckCombobox.SelectedIndexChanged += ChooseAnotherCategoryToSearchVaildOrNotMedicine;
            // 
            // CheckLabel
            // 
            CheckLabel.AutoSize = true;
            CheckLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CheckLabel.Location = new Point(31, 48);
            CheckLabel.Name = "CheckLabel";
            CheckLabel.Size = new Size(78, 31);
            CheckLabel.TabIndex = 1;
            CheckLabel.Text = "Check";
            // 
            // AllMedicineSearshWithValid
            // 
            AllMedicineSearshWithValid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            AllMedicineSearshWithValid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            AllMedicineSearshWithValid.BackgroundColor = SystemColors.Window;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            AllMedicineSearshWithValid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            AllMedicineSearshWithValid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            AllMedicineSearshWithValid.DefaultCellStyle = dataGridViewCellStyle2;
            AllMedicineSearshWithValid.Location = new Point(31, 94);
            AllMedicineSearshWithValid.Name = "AllMedicineSearshWithValid";
            AllMedicineSearshWithValid.RowHeadersWidth = 51;
            AllMedicineSearshWithValid.Size = new Size(650, 344);
            AllMedicineSearshWithValid.TabIndex = 2;
            // 
            // VaildityCheck
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(AllMedicineSearshWithValid);
            Controls.Add(CheckLabel);
            Controls.Add(VaildateCheckCombobox);
            MaximizeBox = false;
            MinimumSize = new Size(818, 497);
            Name = "VaildityCheck";
            Text = "VaildityCheck";
            WindowState = FormWindowState.Maximized;
            Load += VaildityCheck_Load;
            ((System.ComponentModel.ISupportInitialize)AllMedicineSearshWithValid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox VaildateCheckCombobox;
        private Label CheckLabel;
        private DataGridView AllMedicineSearshWithValid;
    }
}