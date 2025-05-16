namespace Pharmacy_Desktop_App.Pharmacist
{
    partial class ModifyMedicine
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
            MedicineNumberLabel = new Label();
            MedicineNameLabel = new Label();
            ManufacturingDateLabel = new Label();
            ExpiryDateLabel = new Label();
            QuantityLabel = new Label();
            PricePerUnitLabel = new Label();
            MedicineNumberText = new NumericUpDown();
            SearchButton = new Button();
            MedicineNameText = new TextBox();
            UpdateMedicineButton = new Button();
            ManufacturingDateText = new DateTimePicker();
            ExpiredDateText = new DateTimePicker();
            QuantityText = new NumericUpDown();
            PricePerUnitText = new NumericUpDown();
            ModifyMedicineLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)MedicineNumberText).BeginInit();
            ((System.ComponentModel.ISupportInitialize)QuantityText).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PricePerUnitText).BeginInit();
            SuspendLayout();
            // 
            // MedicineNumberLabel
            // 
            MedicineNumberLabel.Anchor = AnchorStyles.Left;
            MedicineNumberLabel.AutoSize = true;
            MedicineNumberLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MedicineNumberLabel.Location = new Point(23, 66);
            MedicineNumberLabel.Name = "MedicineNumberLabel";
            MedicineNumberLabel.Size = new Size(207, 31);
            MedicineNumberLabel.TabIndex = 0;
            MedicineNumberLabel.Text = "Medicine Number";
            // 
            // MedicineNameLabel
            // 
            MedicineNameLabel.Anchor = AnchorStyles.Left;
            MedicineNameLabel.AutoSize = true;
            MedicineNameLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MedicineNameLabel.Location = new Point(23, 122);
            MedicineNameLabel.Name = "MedicineNameLabel";
            MedicineNameLabel.Size = new Size(182, 31);
            MedicineNameLabel.TabIndex = 1;
            MedicineNameLabel.Text = "Medicine Name";
            // 
            // ManufacturingDateLabel
            // 
            ManufacturingDateLabel.Anchor = AnchorStyles.Left;
            ManufacturingDateLabel.AutoSize = true;
            ManufacturingDateLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ManufacturingDateLabel.Location = new Point(23, 294);
            ManufacturingDateLabel.Name = "ManufacturingDateLabel";
            ManufacturingDateLabel.Size = new Size(231, 31);
            ManufacturingDateLabel.TabIndex = 2;
            ManufacturingDateLabel.Text = "Manufacturing Date";
            // 
            // ExpiryDateLabel
            // 
            ExpiryDateLabel.Anchor = AnchorStyles.Left;
            ExpiryDateLabel.AutoSize = true;
            ExpiryDateLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ExpiryDateLabel.Location = new Point(23, 176);
            ExpiryDateLabel.Name = "ExpiryDateLabel";
            ExpiryDateLabel.Size = new Size(138, 31);
            ExpiryDateLabel.TabIndex = 3;
            ExpiryDateLabel.Text = "Expiry Date";
            // 
            // QuantityLabel
            // 
            QuantityLabel.Anchor = AnchorStyles.Left;
            QuantityLabel.AutoSize = true;
            QuantityLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            QuantityLabel.Location = new Point(23, 230);
            QuantityLabel.Name = "QuantityLabel";
            QuantityLabel.Size = new Size(108, 31);
            QuantityLabel.TabIndex = 4;
            QuantityLabel.Text = "Quantity";
            // 
            // PricePerUnitLabel
            // 
            PricePerUnitLabel.Anchor = AnchorStyles.Left;
            PricePerUnitLabel.AutoSize = true;
            PricePerUnitLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PricePerUnitLabel.Location = new Point(23, 350);
            PricePerUnitLabel.Name = "PricePerUnitLabel";
            PricePerUnitLabel.Size = new Size(160, 31);
            PricePerUnitLabel.TabIndex = 5;
            PricePerUnitLabel.Text = "Price Per Unit";
            // 
            // MedicineNumberText
            // 
            MedicineNumberText.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            MedicineNumberText.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MedicineNumberText.Location = new Point(250, 59);
            MedicineNumberText.Maximum = new decimal(new int[] { 276447232, 23283, 0, 0 });
            MedicineNumberText.Name = "MedicineNumberText";
            MedicineNumberText.Size = new Size(438, 38);
            MedicineNumberText.TabIndex = 6;
            // 
            // SearchButton
            // 
            SearchButton.Anchor = AnchorStyles.Right;
            SearchButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SearchButton.Location = new Point(694, 57);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(94, 38);
            SearchButton.TabIndex = 7;
            SearchButton.Text = "Search";
            SearchButton.UseVisualStyleBackColor = true;
            SearchButton.Click += SearchButton_Click;
            // 
            // MedicineNameText
            // 
            MedicineNameText.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            MedicineNameText.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MedicineNameText.Location = new Point(250, 115);
            MedicineNameText.Name = "MedicineNameText";
            MedicineNameText.Size = new Size(538, 38);
            MedicineNameText.TabIndex = 8;
            // 
            // UpdateMedicineButton
            // 
            UpdateMedicineButton.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            UpdateMedicineButton.BackColor = SystemColors.GradientActiveCaption;
            UpdateMedicineButton.Enabled = false;
            UpdateMedicineButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UpdateMedicineButton.Location = new Point(146, 396);
            UpdateMedicineButton.Name = "UpdateMedicineButton";
            UpdateMedicineButton.Size = new Size(533, 42);
            UpdateMedicineButton.TabIndex = 10;
            UpdateMedicineButton.Text = "Update Medicine";
            UpdateMedicineButton.UseVisualStyleBackColor = false;
            UpdateMedicineButton.Click += UpdateMedicineButton_Click;
            // 
            // ManufacturingDateText
            // 
            ManufacturingDateText.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            ManufacturingDateText.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ManufacturingDateText.Location = new Point(250, 287);
            ManufacturingDateText.Name = "ManufacturingDateText";
            ManufacturingDateText.Size = new Size(538, 38);
            ManufacturingDateText.TabIndex = 11;
            // 
            // ExpiredDateText
            // 
            ExpiredDateText.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            ExpiredDateText.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ExpiredDateText.Location = new Point(250, 169);
            ExpiredDateText.Name = "ExpiredDateText";
            ExpiredDateText.Size = new Size(538, 38);
            ExpiredDateText.TabIndex = 12;
            // 
            // QuantityText
            // 
            QuantityText.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            QuantityText.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            QuantityText.Location = new Point(250, 228);
            QuantityText.Name = "QuantityText";
            QuantityText.Size = new Size(538, 38);
            QuantityText.TabIndex = 13;
            // 
            // PricePerUnitText
            // 
            PricePerUnitText.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            PricePerUnitText.DecimalPlaces = 4;
            PricePerUnitText.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PricePerUnitText.Location = new Point(250, 343);
            PricePerUnitText.Maximum = new decimal(new int[] { -727379968, 232, 0, 0 });
            PricePerUnitText.Name = "PricePerUnitText";
            PricePerUnitText.Size = new Size(538, 38);
            PricePerUnitText.TabIndex = 14;
            // 
            // ModifyMedicineLabel
            // 
            ModifyMedicineLabel.AutoSize = true;
            ModifyMedicineLabel.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ModifyMedicineLabel.Location = new Point(223, 6);
            ModifyMedicineLabel.Name = "ModifyMedicineLabel";
            ModifyMedicineLabel.Size = new Size(319, 50);
            ModifyMedicineLabel.TabIndex = 15;
            ModifyMedicineLabel.Text = "Modify Medicine";
            // 
            // ModifyMedicine
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ModifyMedicineLabel);
            Controls.Add(PricePerUnitText);
            Controls.Add(QuantityText);
            Controls.Add(ExpiredDateText);
            Controls.Add(ManufacturingDateText);
            Controls.Add(UpdateMedicineButton);
            Controls.Add(MedicineNameText);
            Controls.Add(SearchButton);
            Controls.Add(MedicineNumberText);
            Controls.Add(PricePerUnitLabel);
            Controls.Add(QuantityLabel);
            Controls.Add(ExpiryDateLabel);
            Controls.Add(ManufacturingDateLabel);
            Controls.Add(MedicineNameLabel);
            Controls.Add(MedicineNumberLabel);
            MaximizeBox = false;
            MinimumSize = new Size(818, 497);
            Name = "ModifyMedicine";
            Text = "ModifyMedicine";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)MedicineNumberText).EndInit();
            ((System.ComponentModel.ISupportInitialize)QuantityText).EndInit();
            ((System.ComponentModel.ISupportInitialize)PricePerUnitText).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label MedicineNumberLabel;
        private Label MedicineNameLabel;
        private Label ManufacturingDateLabel;
        private Label ExpiryDateLabel;
        private Label QuantityLabel;
        private Label PricePerUnitLabel;
        private NumericUpDown MedicineNumberText;
        private Button SearchButton;
        private TextBox MedicineNameText;
        private Button UpdateMedicineButton;
        private DateTimePicker ManufacturingDateText;
        private DateTimePicker ExpiredDateText;
        private NumericUpDown QuantityText;
        private NumericUpDown PricePerUnitText;
        private Label ModifyMedicineLabel;
    }
}