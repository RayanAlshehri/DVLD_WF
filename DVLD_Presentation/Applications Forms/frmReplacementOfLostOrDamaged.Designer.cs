namespace DVLD_Presentation
{
    partial class frmReplacementOfLostOrDamaged
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
            this.btnOtherFindOptions = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.rbLost = new System.Windows.Forms.RadioButton();
            this.rbDamaged = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.btnIssueLicense = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblServiceFee = new System.Windows.Forms.Label();
            this.llViewNewLicense = new System.Windows.Forms.LinkLabel();
            this.ctrlSearchForLicense1 = new DVLD_Presentation.CtrlSearchForLicense();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOtherFindOptions
            // 
            this.btnOtherFindOptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOtherFindOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOtherFindOptions.Location = new System.Drawing.Point(306, 115);
            this.btnOtherFindOptions.Name = "btnOtherFindOptions";
            this.btnOtherFindOptions.Size = new System.Drawing.Size(154, 37);
            this.btnOtherFindOptions.TabIndex = 1;
            this.btnOtherFindOptions.Text = "Other Find Options";
            this.btnOtherFindOptions.UseVisualStyleBackColor = true;
            this.btnOtherFindOptions.Click += new System.EventHandler(this.btnOtherFindOptions_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Location = new System.Drawing.Point(265, 30);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(340, 37);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "License Replacement";
            // 
            // rbLost
            // 
            this.rbLost.AutoSize = true;
            this.rbLost.Enabled = false;
            this.rbLost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbLost.Location = new System.Drawing.Point(144, 461);
            this.rbLost.Name = "rbLost";
            this.rbLost.Size = new System.Drawing.Size(58, 24);
            this.rbLost.TabIndex = 3;
            this.rbLost.TabStop = true;
            this.rbLost.Text = "Lost";
            this.rbLost.UseVisualStyleBackColor = true;
            this.rbLost.CheckedChanged += new System.EventHandler(this.rbLost_CheckedChanged);
            // 
            // rbDamaged
            // 
            this.rbDamaged.AutoSize = true;
            this.rbDamaged.Enabled = false;
            this.rbDamaged.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDamaged.Location = new System.Drawing.Point(208, 461);
            this.rbDamaged.Name = "rbDamaged";
            this.rbDamaged.Size = new System.Drawing.Size(97, 24);
            this.rbDamaged.TabIndex = 4;
            this.rbDamaged.TabStop = true;
            this.rbDamaged.Text = "Damaged";
            this.rbDamaged.UseVisualStyleBackColor = true;
            this.rbDamaged.CheckedChanged += new System.EventHandler(this.rbDamaged_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 463);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Replacement of:";
            // 
            // btnIssueLicense
            // 
            this.btnIssueLicense.Enabled = false;
            this.btnIssueLicense.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIssueLicense.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIssueLicense.Image = global::DVLD_Presentation.Properties.Resources.Driving_License;
            this.btnIssueLicense.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIssueLicense.Location = new System.Drawing.Point(749, 491);
            this.btnIssueLicense.Name = "btnIssueLicense";
            this.btnIssueLicense.Size = new System.Drawing.Size(190, 37);
            this.btnIssueLicense.TabIndex = 2;
            this.btnIssueLicense.Text = "Issue License";
            this.btnIssueLicense.UseVisualStyleBackColor = true;
            this.btnIssueLicense.Click += new System.EventHandler(this.btnIssueLicense_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 508);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Service Fee:";
            // 
            // lblServiceFee
            // 
            this.lblServiceFee.AutoSize = true;
            this.lblServiceFee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServiceFee.Location = new System.Drawing.Point(105, 508);
            this.lblServiceFee.Name = "lblServiceFee";
            this.lblServiceFee.Size = new System.Drawing.Size(0, 20);
            this.lblServiceFee.TabIndex = 7;
            // 
            // llViewNewLicense
            // 
            this.llViewNewLicense.AutoSize = true;
            this.llViewNewLicense.Enabled = false;
            this.llViewNewLicense.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llViewNewLicense.Location = new System.Drawing.Point(456, 508);
            this.llViewNewLicense.Name = "llViewNewLicense";
            this.llViewNewLicense.Size = new System.Drawing.Size(137, 20);
            this.llViewNewLicense.TabIndex = 3;
            this.llViewNewLicense.TabStop = true;
            this.llViewNewLicense.Text = "View New License";
            this.llViewNewLicense.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llViewNewLicense_LinkClicked);
            // 
            // ctrlSearchForLicense1
            // 
            this.ctrlSearchForLicense1.BackColor = System.Drawing.Color.White;
            this.ctrlSearchForLicense1.FindEnabled = true;
            this.ctrlSearchForLicense1.ForeColor = System.Drawing.Color.Black;
            this.ctrlSearchForLicense1.Location = new System.Drawing.Point(6, 113);
            this.ctrlSearchForLicense1.Name = "ctrlSearchForLicense1";
            this.ctrlSearchForLicense1.Size = new System.Drawing.Size(942, 327);
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
            this.btnClose.Location = new System.Drawing.Point(620, 491);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(123, 37);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmReplacementOfLostOrDamaged
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(954, 546);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.llViewNewLicense);
            this.Controls.Add(this.btnOtherFindOptions);
            this.Controls.Add(this.ctrlSearchForLicense1);
            this.Controls.Add(this.lblServiceFee);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnIssueLicense);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rbDamaged);
            this.Controls.Add(this.rbLost);
            this.Controls.Add(this.lblTitle);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmReplacementOfLostOrDamaged";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Replacement of Lost/Damaged";
            this.Load += new System.EventHandler(this.frmReplacementOfLostOrDamaged_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnOtherFindOptions;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.RadioButton rbLost;
        private System.Windows.Forms.RadioButton rbDamaged;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnIssueLicense;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblServiceFee;
        private CtrlSearchForLicense ctrlSearchForLicense1;
        private System.Windows.Forms.LinkLabel llViewNewLicense;
        private System.Windows.Forms.Button btnClose;
    }
}