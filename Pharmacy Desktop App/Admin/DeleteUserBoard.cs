using Business_Layer.UnitOFWork;
using Business_Logic.Models;
using Microsoft.AspNetCore.Identity;

namespace Pharmacy_Desktop_App.Admin
{
    public partial class DeleteUserBoard : Form
    {
        IUnitOFWork unitOFWork;
        public DeleteUserBoard(IUnitOFWork UnitOFWork)
        {
            InitializeComponent();
            unitOFWork = UnitOFWork;
        }

        private async void DeleteUserButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(EamilOfUserTextBox.Text))
                {
                    ApplicationUser UserThatWantToDeleteIt = await unitOFWork.UserManager.FindByEmailAsync(EamilOfUserTextBox.Text);
                    if (UserThatWantToDeleteIt is not null)
                    {
                        DialogResult WhichUserIsClicked = MessageBox.Show($"You Want To Delete User [{UserThatWantToDeleteIt.UserName}] From System", "Delete User", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                        if (WhichUserIsClicked == DialogResult.Yes)
                        {
                            IdentityResult UserIsDeletedSuccessfully = await unitOFWork.UserManager.DeleteAsync(UserThatWantToDeleteIt);
                            if (UserIsDeletedSuccessfully.Succeeded)
                            {
                                MessageBox.Show($"{UserThatWantToDeleteIt} Is Deleted Successfully");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show($"The User {EamilOfUserTextBox.Text} It Is Not Found In System");
                    }
                }
                else
                {
                    MessageBox.Show("Please , Enter Email To Delete User");
                }
            }
            catch
            {
                MessageBox.Show("Some Thing Is Wrong");
            }
        }

        private void DeleteUserBoard_Load(object sender, EventArgs e)
        {
            DeleteUserButton.Enabled = false;
        }

        private void KeyUpToWriteEmailOFUser(object sender, KeyEventArgs e)
        {
            DeleteUserButton.Enabled = true;
        }
    }
}
