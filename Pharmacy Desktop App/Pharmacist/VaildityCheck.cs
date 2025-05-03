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
    public partial class VaildityCheck : Form
    {
        IUnitOFWork UnitOFWork;
        public VaildityCheck(IUnitOFWork unitOFWork)
        {
            InitializeComponent();
            this.UnitOFWork = unitOFWork;
        }

        private void VaildityCheck_Load(object sender, EventArgs e)
        {
            VaildateCheckCombobox.Items.Add(Check.All);
            VaildateCheckCombobox.Items.Add(Check.Valid);
            VaildateCheckCombobox.Items.Add(Check.InValid);

            AllMedicineSearshWithValid.DataSource = UnitOFWork.Medicine.SearchByValid(Check.All);
            AllMedicineSearshWithValid.Columns["Id"].Visible = false;
        }

        private void ChooseAnotherCategoryToSearchVaildOrNotMedicine(object sender, EventArgs e)
        {
            AllMedicineSearshWithValid.DataSource = UnitOFWork.Medicine.SearchByValid((Check)VaildateCheckCombobox.SelectedItem!);
        }
    }
}
