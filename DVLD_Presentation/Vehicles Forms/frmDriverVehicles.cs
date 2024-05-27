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

namespace DVLD_Presentation.Vehicles_Forms
{
    public partial class frmDriverVehicles : Form
    {
        private int DriverID;
        public frmDriverVehicles(int DriverID)
        {
            InitializeComponent();

            this.DriverID = DriverID;
            lblTitle.Location = new Point(clsDesign.GetControlXcenterPosition(ClientSize.Width, lblTitle.Width), clsGlobal.YpositionForTitle);
        }

        private void frmDriverVehicles_Load(object sender, EventArgs e)
        {
            ctrlDriverVehicles1.FillInfo(DriverID);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }       
    }
}
