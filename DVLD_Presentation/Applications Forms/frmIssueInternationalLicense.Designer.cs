namespace DVLD_Presentation
{
    partial class frmIssueInternationalLicense
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
            this.btnIssueLicense = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblServiceFee = new System.Windows.Forms.Label();
            this.llViewInternationalLicense = new System.Windows.Forms.LinkLabel();
            this.ctrlSearchForLicense1 = new DVLD_Presentation.CtrlSearchForLicense();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Location = new System.Drawing.Point(225, 35);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(450, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Issue Internamtional License";
            // 
            // btnIssueLicense
            // 
            this.btnIssueLicense.Enabled = false;
            this.btnIssueLicense.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIssueLicense.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIssueLicense.Image = global::DVLD_Presentation.Properties.Resources.Driving_License;
            this.btnIssueLicense.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIssueLicense.Location = new System.Drawing.Point(757, 446);
            this.btnIssueLicense.Name = "btnIssueLicense";
            this.btnIssueLicense.Size = new System.Drawing.Size(190, 37);
            this.btnIssueLicense.TabIndex = 1;
            this.btnIssueLicense.Text = "Issue License";
            this.btnIssueLicense.UseVisualStyleBackColor = true;
            this.btnIssueLicense.Click += new System.EventHandler(this.btnIssueLicense_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 454);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Service Fee:";
            // 
            // lblServiceFee
            // 
            this.lblServiceFee.AutoSize = true;
            this.lblServiceFee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServiceFee.Location = new System.Drawing.Point(116, 454);
            this.lblServiceFee.Name = "lblServiceFee";
            this.lblServiceFee.Size = new System.Drawing.Size(0, 20);
            this.lblServiceFee.TabIndex = 7;
            // 
            // llViewInternationalLicense
            // 
            this.llViewInternationalLicense.AutoSize = true;
            this.llViewInternationalLicense.Enabled = false;
            this.llViewInternationalLicense.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llViewInternationalLicense.Location = new System.Drawing.Point(411, 454);
            this.llViewInternationalLicense.Name = "llViewInternationalLicense";
            this.llViewInternationalLicense.Size = new System.Drawing.Size(195, 20);
            this.llViewInternationalLicense.TabIndex = 2;
            this.llViewInternationalLicense.TabStop = true;
            this.llViewInternationalLicense.Text = "View International License";
            this.llViewInternationalLicense.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llViewInternationalLicense_LinkClicked);
            // 
            // ctrlSearchForLicense1
            // 
            this.ctrlSearchForLicense1.BackColor = System.Drawing.Color.White;
            this.ctrlSearchForLicense1.FindEnabled = true;
            this.ctrlSearchForLicense1.ForeColor = System.Drawing.Color.Black;
            this.ctrlSearchForLicense1.Location = new System.Drawing.Point(12, 102);
            this.ctrlSearchForLicense1.Name = "ctrlSearchForLicense1";
            this.ctrlSearchForLicense1.Size = new System.Drawing.Size(938, 331);
            this.ctrlSearchForLicense1.TabIndex = 0;
            this.ctrlSearchForLicense1.LicenseFound += new System.EventHandler<DVLD_Presentation.CtrlSearchForLicense.LicenseFoundEventArgs>(this.ctrlSearchForLicense1_LicenseFound);
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::DVLD_Presentation.Properties.Resources.cross;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(628, 446);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(123, 37);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmIssueInternationalLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(965, 495);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.ctrlSearchForLicense1);
            this.Controls.Add(this.llViewInternationalLicense);
            this.Controls.Add(this.lblServiceFee);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnIssueLicense);
            this.Controls.Add(this.lblTitle);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmIssueInternationalLicense";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Issue International License";
            this.Load += new System.EventHandler(this.frmIssueInternationalLicense_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnIssueLicense;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblServiceFee;
        private System.Windows.Forms.LinkLabel llViewInternationalLicense;
        private CtrlSearchForLicense ctrlSearchForLicense1;
        private System.Windows.Forms.Button btnClose;
    }
}