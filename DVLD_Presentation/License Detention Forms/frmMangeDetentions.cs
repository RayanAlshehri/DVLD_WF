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
    public partial class frmLicenseRelease : Form
    {
        enum enFilters {None = 0, LicenseID = 1, NationalNumber = 2, DetentionID = 3}

        private DataTable DetainedLicensesDT;
        private enFilters SelectedFilter;

        public frmLicenseRelease()
        {
            InitializeComponent();

            lblTitle.Location = new Point(clsDesign.GetControlXcenterPosition(ClientSize.Width, lblTitle.Width), clsGlobal.YpositionForTitle);
        }

        private void CustomizeDGV()
        {
            dgvDetainedLicenses.Columns["DetentionID"].HeaderText = "Detention ID";
            dgvDetainedLicenses.Columns["DetentionID"].Width = 100;

            dgvDetainedLicenses.Columns["LicenseID"].HeaderText = "License ID";
            dgvDetainedLicenses.Columns["LicenseID"].Width = 100;

            dgvDetainedLicenses.Columns["DriverNationalNumber"].HeaderText = "Driver National Number";
            dgvDetainedLicenses.Columns["DriverNationalNumber"].Width = 140;

            dgvDetainedLicenses.Columns["DriverFullName"].HeaderText = "Driver Full Name";
            dgvDetainedLicenses.Columns["DriverFullName"].Width = 200;

            dgvDetainedLicenses.Columns["DetentionDate"].HeaderText = "Detention Date";
            dgvDetainedLicenses.Columns["DetentionDate"].Width = 130;

            dgvDetainedLicenses.Columns["Fine"].HeaderText = "Fine";
            dgvDetainedLicenses.Columns["Fine"].Width = 80;

            dgvDetainedLicenses.Columns["Status"].Width = 80;

            dgvDetainedLicenses.Columns["ReleaseDate"].HeaderText = "Release Date";
            dgvDetainedLicenses.Columns["ReleaseDate"].Width = 130;
        }

        private void LoadDataToDGV()
        {
            DetainedLicensesDT = clsDetention.GetAllDetention();

            if (DetainedLicensesDT.Rows.Count > 0)
            {
                DetainedLicensesDT.Columns["Status"].ReadOnly = false;
                DetainedLicensesDT.Columns["ReleaseDate"].ReadOnly = false;
            }

            dgvDetainedLicenses.DataSource = DetainedLicensesDT;

            if (dgvDetainedLicenses.Rows.Count > 0)
                CustomizeDGV();
        }

        private void ApplyFilter()
        {
            switch (SelectedFilter)
            {
                case enFilters.LicenseID:
                    DetainedLicensesDT.DefaultView.RowFilter = "[LicenseID] = " + tbFilter.Text.Trim();
                    break;

                case enFilters.NationalNumber:
                    DetainedLicensesDT.DefaultView.RowFilter = "[DriverNationalNumber] like '" + tbFilter.Text.Trim() + "%'";
                    break;

                case enFilters.DetentionID:
                    DetainedLicensesDT.DefaultView.RowFilter = "[DetentionID] = " + tbFilter.Text.Trim();
                    break;
            }
        }

        public void UpdateDetention()
        {           
            dgvDetainedLicenses.CurrentRow.Cells["Status"].Value = "Released";
            dgvDetainedLicenses.CurrentRow.Cells["ReleaseDate"].Value =
                clsUtility.FormatDateToDMYHM(
                    clsDetention.FindByDetentionID((int)dgvDetainedLicenses.CurrentRow.Cells["DetentionID"].Value).DetentionDate);
        }

        private void frmLicenseRelease_Load(object sender, EventArgs e)
        {
            LoadDataToDGV();
            cbFilter.SelectedIndex = (int)enFilters.None;
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedFilter = (enFilters)cbFilter.SelectedIndex;
            DetainedLicensesDT.DefaultView.RowFilter = "";

            if (SelectedFilter == enFilters.None)
            {
                tbFilter.Visible = false;
            }
            else
            {
                tbFilter.Clear();
                tbFilter.Visible = true;
            }
        }

        private void tbFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != '\b';
        }

        private void tbFilter_TextChanged(object sender, EventArgs e)
        {
            if (!(tbFilter.Text == "" && (SelectedFilter == enFilters.LicenseID || SelectedFilter == enFilters.DetentionID)))
                ApplyFilter();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            miReleaseLicense.Enabled = dgvDetainedLicenses.CurrentRow.Cells["Status"].Value.ToString() == "Detained" ?
                true : false;
        }

        private void miReleaseLicense_Click(object sender, EventArgs e)
        {
            frmReleaseLicense frm = new frmReleaseLicense((int)dgvDetainedLicenses.SelectedRows[0].Cells["DetentionID"].Value);

            frm.LicenseReleased += UpdateDetention;
            frm.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvDetainedLicenses_KeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = (e.KeyCode == Keys.Escape);
            Close();
        }
    }
}
