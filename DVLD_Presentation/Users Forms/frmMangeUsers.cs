using CommonClasses;
using DVLD_Business;
using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using System.Drawing;

namespace DVLD_Presentation
{
    public partial class frmMangeUsers : Form
    {
        private DataTable UsersDT;
        private enum enFilters
        {
            None = 0, UserID = 1, FullName = 2, Username = 3, AccStatus = 4
        }

        enFilters CurrentFilter;

        public frmMangeUsers()
        {
            InitializeComponent();

            lblTitle.Location = new Point(clsDesign.GetControlXcenterPosition(ClientSize.Width, lblTitle.Width), clsGlobal.YpositionForTitle);
        }

        private void EnableDTediting()
        {
            UsersDT.Columns["UserID"].ReadOnly = false;
            UsersDT.Columns["FullName"].ReadOnly = false;
            UsersDT.Columns["Username"].ReadOnly = false;
            UsersDT.Columns["AccountStatus"].ReadOnly = false;
        }

        private void ChangeDGVcolumnsNamesAndWidth()
        {
            dgvUsers.Columns["UserID"].HeaderText = "User ID";
            dgvUsers.Columns["FullName"].HeaderText = "Full Name";
            dgvUsers.Columns["AccountStatus"].HeaderText = "Account Status";
        }

