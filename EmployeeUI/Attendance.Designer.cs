namespace EmployeeUI
{
    partial class Attendance
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
            this.label1 = new System.Windows.Forms.Label();
            this.dtpAttendanceDate = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lblAttendance
            // 
            this.lblAttendance.AutoSize = true;
            this.lblAttendance.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAttendance.Location = new System.Drawing.Point(33, 27);
            this.lblAttendance.Name = "lblAttendance";
            this.lblAttendance.Size = new System.Drawing.Size(162, 31);
            this.lblAttendance.TabIndex = 0;
            this.lblAttendance.Text = "Attendance";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(417, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Date:";
            // 
            // dtpAttendanceDate
            // 
            this.dtpAttendanceDate.Location = new System.Drawing.Point(471, 38);
            this.dtpAttendanceDate.Name = "dtpAttendanceDate";
            this.dtpAttendanceDate.ShowUpDown = true;
            this.dtpAttendanceDate.Size = new System.Drawing.Size(204, 20);
            this.dtpAttendanceDate.TabIndex = 2;
            this.dtpAttendanceDate.ValueChanged += new System.EventHandler(this.dtpAttendanceDate_ValueChanged);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(640, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(35, 100);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(458, 21);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(202, 19);
            this.panel2.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(462, 21);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 100);
            this.panel3.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(458, 57);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(191, 10);
            this.panel4.TabIndex = 5;
            // 
            // Attendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dtpAttendanceDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblAttendance);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Attendance";
            this.Size = new System.Drawing.Size(694, 322);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAttendance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpAttendanceDate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
    }
}
