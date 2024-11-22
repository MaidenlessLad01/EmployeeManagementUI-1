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
    public partial class EmployeeInfo : Form
    {
        public EmployeeInfo()
        {
            InitializeComponent();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            attendance1.Visible = false;
            employeeDetails1.Visible = true;
        }

        private void btnAttendance_Click(object sender, EventArgs e)
        {
            attendance1.Visible = true;
            employeeDetails1.Visible = false;
        }
    }
}
