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
        public Edit()
        {
            InitializeComponent();
            LoadEmployeeData();
        }

        public void ReloadEmployeeData()
        {
            LoadEmployeeData(); 
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DialogResult check = new DialogResult();

            check = MessageBox.Show("Are you sure you want to update employee detail?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (check == DialogResult.Yes)
            {
                using (database1DataContext db = new database1DataContext())
                {
                    db.UpdateEmpInfo
                    (
                       int.Parse(txtEmpID.Text),
                       txtLName.Text,
                       txtFName.Text,
                       txtMName.Text,
                       cboPosition.Text,
                       cboStatus.Text

                    );
                    LoadEmployeeData();
                }
               
                MessageBox.Show("Employee Detail Updated" , "Successful");
            }
        }

        private void btnFire_Click(object sender, EventArgs e)
        {                    
            using(database1DataContext db = new database1DataContext())
            {
                // Get the employee by their ID (from the populated textbox)
                if (int.TryParse(txtEmpID.Text, out int employeeID))
                {
                    // Find the employee and related account
                    var employeeToDelete = db.EmployeeDetails.SingleOrDefault(emp => emp.EmployeeID == employeeID);
                    var accountToDelete = db.Accounts.SingleOrDefault(acc => acc.EmployeeID == employeeID);

                    if (employeeToDelete != null && accountToDelete != null)
                    {
                        // Remove the account first (because of the foreign key constraint)
                        db.Accounts.DeleteOnSubmit(accountToDelete);

                        // Remove the employee
                        db.EmployeeDetails.DeleteOnSubmit(employeeToDelete);

                        // Commit the changes to the database
                        db.SubmitChanges();

                        MessageBox.Show("Employee and account removed successfully!");

                        // Optionally reload the DataGridView to reflect changes
                        LoadEmployeeData();
                    }
                    else
                    {
                        MessageBox.Show("Employee not found!");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Employee ID!");
                }
            }

            Form1 parentForm = (Form1)this.ParentForm; // Access the main form
            parentForm.AddEmp.ReloadEmployeeData(); // Reload the DGV
        }
        
        private void LoadEmployeeData()
        {
            using (database1DataContext db = new database1DataContext())
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
                                    e.Position,
                                    e.Status
                                };

                //Bind the query result to the DataGridView
                dgvEmployees.DataSource = employees.ToList();


            }
        }

        private void dgvEmployees_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dgvEmployees.Rows[e.RowIndex];
                txtEmpID.Text = row.Cells[0].Value.ToString();
                txtFName.Text = row.Cells[1].Value.ToString();
                txtLName.Text = row.Cells[2].Value.ToString();
                txtMName.Text = row.Cells[3].Value.ToString();
                cboPosition.Text = row.Cells[4].Value.ToString();
                cboStatus.Text = row.Cells[5].Value.ToString();
            }
                     
        }

        private void Edit_Load(object sender, EventArgs e)
        {
            
                // Ensure the reference to the parent form is set when the control loads
                if (this.ParentForm is Form1 parentForm)
                {
                    parentForm.EmployeeListControl = this; // Set the UserControl reference in the parent form
                }
            
        }
    }
}
