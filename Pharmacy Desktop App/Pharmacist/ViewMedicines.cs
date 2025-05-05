using Business_Layer.UnitOFWork;
using Business_Logic.Models;

namespace Pharmacy_Desktop_App.Pharmacist
{
    public partial class ViewMedicines : Form
    {
        IUnitOFWork UnitOFWork;
        public ViewMedicines(IUnitOFWork unitOFWork)
        {
            InitializeComponent();
            this.UnitOFWork = unitOFWork;
        }

        private void ViewMedicines_Load(object sender, EventArgs e)
        {
            AllMedicines.DataSource = UnitOFWork.Medicine.GetAll();
            AllMedicines.Columns["Id"].Visible = false;
        }

        private void SearchAboutMedicineWhenKeyUp(object sender, KeyEventArgs e)
        {
            List<Medicine> MedicinesThatYouSearchAbout = UnitOFWork.Medicine.SearchAboutMedicineByKeyUp(MedicineNameTextWouldToSearch.Text);
            if (MedicinesThatYouSearchAbout != null)
            {
                AllMedicines.DataSource = MedicinesThatYouSearchAbout;
                AllMedicines.Columns["Id"].Visible = false;
            }
            else
            {
                MessageBox.Show("There is no medicine with this name");
            }
        }

        private void DeleteMedicineButton_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow Medicine in AllMedicines.SelectedRows)
                {

                    var Item = (Medicine)Medicine.DataBoundItem;
                    bool MedicineIsDeletedFromMemory = UnitOFWork.Medicine.Delete(Item);
                    bool MedicineIsDeletedFromDatabase = UnitOFWork.Medicine.Save();
                    if (MedicineIsDeletedFromMemory && MedicineIsDeletedFromDatabase)
                    {
                        AllMedicines.DataSource = UnitOFWork.Medicine.GetAll();
                        AllMedicines.Columns["Id"].Visible = false;
                        MessageBox.Show("Medicine deleted successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Error deleting medicine.");
                    }
                }
                if (AllMedicines.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a medicine to delete.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting medicine: " + ex.Message);
            }
        }
    }
}
