
namespace EmployeeUI
{
    partial class RegisterAcc
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.picEye1 = new System.Windows.Forms.PictureBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.lblpassword = new System.Windows.Forms.Label();
            this.btnSignup = new System.Windows.Forms.Button();
            this.picEye2 = new System.Windows.Forms.PictureBox();
            this.txtconfpassword = new System.Windows.Forms.TextBox();
            this.lblconfpassword = new System.Windows.Forms.Label();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.lblusername = new System.Windows.Forms.Label();
            this.lblregister = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEye1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEye2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Location = new System.Drawing.Point(411, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(292, 437);
            this.panel1.TabIndex = 21;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTitle.Location = new System.Drawing.Point(59, 337);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(181, 62);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "   Employee \r\nManagement";
            // 
            // picEye1
            // 
            this.picEye1.BackColor = System.Drawing.SystemColors.Window;
            this.picEye1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picEye1.Image = global::EmployeeUI.Properties.Resources.icons8_eye_50;
            this.picEye1.Location = new System.Drawing.Point(343, 217);
            this.picEye1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picEye1.Name = "picEye1";
            this.picEye1.Size = new System.Drawing.Size(33, 30);
            this.picEye1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picEye1.TabIndex = 31;
            this.picEye1.TabStop = false;
            this.picEye1.Click += new System.EventHandler(this.picEye1_Click);
            // 
            // txtpassword
            // 
            this.txtpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpassword.Location = new System.Drawing.Point(23, 215);
            this.txtpassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(359, 30);
            this.txtpassword.TabIndex = 30;
            this.txtpassword.UseSystemPasswordChar = true;
            // 
            // lblpassword
            // 
            this.lblpassword.AutoSize = true;
            this.lblpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpassword.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblpassword.Location = new System.Drawing.Point(19, 182);
            this.lblpassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(97, 24);
            this.lblpassword.TabIndex = 29;
            this.lblpassword.Text = "Password:";
            // 
            // btnSignup
            // 
            this.btnSignup.BackColor = System.Drawing.Color.Navy;
            this.btnSignup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignup.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSignup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSignup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignup.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignup.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSignup.Location = new System.Drawing.Point(125, 362);
            this.btnSignup.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSignup.Name = "btnSignup";
            this.btnSignup.Size = new System.Drawing.Size(139, 43);
            this.btnSignup.TabIndex = 28;
            this.btnSignup.Text = "SIGNUP";
            this.btnSignup.UseVisualStyleBackColor = false;
            this.btnSignup.Click += new System.EventHandler(this.btnSignup_Click);
            // 
            // picEye2
            // 
            this.picEye2.BackColor = System.Drawing.SystemColors.Window;
            this.picEye2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picEye2.Image = global::EmployeeUI.Properties.Resources.icons8_eye_50;
            this.picEye2.Location = new System.Drawing.Point(343, 303);
            this.picEye2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picEye2.Name = "picEye2";
            this.picEye2.Size = new System.Drawing.Size(33, 30);
            this.picEye2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picEye2.TabIndex = 27;
            this.picEye2.TabStop = false;
            this.picEye2.Click += new System.EventHandler(this.picEye2_Click);
            // 
            // txtconfpassword
            // 
            this.txtconfpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtconfpassword.Location = new System.Drawing.Point(23, 302);
            this.txtconfpassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtconfpassword.Name = "txtconfpassword";
            this.txtconfpassword.Size = new System.Drawing.Size(359, 30);
            this.txtconfpassword.TabIndex = 26;
            this.txtconfpassword.UseSystemPasswordChar = true;
            // 
            // lblconfpassword
            // 
            this.lblconfpassword.AutoSize = true;
            this.lblconfpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblconfpassword.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblconfpassword.Location = new System.Drawing.Point(19, 268);
            this.lblconfpassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblconfpassword.Name = "lblconfpassword";
            this.lblconfpassword.Size = new System.Drawing.Size(167, 24);
            this.lblconfpassword.TabIndex = 25;
            this.lblconfpassword.Text = "Confirm Password:";
            // 
            // txtusername
            // 
            this.txtusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusername.Location = new System.Drawing.Point(23, 126);
            this.txtusername.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(359, 30);
            this.txtusername.TabIndex = 24;
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusername.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblusername.Location = new System.Drawing.Point(19, 92);
            this.lblusername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(102, 24);
            this.lblusername.TabIndex = 23;
            this.lblusername.Text = "Username:";
            // 
            // lblregister
            // 
            this.lblregister.AutoSize = true;
            this.lblregister.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblregister.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblregister.Location = new System.Drawing.Point(15, 27);
            this.lblregister.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblregister.Name = "lblregister";
            this.lblregister.Size = new System.Drawing.Size(292, 39);
            this.lblregister.TabIndex = 22;
            this.lblregister.Text = "Register Account";
            // 
            // RegisterAcc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 433);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.picEye1);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.lblpassword);
            this.Controls.Add(this.btnSignup);
            this.Controls.Add(this.picEye2);
            this.Controls.Add(this.txtconfpassword);
            this.Controls.Add(this.lblconfpassword);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.lblusername);
            this.Controls.Add(this.lblregister);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "RegisterAcc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterAcc";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEye1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEye2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox picEye1;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Label lblpassword;
        private System.Windows.Forms.Button btnSignup;
        private System.Windows.Forms.PictureBox picEye2;
        private System.Windows.Forms.TextBox txtconfpassword;
        private System.Windows.Forms.Label lblconfpassword;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.Label lblusername;
        private System.Windows.Forms.Label lblregister;
    }
}