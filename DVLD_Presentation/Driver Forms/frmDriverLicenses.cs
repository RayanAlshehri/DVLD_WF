using CommonClasses;
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
    public partial class frmDriverLicenses : Form
    {
        private int DriverID;
        public frmDriverLicenses(int DriverID)
        {
            InitializeComponent();

            this.DriverID = DriverID;
            lblTitle.Location = new Point(clsDesign.GetControlXcenterPosition(ClientSize.Width, lblTitle.Width), clsGlobal.YpositionForTitle);
        }

        private void frmDriverLicenses_Load(object sender, EventArgs e)
        {
            ctrlDriverLicenses1.FillInfoByDriverID(DriverID);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
