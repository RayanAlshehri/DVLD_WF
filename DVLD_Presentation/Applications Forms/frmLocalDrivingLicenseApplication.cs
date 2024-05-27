using DVLD_Business;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using CommonClasses;
using System.Runtime.InteropServices;

namespace DVLD_Presentation
{
    public partial class frmLocalDrivingLicenseApplication : Form
    {
        public delegate void ApplicationCreatedEventHandler(int ApplicationID);
        public ApplicationCreatedEventHandler ApplicationCreated;

        public delegate void ApplicationCompletedEventHandler();
        public ApplicationCompletedEventHandler ApplicationCompleted;
        enum enFormMode { Create, Update, Complete}   
        private struct stTestsAppointments
        {
            public clsTestAppoinment Vision;
            public clsTestAppoinment Theory;
            public clsTestAppoinment Practical;
        }
        private struct stTakenTests
        {
            public clsTakenTest Vision;
            public clsTakenTheoryTest Theory;
            public clsTakenTest Practical;
        }

        private int ApplicationID;
        private clsLocalLicenseApplication LocalLicenseApplication;
        private enFormMode frmMode;
        private clsLicenseClass.enLicenseClasses SelectedClass;
        private stTestsAppointments TestsAppointments;
        private stTakenTests TakenTests;
      
        public frmLocalDrivingLicenseApplication()
        {
            InitializeComponent();

            frmMode = enFormMode.Create;
            lblTitle.Location = new Point(clsDesign.GetControlXcenterPosition(tabControl1.ClientSize.Width, lblTitle.Width), 
                clsGlobal.YpositionForTitle);
        }

        public frmLocalDrivingLicenseApplication(int ApplicationID)
        {
            InitializeComponent();
          
            this.ApplicationID = ApplicationID;
            frmMode = enFormMode.Update;
            DoPreviouslyCreatedApplicationChanges();           
        }


        private void SetFormMode()
        {
            if (LocalLicenseApplication.Status == clsApplication.enApplicationStatus.Complete)
                frmMode = enFormMode.Complete;
            else
                frmMode = enFormMode.Update;
        }  

        private void PopulateClassesCB()
        {          
            cbLicenseClass.DataSource = clsLicenseClass.GetAllClasses();
            cbLicenseClass.DisplayMember = "ClassName";           
            cbLicenseClass.SelectedIndex = -1;
        }

        private void FillSelectedPersonInfo(int PersonID)
        {
            ctrlPersonCard1.FillPersonCard(PersonID); 
        }
      
        private bool CreateNewApplication()
        {                                                 
            LocalLicenseApplication = new clsLocalLicenseApplication();
            LocalLicenseApplication.ApplicantPerson.ID = ctrlPersonCard1.Person.ID;
            LocalLicenseApplication.Service = clsService.enServices.IssueLicenseFirstTime;
            LocalLicenseApplication.Status = clsApplication.enApplicationStatus.New;
            LocalLicenseApplication.PaidFee = Convert.ToDecimal(lblApplicationFee.Text);
            LocalLicenseApplication.CreatedByUserID = clsGlobal.LogedUser.ID;
            LocalLicenseApplication.LicenseClassInfo.Class = SelectedClass;

            return LocalLicenseApplication.Save();         
        }

        //Update mode methods:
        private void DoPreviouslyCreatedApplicationChanges()
        {
            tpCreateApplic.Text = "Person Information";
            lblTitle.Text = "Update Application";
            lblTitle.Location = new Point(clsDesign.GetControlXcenterPosition(tabControl1.ClientSize.Width, lblTitle.Width), 
                clsGlobal.YpositionForTitle);

            btnSelectPerson.Visible = false;
            btnSaveApplication.Visible = false;
            btnClose.Location = new Point (btnSaveApplication.Location.X, btnSaveApplication.Location.Y); 
            cbLicenseClass.Enabled = false;
            tpTests.Enabled = true;                     
        }

        private void FillApplicationSummary()
        {
            lblApplicationID.Text = LocalLicenseApplication.ApplicationID.ToString();
            lblService.Text = "Issue Local License (First Time)";
            lblApplicantNationalNumber.Text = LocalLicenseApplication.ApplicantPerson.NationalNumber;
            lblApplicantFullName.Text = LocalLicenseApplication.ApplicantPerson.FullName;
            lblLicenseClass.Text = LocalLicenseApplication.LicenseClassInfo.Name;
            lblPaidApplicationFee.Text = LocalLicenseApplication.PaidFee.ToString();
            lblApplicationDate.Text = clsUtility.FormatDateToDMYHM(LocalLicenseApplication.ApplicationDate);
            lblCreatedByUser.Text = clsUser.Find(LocalLicenseApplication.CreatedByUserID).Username;
        }
   
