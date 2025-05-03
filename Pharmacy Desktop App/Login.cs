
using  Business_Layer;
using Business_Layer.UnitOFWork;
using Business_Layer.Repositories;
using Microsoft.AspNetCore.Identity;
using Business_Logic.Models;
using Microsoft.IdentityModel.Tokens;
using Business_Layer.Utility;
using Pharmacy_Desktop_App.Admin;
using Business_Layer.Services;
using Pharmacy_Desktop_App.Pharmacist;
using System.Security.Claims;
namespace Pharmacy_Desktop_App
{
    public partial class Login : Form
    {
        private IUnitOFWork UnitOFWork;
        public Login(IUnitOFWork unitOFWork)
        {
            InitializeComponent();
            UnitOFWork = unitOFWork;
        }



        private async void LoginButton_Click_1(object sender, EventArgs e)
        {
            if (UserNameText.Text != "" && PasswordText.Text != "")
            {
                ApplicationUser UserIsFoundInDataBase = await UnitOFWork.UserManager.FindByEmailAsync(UserNameText.Text)!;
                if (UserIsFoundInDataBase != null)
                {
                    bool ValidPasswordWithThisUserName = await UnitOFWork.UserManager.CheckPasswordAsync(UserIsFoundInDataBase, PasswordText.Text);
                    if (ValidPasswordWithThisUserName)
                    {
                        this.Hide();
                        var dashboard = new DashboardOFAdmin(
                                new AddUserButton(UnitOFWork),
                                UnitOFWork,
                                new ViewUsers(UnitOFWork),
                                this,
                                UserIsFoundInDataBase);
                        if (await UnitOFWork.UserManager.IsInRoleAsync(UserIsFoundInDataBase, StaticData.Administrator))
                        {
                            dashboard.Show();
                        }
                        else if (await UnitOFWork.UserManager.IsInRoleAsync(UserIsFoundInDataBase, StaticData.Pharmacist))
                        {
                            var dashboardPharmacist = new DashboardOFPharmacist(UnitOFWork);
                            dashboardPharmacist.Show();
                        }
                        UserNameText.Text = "";
                        PasswordText.Text = "";

                    }
                    else
                    {
                        MessageBox.Show("Invalid Login");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Login");
                }

            }
            else
            {
                MessageBox.Show("Please fill all the fields");
            }
        }

        private void ClosedLoginForm(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
