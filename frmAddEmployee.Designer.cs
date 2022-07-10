namespace Accounting
{
    partial class frmAddEmployee
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
            this.lblGSalary = new System.Windows.Forms.Label();
            this.lblDOB = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblDetails = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtGSalary = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.radCommisioned = new System.Windows.Forms.RadioButton();
            this.radSalaried = new System.Windows.Forms.RadioButton();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lblGSalary
            // 
            this.lblGSalary.AutoSize = true;
            this.lblGSalary.Location = new System.Drawing.Point(11, 176);
            this.lblGSalary.Name = "lblGSalary";
            this.lblGSalary.Size = new System.Drawing.Size(66, 13);
            this.lblGSalary.TabIndex = 12;
            this.lblGSalary.Text = "Gross Salary";
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Location = new System.Drawing.Point(11, 150);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(65, 13);
            this.lblDOB.TabIndex = 10;
            this.lblDOB.Text = "Date of birth";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(11, 123);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 9;
            this.lblName.Text = "Name";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(11, 96);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(49, 13);
            this.lblSurname.TabIndex = 8;
            this.lblSurname.Text = "Surname";
            // 
            // lblDetails
            // 
            this.lblDetails.AutoSize = true;
            this.lblDetails.Location = new System.Drawing.Point(11, 69);
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.Size = new System.Drawing.Size(18, 13);
            this.lblDetails.TabIndex = 7;
            this.lblDetails.Text = "ID";
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(118, 232);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 14;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(132, 69);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(200, 20);
            this.txtID.TabIndex = 15;
            // 
            // txtGSalary
            // 
            this.txtGSalary.Location = new System.Drawing.Point(132, 176);
            this.txtGSalary.Name = "txtGSalary";
            this.txtGSalary.Size = new System.Drawing.Size(200, 20);
            this.txtGSalary.TabIndex = 16;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(132, 123);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(200, 20);
            this.txtName.TabIndex = 19;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(132, 96);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(200, 20);
            this.txtSurname.TabIndex = 20;
            // 
            // radCommisioned
            // 
            this.radCommisioned.AutoSize = true;
            this.radCommisioned.Location = new System.Drawing.Point(12, 35);
            this.radCommisioned.Name = "radCommisioned";
            this.radCommisioned.Size = new System.Drawing.Size(141, 17);
            this.radCommisioned.TabIndex = 22;
            this.radCommisioned.TabStop = true;
            this.radCommisioned.Text = "Commissioned Employee";
            this.radCommisioned.UseVisualStyleBackColor = true;
            // 
            // radSalaried
            // 
            this.radSalaried.AutoSize = true;
            this.radSalaried.Checked = true;
            this.radSalaried.Location = new System.Drawing.Point(12, 12);
            this.radSalaried.Name = "radSalaried";
            this.radSalaried.Size = new System.Drawing.Size(112, 17);
            this.radSalaried.TabIndex = 21;
            this.radSalaried.TabStop = true;
            this.radSalaried.Text = "Salaried Employee";
            this.radSalaried.UseVisualStyleBackColor = true;
            // 
            // dtpDOB
            // 
            this.dtpDOB.Location = new System.Drawing.Point(132, 150);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(200, 20);
            this.dtpDOB.TabIndex = 23;
            // 
            // frmAddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 267);
            this.Controls.Add(this.dtpDOB);
            this.Controls.Add(this.radCommisioned);
            this.Controls.Add(this.radSalaried);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtGSalary);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblGSalary);
            this.Controls.Add(this.lblDOB);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.lblDetails);
            this.Name = "frmAddEmployee";
            this.Text = "ADD EMPLOYEE";
            this.Load += new System.EventHandler(this.frmAddEmployee_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblGSalary;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblDetails;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtGSalary;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.RadioButton radCommisioned;
        private System.Windows.Forms.RadioButton radSalaried;
        private System.Windows.Forms.DateTimePicker dtpDOB;
    }
}