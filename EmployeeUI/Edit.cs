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
    public partial class Edit : UserControl
    {
        //Declare variable/s
        //declare database
        database1DataContext db = new database1DataContext();
        Employee emp = new Employee();
        public Edit()
        {
            InitializeComponent();
            //Matik load the DGV kung naay sulod
            LoadEmployeeData();
        }

        public void ReloadEmployeeData()
        {
            //Reloaf dgv kung nay changes
            LoadEmployeeData(); 
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ////Confirmation, sure najud nga i putbol?
            DialogResult check = MessageBox.Show("Are you sure you want to update employee detail?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (check == DialogResult.Yes)
            {
                try
                {
                    // Call UpdateEmployee method, and pass all the necessary parameters
                    emp.UpdateEmployee(
                        int.Parse(txtEmpID.Text),
                        txtLName.Text,                              
                        txtFName.Text,                              
                        txtMName.Text,                              
                        Convert.ToDateTime(dtpDoB.Value),                               
                        txtPhoneNum.Text,                        
                        cboGender.Text,                          
                        txtEmail.Text,                           
                        cboPosition.Text,                        
                        cboStatus.Text,
                        Convert.ToDecimal(txtHourlyRate.Text)
                    );

                    // Reload the DataGridView with updated employee data
                    LoadEmployeeData();

                    MessageBox.Show("Employee Detail Updated", "Successful");

                    // Reload employee data on the main form after update
                    MainForm parentForm = (MainForm)this.ParentForm;
                    parentForm.EmployeeListControl.ReloadEmployeeData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error updating employee: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void btnFire_Click(object sender, EventArgs e)
        {
            ////Get the employeeID based sa clicked cell
            //if (int.TryParse(txtEmpID.Text, out int employeeID))
            //{
            //    try
            //    {
            //        //Bye bye employee then reseed ang identity based kung pila ang last identity
            //        db.FireEmployees(employeeID);

            //        MessageBox.Show("Employee and account removed successfully!");

            //        //Reload changes sa DGV
            //        LoadEmployeeData();

            //        //reload ang dgv nga naa sa lain nga UserControl
            //        MainForm parentForm = (MainForm)this.ParentForm;
            //        parentForm.AddEmp.ReloadEmployeeData(); 
            //    }
            //    catch (Exception ex)
            //    {
            //        //Comment hahah
            //        MessageBox.Show("Error while deleting employee: " + ex.Message);
            //    }
            //}
            //else
            //{
            //    //Comment nasad hahaha
            //    MessageBox.Show("Invalid Employee ID!");
            //}
              // Confirmation dialog before archiving
            DialogResult check = MessageBox.Show("Are you sure you want to archive this employee?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (check == DialogResult.Yes)
            {
                try
                {
                // Call ArchiveEmployee method to update status to 'Inactive'
                emp.ArchiveEmployee(int.Parse(txtEmpID.Text));

                // Reload the DataGridView with active employees
                LoadEmployeeData();
                // Reload the archived DataGridView with inactive employees

                MainForm parentForm = (MainForm)this.ParentForm;
                parentForm.AddEmp.ReloadEmployeeData();
                    // Ensure InactiveEmp is not null before accessing it
                    if (parentForm.InactiveEmp != null)
                    {
                        parentForm.InactiveEmp.LoadInactiveEmployees(); // Refresh the inactive employees
                    }
                    else
                    {
                        MessageBox.Show("Inactive employees control is not loaded", "Error");
                    }
                    MessageBox.Show("Employee has been archived", "Success");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error archiving employee: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LoadEmployeeData()
        {
            // Fetch the employee and account data by joining the tables using LINQ
            var employees = from e in db.EmployeeDetails
                            join a in db.Accounts on e.EmployeeID equals a.EmployeeID
                            join s in db.Salaries on e.EmployeeID equals s.EmployeeID
                            where e.Status =="Active"
                            select new
                            {
                                e.EmployeeID,
                                e.Lastname,
                                e.Firstname,
                                e.Middlename,
                                e.DoB,
                                e.PhoneNumber,
                                e.Gender,
                                e.Position,
                                s.HourlyRate,
                                e.Email,
                                a.Username,
                                a.Password,
                                e.Status
                            };

            //Show the result into the DGV
            dgvEmployees.DataSource = employees.ToList();      
        }

        private void dgvEmployees_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Show the employee details in the textboxes if a cell is clicked
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dgvEmployees.Rows[e.RowIndex];
                txtEmpID.Text = row.Cells[0].Value.ToString();
                txtFName.Text = row.Cells[1].Value.ToString();
                txtLName.Text = row.Cells[2].Value.ToString();
                txtMName.Text = row.Cells[3].Value.ToString();
                dtpDoB.Value= Convert.ToDateTime(row.Cells[4].Value);
                txtPhoneNum.Text = row.Cells[5].Value.ToString();
                cboGender.Text = row.Cells[6].Value.ToString();
                cboPosition.Text = row.Cells[7].Value.ToString();
                txtHourlyRate.Text = row.Cells[8].Value.ToString();
                txtEmail.Text = row.Cells[9].Value.ToString();
                txtusername.Text = row.Cells[10].Value.ToString();
                txtpassword.Text = row.Cells[11].Value.ToString();
                cboStatus.Text = row.Cells[12].Value.ToString();
            }
                     
        }

        private void Edit_Load(object sender, EventArgs e)
        {
                
                //Reference sa parent form para ma load ang DGV 
                if (this.ParentForm is MainForm parentForm)
                {
                    parentForm.EmployeeListControl = this;
                }
            
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            //Refresh, ambot ngano need pani. Chuy2 lang gud
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
            txtHourlyRate.Text = hourlyRate.ToString();
        }
    }
}
