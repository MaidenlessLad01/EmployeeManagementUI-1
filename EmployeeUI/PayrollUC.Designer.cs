namespace EmployeeUI
{
    partial class PayrollUC
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlSalaryContainer = new System.Windows.Forms.Panel();
            this.dgvAttendance = new System.Windows.Forms.DataGridView();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.txtMName = new System.Windows.Forms.TextBox();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.lblMName = new System.Windows.Forms.Label();
            this.lblFName = new System.Windows.Forms.Label();
            this.lblLName = new System.Windows.Forms.Label();
            this.dtpMonth = new System.Windows.Forms.DateTimePicker();
            this.lblMonth = new System.Windows.Forms.Label();
            this.cboEmployeeID = new System.Windows.Forms.ComboBox();
            this.lblEmpId = new System.Windows.Forms.Label();
            this.btnSalary = new System.Windows.Forms.Button();
            this.txtPosition = new System.Windows.Forms.TextBox();
            this.lblPosition = new System.Windows.Forms.Label();
            this.txtHourlyRate = new System.Windows.Forms.TextBox();
            this.lblHourlyRate = new System.Windows.Forms.Label();
            this.txtTotalHoursWorked = new System.Windows.Forms.TextBox();
            this.lblHoursWorked = new System.Windows.Forms.Label();
            this.txtTotalSalary = new System.Windows.Forms.TextBox();
            this.lblTotalSalary = new System.Windows.Forms.Label();
            this.pnlSalaryContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendance)).BeginInit();
            this.pnlContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSalaryContainer
            // 
            this.pnlSalaryContainer.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnlSalaryContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSalaryContainer.Controls.Add(this.dgvAttendance);
            this.pnlSalaryContainer.Location = new System.Drawing.Point(330, 23);
            this.pnlSalaryContainer.Margin = new System.Windows.Forms.Padding(4);
            this.pnlSalaryContainer.Name = "pnlSalaryContainer";
            this.pnlSalaryContainer.Size = new System.Drawing.Size(578, 600);
            this.pnlSalaryContainer.TabIndex = 17;
            // 
            // dgvAttendance
            // 
            this.dgvAttendance.AllowUserToAddRows = false;
            this.dgvAttendance.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAttendance.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvAttendance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAttendance.EnableHeadersVisualStyles = false;
            this.dgvAttendance.Location = new System.Drawing.Point(21, 55);
            this.dgvAttendance.Margin = new System.Windows.Forms.Padding(4);
            this.dgvAttendance.Name = "dgvAttendance";
            this.dgvAttendance.ReadOnly = true;
            this.dgvAttendance.RowHeadersVisible = false;
            this.dgvAttendance.RowHeadersWidth = 51;
            this.dgvAttendance.Size = new System.Drawing.Size(535, 475);
            this.dgvAttendance.TabIndex = 0;
            // 
            // pnlContainer
            // 
            this.pnlContainer.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnlContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlContainer.Controls.Add(this.txtTotalSalary);
            this.pnlContainer.Controls.Add(this.lblTotalSalary);
            this.pnlContainer.Controls.Add(this.txtTotalHoursWorked);
            this.pnlContainer.Controls.Add(this.lblHoursWorked);
            this.pnlContainer.Controls.Add(this.txtHourlyRate);
            this.pnlContainer.Controls.Add(this.lblHourlyRate);
            this.pnlContainer.Controls.Add(this.txtPosition);
            this.pnlContainer.Controls.Add(this.lblPosition);
            this.pnlContainer.Controls.Add(this.txtMName);
            this.pnlContainer.Controls.Add(this.txtFName);
            this.pnlContainer.Controls.Add(this.txtLName);
            this.pnlContainer.Controls.Add(this.lblMName);
            this.pnlContainer.Controls.Add(this.lblFName);
            this.pnlContainer.Controls.Add(this.lblLName);
            this.pnlContainer.Controls.Add(this.dtpMonth);
            this.pnlContainer.Controls.Add(this.lblMonth);
            this.pnlContainer.Controls.Add(this.cboEmployeeID);
            this.pnlContainer.Controls.Add(this.lblEmpId);
            this.pnlContainer.Controls.Add(this.btnSalary);
            this.pnlContainer.Location = new System.Drawing.Point(24, 23);
            this.pnlContainer.Margin = new System.Windows.Forms.Padding(4);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(298, 600);
            this.pnlContainer.TabIndex = 16;
            // 
            // txtMName
            // 
            this.txtMName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMName.Location = new System.Drawing.Point(141, 242);
            this.txtMName.Name = "txtMName";
            this.txtMName.ReadOnly = true;
            this.txtMName.Size = new System.Drawing.Size(141, 27);
            this.txtMName.TabIndex = 24;
            // 
            // txtFName
            // 
            this.txtFName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFName.Location = new System.Drawing.Point(141, 195);
            this.txtFName.Name = "txtFName";
            this.txtFName.ReadOnly = true;
            this.txtFName.Size = new System.Drawing.Size(141, 27);
            this.txtFName.TabIndex = 23;
            // 
            // txtLName
            // 
            this.txtLName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLName.Location = new System.Drawing.Point(141, 146);
            this.txtLName.Name = "txtLName";
            this.txtLName.ReadOnly = true;
            this.txtLName.Size = new System.Drawing.Size(141, 27);
            this.txtLName.TabIndex = 22;
            // 
            // lblMName
            // 
            this.lblMName.AutoSize = true;
            this.lblMName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMName.Location = new System.Drawing.Point(2, 244);
            this.lblMName.Name = "lblMName";
            this.lblMName.Size = new System.Drawing.Size(133, 25);
            this.lblMName.TabIndex = 21;
            this.lblMName.Text = "Middle Name:";
            // 
            // lblFName
            // 
            this.lblFName.AutoSize = true;
            this.lblFName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFName.Location = new System.Drawing.Point(23, 195);
            this.lblFName.Name = "lblFName";
            this.lblFName.Size = new System.Drawing.Size(112, 25);
            this.lblFName.TabIndex = 20;
            this.lblFName.Text = "First Name:";
            // 
            // lblLName
            // 
            this.lblLName.AutoSize = true;
            this.lblLName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLName.Location = new System.Drawing.Point(23, 148);
            this.lblLName.Name = "lblLName";
            this.lblLName.Size = new System.Drawing.Size(112, 25);
            this.lblLName.TabIndex = 19;
            this.lblLName.Text = "Last Name:";
            // 
            // dtpMonth
            // 
            this.dtpMonth.CustomFormat = "MM/yyy";
            this.dtpMonth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpMonth.Location = new System.Drawing.Point(141, 55);
            this.dtpMonth.Name = "dtpMonth";
            this.dtpMonth.ShowUpDown = true;
            this.dtpMonth.Size = new System.Drawing.Size(141, 22);
            this.dtpMonth.TabIndex = 18;
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonth.Location = new System.Drawing.Point(62, 55);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(73, 25);
            this.lblMonth.TabIndex = 17;
            this.lblMonth.Text = "Month:";
            // 
            // cboEmployeeID
            // 
            this.cboEmployeeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboEmployeeID.FormattingEnabled = true;
            this.cboEmployeeID.Location = new System.Drawing.Point(141, 99);
            this.cboEmployeeID.Name = "cboEmployeeID";
            this.cboEmployeeID.Size = new System.Drawing.Size(141, 28);
            this.cboEmployeeID.TabIndex = 16;
            this.cboEmployeeID.SelectedIndexChanged += new System.EventHandler(this.cboEmployeeID_SelectedIndexChanged);
            // 
            // lblEmpId
            // 
            this.lblEmpId.AutoSize = true;
            this.lblEmpId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpId.Location = new System.Drawing.Point(6, 99);
            this.lblEmpId.Name = "lblEmpId";
            this.lblEmpId.Size = new System.Drawing.Size(129, 25);
            this.lblEmpId.TabIndex = 15;
            this.lblEmpId.Text = "Employee ID:";
            // 
            // btnSalary
            // 
            this.btnSalary.BackColor = System.Drawing.Color.Navy;
            this.btnSalary.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalary.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSalary.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSalary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalary.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSalary.Location = new System.Drawing.Point(78, 465);
            this.btnSalary.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalary.Name = "btnSalary";
            this.btnSalary.Size = new System.Drawing.Size(120, 34);
            this.btnSalary.TabIndex = 14;
            this.btnSalary.Text = "Calculate";
            this.btnSalary.UseVisualStyleBackColor = false;
            this.btnSalary.Click += new System.EventHandler(this.btnSalary_Click);
            // 
            // txtPosition
            // 
            this.txtPosition.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPosition.Location = new System.Drawing.Point(141, 286);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.ReadOnly = true;
            this.txtPosition.Size = new System.Drawing.Size(141, 27);
            this.txtPosition.TabIndex = 26;
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosition.Location = new System.Drawing.Point(48, 288);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(87, 25);
            this.lblPosition.TabIndex = 25;
            this.lblPosition.Text = "Position:";
            // 
            // txtHourlyRate
            // 
            this.txtHourlyRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHourlyRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHourlyRate.Location = new System.Drawing.Point(141, 332);
            this.txtHourlyRate.Name = "txtHourlyRate";
            this.txtHourlyRate.ReadOnly = true;
            this.txtHourlyRate.Size = new System.Drawing.Size(141, 27);
            this.txtHourlyRate.TabIndex = 28;
            // 
            // lblHourlyRate
            // 
            this.lblHourlyRate.AutoSize = true;
            this.lblHourlyRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHourlyRate.Location = new System.Drawing.Point(16, 332);
            this.lblHourlyRate.Name = "lblHourlyRate";
            this.lblHourlyRate.Size = new System.Drawing.Size(119, 25);
            this.lblHourlyRate.TabIndex = 27;
            this.lblHourlyRate.Text = "Hourly Rate:";
            // 
            // txtTotalHoursWorked
            // 
            this.txtTotalHoursWorked.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalHoursWorked.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalHoursWorked.Location = new System.Drawing.Point(141, 377);
            this.txtTotalHoursWorked.Name = "txtTotalHoursWorked";
            this.txtTotalHoursWorked.ReadOnly = true;
            this.txtTotalHoursWorked.Size = new System.Drawing.Size(141, 27);
            this.txtTotalHoursWorked.TabIndex = 30;
            // 
            // lblHoursWorked
            // 
            this.lblHoursWorked.AutoSize = true;
            this.lblHoursWorked.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoursWorked.Location = new System.Drawing.Point(-9, 379);
            this.lblHoursWorked.Name = "lblHoursWorked";
            this.lblHoursWorked.Size = new System.Drawing.Size(144, 25);
            this.lblHoursWorked.TabIndex = 29;
            this.lblHoursWorked.Text = "Hours Worked:";
            // 
            // txtTotalSalary
            // 
            this.txtTotalSalary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalSalary.Location = new System.Drawing.Point(141, 420);
            this.txtTotalSalary.Name = "txtTotalSalary";
            this.txtTotalSalary.ReadOnly = true;
            this.txtTotalSalary.Size = new System.Drawing.Size(141, 27);
            this.txtTotalSalary.TabIndex = 32;
            // 
            // lblTotalSalary
            // 
            this.lblTotalSalary.AutoSize = true;
            this.lblTotalSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSalary.Location = new System.Drawing.Point(12, 420);
            this.lblTotalSalary.Name = "lblTotalSalary";
            this.lblTotalSalary.Size = new System.Drawing.Size(123, 25);
            this.lblTotalSalary.TabIndex = 31;
            this.lblTotalSalary.Text = "Total Salary:";
            // 
            // PayrollUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlSalaryContainer);
            this.Controls.Add(this.pnlContainer);
            this.Name = "PayrollUC";
            this.Size = new System.Drawing.Size(928, 647);
            this.pnlSalaryContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendance)).EndInit();
            this.pnlContainer.ResumeLayout(false);
            this.pnlContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSalaryContainer;
        private System.Windows.Forms.DataGridView dgvAttendance;
        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.TextBox txtMName;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.Label lblMName;
        private System.Windows.Forms.Label lblFName;
        private System.Windows.Forms.Label lblLName;
        private System.Windows.Forms.DateTimePicker dtpMonth;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.ComboBox cboEmployeeID;
        private System.Windows.Forms.Label lblEmpId;
        private System.Windows.Forms.Button btnSalary;
        private System.Windows.Forms.TextBox txtHourlyRate;
        private System.Windows.Forms.Label lblHourlyRate;
        private System.Windows.Forms.TextBox txtPosition;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.TextBox txtTotalSalary;
        private System.Windows.Forms.Label lblTotalSalary;
        private System.Windows.Forms.TextBox txtTotalHoursWorked;
        private System.Windows.Forms.Label lblHoursWorked;
    }
}
