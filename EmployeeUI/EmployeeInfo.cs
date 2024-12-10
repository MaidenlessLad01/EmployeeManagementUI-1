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
    public partial class EmployeeInfo : Form
    {
        //Declare global variable/s
        //declare database
        database1DataContext db = new database1DataContext();
        //kuhaon ang Id sa employee
        private int employeeID;
        public EmployeeInfo(int empID)
        {
            InitializeComponent();
            //konek
            employeeID = empID;
            LoadInfo();
            employeeDetails1.SetEmployeeID(empID);
            attendance1.GetEmployeeID(empID);
            this.FormBorderStyle = FormBorderStyle.None;
            picClose.Parent = this;
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            attendance1.Visible = false;
            employeeDetails1.Visible = true;
        }

        private void btnAttendance_Click(object sender, EventArgs e)
        {
            attendance1.Visible = true;
            employeeDetails1.Visible = false;
        }

        private void LoadInfo()
        {
            

            // Ensure that the employee ID is correct before querying the database
            MessageBox.Show(employeeID.ToString(), "Employee ID");

            // Load employee data from the database using the stored employeeID
            var result = db.ShowEmployeeNames(employeeID).FirstOrDefault();

            if (result != null)
            {
                // Assign the loaded data to respective labelsdd
                lblLName.Text = result.Lastname;
                lblFName.Text = result.Firstname;
                lblMName.Text = result.Middlename;
                lblPosition.Text = result.Position;
            }
            else
            {
                MessageBox.Show("No employee data found for the given ID");
            }

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
        private void lblSignOut_Click(object sender, EventArgs e)
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

        private void lblSignOut_MouseEnter_1(object sender, EventArgs e)
        {
            Label label = sender as Label;
            label.Font = new Font(label.Font, FontStyle.Underline);
        }

        private void lblSignOut_MouseLeave_1(object sender, EventArgs e)
        {
            Label label = sender as Label;
            label.Font = new Font(label.Font, FontStyle.Bold);
        }

        private void EmployeeInfo_Load(object sender, EventArgs e)
        {
            //Set the label to employeeID
            lblID.Text = employeeID.ToString();
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
