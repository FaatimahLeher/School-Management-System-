using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SMS_V3
{
    public partial class LoginFormcs : Form
    {
        public LoginFormcs()
        {
            InitializeComponent();
        }

        private void lblUsername_Click(object sender, EventArgs e)
        {


        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
           
            // Hardcoded credentials for now (We will move these to the DB tomorrow)
            string username = "admin";
            string password = "password123";

            if (txtUsername.Text == username && txtPassword.Text == password)
            {
                MessageBox.Show("Login Successful!", "Security System", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // This is the important part:
                this.Hide();                // Hide the login form
                Form1 dashboard = new Form1();
                dashboard.Show();           // Show your main dashboard
            }
            else
            {
                MessageBox.Show("Invalid Credentials. Access Denied.", "Security Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Clear();
                txtUsername.Focus();
            }
        }
    }
    }

