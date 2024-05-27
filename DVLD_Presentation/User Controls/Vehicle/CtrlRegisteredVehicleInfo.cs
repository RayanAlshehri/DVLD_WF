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
    public partial class CtrlRegisteredVehicleInfo : UserControl
    {
        private clsRegisteredVehicle _RegisteredVehicle;
        public CtrlRegisteredVehicleInfo()
        {
            InitializeComponent();
        }

        private void _LoadInfoToControls()
        {
            lblMake.Text = _RegisteredVehicle.Make;
            lblModel.Text = _RegisteredVehicle.Model;
            lblYear.Text = _RegisteredVehicle.Year.ToString();
            lblLicensePlateNumber.Text = _RegisteredVehicle.LicensePlate.Number;
            lblOwnerNationalNumber.Text = _RegisteredVehicle.Driver.Person.NationalNumber;
            lblOwnerFullName.Text = _RegisteredVehicle.Driver.Person.FullName;
            lblGender.Text = _RegisteredVehicle.Driver.Person.Gender.ToString();
            lblRegistrationDate.Text = clsUtility.FormatDateToDMYHM(_RegisteredVehicle.RegisterDate);
        }

        public void FillInfo(int RegisteredVehicleID)
        {
            _RegisteredVehicle = clsRegisteredVehicle.FindByRegisteredVehicleID(RegisteredVehicleID);

            if (_RegisteredVehicle != null )
            {
                _LoadInfoToControls();
            }
            else
            {
                MessageBox.Show("Vehicle not found", "Registered Vehicle Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
