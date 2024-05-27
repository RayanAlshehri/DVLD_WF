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
    public partial class frmReleaseLicense : Form
    {
        public delegate void LicenseReleasedEventHandler();
        public LicenseReleasedEventHandler LicenseReleased;
       
        private int DetentionID;
        private clsDetention Detention;
        private bool IsReleased;
        public frmReleaseLicense(int DetentionID)
        {
            InitializeComponent();
           
            this.DetentionID = DetentionID;
            lblTitle.Location = new Point(clsDesign.GetControlXcenterPosition(ClientSize.Width, lblTitle.Width), clsGlobal.YpositionForTitle);
        }    

        private void frmViewDetention_Load(object sender, EventArgs e)
        {
            decimal ServiceFee = clsService.GetService(clsService.enServices.LicenseRelease).Fee;

            Detention = clsDetention.FindByDetentionID(DetentionID);
            ctrlLicenseInfo1.HideReleaseLicenseLink = true;
            ctrlLicenseInfo1.FillLicenseInfoByLicenseID(Detention.LicenseID);
            lblServiceFee.Text = ServiceFee.ToString();

            if (!Detention.IsFinePaid)
            {
                lblFineFee.Text = Detention.Fine.ToString();
                lblTotal.Text = (ServiceFee + Detention.Fine).ToString();
            }
            else
            {
                lblFineFee.Text = Detention.Fine.ToString() + " (Paid)";
                lblTotal.Text = ServiceFee.ToString();
            }
        }

        private void btnReleaseLicense_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to release this license?", "Confirmation", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                return;
            }

            if (ctrlLicenseInfo1.License.Release(clsGlobal.LogedUser.ID))
            {
                MessageBox.Show("License released successfully", "Release License", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                btnReleaseLicense.Enabled = false;
                ctrlLicenseInfo1.FillLicenseInfoByLicenseID(ctrlLicenseInfo1.License.ID);
                IsReleased = true;
            }
            else
            {
                MessageBox.Show("Failed to release license", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmReleaseLicense_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (IsReleased)
                LicenseReleased?.Invoke();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