        private void LoadDataToDGV()
        {
            UsersDT = clsUser.GetAllUsers();

            if (UsersDT.Columns.Count > 0 )
            {
                EnableDTediting();
            }
            else
            {
                MessageBox.Show("Error in fetching data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            dgvUsers.DataSource = UsersDT;
            ChangeDGVcolumnsNamesAndWidth();            
        } 

        private void ApplyFilter()
        {
            switch (CurrentFilter)
            {       
                case enFilters.UserID:
                    if (tbFilter.Text != "")
                        UsersDT.DefaultView.RowFilter = "[UserID] = '" + tbFilter.Text.Trim().ToString() + "'";
                    else
                        UsersDT.DefaultView.RowFilter = "";

                    break;

                case enFilters.FullName:
                    UsersDT.DefaultView.RowFilter = "[FullName] like '" + tbFilter.Text.Trim().ToString() + "%'";
                    break;

                case enFilters.Username:
                    UsersDT.DefaultView.RowFilter = "[Username] like '" + tbFilter.Text.Trim().ToString() + "%'";
                    break;

                case enFilters.AccStatus:
                    if (cbAccStatusFilter.Checked)
                        UsersDT.DefaultView.RowFilter = "[AccountStatus] like 'Active'";
                    else
                        UsersDT.DefaultView.RowFilter = "[AccountStatus] like 'Inactive'";
                    break;
            }
        }

        private void AddNewUserToDGV(int UserID)
        {
            clsUser User = clsUser.Find(UserID);
            DataRowView NewRow = UsersDT.DefaultView.AddNew();

            NewRow["UserID"] = User.ID;
            NewRow["FullName"] = User.Person.FullName;
            NewRow["Username"] = User.Username;

            if (User.IsActive)
                NewRow["AccountStatus"] = "Active";
            else
                NewRow["AccountStatus"] = "Inactive";

            NewRow.EndEdit();

            lblNoOfRecords.Text = $"{dgvUsers.RowCount} Record(s)";
        }

        private void ApplyChangesToUserInfo()
        {
            clsUser User = clsUser.Find((int)dgvUsers.CurrentRow.Cells["UserID"].Value);
           
            dgvUsers.CurrentRow.Cells["FullName"].Value = User.Person.FullName;
            dgvUsers.CurrentRow.Cells["Username"].Value = User.Username;

            if (User.IsActive)
                dgvUsers.SelectedRows[0].Cells["AccountStatus"].Value = "Active";
            else
                dgvUsers.SelectedRows[0].Cells["AccountStatus"].Value = "Inactive";
        }

        private void ShowAccessDeniedMessage(string AccessDeniedOn)
        {
            MessageBox.Show($"Access denied. You do not have access to {AccessDeniedOn}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        //Events:
        private void frmMangeUsers_Load(object sender, EventArgs e)
        {           
            LoadDataToDGV();
            lblNoOfRecords.Text = dgvUsers.Rows.Count.ToString() + " Record(s)";
            cbFilters.SelectedIndex = (int)enFilters.None;
        }
      
        private void cbFilters_SelectedIndexChanged(object sender, EventArgs e)
        {
            CurrentFilter = (enFilters)cbFilters.SelectedIndex;
            UsersDT.DefaultView.RowFilter = "";
            lblNoOfRecords.Text = dgvUsers.Rows.Count.ToString() + " Record(s)";

            if (CurrentFilter == enFilters.None)
            {             
                tbFilter.Visible = false;
                cbAccStatusFilter.Visible = false;
            }
            else if (CurrentFilter == enFilters.AccStatus)
            {
                tbFilter.Visible = false;
                cbAccStatusFilter.Visible = true;
                cbAccStatusFilter.Checked = true;
            }
            else
            {
                cbAccStatusFilter.Visible = false;
                tbFilter.Clear();
                tbFilter.Visible = true;                                
            }
        }

        private void cbAccStatusFilter_CheckedChanged(object sender, EventArgs e)
        {
            ApplyFilter();
            lblNoOfRecords.Text = $"{dgvUsers.RowCount} Record(s)";
        }

        private void tbFilter_TextChanged(object sender, EventArgs e)
        {
            ApplyFilter();
            lblNoOfRecords.Text = $"{dgvUsers.RowCount} Record(s)";
        }

        private void tbFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (CurrentFilter == enFilters.UserID)
            {
                if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
                    e.Handled = true;
            }
            else
            {
                if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != '\b')
                    e.Handled = true;
            }
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            frmAddNewUser frm = new frmAddNewUser();
            frm.UserAdded += AddNewUserToDGV;
            frm.ShowDialog();
        }

        private void dgvUsers_KeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = (e.KeyCode == Keys.Escape);
            Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
       

        //Context menu events:     
        private void miUserDetails_Click(object sender, EventArgs e)
        {
            Form frm = new frmUserDetails((int)dgvUsers.CurrentRow.Cells["UserID"].Value);
            frm.ShowDialog();
        }

        private void miEdit_Click(object sender, EventArgs e)
        {
            if (!clsGlobal.LogedUser.HasPermission(clsUser.enPermissionsOnUsers.Update))
            {
                ShowAccessDeniedMessage("update user");
                return;
            }

            frmUpdateUser frm = new frmUpdateUser((int)dgvUsers.CurrentRow.Cells["UserID"].Value);
            frm.UserUpdated += ApplyChangesToUserInfo;
            frm.ShowDialog();
        }

        private void miChangePassword_Click(object sender, EventArgs e)
        {
            if (!clsGlobal.LogedUser.HasPermission(clsUser.enPermissionsOnUsers.Update))
            {
                ShowAccessDeniedMessage("update user");
                return;
            }

            Form frm = new frmChangePassword((int)dgvUsers.CurrentRow.Cells["UserID"].Value);
            frm.ShowDialog();
        }
     
        private void miDelete_Click(object sender, EventArgs e)
        {
            if (!clsGlobal.LogedUser.HasPermission(clsUser.enPermissionsOnUsers.Delete))
            {
                ShowAccessDeniedMessage("delete user");
                return;
            }

            if (MessageBox.Show("Are you sure you want to delete this user?", "Confirmation",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                return;
            }

            if (clsUser.DeleteUser((int)dgvUsers.CurrentRow.Cells["UserID"].Value))
            {
                MessageBox.Show("User deleted successfully", "Delete User",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                dgvUsers.Rows.RemoveAt(dgvUsers.SelectedRows[0].Index);
                lblNoOfRecords.Text = $"{dgvUsers.RowCount} Record(s)";

            }
            else
            {
                MessageBox.Show("Failed to delete user beacause there is data linked to it", "Delete User",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }     
    }
}
