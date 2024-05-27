﻿using CommonClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace DVLD_Presentation
{
    public partial class frmLicenseInfo : Form
    {
        private int LicenseID;
        public frmLicenseInfo(int LicenseID)
        {
            InitializeComponent();

            this.LicenseID = LicenseID;
            lblTitle.Location = new Point(clsDesign.GetControlXcenterPosition(ClientSize.Width, lblTitle.Width),
                clsGlobal.YpositionForTitle);
        }

        private void frmLicenseInfo_Load(object sender, EventArgs e)
        {
            ctrlLicenseInfo1.FillLicenseInfoByLicenseID(LicenseID);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
