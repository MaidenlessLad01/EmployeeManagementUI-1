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
    public partial class EmployeeDetails : UserControl
    {
        //Declare variable
        database1DataContext db = new database1DataContext();
        private int employeeID;
        public EmployeeDetails()
        {
            InitializeComponent();
            LoadInfo();
        }
        public EmployeeDetails(int empID) : this()
        {
            employeeID = empID;
            LoadInfo();
        }

        public void SetEmployeeID(int empID)
        {
            employeeID = empID;
            LoadInfo();
        }
        private void LoadInfo()
        {
            // Load employee data from the database using the stored employeeID
            var result = db.ShowEmployeeDetail(employeeID).FirstOrDefault();

            if (result != null)
            {
                // Assign the loaded data to respective labels
                lblGender.Text = result.gender;
                dtpDoB.Value = result.DoB;
                lblEmail.Text = result.Email;
                lblPhoneNumber.Text = result.PhoneNumber;
            }
           
        }

        private void EmployeeDetails_Load(object sender, EventArgs e)
        {
            lblEmployeeID.Text = employeeID.ToString();

        }
    }
}
