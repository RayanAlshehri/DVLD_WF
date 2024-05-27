namespace DVLD_Presentation
{
    partial class frmLicenseDetention
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnDetainLicense = new System.Windows.Forms.Button();
            this.ctrlSearchForLicense1 = new DVLD_Presentation.CtrlSearchForLicense();
            this.label2 = new System.Windows.Forms.Label();
            this.tbFineFee = new System.Windows.Forms.TextBox();
            this.llViewDriverLicenses = new System.Windows.Forms.LinkLabel();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Location = new System.Drawing.Point(303, 40);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(288, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "License Detention";
            // 
            // btnDetainLicense
            // 
            this.btnDetainLicense.Enabled = false;
            this.btnDetainLicense.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetainLicense.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetainLicense.Image = global::DVLD_Presentation.Properties.Resources.stop;
            this.btnDetainLicense.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDetainLicense.Location = new System.Drawing.Point(749, 475);
            this.btnDetainLicense.Name = "btnDetainLicense";
            this.btnDetainLicense.Size = new System.Drawing.Size(197, 37);
            this.btnDetainLicense.TabIndex = 2;
            this.btnDetainLicense.Text = "Detain License";
            this.btnDetainLicense.UseVisualStyleBackColor = true;
            this.btnDetainLicense.Click += new System.EventHandler(this.btnDetainLicense_Click);
            // 
            // ctrlSearchForLicense1
            // 
            this.ctrlSearchForLicense1.BackColor = System.Drawing.Color.White;
            this.ctrlSearchForLicense1.FindEnabled = true;
            this.ctrlSearchForLicense1.ForeColor = System.Drawing.Color.Black;
            this.ctrlSearchForLicense1.Location = new System.Drawing.Point(12, 120);
            this.ctrlSearchForLicense1.Name = "ctrlSearchForLicense1";
            this.ctrlSearchForLicense1.Size = new System.Drawing.Size(938, 328);
            this.ctrlSearchForLicense1.TabIndex = 0;
            this.ctrlSearchForLicense1.LicenseFound += new System.EventHandler<DVLD_Presentation.CtrlSearchForLicense.LicenseFoundEventArgs>(this.ctrlSearchForLicense1_LicenseFound);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 487);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Fine:";
            // 
            // tbFineFee
            // 
            this.tbFineFee.Enabled = false;
            this.tbFineFee.Location = new System.Drawing.Point(86, 487);
            this.tbFineFee.Name = "tbFineFee";
            this.tbFineFee.Size = new System.Drawing.Size(130, 20);
            this.tbFineFee.TabIndex = 1;
            this.tbFineFee.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbFineFee_KeyPress);
            // 
            // llViewDriverLicenses
            // 
            this.llViewDriverLicenses.AutoSize = true;
            this.llViewDriverLicenses.Enabled = false;
            this.llViewDriverLicenses.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llViewDriverLicenses.Location = new System.Drawing.Point(436, 485);
            this.llViewDriverLicenses.Name = "llViewDriverLicenses";
            this.llViewDriverLicenses.Size = new System.Drawing.Size(155, 20);
            this.llViewDriverLicenses.TabIndex = 3;
            this.llViewDriverLicenses.TabStop = true;
            this.llViewDriverLicenses.Text = "View Driver Licenses";
            this.llViewDriverLicenses.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llViewDriverLicenses_LinkClicked);
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::DVLD_Presentation.Properties.Resources.cross;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(610, 475);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(133, 37);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmLicenseDetention
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(967, 527);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.llViewDriverLicenses);
            this.Controls.Add(this.tbFineFee);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ctrlSearchForLicense1);
            this.Controls.Add(this.btnDetainLicense);
            this.Controls.Add(this.lblTitle);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmLicenseDetention";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "License Detention";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnDetainLicense;
        private CtrlSearchForLicense ctrlSearchForLicense1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbFineFee;
        private System.Windows.Forms.LinkLabel llViewDriverLicenses;
        private System.Windows.Forms.Button btnClose;
    }
}