﻿using System;
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
        Authentication auth = new Authentication();
        bool isPasswordVisible = false;
     

        public Login()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            picClose.Parent = picWall;
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
            string position;
            int employeeID = 0;

            if (auth.Login(txtusername.Text, txtpassword.Text, out employeeID, out position))
            {
                // If position is Manager, show admin UI
                if (position == "Manager")
                {
                    MessageBox.Show("Login Successful. Welcome Admin " + txtusername.Text.ToUpper(), "Login");
                    MainForm f1 = new MainForm(employeeID); // Pass the employee's ID
                    f1.Show();
                    this.Hide();
                }
                else // Show employee info UI
                {
                    MessageBox.Show("Login Successful. Welcome " + txtusername.Text, "Login");
                    EmployeeInfo empinfo = new EmployeeInfo(employeeID); // Pass the employee's ID
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

        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
            }
        }

        private void txtpassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
            }
        }
    }
}
