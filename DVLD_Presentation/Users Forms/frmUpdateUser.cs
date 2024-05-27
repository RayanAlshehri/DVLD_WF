using DVLD_Business;
using System;
using System.Windows.Forms;

namespace DVLD_Presentation
{
    public partial class frmUpdateUser : Form
    {
        public delegate void UserUpdatedEventHandler();
        public UserUpdatedEventHandler UserUpdated;

        private int UserID;
        private clsUser User;
        private bool IsUpdated = false;
        public frmUpdateUser(int UserID)
        {
            InitializeComponent(); 
            
            this.UserID = UserID;
        }

        private bool UpdateUser()
        {
            User.Username = tbUsername.Text.Trim();
            User.IsActive = cbAccountStatus.Checked;
            User.PermissionsOnUsers = ctrlPermissionsOnUsers1.GetPermissionsNumber();

            return User.Save();
        }


        //Events:
        private void frmUpdateUser_Load(object sender, EventArgs e)
        {
            User = clsUser.Find(UserID);

            ctrlPersonCard1.FillPersonCard(User.Person.ID);
            tbUsername.Text = User.Username;
            cbAccountStatus.Checked = User.IsActive;
            ctrlPermissionsOnUsers1.LoadPermissions(User.PermissionsOnUsers);

            if (!clsGlobal.LogedUser.HasPermission(clsUser.enPermissionsOnUsers.FullPermissions) || clsGlobal.LogedUser.ID == User.ID)
            {
                ctrlPermissionsOnUsers1.Enabled = false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbUsername.Text))
            {
                MessageBox.Show("Enter username", "Update User",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            if (clsUser.DoesUserExistByUsername(tbUsername.Text.Trim()) && tbUsername.Text.Trim() != User.Username)
            {
                MessageBox.Show("Username is used", "Update User",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            if (UpdateUser())
            {
                MessageBox.Show("User updated successfully", "Update User",
                     MessageBoxButtons.OK, MessageBoxIcon.Information);

                IsUpdated = true;
            }
            else
            {
                MessageBox.Show("Failed to update user", "Update User",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            Form frm = new frmChangePassword(User.ID);
            frm.ShowDialog();
        }

        private void frmUpdateUser_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (IsUpdated)
                UserUpdated?.Invoke();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
