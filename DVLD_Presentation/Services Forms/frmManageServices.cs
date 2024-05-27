using CommonClasses;
using DVLD_Business;
using System;
using System.Windows.Forms;
using System.Drawing;

namespace DVLD_Presentation
{
    public partial class frmManageServices : Form
    {
        private object CellValueBeforeEdit;
        public frmManageServices()
        {
            InitializeComponent();

            lblTitle.Location = new Point(clsDesign.GetControlXcenterPosition(ClientSize.Width, lblTitle.Width), clsGlobal.YpositionForTitle);
        }

        private void CustomizeDGV()
        {
            dgvServices.Columns["ServiceID"].HeaderText = "Service Number";
            dgvServices.Columns["ServiceID"].Width = 150;
            dgvServices.Columns["ServiceID"].ReadOnly = true;

            dgvServices.Columns["ServiceName"].HeaderText = "Service Name";
            dgvServices.Columns["ServiceName"].Width = 250;
            dgvServices.Columns["ServiceName"].ReadOnly = true;
        }

        private void LoadDatatoDGV()
        {           
            dgvServices.DataSource = clsService.GetAllServices();
  
            if (dgvServices.Rows.Count > 0 )
                CustomizeDGV();       
        }


        //Events
        private void frmManageServices_Load(object sender, EventArgs e)
        {
            LoadDatatoDGV();
        }

        private void dgvServices_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            CellValueBeforeEdit = dgvServices.CurrentCell.Value;
        }

        private void dgvServices_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (CellValueBeforeEdit.Equals(dgvServices.CurrentCell.Value))
                return;

            if (dgvServices.CurrentCell.Value == DBNull.Value)
            {
                dgvServices.CurrentCell.Value = CellValueBeforeEdit;
                return;
            }

            int EditedRowIndex = dgvServices.CurrentCell.RowIndex;

            clsService Service = clsService.GetService((clsService.enServices)dgvServices.Rows[EditedRowIndex].Cells["ServiceID"].Value);

            Service.Fee = (decimal)dgvServices.Rows[EditedRowIndex].Cells["Fee"].Value;

            if (!Service.Save())
            {
                MessageBox.Show("Error in updating service", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dgvServices.CurrentCell.Value = CellValueBeforeEdit;
            }                    
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
