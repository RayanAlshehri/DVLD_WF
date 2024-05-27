 using DVLD_Business;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using CommonClasses;

namespace DVLD_Presentation
{
    public partial class frmUpdatePerson : Form
    {
        public delegate void PersonUpdatedEventHandler();
        public PersonUpdatedEventHandler PersonUpdated;

        enum enFindBy { PersonID, NaionalNumber}

        private int PersonID;
        private string NationalNumber;
        enFindBy FindBy;
        private clsPerson Person;
        private bool IsUpdated;

        public frmUpdatePerson(int PersonID)
        {
            InitializeComponent();

            this.PersonID = PersonID;
            FindBy = enFindBy.PersonID;
            IsUpdated = false;
            lblTitle.Location = new Point(clsDesign.GetControlXcenterPosition(ClientSize.Width, lblTitle.Width), clsGlobal.YpositionForTitle);
        }

        public frmUpdatePerson(string NationalNumber)
        {
            InitializeComponent();

            this.NationalNumber = NationalNumber;
            FindBy = enFindBy.NaionalNumber;
            IsUpdated = false;
            lblTitle.Location = new Point(clsDesign.GetControlXcenterPosition(ClientSize.Width, lblTitle.Width), clsGlobal.YpositionForTitle);
        }
        
        private bool UpdatePerson()
        {          
            ctrlGetPersonInfo1.FillPersonObject(Person);

            return Person.Save();
        }
        
        private void frmUpdatePerson_Load(object sender, EventArgs e)
        {
            ctrlGetPersonInfo1.mtbNationalNumber.Enabled = false;

            if (FindBy == enFindBy.PersonID)
                Person = clsPerson.Find(PersonID);
            else
                Person = clsPerson.Find(NationalNumber);

            if (Person == null)
            {
                MessageBox.Show("Person was not found", "Update Person", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            ctrlGetPersonInfo1.mtbNationalNumber.Enabled = false;
            ctrlGetPersonInfo1.FillControls(Person.ID);         
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ctrlGetPersonInfo1.ValidateChildren())
            {
                if (UpdatePerson())
                {
                    MessageBox.Show("Person updated successfully", "Update Person",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    IsUpdated = true;
                }
                else
                {
                    MessageBox.Show("Failed to update person", "Update Person",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Fill rquired information", "Update Person", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmUpdatePerson_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (IsUpdated)
                PersonUpdated?.Invoke();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
