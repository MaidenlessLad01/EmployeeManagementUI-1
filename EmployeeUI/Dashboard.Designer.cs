
namespace EmployeeUI
{
    partial class Dashboard
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.picInactEmp = new System.Windows.Forms.PictureBox();
            this.lblInactEmpNum = new System.Windows.Forms.Label();
            this.lblInactEmp = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.picactive = new System.Windows.Forms.PictureBox();
            this.lblActEmpNum = new System.Windows.Forms.Label();
            this.lblactemp = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblAttendance = new System.Windows.Forms.Label();
            this.dgvAttendance = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picInactEmp)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picactive)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendance)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(23, 22);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(875, 194);
            this.panel1.TabIndex = 8;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Navy;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.picInactEmp);
            this.panel6.Controls.Add(this.lblInactEmpNum);
            this.panel6.Controls.Add(this.lblInactEmp);
            this.panel6.Location = new System.Drawing.Point(462, 30);
            this.panel6.Margin = new System.Windows.Forms.Padding(4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(250, 140);
            this.panel6.TabIndex = 6;
            // 
            // picInactEmp
            // 
            this.picInactEmp.BackColor = System.Drawing.Color.Transparent;
            this.picInactEmp.Image = global::EmployeeUI.Properties.Resources.icons8_person_64__1_;
            this.picInactEmp.Location = new System.Drawing.Point(17, 15);
            this.picInactEmp.Margin = new System.Windows.Forms.Padding(4);
            this.picInactEmp.Name = "picInactEmp";
            this.picInactEmp.Size = new System.Drawing.Size(76, 79);
            this.picInactEmp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picInactEmp.TabIndex = 4;
            this.picInactEmp.TabStop = false;
            // 
            // lblInactEmpNum
            // 
            this.lblInactEmpNum.AutoSize = true;
            this.lblInactEmpNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInactEmpNum.ForeColor = System.Drawing.SystemColors.Control;
            this.lblInactEmpNum.Location = new System.Drawing.Point(157, 47);
            this.lblInactEmpNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInactEmpNum.Name = "lblInactEmpNum";
            this.lblInactEmpNum.Size = new System.Drawing.Size(24, 25);
            this.lblInactEmpNum.TabIndex = 2;
            this.lblInactEmpNum.Text = "0";
            // 
            // lblInactEmp
            // 
            this.lblInactEmp.AutoSize = true;
            this.lblInactEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInactEmp.ForeColor = System.Drawing.SystemColors.Control;
            this.lblInactEmp.Location = new System.Drawing.Point(25, 101);
            this.lblInactEmp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInactEmp.Name = "lblInactEmp";
            this.lblInactEmp.Size = new System.Drawing.Size(199, 25);
            this.lblInactEmp.TabIndex = 1;
            this.lblInactEmp.Text = "Inactive Employees";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Navy;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.picactive);
            this.panel2.Controls.Add(this.lblActEmpNum);
            this.panel2.Controls.Add(this.lblactemp);
            this.panel2.Location = new System.Drawing.Point(176, 30);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 140);
            this.panel2.TabIndex = 6;
            // 
            // picactive
            // 
            this.picactive.BackColor = System.Drawing.Color.Transparent;
            this.picactive.Image = global::EmployeeUI.Properties.Resources.icons8_person_64;
            this.picactive.Location = new System.Drawing.Point(17, 17);
            this.picactive.Margin = new System.Windows.Forms.Padding(4);
            this.picactive.Name = "picactive";
            this.picactive.Size = new System.Drawing.Size(77, 64);
            this.picactive.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picactive.TabIndex = 4;
            this.picactive.TabStop = false;
            // 
            // lblActEmpNum
            // 
            this.lblActEmpNum.AutoSize = true;
            this.lblActEmpNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActEmpNum.ForeColor = System.Drawing.SystemColors.Control;
            this.lblActEmpNum.Location = new System.Drawing.Point(161, 47);
            this.lblActEmpNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblActEmpNum.Name = "lblActEmpNum";
            this.lblActEmpNum.Size = new System.Drawing.Size(24, 25);
            this.lblActEmpNum.TabIndex = 2;
            this.lblActEmpNum.Text = "0";
            // 
            // lblactemp
            // 
            this.lblactemp.AutoSize = true;
            this.lblactemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblactemp.ForeColor = System.Drawing.SystemColors.Control;
            this.lblactemp.Location = new System.Drawing.Point(44, 101);
            this.lblactemp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblactemp.Name = "lblactemp";
            this.lblactemp.Size = new System.Drawing.Size(184, 25);
            this.lblactemp.TabIndex = 1;
            this.lblactemp.Text = "Active Employees";
            this.lblactemp.Click += new System.EventHandler(this.label4_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.btnRefresh);
            this.panel4.Controls.Add(this.dtpDate);
            this.panel4.Controls.Add(this.lblDate);
            this.panel4.Controls.Add(this.lblAttendance);
            this.panel4.Controls.Add(this.dgvAttendance);
            this.panel4.Location = new System.Drawing.Point(23, 238);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(875, 377);
            this.panel4.TabIndex = 9;
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
            this.btnRefresh.Location = new System.Drawing.Point(733, 14);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(120, 34);
            this.btnRefresh.TabIndex = 24;
            this.btnRefresh.Text = "REFRESH";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // dtpDate
            // 
            this.dtpDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.Location = new System.Drawing.Point(585, 16);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(131, 27);
            this.dtpDate.TabIndex = 7;
            this.dtpDate.ValueChanged += new System.EventHandler(this.dtpDate_ValueChanged);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(515, 16);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(64, 25);
            this.lblDate.TabIndex = 6;
            this.lblDate.Text = "Date: ";
            // 
            // lblAttendance
            // 
            this.lblAttendance.AutoSize = true;
            this.lblAttendance.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAttendance.Location = new System.Drawing.Point(20, 11);
            this.lblAttendance.Name = "lblAttendance";
            this.lblAttendance.Size = new System.Drawing.Size(192, 38);
            this.lblAttendance.TabIndex = 5;
            this.lblAttendance.Text = "Attendance";
            // 
            // dgvAttendance
            // 
            this.dgvAttendance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAttendance.Location = new System.Drawing.Point(23, 62);
            this.dgvAttendance.Name = "dgvAttendance";
            this.dgvAttendance.RowHeadersWidth = 51;
            this.dgvAttendance.RowTemplate.Height = 24;
            this.dgvAttendance.Size = new System.Drawing.Size(827, 274);
            this.dgvAttendance.TabIndex = 4;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Dashboard";
            this.Size = new System.Drawing.Size(928, 647);
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picInactEmp)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picactive)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendance)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lblInactEmpNum;
        private System.Windows.Forms.Label lblInactEmp;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblActEmpNum;
        private System.Windows.Forms.Label lblactemp;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox picInactEmp;
        private System.Windows.Forms.PictureBox picactive;
        private System.Windows.Forms.DataGridView dgvAttendance;
        private System.Windows.Forms.Label lblAttendance;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Button btnRefresh;
    }
}
