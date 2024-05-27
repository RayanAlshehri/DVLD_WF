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
    public partial class frmVehicleInfo : Form
    {
        private int RegisteredVehicleID;
        public frmVehicleInfo(int RegisteredVehicleID)
        {
            InitializeComponent();

            lblTitle.Location = new Point(clsDesign.GetControlXcenterPosition(ClientSize.Width, lblTitle.Width), clsGlobal.YpositionForTitle);
            this.RegisteredVehicleID = RegisteredVehicleID;
        }

        private void frmVehicleInfo_Load(object sender, EventArgs e)
        {
            ctrlRegisteredVehicleInfo1.FillInfo(RegisteredVehicleID);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
