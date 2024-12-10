namespace EmployeeUI
{
    partial class InactiveEmployees
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.dgvInactEmployees = new System.Windows.Forms.DataGridView();
            this.pnlEmployees = new System.Windows.Forms.Panel();
            this.pnlEmployeeData = new System.Windows.Forms.Panel();
            this.pnlEmployeeDataContainer = new System.Windows.Forms.Panel();
            this.txtHourlyRate = new System.Windows.Forms.TextBox();
            this.lblHourlyRate = new System.Windows.Forms.Label();
            this.txtEmpID = new System.Windows.Forms.TextBox();
            this.lblEmpID = new System.Windows.Forms.Label();
            this.cboPosition = new System.Windows.Forms.ComboBox();
            this.txtMName = new System.Windows.Forms.TextBox();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.lblPosition = new System.Windows.Forms.Label();
            this.lblMName = new System.Windows.Forms.Label();
            this.lblLName = new System.Windows.Forms.Label();
            this.lblFName = new System.Windows.Forms.Label();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnRestore = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInactEmployees)).BeginInit();
            this.pnlEmployees.SuspendLayout();
            this.pnlEmployeeData.SuspendLayout();
            this.pnlEmployeeDataContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Navy;
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnRefresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRefresh.Location = new System.Drawing.Point(730, 9);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(120, 34);
            this.btnRefresh.TabIndex = 23;
            this.btnRefresh.Text = "REFRESH";
            this.btnRefresh.UseVisualStyleBackColor = false;
            // 
            // dgvInactEmployees
            // 
            this.dgvInactEmployees.AllowUserToAddRows = false;
            this.dgvInactEmployees.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInactEmployees.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvInactEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInactEmployees.EnableHeadersVisualStyles = false;
            this.dgvInactEmployees.Location = new System.Drawing.Point(23, 51);
            this.dgvInactEmployees.Margin = new System.Windows.Forms.Padding(4);
            this.dgvInactEmployees.Name = "dgvInactEmployees";
            this.dgvInactEmployees.ReadOnly = true;
            this.dgvInactEmployees.RowHeadersVisible = false;
            this.dgvInactEmployees.RowHeadersWidth = 51;
            this.dgvInactEmployees.Size = new System.Drawing.Size(827, 173);
            this.dgvInactEmployees.TabIndex = 1;
            // 
            // pnlEmployees
            // 
            this.pnlEmployees.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnlEmployees.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlEmployees.Controls.Add(this.btnRefresh);
            this.pnlEmployees.Controls.Add(this.dgvInactEmployees);
            this.pnlEmployees.Location = new System.Drawing.Point(22, 28);
            this.pnlEmployees.Margin = new System.Windows.Forms.Padding(4);
            this.pnlEmployees.Name = "pnlEmployees";
            this.pnlEmployees.Size = new System.Drawing.Size(875, 251);
            this.pnlEmployees.TabIndex = 3;
            // 
            // pnlEmployeeData
            // 
            this.pnlEmployeeData.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnlEmployeeData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlEmployeeData.Controls.Add(this.pnlEmployeeDataContainer);
            this.pnlEmployeeData.Controls.Add(this.btnRestore);
            this.pnlEmployeeData.Location = new System.Drawing.Point(22, 287);
            this.pnlEmployeeData.Margin = new System.Windows.Forms.Padding(4);
            this.pnlEmployeeData.Name = "pnlEmployeeData";
            this.pnlEmployeeData.Size = new System.Drawing.Size(875, 338);
            this.pnlEmployeeData.TabIndex = 4;
            // 
            // pnlEmployeeDataContainer
            // 
            this.pnlEmployeeDataContainer.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlEmployeeDataContainer.Controls.Add(this.txtHourlyRate);
            this.pnlEmployeeDataContainer.Controls.Add(this.lblHourlyRate);
            this.pnlEmployeeDataContainer.Controls.Add(this.txtEmpID);
            this.pnlEmployeeDataContainer.Controls.Add(this.lblEmpID);
            this.pnlEmployeeDataContainer.Controls.Add(this.cboPosition);
            this.pnlEmployeeDataContainer.Controls.Add(this.txtMName);
            this.pnlEmployeeDataContainer.Controls.Add(this.txtLName);
            this.pnlEmployeeDataContainer.Controls.Add(this.txtFName);
            this.pnlEmployeeDataContainer.Controls.Add(this.lblPosition);
            this.pnlEmployeeDataContainer.Controls.Add(this.lblMName);
            this.pnlEmployeeDataContainer.Controls.Add(this.lblLName);
            this.pnlEmployeeDataContainer.Controls.Add(this.lblFName);
            this.pnlEmployeeDataContainer.Controls.Add(this.cboStatus);
            this.pnlEmployeeDataContainer.Controls.Add(this.lblStatus);
            this.pnlEmployeeDataContainer.Location = new System.Drawing.Point(23, 25);
            this.pnlEmployeeDataContainer.Margin = new System.Windows.Forms.Padding(4);
            this.pnlEmployeeDataContainer.Name = "pnlEmployeeDataContainer";
            this.pnlEmployeeDataContainer.Size = new System.Drawing.Size(661, 288);
            this.pnlEmployeeDataContainer.TabIndex = 21;
            // 
            // txtHourlyRate
            // 
            this.txtHourlyRate.BackColor = System.Drawing.SystemColors.Control;
            this.txtHourlyRate.Location = new System.Drawing.Point(478, 84);
            this.txtHourlyRate.Margin = new System.Windows.Forms.Padding(4);
            this.txtHourlyRate.Name = "txtHourlyRate";
            this.txtHourlyRate.ReadOnly = true;
            this.txtHourlyRate.Size = new System.Drawing.Size(164, 22);
            this.txtHourlyRate.TabIndex = 41;
            // 
            // lblHourlyRate
            // 
            this.lblHourlyRate.AutoSize = true;
            this.lblHourlyRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHourlyRate.Location = new System.Drawing.Point(368, 86);
            this.lblHourlyRate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHourlyRate.Name = "lblHourlyRate";
            this.lblHourlyRate.Size = new System.Drawing.Size(103, 20);
            this.lblHourlyRate.TabIndex = 40;
            this.lblHourlyRate.Text = "Hourly Rate:";
            // 
            // txtEmpID
            // 
            this.txtEmpID.BackColor = System.Drawing.SystemColors.Control;
            this.txtEmpID.Enabled = false;
            this.txtEmpID.Location = new System.Drawing.Point(166, 33);
            this.txtEmpID.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmpID.Name = "txtEmpID";
            this.txtEmpID.Size = new System.Drawing.Size(164, 22);
            this.txtEmpID.TabIndex = 39;
            // 
            // lblEmpID
            // 
            this.lblEmpID.AutoSize = true;
            this.lblEmpID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpID.Location = new System.Drawing.Point(49, 33);
            this.lblEmpID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmpID.Name = "lblEmpID";
            this.lblEmpID.Size = new System.Drawing.Size(109, 20);
            this.lblEmpID.TabIndex = 38;
            this.lblEmpID.Text = "Employee ID:";
            // 
            // cboPosition
            // 
            this.cboPosition.BackColor = System.Drawing.SystemColors.Control;
            this.cboPosition.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPosition.FormattingEnabled = true;
            this.cboPosition.Items.AddRange(new object[] {
            "Intern",
            "Junior Developer",
            "Senior Developer",
            "Team Leader",
            "Manager",
            "69"});
            this.cboPosition.Location = new System.Drawing.Point(478, 33);
            this.cboPosition.Margin = new System.Windows.Forms.Padding(4);
            this.cboPosition.Name = "cboPosition";
            this.cboPosition.Size = new System.Drawing.Size(164, 24);
            this.cboPosition.TabIndex = 37;
            // 
            // txtMName
            // 
            this.txtMName.BackColor = System.Drawing.SystemColors.Control;
            this.txtMName.Location = new System.Drawing.Point(166, 185);
            this.txtMName.Margin = new System.Windows.Forms.Padding(4);
            this.txtMName.Name = "txtMName";
            this.txtMName.Size = new System.Drawing.Size(164, 22);
            this.txtMName.TabIndex = 33;
            // 
            // txtLName
            // 
            this.txtLName.BackColor = System.Drawing.SystemColors.Control;
            this.txtLName.Location = new System.Drawing.Point(166, 84);
            this.txtLName.Margin = new System.Windows.Forms.Padding(4);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(164, 22);
            this.txtLName.TabIndex = 32;
            // 
            // txtFName
            // 
            this.txtFName.BackColor = System.Drawing.SystemColors.Control;
            this.txtFName.Location = new System.Drawing.Point(166, 136);
            this.txtFName.Margin = new System.Windows.Forms.Padding(4);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(164, 22);
            this.txtFName.TabIndex = 31;
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosition.Location = new System.Drawing.Point(396, 37);
            this.lblPosition.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(74, 20);
            this.lblPosition.TabIndex = 30;
            this.lblPosition.Text = "Position:";
            // 
            // lblMName
            // 
            this.lblMName.AutoSize = true;
            this.lblMName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMName.Location = new System.Drawing.Point(40, 185);
            this.lblMName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMName.Name = "lblMName";
            this.lblMName.Size = new System.Drawing.Size(112, 20);
            this.lblMName.TabIndex = 26;
            this.lblMName.Text = "Middle Name:";
            // 
            // lblLName
            // 
            this.lblLName.AutoSize = true;
            this.lblLName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLName.Location = new System.Drawing.Point(56, 82);
            this.lblLName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLName.Name = "lblLName";
            this.lblLName.Size = new System.Drawing.Size(96, 20);
            this.lblLName.TabIndex = 25;
            this.lblLName.Text = "Last Name:";
            // 
            // lblFName
            // 
            this.lblFName.AutoSize = true;
            this.lblFName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFName.Location = new System.Drawing.Point(61, 136);
            this.lblFName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFName.Name = "lblFName";
            this.lblFName.Size = new System.Drawing.Size(97, 20);
            this.lblFName.TabIndex = 24;
            this.lblFName.Text = "First Name:";
            // 
            // cboStatus
            // 
            this.cboStatus.BackColor = System.Drawing.SystemColors.Control;
            this.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.cboStatus.Location = new System.Drawing.Point(478, 136);
            this.cboStatus.Margin = new System.Windows.Forms.Padding(4);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(164, 24);
            this.cboStatus.TabIndex = 19;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(408, 136);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(62, 20);
            this.lblStatus.TabIndex = 18;
            this.lblStatus.Text = "Status:";
            // 
            // btnRestore
            // 
            this.btnRestore.BackColor = System.Drawing.Color.Navy;
            this.btnRestore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestore.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnRestore.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnRestore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestore.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestore.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRestore.Location = new System.Drawing.Point(711, 29);
            this.btnRestore.Margin = new System.Windows.Forms.Padding(4);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(139, 43);
            this.btnRestore.TabIndex = 18;
            this.btnRestore.Text = "RESTORE";
            this.btnRestore.UseVisualStyleBackColor = false;
            // 
            // InactiveEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlEmployeeData);
            this.Controls.Add(this.pnlEmployees);
            this.Name = "InactiveEmployees";
            this.Size = new System.Drawing.Size(928, 647);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInactEmployees)).EndInit();
            this.pnlEmployees.ResumeLayout(false);
            this.pnlEmployeeData.ResumeLayout(false);
            this.pnlEmployeeDataContainer.ResumeLayout(false);
            this.pnlEmployeeDataContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView dgvInactEmployees;
        private System.Windows.Forms.Panel pnlEmployees;
        private System.Windows.Forms.Panel pnlEmployeeData;
        private System.Windows.Forms.Panel pnlEmployeeDataContainer;
        private System.Windows.Forms.TextBox txtHourlyRate;
        private System.Windows.Forms.Label lblHourlyRate;
        private System.Windows.Forms.TextBox txtEmpID;
        private System.Windows.Forms.Label lblEmpID;
        private System.Windows.Forms.ComboBox cboPosition;
        private System.Windows.Forms.TextBox txtMName;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Label lblMName;
        private System.Windows.Forms.Label lblLName;
        private System.Windows.Forms.Label lblFName;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnRestore;
    }
}
