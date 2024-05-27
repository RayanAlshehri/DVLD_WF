using CommonClasses;
using DVLD_Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace DVLD_Presentation
{
    public partial class frmReplacementOfLostOrDamaged : Form
    {
        private decimal LostFee;
        private decimal DamagedFee;
        private clsLicense FoundLicense;
        private int NewLicenseID;
        public frmReplacementOfLostOrDamaged()
        {
            InitializeComponent();

            lblTitle.Location = new Point(clsDesign.GetControlXcenterPosition(ClientSize.Width, lblTitle.Width),
                clsGlobal.YpositionForTitle);
        }

        private void DisableIssueReplacementControls()
        {
            rbLost.Enabled = false;
            rbDamaged.Enabled = false;
            lblServiceFee.Text = string.Empty;
            btnIssueLicense.Enabled = false;
        }
                                  
        private bool IsSelectedLicenseElegibleForReplacement(int LicenseID)
        {
            clsLicense License = clsLicense.FindByLicenseID(LicenseID);

            if (!License.IsActive)
            {
                MessageBox.Show("License has to be active", "Select License",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                DisableIssueReplacementControls();;              
                return false;
            }
            else if (License.IsExpired())
            {
                MessageBox.Show("License can not be expired", "Select License",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                DisableIssueReplacementControls();
                return false;
            }
            else if (License.IsDetained())
            {
                MessageBox.Show("This License is detained", "Select License", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DisableIssueReplacementControls();
                return false;
            }
            else
            {              
                FoundLicense = License;
                ctrlSearchForLicense1.FillLicenseInfo(LicenseID);
                rbLost.Enabled = true;
                rbDamaged.Enabled = true;
                btnIssueLicense.Enabled = true;

                return true;
            }
        }       

        private void DisplaySelectedServiceFee()
        {
            if (rbLost.Checked)
                lblServiceFee.Text = LostFee.ToString();
            else
                lblServiceFee.Text = DamagedFee.ToString();
        }

        private clsLicense.enLicenseIssueReasons GetIssueReason()
        {
            return rbLost.Checked ? clsLicense.enLicenseIssueReasons.ReplaceLost : clsLicense.enLicenseIssueReasons.ReplaceDamaged;
        }
             
        private void PutFormInLicenseIssuedState()
        {
            ctrlSearchForLicense1.FindEnabled = false;
            btnOtherFindOptions.Enabled = false;
            rbLost.Enabled = false;
            rbDamaged.Enabled = false;
            btnIssueLicense.Enabled = false;

            llViewNewLicense.Enabled = true;
        }


        //Events:

        private void frmReplacementOfLostOrDamaged_Load(object sender, EventArgs e)
        {
            LostFee = clsService.GetService(clsService.enServices.ReplaceLost).Fee;
            DamagedFee = clsService.GetService(clsService.enServices.ReplaceDamaged).Fee;
            ctrlSearchForLicense1.FocusFindTextBox();
        }

        private void ctrlSearchForLicense1_LicenseFound(object sender, CtrlSearchForLicense.LicenseFoundEventArgs e)
        {
            if (!e.FoundLicense.IsActive)
            {
                MessageBox.Show("License has to be active", "License Replacement",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                DisableIssueReplacementControls();
                return;
            }
            else if (e.FoundLicense.IsExpired())
            {
                MessageBox.Show("License can not be expired", "License Replacement",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                DisableIssueReplacementControls();
                return;
            }
            else if (e.FoundLicense.IsDetained())
            {
                MessageBox.Show("This License is detained", "License Replacement", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DisableIssueReplacementControls();
                return;
            }
            else
            {
                rbLost.Enabled = true;
                rbDamaged.Enabled = true;
                btnIssueLicense.Enabled = true;
                btnIssueLicense.Focus();
                FoundLicense = e.FoundLicense;
            }
        }

        private void btnOtherFindOptions_Click(object sender, EventArgs e)
        {
            frmSelectLicense frm = new frmSelectLicense();

            frm.Validation += IsSelectedLicenseElegibleForReplacement;
            frm.ShowDialog();
        }

        private void rbLost_CheckedChanged(object sender, EventArgs e)
        {
            DisplaySelectedServiceFee();
        }

        private void rbDamaged_CheckedChanged(object sender, EventArgs e)
        {
            DisplaySelectedServiceFee();
        }

        private void btnIssueLicense_Click(object sender, EventArgs e)
        {
            if (!rbLost.Checked && !rbDamaged.Checked)
            {
                MessageBox.Show("Chose replacement reason", "Issue Replacement",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            if (MessageBox.Show("Are you want to Issue a replacement for this license?", "Confirmation",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                return;
            }         

            clsLicense NewLicense = FoundLicense.Replace(GetIssueReason(), clsGlobal.LogedUser.ID);

            if (NewLicense != null)
            {
                MessageBox.Show("New license issued successfully", "Issue Replacement",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
               
                PutFormInLicenseIssuedState();
                NewLicenseID = NewLicense.ID;
            }
            else
            {
                MessageBox.Show("Failed to issue replacement", "Issue Replacement",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void llViewNewLicense_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form frm = new frmLicenseInfo(NewLicenseID);
            frm.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }      
    }
}
