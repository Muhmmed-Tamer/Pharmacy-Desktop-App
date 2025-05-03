using Business_Layer.UnitOFWork;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy_Desktop_App.Pharmacist
{
    public partial class PrintOFSellMedicine : Form
    {
        IUnitOFWork UnitOFWork;
        bool HowYouWantToPrint = true;
        public PrintOFSellMedicine(IUnitOFWork unitOFWork , bool HowYouWantToPrint)
        {
            InitializeComponent();
            this.UnitOFWork = unitOFWork;
            this.HowYouWantToPrint = HowYouWantToPrint;
        }

        private void PrintOFSellMedicine_Load(object sender, EventArgs e)
        {
            AllSellMedicinesDataGridView.DataSource = UnitOFWork.Cart.GetMedicinesThatIsWantToSellItOrThatSelled(HowYouWantToPrint);
            AllSellMedicinesDataGridView.Columns["MedicineIsSelling"].Visible = false;
            AllSellMedicinesDataGridView.Columns["User"].Visible = false;
            AllSellMedicinesDataGridView.Columns["UserId"].Visible = false;
            AllSellMedicinesDataGridView.Columns["Id"].Visible = false;
            AllSellMedicinesDataGridView.Columns["Medicine"].Visible = false;
            AllSellMedicinesDataGridView.Columns["MedicineId"].Visible = false;
        }
    }
}
