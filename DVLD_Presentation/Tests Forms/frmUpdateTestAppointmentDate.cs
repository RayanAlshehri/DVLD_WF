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
    public partial class frmUpdateTestAppointmentDate : Form
    {      
        private clsTestAppoinment Appointment;

        public frmUpdateTestAppointmentDate(int AppointmentID)
        {
            InitializeComponent();

            Appointment = clsTestAppoinment.Find(AppointmentID);
            lblTitle.Location = new Point(clsDesign.GetControlXcenterPosition(ClientSize.Width, lblTitle.Width), clsGlobal.YpositionForTitle);
        }

        private void frmUpdateTestAppointmentDate_Load(object sender, EventArgs e)
        {
            DateTime CurrentDateTime = DateTime.Now;
            DateTime MinimumDate = new DateTime(CurrentDateTime.Year, CurrentDateTime.Month, CurrentDateTime.Day, CurrentDateTime.Hour,
                CurrentDateTime.Minute, 0);

            ctrlPersonCard1.FillPersonCard(Appointment.PersonID);
            dateTimePicker1.MinDate = MinimumDate;
            dateTimePicker1.Value = MinimumDate;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Appointment.ChangeTestDate(dateTimePicker1.Value))
            {
                MessageBox.Show("Test date updated successfully", "Update Appointment", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Failed to update test date", "Update Appointment", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
