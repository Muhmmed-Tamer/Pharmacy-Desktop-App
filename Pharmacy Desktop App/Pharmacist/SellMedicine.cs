using Business_Layer.UnitOFWork;
using Business_Logic.Models;

namespace Pharmacy_Desktop_App.Pharmacist
{
    public partial class SellMedicine : Form
    {
        IUnitOFWork UnitOFWork;
        Medicine selectedMedicine;
        public SellMedicine(IUnitOFWork unitOFWork)
        {
            InitializeComponent();
            this.UnitOFWork = unitOFWork;
            Medicines.ClearSelected();
        }

        private void SellMedicine_Load(object sender, EventArgs e)
        {
            Medicines.SelectedIndex = -1;
            Medicines.DataSource = UnitOFWork.Medicine.SearchByValid(Check.Valid);
            Medicines.DisplayMember = "Name";
            Medicines.ValueMember = "Id";
        }

        private void SelectItemFromMedicine(object sender, EventArgs e)
        {

            if (Medicines.SelectedValue is int)
            {
                QuantityText.Enabled = true;
                int MedicineThatYouSelected = (int)Medicines.SelectedValue!;
                selectedMedicine = UnitOFWork.Medicine.GetById(MedicineThatYouSelected);
                MedicineNameText.Text = selectedMedicine.Name;
                PricePerUnitText.Text = selectedMedicine.Price_Per_Unit.ToString();
                ExpiredDateText.Value = selectedMedicine.ExpiryDate;
            }

        }

        private void QuantityOFMedicineThatSell(object sender, KeyEventArgs e)
        {
            if (selectedMedicine != null)
            {
                if (QuantityText.Value <= selectedMedicine.Quantity)
                {
                    TotalPriceText.Value = QuantityText.Value * selectedMedicine.Price_Per_Unit;
                    AddToCartButton.Enabled = true;
                }
                else
                {
                    TotalPriceText.Value = 0;
                    AddToCartButton.Enabled = false;
                    MessageBox.Show($"This Quantity Is Not Available The Available Is {selectedMedicine.Quantity} Quantity ");
                }
            }
            else
            {
                MessageBox.Show("Please Enter A Valid Quantity");
            }
        }

        private void AddToCartButton_Click(object sender, EventArgs e)
        {
            bool IsUpdatedInMemory2 = false;
            bool IsUpdatedInDataBase2 = false;
            List<Cart> MedicinesThatIsNotSelledButAddedInCart = UnitOFWork.Cart.GetMedicinesThatIsWantToSellItOrThatSelled(false);
            try
            {
                foreach (var Item in MedicinesThatIsNotSelledButAddedInCart)
                {
                    if (Item.MedicineId == selectedMedicine.Id)
                    {
                        Item.Quantity += (int)QuantityText.Value;
                        selectedMedicine.Quantity -= (int)QuantityText.Value;
                        Item.TotalPrice += TotalPriceText.Value;
                        Item.DateAdded = DateTime.Now;
                        IsUpdatedInMemory2 = UnitOFWork.Cart.Update(Item);
                        IsUpdatedInDataBase2 = UnitOFWork.Cart.Save();

                    }
                }
                if (!IsUpdatedInDataBase2 && !IsUpdatedInMemory2)
                {
                    Cart cart = new Cart();
                    cart.MedicineName = selectedMedicine.Name;
                    cart.Quantity = (int)QuantityText.Value;
                    cart.DateAdded = DateTime.Now;
                    cart.TotalPrice = TotalPriceText.Value;
                    cart.MedicineId = selectedMedicine.Id;
                    bool IsAddedInMemory = UnitOFWork.Cart.Add(cart);
                    bool IsSavedInDataBase = UnitOFWork.Cart.Save();
                    selectedMedicine.Quantity -= (int)QuantityText.Value;
                    bool IsUpdatedInMemory = UnitOFWork.Medicine.Update(selectedMedicine);
                    bool IsUpdatedInDataBase = UnitOFWork.Medicine.Save();

                }
                PriceOFAllMedicinesText.Value = 0;
                foreach (var Item in UnitOFWork.Cart.GetMedicinesThatIsWantToSellItOrThatSelled(false))
                {
                    //code
                    PriceOFAllMedicinesText.Value += Item.TotalPrice;
                }
                MedicinesInCartsDataView.DataSource = UnitOFWork.Cart.GetMedicinesThatIsWantToSellItOrThatSelled(false);
                MedicinesInCartsDataView.Columns["MedicineId"].Visible = false;
                MedicinesInCartsDataView.Columns["Id"].Visible = false;
                MedicinesInCartsDataView.Columns["User"].Visible = false;
                MedicinesInCartsDataView.Columns["UserId"].Visible = false;
                MedicinesInCartsDataView.Columns["Medicine"].Visible = false;
                MedicinesInCartsDataView.Columns["MedicineIsSelling"].Visible = false;
                PrintButton.Enabled = true;

                MedicineNameText.Text = "";
                PricePerUnitText.Text = "";
                ExpiredDateText.Value = DateTime.Now;
                AddToCartButton.Enabled = false;
            }
            catch
            {
                MessageBox.Show("Some Thing Is Error");
            }
        }

