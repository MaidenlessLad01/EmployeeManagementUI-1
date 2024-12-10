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
    public partial class MainForm : Form
    {
        //declare global vars

        //initialize ang usercontrol
        public Edit EmployeeListControl { get; set; }
        public AddEmployee AddEmp { get; set; }

        public InactiveEmployees InactiveEmp { get; set; }
        //kuhaon ang employeeID
        private int employeeID;
        public MainForm(int empID)
        {
            InitializeComponent();
            //konek
            employeeID = empID;
            this.FormBorderStyle = FormBorderStyle.None;
            InactiveEmp = new InactiveEmployees();
            this.Controls.Add(InactiveEmp);
        }


        private void btnDashboard_Click(object sender, EventArgs e)
        {
            //show dashboard
            dashboard1.Visible = true;
            addEmployee1.Visible = false;
            inactiveEmployees1.Visible = false;
            payrollUC1.Visible = false;
            edit1.Visible = false;
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            //end session
            Environment.Exit(0);
        }
        private void lblSignOut_MouseEnter(object sender, EventArgs e)
        {
            //sheesh
            Label label = sender as Label;
            label.Font = new Font(label.Font, FontStyle.Underline);
           
        }

        private void lblSignOut_MouseLeave(object sender, EventArgs e)
        {
            //sheesh pt.2
            Label label = sender as Label;
            label.Font = new Font(label.Font, FontStyle.Bold);
        }

        private void lblSignOut_Click(object sender, EventArgs e)
        {
            //confirmation to sign out
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
            //show addemployee
            inactiveEmployees1.Visible = false;
            dashboard1.Visible = false;
            addEmployee1.Visible = true;
            edit1.Visible = false;
            payrollUC1.Visible = false;
        }

        private void picSignout_Click(object sender, EventArgs e)
        {
            //confirmation to sign out
            DialogResult check = new DialogResult();

            check = MessageBox.Show("Are you sure you want to sign out?", "Sign Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (check == DialogResult.Yes)
            {
                Login log = new Login();
                log.Show();
                this.Hide();
            }
        }

        private void btnManage_Click(object sender, EventArgs e)
        {
            //show manage emp
            inactiveEmployees1.Visible = false;
            dashboard1.Visible = false;
            addEmployee1.Visible = false;
            payrollUC1.Visible=false;
            edit1.Visible = true;
        }

        private void btnArchive_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = false;
            addEmployee1.Visible = false;
            edit1.Visible = false;
            payrollUC1.Visible=false;
            inactiveEmployees1.Visible = true;
        }

        private void btnPayroll_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = false;
            addEmployee1.Visible = false;
            edit1.Visible = false;
            payrollUC1.Visible = true;
            inactiveEmployees1.Visible = false;
        }
    }

}
