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
        
        public AddEmployee()
        {
            InitializeComponent();
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
            LoadEmployeeData();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            txtEmail.Clear();
           
            txtFName.Clear();
            txtLName.Clear();
            txtMName.Clear();
            txtPhoneNum.Clear();
            cboGender.ResetText();
            cboPosition.ResetText();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
           
            DialogResult check = new DialogResult();

            check = MessageBox.Show("Are you sure you want to add employee?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (check == DialogResult.Yes)
            {
                using (database1DataContext db = new database1DataContext())
                {
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
                    LoadEmployeeData();
                }
                MessageBox.Show("Employee and Account added successfully!");
            }
            Form1 parentForm = (Form1)this.ParentForm; // Access the main form
            parentForm.EmployeeListControl.ReloadEmployeeData(); // Reload the DGV
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
                                    e.DoB,
                                    e.PhoneNumber,
                                    e.Gender,
                                    e.Email,
                                    e.Position,
                                    a.Username,
                                    a.Password
                                };

                // Bind the query result to the DataGridView
                dgvEmployee.DataSource = employees.ToList();
            }
        }

        
    }
}
