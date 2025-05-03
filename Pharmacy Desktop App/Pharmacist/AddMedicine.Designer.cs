namespace Pharmacy_Desktop_App.Pharmacist
{
    partial class AddMedicine
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
            AddMedicineButton = new Button();
            MedicineNumberLabel = new Label();
            MedicineNameLabel = new Label();
            ManufacturingDateLabel = new Label();
            ExpiryDateLabel = new Label();
            QuantityLabel = new Label();
            PricePerUnitLabel = new Label();
            MedicineNameText = new TextBox();
            QuantityText = new NumericUpDown();
            ManufacturingDateText = new DateTimePicker();
            ExpiryDateText = new DateTimePicker();
            PricePerUnitText = new NumericUpDown();
            MedcineNumberText = new NumericUpDown();
            AddMedicineLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)QuantityText).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PricePerUnitText).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MedcineNumberText).BeginInit();
            SuspendLayout();
            // 
            // AddMedicineButton
            // 
            AddMedicineButton.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            AddMedicineButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddMedicineButton.Location = new Point(155, 377);
            AddMedicineButton.Name = "AddMedicineButton";
            AddMedicineButton.Size = new Size(474, 45);
            AddMedicineButton.TabIndex = 0;
            AddMedicineButton.Text = "Add Medicine";
            AddMedicineButton.UseVisualStyleBackColor = true;
            AddMedicineButton.Click += AddMedicineButton_Click;
            // 
            // MedicineNumberLabel
            // 
            MedicineNumberLabel.Anchor = AnchorStyles.Left;
            MedicineNumberLabel.AutoSize = true;
            MedicineNumberLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MedicineNumberLabel.Location = new Point(21, 61);
            MedicineNumberLabel.Name = "MedicineNumberLabel";
            MedicineNumberLabel.Size = new Size(207, 31);
            MedicineNumberLabel.TabIndex = 1;
            MedicineNumberLabel.Text = "Medicine Number";
            // 
            // MedicineNameLabel
            // 
            MedicineNameLabel.Anchor = AnchorStyles.Left;
            MedicineNameLabel.AutoSize = true;
            MedicineNameLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MedicineNameLabel.Location = new Point(21, 149);
            MedicineNameLabel.Name = "MedicineNameLabel";
            MedicineNameLabel.Size = new Size(182, 31);
            MedicineNameLabel.TabIndex = 2;
            MedicineNameLabel.Text = "Medicine Name";
            // 
            // ManufacturingDateLabel
            // 
            ManufacturingDateLabel.Anchor = AnchorStyles.Left;
            ManufacturingDateLabel.AutoSize = true;
            ManufacturingDateLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ManufacturingDateLabel.Location = new Point(21, 252);
            ManufacturingDateLabel.Name = "ManufacturingDateLabel";
            ManufacturingDateLabel.Size = new Size(231, 31);
            ManufacturingDateLabel.TabIndex = 3;
            ManufacturingDateLabel.Text = "Manufacturing Date";
            // 
            // ExpiryDateLabel
            // 
            ExpiryDateLabel.Anchor = AnchorStyles.Left;
            ExpiryDateLabel.AutoSize = true;
            ExpiryDateLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ExpiryDateLabel.Location = new Point(21, 107);
            ExpiryDateLabel.Name = "ExpiryDateLabel";
            ExpiryDateLabel.Size = new Size(132, 31);
            ExpiryDateLabel.TabIndex = 4;
            ExpiryDateLabel.Text = "ExpiryDate";
            // 
            // QuantityLabel
            // 
            QuantityLabel.Anchor = AnchorStyles.Left;
            QuantityLabel.AutoSize = true;
            QuantityLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            QuantityLabel.Location = new Point(21, 202);
            QuantityLabel.Name = "QuantityLabel";
            QuantityLabel.Size = new Size(108, 31);
            QuantityLabel.TabIndex = 5;
            QuantityLabel.Text = "Quantity";
            // 
            // PricePerUnitLabel
            // 
            PricePerUnitLabel.Anchor = AnchorStyles.Left;
            PricePerUnitLabel.AutoSize = true;
            PricePerUnitLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PricePerUnitLabel.Location = new Point(21, 307);
            PricePerUnitLabel.Name = "PricePerUnitLabel";
            PricePerUnitLabel.Size = new Size(160, 31);
            PricePerUnitLabel.TabIndex = 6;
            PricePerUnitLabel.Text = "Price Per Unit";
            // 
            // MedicineNameText
            // 
            MedicineNameText.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            MedicineNameText.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MedicineNameText.Location = new Point(258, 155);
            MedicineNameText.Name = "MedicineNameText";
            MedicineNameText.Size = new Size(530, 38);
            MedicineNameText.TabIndex = 8;
            // 
            // QuantityText
            // 
            QuantityText.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            QuantityText.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            QuantityText.Location = new Point(258, 206);
            QuantityText.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            QuantityText.Name = "QuantityText";
            QuantityText.Size = new Size(530, 38);
            QuantityText.TabIndex = 13;
            // 
            // ManufacturingDateText
            // 
            ManufacturingDateText.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            ManufacturingDateText.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ManufacturingDateText.Location = new Point(258, 252);
            ManufacturingDateText.Name = "ManufacturingDateText";
            ManufacturingDateText.Size = new Size(530, 38);
            ManufacturingDateText.TabIndex = 14;
            // 
            // ExpiryDateText
            // 
            ExpiryDateText.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            ExpiryDateText.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ExpiryDateText.Location = new Point(258, 111);
            ExpiryDateText.Name = "ExpiryDateText";
            ExpiryDateText.Size = new Size(530, 38);
            ExpiryDateText.TabIndex = 15;
            // 
            // PricePerUnitText
            // 
            PricePerUnitText.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            PricePerUnitText.DecimalPlaces = 4;
            PricePerUnitText.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PricePerUnitText.Location = new Point(258, 311);
            PricePerUnitText.Maximum = new decimal(new int[] { 1410065408, 2, 0, 0 });
            PricePerUnitText.Name = "PricePerUnitText";
            PricePerUnitText.Size = new Size(530, 38);
            PricePerUnitText.TabIndex = 16;
            // 
            // MedcineNumberText
            // 
            MedcineNumberText.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            MedcineNumberText.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MedcineNumberText.Location = new Point(258, 66);
            MedcineNumberText.Maximum = new decimal(new int[] { 1316134912, 2328, 0, 0 });
            MedcineNumberText.Name = "MedcineNumberText";
            MedcineNumberText.Size = new Size(530, 38);
            MedcineNumberText.TabIndex = 17;
            // 
            // AddMedicineLabel
            // 
            AddMedicineLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            AddMedicineLabel.AutoSize = true;
            AddMedicineLabel.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddMedicineLabel.Location = new Point(243, 9);
            AddMedicineLabel.Name = "AddMedicineLabel";
            AddMedicineLabel.Size = new Size(284, 54);
            AddMedicineLabel.TabIndex = 19;
            AddMedicineLabel.Text = "Add Medicine";
            // 
            // AddMedicine
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(AddMedicineLabel);
            Controls.Add(MedcineNumberText);
            Controls.Add(PricePerUnitText);
            Controls.Add(ExpiryDateText);
            Controls.Add(ManufacturingDateText);
            Controls.Add(QuantityText);
            Controls.Add(MedicineNameText);
            Controls.Add(PricePerUnitLabel);
            Controls.Add(QuantityLabel);
            Controls.Add(ExpiryDateLabel);
            Controls.Add(ManufacturingDateLabel);
            Controls.Add(MedicineNameLabel);
            Controls.Add(MedicineNumberLabel);
            Controls.Add(AddMedicineButton);
            MaximizeBox = false;
            Name = "AddMedicine";
            Text = "AddMedicine";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)QuantityText).EndInit();
            ((System.ComponentModel.ISupportInitialize)PricePerUnitText).EndInit();
            ((System.ComponentModel.ISupportInitialize)MedcineNumberText).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button AddMedicineButton;
        private Label MedicineNumberLabel;
        private Label MedicineNameLabel;
        private Label ManufacturingDateLabel;
        private Label ExpiryDateLabel;
        private Label QuantityLabel;
        private Label PricePerUnitLabel;
        private TextBox MedicineNameText;
        private NumericUpDown QuantityText;
        private DateTimePicker ManufacturingDateText;
        private DateTimePicker ExpiryDateText;
        private NumericUpDown PricePerUnitText;
        private NumericUpDown MedcineNumberText;
        private Label AddMedicineLabel;
    }
}