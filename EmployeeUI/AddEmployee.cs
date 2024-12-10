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
            if (this.ParentForm is MainForm parentForm)
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
            txtusername.Clear();
            txtpassword.Clear();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Confirmation dialog
            DialogResult check = MessageBox.Show("Are you sure you want to add this employee?",
                                                 "Confirmation", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (check == DialogResult.Yes)
            {
                try
                {
                    // Create an Employee instance
                    Employee emp = new Employee();

                    string getrole = cboPosition.Text;

                    txtHourlyRate.Text = Convert.ToString(emp.GetHourlyRate(getrole));

                    // Add employee with all required data
                    emp.AddEmployee(
                        txtLName.Text,
                        txtFName.Text,
                        txtMName.Text,
                        dtpDoB.Value,
                        txtPhoneNum.Text,
                        cboGender.Text,
                        txtEmail.Text,
                        cboPosition.Text,
                        txtusername.Text,
                        txtpassword.Text,
                        Convert.ToDecimal(txtHourlyRate.Text)
                    );
                    // Load the updated data into the DataGridView
                    LoadEmployeeData();

                    MessageBox.Show("Employee and account added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Access the main form and reload the DataGridView with new employee data
                    MainForm parentForm = (MainForm)this.ParentForm;
                    parentForm.EmployeeListControl.ReloadEmployeeData();
                }
                catch (Exception ex)
                {
                    // Show validation or database error messages
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
       

        private void LoadEmployeeData()
        {
            
            // Fetch the employee and account data by joining the tables using LINQ
            var employees = from e in db.EmployeeDetails
                            join a in db.Accounts on e.EmployeeID equals a.EmployeeID
                            join s in db.Salaries on e.EmployeeID equals s.EmployeeID
                            where e.Status == "Active"
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
                                s.HourlyRate,
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

        private void cboPosition_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the selected position from the ComboBox
            string position = cboPosition.Text;

            // Create an instance of Employee
            Employee employee = new Employee();

            // Get the corresponding hourly rate for the position
            decimal hourlyRate = employee.GetHourlyRate(position);

            // Display the hourly rate in the text box
            txtHourlyRate.Text = hourlyRate.ToString("C");
        }

        private void dgvEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
