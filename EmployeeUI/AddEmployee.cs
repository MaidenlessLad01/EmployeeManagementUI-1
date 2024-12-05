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
            
            //Check user inputs
            string errorMessage = CheckInputs(); //check if fields are empty

            if (!string.IsNullOrEmpty(errorMessage))
            {
                //Show errors and stop
                MessageBox.Show(errorMessage, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Confirmation
            DialogResult check = MessageBox.Show("Are you sure you want to add this employee?",
                                                 "Confirmation",
                                                 MessageBoxButtons.YesNo,
                                                 MessageBoxIcon.Question);
            if (check == DialogResult.Yes)
            {
                // If confirmed, add employee to the database
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

                // Load the updated data into the DataGridView
                LoadEmployeeData();

                MessageBox.Show("Employee and account added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Access the main form and reload the DataGridView with new employee data
                Form1 parentForm = (Form1)this.ParentForm;
                parentForm.EmployeeListControl.ReloadEmployeeData();
            }

        }
        private string CheckInputs()
        {
            string errorMsg = "";
            //Display if empty
            if (string.IsNullOrWhiteSpace(txtLName.Text))
                errorMsg += "Last Name is required.\n";
            if (string.IsNullOrWhiteSpace(txtFName.Text))
                errorMsg += "First Name is required.\n";
            if (string.IsNullOrWhiteSpace(txtMName.Text))
                errorMsg += "Middle Name is required.\n";
            if (dtpDoB.Value == null || dtpDoB.Value > DateTime.Now)
                errorMsg += "Date of Birth is invalid or missing.\n";
            if (string.IsNullOrWhiteSpace(txtPhoneNum.Text))
                errorMsg += "Phone Number is required.\n";
            if (string.IsNullOrWhiteSpace(cboGender.Text))
                errorMsg += "Gender is required.\n";
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
                errorMsg += "Email is required.\n";
            if (string.IsNullOrWhiteSpace(cboPosition.Text))
                errorMsg += "Position is required.\n";
            if (string.IsNullOrWhiteSpace(txtusername.Text))
                errorMsg += "Username is required.\n";
            if (string.IsNullOrWhiteSpace(txtpassword.Text))
                errorMsg += "Password is required.\n";

            return errorMsg; // Return all error messages as a single string
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
    }
}
