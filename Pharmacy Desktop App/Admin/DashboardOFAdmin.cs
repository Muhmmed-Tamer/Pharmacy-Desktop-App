using Business_Layer.UnitOFWork;
using Business_Logic.Models;

namespace Pharmacy_Desktop_App.Admin
{
    public partial class DashboardOFAdmin : Form
    {
        private AddUserButton addUserButton { get; }
        private ViewUsers viewUsers { get; }
        private Login Login { get; }
        private ApplicationUser UserThatLoginForNow { get; set; }
        private ReportOFAdmin reportOFAdmin { get; set; }
        private IUnitOFWork UnitOFWork;
        public DashboardOFAdmin(AddUserButton addUserButton, IUnitOFWork unitOFWork, Login login, ViewUsers viewUsers, ApplicationUser UserThatLoginForNow, ReportOFAdmin reportOFAdmin)
        {
            InitializeComponent();
            this.addUserButton = addUserButton;
            this.UnitOFWork = unitOFWork;
            this.viewUsers = viewUsers;
            this.Login = login;
            this.UserThatLoginForNow = UserThatLoginForNow;
            this.reportOFAdmin = reportOFAdmin;
        }

        private void DashboardOFAdmin_Load(object sender, EventArgs e)
        {
            //PictureOFAdmin.Image = Image.FromFile("C:\\Users\\ahmed\\source\\repos\\Pharmacy_Desktop_App\\Pharmacy_Desktop_App\\Resources\\admin.png");
        }

        private void AddUserButton_Click(object sender, EventArgs e)
        {
            AddUserButton AddBoard = new AddUserButton(UnitOFWork);
            AddBoard.Show();
        }

        private async void ViewUsersButton_Click(object sender, EventArgs e)
        {
            ApplicationUser User = await UnitOFWork.UserManager.FindByIdAsync(UserThatLoginForNow.Id);
            ViewUsers viewUsers = new ViewUsers(UnitOFWork, User);
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

        private void GenerateReportButton_Click(object sender, EventArgs e)
        {
            reportOFAdmin.Show();
            this.Hide();
        }

        private void DeleteUserButton_Click(object sender, EventArgs e)
        {
            DeleteUserBoard DeleteUser = new DeleteUserBoard(UnitOFWork);
            DeleteUser.Show();
        }
    }
}
