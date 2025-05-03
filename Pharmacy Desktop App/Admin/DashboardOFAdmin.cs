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

namespace Pharmacy_Desktop_App.Admin
{
    public partial class DashboardOFAdmin : Form
    {
        private AddUserButton addUserButton { get; }
        private ViewUsers viewUsers { get; }
        private Login Login { get; }
        ApplicationUser UserThatLoginForNow { get; set; }
        private IUnitOFWork UnitOFWork;
        public DashboardOFAdmin(AddUserButton addUserButton, IUnitOFWork unitOFWork, ViewUsers viewUsers, Login login, ApplicationUser UserThatLoginForNow)
        {
            InitializeComponent();
            this.addUserButton = addUserButton;
            this.UnitOFWork = unitOFWork;
            this.viewUsers = viewUsers;
            this.Login = login;
            this.UserThatLoginForNow = UserThatLoginForNow;
        }

        private void DashboardOFAdmin_Load(object sender, EventArgs e)
        {
            //PictureOFAdmin.Image = Image.FromFile("C:\\Users\\ahmed\\source\\repos\\Pharmacy_Desktop_App\\Pharmacy_Desktop_App\\Resources\\admin.png");
        }

        private void AddUserButton_Click(object sender, EventArgs e)
        {
            addUserButton.Show();
        }

        private void ViewUsersButton_Click(object sender, EventArgs e)
        {
            viewUsers.Show();
        }

        private void ProfileButton_Click(object sender, EventArgs e)
        {
            Profile profile = new Profile(UserThatLoginForNow);
            profile.Show();
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            UnitOFWork.SignInManager.SignOutAsync();
            this.Hide();
            Login.Show();
        }

        private void ViewLoginForm(object sender, FormClosedEventArgs e)
        {
            Login.Show();
            this.Hide();
        }
    }
}
