using CommonClasses;
using DVLD_Business;
using System;
using System.Windows.Forms;
using System.Drawing;
using System.Security.Policy;

namespace DVLD_Presentation
{
    public partial class frmManageTests : Form
    {
        private object CellValueBeforeEdit;
        public frmManageTests()
        {
            InitializeComponent();

            lblTitle.Location = new Point(clsDesign.GetControlXcenterPosition(ClientSize.Width, lblTitle.Width), clsGlobal.YpositionForTitle);
        }

        private void CustomizeDGV()
        {
            dgvTests.Columns["TestTypeID"].HeaderText = "Test Number";
            dgvTests.Columns["TestTypeID"].ReadOnly = true;

            dgvTests.Columns["TestName"].HeaderText = "Test Name";
            dgvTests.Columns["TestName"].ReadOnly = true;

            dgvTests.Columns["Fee"].HeaderText = "Fee";
        }

        private void LoadDataToDGV()
        {        
            dgvTests.DataSource = clsTestType.GetAllTests();
            
            if (dgvTests.Rows.Count > 0 )
            {
                CustomizeDGV();
            }
        }


        private void frmManageTests_Load(object sender, EventArgs e)
        {
            LoadDataToDGV();
        }

        private void dgvTests_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            CellValueBeforeEdit = dgvTests.CurrentCell.Value;
        }

        private void dgvTests_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (CellValueBeforeEdit.Equals(dgvTests.CurrentCell.Value))
                return;

            if (dgvTests.CurrentCell.Value == DBNull.Value)
            {
                dgvTests.CurrentCell.Value = CellValueBeforeEdit;
                return;
            }

            int EditedRowIndex = dgvTests.CurrentCell.RowIndex;

            clsTestType TestType = clsTestType.GetTest((clsTestType.enTestTypes)dgvTests.Rows[EditedRowIndex].Cells["TestTypeID"].Value);

            TestType.Fee = (decimal)dgvTests.Rows[EditedRowIndex].Cells["Fee"].Value; 

            if (!TestType.Save())
            {
                MessageBox.Show("Error in updating test type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dgvTests.CurrentCell.Value = CellValueBeforeEdit;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
