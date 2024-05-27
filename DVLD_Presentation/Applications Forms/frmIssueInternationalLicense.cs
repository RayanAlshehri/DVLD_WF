using CommonClasses;
using DVLD_Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Presentation
{
    public partial class frmIssueInternationalLicense : Form
    {
        private int IssuedInternationalLicenseID;
        private clsLicense FoundLicense;
        public frmIssueInternationalLicense()
        {
            InitializeComponent();

            lblTitle.Location = new Point(clsDesign.GetControlXcenterPosition(ClientSize.Width, lblTitle.Width), clsGlobal.YpositionForTitle);
        }
      
        private void frmIssueInternationalLicense_Load(object sender, EventArgs e)
        {
            lblServiceFee.Text = clsService.GetService(clsService.enServices.IssueInternationalLicense).Fee.ToString();
        }

        private void ctrlSearchForLicense1_LicenseFound(object sender, CtrlSearchForLicense.LicenseFoundEventArgs e)
        {
            if (!e.FoundLicense.IsActive)
            {
                MessageBox.Show("Selected license has to be active", "Issue International License",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                btnIssueLicense.Enabled = false;
                return;
            }

            if (e.FoundLicense.IsExpired())
            {
                MessageBox.Show("Selected license can not be expired", "Issue International License",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                btnIssueLicense.Enabled = false;
                return;
            }

            if (e.FoundLicense.ClassInfo.Class != clsLicenseClass.enLicenseClasses.Normal)
            {
                MessageBox.Show("Selected license class has to be class 3(Normal)", "Issue International License",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                btnIssueLicense.Enabled = false;
                return;
            }

            if (e.FoundLicense.IsDetained())
            {
                MessageBox.Show("This License is detained", "Issue International License", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnIssueLicense.Enabled = false;
                return;
            }

            btnIssueLicense.Enabled = true;
            btnIssueLicense.Focus();
            FoundLicense = e.FoundLicense;
        }

        private void btnIssueLicense_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are sure you want issue an international license", "Issue International License", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                return;
            }

           
            if (FoundLicense.HasInternationalLicense())
            {
                if (MessageBox.Show("This driver already has an international license. Do you want to issue a new one?. " +
                    "Issuing a new license will deactivate the previous one.", "Issue International License", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
                {
                    return;
                }
            }

            IssuedInternationalLicenseID = FoundLicense.IssueInternationalLicense(clsGlobal.LogedUser.ID);

            if (IssuedInternationalLicenseID != -1)
            {
                MessageBox.Show("license issue successfully", "Issue International License",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                ctrlSearchForLicense1.FindEnabled = false;
                btnIssueLicense.Enabled = false;
                llViewInternationalLicense.Enabled = true;
            }
            else
            {
                MessageBox.Show("Failed to issue license", "Issue International License",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void llViewInternationalLicense_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form frm = new frmInternationalLicenseInfo(IssuedInternationalLicenseID);
            frm.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }       
    }
}
