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
    public partial class CtrlPermissionsOnUsers : UserControl
    {
        public CtrlPermissionsOnUsers()
        {
            InitializeComponent();
        }

        private bool _AreAllPermissionsChecked()
        {
            return cbViewList.Checked && cbAdd.Checked && cbUpdate.Checked && cbDelete.Checked;
        }

        public int GetPermissionsNumber()
        {
            if (cbFullPermissions.Checked)
                return (int)clsUser.enPermissionsOnUsers.FullPermissions;

            int Permissions = 0;

            if (cbViewList.Checked)
                Permissions += (int)clsUser.enPermissionsOnUsers.ViewList;

            if (cbAdd.Checked)
                Permissions += (int)clsUser.enPermissionsOnUsers.Add;

            if (cbUpdate.Checked)
                Permissions += (int)clsUser.enPermissionsOnUsers.Update;

            if (cbDelete.Checked)
                Permissions += (int)clsUser.enPermissionsOnUsers.Delete;

            return Permissions;
        }

        public void LoadPermissions(int Permissions)
        {
            if (Permissions == 0)
                return;

            if (clsUser.HasPermission(Permissions, clsUser.enPermissionsOnUsers.FullPermissions))
            {
                cbFullPermissions.Checked = true;
                return;
            }   
            
            if (clsUser.HasPermission(Permissions, clsUser.enPermissionsOnUsers.ViewList))
                cbViewList.Checked= true;

            if (clsUser.HasPermission(Permissions, clsUser.enPermissionsOnUsers.Add))
                cbAdd.Checked = true;

            if (clsUser.HasPermission(Permissions, clsUser.enPermissionsOnUsers.Update)) 
                cbUpdate.Checked = true;

            if (clsUser.HasPermission(Permissions, clsUser.enPermissionsOnUsers.Delete)) 
                cbDelete.Checked = true;
        }


        private void CtrlPermissionsOnUsers_Load(object sender, EventArgs e)
        {
            errorProvider1.SetError(cbViewList, "Add, update, and delete user is accessed through users list");
        }

        private void cbFullPermissions_CheckedChanged(object sender, EventArgs e)
        {
            if (cbFullPermissions.Checked)
            {
                cbViewList.Checked = false;
                cbAdd.Checked = false;
                cbUpdate.Checked = false;
                cbDelete.Checked = false;

                cbViewList.Enabled = false;
                cbAdd.Enabled = false;
                cbUpdate.Enabled = false;
                cbDelete.Enabled = false;
            }
            else
            {
                cbViewList.Enabled = true;               
            }
        }

        private void cbViewList_CheckedChanged(object sender, EventArgs e)
        {
            if (cbViewList.Checked)
            {
                cbAdd.Enabled = true;
                cbUpdate.Enabled = true;
                cbDelete.Enabled = true;
            }
            else
            {
                cbAdd.Checked = false;
                cbUpdate.Checked = false;
                cbDelete.Checked = false;

                cbAdd.Enabled = false;
                cbUpdate.Enabled = false;
                cbDelete.Enabled = false;
            }
        }

        private void cbAdd_CheckedChanged(object sender, EventArgs e)
        {
            if (_AreAllPermissionsChecked())
                cbFullPermissions.Checked = true;
        }

        private void cbUpdate_CheckedChanged(object sender, EventArgs e)
        {
            if (_AreAllPermissionsChecked())
                cbFullPermissions.Checked = true;
        }

        private void cbDelete_CheckedChanged(object sender, EventArgs e)
        {
            if (_AreAllPermissionsChecked())
                cbFullPermissions.Checked = true;
        }
      
    }
}
