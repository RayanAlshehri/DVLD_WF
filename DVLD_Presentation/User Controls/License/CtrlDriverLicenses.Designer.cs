namespace DVLD_Presentation
{
    partial class CtrlDriverLicenses
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
            this.components = new System.ComponentModel.Container();
            this.dgvLicenses = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.miLicenseDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.rbLocalLicenses = new System.Windows.Forms.RadioButton();
            this.rbInternationalLicenses = new System.Windows.Forms.RadioButton();
            this.ctrlPersonCard1 = new DVLD_Presentation.CtrlPersonCard();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLicenses)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvLicenses
            // 
            this.dgvLicenses.AllowUserToAddRows = false;
            this.dgvLicenses.AllowUserToDeleteRows = false;
            this.dgvLicenses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLicenses.BackgroundColor = System.Drawing.Color.White;
            this.dgvLicenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLicenses.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvLicenses.Location = new System.Drawing.Point(14, 251);
            this.dgvLicenses.MultiSelect = false;
            this.dgvLicenses.Name = "dgvLicenses";
            this.dgvLicenses.ReadOnly = true;
            this.dgvLicenses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLicenses.Size = new System.Drawing.Size(843, 166);
            this.dgvLicenses.TabIndex = 9;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miLicenseDetails});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(189, 56);
            // 
            // miLicenseDetails
            // 
            this.miLicenseDetails.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.miLicenseDetails.Image = global::DVLD_Presentation.Properties.Resources.details;
            this.miLicenseDetails.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.miLicenseDetails.Name = "miLicenseDetails";
            this.miLicenseDetails.Size = new System.Drawing.Size(188, 30);
            this.miLicenseDetails.Text = "License Details";
            this.miLicenseDetails.Click += new System.EventHandler(this.miLicenseDetails_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Licenses:";
            // 
            // rbLocalLicenses
            // 
            this.rbLocalLicenses.AutoSize = true;
            this.rbLocalLicenses.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbLocalLicenses.Location = new System.Drawing.Point(103, 217);
            this.rbLocalLicenses.Name = "rbLocalLicenses";
            this.rbLocalLicenses.Size = new System.Drawing.Size(132, 24);
            this.rbLocalLicenses.TabIndex = 11;
            this.rbLocalLicenses.TabStop = true;
            this.rbLocalLicenses.Text = "Local Licenses";
            this.rbLocalLicenses.UseVisualStyleBackColor = true;
            this.rbLocalLicenses.CheckedChanged += new System.EventHandler(this.rbLocalLicenses_CheckedChanged);
            // 
            // rbInternationalLicenses
            // 
            this.rbInternationalLicenses.AutoSize = true;
            this.rbInternationalLicenses.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbInternationalLicenses.Location = new System.Drawing.Point(241, 217);
            this.rbInternationalLicenses.Name = "rbInternationalLicenses";
            this.rbInternationalLicenses.Size = new System.Drawing.Size(183, 24);
            this.rbInternationalLicenses.TabIndex = 12;
            this.rbInternationalLicenses.TabStop = true;
            this.rbInternationalLicenses.Text = "International Licenses";
            this.rbInternationalLicenses.UseVisualStyleBackColor = true;
            this.rbInternationalLicenses.CheckedChanged += new System.EventHandler(this.rbInternationalLicenses_CheckedChanged);
            // 
            // ctrlPersonCard1
            // 
            this.ctrlPersonCard1.BackColor = System.Drawing.Color.White;
            this.ctrlPersonCard1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlPersonCard1.ForeColor = System.Drawing.Color.Black;
            this.ctrlPersonCard1.Location = new System.Drawing.Point(4, 5);
            this.ctrlPersonCard1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctrlPersonCard1.Name = "ctrlPersonCard1";
            this.ctrlPersonCard1.Size = new System.Drawing.Size(869, 194);
            this.ctrlPersonCard1.TabIndex = 1;
            // 
            // CtrlDriverLicenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.rbInternationalLicenses);
            this.Controls.Add(this.rbLocalLicenses);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvLicenses);
            this.Controls.Add(this.ctrlPersonCard1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "CtrlDriverLicenses";
            this.Size = new System.Drawing.Size(871, 420);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLicenses)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem miLicenseDetails;
        private System.Windows.Forms.DataGridView dgvLicenses;
        private System.Windows.Forms.RadioButton rbLocalLicenses;
        private System.Windows.Forms.RadioButton rbInternationalLicenses;
        private CtrlPersonCard ctrlPersonCard1;
    }
}
