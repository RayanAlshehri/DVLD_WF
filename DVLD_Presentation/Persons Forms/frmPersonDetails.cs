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
    public partial class frmPersonDetails : Form
    {
        string NationalNumber;
        public frmPersonDetails(string NationalNumber)
        {
            InitializeComponent();     
            
            this.NationalNumber = NationalNumber;
            lblTitle.Location = new Point(clsDesign.GetControlXcenterPosition(ClientSize.Width, lblTitle.Width), clsGlobal.YpositionForTitle);
        }

        private void frmPersonDetails_Load(object sender, EventArgs e)
        {
            ctrlPersonCard1.FillPersonCard(NationalNumber);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
