using DVLD_Business;
using DVLD_Presentation.Properties;
using CommonClasses;
using System.Windows.Forms;

namespace DVLD_Presentation
{
    public partial class CtrlPersonCard : UserControl
    {
        public delegate void PersonUpdatedEventHandler();
        public PersonUpdatedEventHandler PersonUpdated;

        private clsPerson _Person;
        public clsPerson Person 
        { 
            get 
            { 
                if (_Person != null)
                    return _Person;

                return null;
            } 
        } 
        public CtrlPersonCard()
        {
            InitializeComponent();

            _Person = null;
        }

        private void _LoadInfoToControls()
        {         
            lblNationalNumber.Text = _Person.NationalNumber;
            lblName.Text = _Person.FullName;
            lblDateOfBirth.Text = clsUtility.FormatDateToDMY(_Person.DateOfBirth);
            lblNationality.Text = _Person.Country.Name;
            lblPhone.Text = _Person.Phone;
            lblEmail.Text = _Person.Email;
            lblAddress.Text = _Person.Address;

            if (_Person.Gender == 'M')
                lblGender.Text = "Male";
            else
                lblGender.Text = "Female";

            if (_Person.ImagePath != null)
            {
                pictureBox1.ImageLocation = _Person.ImagePath;
            }
            else
            {
                if (_Person.Gender == 'M')
                    pictureBox1.Image = Resources.Person_Male;
                else
                    pictureBox1.Image = Resources.Person_Female;
            }

            llEditInfo.Enabled = true;
        }

        private void _ApplyChangesToPersonInfo()
        {
            _Person = clsPerson.Find(_Person.ID);
            _LoadInfoToControls();
            PersonUpdated?.Invoke();
        }
     
        public void FillPersonCard(string NationalNumber)
        {
            _Person = clsPerson.Find(NationalNumber);

            if (_Person == null)
            {
                MessageBox.Show("Person with National Number " + NationalNumber + " was not found", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            _LoadInfoToControls();
        }

        public void FillPersonCard(int PersonID)
        {
            _Person = clsPerson.Find(PersonID);

            if (_Person == null)
            {
                MessageBox.Show("Person with ID " + PersonID + " was not found", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            _LoadInfoToControls();
        }

        private void llEditInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmUpdatePerson frm = new frmUpdatePerson(_Person.ID);

            frm.PersonUpdated += _ApplyChangesToPersonInfo;
            frm.ShowDialog();
        }
    }
}
