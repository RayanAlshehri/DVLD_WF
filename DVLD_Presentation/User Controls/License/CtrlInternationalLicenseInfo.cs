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
    public partial class CtrlInternationalLicenseInfo : UserControl
    {
        public CtrlInternationalLicenseInfo()
        {
            InitializeComponent();
        }

        public void FillLicenseInfo(int InternationalLicenseID)
        {
            clsInternationalLicense InternationalLicense = clsInternationalLicense.FindByInternationalLicenseID(InternationalLicenseID);

            if (InternationalLicense != null )
            {
                lblLicenseID.Text = InternationalLicense.ID.ToString();
                lblFullName.Text = InternationalLicense.Driver.Person.FullName;
                lblNationalNo.Text = InternationalLicense.Driver.Person.NationalNumber;
                lblDriverID.Text = InternationalLicense.Driver.ID.ToString();
                lblDateOfBirth.Text = clsUtility.FormatDateToDMY(InternationalLicense.Driver.Person.DateOfBirth);
                lblGender.Text = InternationalLicense.Driver.Person.Gender.ToString();
                lblLocalLicenseID.Text = InternationalLicense.IssuedUsingLocalLicenseID.ToString();
                lblIssueDate.Text = clsUtility.FormatDateToDMY(InternationalLicense.IssueDate);
                lblExpiryDate.Text = clsUtility.FormatDateToDMY(InternationalLicense.ExpiryDate);
                lblIssueReason.Text = "First Time";
                lblConstraints.Text = clsLicense.GetConstraintsString(
                    clsLicense.FindByLicenseID(InternationalLicense.IssuedUsingLocalLicenseID).Constraints);
                lblLicenseStatus.Text = InternationalLicense.LicenseStatus;

                if (InternationalLicense.Driver.Person.ImagePath != null)
                {
                    pictureBox1.ImageLocation = InternationalLicense.Driver.Person.ImagePath;
                }
                else
                {
                    if (InternationalLicense.Driver.Person.Gender == 'M')
                        pictureBox1.Image = Resources.Person_Male;
                    else
                        pictureBox1.Image = Resources.Person_Female;
                }
            }
        }
    }
}
