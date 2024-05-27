namespace DVLD_Presentation
{
    partial class CtrlFindPerson
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.mtbNationalNumber = new System.Windows.Forms.MaskedTextBox();
            this.btnAddPerson = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.ctrlPersonCard1 = new DVLD_Presentation.CtrlPersonCard();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "National Number:";
            // 
            // mtbNationalNumber
            // 
            this.mtbNationalNumber.Location = new System.Drawing.Point(150, 17);
            this.mtbNationalNumber.Mask = "00000";
            this.mtbNationalNumber.Name = "mtbNationalNumber";
            this.mtbNationalNumber.Size = new System.Drawing.Size(118, 20);
            this.mtbNationalNumber.TabIndex = 0;
            this.mtbNationalNumber.ValidatingType = typeof(int);
            this.mtbNationalNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtbNationalNumber_KeyPress);
            // 
            // btnAddPerson
            // 
            this.btnAddPerson.BackColor = System.Drawing.Color.White;
            this.btnAddPerson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPerson.Image = global::DVLD_Presentation.Properties.Resources.add_user2;
            this.btnAddPerson.Location = new System.Drawing.Point(808, 5);
            this.btnAddPerson.Name = "btnAddPerson";
            this.btnAddPerson.Size = new System.Drawing.Size(63, 47);
            this.btnAddPerson.TabIndex = 2;
            this.btnAddPerson.UseVisualStyleBackColor = false;
            this.btnAddPerson.Click += new System.EventHandler(this.btnAddPerson_Click);
            // 
            // btnFind
            // 
            this.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFind.Image = global::DVLD_Presentation.Properties.Resources.magnifying_glass_3;
            this.btnFind.Location = new System.Drawing.Point(274, 13);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(44, 29);
            this.btnFind.TabIndex = 1;
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // ctrlPersonCard1
            // 
            this.ctrlPersonCard1.BackColor = System.Drawing.Color.White;
            this.ctrlPersonCard1.ForeColor = System.Drawing.Color.Black;
            this.ctrlPersonCard1.Location = new System.Drawing.Point(7, 48);
            this.ctrlPersonCard1.Name = "ctrlPersonCard1";
            this.ctrlPersonCard1.Size = new System.Drawing.Size(867, 192);
            this.ctrlPersonCard1.TabIndex = 3;
            // 
            // CtrlFindPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnAddPerson);
            this.Controls.Add(this.ctrlPersonCard1);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.mtbNationalNumber);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "CtrlFindPerson";
            this.Size = new System.Drawing.Size(874, 245);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mtbNationalNumber;
        private System.Windows.Forms.Button btnFind;
        private CtrlPersonCard ctrlPersonCard1;
        private System.Windows.Forms.Button btnAddPerson;
    }
}
