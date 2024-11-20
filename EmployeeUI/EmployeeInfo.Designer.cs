namespace EmployeeUI
{
    partial class EmployeeInfo
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
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.lblSignOut = new System.Windows.Forms.Label();
            this.pnlOptions = new System.Windows.Forms.Panel();
            this.picSignout = new System.Windows.Forms.PictureBox();
            this.pnlEmp = new System.Windows.Forms.Panel();
            this.lblEmpName = new System.Windows.Forms.Label();
            this.picEmpImg = new System.Windows.Forms.PictureBox();
            this.lblPosition = new System.Windows.Forms.Label();
            this.pnlEmpDetails = new System.Windows.Forms.Panel();
            this.employeeDetails1 = new EmployeeUI.EmployeeDetails();
            this.attendance1 = new EmployeeUI.Attendance();
            this.pnlOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSignout)).BeginInit();
            this.pnlEmp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEmpImg)).BeginInit();
            this.pnlEmpDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnProfile
            // 
            this.btnProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProfile.FlatAppearance.BorderSize = 0;
            this.btnProfile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnProfile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfile.ForeColor = System.Drawing.SystemColors.Control;
            this.btnProfile.Location = new System.Drawing.Point(0, 113);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(192, 67);
            this.btnProfile.TabIndex = 0;
            this.btnProfile.Text = "Profile";
            this.btnProfile.UseVisualStyleBackColor = false;
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnAddEmployee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddEmployee.FlatAppearance.BorderSize = 0;
            this.btnAddEmployee.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAddEmployee.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAddEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEmployee.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAddEmployee.Location = new System.Drawing.Point(0, 179);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(192, 67);
            this.btnAddEmployee.TabIndex = 1;
            this.btnAddEmployee.Text = "Attendance";
            this.btnAddEmployee.UseVisualStyleBackColor = false;
            // 
            // lblSignOut
            // 
            this.lblSignOut.AutoSize = true;
            this.lblSignOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSignOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignOut.ForeColor = System.Drawing.SystemColors.Control;
            this.lblSignOut.Location = new System.Drawing.Point(60, 508);
            this.lblSignOut.Name = "lblSignOut";
            this.lblSignOut.Size = new System.Drawing.Size(103, 25);
            this.lblSignOut.TabIndex = 1;
            this.lblSignOut.Text = "Sign Out";
            // 
            // pnlOptions
            // 
            this.pnlOptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.pnlOptions.Controls.Add(this.picSignout);
            this.pnlOptions.Controls.Add(this.lblSignOut);
            this.pnlOptions.Controls.Add(this.btnAddEmployee);
            this.pnlOptions.Controls.Add(this.btnProfile);
            this.pnlOptions.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlOptions.Location = new System.Drawing.Point(0, 0);
            this.pnlOptions.Name = "pnlOptions";
            this.pnlOptions.Size = new System.Drawing.Size(192, 565);
            this.pnlOptions.TabIndex = 0;
            // 
            // picSignout
            // 
            this.picSignout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picSignout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picSignout.Image = global::EmployeeUI.Properties.Resources.icons8_logout_24;
            this.picSignout.Location = new System.Drawing.Point(36, 506);
            this.picSignout.Name = "picSignout";
            this.picSignout.Size = new System.Drawing.Size(27, 28);
            this.picSignout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSignout.TabIndex = 3;
            this.picSignout.TabStop = false;
            // 
            // pnlEmp
            // 
            this.pnlEmp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.pnlEmp.Controls.Add(this.lblPosition);
            this.pnlEmp.Controls.Add(this.picEmpImg);
            this.pnlEmp.Controls.Add(this.lblEmpName);
            this.pnlEmp.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEmp.Location = new System.Drawing.Point(192, 0);
            this.pnlEmp.Margin = new System.Windows.Forms.Padding(2);
            this.pnlEmp.Name = "pnlEmp";
            this.pnlEmp.Size = new System.Drawing.Size(696, 246);
            this.pnlEmp.TabIndex = 3;
            // 
            // lblEmpName
            // 
            this.lblEmpName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblEmpName.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblEmpName.Location = new System.Drawing.Point(241, 39);
            this.lblEmpName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmpName.Name = "lblEmpName";
            this.lblEmpName.Size = new System.Drawing.Size(429, 47);
            this.lblEmpName.TabIndex = 1;
            this.lblEmpName.Text = "Employee Name";
            // 
            // picEmpImg
            // 
            this.picEmpImg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.picEmpImg.Image = global::EmployeeUI.Properties.Resources.icons8_person_64__1_;
            this.picEmpImg.Location = new System.Drawing.Point(39, 27);
            this.picEmpImg.Margin = new System.Windows.Forms.Padding(2);
            this.picEmpImg.Name = "picEmpImg";
            this.picEmpImg.Size = new System.Drawing.Size(167, 175);
            this.picEmpImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picEmpImg.TabIndex = 0;
            this.picEmpImg.TabStop = false;
            // 
            // lblPosition
            // 
            this.lblPosition.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosition.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPosition.Location = new System.Drawing.Point(242, 89);
            this.lblPosition.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(305, 32);
            this.lblPosition.TabIndex = 2;
            this.lblPosition.Text = "Position";
            // 
            // pnlEmpDetails
            // 
            this.pnlEmpDetails.Controls.Add(this.attendance1);
            this.pnlEmpDetails.Controls.Add(this.employeeDetails1);
            this.pnlEmpDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlEmpDetails.Location = new System.Drawing.Point(192, 246);
            this.pnlEmpDetails.Name = "pnlEmpDetails";
            this.pnlEmpDetails.Size = new System.Drawing.Size(696, 319);
            this.pnlEmpDetails.TabIndex = 4;
            // 
            // employeeDetails1
            // 
            this.employeeDetails1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.employeeDetails1.Location = new System.Drawing.Point(0, 0);
            this.employeeDetails1.Name = "employeeDetails1";
            this.employeeDetails1.Size = new System.Drawing.Size(694, 322);
            this.employeeDetails1.TabIndex = 0;
            // 
            // attendance1
            // 
            this.attendance1.Location = new System.Drawing.Point(0, 0);
            this.attendance1.Margin = new System.Windows.Forms.Padding(2);
            this.attendance1.Name = "attendance1";
            this.attendance1.Size = new System.Drawing.Size(694, 322);
            this.attendance1.TabIndex = 1;
            // 
            // EmployeeInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 565);
            this.Controls.Add(this.pnlEmpDetails);
            this.Controls.Add(this.pnlEmp);
            this.Controls.Add(this.pnlOptions);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "EmployeeInfo";
            this.Text = "EmployeeInfo";
            this.pnlOptions.ResumeLayout(false);
            this.pnlOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSignout)).EndInit();
            this.pnlEmp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picEmpImg)).EndInit();
            this.pnlEmpDetails.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.Label lblSignOut;
        private System.Windows.Forms.PictureBox picSignout;
        private System.Windows.Forms.Panel pnlOptions;
        private System.Windows.Forms.Panel pnlEmp;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.PictureBox picEmpImg;
        private System.Windows.Forms.Label lblEmpName;
        private System.Windows.Forms.Panel pnlEmpDetails;
        private EmployeeDetails employeeDetails1;
        private Attendance attendance1;
    }
}