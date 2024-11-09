
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblTtlEmpNum = new System.Windows.Forms.Label();
            this.lblTotalEmployees = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblInactEmpNum = new System.Windows.Forms.Label();
            this.lblInactEmp = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblactemp = new System.Windows.Forms.Label();
            this.lblActEmpNum = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.picInactEmp = new System.Windows.Forms.PictureBox();
            this.picactive = new System.Windows.Forms.PictureBox();
            this.picTtlEmp = new System.Windows.Forms.PictureBox();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picInactEmp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picactive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTtlEmp)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Navy;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.picTtlEmp);
            this.panel3.Controls.Add(this.lblTtlEmpNum);
            this.panel3.Controls.Add(this.lblTotalEmployees);
            this.panel3.Location = new System.Drawing.Point(15, 24);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(188, 114);
            this.panel3.TabIndex = 5;
            // 
            // lblTtlEmpNum
            // 
            this.lblTtlEmpNum.AutoSize = true;
            this.lblTtlEmpNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTtlEmpNum.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTtlEmpNum.Location = new System.Drawing.Point(127, 38);
            this.lblTtlEmpNum.Name = "lblTtlEmpNum";
            this.lblTtlEmpNum.Size = new System.Drawing.Size(19, 20);
            this.lblTtlEmpNum.TabIndex = 2;
            this.lblTtlEmpNum.Text = "0";
            // 
            // lblTotalEmployees
            // 
            this.lblTotalEmployees.AutoSize = true;
            this.lblTotalEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalEmployees.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTotalEmployees.Location = new System.Drawing.Point(43, 82);
            this.lblTotalEmployees.Name = "lblTotalEmployees";
            this.lblTotalEmployees.Size = new System.Drawing.Size(141, 20);
            this.lblTotalEmployees.TabIndex = 1;
            this.lblTotalEmployees.Text = "Total Employees";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(17, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(657, 158);
            this.panel1.TabIndex = 8;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Navy;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.picInactEmp);
            this.panel6.Controls.Add(this.lblInactEmpNum);
            this.panel6.Controls.Add(this.lblInactEmp);
            this.panel6.Location = new System.Drawing.Point(452, 24);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(188, 114);
            this.panel6.TabIndex = 6;
            // 
            // lblInactEmpNum
            // 
            this.lblInactEmpNum.AutoSize = true;
            this.lblInactEmpNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInactEmpNum.ForeColor = System.Drawing.SystemColors.Control;
            this.lblInactEmpNum.Location = new System.Drawing.Point(118, 38);
            this.lblInactEmpNum.Name = "lblInactEmpNum";
            this.lblInactEmpNum.Size = new System.Drawing.Size(19, 20);
            this.lblInactEmpNum.TabIndex = 2;
            this.lblInactEmpNum.Text = "0";
            // 
            // lblInactEmp
            // 
            this.lblInactEmp.AutoSize = true;
            this.lblInactEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInactEmp.ForeColor = System.Drawing.SystemColors.Control;
            this.lblInactEmp.Location = new System.Drawing.Point(19, 82);
            this.lblInactEmp.Name = "lblInactEmp";
            this.lblInactEmp.Size = new System.Drawing.Size(164, 20);
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
            this.panel2.Location = new System.Drawing.Point(238, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(188, 114);
            this.panel2.TabIndex = 6;
            // 
            // lblactemp
            // 
            this.lblactemp.AutoSize = true;
            this.lblactemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblactemp.ForeColor = System.Drawing.SystemColors.Control;
            this.lblactemp.Location = new System.Drawing.Point(33, 82);
            this.lblactemp.Name = "lblactemp";
            this.lblactemp.Size = new System.Drawing.Size(150, 20);
            this.lblactemp.TabIndex = 1;
            this.lblactemp.Text = "Active Employees";
            this.lblactemp.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblActEmpNum
            // 
            this.lblActEmpNum.AutoSize = true;
            this.lblActEmpNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActEmpNum.ForeColor = System.Drawing.SystemColors.Control;
            this.lblActEmpNum.Location = new System.Drawing.Point(121, 38);
            this.lblActEmpNum.Name = "lblActEmpNum";
            this.lblActEmpNum.Size = new System.Drawing.Size(19, 20);
            this.lblActEmpNum.TabIndex = 2;
            this.lblActEmpNum.Text = "0";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Location = new System.Drawing.Point(17, 193);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(657, 307);
            this.panel4.TabIndex = 9;
            // 
            // picInactEmp
            // 
            this.picInactEmp.BackColor = System.Drawing.Color.Transparent;
            this.picInactEmp.Image = global::EmployeeUI.Properties.Resources.icons8_person_64__1_;
            this.picInactEmp.Location = new System.Drawing.Point(13, 12);
            this.picInactEmp.Name = "picInactEmp";
            this.picInactEmp.Size = new System.Drawing.Size(57, 64);
            this.picInactEmp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picInactEmp.TabIndex = 4;
            this.picInactEmp.TabStop = false;
            // 
            // picactive
            // 
            this.picactive.BackColor = System.Drawing.Color.Transparent;
            this.picactive.Image = global::EmployeeUI.Properties.Resources.icons8_person_64;
            this.picactive.Location = new System.Drawing.Point(13, 14);
            this.picactive.Name = "picactive";
            this.picactive.Size = new System.Drawing.Size(58, 52);
            this.picactive.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picactive.TabIndex = 4;
            this.picactive.TabStop = false;
            // 
            // picTtlEmp
            // 
            this.picTtlEmp.BackColor = System.Drawing.Color.Transparent;
            this.picTtlEmp.Image = global::EmployeeUI.Properties.Resources.icons8_list_64__1_;
            this.picTtlEmp.Location = new System.Drawing.Point(11, 12);
            this.picTtlEmp.Name = "picTtlEmp";
            this.picTtlEmp.Size = new System.Drawing.Size(57, 64);
            this.picTtlEmp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTtlEmp.TabIndex = 3;
            this.picTtlEmp.TabStop = false;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Name = "Dashboard";
            this.Size = new System.Drawing.Size(696, 526);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picInactEmp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picactive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTtlEmp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblTtlEmpNum;
        private System.Windows.Forms.Label lblTotalEmployees;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lblInactEmpNum;
        private System.Windows.Forms.Label lblInactEmp;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblActEmpNum;
        private System.Windows.Forms.Label lblactemp;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox picTtlEmp;
        private System.Windows.Forms.PictureBox picInactEmp;
        private System.Windows.Forms.PictureBox picactive;
    }
}
