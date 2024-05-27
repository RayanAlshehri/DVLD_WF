using CommonClasses;
using DVLD_Business;
using System;
using System.Data;
using System.Windows.Forms;
using System.Drawing;

namespace DVLD_Presentation
{
    public partial class frmSelectLicense : Form
    {
        public delegate bool SelectedLicenseValidation(int LicenseID);
        public SelectedLicenseValidation Validation;

        public delegate void LicenseSelectedEventHandler(int LicenseID);
        public LicenseSelectedEventHandler DataBack;

        public frmSelectLicense()
        {
            InitializeComponent();

            lblTitle.Location = new Point(clsDesign.GetControlXcenterPosition(ClientSize.Width, lblTitle.Width),
               clsGlobal.YpositionForTitle);
        }

    
        private void frmSelectLicense_Load(object sender, EventArgs e)
        {
            ctrlFindDriverLicenses1.FindTextBoxFocus();
            ctrlFindDriverLicenses1.rbInternationalLicensesEnabled = false;
        }   

        private void btnSelectLicense_Click(object sender, EventArgs e)
        {
            if (ctrlFindDriverLicenses1.Driver == null)
            {
                MessageBox.Show("Find driver first", "Select License", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Validation != null)
            {
                if (!Validation.Invoke(ctrlFindDriverLicenses1.SelectedLicenseID))
                    return;
            }

            DataBack?.Invoke(ctrlFindDriverLicenses1.SelectedLicenseID);
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
