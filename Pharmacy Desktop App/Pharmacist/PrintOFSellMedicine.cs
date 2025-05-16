using Business_Layer.UnitOFWork;

namespace Pharmacy_Desktop_App.Pharmacist
{
    public partial class PrintOFSellMedicine : Form
    {
        IUnitOFWork UnitOFWork;
        bool HowYouWantToPrint = true;
        bool YouWantToSellAgain = false;
        public PrintOFSellMedicine(IUnitOFWork unitOFWork, bool HowYouWantToPrint, bool youWantToSellAgain)
        {
            InitializeComponent();
            this.UnitOFWork = unitOFWork;
            this.HowYouWantToPrint = HowYouWantToPrint;
            YouWantToSellAgain = youWantToSellAgain;
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

        private void ViewMedicineToSellIT(object sender, FormClosingEventArgs e)
        {
            if (YouWantToSellAgain)
            {
                SellMedicine sellMedicine = new SellMedicine(UnitOFWork);
                sellMedicine.Show();
            }
        }
    }
}
