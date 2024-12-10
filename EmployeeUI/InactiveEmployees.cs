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
    public partial class InactiveEmployees : UserControl
    {
        //var dec
        database1DataContext db = new database1DataContext();
        public InactiveEmployees()
        {
            InitializeComponent();
            LoadInactiveEmployees();
        }
        public void LoadInactiveEmployees()
        {
            var inactiveEmployees = from emp in db.EmployeeDetails
                                    where emp.Status == "Inactive"
                                    select new
                                    {
                                        emp.EmployeeID,
                                        emp.Lastname,
                                        emp.Firstname,
                                        emp.Middlename,
                                        emp.Position,
                                        emp.Status
                                    };
            dgvInactEmployees.DataSource = inactiveEmployees.ToList();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadInactiveEmployees();
        }
    }
}
