using CommonClasses;
using DVLD_Business;
using DVLD_Presentation.Properties;
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
    public partial class frmTakeTest : Form
    {
        public delegate void TestTakenEventHandler(int TakenTestID);
        public TestTakenEventHandler TestTaken;


        private clsTakenTest TakenTest;
        private int AppointmentID;
        private clsTestType.enTestTypes TestType;
        public frmTakeTest(int AppointmentID, clsTestType.enTestTypes TestType)
        {
            InitializeComponent();

            this.AppointmentID = AppointmentID;
            this.TestType = TestType;

            SetTitleText();
            lblTitle.Location = new Point(clsDesign.GetControlXcenterPosition(ClientSize.Width, lblTitle.Width), clsGlobal.YpositionForTitle);
            SetPicture();
        }    

        private void SetTitleText()
        {
            switch (TestType)
            {
                case clsTestType.enTestTypes.Vision:
                    lblTitle.Text = "Vision Test";                   
                    break;

                case clsTestType.enTestTypes.Theory:
                    lblTitle.Text = "Theoratical Test";                  
                    break;

                case clsTestType.enTestTypes.Practical:
                    lblTitle.Text = "Practical Test";                  
                    break;
            }
        }

        private void SetPicture()
        {
            switch (TestType)
            {
                case clsTestType.enTestTypes.Vision:
                    pictureBox1.Image = Resources.eye_chart2;
                    break;

                case clsTestType.enTestTypes.Theory:
                    pictureBox1.Image = Resources.written_test;
                    break;

                case clsTestType.enTestTypes.Practical:
                    pictureBox1.Image = Resources.car;
                    break;
            }
        }

        private bool IsRequiredInfoFilled()
        {
            return rbPass.Checked || rbFail.Checked;
        }

        private bool ValidateFields()
        {
            if (!IsRequiredInfoFilled())
            {
                MessageBox.Show("Fill required Fields", "Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

           return true;
        }

        private bool AddNewTest()
        {
            TakenTest = new clsTakenTest();

            TakenTest.AppointmentID = AppointmentID;
            TakenTest.Result = rbPass.Checked;
            TakenTest.Notes = tbNotes.Text.Trim();
            TakenTest.CreatedByUserID = clsGlobal.LogedUser.ID;

            return TakenTest.Save();
        }
   

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateFields())
                return;
            
            if (AddNewTest())
            {
                MessageBox.Show("Test saved successfully", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Close();
                TestTaken?.Invoke(TakenTest.TakenTestID);             
            }
            else
            {
                MessageBox.Show("Failed to save test", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
