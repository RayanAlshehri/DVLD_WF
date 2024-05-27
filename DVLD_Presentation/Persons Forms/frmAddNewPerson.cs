using CommonClasses;
using DVLD_Business;
using System;
using System.Windows.Forms;
using System.Drawing;

namespace DVLD_Presentation
{
    public partial class frmAddNewPerson : Form
    {
        public delegate void PersonAddedEventHandler(int PersonID);
        public PersonAddedEventHandler PersonAdded;

        private clsPerson Person;
        public frmAddNewPerson()
        {
            InitializeComponent();

            lblTitle.Location = new Point(clsDesign.GetControlXcenterPosition(ClientSize.Width, lblTitle.Width), clsGlobal.YpositionForTitle);
        }
   
        private bool AddPerson()
        {
            Person = new clsPerson();

            CtrlGetPersonInfo1.FillPersonObject(Person);

            return Person.Save();
        }


        private void frmAddNewPerson_Load(object sender, EventArgs e)
        {           
            CtrlGetPersonInfo1.rbMale.Checked = true;
            CtrlGetPersonInfo1.cbCountries.SelectedIndex = 193;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!CtrlGetPersonInfo1.ValidateChildren())
            {
                MessageBox.Show("Invalid or missing information detected.", "Add Person", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }


            if (clsPerson.DoesPersonExist(CtrlGetPersonInfo1.mtbNationalNumber.Text.ToString().Trim()))
            {
                MessageBox.Show("National number is for another person", "Add Person", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            if (AddPerson())
            {
                MessageBox.Show("Person added successfully", "Add Person"
                    , MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
                PersonAdded?.Invoke(Person.ID);
            }
            else
            {
                MessageBox.Show("Failed to add person", "Add Person",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
