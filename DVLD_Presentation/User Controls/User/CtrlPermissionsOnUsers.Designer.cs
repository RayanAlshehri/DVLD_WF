namespace DVLD_Presentation
{
    partial class CtrlPermissionsOnUsers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CtrlPermissionsOnUsers));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbFullPermissions = new System.Windows.Forms.CheckBox();
            this.cbDelete = new System.Windows.Forms.CheckBox();
            this.cbUpdate = new System.Windows.Forms.CheckBox();
            this.cbAdd = new System.Windows.Forms.CheckBox();
            this.cbViewList = new System.Windows.Forms.CheckBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbFullPermissions);
            this.groupBox1.Controls.Add(this.cbDelete);
            this.groupBox1.Controls.Add(this.cbUpdate);
            this.groupBox1.Controls.Add(this.cbAdd);
            this.groupBox1.Controls.Add(this.cbViewList);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(211, 149);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Permissions On Users:";
            // 
            // cbFullPermissions
            // 
            this.cbFullPermissions.AutoSize = true;
            this.cbFullPermissions.Location = new System.Drawing.Point(18, 35);
            this.cbFullPermissions.Name = "cbFullPermissions";
            this.cbFullPermissions.Size = new System.Drawing.Size(142, 24);
            this.cbFullPermissions.TabIndex = 4;
            this.cbFullPermissions.Text = "Full Permissions";
            this.cbFullPermissions.UseVisualStyleBackColor = true;
            this.cbFullPermissions.CheckedChanged += new System.EventHandler(this.cbFullPermissions_CheckedChanged);
            // 
            // cbDelete
            // 
            this.cbDelete.AutoSize = true;
            this.cbDelete.Enabled = false;
            this.cbDelete.Location = new System.Drawing.Point(137, 114);
            this.cbDelete.Name = "cbDelete";
            this.cbDelete.Size = new System.Drawing.Size(75, 24);
            this.cbDelete.TabIndex = 3;
            this.cbDelete.Text = "Delete";
            this.cbDelete.UseVisualStyleBackColor = true;
            this.cbDelete.CheckedChanged += new System.EventHandler(this.cbDelete_CheckedChanged);
            // 
            // cbUpdate
            // 
            this.cbUpdate.AutoSize = true;
            this.cbUpdate.Enabled = false;
            this.cbUpdate.Location = new System.Drawing.Point(18, 114);
            this.cbUpdate.Name = "cbUpdate";
            this.cbUpdate.Size = new System.Drawing.Size(81, 24);
            this.cbUpdate.TabIndex = 2;
            this.cbUpdate.Text = "Update";
            this.cbUpdate.UseVisualStyleBackColor = true;
            this.cbUpdate.CheckedChanged += new System.EventHandler(this.cbUpdate_CheckedChanged);
            // 
            // cbAdd
            // 
            this.cbAdd.AutoSize = true;
            this.cbAdd.Enabled = false;
            this.cbAdd.Location = new System.Drawing.Point(137, 75);
            this.cbAdd.Name = "cbAdd";
            this.cbAdd.Size = new System.Drawing.Size(57, 24);
            this.cbAdd.TabIndex = 1;
            this.cbAdd.Text = "Add";
            this.cbAdd.UseVisualStyleBackColor = true;
            this.cbAdd.CheckedChanged += new System.EventHandler(this.cbAdd_CheckedChanged);
            // 
            // cbViewList
            // 
            this.cbViewList.AutoSize = true;
            this.cbViewList.Location = new System.Drawing.Point(18, 75);
            this.cbViewList.Name = "cbViewList";
            this.cbViewList.Size = new System.Drawing.Size(91, 24);
            this.cbViewList.TabIndex = 0;
            this.cbViewList.Text = "View List";
            this.cbViewList.UseVisualStyleBackColor = true;
            this.cbViewList.CheckedChanged += new System.EventHandler(this.cbViewList_CheckedChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // CtrlPermissionsOnUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "CtrlPermissionsOnUsers";
            this.Size = new System.Drawing.Size(216, 150);
            this.Load += new System.EventHandler(this.CtrlPermissionsOnUsers_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbFullPermissions;
        private System.Windows.Forms.CheckBox cbDelete;
        private System.Windows.Forms.CheckBox cbUpdate;
        private System.Windows.Forms.CheckBox cbAdd;
        private System.Windows.Forms.CheckBox cbViewList;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
