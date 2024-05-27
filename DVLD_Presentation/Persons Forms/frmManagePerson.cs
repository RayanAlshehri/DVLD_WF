using DVLD_Business;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using System.Drawing;
using CommonClasses;

namespace DVLD_Presentation
{
    public partial class frmManagePerson : Form
    {
        private DataTable PersonsDT;
        enum enFilters 
        {
            None, NationalNumber, FirstName, SecondName, ThirdName, LastName,
                Gender, DateOfBirth, CountryName 
        }

        enFilters CurrentFilter;
        public frmManagePerson()
        {
            InitializeComponent();

            lblTitle.Location = new Point(clsDesign.GetControlXcenterPosition(ClientSize.Width, lblTitle.Width), clsGlobal.YpositionForTitle);
        }
               
        private void AllowPersonsDTediting()
        {
            PersonsDT.Columns["NationalNumber"].ReadOnly = false;
            PersonsDT.Columns["FirstName"].ReadOnly = false;
            PersonsDT.Columns["SecondName"].ReadOnly = false;
            PersonsDT.Columns["ThirdName"].ReadOnly = false;
            PersonsDT.Columns["LastName"].ReadOnly = false;
            PersonsDT.Columns["Gender"].ReadOnly = false;
            PersonsDT.Columns["DateOfBirth"].ReadOnly = false;
            PersonsDT.Columns["Nationality"].ReadOnly = false;
            PersonsDT.Columns["Phone"].ReadOnly = false;
            PersonsDT.Columns["Email"].ReadOnly = false;
            PersonsDT.Columns["Address"].ReadOnly = false;
        }

        private void CustomizeDGV()
        {
            dgvPersons.Columns["NationalNumber"].HeaderText = "National Number";
            dgvPersons.Columns["NationalNumber"].Width = 125;

            dgvPersons.Columns["FirstName"].HeaderText = "First Name";

            dgvPersons.Columns["SecondName"].HeaderText = "Second Name";
            dgvPersons.Columns["SecondName"].Width = 110;

            dgvPersons.Columns["ThirdName"].HeaderText = "Third Name";
            dgvPersons.Columns["ThirdName"].Width = 110;

            dgvPersons.Columns["LastName"].HeaderText = "Last Name";
            dgvPersons.Columns["LastName"].Width = 110;

            dgvPersons.Columns["DateOfBirth"].HeaderText = "Date of Birth";
            dgvPersons.Columns["DateOfBirth"].Width = 110;

            dgvPersons.Columns["Nationality"].Width = 105;

        }

