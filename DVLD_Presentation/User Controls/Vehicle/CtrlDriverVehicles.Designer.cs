namespace DVLD_Presentation
{
    partial class CtrlDriverVehicles
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
            this.dgvVehicles = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNoVehiclesMessage = new System.Windows.Forms.Label();
            this.ctrlPersonCard1 = new DVLD_Presentation.CtrlPersonCard();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.miVehicleDetails = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehicles)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvVehicles
            // 
            this.dgvVehicles.AllowUserToAddRows = false;
            this.dgvVehicles.AllowUserToDeleteRows = false;
            this.dgvVehicles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVehicles.BackgroundColor = System.Drawing.Color.White;
            this.dgvVehicles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVehicles.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvVehicles.Location = new System.Drawing.Point(3, 251);
            this.dgvVehicles.MultiSelect = false;
            this.dgvVehicles.Name = "dgvVehicles";
            this.dgvVehicles.ReadOnly = true;
            this.dgvVehicles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVehicles.Size = new System.Drawing.Size(865, 180);
            this.dgvVehicles.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Vehicles:";
            // 
            // lblNoVehiclesMessage
            // 
            this.lblNoVehiclesMessage.AutoSize = true;
            this.lblNoVehiclesMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoVehiclesMessage.Location = new System.Drawing.Point(303, 328);
            this.lblNoVehiclesMessage.Name = "lblNoVehiclesMessage";
            this.lblNoVehiclesMessage.Size = new System.Drawing.Size(265, 20);
            this.lblNoVehiclesMessage.TabIndex = 3;
            this.lblNoVehiclesMessage.Text = "This driver does not have any vehicle";
            this.lblNoVehiclesMessage.Visible = false;
            // 
            // ctrlPersonCard1
            // 
            this.ctrlPersonCard1.BackColor = System.Drawing.Color.White;
            this.ctrlPersonCard1.ForeColor = System.Drawing.Color.Black;
            this.ctrlPersonCard1.Location = new System.Drawing.Point(3, 3);
            this.ctrlPersonCard1.Name = "ctrlPersonCard1";
            this.ctrlPersonCard1.Size = new System.Drawing.Size(867, 192);
            this.ctrlPersonCard1.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miVehicleDetails});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(167, 34);
            // 
            // miVehicleDetails
            // 
            this.miVehicleDetails.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.miVehicleDetails.Image = global::DVLD_Presentation.Properties.Resources.details;
            this.miVehicleDetails.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.miVehicleDetails.Name = "miVehicleDetails";
            this.miVehicleDetails.Size = new System.Drawing.Size(166, 30);
            this.miVehicleDetails.Text = "Vehicle Details";
            this.miVehicleDetails.Click += new System.EventHandler(this.miVehicleDetails_Click);
            // 
            // CtrlDriverVehicles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblNoVehiclesMessage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvVehicles);
            this.Controls.Add(this.ctrlPersonCard1);
            this.Name = "CtrlDriverVehicles";
            this.Size = new System.Drawing.Size(871, 434);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehicles)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CtrlPersonCard ctrlPersonCard1;
        private System.Windows.Forms.DataGridView dgvVehicles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNoVehiclesMessage;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem miVehicleDetails;
    }
}
