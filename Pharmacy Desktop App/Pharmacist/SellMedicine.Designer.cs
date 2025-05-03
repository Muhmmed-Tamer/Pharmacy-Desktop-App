namespace Pharmacy_Desktop_App.Pharmacist
{
    partial class SellMedicine
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
            SearchMedicineLabel = new Label();
            Medicines = new ListBox();
            MedicineNameLabel = new Label();
            ExpiredDateLabel = new Label();
            QuantityLabel = new Label();
            TotalPriceLabel = new Label();
            MedicineNameText = new TextBox();
            QuantityText = new NumericUpDown();
            TotalPriceText = new NumericUpDown();
            ExpiredDateText = new DateTimePicker();
            PricePerUnitLabel = new Label();
            PricePerUnitText = new NumericUpDown();
            AddToCartButton = new Button();
            MedicinesInCartsDataView = new DataGridView();
            PriceOFAllMedicinesText = new NumericUpDown();
            PriceOFAllMedicinesLabel = new Label();
            PrintButton = new Button();
            SearchInMedicineText = new TextBox();
            ((System.ComponentModel.ISupportInitialize)QuantityText).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TotalPriceText).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PricePerUnitText).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MedicinesInCartsDataView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PriceOFAllMedicinesText).BeginInit();
            SuspendLayout();
            // 
            // SearchMedicineLabel
            // 
            SearchMedicineLabel.AutoSize = true;
            SearchMedicineLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SearchMedicineLabel.Location = new Point(12, 9);
            SearchMedicineLabel.Name = "SearchMedicineLabel";
            SearchMedicineLabel.Size = new Size(168, 28);
            SearchMedicineLabel.TabIndex = 0;
            SearchMedicineLabel.Text = "Search Medicine";
            // 
            // Medicines
            // 
            Medicines.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Medicines.FormattingEnabled = true;
            Medicines.ItemHeight = 31;
            Medicines.Location = new Point(12, 88);
            Medicines.Name = "Medicines";
            Medicines.Size = new Size(203, 314);
            Medicines.TabIndex = 0;
            Medicines.SelectedIndexChanged += SelectItemFromMedicine;
            // 
            // MedicineNameLabel
            // 
            MedicineNameLabel.AutoSize = true;
            MedicineNameLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MedicineNameLabel.Location = new Point(221, 7);
            MedicineNameLabel.Name = "MedicineNameLabel";
            MedicineNameLabel.Size = new Size(182, 31);
            MedicineNameLabel.TabIndex = 2;
            MedicineNameLabel.Text = "Medicine Name";
            // 
            // ExpiredDateLabel
            // 
            ExpiredDateLabel.AutoSize = true;
            ExpiredDateLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ExpiredDateLabel.Location = new Point(221, 80);
            ExpiredDateLabel.Name = "ExpiredDateLabel";
            ExpiredDateLabel.Size = new Size(151, 31);
            ExpiredDateLabel.TabIndex = 3;
            ExpiredDateLabel.Text = "Expired Date";
            // 
            // QuantityLabel
            // 
            QuantityLabel.AutoSize = true;
            QuantityLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            QuantityLabel.Location = new Point(221, 43);
            QuantityLabel.Name = "QuantityLabel";
            QuantityLabel.Size = new Size(108, 31);
            QuantityLabel.TabIndex = 5;
            QuantityLabel.Text = "Quantity";
            // 
            // TotalPriceLabel
            // 
            TotalPriceLabel.AutoSize = true;
            TotalPriceLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TotalPriceLabel.Location = new Point(221, 117);
            TotalPriceLabel.Name = "TotalPriceLabel";
            TotalPriceLabel.Size = new Size(126, 31);
            TotalPriceLabel.TabIndex = 6;
            TotalPriceLabel.Text = "Total Price";
            // 
            // MedicineNameText
            // 
            MedicineNameText.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            MedicineNameText.Enabled = false;
            MedicineNameText.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MedicineNameText.Location = new Point(422, 6);
            MedicineNameText.Name = "MedicineNameText";
            MedicineNameText.Size = new Size(401, 31);
            MedicineNameText.TabIndex = 7;
            // 
            // QuantityText
            // 
            QuantityText.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            QuantityText.Enabled = false;
            QuantityText.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            QuantityText.Location = new Point(422, 43);
            QuantityText.Name = "QuantityText";
            QuantityText.Size = new Size(401, 31);
            QuantityText.TabIndex = 8;
            QuantityText.KeyUp += QuantityOFMedicineThatSell;
            // 
            // TotalPriceText
            // 
            TotalPriceText.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TotalPriceText.DecimalPlaces = 3;
            TotalPriceText.Enabled = false;
            TotalPriceText.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TotalPriceText.Location = new Point(422, 117);
            TotalPriceText.Maximum = new decimal(new int[] { 1215752192, 23, 0, 0 });
            TotalPriceText.Name = "TotalPriceText";
            TotalPriceText.Size = new Size(401, 31);
            TotalPriceText.TabIndex = 9;
            // 
            // ExpiredDateText
            // 
            ExpiredDateText.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ExpiredDateText.Enabled = false;
            ExpiredDateText.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ExpiredDateText.Location = new Point(422, 80);
            ExpiredDateText.Name = "ExpiredDateText";
            ExpiredDateText.Size = new Size(401, 31);
            ExpiredDateText.TabIndex = 10;
            // 
            // PricePerUnitLabel
            // 
            PricePerUnitLabel.AutoSize = true;
            PricePerUnitLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PricePerUnitLabel.Location = new Point(221, 157);
            PricePerUnitLabel.Name = "PricePerUnitLabel";
            PricePerUnitLabel.Size = new Size(160, 31);
            PricePerUnitLabel.TabIndex = 11;
            PricePerUnitLabel.Text = "Price Per Unit";
            // 
            // PricePerUnitText
            // 
            PricePerUnitText.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            PricePerUnitText.DecimalPlaces = 3;
            PricePerUnitText.Enabled = false;
            PricePerUnitText.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PricePerUnitText.Location = new Point(422, 160);
            PricePerUnitText.Maximum = new decimal(new int[] { 1215752192, 23, 0, 0 });
            PricePerUnitText.Name = "PricePerUnitText";
            PricePerUnitText.Size = new Size(401, 31);
            PricePerUnitText.TabIndex = 12;
            // 
            // AddToCartButton
            // 
            AddToCartButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            AddToCartButton.Enabled = false;
            AddToCartButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddToCartButton.Location = new Point(221, 197);
            AddToCartButton.Name = "AddToCartButton";
            AddToCartButton.Size = new Size(601, 43);
            AddToCartButton.TabIndex = 13;
            AddToCartButton.Text = "Add To Cart";
            AddToCartButton.UseVisualStyleBackColor = true;
            AddToCartButton.Click += AddToCartButton_Click;
            // 
            // MedicinesInCartsDataView
            // 
            MedicinesInCartsDataView.AllowUserToAddRows = false;
            MedicinesInCartsDataView.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            MedicinesInCartsDataView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            MedicinesInCartsDataView.BackgroundColor = SystemColors.Window;
            MedicinesInCartsDataView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            MedicinesInCartsDataView.Location = new Point(221, 249);
            MedicinesInCartsDataView.MinimumSize = new Size(601, 153);
            MedicinesInCartsDataView.Name = "MedicinesInCartsDataView";
            MedicinesInCartsDataView.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            MedicinesInCartsDataView.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            MedicinesInCartsDataView.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MedicinesInCartsDataView.RowsDefaultCellStyle = dataGridViewCellStyle2;
            MedicinesInCartsDataView.Size = new Size(601, 153);
            MedicinesInCartsDataView.TabIndex = 14;
            // 
            // PriceOFAllMedicinesText
            // 
            PriceOFAllMedicinesText.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            PriceOFAllMedicinesText.DecimalPlaces = 3;
            PriceOFAllMedicinesText.Enabled = false;
            PriceOFAllMedicinesText.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PriceOFAllMedicinesText.Location = new Point(221, 428);
            PriceOFAllMedicinesText.Maximum = new decimal(new int[] { 1874919424, 2328306, 0, 0 });
            PriceOFAllMedicinesText.Name = "PriceOFAllMedicinesText";
            PriceOFAllMedicinesText.Size = new Size(439, 38);
            PriceOFAllMedicinesText.TabIndex = 15;
            // 
            // PriceOFAllMedicinesLabel
            // 
            PriceOFAllMedicinesLabel.Anchor = AnchorStyles.Left;
            PriceOFAllMedicinesLabel.AutoSize = true;
            PriceOFAllMedicinesLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PriceOFAllMedicinesLabel.Location = new Point(12, 430);
            PriceOFAllMedicinesLabel.Name = "PriceOFAllMedicinesLabel";
            PriceOFAllMedicinesLabel.Size = new Size(103, 31);
            PriceOFAllMedicinesLabel.TabIndex = 16;
            PriceOFAllMedicinesLabel.Text = "All Price";
            // 
            // PrintButton
            // 
            PrintButton.Anchor = AnchorStyles.Right;
            PrintButton.Enabled = false;
            PrintButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PrintButton.Location = new Point(696, 428);
            PrintButton.Name = "PrintButton";
            PrintButton.Size = new Size(126, 40);
            PrintButton.TabIndex = 17;
            PrintButton.Text = "Print ";
            PrintButton.UseVisualStyleBackColor = true;
            PrintButton.Click += PrintButton_Click;
            // 
            // SearchInMedicineText
            // 
            SearchInMedicineText.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SearchInMedicineText.Location = new Point(12, 38);
            SearchInMedicineText.Name = "SearchInMedicineText";
            SearchInMedicineText.Size = new Size(203, 31);
            SearchInMedicineText.TabIndex = 18;
            SearchInMedicineText.KeyUp += SearchAboutMedicineKeyUp;
            // 
            // SellMedicine
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(849, 480);
            Controls.Add(SearchInMedicineText);
            Controls.Add(PrintButton);
            Controls.Add(PriceOFAllMedicinesLabel);
            Controls.Add(PriceOFAllMedicinesText);
            Controls.Add(MedicinesInCartsDataView);
            Controls.Add(AddToCartButton);
            Controls.Add(PricePerUnitText);
            Controls.Add(PricePerUnitLabel);
            Controls.Add(ExpiredDateText);
            Controls.Add(TotalPriceText);
            Controls.Add(QuantityText);
            Controls.Add(MedicineNameText);
            Controls.Add(TotalPriceLabel);
            Controls.Add(QuantityLabel);
            Controls.Add(ExpiredDateLabel);
            Controls.Add(MedicineNameLabel);
            Controls.Add(Medicines);
            Controls.Add(SearchMedicineLabel);
            MaximizeBox = false;
            Name = "SellMedicine";
            Text = "SellMedicine";
            WindowState = FormWindowState.Maximized;
            FormClosing += CheckIFMedicnesSelledOrNot;
            Load += SellMedicine_Load;
            ((System.ComponentModel.ISupportInitialize)QuantityText).EndInit();
            ((System.ComponentModel.ISupportInitialize)TotalPriceText).EndInit();
            ((System.ComponentModel.ISupportInitialize)PricePerUnitText).EndInit();
            ((System.ComponentModel.ISupportInitialize)MedicinesInCartsDataView).EndInit();
            ((System.ComponentModel.ISupportInitialize)PriceOFAllMedicinesText).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label SearchMedicineLabel;
        private ListBox Medicines;
        private Label MedicineNameLabel;
        private Label ExpiredDateLabel;
        private Label QuantityLabel;
        private Label TotalPriceLabel;
        private TextBox MedicineNameText;
        private NumericUpDown QuantityText;
        private NumericUpDown TotalPriceText;
        private DateTimePicker ExpiredDateText;
        private Label PricePerUnitLabel;
        private NumericUpDown PricePerUnitText;
        private Button AddToCartButton;
        private DataGridView MedicinesInCartsDataView;
        private NumericUpDown PriceOFAllMedicinesText;
        private Label PriceOFAllMedicinesLabel;
        private Button PrintButton;
        private TextBox SearchInMedicineText;
    }
}