using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeUI
{
    internal class AttendanceClass
    {
        database1DataContext db = new database1DataContext();

        public void TimeOut(int employeeID, DateTime selectedDate)
        {
            try
            {
                db.TimeOutTime(employeeID, DateTime.Now.TimeOfDay);

                //db.TimeOut(employeeID, selectedDate);
                db.SubmitChanges();
                MessageBox.Show("Time out recorded successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        public void TimeIn(int employeeID, DateTime selectedDate)
        {
            try
            {
                db.TimeInTime(employeeID, DateTime.Now.TimeOfDay);
                //db.TimeIn(employeeID, selectedDate);
                db.SubmitChanges();
                MessageBox.Show("Time In recorded successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex) 
            {
                MessageBox.Show("An error occured: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public List<AttendanceRecord> LoadAttendance(DateTime selectedDate)
        {
            var attendance = (from e in db.EmployeeDetails
                                  // Left join on EmployeeDetails and Attendance
                              join a in db.Attendances on e.EmployeeID equals a.EmployeeID into ea
                              from a in ea.DefaultIfEmpty()  // This ensures all employees are included
                              where a.Date.Date == selectedDate && e.Status == "Active"     // Only active employees
                              select new AttendanceRecord
                              {
                                  EmployeeID = e.EmployeeID,
                                  LName = e.Lastname,
                                  FName = e.Firstname,
                                  MName = e.Middlename,
                                  TimeIn = a != null ? a.TimeIn : (TimeSpan?)null,  // Handle null TimeIn
                                  TimeOut = a != null ? a.TimeOut : (TimeSpan?)null, // Handle null TimeOut
                                  TotalHours = a != null ? a.TotalHours : (decimal?)null, // Handle null TotalHours
                                  Status = e.Status
                              }).ToList();

            return attendance;
        }
        public class AttendanceRecord
        {
            public int EmployeeID { get; set; }
            public string LName { get; set; }
            public string FName { get; set; }
            public string MName { get; set; }
            public TimeSpan? TimeIn { get; set; }
            public TimeSpan? TimeOut { get; set; }
            public Decimal? TotalHours { get; set; }
            public string Status { get; set; }

        }
        public List<AttendanceRecord> LoadAttendanceData()
        {
            var attendance = (from e in db.EmployeeDetails
                                  // Left join on EmployeeDetails and Attendance
                              join a in db.Attendances on e.EmployeeID equals a.EmployeeID into ea
                              from a in ea.DefaultIfEmpty()  // This ensures all employees are included
                              where e.Status == "Active"     // Only active employees
                              select new AttendanceRecord
                              {
                                  EmployeeID = e.EmployeeID,
                                  LName = e.Lastname,
                                  FName = e.Firstname,
                                  MName = e.Middlename,
                                  TimeIn = a != null ? a.TimeIn : (TimeSpan?)null,  // Handle null TimeIn
                                  TimeOut = a != null ? a.TimeOut : (TimeSpan?)null, // Handle null TimeOut
                                  TotalHours = a != null ? a.TotalHours : (decimal?)null, // Handle null TotalHours
                                  Status = e.Status
                              }).ToList();

            return attendance;
        }
    }
}
