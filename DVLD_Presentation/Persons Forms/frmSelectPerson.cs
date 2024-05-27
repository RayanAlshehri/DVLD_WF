using CommonClasses;
using DVLD_Business;
using System;
using System.Windows.Forms;
using System.Drawing;

namespace DVLD_Presentation
{
    public partial class frmSelectPerson : Form
    {
        public delegate void DataBackEventHandler(int PersonID);
        public DataBackEventHandler DataBack;

        private int PersonID = -1;
        public frmSelectPerson()
        {
            InitializeComponent();

            lblTitle.Location = new Point(clsDesign.GetControlXcenterPosition(ClientSize.Width, lblTitle.Width), clsGlobal.YpositionForTitle);
        }


        //Events:
        private void frmSelectPerson_Load(object sender, EventArgs e)
        {
            ctrlFindPerson1.FocusFindTextBox();
        }

        private void ctrlFindPerson1_PersonFound(object sender, CtrlFindPerson.PersonFoundEventArgs e)
        {
            PersonID = e.FoundPerson.ID;
            btnSelectPerson.Focus();
        }

        private void btnSelectPerson_Click(object sender, EventArgs e)
        {
            if (PersonID != -1)
            {
                Close();
                DataBack?.Invoke(PersonID);             
            }
            else
            {
                MessageBox.Show("Find a person to select", "Select Person", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
