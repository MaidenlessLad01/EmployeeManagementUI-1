using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace EmployeeUI
{
    internal class Employee : Dashboard
    {
        //Fields
        database1DataContext db = new database1DataContext();

        public void AddEmployee(string lastName, string firstName, string middleName, DateTime dob,
                            string phoneNumber, string gender, string email, string position,
                            string username, string password, decimal hourlyrate)
        {
            // Perform input validation
            string validationError = ValidateInputs(lastName, firstName, middleName, dob, phoneNumber, gender, email, position, username, password);

            if (!string.IsNullOrEmpty(validationError))
            {
                throw new Exception("Validation Error: " + validationError); // Throw error if validation fails
            }

            // If validation passes, proceed with adding the employee
            try
            {
                bool UserExist = db.Accounts.Any(a => a.Username == username);

                if (UserExist)
                {
                    throw new Exception("Username taken. Please enter a different username");
                }

                db.AddEmployeeAcc(lastName, firstName, middleName, dob, phoneNumber, gender, email, position, username, password, hourlyrate);
            }
            catch (Exception ex)
            {
                // Handle exceptions
                throw new Exception("Error adding employee: " + ex.Message);
            }
        }

        // Method for input validation
        private string ValidateInputs(string lastName, string firstName, string middleName, DateTime dob, string phoneNumber,
                                      string gender, string email, string position, string username, string password)
        {
            string errorMsg = "";

            // Display error messages if required fields are empty or invalid
            if (string.IsNullOrWhiteSpace(lastName))
                errorMsg += "Last Name is required.\n";
            if (string.IsNullOrWhiteSpace(firstName))
                errorMsg += "First Name is required.\n";
            if (string.IsNullOrWhiteSpace(middleName))
                errorMsg += "Middle Name is required.\n";
            if (dob == null || dob > DateTime.Now)
                errorMsg += "Date of Birth is invalid or missing.\n";
            if (string.IsNullOrWhiteSpace(phoneNumber))
                errorMsg += "Phone Number is required.\n";
            else if (!IsValidPhoneNumber(phoneNumber))
                errorMsg += "Phone Number format is invalid.\n";
            if (string.IsNullOrWhiteSpace(gender))
                errorMsg += "Gender is required.\n";
            if (string.IsNullOrWhiteSpace(email))
                errorMsg += "Email is required.\n";
            else if (!IsValidEmail(email))
                errorMsg += "Email format is invalid.\n";
            if (string.IsNullOrWhiteSpace(position))
                errorMsg += "Position is required.\n";
            if (string.IsNullOrWhiteSpace(username))
                errorMsg += "Username is required.\n";
            if (string.IsNullOrWhiteSpace(password))
                errorMsg += "Password is required.\n";

            return errorMsg; // Return all error messages as a single string
        }

        // Method to validate email format
        private bool IsValidEmail(string email)
        {
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$"; 
            return Regex.IsMatch(email, pattern);
        }
        // Method to validate phone number format
        private bool IsValidPhoneNumber(string phoneNumber)
        {
            string pattern = @"^\+?[\d\s\-()]{7,15}$"; 
            return Regex.IsMatch(phoneNumber, pattern);
        }
        public decimal GetHourlyRate(string position)
        {
            decimal hourlyRate = 0;

            switch (position)
            {
                case "Intern":
                    hourlyRate = 7.00M;
                    break;
                case "Junior Developer":
                    hourlyRate = 9.00M;
                    break;
                case "Senior Developer":
                    hourlyRate = 11.00M;
                    break;
                case "Team Leader":
                    hourlyRate = 13.00M;
                    break;
                case "Manager":
                    hourlyRate = 15.00M;
                    break;
                default:
                    hourlyRate = 0.00M;  // Default rate if no match
                    break;
            }

            return hourlyRate;
        }

        public void UpdateEmployee( int employeeID, string LName, string FName, string MName, DateTime DoB, string PhoneNumber, string Gender, string Email,string Position, string Status, decimal hourlyrate)
        {
            // Retrieve the employee record from the database
            var employee = db.EmployeeDetails.SingleOrDefault(e => e.EmployeeID == employeeID);
            
            if (employee != null)
            {

                db.UpdateEmpInfo(employeeID,LName,FName,MName,DoB,PhoneNumber,Gender,Email,Position,Status,hourlyrate);

            }
            else
            {
                throw new Exception("Employee not found");
            }
        }
        public void ArchiveEmployee(int employeeID)
        {
            // Retrieve the employee record from the database
            var employee = db.EmployeeDetails.SingleOrDefault(e => e.EmployeeID == employeeID);

            if (employee != null)
            {
                // Set the employee's status to 'Inactive'
                employee.Status = "Inactive";

                // Submit the changes to the database
                db.SubmitChanges();
            }
            else
            {
                throw new Exception("Employee not found");
            }
        }

    }

}
