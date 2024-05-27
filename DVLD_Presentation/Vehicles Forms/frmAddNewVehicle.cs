using CommonClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using DVLD_Business;
using System.Windows.Forms;
using DVLD_Presentation.Vehicles_Forms;

namespace DVLD_Presentation
{
    public partial class frmRegisterVehicle : Form
    {
        private bool IsPersonSelected = false;
        private int FoundPersonDriverID = -1;
        private int NewRegisteredVehicleID;
        public frmRegisterVehicle()
        {
            InitializeComponent();

            lblTapPage1Title.Location = new Point(clsDesign.GetControlXcenterPosition(tpSelectOwner.ClientSize.Width, lblTapPage1Title.Width), clsGlobal.YpositionForTitle);
            lblTapPage2Title.Location = new Point(clsDesign.GetControlXcenterPosition(tpVehicleRegistration.ClientSize.Width, lblTapPage2Title.Width), clsGlobal.YpositionForTitle);
        }

        private bool RegisterVehicle()
        {
            clsRegisteredVehicle RegisteredVehicle = new clsRegisteredVehicle();

            RegisteredVehicle.Driver.ID = FoundPersonDriverID;
            RegisteredVehicle.Make = tbVehicleMake.Text.Trim();
            RegisteredVehicle.Model = tbVehicleModel.Text.Trim();
            RegisteredVehicle.Year = Convert.ToInt32(tbYear.Text.Trim());
            RegisteredVehicle.CreatedByUserID = clsGlobal.LogedUser.ID;

            if (RegisteredVehicle.Save())
            {
                NewRegisteredVehicleID = RegisteredVehicle.ID;
                return true;
            }
            
            return false;
        }

        private void frmRegisterVehicle_Load(object sender, EventArgs e)
        {
            ctrlFindPerson1.EnableAddNewPerson = false;
            tpVehicleRegistration.Enabled = false;
        }

        private void tpSelectOwner_Enter(object sender, EventArgs e)
        {
            ctrlFindPerson1.FocusFindTextBox();
            this.CancelButton = btnClose1;
        }

        private void ctrlFindPerson1_PersonFound(object sender, CtrlFindPerson.PersonFoundEventArgs e)
        {
            if (!clsDriver.DoesDriverExistByPersonID(e.FoundPerson.ID))
            {
                MessageBox.Show("The selected person is not a driver. Please chose a different one", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                IsPersonSelected = false;
                btnNext.Enabled = false;
                return;
            }

            FoundPersonDriverID = clsDriver.FindByPersonID(e.FoundPerson.ID).ID;
            lblDriverID.Text = FoundPersonDriverID.ToString();
            lblDriverFullName.Text = e.FoundPerson.FullName;
            IsPersonSelected = true;
            btnNext.Enabled = true;
            btnNext.Focus();
        }

        private void tpVehicleRegistration_Enter(object sender, EventArgs e)
        {
            if (!IsPersonSelected)
            {
                tabControl1.SelectedTab = tpSelectOwner;
                MessageBox.Show("Select person first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            tpVehicleRegistration.Enabled = true;
            this.CancelButton = btnClose2;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tpVehicleRegistration;
        }

        private void ValidateRequiredTextBox_Validating(object sender, CancelEventArgs e)
        {
            TextBox TB = (TextBox)sender;

            if (string.IsNullOrWhiteSpace(TB.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(TB, "This field is required");
            }
            else
            {
                errorProvider1.SetError(TB, "");
            }
        }

        private void tbYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b');
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                MessageBox.Show("Fill required fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Convert.ToInt32(tbYear.Text.Trim()) > DateTime.Now.Year + 1)
            {
                MessageBox.Show("Year can not be more than one year in the future", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("Are you sure that you to register this vehicle?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                return;
            }

            if (RegisterVehicle())
            {
                MessageBox.Show("Vehicle registered successfully", "Register Vehicle", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ctrlFindPerson1.EnableFindControls = false;
                tbVehicleMake.Enabled = false;
                tbVehicleModel.Enabled = false;
                tbYear.Enabled = false;
                btnSave.Enabled = false;
                llViewRegisteredVehicle.Enabled = true;
            }
            else
            {
                MessageBox.Show("Vehicle registration failed", "Register Vehicle", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void llViewRegisteredVehicle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmVehicleInfo frm = new frmVehicleInfo(NewRegisteredVehicleID);

            frm.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void llViewDriverVehicles_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmDriverVehicles frm = new frmDriverVehicles(FoundPersonDriverID);
            frm.ShowDialog();
        }
    }
}
