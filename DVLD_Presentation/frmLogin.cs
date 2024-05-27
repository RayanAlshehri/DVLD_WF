using System;
using CommonClasses;
using System.Windows.Forms;
using DVLD_Business;
using System.Configuration;

namespace DVLD_Presentation
{
    public partial class frmLogin : Form
    {
        string StoredUsername;
        bool IsCredentialsStored = false;
        public frmLogin()
        {
            InitializeComponent();
        }

        private bool IsLoginInfoFilled()
        {
            return !(string.IsNullOrWhiteSpace(tbUsername.Text) || string.IsNullOrWhiteSpace(tbPassword.Text));
        }


        private void frmLogin_Load(object sender, EventArgs e)
        {           
            if (clsUtility.GetStoredUsernameInRegestry(ref StoredUsername, ConfigurationManager.AppSettings["RegestryKeyName"]))
            {
                tbUsername.Text = StoredUsername;
                cbRememberMe.Checked = true;
                IsCredentialsStored = true;
            }
            
            tbUsername.Focus();
            this.ActiveControl = tbUsername;
        }
      
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!IsLoginInfoFilled())
            {
                MessageBox.Show("Login information not filled", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);

                tbUsername.Clear();
                tbPassword.Clear();
                return;
            }

            clsUser User;

            try
            {
                User = clsUser.Find(tbUsername.Text.Trim(), clsUtility.HashData(tbPassword.Text.Trim()));               
            }
            catch (Exception EX)
            {
                clsUtility.LogExceptionToEventViewer(ConfigurationManager.AppSettings["LoggedExceptionSourceName"], EX);
                MessageBox.Show("Error in getting credentials", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (User == null)
            {
                MessageBox.Show("Wrong username or password", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbPassword.Clear();
                return;
            }

            if (cbRememberMe.Checked)
            {
                if (!IsCredentialsStored || (tbUsername.Text != StoredUsername))
                {
                    clsUtility.StoreUsernameInRegestry(User.Username,
                        ConfigurationManager.AppSettings["RegestryKeyName"]);
                }
            }
            else
            {
                if (IsCredentialsStored)
                    clsUtility.DeleteStoredUsernameInRegestry(ConfigurationManager.AppSettings["RegestryKeyName"]);
            }


            if (!User.IsActive)
            {
                MessageBox.Show("Account not active", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);

                tbUsername.Clear();
                tbPassword.Clear();
            }
            else
            {
                clsGlobal.LogedUser = User;

                Form frm = new frmMainScreen(this);

                tbUsername.Focus();
                this.Hide();
                tbUsername.Clear();
                tbPassword.Clear();
                frmLogin_Load(null, null);
                frm.Show();
            }
        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Environment.Exit(0);           
        }     
    }
}
