using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeUI
{
    public partial class AddEmployee : UserControl
    {
        //Declare variable/s
        //declare database
        database1DataContext db = new database1DataContext();
        public AddEmployee()
        {
            InitializeComponent();
            //Matik load the DGV kung naay sulod
            LoadEmployeeData();

        }
        private void AddEmployee_Load(object sender, EventArgs e)
        {
            // Ensure the reference to the parent form is set when the control loads
            if (this.ParentForm is Form1 parentForm)
            {
                parentForm.AddEmp = this; // Set the UserControl reference in the parent form
            }
        }
        public void ReloadEmployeeData()
        {
            //For reloading the dgv if nay changes
            LoadEmployeeData();
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            //Clear
            txtEmail.Clear();
            txtFName.Clear();
            txtLName.Clear();
            txtMName.Clear();
            txtPhoneNum.Clear();
            cboGender.ResetText();
            cboPosition.ResetText();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Confirmation, sure nga i-hire?
            DialogResult check = new DialogResult();
            check = MessageBox.Show("Are you sure you want to add employee?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (check == DialogResult.Yes)
            {   
                //if yes, add employee sa database
                db.AddEmployeeAcc
                (
                    txtLName.Text,
                    txtFName.Text,
                    txtMName.Text,
                    dtpDoB.Value,
                    txtPhoneNum.Text,
                    cboGender.Text,
                    txtEmail.Text,
                    cboPosition.Text,                     
                    txtusername.Text,
                    txtpassword.Text
                );
                //isud sa DGV
                LoadEmployeeData();
                
                MessageBox.Show("Employee and Account added successfully!");
            }
            Form1 parentForm = (Form1)this.ParentForm; // Access the main form
            parentForm.EmployeeListControl.ReloadEmployeeData(); // Reload the DGV kung naay changes
        }
        
        private void LoadEmployeeData()
        {
            
            // Fetch the employee and account data by joining the tables using LINQ
            var employees = from e in db.EmployeeDetails
                            join a in db.Accounts on e.EmployeeID equals a.EmployeeID
                            select new
                            {
                                e.EmployeeID,
                                e.Lastname,
                                e.Firstname,
                                e.Middlename,
                                e.DoB,
                                e.PhoneNumber,
                                e.Gender,
                                e.Email,
                                e.Position,
                                a.Username,
                                a.Password
                            };
                // Show 
                dgvEmployee.DataSource = employees.ToList();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            //Refresh eyyy idk ngano naa ni pero ana lang para aron ing non hahah
            LoadEmployeeData();
        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblpassword_Click(object sender, EventArgs e)
        {

        }
    }
}
