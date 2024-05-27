using CommonClasses;
using DVLD_Business;
using DVLD_Presentation.Properties;
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
    public partial class CtrlLicenseInfo : UserControl
    {
        private clsLicense _License;
        private bool _HideReleaseLicenseLink = false;
        public clsLicense License { get { return _License; } }
        public bool HideReleaseLicenseLink
        {
            get 
            {
                return _HideReleaseLicenseLink; 
            }
            set 
            { 
                _HideReleaseLicenseLink = value;

                if (License != null && License.IsDetained())
                    llReleaseLicense.Visible = value;
            }
        }
        public CtrlLicenseInfo()
        {
            InitializeComponent();
        }

        private void _LoadLicenseInfoToControls()
        {
            if (_License != null)
            {
                lblLicenseID.Text = _License.ID.ToString();
                lblFullName.Text = _License.Driver.Person.FullName;
                lblNationalNo.Text = _License.Driver.Person.NationalNumber;
                lblDriverID.Text = _License.Driver.ID.ToString();
                lblDateOfBirth.Text = clsUtility.FormatDateToDMY(_License.Driver.Person.DateOfBirth);
                lblGender.Text = _License.Driver.Person.Gender.ToString();
                lblClass.Text = clsLicenseClass.GetClass(_License.ClassInfo.Class).Name;
                lblIssueDate.Text = clsUtility.FormatDateToDMY(_License.IssueDate);
                lblExpiryDate.Text = clsUtility.FormatDateToDMY(_License.ExpiryDate);
                lblIssueReason.Text = _License.IssueReasonString;
                lblConstraints.Text = clsLicense.GetConstraintsString(_License.Constraints);
                lblLicenseStatus.Text = _License.LicenseStatusString;

                if (_License.Driver.Person.ImagePath != null)
                {
                    pictureBox1.ImageLocation = _License.Driver.Person.ImagePath;
                }
                else
                {
                    if (_License.Driver.Person.Gender == 'M')
                        pictureBox1.Image = Resources.Person_Male;
                    else
                        pictureBox1.Image = Resources.Person_Female;
                }

                bool IsDetained = _License.IsDetained();

                lblDetentionMessage.Visible = IsDetained;

                if (!_HideReleaseLicenseLink)
                    llReleaseLicense.Visible = IsDetained;
            }
        }

        public void FillLicenseInfoByLicenseID(int LicenseID)
        {         
            _License = clsLicense.FindByLicenseID(LicenseID);
            _LoadLicenseInfoToControls();
        }

        public void FillLicenseInfoByAppID(int ApplicationID)
        {
            _License = clsLicense.FindByApplicationID(ApplicationID);
            _LoadLicenseInfoToControls();
        }

        private void llReleaseLicense_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmReleaseLicense frm = new frmReleaseLicense(clsDetention.FindLastDetentionByLicenseID(_License.ID).ID);

            frm.ShowDialog();
            FillLicenseInfoByLicenseID(_License.ID);
        }
    }
}
