using Business_Layer.UnitOFWork;

namespace Pharmacy_Desktop_App.Pharmacist
{
    public partial class DashboardOFPharmacist : Form
    {
        IUnitOFWork UnitOFWork;
        Login Login { get; }
        public DashboardOFPharmacist(IUnitOFWork unitOFWork)
        {
            InitializeComponent();
            this.UnitOFWork = unitOFWork;
            this.Login = new Login(UnitOFWork);
        }

        private void AddMedicineButton_Click(object sender, EventArgs e)
        {
            AddMedicine addMedicine = new AddMedicine(UnitOFWork);
            addMedicine.Show();
        }

        private void ViewMedicineButton_Click(object sender, EventArgs e)
        {
            ViewMedicines viewMedicines = new ViewMedicines(UnitOFWork);
            viewMedicines.Show();
        }

        private void ValidityCheckButton_Click(object sender, EventArgs e)
        {
            VaildityCheck check = new VaildityCheck(UnitOFWork);
            check.Show();

        }

        private async void LogOutButton_Click(object sender, EventArgs e)
        {
            Login.Show();
            this.Hide();
        }

        private void ModifyMedicineButton_Click(object sender, EventArgs e)
        {
            ModifyMedicine modifyMedicine = new ModifyMedicine(UnitOFWork);
            modifyMedicine.Show();
        }

        private void SellMedicineButton_Click(object sender, EventArgs e)
        {
            SellMedicine sellMedicine = new SellMedicine(UnitOFWork);
            sellMedicine.Show();

        }

        private void AllMedicineButton_Click(object sender, EventArgs e)
        {
            PrintOFSellMedicine printOFSellMedicine = new PrintOFSellMedicine(UnitOFWork, true, false);
            printOFSellMedicine.Show();
        }

        private void ViewLoginForm(object sender, FormClosedEventArgs e)
        {
            Login.Show();
            this.Hide();
        }
    }
}
