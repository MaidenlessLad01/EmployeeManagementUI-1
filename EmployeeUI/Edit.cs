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
            //Confirmation, sure najud nga i putbol?
            DialogResult check = new DialogResult();
            check = MessageBox.Show("Are you sure you want to update employee detail?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (check == DialogResult.Yes)
            {
                //If yes, mausab ang records nga gi enter sa admin    
                db.UpdateEmpInfo
                (
                    //new data nga gi enter sa admin
                    int.Parse(txtEmpID.Text),
                    txtLName.Text,
                    txtFName.Text,
                    txtMName.Text,
                    cboPosition.Text,
                    cboStatus.Text

                );
                //Reload ang DGV and ma save ang changes
                LoadEmployeeData();         
                MessageBox.Show("Employee Detail Updated" , "Successful");
            }
        }

        private void btnFire_Click(object sender, EventArgs e)
        {                                
            //Get the employeeID based sa clicked cell
            if (int.TryParse(txtEmpID.Text, out int employeeID))
            {
                try
                {
                    //Bye bye employee then reseed ang identity based kung pila ang last identity
                    db.FireEmployees(employeeID);

                    MessageBox.Show("Employee and account removed successfully!");

                    //Reload changes sa DGV
                    LoadEmployeeData();

                    //reload ang dgv nga naa sa lain nga UserControl
                    Form1 parentForm = (Form1)this.ParentForm;
                    parentForm.AddEmp.ReloadEmployeeData(); 
                }
                catch (Exception ex)
                {
                    //Comment hahah
                    MessageBox.Show("Error while deleting employee: " + ex.Message);
                }
            }
            else
            {
                //Comment nasad hahaha
                MessageBox.Show("Invalid Employee ID!");
            }
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
                                e.Position,
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
                cboPosition.Text = row.Cells[4].Value.ToString();
                cboStatus.Text = row.Cells[5].Value.ToString();
            }
                     
        }

        private void Edit_Load(object sender, EventArgs e)
        {
                
                //Reference sa parent form para ma load ang DGV 
                if (this.ParentForm is Form1 parentForm)
                {
                    parentForm.EmployeeListControl = this;
                }
            
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            //Refresh, ambot ngano need pani. Chuy2 lang gud
            LoadEmployeeData();
        }
    }
}
