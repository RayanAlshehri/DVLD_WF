using DVLD_Business;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace DVLD_Presentation
{
    public partial class frmMainScreen : Form
    {
        bool IsFormCloseByLogoutBtn;
        frmLogin LoginForm;
        public frmMainScreen(frmLogin LoginForm)
        {
            InitializeComponent();

            this.LoginForm = LoginForm;
        }

        private void OpenChildForm(Form frm) 
        {
            frm.ShowDialog();          
        }


        //Events:

        //Main menu items:  
        private void miPersons_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmManagePerson());
        }

        private void miDrivers_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmManageDrivers());
        }

        private void miUsers_Click(object sender, EventArgs e)
        {
            if (!clsGlobal.LogedUser.HasPermission(clsUser.enPermissionsOnUsers.ViewList))
            {
                MessageBox.Show("Access denied. You do not have access to Users list", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            OpenChildForm(new frmMangeUsers());
        }


        //Account Settings drop down items:
        private void ddmiUserDetails_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmUserDetails(clsGlobal.LogedUser.ID));
        }
     
        private void ddmiChangePassword_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmChangePassword(clsGlobal.LogedUser.ID));
        }

        private void ddmiLogout_Click(object sender, EventArgs e)
        {
            IsFormCloseByLogoutBtn = true;
            Close();
            LoginForm.Show();
        }


        //Applications drop down items:
        private void ddmiManageSevices_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmManageServices());
        }

        private void ddmiManageApplications_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmManageApplications());
        }      

        private void ddmiManageLicensesClasses_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmManageLicensesClasses());
        }

        private void ddmiManageTests_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmManageTests());
        }


        //New drop down items:      
        private void miLocalLicense_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmLocalDrivingLicenseApplication());
        }

        private void miInternationalLicense_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmIssueInternationalLicense());
        }

        private void ddmiLicenseRenew_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmLicenseRenewal());
        }

        private void ddmiReplamcent_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmReplacementOfLostOrDamaged());
        }
     
        private void ddmiDetainLicense_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmLicenseDetention());
        }

        private void ddmiReleaseLicense_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmLicenseRelease());
        }

        private void miClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmMainScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!IsFormCloseByLogoutBtn)
                Environment.Exit(0);
        }

        private void miManageLicensesClasses_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmManageLicensesClasses());
        }

        private void miManageTests_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmManageTests());
        }

        private void miManageServices_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmManageServices());
        }
               
        private void MenuItem_DropDownOpened(object sender, EventArgs e)
        {
            ToolStripMenuItem Item = (ToolStripMenuItem)sender;
            Item.ForeColor = Color.Black;
        }

        private void MenuItem_DropDownClosed(object sender, EventArgs e)
        {
            ToolStripMenuItem Item = (ToolStripMenuItem)sender;
            Item.ForeColor = Color.White;
        }

        private void ddmiRegisterVehicles_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmRegisterVehicle());
        }
    }
}
