using DVLD_Business;
using System;
using System.ComponentModel;
using CommonClasses;
using System.Windows.Forms;
using System.IO;
using DVLD_Presentation.Properties;

namespace DVLD_Presentation
{
    public partial class CtrlGetPersonInfo : UserControl
    {

        public CtrlGetPersonInfo()
        {
            InitializeComponent();
        }   
     
        private void _PopulateCBcountries()
        {
            cbCountries.DataSource = clsCountry.GetAllCountries();
            cbCountries.DisplayMember = "CountryName";
            cbCountries.SelectedIndex = -1;
        }

        public void FillPersonObject(clsPerson Person)
        {
            Person.FirstName = tbFirstName.Text.Trim();
            Person.SecondName = tbSecondName.Text.Trim();
            Person.ThirdName = !string.IsNullOrWhiteSpace(tbThirdName.Text) ? tbThirdName.Text.Trim() : null;
            Person.LastName = tbLastName.Text.Trim();
            Person.DateOfBirth = DateOfBirthPicker.Value;
            Person.NationalNumber = mtbNationalNumber.Text.Trim();
            Person.Country.ID = cbCountries.SelectedIndex + 1;
            Person.Phone = tbPhone.Text.Trim();
            Person.Email = !string.IsNullOrWhiteSpace(tbEmail.Text) ? tbEmail.Text.Trim() : null;
            Person.Address = tbAddress.Text.Trim();

            if (rbMale.Checked)
                Person.Gender = 'M';
            else
                Person.Gender = 'F';

            if (pictureBox1.ImageLocation != null)
            {
                if (pictureBox1.ImageLocation != Person.ImagePath)
                {
                    if (Person.ImagePath != null)
                        File.Delete(Person.ImagePath);

                    Person.ImagePath = clsUtility.CopyFileToDestinationFileWithGUIDname(pictureBox1.ImageLocation,
                        clsGlobal.PersonsImagesFile);
                }
            }         
            else
            {
                if (Person.ImagePath != null)
                    File.Delete(Person.ImagePath);

                Person.ImagePath = null;
            }          
        }

        public void LoadInfoToControls(clsPerson Person)
        {
            mtbNationalNumber.Text = Person.NationalNumber;
            tbFirstName.Text = Person.FirstName;
            tbSecondName.Text = Person.SecondName;
            tbThirdName.Text = Person.ThirdName;
            tbLastName.Text = Person.LastName;
            tbAddress.Text = Person.Address;
            tbPhone.Text = Person.Phone;
            tbEmail.Text = Person.Email;
            DateOfBirthPicker.Value = Person.DateOfBirth;
        }

        public void FillControls(int PersonID)
        {
            clsPerson Person = clsPerson.Find(PersonID);

            LoadInfoToControls(Person);
            
            if (Person.Gender == 'M')
                rbMale.Checked = true;
            else
                rbFemale.Checked = true;

            cbCountries.SelectedIndex = Person.Country.ID - 1;

            if (Person.ImagePath != null)
            {
                pictureBox1.ImageLocation = Person.ImagePath;
                llRemoveImage.Visible = true;
            }
            else
            {
                if (Person.Gender == 'M')
                    pictureBox1.Image = Resources.Person_Male;
                else
                    pictureBox1.Image = Resources.Person_Female;
            }
        }

        public void SetDefaultImage()
        {
            if (rbMale.Checked)
                pictureBox1.Image = Resources.Person_Male;
            else if (rbFemale.Checked)
                pictureBox1.Image = Resources.Person_Female;
        }


        //Events:
        private void UsrCtrlPersonInfo_Load(object sender, EventArgs e)
        {          
            DateOfBirthPicker.MaxDate = DateTime.Now.AddYears(-18);
            DateOfBirthPicker.MinDate = DateTime.Now.AddYears(-100);
            _PopulateCBcountries();
        }


        //Text boxes validations:
        private void mtbNationalNumber_Validating(object sender, CancelEventArgs e)
        {
            if (mtbNationalNumber.Text.Trim().Length != 5)
            {
                e.Cancel = true;
                errorProvider1.SetError(mtbNationalNumber, "Enter a valid national number");
            }
            else 
            {
                errorProvider1.SetError(mtbNationalNumber, "");
            }
        }

        private void ValidateRequiredFields(object sender, CancelEventArgs e)
        {
            TextBox TB = (TextBox)sender;

            if (string.IsNullOrWhiteSpace(TB.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(TB, "This field is required");
            }
            else
            {
                errorProvider1.SetError(TB, "");
            }
        }

        private void tbPhone_Validating(object sender, CancelEventArgs e)
        {
            ValidateRequiredFields(sender, e);

            if (errorProvider1.GetError(tbPhone) != "")
            {
                return;
            }

            if (!clsValidation.IsPhoneNumberValid(tbPhone.Text))
            {
                errorProvider1.SetError(tbPhone, "Invalid phone number");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(tbPhone, "");
            }
        }

        private void tbPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b');
        }

        private void tbEmail_Validating(object sender, CancelEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tbEmail.Text))
            {
                if (!clsValidation.DoesEmailHaveBasicFormat(tbEmail.Text.Trim()))
                {
                    e.Cancel = true;
                    errorProvider1.SetError(tbEmail, "Invalid email format");
                }
                else
                {
                    errorProvider1.SetError(tbEmail, "");
                }
            }
            else
            {
                errorProvider1.SetError(tbEmail, "");
            }
        }

        private void GenderRadioButtons_CheckedChanged(object sender, EventArgs e)
        {
            SetDefaultImage();
        } 


        //PictureBox:
        private void LLSetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.InitialDirectory = "C:\\Users\\USER";
            openFileDialog1.Title = "Set Image";
            openFileDialog1.Filter = "Image files (*.png)|*.png";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = openFileDialog1.FileName;
                llRemoveImage.Visible = true;
            }
        }

        private void llRemoveImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pictureBox1.ImageLocation = null;
            SetDefaultImage();
            llRemoveImage.Visible = false;
        }
    }
}
