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
    public partial class CtrlUserCard : UserControl
    {
        private int _UserID = -1;
        public CtrlUserCard()
        {
            InitializeComponent();
        }

        public void FillUserCard(int UserID)
        {
            clsUser User = clsUser.Find(UserID);

            if (User != null)
            {
                lblUserID.Text = User.ID.ToString();
                lblUsername.Text = User.Username.ToString();

                if (User.IsActive)
                    lblAccStatus.Text = "Active";
                else
                    lblAccStatus.Text = "Inactive";

                _UserID = UserID;
            }
            else
            {
                MessageBox.Show("User with ID " + UserID + " was not found", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }    
    }
}
