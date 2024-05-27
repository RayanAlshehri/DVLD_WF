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
    public partial class CtrlFindPerson : UserControl
    {
        private bool _EnableAddNewPerson = true;
        private bool _EnableFindControls = true;

        public event EventHandler<PersonFoundEventArgs> PersonFound;

        public class PersonFoundEventArgs : EventArgs
        {
            public clsPerson FoundPerson { get; }

            public PersonFoundEventArgs(clsPerson FoundPerson)
            {
                this.FoundPerson = FoundPerson;
            }
        }

        protected virtual void OnPersonFound()
        {
            PersonFound?.Invoke(this, new PersonFoundEventArgs(ctrlPersonCard1.Person));
        }

        public bool EnableAddNewPerson
        {
            get 
            {
                return _EnableAddNewPerson;
            }

            set 
            {
                btnAddPerson.Enabled = value;
                _EnableAddNewPerson = value;              
            }
        }

        public bool EnableFindControls
        {
            get
            {
                return _EnableFindControls;
            }

            set
            {
                mtbNationalNumber.Enabled = value;
                btnFind.Enabled = value;
                _EnableFindControls = value;
            }
        }

        public CtrlFindPerson()
        {
            InitializeComponent();
        }

        public void DisableFindControls()
        {
            mtbNationalNumber.Enabled = false;
            btnFind.Enabled = false;
            btnAddPerson.Enabled = false;
        }

        public void FocusFindTextBox()
        {
            mtbNationalNumber.Focus();
        }

        private void _FillNewlyAddedPersonInfo(int PersonID)
        {
            ctrlPersonCard1.FillPersonCard(PersonID);
            OnPersonFound();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(mtbNationalNumber.Text))
            {
                MessageBox.Show("Enter national number to find", "Find Person",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                mtbNationalNumber.Clear();
                return;
            }

            if (mtbNationalNumber.Text.Trim().Length != 5)
            {
                MessageBox.Show("Enter a valid national number", "Find Person",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            string NationalNumber = mtbNationalNumber.Text.Trim();

            if (clsPerson.DoesPersonExist(NationalNumber))
            {
                ctrlPersonCard1.FillPersonCard(NationalNumber);
                OnPersonFound();
            }
            else
            {
                MessageBox.Show("Person with national number " + NationalNumber + " was not found", "Find Person",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            frmAddNewPerson frm = new frmAddNewPerson();

            frm.PersonAdded += _FillNewlyAddedPersonInfo;
            frm.ShowDialog();
        }

        private void mtbNationalNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                btnFind.PerformClick();
        }
    }
}
