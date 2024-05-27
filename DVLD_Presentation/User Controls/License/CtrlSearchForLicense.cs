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
    public partial class CtrlSearchForLicense : UserControl
    {
        private bool _FindEnabled = true;
        public bool FindEnabled 
        { 
            get 
            { 
                return _FindEnabled;
            } 
            set
            {
                _FindEnabled = value;

                tbLicenseID.Enabled = _FindEnabled;
                btnFind.Enabled = _FindEnabled;
            }
        }     
      
        public event EventHandler<LicenseFoundEventArgs> LicenseFound;

        public class LicenseFoundEventArgs : EventArgs
        {
            public clsLicense FoundLicense { get; }

            public LicenseFoundEventArgs(clsLicense FoundLicense)
            {
                this.FoundLicense = FoundLicense;
            }   
        }
        protected virtual void OnLicenseFound()
        {
            LicenseFound?.Invoke(this, new LicenseFoundEventArgs(ctrlLicenseInfo1.License));
        }

        public CtrlSearchForLicense()
        {
            InitializeComponent();
        }

        public void FocusFindTextBox()
        {
            tbLicenseID.Focus();
        }

        public void FillLicenseInfo(int LicenseID)
        {
            ctrlLicenseInfo1.FillLicenseInfoByLicenseID(LicenseID);
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbLicenseID.Text))
            {
                MessageBox.Show("Enter license ID to find", "Find license",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int LicenseID = Convert.ToInt32(tbLicenseID.Text.Trim());          

            if (clsLicense.DoesLicenseExist(LicenseID))
            {
                ctrlLicenseInfo1.FillLicenseInfoByLicenseID(LicenseID);
                
                if (LicenseFound != null)
                    OnLicenseFound();
            }
            else
            {
                MessageBox.Show("License with license ID " + LicenseID + " was not found", "Find License",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbLicenseID_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != '\b';

            if (e.KeyChar == (char)13)
                btnFind.PerformClick();
        }
    }
}
