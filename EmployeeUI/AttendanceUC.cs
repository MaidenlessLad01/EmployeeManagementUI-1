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
    public partial class AttendanceUC : UserControl
    {
        database1DataContext db = new database1DataContext();
        AttendanceClass att = new AttendanceClass();
        public int employeeID;
        public AttendanceUC()
        {
            InitializeComponent();
        }
        public AttendanceUC(int empID) : this()
        {
            employeeID = empID;
        }
        public void GetEmployeeID(int empID)
        {
            employeeID = empID;
        }

        private void dtpAttendanceDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnTimeIn_Click(object sender, EventArgs e)
        {
            //Call the TimeIn method
            DateTime selectedDate = dtpAttendanceDate.Value;
            att.TimeIn(employeeID, selectedDate);
        }

        private void btnTimeOut_Click(object sender, EventArgs e)
        {
            // Call the TimeOun method
            DateTime selectedDate = dtpAttendanceDate.Value;
            att.TimeOut(employeeID, selectedDate);
        }
    }
}
