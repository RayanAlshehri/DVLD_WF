namespace DVLD_Presentation
{
    partial class frmSelectLicense
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSelectLicense));
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnSelectLicense = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.ctrlFindDriverLicenses1 = new DVLD_Presentation.User_Controls.License.CtrlFindDriverLicenses();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Location = new System.Drawing.Point(318, 29);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(236, 37);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Select License";
            // 
            // btnSelectLicense
            // 
            this.btnSelectLicense.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectLicense.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectLicense.Image = ((System.Drawing.Image)(resources.GetObject("btnSelectLicense.Image")));
            this.btnSelectLicense.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSelectLicense.Location = new System.Drawing.Point(671, 567);
            this.btnSelectLicense.Name = "btnSelectLicense";
            this.btnSelectLicense.Size = new System.Drawing.Size(197, 37);
            this.btnSelectLicense.TabIndex = 1;
            this.btnSelectLicense.Text = "Select License";
            this.btnSelectLicense.UseVisualStyleBackColor = true;
            this.btnSelectLicense.Click += new System.EventHandler(this.btnSelectLicense_Click);
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::DVLD_Presentation.Properties.Resources.cross;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(542, 567);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(123, 37);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ctrlFindDriverLicenses1
            // 
            this.ctrlFindDriverLicenses1.BackColor = System.Drawing.Color.White;
            this.ctrlFindDriverLicenses1.ForeColor = System.Drawing.Color.Black;
            this.ctrlFindDriverLicenses1.Location = new System.Drawing.Point(12, 102);
            this.ctrlFindDriverLicenses1.Name = "ctrlFindDriverLicenses1";
            this.ctrlFindDriverLicenses1.rbInternationalLicensesEnabled = true;
            this.ctrlFindDriverLicenses1.Size = new System.Drawing.Size(872, 451);
            this.ctrlFindDriverLicenses1.TabIndex = 0;
            // 
            // frmSelectLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(889, 615);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.ctrlFindDriverLicenses1);
            this.Controls.Add(this.btnSelectLicense);
            this.Controls.Add(this.lblTitle);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmSelectLicense";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Select License";
            this.Load += new System.EventHandler(this.frmSelectLicense_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnSelectLicense;
        private User_Controls.License.CtrlFindDriverLicenses ctrlFindDriverLicenses1;
        private System.Windows.Forms.Button btnClose;
    }
}