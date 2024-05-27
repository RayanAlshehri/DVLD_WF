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
    public partial class CtrlDriverVehicles : UserControl
    {
        private clsDriver _Driver;
        public CtrlDriverVehicles()
        {
            InitializeComponent();
        }

        private void _CustomizeDGV()
        {
            dgvVehicles.Columns["RegisteredVehicleID"].HeaderText = "Registered Vehicle ID";
            dgvVehicles.Columns["VehicleMake"].HeaderText = "Make";
            dgvVehicles.Columns["VehicleModel"].HeaderText = "Model";
            dgvVehicles.Columns["LicensePlateNumber"].HeaderText = "License Plate Number";
            dgvVehicles.Columns["RegisterDate"].HeaderText = "Register Date";
        }

        private void _LoadDataToDGV()
        {
            DataTable VehiclesDT = _Driver.GetAllVehicles();

            if (VehiclesDT.Columns.Count == 0)
            {
                MessageBox.Show("Error in fetching data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (VehiclesDT.Rows.Count == 0)
            {
                lblNoVehiclesMessage.Visible = true;
                return;
            }

            dgvVehicles.DataSource = VehiclesDT;
            _CustomizeDGV();
        }

        public void FillInfo(int DriverID)
        {
            _Driver = clsDriver.FindByDriverID(DriverID);

            if (_Driver != null)
            {
                ctrlPersonCard1.FillPersonCard(_Driver.Person.ID);
                _LoadDataToDGV();
            }
            else
            {
                MessageBox.Show("Driver not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void miVehicleDetails_Click(object sender, EventArgs e)
        {
            frmVehicleInfo frm = new frmVehicleInfo((int)dgvVehicles.CurrentRow.Cells["RegisteredVehicleID"].Value);

            frm.ShowDialog();
        }
    }
}
