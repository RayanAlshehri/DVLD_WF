using DVLD_Business;
using System;
using System.Windows.Forms;
using System.ComponentModel;
using CommonClasses;
using System.Drawing;
using System.Configuration;

namespace DVLD_Presentation
{
    public partial class frmChangePassword : Form
    {
        private int UserID = -1;
        private clsUser User;
        public frmChangePassword(int UserID)
        {
            InitializeComponent();

            this.UserID = UserID;
            lblTitle.Location = new Point(clsDesign.GetControlXcenterPosition(ClientSize.Width, lblTitle.Width), clsGlobal.YpositionForTitle);         
        }

        private void ClearPasswordTextBoxes()
        {
            tbOldPass.Focus();
            tbOldPass.Clear();
            tbNewPass.Clear();
            tbConfirmPass.Clear();
        }


        private void frmChangePassword_Load(object sender, EventArgs e)
        {
            User = clsUser.Find(UserID);

            if (User == null)
                return;

            ctrlPersonCard1.FillPersonCard(User.Person.ID);
            ctrlUserCard1.FillUserCard(User.ID);
            tbOldPass.Focus();
        }

        private void ValidateRequiredFields(object sender, CancelEventArgs e)
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string NewPassword = tbNewPass.Text.Trim();

                if (!ValidateChildren())
                {
                    MessageBox.Show("Fill rquired information", "Change Password",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                    ClearPasswordTextBoxes();
                    return;
                }

                if (clsUtility.HashData(tbOldPass.Text.Trim()) != User.Password)
                {
                    MessageBox.Show("Old password is incorrect", "Change Password",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                    ClearPasswordTextBoxes();
                    return;
                }

                if (clsUtility.HashData(NewPassword) == User.Password)
                {
                    MessageBox.Show("New password matches the old password", "Change Password",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                    ClearPasswordTextBoxes();
                    return;
                }

                if (NewPassword != tbConfirmPass.Text.Trim())
                {
                    MessageBox.Show("New and confirmed passwords do not match", "Change Password",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                    ClearPasswordTextBoxes();
                    return;
                }

                if (User.UpdatePassword(NewPassword))
                {
                    MessageBox.Show("Password changed successfully", "Change Password",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ClearPasswordTextBoxes();

                }
                else
                {
                    MessageBox.Show("Failed to update password", "Change Password",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                    ClearPasswordTextBoxes();
                }
            }
            catch (Exception EX)
            {
                clsUtility.LogExceptionToEventViewer(ConfigurationManager.AppSettings["LoggedExceptionSourceName"], EX);

                MessageBox.Show("Failed to update password", "Change Password",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
