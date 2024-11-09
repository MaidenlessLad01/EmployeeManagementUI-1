using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeUI
{
    public partial class RegisterAcc : Form
    {
        //var dec
        bool isPasswordVisible = false;
        public RegisterAcc()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;

        }

        private void picEye1_Click(object sender, EventArgs e)
        {
            isPasswordVisible = !isPasswordVisible;

            if (isPasswordVisible)
            {
                txtpassword.UseSystemPasswordChar = false;

            }
            // Otherwise, hide the password characters
            else
            {
                txtpassword.UseSystemPasswordChar = true;

            }
        }

        private void picEye2_Click(object sender, EventArgs e)
        {
            isPasswordVisible = !isPasswordVisible;

            if (isPasswordVisible)
            {
                txtconfpassword.UseSystemPasswordChar = false;

            }
            // Otherwise, hide the password characters
            else
            {
                txtconfpassword.UseSystemPasswordChar = true;

            }
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Account Created Successfully!","Account Created");
            Login log = new Login();
            log.Show();
            this.Hide();
        }
    }
}
