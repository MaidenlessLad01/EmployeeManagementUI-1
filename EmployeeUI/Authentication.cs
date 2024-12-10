using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeUI
{
    internal class Authentication
    {
        database1DataContext db = new database1DataContext();

        public bool Login(string username, string password, out int employeeID, out string position)
        {
            employeeID = 0;
            position = string.Empty;

            // LINQ query to authenticate the employee
            var auth = (from emp in db.EmployeeDetails
                        join accounts in db.Accounts
                        on emp.EmployeeID equals accounts.EmployeeID
                        where accounts.Username == username
                        select new { accounts.Username, accounts.Password, emp.Position, emp.EmployeeID }).FirstOrDefault();

            // Check if authentication is successful
            if (auth != null && auth.Password == password)
            {
                employeeID = auth.EmployeeID;
                position = auth.Position;
                return true; // Login successful
            }

            return false; // Login failed
        }
    }
}
