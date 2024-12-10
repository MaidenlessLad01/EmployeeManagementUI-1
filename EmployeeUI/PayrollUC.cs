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
    public partial class PayrollUC : UserControl
    {
        database1DataContext db = new database1DataContext();
        public PayrollUC()
        {
            InitializeComponent();
            var employeeIDs = db.EmployeeDetails.Select(emp => emp.EmployeeID).ToList();
            cboEmployeeID.DataSource = employeeIDs;  // Assuming cboEmployeeID is your ComboBox
            LoadAttendanceData();
        }

        private void cboEmployeeID_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedEmployeeID = (int)cboEmployeeID.SelectedItem;

            // Query the employee details based on the selected employee ID
            var employee = db.EmployeeDetails.SingleOrDefault(emp => emp.EmployeeID == selectedEmployeeID);
            var salary = db.Salaries.SingleOrDefault(sal => sal.EmployeeID == selectedEmployeeID);
            if (employee != null)
            {
                // Populate the textboxes with the employee's details
                txtFName.Text = employee.Firstname;
                txtLName.Text = employee.Lastname;
                txtMName.Text = employee.Middlename;
                txtPosition.Text = employee.Position;
                txtHourlyRate.Text = salary.HourlyRate.ToString();  
            }

            LoadAttendanceData();
        }
        private void LoadAttendanceData()
        {
            int selectedEmployeeID = (int)cboEmployeeID.SelectedItem;
            DateTime selectedMonth = dtpMonth.Value;  // Use the selected month from DateTimePicker

            // Query the attendance records for the selected employee and month
            var attendanceRecords = db.Attendances
                .Where(att => att.EmployeeID == selectedEmployeeID &&
                              att.Date.Month == selectedMonth.Month &&
                              att.Date.Year == selectedMonth.Year)
                .Select(att => new
                {
                    att.Date,
                    att.TimeIn,
                    att.TimeOut,
                    att.TotalHours
                })
                .ToList();

            // Bind the attendance records to the DataGridView
            dgvAttendance.DataSource = attendanceRecords;
        }
        private void CalculateTotalSalary()
        {
            int selectedEmployeeID = (int)cboEmployeeID.SelectedItem;
            DateTime selectedMonth = dtpMonth.Value; // Use DateTimePicker to get the selected month

            // Get the hourly rate for the selected employee
            decimal hourlyRate = db.Salaries
                                  .Where(s => s.EmployeeID == selectedEmployeeID)
                                  .Select(s => s.HourlyRate)
                                  .FirstOrDefault() ?? 0m;

            if (hourlyRate == 0)
            {
                MessageBox.Show("Hourly rate not found for the selected employee.");
                return;
            }

            // Calculate the total hours worked for the selected employee in the selected month
            decimal totalHoursWorked = db.Attendances
                .Where(att => att.EmployeeID == selectedEmployeeID &&
                              att.Date.Month == selectedMonth.Month &&  // Filter by selected month
                              att.Date.Year == selectedMonth.Year)      // Ensure correct year
                .Sum(att => att.TotalHours) ?? 0m;  // Sum total hours worked in that month

            // Calculate the total salary
            decimal totalSalary = totalHoursWorked * hourlyRate;

            // Display the total hours worked and total salary
            txtTotalHoursWorked.Text = totalHoursWorked.ToString("F2");
            txtTotalSalary.Text = totalSalary.ToString("C");  // Display salary in currency format
        }

        private void btnSalary_Click(object sender, EventArgs e)
        {
            CalculateTotalSalary();
        }
    }
}
