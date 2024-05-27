using CommonClasses;
using DVLD_Business;
using DVLD_Presentation.Vehicles_Forms;
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
    public partial class frmManageDrivers : Form
    {
        enum enFilters { None, DriverID, NationalNo, FullName}

        private DataTable DriversDT;
        enFilters CurrentFilter;
        public frmManageDrivers()
        {
            InitializeComponent();

            lblTitle.Location = new Point(clsDesign.GetControlXcenterPosition(ClientSize.Width, lblTitle.Width), clsGlobal.YpositionForTitle);
        }

        private void ChangeDGVcolumnsNames()
        {
            dgvDrivers.Columns["DriverID"].HeaderText = "Driver ID";
            dgvDrivers.Columns["NationalNumber"].HeaderText = "National No.";
            dgvDrivers.Columns["FullName"].HeaderText = "Full Name";
            dgvDrivers.Columns["ActiveLicenses"].HeaderText = "Active Licenses";
        }

        private void LoadDataToDGV()
        {
            DriversDT = clsDriver.GetAllDrivers();

            if (DriversDT.Columns.Count == 0 )
            {
                MessageBox.Show("Error in fetching data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            dgvDrivers.DataSource = DriversDT;
            ChangeDGVcolumnsNames();         
        }

        private void ApplyFilter()
        {
            switch(CurrentFilter)
            {             
                case enFilters.DriverID:
                    if (tbFilter.Text != "")
                    {
                        DriversDT.DefaultView.RowFilter = "[DriverID] = " + tbFilter.Text.Trim();
                    }
                    else
                    {
                        DriversDT.DefaultView.RowFilter = "";
                    }
                    break;

                case enFilters.NationalNo:
                    DriversDT.DefaultView.RowFilter = "[NationalNumber] like '" + tbFilter.Text.Trim() + "%'";
                    break;

                case enFilters.FullName:
                    DriversDT.DefaultView.RowFilter = "[FullName] like '" + tbFilter.Text.Trim() + "%'";
                    break;
            }
        }


        //Events:
        private void frmManageDrivers_Load(object sender, EventArgs e)
        {
            LoadDataToDGV();
            lblNoOfRecords.Text = $"{dgvDrivers.RowCount} Record(s)";
            cbFilters.SelectedIndex = 0;
        }

        private void cbFilters_SelectedIndexChanged(object sender, EventArgs e)
        {
            DriversDT.DefaultView.RowFilter = "";
            CurrentFilter = (enFilters)cbFilters.SelectedIndex;

            if (CurrentFilter == enFilters.None)
            {
                tbFilter.Visible = false;
            }
            else
            {
                tbFilter.Clear();
                tbFilter.Visible = true;
            }
        }

        private void tbFilter_TextChanged(object sender, EventArgs e)
        {
            ApplyFilter();
            lblNoOfRecords.Text = $"{dgvDrivers.RowCount} Record(s)";
        }

        private void tbFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (CurrentFilter == enFilters.DriverID && !char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if (dgvDrivers.SelectedRows.Count != 1)
                e.Cancel = true;
        }

        private void miViewLicenses_Click(object sender, EventArgs e)
        {
            Form frm = new frmDriverLicenses((int)dgvDrivers.SelectedRows[0].Cells["DriverID"].Value);
            frm.ShowDialog();
        }

        private void miViewVehicles_Click(object sender, EventArgs e)
        {          
            Form frm = new frmDriverVehicles((int)dgvDrivers.SelectedRows[0].Cells["DriverID"].Value);
            frm.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }       
    }
}
