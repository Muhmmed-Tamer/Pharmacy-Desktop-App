using Business_Layer.UnitOFWork;
using Business_Layer.Utility;
using Business_Logic.DTO;
using Business_Logic.Models;
using Microsoft.AspNetCore.Identity;

namespace Pharmacy_Desktop_App.Admin
{
    public partial class ViewUsers : Form
    {
        IUnitOFWork UnitOFWork;
        List<ApplicationUserDTO> AllUsersDTO;
        public ApplicationUser UserThatLoginForNow { get; set; }
        public ViewUsers(IUnitOFWork unitOFWork, ApplicationUser applicationUserDTO)
        {
            InitializeComponent();
            this.UnitOFWork = unitOFWork;
            AllUsersDTO = new List<ApplicationUserDTO>();
            this.UserThatLoginForNow = applicationUserDTO;
        }
        public async Task<List<ApplicationUserDTO>> GetAllUsersWithSomeProperties(ApplicationUser UserThatLoginForNow)
        {
            var AllUsers = UnitOFWork.UserManager.Users.Where(U => U.Id != UserThatLoginForNow.Id).ToList();
            foreach (var U in AllUsers)
            {
                AllUsersDTO.Add(new ApplicationUserDTO
                {
                    Id = U.Id,
                    UserName = U.UserName,
                    Email = U.Email,
                    Phone = U.PhoneNumber,
                    Role = await UnitOFWork.UserManager.IsInRoleAsync(U, StaticData.Administrator) == true ? "Administrator" : "Pharmacist"
                });
            }
            return AllUsersDTO;
        }
        private async void ViewUsers_Load(object sender, EventArgs e)
        {
            DataGridOFAllUsers.ClearSelection();
            this.DeleteUserButton.Enabled = false;
            DataGridOFAllUsers.DataSource = await GetAllUsersWithSomeProperties(UserThatLoginForNow);
            DataGridOFAllUsers.Columns["Id"].Visible = false;

        }

        private async void DeleteUserButton_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow Medicine in DataGridOFAllUsers.SelectedRows)
                {
                    {

                        var User = (ApplicationUserDTO)Medicine.DataBoundItem;
                        ApplicationUser UserThatWantToDeleteIt = await UnitOFWork.UserManager.FindByIdAsync(User.Id);
                        IdentityResult UserIsDeleted = await UnitOFWork.UserManager.DeleteAsync(UserThatWantToDeleteIt);
                        if (UserIsDeleted.Succeeded)
                        {
                            MessageBox.Show("User deleted successfully.");
                            DataGridOFAllUsers.DataSource = await GetAllUsersWithSomeProperties(UserThatLoginForNow);
                            DataGridOFAllUsers.Columns["Id"].Visible = false;
                        }
                        else
                        {
                            MessageBox.Show("Error deleting user.");
                        }
                    }

                }
                if (DataGridOFAllUsers.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a user to delete.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting medicine: " + ex.Message);
            }
        }

        private void SelectedUserToDelete(object sender, EventArgs e)
        {
            this.DeleteUserButton.Enabled = true;
        }
    }
}
