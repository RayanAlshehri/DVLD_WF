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
using System.Windows.Navigation;

namespace DVLD_Presentation
{
    public partial class CtrlDriverLicenses : UserControl
    {
        private clsDriver _Driver;
        private bool _rbInternationalLicensesEnabled = true;
        private DataTable _LocalLicensesDT;
        private DataTable _InternationalLicensesDT;

        public bool rbInternationalLicensesEnabled
        {
            get 
            { 
                return _rbInternationalLicensesEnabled;
            }
            set 
            {
                _rbInternationalLicensesEnabled = value;
                rbInternationalLicenses.Enabled = value;
            }
        }

        public clsDriver Driver
        {
            get
            {
                return _Driver != null ?  _Driver : null;
            }
        }
        public int SelectedLicenseID
        {
            get { return (int)dgvLicenses.CurrentRow.Cells["License ID"].Value; }
        }

        public CtrlDriverLicenses()
        {
            InitializeComponent();
        }
           
        private void CustomizeInternationalLicenseDT()
        {
            if (_InternationalLicensesDT.Columns.Count > 0)
            {
                _InternationalLicensesDT.Columns["InternationalLicenseID"].ColumnName = "License ID";
                _InternationalLicensesDT.Columns["DriverID"].ColumnName = "Driver ID";
                _InternationalLicensesDT.Columns["IssuedUsingLocalLicenseID"].ColumnName = "Local License ID";
                _InternationalLicensesDT.Columns["IssueDate"].ColumnName = "Issue Date";
                _InternationalLicensesDT.Columns["ExpiryDate"].ColumnName = "Expiry Date";
                _InternationalLicensesDT.Columns["LicenseStatus"].ColumnName = "License Status";
            }
        }

        private void _LoadLicensesToDataTables()
        {
            _LocalLicensesDT = _Driver.GetAllLicenses();
            _InternationalLicensesDT = _Driver.GetAllInternationalLicenses();
            CustomizeInternationalLicenseDT();
        }

        private void _LoadCheckedLicensesType()
        {
            if (rbLocalLicenses.Checked)
                dgvLicenses.DataSource = _LocalLicensesDT;
            else
                dgvLicenses.DataSource = _InternationalLicensesDT;
        }

        private void _LoadInfo()
        {
            ctrlPersonCard1.FillPersonCard(_Driver.Person.ID);
            _LoadLicensesToDataTables();

            if (_LocalLicensesDT.Columns.Count == 0)
            {
                MessageBox.Show("Error in fetching local licenses data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                            
            }

            if (_InternationalLicensesDT.Columns.Count == 0 )
            {
                MessageBox.Show("Error in fetching international licenses data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            rbLocalLicenses.Checked = true;
        }

        public void FillInfoByDriverID(int DriverID)
        {
            _Driver = clsDriver.FindByDriverID(DriverID);

            if (_Driver != null)
            {
                _LoadInfo();
            }
            else
            {
                MessageBox.Show("Driver with driver ID " + DriverID + "was not found", "Driver Licenses",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void FillInfoByPersonID(int PersonID)
        {
            _Driver = clsDriver.FindByPersonID(PersonID);

            if (_Driver != null)
            {
                _LoadInfo();
            }           
            else if (clsPerson.DoesPersonExist(PersonID))
            {
                MessageBox.Show("This person does not have any license", "Driver Licenses",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Person was not found", "Driver Licenses",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void rbLocalLicenses_CheckedChanged(object sender, EventArgs e)
        {
            _LoadCheckedLicensesType();
        }

        private void rbInternationalLicenses_CheckedChanged(object sender, EventArgs e)
        {
            _LoadCheckedLicensesType();
        }
     
        private void miLicenseDetails_Click(object sender, EventArgs e)
        {
            if (rbLocalLicenses.Checked)
            {
                Form frm = new frmLicenseInfo((int)dgvLicenses.CurrentRow.Cells["License ID"].Value);
                frm.ShowDialog();
            }    
            else
            {
                Form frm = new frmInternationalLicenseInfo((int)dgvLicenses.CurrentRow.Cells["License ID"].Value);
                frm.ShowDialog();
            }
        }
    }
}
