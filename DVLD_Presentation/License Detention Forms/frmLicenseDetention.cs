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
    public partial class frmLicenseDetention : Form
    {
        private clsLicense FoundLicense;

        public frmLicenseDetention()
        {
            InitializeComponent();

            lblTitle.Location = new Point(clsDesign.GetControlXcenterPosition(ClientSize.Width, lblTitle.Width), clsGlobal.YpositionForTitle);
        }

        private void ctrlSearchForLicense1_LicenseFound(object sender, CtrlSearchForLicense.LicenseFoundEventArgs e)
        {
            if (e.FoundLicense.IsDetained())
            {
                MessageBox.Show("This license is already detained", "License Detention",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                tbFineFee.Enabled = false;
                btnDetainLicense.Enabled = false;
                llViewDriverLicenses.Enabled = false;
                return;
            }

            tbFineFee.Enabled = true;
            btnDetainLicense.Enabled = true;
            llViewDriverLicenses.Enabled = true;
            FoundLicense = e.FoundLicense;

            tbFineFee.Focus();
        }

        private void tbFineFee_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
                e.Handled = true;
        }

        private void btnDetainLicense_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbFineFee.Text))
            {
                MessageBox.Show("Enter fine fee", "License Detention",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            if (MessageBox.Show("Are you sure you want to detain this license", "Confirmation", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                return;
            }

            int DetentionID = FoundLicense.Detain(Convert.ToDecimal(tbFineFee.Text.Trim()), clsGlobal.LogedUser.ID);

            if (DetentionID != -1)
            {
                MessageBox.Show("License detained successfully. Detention ID: " + DetentionID, "Detain License",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                ctrlSearchForLicense1.FindEnabled = false;
                btnDetainLicense.Enabled = false;
                tbFineFee.Enabled = false;

                ctrlSearchForLicense1.FillLicenseInfo(FoundLicense.ID);
            }
            else
            {
                MessageBox.Show("Failed to detain license", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void llViewDriverLicenses_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmDriverLicenses frm = new frmDriverLicenses(FoundLicense.Driver.ID);

            frm.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }     
    }
}
