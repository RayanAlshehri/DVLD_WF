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
    public partial class frmManageApplications : Form
    {
        enum enFilters { None, ApplicationID, NationalNumber, FullName, Status}

        private DataTable ApplicationsDT;
        enFilters CurrentFilter;
        public frmManageApplications()
        {
            InitializeComponent();

            lblTitle.Location = new Point(clsDesign.GetControlXcenterPosition(ClientSize.Width, lblTitle.Width), clsGlobal.YpositionForTitle);
        }

        private void LoadDataToDGV()
        {
            ApplicationsDT = clsLocalLicenseApplication.GetAllApplications();

            if (ApplicationsDT.Columns.Count > 0)
            {
                ApplicationsDT.Columns["Status"].ReadOnly = false;
            }
            else
            {
                MessageBox.Show("Error in fetching data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            dgvApplications.DataSource = ApplicationsDT;
            CustomizeDGV();
        }

        private void CustomizeDGV()
        {
            dgvApplications.Columns["ApplicationID"].HeaderText = "Application No.";
            dgvApplications.Columns["ApplicationID"].Width = 110;

            dgvApplications.Columns["ClassName"].HeaderText = "License Class";
            dgvApplications.Columns["ClassName"].Width = 120;

            dgvApplications.Columns["NationalNumber"].HeaderText = "Applicant National No.";
            dgvApplications.Columns["NationalNumber"].Width = 110;

            dgvApplications.Columns["FullName"].HeaderText = "Applicant Full Name";
            dgvApplications.Columns["FullName"].Width = 160;

            dgvApplications.Columns["ApplicationDate"].HeaderText = "Application Date";
            dgvApplications.Columns["ApplicationDate"].Width = 120;

            dgvApplications.Columns["Status"].Width = 80;
        }
    
        private string GetStatusFilter()
        {
            if (rbNew.Checked)
                return "New";

            if (rbComplete.Checked) 
                return "Complete";

            if (rbCancelled.Checked)
                return "Cancelled";

            return "";
        }

        private void ApplyFilter()
        {
            switch (CurrentFilter)
            {           
                case enFilters.ApplicationID:
                    if (tbFilter.Text != "")
                        ApplicationsDT.DefaultView.RowFilter = "[ApplicationID] = " + tbFilter.Text.Trim();
                    else
                        ApplicationsDT.DefaultView.RowFilter = "";
                    break;

                case enFilters.NationalNumber:
                    ApplicationsDT.DefaultView.RowFilter = "[NationalNumber] like'" + tbFilter.Text.Trim() + "%'";
                    break;

                case enFilters.FullName:
                    ApplicationsDT.DefaultView.RowFilter = "[FullName] like'" + tbFilter.Text.Trim() + "%'";
                    break;

                case enFilters.Status:
                    ApplicationsDT.DefaultView.RowFilter = "[Status] like'" + GetStatusFilter() + "%'";
                    break;
            }
        }

        private void AddNewlyAddedApplicationToDGV(int LocalLicenseApplicationID)
        {
            clsLocalLicenseApplication NewApplication  = 
                clsLocalLicenseApplication.FindByLocalLicenseApplicationID(LocalLicenseApplicationID);

            DataRowView NewRow = ApplicationsDT.DefaultView.AddNew();

            NewRow["ApplicationID"] = NewApplication.ApplicationID;
            NewRow["ClassName"] = clsLicenseClass.GetClass(NewApplication.LicenseClassInfo.Class).Name;
            NewRow["NationalNumber"] = NewApplication.ApplicantPerson.NationalNumber;
            NewRow["FullName"] = NewApplication.ApplicantPerson.FullName;
            NewRow["ApplicationDate"] = clsUtility.FormatDateToDMYHM(NewApplication.ApplicationDate);
            NewRow["Status"] = NewApplication.Status.ToString();
        }

        private void ChangeNewlyCompletedApplicationStatus()
        {
            dgvApplications.SelectedRows[0].Cells["Status"].Value = "Complete";
        }


        //Events:
        private void frmMangeApplications_Load(object sender, EventArgs e)
        {
            LoadDataToDGV();
            cbFilters.SelectedIndex = 0;
            lblNoOfRecords.Text = $"{dgvApplications.RowCount} Record(s)";
        }

        private void btnAddApplication_Click(object sender, EventArgs e)
        {
            frmLocalDrivingLicenseApplication frm = new frmLocalDrivingLicenseApplication();

            frm.ApplicationCreated += AddNewlyAddedApplicationToDGV;
            frm.ShowDialog();
        }

        private void cbFilters_SelectedIndexChanged(object sender, EventArgs e)
        {
            CurrentFilter = (enFilters)cbFilters.SelectedIndex;
            ApplicationsDT.DefaultView.RowFilter = "";

            if (CurrentFilter == enFilters.None)
            { 
                tbFilter.Visible = false;
                pnlStatusesFilters.Visible = false;
            }
            else if (CurrentFilter == enFilters.Status)
            {
                rbNew.Checked = false;
                rbComplete.Checked = false;
                rbCancelled.Checked = false;
                tbFilter.Visible = false;
                pnlStatusesFilters.Visible = true;
            }
            else
            {
                tbFilter.Clear();
                tbFilter.Visible = true;
                pnlStatusesFilters.Visible = false;
            }                   
        }

        private void tbFilter_TextChanged(object sender, EventArgs e)
        {
            ApplyFilter();
            lblNoOfRecords.Text = $"{dgvApplications.RowCount} Record(s)";
        }

        private void tbFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (CurrentFilter == enFilters.ApplicationID)
            {
                if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
                {
                    e.Handled = true;
                }
            }
        }

        private void rbNew_CheckedChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void rbComplete_CheckedChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void rbCancelled_CheckedChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void dgvApplications_KeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = (e.KeyCode == Keys.Escape);
            Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }


        //Menu events:
        private void cmsApplication_Opening(object sender, CancelEventArgs e)
        {
            string SelectedApplicationStatus = dgvApplications.SelectedRows[0].Cells["Status"].Value.ToString();

            if (SelectedApplicationStatus == "Cancelled")
            {
                miOpenApplication.Enabled = false;
                miCancel.Enabled = false;
            }
            else if (SelectedApplicationStatus == "Complete")
            {
                miOpenApplication.Enabled = true;
                miCancel.Enabled = false;
            }
            else
            {
                miOpenApplication.Enabled = true;
                miCancel.Enabled = true;
            }
        }
    
        private void miEdit_Click(object sender, EventArgs e)
        {
            int ApplicationID = Convert.ToInt32(dgvApplications.SelectedRows[0].Cells["ApplicationID"].Value);

            frmLocalDrivingLicenseApplication frm = new frmLocalDrivingLicenseApplication(ApplicationID);

            frm.ApplicationCompleted += ChangeNewlyCompletedApplicationStatus;
            frm.ShowDialog();
        }

        private void miCancel_Click(object sender, EventArgs e)
        {         
            if (MessageBox.Show("Are you sure you want to cancel the application?", "Confirmation",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                return;
            }

            int ApplicationID = Convert.ToInt32(dgvApplications.SelectedRows[0].Cells["ApplicationID"].Value);
            clsLocalLicenseApplication LocalLicenseApplication = clsLocalLicenseApplication.FindByApplicationID(ApplicationID);



            if (LocalLicenseApplication.Cancel())
            {
                MessageBox.Show("Application cancelled successfully", "Cancel Application",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                dgvApplications.SelectedRows[0].Cells["Status"].Value = "Cancelled";
            }
            else
            {
                MessageBox.Show("Failed to cancel Application", "Cancel Application",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void miApplicantLicenses_Click(object sender, EventArgs e)
        {
            string NationalNo = dgvApplications.SelectedRows[0].Cells["NationalNumber"].Value.ToString();
            clsDriver Driver = clsDriver.FindByPersonID(clsPerson.Find(NationalNo).ID);

            if (Driver != null)
            {
                Form frm = new frmDriverLicenses(Driver.ID);
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("This applicant does not have any license", "View Licenses",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }     
    }
}
