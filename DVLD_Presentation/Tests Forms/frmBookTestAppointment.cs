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
    public partial class frmBookTestAppointment : Form
    {
        private int PersonID;
        private clsTestType.enTestTypes TestType;
        private int LocalLicenseApplicationID;
        clsTestAppoinment Appointment;
        private bool IsRetake;

        public delegate void AppoinmentBookedEventHandler(int AppointmentID);
        public AppoinmentBookedEventHandler AppointmentBooked;

        public frmBookTestAppointment(int PersonID, clsTestType.enTestTypes Test, int LocalLicenseApplicationID, bool IsRetake)
        {
            InitializeComponent();

            this.PersonID = PersonID;
            this.TestType = Test;
            this.LocalLicenseApplicationID = LocalLicenseApplicationID;
            this.IsRetake = IsRetake;        
            lblTitle.Location = new Point(clsDesign.GetControlXcenterPosition(ClientSize.Width, lblTitle.Width), clsGlobal.YpositionForTitle);
        }

        private string GetTestName()
        {
            switch (TestType)
            {
                case clsTestType.enTestTypes.Vision:
                    return "Vision exam";

                case clsTestType.enTestTypes.Theory:
                    return "Theoratical exam";

                case clsTestType.enTestTypes.Practical:
                    return "Practical exam";
            }

            return "";
        }
         
        private bool AddApointment()
        {
            int? RetakeTestApplicationID = null;

            if (IsRetake)
            {
                clsApplication Application = new clsApplication();

                Application.ApplicantPerson.ID = PersonID;
                Application.Service = clsService.enServices.RepeatCheckup;
                Application.Status = clsApplication.enApplicationStatus.New;
                Application.PaidFee = Convert.ToDecimal(lblRetakeTestServiceFee.Text);
                Application.CreatedByUserID = clsGlobal.LogedUser.ID;

                if (Application.Save())
                    RetakeTestApplicationID = Application.ApplicationID;
                else
                    return false;
            }

            Appointment = new clsTestAppoinment();

            DateTime TestDate = new DateTime(DateTimwPicker1.Value.Year, DateTimwPicker1.Value.Month, DateTimwPicker1.Value.Day,
                 DateTimwPicker1.Value.Hour, DateTimwPicker1.Value.Minute, 0);
            Appointment.PersonID = PersonID;
            Appointment.TestTypeInfo.Type = TestType;
            Appointment.LocalLicenseApplication.LocalLicenseApplicationID = LocalLicenseApplicationID;
            Appointment.PaidFee = clsTestType.GetTest(TestType).Fee;
            Appointment.TestDate = TestDate;
            Appointment.CreatedByUserID = clsGlobal.LogedUser.ID;
            Appointment.RetakeTestApplicationID = RetakeTestApplicationID;

            return Appointment.Save();                   
        }
          

        //Event:
        private void frmBookTestAppoint_Load(object sender, EventArgs e)
        {
            decimal TestFee = clsTestType.GetTest(TestType).Fee;
            decimal RetakeTestFee = 0;
            DateTime CurrentDateTime = DateTime.Now;

            ctrlPersonCard1.FillPersonCard(PersonID);
            lblTestName.Text = GetTestName();
            DateTimwPicker1.MinDate = CurrentDateTime;
            DateTimwPicker1.Value = CurrentDateTime;

            lblTestFee.Text = TestFee.ToString();      

            if (IsRetake)
            {
                RetakeTestFee = clsService.GetService(clsService.enServices.RepeatCheckup).Fee;
                lblRetakeTestServiceFee.Text = RetakeTestFee.ToString();
            }

            lblTotal.Text = (TestFee + RetakeTestFee).ToString();
        }
   
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (AddApointment())
            {
                MessageBox.Show("Appointment booked successfully", "Book Appointment"
                    , MessageBoxButtons.OK, MessageBoxIcon.Information);           

                this.Close();
                AppointmentBooked?.Invoke(Appointment.ID);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
