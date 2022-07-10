namespace Accounting
{
    partial class frmEmployees
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
            this.lstEmployees = new System.Windows.Forms.ListBox();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblCommission = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nudCommission = new System.Windows.Forms.NumericUpDown();
            this.nudTax = new System.Windows.Forms.NumericUpDown();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnPayslip = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.AboutMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.lblDetails = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCommission)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTax)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstEmployees
            // 
            this.lstEmployees.DisplayMember = "\"Surname\"";
            this.lstEmployees.FormattingEnabled = true;
            this.lstEmployees.Location = new System.Drawing.Point(0, 25);
            this.lstEmployees.Name = "lstEmployees";
            this.lstEmployees.Size = new System.Drawing.Size(227, 199);
            this.lstEmployees.TabIndex = 0;
            this.lstEmployees.SelectedIndexChanged += new System.EventHandler(this.lstEmployees_SelectedIndexChanged);
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Location = new System.Drawing.Point(15, 27);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(82, 13);
            this.lblTax.TabIndex = 8;
            this.lblTax.Text = "Tax percentage";
            // 
            // lblCommission
            // 
            this.lblCommission.AutoSize = true;
            this.lblCommission.Location = new System.Drawing.Point(15, 61);
            this.lblCommission.Name = "lblCommission";
            this.lblCommission.Size = new System.Drawing.Size(119, 13);
            this.lblCommission.TabIndex = 9;
            this.lblCommission.Text = "Commission percentage";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nudCommission);
            this.groupBox1.Controls.Add(this.nudTax);
            this.groupBox1.Controls.Add(this.lblTax);
            this.groupBox1.Controls.Add(this.lblCommission);
            this.groupBox1.Location = new System.Drawing.Point(521, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(269, 100);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Apply to all employees";
            // 
            // nudCommission
            // 
            this.nudCommission.DecimalPlaces = 1;
            this.nudCommission.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudCommission.Location = new System.Drawing.Point(162, 59);
            this.nudCommission.Name = "nudCommission";
            this.nudCommission.Size = new System.Drawing.Size(101, 20);
            this.nudCommission.TabIndex = 11;
            this.nudCommission.ValueChanged += new System.EventHandler(this.nudCommission_ValueChanged);
            // 
            // nudTax
            // 
            this.nudTax.DecimalPlaces = 1;
            this.nudTax.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudTax.Location = new System.Drawing.Point(162, 27);
            this.nudTax.Name = "nudTax";
            this.nudTax.Size = new System.Drawing.Size(101, 20);
            this.nudTax.TabIndex = 10;
            this.nudTax.ValueChanged += new System.EventHandler(this.nudTax_ValueChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(391, 172);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 38);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Add new employee";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(472, 172);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 38);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save changes";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(553, 172);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 38);
            this.btnRemove.TabIndex = 13;
            this.btnRemove.Text = "Remove employee";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnPayslip
            // 
            this.btnPayslip.Location = new System.Drawing.Point(634, 172);
            this.btnPayslip.Name = "btnPayslip";
            this.btnPayslip.Size = new System.Drawing.Size(75, 38);
            this.btnPayslip.TabIndex = 14;
            this.btnPayslip.Text = "Payslip";
            this.btnPayslip.UseVisualStyleBackColor = true;
            this.btnPayslip.Click += new System.EventHandler(this.btnPayslip_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(715, 172);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 38);
            this.btnClose.TabIndex = 15;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(802, 24);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // AboutMenu
            // 
            this.AboutMenu.Name = "AboutMenu";
            this.AboutMenu.Size = new System.Drawing.Size(52, 20);
            this.AboutMenu.Text = "About";
            this.AboutMenu.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // lblDetails
            // 
            this.lblDetails.AutoSize = true;
            this.lblDetails.Location = new System.Drawing.Point(244, 10);
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.Size = new System.Drawing.Size(39, 13);
            this.lblDetails.TabIndex = 19;
            this.lblDetails.Text = "Details";
            // 
            // frmEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 222);
            this.Controls.Add(this.lblDetails);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnPayslip);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lstEmployees);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmEmployees";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EMPLOYEES";
            this.Load += new System.EventHandler(this.frmEmployees_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCommission)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTax)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstEmployees;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblCommission;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown nudCommission;
        private System.Windows.Forms.NumericUpDown nudTax;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnPayslip;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem AboutMenu;
        private System.Windows.Forms.Label lblDetails;
    }
}

