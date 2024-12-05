using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace EmployeeUI
{
    

    public partial class Login : Form
    {
        //var dec
        
        database1DataContext db = new database1DataContext();
        bool isPasswordVisible = false;
     

        public Login()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
        }
        private void picEye_Click(object sender, EventArgs e)
        {
            isPasswordVisible = !isPasswordVisible;

            if (isPasswordVisible)
            {
                //show password
                txtpassword.UseSystemPasswordChar = false;
               
            }
            //hide password
            else
            {
                txtpassword.UseSystemPasswordChar = true;
               
            }
        }

        private void lblRegister_MouseHover(object sender, EventArgs e)
        {
           
        }

        private void lblRegister_MouseEnter(object sender, EventArgs e)
        {
            Label label = sender as Label;
            label.Font = new Font(label.Font, FontStyle.Underline);
        }

        private void lblRegister_MouseLeave(object sender, EventArgs e)
        {
            Label label = sender as Label;
           
            label.Font = new Font(label.Font, FontStyle.Regular);
        }

        private void lblRegister_Click(object sender, EventArgs e)
        {
            RegisterAcc reg = new RegisterAcc();
            reg.Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //LINQ to get the necessary credentials sa employee nga mo log in
            var auth = (from emp in db.EmployeeDetails
                        join accounts in db.Accounts
                        on emp.EmployeeID equals accounts.EmployeeID
                        where accounts.Username == txtusername.Text
                        select new { accounts.Username, accounts.Password, emp.Position, emp.EmployeeID }).FirstOrDefault();


            //authenticate if sakto ba 
            if (auth != null && auth.Password == txtpassword.Text)
            {
                //if position kay manager, show admin UI
                if (auth.Position == "Manager")
                {
                    MessageBox.Show("Login Successful. Welcome Admin " + txtusername.Text.ToLower().ToUpper(), "Login");
                    //set the employee's ID 
                    Form1 f1 = new Form1(auth.EmployeeID);
                    f1.Show();
                    this.Hide();
                }
                else //show employeeinfo ui
                {
                    MessageBox.Show("Login Successful. Welcome " + txtusername.Text, "Login");
                    //set the employee's ID
                    EmployeeInfo empinfo = new EmployeeInfo(auth.EmployeeID);
                    empinfo.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Incorrect Credentials.\n\n(Case Sensitive)", "Error");
            }

        }

        private void pnlSideWall_Paint(object sender, PaintEventArgs e)
        {
            base.OnPaint(e);

            // Get the panel's height and width
            int panelHeight = this.Height;
            int panelWidth = this.Width;

            // Define the gradient starting from the middle to the top
            using (LinearGradientBrush brush = new LinearGradientBrush(
                new Point(0, panelHeight / 2), // Start the gradient in the middle of the panel
                new Point(0, 0),               // End the gradient at the top
                Color.Blue,                    
                Color.Transparent))            
            {
                // Fill the top half with the gradient
                e.Graphics.FillRectangle(brush, new Rectangle(0, 0, panelWidth, panelHeight / 2));
            }

            // Fill the bottom half with solid blue color
            using (SolidBrush solidBrush = new SolidBrush(Color.Blue))
            {
                e.Graphics.FillRectangle(solidBrush, new Rectangle(0, panelHeight / 2, panelWidth, panelHeight / 2));
            }
        }

        private void picWall_Paint(object sender, PaintEventArgs e)
        {
            base.OnPaint(e);

            // Get the panel's height and width
            int panelHeight = this.Height;
            int panelWidth = this.Width;

            // Define the gradient starting from the middle to the top
            using (LinearGradientBrush brush = new LinearGradientBrush(
                new Point(0, panelHeight / 2), // Start the gradient in the middle of the panel
                new Point(0, 0),               // End the gradient at the top
                Color.Navy,                    // Solid blue color at the middle
                Color.Transparent))            // Fading to transparent at the top
            {
                // Fill the top half with the gradient
                e.Graphics.FillRectangle(brush, new Rectangle(0, 0, panelWidth, panelHeight / 2));
            }

            // Fill the bottom half with solid blue color
            using (SolidBrush solidBrush = new SolidBrush(Color.Navy))
            {
                e.Graphics.FillRectangle(solidBrush, new Rectangle(0, panelHeight / 2, panelWidth, panelHeight / 2));
            }
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
