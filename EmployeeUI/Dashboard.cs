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

    public partial class Dashboard : UserControl
    {
        AttendanceClass att = new AttendanceClass();
        database1DataContext db = new database1DataContext();
        public Dashboard()
        {
            InitializeComponent();
            LoadAttendanceData();
            GetEmpNum();
            
        }
        private void GetEmpNum()
        {
            int employeeNum = EmployeeNum();
            lblActEmpNum.Text = employeeNum.ToString();
        }
        public int EmployeeNum()
        {
            var empnum = (from emp in db.EmployeeDetails where emp.Status == "Active" select emp).Count();

            return empnum;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        public void LoadAttendanceData()
        {
            List<AttendanceClass.AttendanceRecord> attendance = att.LoadAttendanceData();
            dgvAttendance.DataSource = attendance;

            
        }
        public void LoadAttendance()
        {
            DateTime selecteDate = dtpDate.Value;

            List<AttendanceClass.AttendanceRecord> attendance = att.LoadAttendance(selecteDate);

            dgvAttendance.DataSource = attendance;
        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            DateTime selecteDate = dtpDate.Value;

            List<AttendanceClass.AttendanceRecord> attendance = att.LoadAttendance(selecteDate);

            dgvAttendance.DataSource = attendance;
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            DateTime currentDate = DateTime.Now.Date;
            att.LoadAttendance(currentDate);


        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadAttendanceData();
        }
    }
}
