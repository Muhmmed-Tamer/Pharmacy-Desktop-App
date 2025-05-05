namespace Pharmacy_Desktop_App.Admin
{
    partial class ReportOFAdmin
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DropDownListOfGenerateReportBy = new ComboBox();
            GenerateReportByLabel = new Label();
            GenerateReportDataGridView = new DataGridView();
            DayLabel = new Label();
            MonthLabel = new Label();
            YearLabel = new Label();
            GenerateReportButton = new Button();
            TotalPriceOfReportLablel = new Label();
            TotalPriceOfReport = new NumericUpDown();
            DateLabel = new Label();
            DateText = new TextBox();
            DayDropDownList = new ComboBox();
            MonthDropDownList = new ComboBox();
            YearDropDownList = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)GenerateReportDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TotalPriceOfReport).BeginInit();
            SuspendLayout();
            // 
            // DropDownListOfGenerateReportBy
            // 
            DropDownListOfGenerateReportBy.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DropDownListOfGenerateReportBy.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DropDownListOfGenerateReportBy.FormattingEnabled = true;
            DropDownListOfGenerateReportBy.Location = new Point(194, 19);
            DropDownListOfGenerateReportBy.Name = "DropDownListOfGenerateReportBy";
            DropDownListOfGenerateReportBy.Size = new Size(594, 36);
            DropDownListOfGenerateReportBy.TabIndex = 0;
            DropDownListOfGenerateReportBy.SelectedValueChanged += SelectedValueChanged;
            // 
            // GenerateReportByLabel
            // 
            GenerateReportByLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            GenerateReportByLabel.AutoSize = true;
            GenerateReportByLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GenerateReportByLabel.Location = new Point(7, 30);
            GenerateReportByLabel.Name = "GenerateReportByLabel";
            GenerateReportByLabel.Size = new Size(181, 25);
            GenerateReportByLabel.TabIndex = 1;
            GenerateReportByLabel.Text = "Generate Report By";
            // 
            // GenerateReportDataGridView
            // 
            GenerateReportDataGridView.AllowUserToAddRows = false;
            GenerateReportDataGridView.AllowUserToDeleteRows = false;
            GenerateReportDataGridView.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            GenerateReportDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            GenerateReportDataGridView.BackgroundColor = SystemColors.Window;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            GenerateReportDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            GenerateReportDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            GenerateReportDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            GenerateReportDataGridView.GridColor = SystemColors.Window;
            GenerateReportDataGridView.Location = new Point(12, 308);
            GenerateReportDataGridView.Name = "GenerateReportDataGridView";
            GenerateReportDataGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            GenerateReportDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            GenerateReportDataGridView.RowHeadersWidth = 51;
            GenerateReportDataGridView.Size = new Size(776, 216);
            GenerateReportDataGridView.TabIndex = 2;
            // 
            // DayLabel
            // 
            DayLabel.Anchor = AnchorStyles.Left;
            DayLabel.AutoSize = true;
            DayLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DayLabel.Location = new Point(12, 159);
            DayLabel.Name = "DayLabel";
            DayLabel.Size = new Size(49, 28);
            DayLabel.TabIndex = 3;
            DayLabel.Text = "Day";
            // 
            // MonthLabel
            // 
            MonthLabel.Anchor = AnchorStyles.Left;
            MonthLabel.AutoSize = true;
            MonthLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MonthLabel.Location = new Point(7, 116);
            MonthLabel.Name = "MonthLabel";
            MonthLabel.Size = new Size(75, 28);
            MonthLabel.TabIndex = 4;
            MonthLabel.Text = "Month";
            // 
            // YearLabel
            // 
            YearLabel.Anchor = AnchorStyles.Left;
            YearLabel.AutoSize = true;
            YearLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            YearLabel.Location = new Point(9, 72);
            YearLabel.Name = "YearLabel";
            YearLabel.Size = new Size(52, 28);
            YearLabel.TabIndex = 5;
            YearLabel.Text = "Year";
            // 
            // GenerateReportButton
            // 
            GenerateReportButton.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            GenerateReportButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GenerateReportButton.Location = new Point(9, 199);
            GenerateReportButton.Name = "GenerateReportButton";
            GenerateReportButton.Size = new Size(776, 47);
            GenerateReportButton.TabIndex = 9;
            GenerateReportButton.Text = "Generate Report";
            GenerateReportButton.UseVisualStyleBackColor = true;
            GenerateReportButton.Click += GenerateReportButton_Click;
            // 
            // TotalPriceOfReportLablel
            // 
            TotalPriceOfReportLablel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            TotalPriceOfReportLablel.AutoSize = true;
            TotalPriceOfReportLablel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TotalPriceOfReportLablel.Location = new Point(9, 534);
            TotalPriceOfReportLablel.Name = "TotalPriceOfReportLablel";
            TotalPriceOfReportLablel.Size = new Size(126, 31);
            TotalPriceOfReportLablel.TabIndex = 16;
            TotalPriceOfReportLablel.Text = "Total Price";
            // 
            // TotalPriceOfReport
            // 
            TotalPriceOfReport.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TotalPriceOfReport.BackColor = Color.LimeGreen;
            TotalPriceOfReport.DecimalPlaces = 2;
            TotalPriceOfReport.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TotalPriceOfReport.Location = new Point(150, 534);
            TotalPriceOfReport.Maximum = new decimal(new int[] { 276447232, 23283, 0, 0 });
            TotalPriceOfReport.Name = "TotalPriceOfReport";
            TotalPriceOfReport.ReadOnly = true;
            TotalPriceOfReport.Size = new Size(638, 38);
            TotalPriceOfReport.TabIndex = 17;
            // 
            // DateLabel
            // 
            DateLabel.Anchor = AnchorStyles.Left;
            DateLabel.AutoSize = true;
            DateLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DateLabel.Location = new Point(18, 263);
            DateLabel.Name = "DateLabel";
            DateLabel.Size = new Size(64, 31);
            DateLabel.TabIndex = 18;
            DateLabel.Text = "Date";
            // 
            // DateText
            // 
            DateText.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            DateText.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DateText.Location = new Point(100, 260);
            DateText.Name = "DateText";
            DateText.ReadOnly = true;
            DateText.Size = new Size(685, 38);
            DateText.TabIndex = 19;
            // 
            // DayDropDownList
            // 
            DayDropDownList.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            DayDropDownList.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DayDropDownList.FormattingEnabled = true;
            DayDropDownList.Location = new Point(194, 159);
            DayDropDownList.Name = "DayDropDownList";
            DayDropDownList.Size = new Size(594, 36);
            DayDropDownList.TabIndex = 20;
            // 
            // MonthDropDownList
            // 
            MonthDropDownList.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            MonthDropDownList.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MonthDropDownList.FormattingEnabled = true;
            MonthDropDownList.Location = new Point(194, 108);
            MonthDropDownList.Name = "MonthDropDownList";
            MonthDropDownList.Size = new Size(594, 36);
            MonthDropDownList.TabIndex = 21;
            // 
            // YearDropDownList
            // 
            YearDropDownList.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            YearDropDownList.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            YearDropDownList.FormattingEnabled = true;
            YearDropDownList.Location = new Point(194, 61);
            YearDropDownList.Name = "YearDropDownList";
            YearDropDownList.Size = new Size(594, 36);
            YearDropDownList.TabIndex = 22;
            // 
            // ReportOFAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(800, 577);
            Controls.Add(YearDropDownList);
            Controls.Add(MonthDropDownList);
            Controls.Add(DayDropDownList);
            Controls.Add(DateText);
            Controls.Add(DateLabel);
            Controls.Add(TotalPriceOfReport);
            Controls.Add(TotalPriceOfReportLablel);
            Controls.Add(GenerateReportButton);
            Controls.Add(YearLabel);
            Controls.Add(MonthLabel);
            Controls.Add(DayLabel);
            Controls.Add(GenerateReportDataGridView);
            Controls.Add(GenerateReportByLabel);
            Controls.Add(DropDownListOfGenerateReportBy);
            MinimizeBox = false;
            MinimumSize = new Size(818, 624);
            Name = "ReportOFAdmin";
            Text = "ReportOFAdmin";
            WindowState = FormWindowState.Maximized;
            FormClosed += ReportOFAdmin_FormClosed;
            Load += ReportOFAdmin_Load;
            ((System.ComponentModel.ISupportInitialize)GenerateReportDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)TotalPriceOfReport).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox DropDownListOfGenerateReportBy;
        private Label GenerateReportByLabel;
        private DataGridView GenerateReportDataGridView;
        private Label DayLabel;
        private Label MonthLabel;
        private Label YearLabel;
        private Button GenerateReportButton;
        private Label TotalPriceOfReportLablel;
        private NumericUpDown TotalPriceOfReport;
        private Label DateLabel;
        private TextBox DateText;
        private ComboBox DayDropDownList;
        private ComboBox MonthDropDownList;
        private ComboBox YearDropDownList;
    }
}