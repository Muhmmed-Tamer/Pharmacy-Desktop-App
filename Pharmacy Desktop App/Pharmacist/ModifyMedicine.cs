using Business_Layer.UnitOFWork;
using Business_Logic.Models;

namespace Pharmacy_Desktop_App.Pharmacist
{
    public partial class ModifyMedicine : Form
    {
        IUnitOFWork UnitOFWork;
        Medicine MedicineYouSearchWithNumber;

        public ModifyMedicine(IUnitOFWork unitOFWork)
        {
            InitializeComponent();
            UnitOFWork = unitOFWork;
            MedicineYouSearchWithNumber = new Medicine();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (MedicineNumberText.Value > 0)
                {
                    MedicineYouSearchWithNumber = UnitOFWork.Medicine.SearchByMedicineNumber((int)MedicineNumberText.Value);
                    if (MedicineYouSearchWithNumber != null)
                    {
                        ManufacturingDateText.Text = MedicineYouSearchWithNumber.ManufacturingDate.ToString();
                        ExpiredDateText.Text = MedicineYouSearchWithNumber.ExpiryDate.ToString();
                        MedicineNameText.Text = MedicineYouSearchWithNumber.Name;
                        QuantityText.Value = MedicineYouSearchWithNumber.Quantity;
                        PricePerUnitText.Value = MedicineYouSearchWithNumber.Price_Per_Unit;
                        UpdateMedicineButton.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Medicine not found.");
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a valid medicine number.");
                }
            }
            catch
            {
                MessageBox.Show("Some Thing Is Error");
            }
        }

        private void UpdateMedicineButton_Click(object sender, EventArgs e)
        {
            try
            {
                MedicineYouSearchWithNumber.ManufacturingDate = ManufacturingDateText.Value;
                MedicineYouSearchWithNumber.ExpiryDate = ExpiredDateText.Value;
                MedicineYouSearchWithNumber.Name = MedicineNameText.Text;
                MedicineYouSearchWithNumber.Quantity = (int)QuantityText.Value;
                MedicineYouSearchWithNumber.Price_Per_Unit = PricePerUnitText.Value;
                bool MedicineIsUpdatedInMemory = UnitOFWork.Medicine.Update(MedicineYouSearchWithNumber);
                bool MedicineIsUpdatedInDataBase = UnitOFWork.Medicine.Save();
                if (MedicineIsUpdatedInMemory && MedicineIsUpdatedInDataBase)
                {
                    MessageBox.Show("Medicine Updated Successfully.");
                }
                else
                {
                    MessageBox.Show("Failed to update medicine.");
                }
            }
            catch
            {
                MessageBox.Show("Some Thing Is Error");
            }

            UpdateMedicineButton.Enabled = false;
        }
    }
}
