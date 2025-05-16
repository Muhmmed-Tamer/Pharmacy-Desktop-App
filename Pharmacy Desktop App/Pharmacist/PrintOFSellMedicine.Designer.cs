namespace Pharmacy_Desktop_App.Pharmacist
{
    partial class PrintOFSellMedicine
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
            AllSellMedicinesDataGridView = new DataGridView();
            AllsellMedicineLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)AllSellMedicinesDataGridView).BeginInit();
            SuspendLayout();
            // 
            // AllSellMedicinesDataGridView
            // 
            AllSellMedicinesDataGridView.AllowUserToAddRows = false;
            AllSellMedicinesDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            AllSellMedicinesDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            AllSellMedicinesDataGridView.BackgroundColor = SystemColors.Window;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            AllSellMedicinesDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            AllSellMedicinesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            AllSellMedicinesDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            AllSellMedicinesDataGridView.Location = new Point(35, 95);
            AllSellMedicinesDataGridView.Name = "AllSellMedicinesDataGridView";
            AllSellMedicinesDataGridView.ReadOnly = true;
            AllSellMedicinesDataGridView.RowHeadersWidth = 51;
            AllSellMedicinesDataGridView.Size = new Size(741, 320);
            AllSellMedicinesDataGridView.TabIndex = 0;
            // 
            // AllsellMedicineLabel
            // 
            AllsellMedicineLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            AllsellMedicineLabel.AutoSize = true;
            AllsellMedicineLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AllsellMedicineLabel.Location = new Point(330, 33);
            AllsellMedicineLabel.Name = "AllsellMedicineLabel";
            AllsellMedicineLabel.Size = new Size(194, 31);
            AllsellMedicineLabel.TabIndex = 1;
            AllsellMedicineLabel.Text = "All Sell Medicine";
            // 
            // PrintOFSellMedicine
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(AllsellMedicineLabel);
            Controls.Add(AllSellMedicinesDataGridView);
            MaximizeBox = false;
            MinimumSize = new Size(818, 497);
            Name = "PrintOFSellMedicine";
            Text = "PrintOFSellMedicine";
            WindowState = FormWindowState.Maximized;
            FormClosing += ViewMedicineToSellIT;
            Load += PrintOFSellMedicine_Load;
            ((System.ComponentModel.ISupportInitialize)AllSellMedicinesDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView AllSellMedicinesDataGridView;
        private Label AllsellMedicineLabel;
    }
}