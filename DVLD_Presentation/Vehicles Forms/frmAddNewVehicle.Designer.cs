namespace DVLD_Presentation
{
    partial class frmRegisterVehicle
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
            this.lblTapPage2Title = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpSelectOwner = new System.Windows.Forms.TabPage();
            this.btnClose1 = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.lblTapPage1Title = new System.Windows.Forms.Label();
            this.tpVehicleRegistration = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblDriverFullName = new System.Windows.Forms.Label();
            this.lblDriverID = new System.Windows.Forms.Label();
            this.llViewDriverVehicles = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClose2 = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.llViewRegisteredVehicle = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbYear = new System.Windows.Forms.TextBox();
            this.tbVehicleModel = new System.Windows.Forms.TextBox();
            this.tbVehicleMake = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ctrlFindPerson1 = new DVLD_Presentation.CtrlFindPerson();
            this.tabControl1.SuspendLayout();
            this.tpSelectOwner.SuspendLayout();
            this.tpVehicleRegistration.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTapPage2Title
            // 
            this.lblTapPage2Title.AutoSize = true;
            this.lblTapPage2Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTapPage2Title.Location = new System.Drawing.Point(306, 30);
            this.lblTapPage2Title.Name = "lblTapPage2Title";
            this.lblTapPage2Title.Size = new System.Drawing.Size(320, 37);
            this.lblTapPage2Title.TabIndex = 0;
            this.lblTapPage2Title.Text = "Vehicle Registration";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpSelectOwner);
            this.tabControl1.Controls.Add(this.tpVehicleRegistration);
            this.tabControl1.Location = new System.Drawing.Point(1, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(922, 416);
            this.tabControl1.TabIndex = 0;
            // 
            // tpSelectOwner
            // 
            this.tpSelectOwner.BackColor = System.Drawing.Color.White;
            this.tpSelectOwner.Controls.Add(this.btnClose1);
            this.tpSelectOwner.Controls.Add(this.btnNext);
            this.tpSelectOwner.Controls.Add(this.lblTapPage1Title);
            this.tpSelectOwner.Controls.Add(this.ctrlFindPerson1);
            this.tpSelectOwner.Location = new System.Drawing.Point(4, 22);
            this.tpSelectOwner.Name = "tpSelectOwner";
            this.tpSelectOwner.Padding = new System.Windows.Forms.Padding(3);
            this.tpSelectOwner.Size = new System.Drawing.Size(914, 390);
            this.tpSelectOwner.TabIndex = 0;
            this.tpSelectOwner.Text = "Select Owner";
            this.tpSelectOwner.Enter += new System.EventHandler(this.tpSelectOwner_Enter);
            // 
            // btnClose1
            // 
            this.btnClose1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose1.Image = global::DVLD_Presentation.Properties.Resources.cross;
            this.btnClose1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose1.Location = new System.Drawing.Point(635, 334);
            this.btnClose1.Name = "btnClose1";
            this.btnClose1.Size = new System.Drawing.Size(123, 37);
            this.btnClose1.TabIndex = 2;
            this.btnClose1.Text = "Close";
            this.btnClose1.UseVisualStyleBackColor = true;
            this.btnClose1.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnNext
            // 
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Image = global::DVLD_Presentation.Properties.Resources.right_arrow;
            this.btnNext.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNext.Location = new System.Drawing.Point(764, 334);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(125, 37);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lblTapPage1Title
            // 
            this.lblTapPage1Title.AutoSize = true;
            this.lblTapPage1Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTapPage1Title.Location = new System.Drawing.Point(330, 17);
            this.lblTapPage1Title.Name = "lblTapPage1Title";
            this.lblTapPage1Title.Size = new System.Drawing.Size(219, 37);
            this.lblTapPage1Title.TabIndex = 2;
            this.lblTapPage1Title.Text = "Select Owner";
            // 
            // tpVehicleRegistration
            // 
            this.tpVehicleRegistration.BackColor = System.Drawing.Color.White;
            this.tpVehicleRegistration.Controls.Add(this.groupBox2);
            this.tpVehicleRegistration.Controls.Add(this.groupBox1);
            this.tpVehicleRegistration.Controls.Add(this.btnClose2);
            this.tpVehicleRegistration.Controls.Add(this.btnSave);
            this.tpVehicleRegistration.Controls.Add(this.llViewRegisteredVehicle);
            this.tpVehicleRegistration.Controls.Add(this.lblTapPage2Title);
            this.tpVehicleRegistration.Location = new System.Drawing.Point(4, 22);
            this.tpVehicleRegistration.Name = "tpVehicleRegistration";
            this.tpVehicleRegistration.Padding = new System.Windows.Forms.Padding(3);
            this.tpVehicleRegistration.Size = new System.Drawing.Size(914, 390);
            this.tpVehicleRegistration.TabIndex = 1;
            this.tpVehicleRegistration.Text = "Vehicle Registration";
            this.tpVehicleRegistration.Enter += new System.EventHandler(this.tpVehicleRegistration_Enter);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblDriverFullName);
            this.groupBox1.Controls.Add(this.lblDriverID);
            this.groupBox1.Controls.Add(this.llViewDriverVehicles);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(7, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(897, 96);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selected Driver";
            // 
            // lblDriverFullName
            // 
            this.lblDriverFullName.AutoSize = true;
            this.lblDriverFullName.Location = new System.Drawing.Point(362, 43);
            this.lblDriverFullName.Name = "lblDriverFullName";
            this.lblDriverFullName.Size = new System.Drawing.Size(18, 20);
            this.lblDriverFullName.TabIndex = 13;
            this.lblDriverFullName.Text = "?";
            // 
            // lblDriverID
            // 
            this.lblDriverID.AutoSize = true;
            this.lblDriverID.Location = new System.Drawing.Point(104, 43);
            this.lblDriverID.Name = "lblDriverID";
            this.lblDriverID.Size = new System.Drawing.Size(18, 20);
            this.lblDriverID.TabIndex = 12;
            this.lblDriverID.Text = "?";
            // 
            // llViewDriverVehicles
            // 
            this.llViewDriverVehicles.AutoSize = true;
            this.llViewDriverVehicles.Location = new System.Drawing.Point(701, 43);
            this.llViewDriverVehicles.Name = "llViewDriverVehicles";
            this.llViewDriverVehicles.Size = new System.Drawing.Size(152, 20);
            this.llViewDriverVehicles.TabIndex = 11;
            this.llViewDriverVehicles.TabStop = true;
            this.llViewDriverVehicles.Text = "View Driver Vehicles";
            this.llViewDriverVehicles.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llViewDriverVehicles_LinkClicked);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(272, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Full Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "DriverID:";
            // 
            // btnClose2
            // 
            this.btnClose2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose2.Image = global::DVLD_Presentation.Properties.Resources.cross;
            this.btnClose2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose2.Location = new System.Drawing.Point(648, 335);
            this.btnClose2.Name = "btnClose2";
            this.btnClose2.Size = new System.Drawing.Size(123, 37);
            this.btnClose2.TabIndex = 5;
            this.btnClose2.Text = "Close";
            this.btnClose2.UseVisualStyleBackColor = true;
            this.btnClose2.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = global::DVLD_Presentation.Properties.Resources.save;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(777, 335);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(123, 37);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // llViewRegisteredVehicle
            // 
            this.llViewRegisteredVehicle.AutoSize = true;
            this.llViewRegisteredVehicle.Enabled = false;
            this.llViewRegisteredVehicle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llViewRegisteredVehicle.Location = new System.Drawing.Point(429, 343);
            this.llViewRegisteredVehicle.Name = "llViewRegisteredVehicle";
            this.llViewRegisteredVehicle.Size = new System.Drawing.Size(181, 20);
            this.llViewRegisteredVehicle.TabIndex = 4;
            this.llViewRegisteredVehicle.TabStop = true;
            this.llViewRegisteredVehicle.Text = "View Registered Vehicle\r\n";
            this.llViewRegisteredVehicle.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llViewRegisteredVehicle_LinkClicked);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(652, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Year:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(335, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Vehicle Model:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Vehicle Make:";
            // 
            // tbYear
            // 
            this.tbYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbYear.Location = new System.Drawing.Point(705, 44);
            this.tbYear.MaxLength = 4;
            this.tbYear.Name = "tbYear";
            this.tbYear.Size = new System.Drawing.Size(159, 20);
            this.tbYear.TabIndex = 2;
            this.tbYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbYear_KeyPress);
            this.tbYear.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateRequiredTextBox_Validating);
            // 
            // tbVehicleModel
            // 
            this.tbVehicleModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbVehicleModel.Location = new System.Drawing.Point(453, 44);
            this.tbVehicleModel.Name = "tbVehicleModel";
            this.tbVehicleModel.Size = new System.Drawing.Size(159, 20);
            this.tbVehicleModel.TabIndex = 1;
            this.tbVehicleModel.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateRequiredTextBox_Validating);
            // 
            // tbVehicleMake
            // 
            this.tbVehicleMake.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbVehicleMake.Location = new System.Drawing.Point(141, 44);
            this.tbVehicleMake.Name = "tbVehicleMake";
            this.tbVehicleMake.Size = new System.Drawing.Size(159, 20);
            this.tbVehicleMake.TabIndex = 0;
            this.tbVehicleMake.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateRequiredTextBox_Validating);
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.tbVehicleMake);
            this.groupBox2.Controls.Add(this.tbVehicleModel);
            this.groupBox2.Controls.Add(this.tbYear);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(7, 211);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(897, 96);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Vehicle Information:";
            // 
            // ctrlFindPerson1
            // 
            this.ctrlFindPerson1.BackColor = System.Drawing.Color.White;
            this.ctrlFindPerson1.EnableAddNewPerson = true;
            this.ctrlFindPerson1.EnableFindControls = true;
            this.ctrlFindPerson1.ForeColor = System.Drawing.Color.Black;
            this.ctrlFindPerson1.Location = new System.Drawing.Point(17, 72);
            this.ctrlFindPerson1.Name = "ctrlFindPerson1";
            this.ctrlFindPerson1.Size = new System.Drawing.Size(874, 245);
            this.ctrlFindPerson1.TabIndex = 0;
            this.ctrlFindPerson1.PersonFound += new System.EventHandler<DVLD_Presentation.CtrlFindPerson.PersonFoundEventArgs>(this.ctrlFindPerson1_PersonFound);
            // 
            // frmRegisterVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnClose1;
            this.ClientSize = new System.Drawing.Size(921, 417);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmRegisterVehicle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Vehicle Registration";
            this.Load += new System.EventHandler(this.frmRegisterVehicle_Load);
            this.tabControl1.ResumeLayout(false);
            this.tpSelectOwner.ResumeLayout(false);
            this.tpSelectOwner.PerformLayout();
            this.tpVehicleRegistration.ResumeLayout(false);
            this.tpVehicleRegistration.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTapPage2Title;
        private CtrlFindPerson ctrlFindPerson1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpSelectOwner;
        private System.Windows.Forms.TabPage tpVehicleRegistration;
        private System.Windows.Forms.Label lblTapPage1Title;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbYear;
        private System.Windows.Forms.TextBox tbVehicleModel;
        private System.Windows.Forms.TextBox tbVehicleMake;
        private System.Windows.Forms.LinkLabel llViewRegisteredVehicle;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnClose2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnClose1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.LinkLabel llViewDriverVehicles;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDriverFullName;
        private System.Windows.Forms.Label lblDriverID;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}