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
            this.btnAttendance = new System.Windows.Forms.Button();
            this.lblSignOut = new System.Windows.Forms.Label();
            this.pnlOptions = new System.Windows.Forms.Panel();
            this.picSignout = new System.Windows.Forms.PictureBox();
            this.pnlEmp = new System.Windows.Forms.Panel();
            this.lblID = new System.Windows.Forms.Label();
            this.lblMName = new System.Windows.Forms.Label();
            this.lblFName = new System.Windows.Forms.Label();
            this.lblPosition = new System.Windows.Forms.Label();
            this.picEmpImg = new System.Windows.Forms.PictureBox();
            this.lblLName = new System.Windows.Forms.Label();
            this.pnlEmpDetails = new System.Windows.Forms.Panel();
            this.employeeDetails1 = new EmployeeUI.EmployeeDetails();
            this.attendance1 = new EmployeeUI.AttendanceUC();
            this.picClose = new System.Windows.Forms.PictureBox();
            this.pnlOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSignout)).BeginInit();
            this.pnlEmp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEmpImg)).BeginInit();
            this.pnlEmpDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
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
            this.btnProfile.Location = new System.Drawing.Point(0, 139);
            this.btnProfile.Margin = new System.Windows.Forms.Padding(4);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(256, 82);
            this.btnProfile.TabIndex = 0;
            this.btnProfile.Text = "Profile";
            this.btnProfile.UseVisualStyleBackColor = false;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // btnAttendance
            // 
            this.btnAttendance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnAttendance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAttendance.FlatAppearance.BorderSize = 0;
            this.btnAttendance.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAttendance.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAttendance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAttendance.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAttendance.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAttendance.Location = new System.Drawing.Point(0, 220);
            this.btnAttendance.Margin = new System.Windows.Forms.Padding(4);
            this.btnAttendance.Name = "btnAttendance";
            this.btnAttendance.Size = new System.Drawing.Size(256, 82);
            this.btnAttendance.TabIndex = 1;
            this.btnAttendance.Text = "Attendance";
            this.btnAttendance.UseVisualStyleBackColor = false;
            this.btnAttendance.Click += new System.EventHandler(this.btnAttendance_Click);
            // 
            // lblSignOut
            // 
            this.lblSignOut.AutoSize = true;
            this.lblSignOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSignOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignOut.ForeColor = System.Drawing.SystemColors.Control;
            this.lblSignOut.Location = new System.Drawing.Point(80, 625);
            this.lblSignOut.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSignOut.Name = "lblSignOut";
            this.lblSignOut.Size = new System.Drawing.Size(127, 31);
            this.lblSignOut.TabIndex = 1;
            this.lblSignOut.Text = "Sign Out";
            this.lblSignOut.Click += new System.EventHandler(this.lblSignOut_Click);
            this.lblSignOut.MouseEnter += new System.EventHandler(this.lblSignOut_MouseEnter_1);
            this.lblSignOut.MouseLeave += new System.EventHandler(this.lblSignOut_MouseLeave_1);
            // 
            // pnlOptions
            // 
            this.pnlOptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.pnlOptions.Controls.Add(this.picSignout);
            this.pnlOptions.Controls.Add(this.lblSignOut);
            this.pnlOptions.Controls.Add(this.btnAttendance);
            this.pnlOptions.Controls.Add(this.btnProfile);
            this.pnlOptions.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlOptions.Location = new System.Drawing.Point(0, 0);
            this.pnlOptions.Margin = new System.Windows.Forms.Padding(4);
            this.pnlOptions.Name = "pnlOptions";
            this.pnlOptions.Size = new System.Drawing.Size(256, 695);
            this.pnlOptions.TabIndex = 0;
            // 
            // picSignout
            // 
            this.picSignout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picSignout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picSignout.Image = global::EmployeeUI.Properties.Resources.icons8_logout_24;
            this.picSignout.Location = new System.Drawing.Point(48, 623);
            this.picSignout.Margin = new System.Windows.Forms.Padding(4);
            this.picSignout.Name = "picSignout";
            this.picSignout.Size = new System.Drawing.Size(36, 34);
            this.picSignout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSignout.TabIndex = 3;
            this.picSignout.TabStop = false;
            this.picSignout.Click += new System.EventHandler(this.picSignout_Click);
            // 
            // pnlEmp
            // 
            this.pnlEmp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.pnlEmp.Controls.Add(this.picClose);
            this.pnlEmp.Controls.Add(this.lblID);
            this.pnlEmp.Controls.Add(this.lblMName);
            this.pnlEmp.Controls.Add(this.lblFName);
            this.pnlEmp.Controls.Add(this.lblPosition);
            this.pnlEmp.Controls.Add(this.picEmpImg);
            this.pnlEmp.Controls.Add(this.lblLName);
            this.pnlEmp.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEmp.Location = new System.Drawing.Point(256, 0);
            this.pnlEmp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlEmp.Name = "pnlEmp";
            this.pnlEmp.Size = new System.Drawing.Size(928, 303);
            this.pnlEmp.TabIndex = 3;
            // 
            // lblID
            // 
            this.lblID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblID.Location = new System.Drawing.Point(23, 264);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(39, 39);
            this.lblID.TabIndex = 5;
            this.lblID.Text = "0";
            // 
            // lblMName
            // 
            this.lblMName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblMName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblMName.Location = new System.Drawing.Point(721, 48);
            this.lblMName.Name = "lblMName";
            this.lblMName.Size = new System.Drawing.Size(195, 58);
            this.lblMName.TabIndex = 4;
            this.lblMName.Text = "MName";
            this.lblMName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFName
            // 
            this.lblFName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblFName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblFName.Location = new System.Drawing.Point(522, 48);
            this.lblFName.Name = "lblFName";
            this.lblFName.Size = new System.Drawing.Size(195, 58);
            this.lblFName.TabIndex = 3;
            this.lblFName.Text = "FName";
            this.lblFName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPosition
            // 
            this.lblPosition.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosition.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPosition.Location = new System.Drawing.Point(323, 110);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(407, 39);
            this.lblPosition.TabIndex = 2;
            this.lblPosition.Text = "Position";
            // 
            // picEmpImg
            // 
            this.picEmpImg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.picEmpImg.Image = global::EmployeeUI.Properties.Resources.icons8_person_64__1_;
            this.picEmpImg.Location = new System.Drawing.Point(52, 33);
            this.picEmpImg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picEmpImg.Name = "picEmpImg";
            this.picEmpImg.Size = new System.Drawing.Size(223, 215);
            this.picEmpImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picEmpImg.TabIndex = 0;
            this.picEmpImg.TabStop = false;
            // 
            // lblLName
            // 
            this.lblLName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblLName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblLName.Location = new System.Drawing.Point(322, 48);
            this.lblLName.Name = "lblLName";
            this.lblLName.Size = new System.Drawing.Size(195, 58);
            this.lblLName.TabIndex = 1;
            this.lblLName.Text = "LName";
            this.lblLName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlEmpDetails
            // 
            this.pnlEmpDetails.Controls.Add(this.employeeDetails1);
            this.pnlEmpDetails.Controls.Add(this.attendance1);
            this.pnlEmpDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlEmpDetails.Location = new System.Drawing.Point(256, 303);
            this.pnlEmpDetails.Margin = new System.Windows.Forms.Padding(4);
            this.pnlEmpDetails.Name = "pnlEmpDetails";
            this.pnlEmpDetails.Size = new System.Drawing.Size(928, 392);
            this.pnlEmpDetails.TabIndex = 4;
            // 
            // employeeDetails1
            // 
            this.employeeDetails1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.employeeDetails1.Location = new System.Drawing.Point(0, 0);
            this.employeeDetails1.Margin = new System.Windows.Forms.Padding(5);
            this.employeeDetails1.Name = "employeeDetails1";
            this.employeeDetails1.Size = new System.Drawing.Size(925, 396);
            this.employeeDetails1.TabIndex = 0;
            // 
            // attendance1
            // 
            this.attendance1.Location = new System.Drawing.Point(0, 0);
            this.attendance1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.attendance1.Name = "attendance1";
            this.attendance1.Size = new System.Drawing.Size(925, 396);
            this.attendance1.TabIndex = 1;
            this.attendance1.Visible = false;
            // 
            // picClose
            // 
            this.picClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picClose.Image = global::EmployeeUI.Properties.Resources.icons8_close_50;
            this.picClose.Location = new System.Drawing.Point(883, 13);
            this.picClose.Margin = new System.Windows.Forms.Padding(4);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(32, 25);
            this.picClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picClose.TabIndex = 6;
            this.picClose.TabStop = false;
            this.picClose.Click += new System.EventHandler(this.picClose_Click);
            // 
            // EmployeeInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 695);
            this.Controls.Add(this.pnlEmpDetails);
            this.Controls.Add(this.pnlEmp);
            this.Controls.Add(this.pnlOptions);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "EmployeeInfo";
            this.Text = "EmployeeInfo";
            this.Load += new System.EventHandler(this.EmployeeInfo_Load);
            this.pnlOptions.ResumeLayout(false);
            this.pnlOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSignout)).EndInit();
            this.pnlEmp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picEmpImg)).EndInit();
            this.pnlEmpDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnAttendance;
        private System.Windows.Forms.Label lblSignOut;
        private System.Windows.Forms.PictureBox picSignout;
        private System.Windows.Forms.Panel pnlOptions;
        private System.Windows.Forms.Panel pnlEmp;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.PictureBox picEmpImg;
        private System.Windows.Forms.Label lblLName;
        private System.Windows.Forms.Panel pnlEmpDetails;
        private EmployeeDetails employeeDetails1;
        private AttendanceUC attendance1;
        private System.Windows.Forms.Label lblFName;
        private System.Windows.Forms.Label lblMName;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.PictureBox picClose;
    }
}