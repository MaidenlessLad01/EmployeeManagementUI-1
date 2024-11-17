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
    public partial class Edit : UserControl
    {
        public Edit()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DialogResult check = new DialogResult();

            check = MessageBox.Show("Are you sure you want to update employee detail?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (check == DialogResult.Yes)
            {
                MessageBox.Show("Employee Detail Updated" , "Successful");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtEmail.Clear();
            txtEmpID.Clear();
            txtFName.Clear();
            txtLName.Clear();
            txtMName.Clear();
            txtPhoneNum.Clear();
            cboGender.ResetText();
            cboPosition.ResetText();
            cboStatus.ResetText();
        }

        
    }
}