        private void LoadDataToDGV()
        {
            PersonsDT = clsPerson.GetAllPersons();
            
            if (PersonsDT.Columns.Count > 0)
            {
                AllowPersonsDTediting();
            }
            else
            {
                MessageBox.Show("Error in fetching data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            dgvPersons.DataSource = PersonsDT;      
            CustomizeDGV();        
        }

        private void ApplyFilter()
        {
            switch (CurrentFilter)
            {
                case enFilters.FirstName:
                    PersonsDT.DefaultView.RowFilter = "[FirstName] like '" + tbFilter.Text.ToString().Trim() + "%'";
                    break;

                case enFilters.SecondName:
                    PersonsDT.DefaultView.RowFilter = "[SecondName] like '" + tbFilter.Text.ToString() + "%'";
                    break;

                case enFilters.ThirdName:
                    PersonsDT.DefaultView.RowFilter = "[ThirdName] like '" + tbFilter.Text.ToString().Trim() + "%'";
                    break;

                case enFilters.LastName:
                    PersonsDT.DefaultView.RowFilter = "[LastName] like '" + tbFilter.Text.ToString().Trim() + "%'";
                    break;

                case enFilters.Gender:
                    PersonsDT.DefaultView.RowFilter = "[Gender] like '" + tbFilter.Text.ToString().Trim() + "%'";
                    break;

                case enFilters.DateOfBirth:
                    PersonsDT.DefaultView.RowFilter = "[DateOfBirth] like '" + tbFilter.Text.ToString().Trim() + "%'";
                    break;

                case enFilters.NationalNumber:
                    PersonsDT.DefaultView.RowFilter = "[NationalNumber] like '" + tbFilter.Text.ToString().Trim() + "%'";
                    break;

                case enFilters.CountryName:
                    PersonsDT.DefaultView.RowFilter = "[Nationality] like '" + tbFilter.Text.ToString().Trim() + "%'";
                    break;
            }
        }

        private void AddNewPersonToDGV(int PersonID)
        {
            clsPerson Person = clsPerson.Find(PersonID);         

            DataRowView NewRow = PersonsDT.DefaultView.AddNew();

            NewRow["FirstName"] = Person.FirstName;
            NewRow["SecondName"] = Person.SecondName;
            NewRow["ThirdName"] = Person.ThirdName;
            NewRow["LastName"] = Person.LastName;
            NewRow["DateOfBirth"] = clsUtility.FormatDateToDMY(Person.DateOfBirth);
            NewRow["NationalNumber"] = Person.NationalNumber;         
            NewRow["Nationality"] = Person.Country.Name;
            NewRow["Phone"] = Person.Phone;
            NewRow["Email"] = Person.Email;
            NewRow["Address"] = Person.Address;

            if (Person.Gender == 'M')
                NewRow["Gender"] = "Male";
            else
                NewRow["Gender"] = "Female";

            lblNoOfRecords.Text = dgvPersons.Rows.Count + " Record(s)";
        }

        private void ApplyChangesToPerson()
        {
            clsPerson Person = clsPerson.Find(dgvPersons.CurrentRow.Cells["NationalNumber"].Value.ToString());
          
            dgvPersons.CurrentRow.Cells["FirstName"].Value = Person.FirstName;
            dgvPersons.CurrentRow.Cells["SecondName"].Value = Person.SecondName;
            dgvPersons.CurrentRow.Cells["ThirdName"].Value = Person.ThirdName;
            dgvPersons.CurrentRow.Cells["LastName"].Value = Person.LastName;
            dgvPersons.CurrentRow.Cells["DateOfBirth"].Value = clsUtility.FormatDateToDMY(Person.DateOfBirth);
            dgvPersons.CurrentRow.Cells["Nationality"].Value = Person.Country.Name;
            dgvPersons.CurrentRow.Cells["Phone"].Value = Person.Phone;
            dgvPersons.CurrentRow.Cells["Email"].Value = Person.Email;
            dgvPersons.CurrentRow.Cells["Address"].Value = Person.Address;

            if (Person.Gender == 'M')
                dgvPersons.CurrentRow.Cells["Gender"].Value = "Male";
            else
                dgvPersons.CurrentRow.Cells["Gender"].Value = "Female";
        }


        //Events:
        private void frmManagePerson_Load(object sender, EventArgs e)
        {
            LoadDataToDGV();

            lblNoOfRecords.Text = dgvPersons.Rows.Count + " Record(s)";
            cbFilters.SelectedIndex = (int)enFilters.None;
        }

        private void cbFilters_SelectedIndexChanged(object sender, EventArgs e)
        {
            CurrentFilter = (enFilters)cbFilters.SelectedIndex;
            tbFilter.Clear();
            PersonsDT.DefaultView.RowFilter = "";
            lblNoOfRecords.Text = dgvPersons.Rows.Count + " Record(s)";
            tbFilter.Visible = (CurrentFilter != enFilters.None);
        }

        private void tbFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (CurrentFilter == enFilters.NationalNumber)
            {
                e.Handled = (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b');
            }
        }

        private void tbFilter_TextChanged(object sender, EventArgs e)
        {
            ApplyFilter();
            lblNoOfRecords.Text = dgvPersons.Rows.Count + " Record(s)";
        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            frmAddNewPerson frm = new frmAddNewPerson();
            frm.PersonAdded += AddNewPersonToDGV;
            frm.ShowDialog();
        }

        private void dgvPersons_KeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = (e.KeyCode == Keys.Escape);
            Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }


        //Context menu events:
        private void miPersonDetails_Click(object sender, EventArgs e)
        {
            frmPersonDetails frm = new frmPersonDetails(dgvPersons.CurrentRow.Cells["NationalNumber"].Value.ToString());

            frm.ctrlPersonCard1.PersonUpdated += ApplyChangesToPerson;
            frm.ShowDialog();                                                                                                     
        }

        private void miEdit_Click(object sender, EventArgs e)
        {
            frmUpdatePerson frm = new frmUpdatePerson(dgvPersons.CurrentRow.Cells["NationalNumber"].Value.ToString());
            frm.PersonUpdated += ApplyChangesToPerson;
            frm.ShowDialog();          
        }

        private void miDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this person?", "Confirmation", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                return;
            }

            string NationalNumber = dgvPersons.CurrentRow.Cells["NationalNumber"].Value.ToString();
            string PersonImagePath = clsPerson.Find(NationalNumber).ImagePath;

            if (clsPerson.DeletePerson(NationalNumber))
            {
                MessageBox.Show("Person deleted successfully", "Delete Person", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                dgvPersons.Rows.RemoveAt(dgvPersons.CurrentRow.Index);
                lblNoOfRecords.Text = dgvPersons.Rows.Count + " Record(s)";

                if (PersonImagePath != null)
                {
                    File.Delete(PersonImagePath);
                }
            }
            else
            {
                MessageBox.Show("Can not delete person because there is data linked to it", "Delete Person", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }        
        }      
    }
}