        private void ShowSummaryTP()
        {
            tpSummary.Enabled = true;
            FillApplicationSummary();

            if (frmMode == enFormMode.Complete)
            {
                llViewLicenseInformation.Enabled = true;
                btnIssuLicense.Enabled = false;
                gbConstraints.Enabled = false;
            
                lblLicenseFee.Text = clsLicense.FindByApplicationID(LocalLicenseApplication.ApplicationID).PaidFee.ToString();
            }   
            else
            {
                lblLicenseFee.Text = clsLicenseClass.GetClass(LocalLicenseApplication.LicenseClassInfo.Class).Fee.ToString();
            }
        }

        private int GetConstraintsNumber()
        {
            int Constraints = 0;

            if (cbAutoCars.Checked)
                Constraints += 1;

            if (cbProsLimb.Checked)
                Constraints += 2;

            if (cbVisionLenses.Checked)
                Constraints += 4;

            if (cbDayHours.Checked)
                Constraints += 8;

            if (cbHandicapedCars.Checked)
                Constraints += 16;

            return Constraints;
        }

        private bool IssueLicense()
        {
            return LocalLicenseApplication.IssueLicesne(GetConstraintsNumber(), clsGlobal.LogedUser.ID) != -1;
        }    


        //Tests methods:        

        private void LoadTests()
        {
            TestsAppointments.Vision = clsTestAppoinment.FindLastAppointment(LocalLicenseApplication.LocalLicenseApplicationID,
                clsTestType.enTestTypes.Vision);
            LoadVisionTestAppointmentInfo();

            TestsAppointments.Theory = clsTestAppoinment.FindLastAppointment(LocalLicenseApplication.LocalLicenseApplicationID,
                clsTestType.enTestTypes.Theory);
            LoadTheoryTestAppointmentInfo();

            TestsAppointments.Practical = clsTestAppoinment.FindLastAppointment(LocalLicenseApplication.LocalLicenseApplicationID,
                clsTestType.enTestTypes.Practical);
            LoadPracticalTestAppointmentInfo();
        }

        private void OpenBookTestForm(clsTestType.enTestTypes TestType, bool IsRetake)
        {
            frmBookTestAppointment frm = new frmBookTestAppointment(LocalLicenseApplication.ApplicantPerson.ID, TestType,
                LocalLicenseApplication.LocalLicenseApplicationID, IsRetake);

            frm.AppointmentBooked += LoadBookedTestDate;
            frm.ShowDialog();
        }

        private void LoadBookedTestDate(int AppointmentID)
        {
            clsTestAppoinment Appointment = clsTestAppoinment.Find(AppointmentID);

            switch (Appointment.TestTypeInfo.Type)
            {
                case clsTestType.enTestTypes.Vision:
                    TestsAppointments.Vision = Appointment;
                    LoadVisionTestAppointmentInfo();
                    break;

                case clsTestType.enTestTypes.Theory:
                    TestsAppointments.Theory = Appointment;
                    LoadTheoryTestAppointmentInfo();
                    break;

                default:
                    TestsAppointments.Practical = Appointment;
                    LoadPracticalTestAppointmentInfo();
                    break;
            }
        }

        private void LoadVisionTestAppointmentInfo()
        {
            btnChangeVisionDate.Visible = false;

            if (TestsAppointments.Vision == null)
            {
                lblVisionExStatus.Text = "No tests booked or taken";
                return;
            }

            if (!TestsAppointments.Vision.IsTaken)
            {
                lblVisionExStatus.Text = "Pending. At " + clsUtility.FormatDateToDMYHM(TestsAppointments.Vision.TestDate);
                btnBookVision.Enabled = false;
                btnTakeVision.Enabled = true;
                btnChangeVisionDate.Visible = true;
                return;
            }

            TakenTests.Vision = clsTakenTest.FindByAppointmentID(TestsAppointments.Vision.ID);
            LoadTakenVisionTestResult();
        }

        private void LoadTheoryTestAppointmentInfo()
        {
            btnChangeTheoryDate.Visible = false;
            lblGrade.Text = "";

            if (TestsAppointments.Theory == null)
            {
                lblTheoExStatus.Text = "No tests booked or taken";
                return;
            }

            if (!TestsAppointments.Theory.IsTaken)
            {              
                lblTheoExStatus.Text = "Pending. At " + clsUtility.FormatDateToDMYHM(TestsAppointments.Theory.TestDate);
                btnBookTheory.Enabled = false;
                btnChangeTheoryDate.Visible = true;
                return;
            }

            TakenTests.Theory = clsTakenTheoryTest.FindByTakenTestID(
                clsTakenTest.FindByAppointmentID(TestsAppointments.Theory.ID).TakenTestID);

            LoadTakenTheoryTestResult();
        }

