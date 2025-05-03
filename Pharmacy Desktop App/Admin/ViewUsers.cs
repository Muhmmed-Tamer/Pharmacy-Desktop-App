using Business_Layer.UnitOFWork;
using Business_Layer.Utility;
using Business_Logic.DTO;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy_Desktop_App.Admin
{
    public partial class ViewUsers : Form
    {
        IUnitOFWork UnitOFWork;
        List<ApplicationUserDTO> AllUsersDTO;
        public ViewUsers(IUnitOFWork unitOFWork)
        {
            InitializeComponent();
            this.UnitOFWork = unitOFWork;
            AllUsersDTO = new List<ApplicationUserDTO>();
        }
        public async Task<List<ApplicationUserDTO>> GetAllUsersWithSomeProperties()
        {
            var AllUsers = UnitOFWork.UserManager.Users.ToList();
            foreach (var U in AllUsers)
            {
                AllUsersDTO.Add(new ApplicationUserDTO
                {
                    Id = U.Id,
                    UserName = U.UserName,
                    Email = U.Email,
                    Phone = U.PhoneNumber,           
                    Role = await UnitOFWork.UserManager.IsInRoleAsync(U, StaticData.Administrator)==true? "Administrator" : "Pharmacist"
                });
            }
            return AllUsersDTO;
        }
        private async void ViewUsers_Load(object sender, EventArgs e)
        {
            DataGridOFAllUsers.DataSource = await GetAllUsersWithSomeProperties();
            DataGridOFAllUsers.Columns["Id"].Visible = false;

        }
    }
}
