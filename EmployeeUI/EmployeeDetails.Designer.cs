namespace EmployeeUI
{
    partial class EmployeeDetails
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
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblPhoneNumberLabel = new System.Windows.Forms.Label();
            this.pnlPhoneNumLabel = new System.Windows.Forms.Panel();
            this.lblEmail = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblEmailLabel = new System.Windows.Forms.Label();
            this.pnlEmailLabel = new System.Windows.Forms.Panel();
            this.pnlDoB = new System.Windows.Forms.Panel();
            this.dtpDoB = new System.Windows.Forms.DateTimePicker();
            this.lblDoBLabel = new System.Windows.Forms.Label();
            this.pnlDoBLabel = new System.Windows.Forms.Panel();
            this.lblGender = new System.Windows.Forms.Label();
            this.pnlGender = new System.Windows.Forms.Panel();
            this.lblGenderLabel = new System.Windows.Forms.Label();
            this.pnlGenderLabel = new System.Windows.Forms.Panel();
            this.lblEmployeeID = new System.Windows.Forms.Label();
            this.pnlEmployeeID = new System.Windows.Forms.Panel();
            this.lblEmpIDLabel = new System.Windows.Forms.Label();
            this.pnlPhoneNum = new System.Windows.Forms.Panel();
            this.pnlEmpIDLabel = new System.Windows.Forms.Panel();
            this.pnlPhoneNumLabel.SuspendLayout();
            this.panel6.SuspendLayout();
            this.pnlEmailLabel.SuspendLayout();
            this.pnlDoB.SuspendLayout();
            this.pnlDoBLabel.SuspendLayout();
            this.pnlGender.SuspendLayout();
            this.pnlGenderLabel.SuspendLayout();
            this.pnlEmployeeID.SuspendLayout();
            this.pnlPhoneNum.SuspendLayout();
            this.pnlEmpIDLabel.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNumber.Location = new System.Drawing.Point(75, 14);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(275, 30);
            this.lblPhoneNumber.TabIndex = 1;
            this.lblPhoneNumber.Text = "09694208700";
            this.lblPhoneNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPhoneNumberLabel
            // 
            this.lblPhoneNumberLabel.AutoSize = true;
            this.lblPhoneNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNumberLabel.Location = new System.Drawing.Point(127, 14);
            this.lblPhoneNumberLabel.Name = "lblPhoneNumberLabel";
            this.lblPhoneNumberLabel.Size = new System.Drawing.Size(188, 29);
            this.lblPhoneNumberLabel.TabIndex = 0;
            this.lblPhoneNumberLabel.Text = "Phone Number";
            // 
            // pnlPhoneNumLabel
            // 
            this.pnlPhoneNumLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnlPhoneNumLabel.Controls.Add(this.lblPhoneNumberLabel);
            this.pnlPhoneNumLabel.Location = new System.Drawing.Point(28, 287);
            this.pnlPhoneNumLabel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlPhoneNumLabel.Name = "pnlPhoneNumLabel";
            this.pnlPhoneNumLabel.Size = new System.Drawing.Size(417, 54);
            this.pnlPhoneNumLabel.TabIndex = 15;
            // 
            // lblEmail
            // 
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(11, 11);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(397, 30);
            this.lblEmail.TabIndex = 1;
            this.lblEmail.Text = "sample@gmail.com";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel6.Controls.Add(this.lblEmail);
            this.panel6.Location = new System.Drawing.Point(480, 226);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(417, 54);
            this.panel6.TabIndex = 18;
            // 
            // lblEmailLabel
            // 
            this.lblEmailLabel.AutoSize = true;
            this.lblEmailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailLabel.Location = new System.Drawing.Point(173, 11);
            this.lblEmailLabel.Name = "lblEmailLabel";
            this.lblEmailLabel.Size = new System.Drawing.Size(79, 29);
            this.lblEmailLabel.TabIndex = 0;
            this.lblEmailLabel.Text = "Email";
            // 
            // pnlEmailLabel
            // 
            this.pnlEmailLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnlEmailLabel.Controls.Add(this.lblEmailLabel);
            this.pnlEmailLabel.Location = new System.Drawing.Point(28, 226);
            this.pnlEmailLabel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlEmailLabel.Name = "pnlEmailLabel";
            this.pnlEmailLabel.Size = new System.Drawing.Size(417, 54);
            this.pnlEmailLabel.TabIndex = 14;
            // 
            // pnlDoB
            // 
            this.pnlDoB.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnlDoB.Controls.Add(this.dtpDoB);
            this.pnlDoB.Location = new System.Drawing.Point(480, 170);
            this.pnlDoB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlDoB.Name = "pnlDoB";
            this.pnlDoB.Size = new System.Drawing.Size(417, 54);
            this.pnlDoB.TabIndex = 17;
            // 
            // dtpDoB
            // 
            this.dtpDoB.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDoB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDoB.Location = new System.Drawing.Point(136, 12);
            this.dtpDoB.Name = "dtpDoB";
            this.dtpDoB.Size = new System.Drawing.Size(146, 34);
            this.dtpDoB.TabIndex = 20;
            // 
            // lblDoBLabel
            // 
            this.lblDoBLabel.AutoSize = true;
            this.lblDoBLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoBLabel.Location = new System.Drawing.Point(141, 12);
            this.lblDoBLabel.Name = "lblDoBLabel";
            this.lblDoBLabel.Size = new System.Drawing.Size(157, 29);
            this.lblDoBLabel.TabIndex = 0;
            this.lblDoBLabel.Text = "Date of Birth";
            // 
            // pnlDoBLabel
            // 
            this.pnlDoBLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnlDoBLabel.Controls.Add(this.lblDoBLabel);
            this.pnlDoBLabel.Location = new System.Drawing.Point(28, 170);
            this.pnlDoBLabel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlDoBLabel.Name = "pnlDoBLabel";
            this.pnlDoBLabel.Size = new System.Drawing.Size(417, 54);
            this.pnlDoBLabel.TabIndex = 13;
            // 
            // lblGender
            // 
            this.lblGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(119, 12);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(175, 30);
            this.lblGender.TabIndex = 1;
            this.lblGender.Text = "Fe/Male";
            this.lblGender.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlGender
            // 
            this.pnlGender.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnlGender.Controls.Add(this.lblGender);
            this.pnlGender.Location = new System.Drawing.Point(480, 113);
            this.pnlGender.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlGender.Name = "pnlGender";
            this.pnlGender.Size = new System.Drawing.Size(417, 54);
            this.pnlGender.TabIndex = 16;
            // 
            // lblGenderLabel
            // 
            this.lblGenderLabel.AutoSize = true;
            this.lblGenderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenderLabel.Location = new System.Drawing.Point(163, 12);
            this.lblGenderLabel.Name = "lblGenderLabel";
            this.lblGenderLabel.Size = new System.Drawing.Size(100, 29);
            this.lblGenderLabel.TabIndex = 0;
            this.lblGenderLabel.Text = "Gender";
            // 
            // pnlGenderLabel
            // 
            this.pnlGenderLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnlGenderLabel.Controls.Add(this.lblGenderLabel);
            this.pnlGenderLabel.Location = new System.Drawing.Point(28, 113);
            this.pnlGenderLabel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlGenderLabel.Name = "pnlGenderLabel";
            this.pnlGenderLabel.Size = new System.Drawing.Size(417, 54);
            this.pnlGenderLabel.TabIndex = 11;
            // 
            // lblEmployeeID
            // 
            this.lblEmployeeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeID.Location = new System.Drawing.Point(119, 12);
            this.lblEmployeeID.Name = "lblEmployeeID";
            this.lblEmployeeID.Size = new System.Drawing.Size(181, 30);
            this.lblEmployeeID.TabIndex = 1;
            this.lblEmployeeID.Text = "00001";
            this.lblEmployeeID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlEmployeeID
            // 
            this.pnlEmployeeID.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnlEmployeeID.Controls.Add(this.lblEmployeeID);
            this.pnlEmployeeID.Location = new System.Drawing.Point(480, 57);
            this.pnlEmployeeID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlEmployeeID.Name = "pnlEmployeeID";
            this.pnlEmployeeID.Size = new System.Drawing.Size(417, 54);
            this.pnlEmployeeID.TabIndex = 12;
            // 
            // lblEmpIDLabel
            // 
            this.lblEmpIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpIDLabel.Location = new System.Drawing.Point(127, 12);
            this.lblEmpIDLabel.Name = "lblEmpIDLabel";
            this.lblEmpIDLabel.Size = new System.Drawing.Size(163, 30);
            this.lblEmpIDLabel.TabIndex = 0;
            this.lblEmpIDLabel.Text = "Emlpoyee ID";
            this.lblEmpIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlPhoneNum
            // 
            this.pnlPhoneNum.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnlPhoneNum.Controls.Add(this.lblPhoneNumber);
            this.pnlPhoneNum.Location = new System.Drawing.Point(480, 287);
            this.pnlPhoneNum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlPhoneNum.Name = "pnlPhoneNum";
            this.pnlPhoneNum.Size = new System.Drawing.Size(417, 54);
            this.pnlPhoneNum.TabIndex = 19;
            // 
            // pnlEmpIDLabel
            // 
            this.pnlEmpIDLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnlEmpIDLabel.Controls.Add(this.lblEmpIDLabel);
            this.pnlEmpIDLabel.Location = new System.Drawing.Point(28, 57);
            this.pnlEmpIDLabel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlEmpIDLabel.Name = "pnlEmpIDLabel";
            this.pnlEmpIDLabel.Size = new System.Drawing.Size(417, 54);
            this.pnlEmpIDLabel.TabIndex = 10;
            // 
            // EmployeeDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.pnlPhoneNumLabel);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.pnlEmailLabel);
            this.Controls.Add(this.pnlDoB);
            this.Controls.Add(this.pnlDoBLabel);
            this.Controls.Add(this.pnlGender);
            this.Controls.Add(this.pnlGenderLabel);
            this.Controls.Add(this.pnlEmployeeID);
            this.Controls.Add(this.pnlPhoneNum);
            this.Controls.Add(this.pnlEmpIDLabel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EmployeeDetails";
            this.Size = new System.Drawing.Size(925, 396);
            this.Load += new System.EventHandler(this.EmployeeDetails_Load);
            this.pnlPhoneNumLabel.ResumeLayout(false);
            this.pnlPhoneNumLabel.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.pnlEmailLabel.ResumeLayout(false);
            this.pnlEmailLabel.PerformLayout();
            this.pnlDoB.ResumeLayout(false);
            this.pnlDoBLabel.ResumeLayout(false);
            this.pnlDoBLabel.PerformLayout();
            this.pnlGender.ResumeLayout(false);
            this.pnlGenderLabel.ResumeLayout(false);
            this.pnlGenderLabel.PerformLayout();
            this.pnlEmployeeID.ResumeLayout(false);
            this.pnlPhoneNum.ResumeLayout(false);
            this.pnlEmpIDLabel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label lblPhoneNumberLabel;
        private System.Windows.Forms.Panel pnlPhoneNumLabel;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lblEmailLabel;
        private System.Windows.Forms.Panel pnlEmailLabel;
        private System.Windows.Forms.Panel pnlDoB;
        private System.Windows.Forms.Label lblDoBLabel;
        private System.Windows.Forms.Panel pnlDoBLabel;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Panel pnlGender;
        private System.Windows.Forms.Label lblGenderLabel;
        private System.Windows.Forms.Panel pnlGenderLabel;
        private System.Windows.Forms.Label lblEmployeeID;
        private System.Windows.Forms.Panel pnlEmployeeID;
        private System.Windows.Forms.Label lblEmpIDLabel;
        private System.Windows.Forms.Panel pnlPhoneNum;
        private System.Windows.Forms.Panel pnlEmpIDLabel;
        private System.Windows.Forms.DateTimePicker dtpDoB;
    }
}
