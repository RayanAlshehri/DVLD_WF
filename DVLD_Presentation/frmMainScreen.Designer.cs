namespace DVLD_Presentation
{
    partial class frmMainScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainScreen));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.miApplications = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miNewDrivingLic = new System.Windows.Forms.ToolStripMenuItem();
            this.miLocalLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.miInternationalLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.mmiLicenseRenew = new System.Windows.Forms.ToolStripMenuItem();
            this.miReplamcent = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ddmiDetainLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.ddmiReleaseLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.ddmiManageApplications = new System.Windows.Forms.ToolStripMenuItem();
            this.miManage = new System.Windows.Forms.ToolStripMenuItem();
            this.miManageLicensesClasses = new System.Windows.Forms.ToolStripMenuItem();
            this.miManageTests = new System.Windows.Forms.ToolStripMenuItem();
            this.miManageServices = new System.Windows.Forms.ToolStripMenuItem();
            this.miPersons = new System.Windows.Forms.ToolStripMenuItem();
            this.miDrivers = new System.Windows.Forms.ToolStripMenuItem();
            this.vehiclesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ddmiRegisterVehicles = new System.Windows.Forms.ToolStripMenuItem();
            this.miUsers = new System.Windows.Forms.ToolStripMenuItem();
            this.miAccountSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.ddmiUserDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.ddmiChangePassword = new System.Windows.Forms.ToolStripMenuItem();
            this.ddmiLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.miClose = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(55)))));
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(25, 25);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miApplications,
            this.miManage,
            this.miPersons,
            this.miDrivers,
            this.vehiclesToolStripMenuItem,
            this.miUsers,
            this.miAccountSettings,
            this.miClose});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1924, 95);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // miApplications
            // 
            this.miApplications.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.ddmiManageApplications});
            this.miApplications.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.miApplications.ForeColor = System.Drawing.Color.White;
            this.miApplications.Image = global::DVLD_Presentation.Properties.Resources.Application;
            this.miApplications.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.miApplications.Name = "miApplications";
            this.miApplications.Size = new System.Drawing.Size(198, 85);
            this.miApplications.Text = "Applications";
            this.miApplications.DropDownClosed += new System.EventHandler(this.MenuItem_DropDownClosed);
            this.miApplications.DropDownOpened += new System.EventHandler(this.MenuItem_DropDownOpened);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(40)))));
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miNewDrivingLic,
            this.mmiLicenseRenew,
            this.miReplamcent,
            this.toolStripSeparator1,
            this.ddmiDetainLicense,
            this.ddmiReleaseLicense});
            this.newToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
            this.newToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(260, 38);
            this.newToolStripMenuItem.Text = "New";
            // 
            // miNewDrivingLic
            // 
            this.miNewDrivingLic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(40)))));
            this.miNewDrivingLic.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miLocalLicense,
            this.miInternationalLicense});
            this.miNewDrivingLic.ForeColor = System.Drawing.Color.White;
            this.miNewDrivingLic.Image = global::DVLD_Presentation.Properties.Resources.add_button;
            this.miNewDrivingLic.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.miNewDrivingLic.Name = "miNewDrivingLic";
            this.miNewDrivingLic.Size = new System.Drawing.Size(349, 38);
            this.miNewDrivingLic.Text = "New Driving License";
            // 
            // miLocalLicense
            // 
            this.miLocalLicense.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(40)))));
            this.miLocalLicense.ForeColor = System.Drawing.Color.White;
            this.miLocalLicense.Image = global::DVLD_Presentation.Properties.Resources.location;
            this.miLocalLicense.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.miLocalLicense.Name = "miLocalLicense";
            this.miLocalLicense.Size = new System.Drawing.Size(256, 38);
            this.miLocalLicense.Text = "Local License";
            this.miLocalLicense.Click += new System.EventHandler(this.miLocalLicense_Click);
            // 
            // miInternationalLicense
            // 
            this.miInternationalLicense.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(40)))));
            this.miInternationalLicense.ForeColor = System.Drawing.Color.White;
            this.miInternationalLicense.Image = global::DVLD_Presentation.Properties.Resources.international;
            this.miInternationalLicense.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.miInternationalLicense.Name = "miInternationalLicense";
            this.miInternationalLicense.Size = new System.Drawing.Size(256, 38);
            this.miInternationalLicense.Text = "International License";
            this.miInternationalLicense.Click += new System.EventHandler(this.miInternationalLicense_Click);
            // 
            // mmiLicenseRenew
            // 
            this.mmiLicenseRenew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(40)))));
            this.mmiLicenseRenew.ForeColor = System.Drawing.Color.White;
            this.mmiLicenseRenew.Image = global::DVLD_Presentation.Properties.Resources.refresh;
            this.mmiLicenseRenew.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mmiLicenseRenew.Name = "mmiLicenseRenew";
            this.mmiLicenseRenew.Size = new System.Drawing.Size(349, 38);
            this.mmiLicenseRenew.Text = "Driving License Renewal";
            this.mmiLicenseRenew.Click += new System.EventHandler(this.ddmiLicenseRenew_Click);
            // 
            // miReplamcent
            // 
            this.miReplamcent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(40)))));
            this.miReplamcent.ForeColor = System.Drawing.Color.White;
            this.miReplamcent.Image = global::DVLD_Presentation.Properties.Resources._switch;
            this.miReplamcent.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.miReplamcent.Name = "miReplamcent";
            this.miReplamcent.Size = new System.Drawing.Size(349, 38);
            this.miReplamcent.Text = "Replacement of Lost or Damaged";
            this.miReplamcent.Click += new System.EventHandler(this.ddmiReplamcent_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(31)))), ((int)(((byte)(63)))));
            this.toolStripSeparator1.ForeColor = System.Drawing.Color.Gainsboro;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(346, 6);
            // 
            // ddmiDetainLicense
            // 
            this.ddmiDetainLicense.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(40)))));
            this.ddmiDetainLicense.ForeColor = System.Drawing.Color.White;
            this.ddmiDetainLicense.Image = global::DVLD_Presentation.Properties.Resources.stop;
            this.ddmiDetainLicense.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ddmiDetainLicense.Name = "ddmiDetainLicense";
            this.ddmiDetainLicense.Size = new System.Drawing.Size(349, 38);
            this.ddmiDetainLicense.Text = "Detain License";
            this.ddmiDetainLicense.Click += new System.EventHandler(this.ddmiDetainLicense_Click);
            // 
            // ddmiReleaseLicense
            // 
            this.ddmiReleaseLicense.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(40)))));
            this.ddmiReleaseLicense.ForeColor = System.Drawing.Color.White;
            this.ddmiReleaseLicense.Image = global::DVLD_Presentation.Properties.Resources.unlock;
            this.ddmiReleaseLicense.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ddmiReleaseLicense.Name = "ddmiReleaseLicense";
            this.ddmiReleaseLicense.Size = new System.Drawing.Size(349, 38);
            this.ddmiReleaseLicense.Text = "Release License";
            this.ddmiReleaseLicense.Click += new System.EventHandler(this.ddmiReleaseLicense_Click);
            // 
            // ddmiManageApplications
            // 
            this.ddmiManageApplications.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(40)))));
            this.ddmiManageApplications.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddmiManageApplications.ForeColor = System.Drawing.Color.White;
            this.ddmiManageApplications.Image = global::DVLD_Presentation.Properties.Resources.project_management;
            this.ddmiManageApplications.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ddmiManageApplications.Name = "ddmiManageApplications";
            this.ddmiManageApplications.Size = new System.Drawing.Size(260, 38);
            this.ddmiManageApplications.Text = "Manage Applications";
            this.ddmiManageApplications.Click += new System.EventHandler(this.ddmiManageApplications_Click);
            // 
            // miManage
            // 
            this.miManage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miManageLicensesClasses,
            this.miManageTests,
            this.miManageServices});
            this.miManage.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.miManage.ForeColor = System.Drawing.Color.White;
            this.miManage.Image = global::DVLD_Presentation.Properties.Resources.software_application;
            this.miManage.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.miManage.Name = "miManage";
            this.miManage.Size = new System.Drawing.Size(160, 85);
            this.miManage.Text = "Manage";
            this.miManage.DropDownClosed += new System.EventHandler(this.MenuItem_DropDownClosed);
            this.miManage.DropDownOpened += new System.EventHandler(this.MenuItem_DropDownOpened);
            // 
            // miManageLicensesClasses
            // 
            this.miManageLicensesClasses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(40)))));
            this.miManageLicensesClasses.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.miManageLicensesClasses.ForeColor = System.Drawing.Color.White;
            this.miManageLicensesClasses.Image = global::DVLD_Presentation.Properties.Resources.manage_id;
            this.miManageLicensesClasses.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.miManageLicensesClasses.Name = "miManageLicensesClasses";
            this.miManageLicensesClasses.Size = new System.Drawing.Size(285, 38);
            this.miManageLicensesClasses.Text = "Manage Licenses Classes";
            this.miManageLicensesClasses.Click += new System.EventHandler(this.miManageLicensesClasses_Click);
            // 
            // miManageTests
            // 
            this.miManageTests.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(40)))));
            this.miManageTests.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.miManageTests.ForeColor = System.Drawing.Color.White;
            this.miManageTests.Image = global::DVLD_Presentation.Properties.Resources.exam1;
            this.miManageTests.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.miManageTests.Name = "miManageTests";
            this.miManageTests.Size = new System.Drawing.Size(285, 38);
            this.miManageTests.Text = "Manage Tests";
            this.miManageTests.Click += new System.EventHandler(this.miManageTests_Click);
            // 
            // miManageServices
            // 
            this.miManageServices.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(40)))));
            this.miManageServices.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.miManageServices.ForeColor = System.Drawing.Color.White;
            this.miManageServices.Image = global::DVLD_Presentation.Properties.Resources.customer;
            this.miManageServices.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.miManageServices.Name = "miManageServices";
            this.miManageServices.Size = new System.Drawing.Size(285, 38);
            this.miManageServices.Text = "Manage Services";
            this.miManageServices.Click += new System.EventHandler(this.miManageServices_Click);
            // 
            // miPersons
            // 
            this.miPersons.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.miPersons.ForeColor = System.Drawing.Color.White;
            this.miPersons.Image = global::DVLD_Presentation.Properties.Resources.people;
            this.miPersons.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.miPersons.Name = "miPersons";
            this.miPersons.Size = new System.Drawing.Size(157, 85);
            this.miPersons.Text = "Persons";
            this.miPersons.Click += new System.EventHandler(this.miPersons_Click);
            // 
            // miDrivers
            // 
            this.miDrivers.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.miDrivers.ForeColor = System.Drawing.Color.White;
            this.miDrivers.Image = global::DVLD_Presentation.Properties.Resources.driver;
            this.miDrivers.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.miDrivers.Name = "miDrivers";
            this.miDrivers.Size = new System.Drawing.Size(151, 85);
            this.miDrivers.Text = "Drivers";
            this.miDrivers.Click += new System.EventHandler(this.miDrivers_Click);
            // 
            // vehiclesToolStripMenuItem
            // 
            this.vehiclesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ddmiRegisterVehicles});
            this.vehiclesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vehiclesToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.vehiclesToolStripMenuItem.Image = global::DVLD_Presentation.Properties.Resources.car1;
            this.vehiclesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.vehiclesToolStripMenuItem.Name = "vehiclesToolStripMenuItem";
            this.vehiclesToolStripMenuItem.Size = new System.Drawing.Size(158, 85);
            this.vehiclesToolStripMenuItem.Text = "Vehicles";
            this.vehiclesToolStripMenuItem.DropDownClosed += new System.EventHandler(this.MenuItem_DropDownClosed);
            this.vehiclesToolStripMenuItem.DropDownOpened += new System.EventHandler(this.MenuItem_DropDownOpened);
            // 
            // ddmiRegisterVehicles
            // 
            this.ddmiRegisterVehicles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(40)))));
            this.ddmiRegisterVehicles.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddmiRegisterVehicles.ForeColor = System.Drawing.Color.White;
            this.ddmiRegisterVehicles.Image = global::DVLD_Presentation.Properties.Resources.edition;
            this.ddmiRegisterVehicles.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ddmiRegisterVehicles.Name = "ddmiRegisterVehicles";
            this.ddmiRegisterVehicles.Size = new System.Drawing.Size(227, 38);
            this.ddmiRegisterVehicles.Text = "Register Vehicles";
            this.ddmiRegisterVehicles.Click += new System.EventHandler(this.ddmiRegisterVehicles_Click);
            // 
            // miUsers
            // 
            this.miUsers.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.miUsers.ForeColor = System.Drawing.Color.White;
            this.miUsers.Image = global::DVLD_Presentation.Properties.Resources.worker;
            this.miUsers.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.miUsers.Name = "miUsers";
            this.miUsers.Size = new System.Drawing.Size(136, 85);
            this.miUsers.Text = "Users";
            this.miUsers.Click += new System.EventHandler(this.miUsers_Click);
            // 
            // miAccountSettings
            // 
            this.miAccountSettings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ddmiUserDetails,
            this.ddmiChangePassword,
            this.ddmiLogout});
            this.miAccountSettings.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.miAccountSettings.ForeColor = System.Drawing.Color.White;
            this.miAccountSettings.Image = global::DVLD_Presentation.Properties.Resources.account_settings;
            this.miAccountSettings.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.miAccountSettings.Name = "miAccountSettings";
            this.miAccountSettings.Size = new System.Drawing.Size(239, 85);
            this.miAccountSettings.Text = "Account Settings";
            this.miAccountSettings.DropDownClosed += new System.EventHandler(this.MenuItem_DropDownClosed);
            this.miAccountSettings.DropDownOpened += new System.EventHandler(this.MenuItem_DropDownOpened);
            // 
            // ddmiUserDetails
            // 
            this.ddmiUserDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(40)))));
            this.ddmiUserDetails.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddmiUserDetails.ForeColor = System.Drawing.Color.White;
            this.ddmiUserDetails.Image = global::DVLD_Presentation.Properties.Resources.id_card;
            this.ddmiUserDetails.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ddmiUserDetails.Name = "ddmiUserDetails";
            this.ddmiUserDetails.Size = new System.Drawing.Size(232, 38);
            this.ddmiUserDetails.Text = "User Details";
            this.ddmiUserDetails.Click += new System.EventHandler(this.ddmiUserDetails_Click);
            // 
            // ddmiChangePassword
            // 
            this.ddmiChangePassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(40)))));
            this.ddmiChangePassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddmiChangePassword.ForeColor = System.Drawing.Color.White;
            this.ddmiChangePassword.Image = global::DVLD_Presentation.Properties.Resources.reset_password_;
            this.ddmiChangePassword.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ddmiChangePassword.Name = "ddmiChangePassword";
            this.ddmiChangePassword.Size = new System.Drawing.Size(232, 38);
            this.ddmiChangePassword.Text = "Change Password";
            this.ddmiChangePassword.Click += new System.EventHandler(this.ddmiChangePassword_Click);
            // 
            // ddmiLogout
            // 
            this.ddmiLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(40)))));
            this.ddmiLogout.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddmiLogout.ForeColor = System.Drawing.Color.White;
            this.ddmiLogout.Image = global::DVLD_Presentation.Properties.Resources.log_out;
            this.ddmiLogout.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ddmiLogout.Name = "ddmiLogout";
            this.ddmiLogout.Size = new System.Drawing.Size(232, 38);
            this.ddmiLogout.Text = "Logout";
            this.ddmiLogout.Click += new System.EventHandler(this.ddmiLogout_Click);
            // 
            // miClose
            // 
            this.miClose.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.miClose.ForeColor = System.Drawing.Color.White;
            this.miClose.Image = global::DVLD_Presentation.Properties.Resources.close_page;
            this.miClose.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.miClose.Name = "miClose";
            this.miClose.Size = new System.Drawing.Size(135, 85);
            this.miClose.Text = "Close";
            this.miClose.Click += new System.EventHandler(this.miClose_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1924, 1061);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // pnlMenu
            // 
            this.pnlMenu.Controls.Add(this.menuStrip1);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(1924, 95);
            this.pnlMenu.TabIndex = 10;
            // 
            // frmMainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1924, 1061);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frmMainScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DVLD";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMainScreen_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem miApplications;
        private System.Windows.Forms.ToolStripMenuItem miPersons;
        private System.Windows.Forms.ToolStripMenuItem miDrivers;
        private System.Windows.Forms.ToolStripMenuItem miUsers;
        private System.Windows.Forms.ToolStripMenuItem miAccountSettings;
        private System.Windows.Forms.ToolStripMenuItem ddmiUserDetails;
        private System.Windows.Forms.ToolStripMenuItem ddmiChangePassword;
        private System.Windows.Forms.ToolStripMenuItem ddmiLogout;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miNewDrivingLic;
        private System.Windows.Forms.ToolStripMenuItem mmiLicenseRenew;
        private System.Windows.Forms.ToolStripMenuItem miReplamcent;
        private System.Windows.Forms.ToolStripMenuItem ddmiReleaseLicense;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem ddmiManageApplications;
        private System.Windows.Forms.ToolStripMenuItem ddmiDetainLicense;
        private System.Windows.Forms.ToolStripMenuItem miLocalLicense;
        private System.Windows.Forms.ToolStripMenuItem miInternationalLicense;
        private System.Windows.Forms.ToolStripMenuItem miManage;
        private System.Windows.Forms.ToolStripMenuItem miManageLicensesClasses;
        private System.Windows.Forms.ToolStripMenuItem miManageTests;
        private System.Windows.Forms.ToolStripMenuItem miManageServices;
        private System.Windows.Forms.ToolStripMenuItem miClose;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem vehiclesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ddmiRegisterVehicles;
        private System.Windows.Forms.Panel pnlMenu;
    }
}