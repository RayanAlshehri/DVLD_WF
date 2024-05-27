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
using System.Windows.Controls;
using System.Windows.Forms;

namespace DVLD_Presentation
{
    public partial class frmLicenseRenewal : Form
    {
        private clsLicense FoundLicense;
        private int NewLicenseID;      
        public frmLicenseRenewal()
        {
            InitializeComponent();

            lblTitle.Location = new Point(clsDesign.GetControlXcenterPosition(ClientSize.Width, lblTitle.Width), clsGlobal.YpositionForTitle);
        }


        private void PutFormInLicenseRenewedState()
        {
            ctrlSearchForLicense1.FindEnabled = false;
            btnIssueLicense.Enabled = false;

            llViewNewLicense.Enabled = true;
        }

    
        private void frmLicenseRenewal_Load(object sender, EventArgs e)
        {
            ctrlSearchForLicense1.FocusFindTextBox();
            lblServiceFee.Text = clsService.GetService(clsService.enServices.LicenseRenew).Fee.ToString();
        }

        private void ctrlSearchForLicense1_LicenseFound(object sender, CtrlSearchForLicense.LicenseFoundEventArgs e)
        {
            if (!(e.FoundLicense.IsExpired() && e.FoundLicense.IsActive))
            {
                MessageBox.Show("Selected license has to be expired and active", "License Renew",
                  MessageBoxButtons.OK, MessageBoxIcon.Error);

                lblClassFee.Text = "";
                lblTotal.Text = "";
                btnIssueLicense.Enabled = false;
                return;
            }

            if (e.FoundLicense.IsDetained())
            {
                MessageBox.Show("This License is detained", "License Renew", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblClassFee.Text = "";
                lblTotal.Text = "";
                btnIssueLicense.Enabled = false;
                return;
            }

            lblClassFee.Text = e.FoundLicense.ClassInfo.Fee.ToString();
            lblTotal.Text = (Convert.ToDecimal(lblServiceFee.Text) + Convert.ToDecimal(lblClassFee.Text)).ToString();
            btnIssueLicense.Enabled = true;
            btnIssueLicense.Focus();
            this.FoundLicense = e.FoundLicense;
        }

        private void btnIssueLicense_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to renew this license?", "License Renewal", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                return;
            }

            clsLicense NewLicense = FoundLicense.Renew(clsGlobal.LogedUser.ID);

            if (NewLicense != null)
            {
                MessageBox.Show("New license issued successfully", "License Renewal", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                PutFormInLicenseRenewedState();
                NewLicenseID = NewLicense.ID;
            }
            else
            {
                MessageBox.Show("Failed to renew license", "License Renewal",
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
