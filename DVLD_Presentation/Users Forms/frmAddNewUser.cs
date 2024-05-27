using DVLD_Business;
using System;
using System.Windows.Forms;
using System.ComponentModel;
using CommonClasses;
using System.Drawing;

namespace DVLD_Presentation
{
    public partial class frmAddNewUser : Form
    {
        public delegate void UserAddedEventHandler(int UserID);
        public UserAddedEventHandler UserAdded;

        private int PersonID;
        private int AddedUserID = -1;
        public frmAddNewUser()
        {
            InitializeComponent();

            lblTitle.Location = new Point(clsDesign.GetControlXcenterPosition(ClientSize.Width, lblTitle.Width), clsGlobal.YpositionForTitle);
        }

        private void ValidateTextBox(TextBox TB)
        {
            if (string.IsNullOrWhiteSpace(TB.Text))
            {
                errorProvider1.SetError(TB, "This field is required");
                TB.Clear();
            }
            else
            {
                errorProvider1.SetError(TB, "");
            }
        }    

        private bool AddUser()
        {      
            clsUser User = new clsUser();
          
            User.Person.ID = PersonID;
            User.Username = tbUsername.Text.Trim();
            User.Password = tbPassword.Text.Trim();
            User.IsActive = cbAccStatus.Checked;
            User.PermissionsOnUsers = ctrlPermissionsOnUsers1.GetPermissionsNumber();

            if (User.Save())
            {
                AddedUserID = User.ID;
                return true;
            }

            return false;
        }

        private void ctrlFindPerson1_PersonFound(object sender, CtrlFindPerson.PersonFoundEventArgs e)
        {
            if (clsUser.DoesUserExistByPersonID(e.FoundPerson.ID))
            {
                MessageBox.Show("This person already has a user account", "Add User",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            gbUserInfo.Enabled = true;
            btnSave.Enabled = true;
            PersonID = e.FoundPerson.ID;
        }

        private void tbUsername_Validating(object sender, CancelEventArgs e)
        {
            if (clsUser.DoesUserExistByUsername(tbUsername.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbUsername, "Username is used");
                return;
            }
            else
            {
                errorProvider1.SetError(tbUsername, "");
            }

            ValidateTextBox(tbUsername);
        }

        private void ValidateRequiredTestBoxes(object sender, CancelEventArgs e)
        {
            TextBox TB = (TextBox)sender;

            if (string.IsNullOrWhiteSpace(TB.Text))
            {
                errorProvider1.SetError(TB, "This field is required");
                e.Cancel = true;
                TB.Clear();
            }
            else
            {
                errorProvider1.SetError(TB, "");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                MessageBox.Show("Invalid information detected", "Add User"
                     , MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
       
            if (tbPassword.Text.Trim() != tbConfirmPassword.Text.Trim())
            {
                MessageBox.Show("Password confirmation does not match the original password", "Add User",
                MessageBoxButtons.OK, MessageBoxIcon.Error);

                tbPassword.Clear();
                tbConfirmPassword.Clear();
                return;
            }

            if (AddUser())
            {
                MessageBox.Show("User added successfully", "Add User",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                ctrlFindPerson1.DisableFindControls();
                gbUserInfo.Enabled = false;
                llViewAddedUserInfo.Enabled = true;
            }
            else
            {
                MessageBox.Show("Failed to add user", "Add User",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void llViewAddedUserInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmUserDetails frm = new frmUserDetails(AddedUserID);

            frm.ShowDialog();
        }

        private void frmAddNewUser_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (AddedUserID != -1)
                UserAdded?.Invoke(AddedUserID);

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
