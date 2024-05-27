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

namespace DVLD_Presentation.User_Controls.License
{
    public partial class CtrlFindDriverLicenses : UserControl
    {
        enum enFindOptions {NationalNumber = 0, DriverID = 1}

        private enFindOptions _SelectedFindOption = enFindOptions.NationalNumber;

        public bool rbInternationalLicensesEnabled
        {
            get 
            { 
                return ctrlDriverLicenses1.rbInternationalLicensesEnabled;
            }
            set
            {
                ctrlDriverLicenses1.rbInternationalLicensesEnabled = value;
            }
        }

        public clsDriver Driver
        {
            get
            {
                return ctrlDriverLicenses1.Driver;
            }
        }

        public int SelectedLicenseID
        {
            get { return ctrlDriverLicenses1.SelectedLicenseID; }
        }

        public CtrlFindDriverLicenses()
        {
            InitializeComponent();
        }

        public void FindTextBoxFocus()
        {
            tbFind.Focus();
        }

        private void CtrlFindDriverLicenses_Load(object sender, EventArgs e)
        {
            cbFindBy.SelectedIndex = (int)_SelectedFindOption;
        }

        private void cbFindBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            _SelectedFindOption = (enFindOptions)cbFindBy.SelectedIndex;
        }

        private void tbFind_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != '\b';

            if (e.KeyChar == (char)13)
                btnFind.PerformClick();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbFind.Text))
            {
                string FindBy = _SelectedFindOption == enFindOptions.NationalNumber ? "National Number" : "Driver ID";

                MessageBox.Show("Enter " + FindBy + " to find", "Driver Licenses", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            switch(_SelectedFindOption)
            {
                case enFindOptions.NationalNumber:
                    string NationalNumber = tbFind.Text.Trim();
                    clsPerson Person = clsPerson.Find(NationalNumber);

                    if (Person != null)
                    {
                        ctrlDriverLicenses1.FillInfoByPersonID(Person.ID);
                    }
                    else
                    {
                        MessageBox.Show("Person with national number " + NationalNumber + " was not found", "Driver License",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    break;

                case enFindOptions.DriverID:
                    int DriverID = Convert.ToInt32(tbFind.Text.Trim());
                    clsDriver Driver = clsDriver.FindByDriverID(DriverID);

                    if (Driver != null)
                    {
                        ctrlDriverLicenses1.FillInfoByDriverID(DriverID);
                    }
                    else
                    {
                        MessageBox.Show("Driver with Driver ID" + Driver + " was not found", "Driver License",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    break;
            }
        }       
    }
}