        private void LoadPracticalTestAppointmentInfo()
        {
            btnChangePracticalDate.Visible = false;

            if (TestsAppointments.Practical == null)
            {
                lblPractExStatus.Text = "No tests booked or taken";
                return;
            }

            if (!TestsAppointments.Practical.IsTaken)
            {
                lblPractExStatus.Text = "Pending. At " + clsUtility.FormatDateToDMYHM(TestsAppointments.Practical.TestDate);
                btnBookPractical.Enabled = false;
                btnTakePractical.Enabled = true;
                btnChangePracticalDate.Visible = true;
                return;
            }


            TakenTests.Practical = clsTakenTest.FindByAppointmentID(TestsAppointments.Practical.ID);
            LoadTakenPractTestResult();
        }

        private void OpenUpdateAppointmentForm(int AppointmentID)
        {
            frmUpdateTestAppointmentDate frm = new frmUpdateTestAppointmentDate(AppointmentID);
            frm.ShowDialog();
        }

        private void OpenTakeTestForm(int AppointmentID, clsTestType.enTestTypes TestType)
        {
            frmTakeTest frm = new frmTakeTest(AppointmentID, TestType);

            frm.TestTaken += LoadNewlyTakenTestInfo;
            frm.ShowDialog();
        }

        private void LoadTakenVisionTestResult()
        {
            btnChangeVisionDate.Visible = false;

            if (TakenTests.Vision != null)
            {
                btnTakeVision.Enabled = false;
                string TestDate = clsUtility.FormatDateToDMYHM(TestsAppointments.Vision.TestDate);
                if (TakenTests.Vision.Result == true)
                {
                    lblVisionExStatus.Text = "Passed. taken at " + TestDate;
                    btnBookVision.Enabled = false;
                    gbWrittenTest.Enabled = true;
                }
                else
                {
                    lblVisionExStatus.Text = "Failed. taken at " + TestDate;
                    btnBookVision.Enabled = true;
                }

                lblVisionNotes.Text = TakenTests.Vision.Notes;
            }
        }

        private void LoadTakenTheoryTestResult()
        {
            btnChangeTheoryDate.Visible = false;

            if (TakenTests.Theory != null)
            {               
                string TestDate = clsUtility.FormatDateToDMYHM(TestsAppointments.Theory.TestDate);
                if (TakenTests.Theory.Result == true)
                {
                    lblTheoExStatus.Text = "Passed. taken at " + TestDate;
                    btnBookTheory.Enabled = false;
                    gbStreetTest.Enabled = true;
                }
                else
                {
                    lblTheoExStatus.Text = "Failed. taken at " + TestDate;
                    btnBookTheory.Enabled = true;
                }

                lblTheoNotes.Text = TakenTests.Theory.Notes;
                lblGrade.Text = TakenTests.Theory.Grade.ToString();
            }
        }

        private void LoadTakenPractTestResult()
        {
            btnChangePracticalDate.Visible = false;

            if (TakenTests.Practical != null)
            {
                btnTakePractical.Enabled = false;

                string TestDate = clsUtility.FormatDateToDMYHM(TestsAppointments.Practical.TestDate);
                if (TakenTests.Practical.Result == true)
                {
                    lblPractExStatus.Text = "Passed. taken at " + TestDate;
                    btnBookPractical.Enabled = false;
                    gbWrittenTest.Enabled = true;
                    ShowSummaryTP();
                    tpSummary.Focus();
                }
                else
                {
                    lblPractExStatus.Text = "Failed. taken at " + TestDate;
                    btnBookPractical.Enabled = true;
                }

                lblPractNotes.Text = TakenTests.Practical.Notes;
            }
        }

        private void LoadNewlyTakenTestInfo(int TakenTestID)
        {
            clsTakenTest TakenTest = clsTakenTest.Find(TakenTestID);

            if (clsTestAppoinment.Find(TakenTest.AppointmentID).TestTypeInfo.Type == clsTestType.enTestTypes.Vision)
            {
                TakenTests.Vision = TakenTest;
                LoadTakenVisionTestResult();
            }
            else
            {
                TakenTests.Practical = TakenTest;
                LoadTakenPractTestResult();
            }
        }
     
                   
        //Events:
        private void frmNewDrivingApplc_Load(object sender, EventArgs e)
        {
            lblApplicationFee.Text = clsService.GetService(clsService.enServices.IssueLicenseFirstTime).Fee.ToString();
            PopulateClassesCB();
            cbLicenseClass.SelectedIndex = (int)clsLicenseClass.enLicenseClasses.Normal - 1;
            tpSummary.Enabled = false;

            if (frmMode == enFormMode.Create)
            {
                tpTests.Enabled = false;             
                return;
            }

            LocalLicenseApplication = clsLocalLicenseApplication.FindByApplicationID(ApplicationID);

            SetFormMode();
            ctrlPersonCard1.FillPersonCard(LocalLicenseApplication.ApplicantPerson.ID);
            cbLicenseClass.SelectedIndex = (int)LocalLicenseApplication.LicenseClassInfo.Class - 1;
            LoadTests();
        }

