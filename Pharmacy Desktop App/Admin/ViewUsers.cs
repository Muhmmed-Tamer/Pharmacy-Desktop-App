using Business_Layer.UnitOFWork;
using Business_Layer.Utility;
using Business_Logic.DTO;
using Business_Logic.Models;

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
            DataGridOFAllUsers.DataSource = await GetAllUsersWithSomeProperties(UserThatLoginForNow);
            DataGridOFAllUsers.Columns["Id"].Visible = false;

        }
    }
}
