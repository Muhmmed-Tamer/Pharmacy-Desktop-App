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
    public partial class Profile : Form
    {
        ApplicationUser User { get; set; }
        public Profile(ApplicationUser UserThatLogin)
        {
            InitializeComponent();
            this.User = UserThatLogin;
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            UserNameText.Text = User.UserName;
            EmailText.Text = User.Email;
            MobileText.Text = User.PhoneNumber;
        }
    }
}