        private void btnSelectPerson_Click(object sender, EventArgs e)
        {
            frmSelectPerson frm = new frmSelectPerson();

            frm.DataBack += FillSelectedPersonInfo;
            frm.ShowDialog();
        }

        private void cbLicenseClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedClass = (clsLicenseClass.enLicenseClasses)cbLicenseClass.SelectedIndex + 1;
        }

        private void btnSaveApplication_Click(object sender, EventArgs e)
        {  
            if (ctrlPersonCard1.Person == null)
            {
                MessageBox.Show("Select a person first", "New Application",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            if (cbLicenseClass.SelectedIndex == -1)
            {
                MessageBox.Show("Chose licesnse class", "New Application",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            clsLicenseClass LicenseClass = clsLicenseClass.GetClass(SelectedClass);
            if (!LicenseClass.IsAgeValid(ctrlPersonCard1.Person.Age))
            {
                MessageBox.Show("Selected person age is less than the minimum age for this license class",
                    "New Application", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            if (clsLocalLicenseApplication.DoesPersonHaveNewApplicationForLicenseClass(ctrlPersonCard1.Person.ID, SelectedClass))
            {
                MessageBox.Show("This person already has a new application for the selected license class", "New Application"
                  , MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            if (ctrlPersonCard1.Person.HasLicenseForClass(SelectedClass))
            {
                MessageBox.Show("Selected person already has a license from this class", "New Application",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (CreateNewApplication())
            {
                MessageBox.Show("Application created successfully", "New Application"
                    , MessageBoxButtons.OK, MessageBoxIcon.Information);

                DoPreviouslyCreatedApplicationChanges();
                tabControl1.SelectedTab = tpTests;

                ApplicationCreated?.Invoke(LocalLicenseApplication.LocalLicenseApplicationID);
            }
            else
            {
                MessageBox.Show("Failed to create application", "New Application",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnIssuLicense_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to issue this license?", "Issue, License",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                if (IssueLicense())
                {
                    MessageBox.Show("License issued", "Issue License", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmMode = enFormMode.Complete;
                    ShowSummaryTP();
                    ApplicationCompleted?.Invoke();
                }
                else
                {
                    MessageBox.Show("Failed to issue license", "Issue License", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        //Tests events:
        private void btnBookVisionTest_Click(object sender, EventArgs e)
        {
            OpenBookTestForm(clsTestType.enTestTypes.Vision, (TakenTests.Vision != null));          
        }

        private void btnBookTeoryTest_Click(object sender, EventArgs e)
        {
            OpenBookTestForm(clsTestType.enTestTypes.Theory, (TakenTests.Theory != null));
        }

        private void btnBookPracticalTest_Click(object sender, EventArgs e)
        {
            OpenBookTestForm(clsTestType.enTestTypes.Practical, TakenTests.Practical != null);         
        }

        private void btnTakeVision_Click(object sender, EventArgs e)
        {
            OpenTakeTestForm(TestsAppointments.Vision.ID, clsTestType.enTestTypes.Vision);
        }  

        private void btnTakePractical_Click(object sender, EventArgs e)
        {
            OpenTakeTestForm(TestsAppointments.Practical.ID, clsTestType.enTestTypes.Practical);
        }

        private void btnChangeVisionAppointmentDate_Click(object sender, EventArgs e)
        {
            OpenUpdateAppointmentForm(TestsAppointments.Vision.ID);
            TestsAppointments.Vision = clsTestAppoinment.Find(TestsAppointments.Vision.ID);
            LoadVisionTestAppointmentInfo();
        }

        private void btnChangeTheoryDate_Click(object sender, EventArgs e)
        {
            OpenUpdateAppointmentForm(TestsAppointments.Theory.ID);
            TestsAppointments.Theory = clsTestAppoinment.Find(TestsAppointments.Theory.ID);
            LoadTheoryTestAppointmentInfo();
        }

        private void btnChangePracticalDate_Click(object sender, EventArgs e)
        {
            OpenUpdateAppointmentForm(TestsAppointments.Practical.ID);
            TestsAppointments.Practical = clsTestAppoinment.Find(TestsAppointments.Practical.ID);
            LoadPracticalTestAppointmentInfo();
        }

        private void llViewLicensesClasses_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmManageLicensesClasses frm = new frmManageLicensesClasses();  
            frm.ShowDialog();
        }

        private void llViewLicenseInformation_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLicenseInfo frm = new frmLicenseInfo(
                clsLicense.FindByApplicationID(LocalLicenseApplication.ApplicationID).ID);

            frm.ShowDialog();
        }
    }
}
