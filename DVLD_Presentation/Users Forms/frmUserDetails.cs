using CommonClasses;
using DVLD_Business;
using System;
using System.Windows.Forms;
using System.Drawing;

namespace DVLD_Presentation
{
    public partial class frmUserDetails : Form
    {       
        private int UserID;

        public frmUserDetails(int UserID)
        {
            InitializeComponent();

            this.UserID = UserID;
            lblTitle.Location = new Point(clsDesign.GetControlXcenterPosition(ClientSize.Width, lblTitle.Width), clsGlobal.YpositionForTitle);
        }
           
        private void frmUserDetails_Load(object sender, EventArgs e)
        {
            ctrlPersonCard1.FillPersonCard(clsUser.Find(UserID).Person.ID);
            ctrlUserCard1.FillUserCard(UserID);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
