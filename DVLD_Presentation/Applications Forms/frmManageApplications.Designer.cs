namespace DVLD_Presentation
{
    partial class frmManageApplications
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
            this.label2 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblNoOfRecords = new System.Windows.Forms.Label();
            this.dgvApplications = new System.Windows.Forms.DataGridView();
            this.cmsApplication = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.miOpenApplication = new System.Windows.Forms.ToolStripMenuItem();
            this.miCancel = new System.Windows.Forms.ToolStripMenuItem();
            this.miApplicantLicenses = new System.Windows.Forms.ToolStripMenuItem();
            this.rbNew = new System.Windows.Forms.RadioButton();
            this.rbComplete = new System.Windows.Forms.RadioButton();
            this.rbCancelled = new System.Windows.Forms.RadioButton();
            this.pnlStatusesFilters = new System.Windows.Forms.Panel();
            this.btnAddApplication = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApplications)).BeginInit();
            this.cmsApplication.SuspendLayout();
            this.pnlStatusesFilters.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbFilter
            // 
            this.tbFilter.Location = new System.Drawing.Point(189, 119);
            this.tbFilter.Name = "tbFilter";
            this.tbFilter.Size = new System.Drawing.Size(131, 20);
            this.tbFilter.TabIndex = 13;
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
            "Application Number",
            "National Number",
            "Full Name",
            "Status"});
            this.cbFilters.Location = new System.Drawing.Point(62, 118);
            this.cbFilters.Name = "cbFilters";
            this.cbFilters.Size = new System.Drawing.Size(121, 21);
            this.cbFilters.TabIndex = 12;
            this.cbFilters.SelectedIndexChanged += new System.EventHandler(this.cbFilters_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Filter:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Location = new System.Drawing.Point(232, 21);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(552, 37);
            this.lblTitle.TabIndex = 10;
            this.lblTitle.Text = "Manage Local License Applications";
            // 
            // lblNoOfRecords
            // 
            this.lblNoOfRecords.AutoSize = true;
            this.lblNoOfRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoOfRecords.Location = new System.Drawing.Point(24, 428);
            this.lblNoOfRecords.Name = "lblNoOfRecords";
            this.lblNoOfRecords.Size = new System.Drawing.Size(108, 20);
            this.lblNoOfRecords.TabIndex = 8;
            this.lblNoOfRecords.Text = "No. of records";
            // 
            // dgvApplications
            // 
            this.dgvApplications.AllowUserToAddRows = false;
            this.dgvApplications.AllowUserToDeleteRows = false;
            this.dgvApplications.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvApplications.BackgroundColor = System.Drawing.Color.White;
            this.dgvApplications.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvApplications.ContextMenuStrip = this.cmsApplication;
            this.dgvApplications.Location = new System.Drawing.Point(12, 145);
            this.dgvApplications.MultiSelect = false;
            this.dgvApplications.Name = "dgvApplications";
            this.dgvApplications.ReadOnly = true;
            this.dgvApplications.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvApplications.Size = new System.Drawing.Size(1010, 262);
            this.dgvApplications.TabIndex = 7;
            this.dgvApplications.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvApplications_KeyDown);
            // 
            // cmsApplication
            // 
            this.cmsApplication.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmsApplication.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miOpenApplication,
            this.miCancel,
            this.miApplicantLicenses});
            this.cmsApplication.Name = "contextMenuStrip1";
            this.cmsApplication.Size = new System.Drawing.Size(222, 94);
            this.cmsApplication.Opening += new System.ComponentModel.CancelEventHandler(this.cmsApplication_Opening);
            // 
            // miOpenApplication
            // 
            this.miOpenApplication.Image = global::DVLD_Presentation.Properties.Resources.google_docs;
            this.miOpenApplication.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.miOpenApplication.Name = "miOpenApplication";
            this.miOpenApplication.Size = new System.Drawing.Size(221, 30);
            this.miOpenApplication.Text = "Open Application";
            this.miOpenApplication.Click += new System.EventHandler(this.miEdit_Click);
            // 
            // miCancel
            // 
            this.miCancel.Image = global::DVLD_Presentation.Properties.Resources.cross_24;
            this.miCancel.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.miCancel.Name = "miCancel";
            this.miCancel.Size = new System.Drawing.Size(221, 30);
            this.miCancel.Text = "Cancel";
            this.miCancel.Click += new System.EventHandler(this.miCancel_Click);
            // 
            // miApplicantLicenses
            // 
            this.miApplicantLicenses.Image = global::DVLD_Presentation.Properties.Resources.list;
            this.miApplicantLicenses.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.miApplicantLicenses.Name = "miApplicantLicenses";
            this.miApplicantLicenses.Size = new System.Drawing.Size(221, 30);
            this.miApplicantLicenses.Text = "View Applicant Licenses";
            this.miApplicantLicenses.Click += new System.EventHandler(this.miApplicantLicenses_Click);
            // 
            // rbNew
            // 
            this.rbNew.AutoSize = true;
            this.rbNew.Location = new System.Drawing.Point(3, 3);
            this.rbNew.Name = "rbNew";
            this.rbNew.Size = new System.Drawing.Size(47, 17);
            this.rbNew.TabIndex = 14;
            this.rbNew.TabStop = true;
            this.rbNew.Text = "New";
            this.rbNew.UseVisualStyleBackColor = true;
            this.rbNew.CheckedChanged += new System.EventHandler(this.rbNew_CheckedChanged);
            // 
            // rbComplete
            // 
            this.rbComplete.AutoSize = true;
            this.rbComplete.Location = new System.Drawing.Point(58, 3);
            this.rbComplete.Name = "rbComplete";
            this.rbComplete.Size = new System.Drawing.Size(69, 17);
            this.rbComplete.TabIndex = 15;
            this.rbComplete.TabStop = true;
            this.rbComplete.Text = "Complete";
            this.rbComplete.UseVisualStyleBackColor = true;
            this.rbComplete.CheckedChanged += new System.EventHandler(this.rbComplete_CheckedChanged);
            // 
            // rbCancelled
            // 
            this.rbCancelled.AutoSize = true;
            this.rbCancelled.Location = new System.Drawing.Point(130, 3);
            this.rbCancelled.Name = "rbCancelled";
            this.rbCancelled.Size = new System.Drawing.Size(72, 17);
            this.rbCancelled.TabIndex = 16;
            this.rbCancelled.TabStop = true;
            this.rbCancelled.Text = "Cancelled";
            this.rbCancelled.UseVisualStyleBackColor = true;
            this.rbCancelled.CheckedChanged += new System.EventHandler(this.rbCancelled_CheckedChanged);
            // 
            // pnlStatusesFilters
            // 
            this.pnlStatusesFilters.Controls.Add(this.rbNew);
            this.pnlStatusesFilters.Controls.Add(this.rbCancelled);
            this.pnlStatusesFilters.Controls.Add(this.rbComplete);
            this.pnlStatusesFilters.Location = new System.Drawing.Point(189, 118);
            this.pnlStatusesFilters.Name = "pnlStatusesFilters";
            this.pnlStatusesFilters.Size = new System.Drawing.Size(203, 26);
            this.pnlStatusesFilters.TabIndex = 17;
            this.pnlStatusesFilters.Visible = false;
            // 
            // btnAddApplication
            // 
            this.btnAddApplication.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddApplication.Image = global::DVLD_Presentation.Properties.Resources.new_file;
            this.btnAddApplication.Location = new System.Drawing.Point(957, 89);
            this.btnAddApplication.Name = "btnAddApplication";
            this.btnAddApplication.Size = new System.Drawing.Size(65, 50);
            this.btnAddApplication.TabIndex = 18;
            this.btnAddApplication.UseVisualStyleBackColor = true;
            this.btnAddApplication.Click += new System.EventHandler(this.btnAddApplication_Click);
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::DVLD_Presentation.Properties.Resources.cross;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(880, 426);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(133, 37);
            this.btnClose.TabIndex = 19;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmManageApplications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(1034, 475);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAddApplication);
            this.Controls.Add(this.pnlStatusesFilters);
            this.Controls.Add(this.tbFilter);
            this.Controls.Add(this.cbFilters);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblNoOfRecords);
            this.Controls.Add(this.dgvApplications);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmManageApplications";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Manage Applications";
            this.Load += new System.EventHandler(this.frmMangeApplications_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvApplications)).EndInit();
            this.cmsApplication.ResumeLayout(false);
            this.pnlStatusesFilters.ResumeLayout(false);
            this.pnlStatusesFilters.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbFilter;
        private System.Windows.Forms.ComboBox cbFilters;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblNoOfRecords;
        private System.Windows.Forms.DataGridView dgvApplications;
        private System.Windows.Forms.RadioButton rbNew;
        private System.Windows.Forms.RadioButton rbComplete;
        private System.Windows.Forms.RadioButton rbCancelled;
        private System.Windows.Forms.Panel pnlStatusesFilters;
        private System.Windows.Forms.ContextMenuStrip cmsApplication;
        private System.Windows.Forms.ToolStripMenuItem miOpenApplication;
        private System.Windows.Forms.ToolStripMenuItem miCancel;
        private System.Windows.Forms.ToolStripMenuItem miApplicantLicenses;
        private System.Windows.Forms.Button btnAddApplication;
        private System.Windows.Forms.Button btnClose;
    }
}