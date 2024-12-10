namespace EmployeeUI
{
    partial class AttendanceUC
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
            this.lblAttendance = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.dtpAttendanceDate = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblTimeIn = new System.Windows.Forms.Label();
            this.btnTimeIn = new System.Windows.Forms.Button();
            this.btnTimeOut = new System.Windows.Forms.Button();
            this.lblTimeOut = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblAttendance
            // 
            this.lblAttendance.AutoSize = true;
            this.lblAttendance.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAttendance.Location = new System.Drawing.Point(44, 33);
            this.lblAttendance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAttendance.Name = "lblAttendance";
            this.lblAttendance.Size = new System.Drawing.Size(199, 39);
            this.lblAttendance.TabIndex = 0;
            this.lblAttendance.Text = "Attendance";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(556, 46);
            this.lblDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(59, 25);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "Date:";
            // 
            // dtpAttendanceDate
            // 
            this.dtpAttendanceDate.Location = new System.Drawing.Point(628, 47);
            this.dtpAttendanceDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpAttendanceDate.Name = "dtpAttendanceDate";
            this.dtpAttendanceDate.Size = new System.Drawing.Size(238, 22);
            this.dtpAttendanceDate.TabIndex = 2;
            this.dtpAttendanceDate.ValueChanged += new System.EventHandler(this.dtpAttendanceDate_ValueChanged);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(611, 26);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(269, 23);
            this.panel2.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(616, 26);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(17, 68);
            this.panel3.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(611, 70);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(255, 12);
            this.panel4.TabIndex = 5;
            // 
            // lblTimeIn
            // 
            this.lblTimeIn.AutoSize = true;
            this.lblTimeIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeIn.Location = new System.Drawing.Point(296, 173);
            this.lblTimeIn.Name = "lblTimeIn";
            this.lblTimeIn.Size = new System.Drawing.Size(101, 29);
            this.lblTimeIn.TabIndex = 7;
            this.lblTimeIn.Text = "Time In";
            // 
            // btnTimeIn
            // 
            this.btnTimeIn.BackColor = System.Drawing.Color.Navy;
            this.btnTimeIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimeIn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnTimeIn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnTimeIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimeIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimeIn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTimeIn.Location = new System.Drawing.Point(278, 214);
            this.btnTimeIn.Margin = new System.Windows.Forms.Padding(4);
            this.btnTimeIn.Name = "btnTimeIn";
            this.btnTimeIn.Size = new System.Drawing.Size(139, 48);
            this.btnTimeIn.TabIndex = 8;
            this.btnTimeIn.Text = "Time In";
            this.btnTimeIn.UseMnemonic = false;
            this.btnTimeIn.UseVisualStyleBackColor = false;
            this.btnTimeIn.Click += new System.EventHandler(this.btnTimeIn_Click);
            // 
            // btnTimeOut
            // 
            this.btnTimeOut.BackColor = System.Drawing.Color.Navy;
            this.btnTimeOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimeOut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnTimeOut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnTimeOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimeOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimeOut.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTimeOut.Location = new System.Drawing.Point(486, 214);
            this.btnTimeOut.Margin = new System.Windows.Forms.Padding(4);
            this.btnTimeOut.Name = "btnTimeOut";
            this.btnTimeOut.Size = new System.Drawing.Size(139, 48);
            this.btnTimeOut.TabIndex = 14;
            this.btnTimeOut.Text = "Time Out";
            this.btnTimeOut.UseMnemonic = false;
            this.btnTimeOut.UseVisualStyleBackColor = false;
            this.btnTimeOut.Click += new System.EventHandler(this.btnTimeOut_Click);
            // 
            // lblTimeOut
            // 
            this.lblTimeOut.AutoSize = true;
            this.lblTimeOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeOut.Location = new System.Drawing.Point(494, 173);
            this.lblTimeOut.Name = "lblTimeOut";
            this.lblTimeOut.Size = new System.Drawing.Size(121, 29);
            this.lblTimeOut.TabIndex = 13;
            this.lblTimeOut.Text = "Time Out";
            // 
            // AttendanceUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnTimeOut);
            this.Controls.Add(this.lblTimeOut);
            this.Controls.Add(this.btnTimeIn);
            this.Controls.Add(this.lblTimeIn);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dtpAttendanceDate);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblAttendance);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AttendanceUC";
            this.Size = new System.Drawing.Size(925, 396);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAttendance;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtpAttendanceDate;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblTimeIn;
        private System.Windows.Forms.Button btnTimeIn;
        private System.Windows.Forms.Button btnTimeOut;
        private System.Windows.Forms.Label lblTimeOut;
    }
}