        private void SearchAboutMedicineKeyUp(object sender, KeyEventArgs e)
        {
            Medicines.DataSource = UnitOFWork.Medicine.SearchAboutMedicineByKeyUp(SearchInMedicineText.Text);
        }

        private void PrintButton_Click(object sender, EventArgs e)
        {
            this.Close();
            List<Cart> MedicinesThatWantToSellIt = UnitOFWork.Cart.GetMedicinesThatIsWantToSellItOrThatSelled(false);
            if (MedicinesThatWantToSellIt.Count > 0)
            {
                PrintOFSellMedicine printOFSellMedicine = new PrintOFSellMedicine(UnitOFWork, false, true);
                MedicineNameText.Text = "";
                PricePerUnitText.Text = "";
                ExpiredDateText.Value = DateTime.Now;
                AddToCartButton.Enabled = false;
                printOFSellMedicine.Show();
                foreach (var Item in MedicinesThatWantToSellIt)
                {

                    Item.MedicineIsSelling = true;
                    bool IsUpdatedInMemory = UnitOFWork.Cart.Update(Item);
                    bool IsUpdatedInDataBase = UnitOFWork.Cart.Save();

                }
                Medicines.DataSource = null;
                PrintButton.Enabled = false;
            }
        }

        private async void CheckIFMedicnesSelledOrNot(object sender, FormClosingEventArgs e)
        {
            List<Cart> Carts = UnitOFWork.Cart.GetMedicinesThatIsWantToSellItOrThatSelled(false);
            if (Carts.Count > 0)
            {
                DialogResult Result = MessageBox.Show("You Want To Sell This Medicines",
                    "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (Result == DialogResult.Yes)
                {
                    PrintOFSellMedicine printOFSellMedicine = new PrintOFSellMedicine(UnitOFWork, false, false);
                    MedicineNameText.Text = "";
                    PricePerUnitText.Text = "";
                    ExpiredDateText.Value = DateTime.Now;
                    AddToCartButton.Enabled = false;
                    printOFSellMedicine.Show();
                    foreach (var Item in Carts)
                    {

                        Item.MedicineIsSelling = true;
                        bool IsUpdatedInMemory = UnitOFWork.Cart.Update(Item);
                        bool IsUpdatedInDataBase = UnitOFWork.Cart.Save();

                    }
                    Medicines.DataSource = null;
                    PrintButton.Enabled = false;
                }
                else
                {
                    foreach (var Item in Carts)
                    {
                        bool IsDeletedFromMemory = UnitOFWork.Cart.Delete(Item);
                        Medicine medicine = UnitOFWork.Medicine.GetById(Item.MedicineId);
                        medicine.Quantity += Item.Quantity;
                        bool IsUpdatedInMemory = UnitOFWork.Medicine.Update(medicine);
                        bool IsUpdatedInDataBase = UnitOFWork.Medicine.Save();
                        bool IsDeletedFromDataBase = UnitOFWork.Cart.Save();
                        if (IsDeletedFromMemory && IsUpdatedInMemory && IsUpdatedInDataBase)
                        {
                            MessageBox.Show("All Medicines Are Deleted");
                        }
                        else
                        {
                            MessageBox.Show("Some Thing Is Error");
                        }
                    }
                }
            }
        }
    }
}
