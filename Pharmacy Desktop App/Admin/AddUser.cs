using Business_Layer.UnitOFWork;
using Business_Layer.Utility;
using Business_Logic.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy_Desktop_App
{
    public partial class AddUserButton : Form
    {
        private readonly IUnitOFWork UnitOFWork;

        public AddUserButton(IUnitOFWork unitOfWork)
        {
            UnitOFWork = unitOfWork;
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (UserNameText.Text != "" && MobileNumberText.Text != "" && EmailText.Text != "" && PasswordText.Text != "" && RolesBox.Text != "")
                {
                    ApplicationUser UserToAddInDataBase = new ApplicationUser();
                    UserToAddInDataBase.UserName = UserNameText.Text;
                    UserToAddInDataBase.PhoneNumber = MobileNumberText.Text;
                    UserToAddInDataBase.Email = EmailText.Text;
                    var ResultOFCreateUser = await UnitOFWork.UserManager.CreateAsync(UserToAddInDataBase, PasswordText.Text);
                    var ResultOFAddRoleToUser = await UnitOFWork.UserManager.AddToRoleAsync(UserToAddInDataBase, RolesBox.Text);
                    if (ResultOFAddRoleToUser.Succeeded && ResultOFAddRoleToUser.Succeeded)
                    {
                        MessageBox.Show("User Created Successfully");
                        UserNameText.Text = "";
                        MobileNumberText.Text = "";
                        EmailText.Text = "";
                        PasswordText.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Faild To Add User");
                    }
                }
                else
                {
                    MessageBox.Show("Please fill all the fields");
                }
            }
            catch
            {
                MessageBox.Show("SomeThing Is Error");
            }
        }

        private void AddUserButton_Load(object sender, EventArgs e)
        {
            List<IdentityRole> AllRoles = UnitOFWork.RoleManager.Roles.ToList();
            RolesBox.DataSource = AllRoles;
            RolesBox.DisplayMember = "Name";
            RolesBox.ValueMember = "Id";
        }
    }
}
