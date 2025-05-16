using Business_Layer.UnitOFWork;
using Business_Logic.Models;
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
    public partial class AddMedicine : Form
    {
        IUnitOFWork UnitOFWork;
        public AddMedicine(IUnitOFWork UnitOFWork)
        {
            InitializeComponent();
            this.UnitOFWork = UnitOFWork;
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void AddMedicineButton_Click(object sender, EventArgs e)
        {
            //Check That Number Is Unique
            List<Medicine> Medicines = UnitOFWork.Medicine.GetAll().ToList();
            foreach (var item in Medicines)
            {
                if (item.Number == MedcineNumberText.Value)
                {
                    MessageBox.Show("This Medicine Number is already exist Change This Number");
                    return;
                }
            }

            if (MedcineNumberText.Value > 0 && MedicineNameText.Text != "" && MedicineNameText.Text != "" && QuantityText.Value > 0 && PricePerUnitText.Value > 0)
            {
                if (ManufacturingDateText.Value < ExpiryDateText.Value)
                {
                    Medicine medicine = new Medicine();
                    medicine.Name = MedicineNameText.Text;
                    medicine.ManufacturingDate = ManufacturingDateText.Value;
                    medicine.ExpiryDate = ExpiryDateText.Value;
                    medicine.Quantity = (int)QuantityText.Value;
                    medicine.Price_Per_Unit = PricePerUnitText.Value;
                    medicine.Number = (int)MedcineNumberText.Value;
                    bool MedicineIsAddedInMemory = UnitOFWork.Medicine.Add(medicine);
                    bool MedicineIsSavedInDataBase = UnitOFWork.Medicine.Save();
                    if (MedicineIsAddedInMemory && MedicineIsSavedInDataBase)
                    {
                        MessageBox.Show("Medicine Added Successfully");
                        MedicineNameText.Text = "";
                        ManufacturingDateText.Value = DateTime.Now;
                        ExpiryDateText.Value = DateTime.Now;
                        QuantityText.Value = 0;
                        PricePerUnitText.Value = 0;
                        MedcineNumberText.Value = 0;
                    }
                    else
                    {
                        MessageBox.Show("Faild To Add Medicine");
                    }
                }
                else
                {
                    MessageBox.Show("Can`t Add Medicine That Expired Date Less Than  ManufacturingDate ");
                }
            }
            else
            {
                MessageBox.Show("Please fill all the fields");
            }
        }

       
    }
}
