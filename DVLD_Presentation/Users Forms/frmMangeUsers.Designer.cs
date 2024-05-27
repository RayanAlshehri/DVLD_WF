namespace DVLD_Presentation
{
    partial class frmMangeUsers
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
            this.components = new System.ComponentModel.Container();
            this.tbFilter = new System.Windows.Forms.TextBox();
            this.cbFilters = new System.Windows.Forms.ComboBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblNoOfRecords = new System.Windows.Forms.Label();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.miUserDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.miEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.miChangePassword = new System.Windows.Forms.ToolStripMenuItem();
            this.miDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.miSendEmail = new System.Windows.Forms.ToolStripMenuItem();
            this.miPhoneCall = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.cbAccStatusFilter = new System.Windows.Forms.CheckBox();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbFilter
            // 
            this.tbFilter.Location = new System.Drawing.Point(189, 106);
            this.tbFilter.Name = "tbFilter";
            this.tbFilter.Size = new System.Drawing.Size(131, 20);
            this.tbFilter.TabIndex = 1;
            this.tbFilter.Visible = false;
            this.tbFilter.TextChanged += new System.EventHandler(this.tbFilter_TextChanged);
            this.tbFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbFilter_KeyPress);
            // 
            // cbFilters
            // 
            this.cbFilters.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilters.FormattingEnabled = true;
            this.cbFilters.Items.AddRange(new object[] {
            "None",
            "User ID",
            "Full Name",
            "Username",
            "Account Status"});
            this.cbFilters.Location = new System.Drawing.Point(62, 105);
            this.cbFilters.Name = "cbFilters";
            this.cbFilters.Size = new System.Drawing.Size(121, 21);
            this.cbFilters.TabIndex = 0;
            this.cbFilters.SelectedIndexChanged += new System.EventHandler(this.cbFilters_SelectedIndexChanged);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Location = new System.Drawing.Point(347, 30);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(236, 37);
            this.lblTitle.TabIndex = 11;
            this.lblTitle.Text = "Manage Users";
            // 
            // lblNoOfRecords
            // 
            this.lblNoOfRecords.AutoSize = true;
            this.lblNoOfRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoOfRecords.Location = new System.Drawing.Point(24, 415);
            this.lblNoOfRecords.Name = "lblNoOfRecords";
            this.lblNoOfRecords.Size = new System.Drawing.Size(108, 20);
            this.lblNoOfRecords.TabIndex = 9;
            this.lblNoOfRecords.Text = "No. of records";
            // 
            // dgvUsers
            // 
            this.dgvUsers.AllowUserToAddRows = false;
            this.dgvUsers.AllowUserToDeleteRows = false;
            this.dgvUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsers.BackgroundColor = System.Drawing.Color.White;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvUsers.Location = new System.Drawing.Point(12, 132);
            this.dgvUsers.MultiSelect = false;
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.ReadOnly = true;
            this.dgvUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsers.Size = new System.Drawing.Size(910, 262);
            this.dgvUsers.TabIndex = 4;
            this.dgvUsers.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvUsers_KeyDown);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miUserDetails,
            this.miEdit,
            this.miChangePassword,
            this.miDelete,
            this.toolStripSeparator1,
            this.miSendEmail,
            this.miPhoneCall});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(189, 190);
            // 
            // miUserDetails
            // 
            this.miUserDetails.Image = global::DVLD_Presentation.Properties.Resources.details;
            this.miUserDetails.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.miUserDetails.Name = "miUserDetails";
            this.miUserDetails.Size = new System.Drawing.Size(188, 30);
            this.miUserDetails.Text = "User Details";
            this.miUserDetails.Click += new System.EventHandler(this.miUserDetails_Click);
            // 
            // miEdit
            // 
            this.miEdit.Image = global::DVLD_Presentation.Properties.Resources.edit_user;
            this.miEdit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.miEdit.Name = "miEdit";
            this.miEdit.Size = new System.Drawing.Size(188, 30);
            this.miEdit.Text = "Edit";
            this.miEdit.Click += new System.EventHandler(this.miEdit_Click);
            // 
            // miChangePassword
            // 
            this.miChangePassword.Image = global::DVLD_Presentation.Properties.Resources.reset_password_24;
            this.miChangePassword.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.miChangePassword.Name = "miChangePassword";
            this.miChangePassword.Size = new System.Drawing.Size(188, 30);
            this.miChangePassword.Text = "Change Password";
            this.miChangePassword.Click += new System.EventHandler(this.miChangePassword_Click);
            // 
            // miDelete
            // 
            this.miDelete.Image = global::DVLD_Presentation.Properties.Resources.delete1;
            this.miDelete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.miDelete.Name = "miDelete";
            this.miDelete.Size = new System.Drawing.Size(188, 30);
            this.miDelete.Text = "Delete";
            this.miDelete.Click += new System.EventHandler(this.miDelete_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(185, 6);
            // 
            // miSendEmail
            // 
            this.miSendEmail.Image = global::DVLD_Presentation.Properties.Resources.email1;
            this.miSendEmail.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.miSendEmail.Name = "miSendEmail";
            this.miSendEmail.Size = new System.Drawing.Size(188, 30);
            this.miSendEmail.Text = "Send Email";
            // 
            // miPhoneCall
            // 
            this.miPhoneCall.Image = global::DVLD_Presentation.Properties.Resources.phone_call;
            this.miPhoneCall.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.miPhoneCall.Name = "miPhoneCall";
            this.miPhoneCall.Size = new System.Drawing.Size(188, 30);
            this.miPhoneCall.Text = "Phone Call";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Filter:";
            // 
            // cbAccStatusFilter
            // 
            this.cbAccStatusFilter.AutoSize = true;
            this.cbAccStatusFilter.Location = new System.Drawing.Point(198, 108);
            this.cbAccStatusFilter.Name = "cbAccStatusFilter";
            this.cbAccStatusFilter.Size = new System.Drawing.Size(104, 17);
            this.cbAccStatusFilter.TabIndex = 1;
            this.cbAccStatusFilter.Text = "Active Accounts";
            this.cbAccStatusFilter.UseVisualStyleBackColor = true;
            this.cbAccStatusFilter.Visible = false;
            this.cbAccStatusFilter.CheckedChanged += new System.EventHandler(this.cbAccStatusFilter_CheckedChanged);
            // 
            // btnAddUser
            // 
            this.btnAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddUser.Image = global::DVLD_Presentation.Properties.Resources.add_user2;
            this.btnAddUser.Location = new System.Drawing.Point(857, 76);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(65, 50);
            this.btnAddUser.TabIndex = 3;
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::DVLD_Presentation.Properties.Resources.cross;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(789, 413);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(133, 37);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmMangeUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(934, 462);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.cbAccStatusFilter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbFilter);
            this.Controls.Add(this.cbFilters);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.lblNoOfRecords);
            this.Controls.Add(this.dgvUsers);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmMangeUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Manage Users";
            this.Load += new System.EventHandler(this.frmMangeUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbFilter;
        private System.Windows.Forms.ComboBox cbFilters;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Label lblNoOfRecords;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbAccStatusFilter;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem miUserDetails;
        private System.Windows.Forms.ToolStripMenuItem miEdit;
        private System.Windows.Forms.ToolStripMenuItem miDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem miSendEmail;
        private System.Windows.Forms.ToolStripMenuItem miPhoneCall;
        private System.Windows.Forms.ToolStripMenuItem miChangePassword;
        private System.Windows.Forms.Button btnClose;
    }
}