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
    public partial class frmManageLicensesClasses : Form
    {
        private object CellValueBeforeEdit;
        public frmManageLicensesClasses()
        {
            InitializeComponent();

            lblTitle.Location = new Point(clsDesign.GetControlXcenterPosition(ClientSize.Width, lblTitle.Width),
                clsGlobal.YpositionForTitle);
        }

        private void CustomizeDGV()
        {
            dgvLicensesClasses.Columns["ClassID"].HeaderText = "Class Number";
            dgvLicensesClasses.Columns["ClassID"].ReadOnly = true;

            dgvLicensesClasses.Columns["ClassName"].HeaderText = "Class Name";
            dgvLicensesClasses.Columns["ClassName"].ReadOnly = true;
            dgvLicensesClasses.Columns["ClassName"].Width = 150;

            dgvLicensesClasses.Columns["ClassDescription"].HeaderText = "Class Description";
            dgvLicensesClasses.Columns["ClassDescription"].Width = 170;

            dgvLicensesClasses.Columns["MinimumAge"].HeaderText = "Minimum Age";
            dgvLicensesClasses.Columns["ValidityLength"].HeaderText = "Validity Length";

            dgvLicensesClasses.Columns["Fee"].Width = 70;
        }
    
        private void LoadDatatoDGV()
        {
            dgvLicensesClasses.DataSource = clsLicenseClass.GetAllClasses();
   
            if (dgvLicensesClasses.Rows.Count > 0) 
                CustomizeDGV();
        }

       
        private void frmManageLicensesClasses_Load(object sender, EventArgs e)
        {
            LoadDatatoDGV();
        }

        private void dgvLicensesClasses_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            CellValueBeforeEdit = dgvLicensesClasses.CurrentCell.Value;
        }

        private void dgvLicensesClasses_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (CellValueBeforeEdit.Equals(dgvLicensesClasses.CurrentCell.Value))
                return;

            if (dgvLicensesClasses.CurrentCell.Value == DBNull.Value)
            {
                dgvLicensesClasses.CurrentCell.Value = CellValueBeforeEdit;
                return;
            }

            int EditedRowIndex = dgvLicensesClasses.CurrentCell.RowIndex;
            clsLicenseClass Class = clsLicenseClass.GetClass(
                (clsLicenseClass.enLicenseClasses)dgvLicensesClasses.Rows[EditedRowIndex].Cells["ClassID"].Value);

            Class.Description = dgvLicensesClasses.Rows[EditedRowIndex].Cells["ClassDescription"].Value.ToString().Trim();
            Class.MinimumAge = (byte)dgvLicensesClasses.Rows[EditedRowIndex].Cells["MinimumAge"].Value;
            Class.ValidityLength = (byte)dgvLicensesClasses.Rows[EditedRowIndex].Cells["ValidityLength"].Value;
            Class.Fee = (decimal)dgvLicensesClasses.Rows[EditedRowIndex].Cells["Fee"].Value;

            if (!Class.Save())
            {
                MessageBox.Show("Failed to update class", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dgvLicensesClasses.CurrentCell.Value = CellValueBeforeEdit;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
