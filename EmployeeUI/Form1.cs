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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
        }


        private void btnDashboard_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = true;
            addEmployee1.Visible = false;
            edit1.Visible = false;
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        private void lblSignOut_MouseEnter(object sender, EventArgs e)
        {
            Label label = sender as Label;
            label.Font = new Font(label.Font, FontStyle.Underline);
           
        }

        private void lblSignOut_MouseLeave(object sender, EventArgs e)
        {
            Label label = sender as Label;
            label.Font = new Font(label.Font, FontStyle.Bold);
        }

        private void lblSignOut_Click(object sender, EventArgs e)
        {
            DialogResult check = new DialogResult();

            check = MessageBox.Show("Are you sure you want to sign out?","Sign Out",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(check == DialogResult.Yes) 
            { 
                Login log = new Login();
                log.Show();
                this.Hide();
            }
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = false;
            addEmployee1.Visible = true;
            edit1.Visible = false;
        }

        private void picSignout_Click(object sender, EventArgs e)
        {
            DialogResult check = new DialogResult();

            check = MessageBox.Show("Are you sure you want to sign out?", "Sign Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (check == DialogResult.Yes)
            {
                Login log = new Login();
                log.Show();
                this.Hide();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = false;
            addEmployee1.Visible = false;
            edit1.Visible = true;
        }
    }

}
