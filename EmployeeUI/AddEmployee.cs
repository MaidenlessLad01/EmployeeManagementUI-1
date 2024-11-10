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
    public partial class AddEmployee : UserControl
    {
        
        public AddEmployee()
        {
            InitializeComponent();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtEmail.Clear();
            txtEmpID.Clear();
            txtFName.Clear();
            txtLName.Clear();
            txtMName.Clear();
            txtPhoneNum.Clear();
            cboGender.ResetText();
            cboPosition.ResetText();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DialogResult check = new DialogResult();

            check = MessageBox.Show("Are you sure you want to add employee?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (check == DialogResult.Yes)
            {
                
            }
        }
    }
}
