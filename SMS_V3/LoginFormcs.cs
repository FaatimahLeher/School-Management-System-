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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string inputUser = txtUsername.Text;
            string inputPass = txtPassword.Text;

            // 1. Check for Admin (Staff)
            if (inputUser == "admin" && inputPass == "password123")
            {
                UserSession.TeacherID = 0; // 0 can represent "Super Admin"
                UserSession.TeacherName = "Administrator";

                ProceedToDashboard("Welcome, Admin!");
            }
            // 2. Check for Teacher A (Class 5)
            else if (inputUser == "teacher1" && inputPass == "teach123")
            {
                // This ID must match the 'AssignedTeacherID' in your SQL Students table
                UserSession.TeacherID = 1;
                UserSession.TeacherName = "Mr. Sibanda";

                ProceedToDashboard("Welcome, Mr. Sibanda!");
            }
            // 3. Check for Teacher B (Class 6)
            else if (inputUser == "teacher2" && inputPass == "teach456")
            {
                UserSession.TeacherID = 2;
                UserSession.TeacherName = "Mrs. Moyo";

                ProceedToDashboard("Welcome, Mrs. Moyo!");
            }
            else
            {
                MessageBox.Show("Invalid Credentials. Access Denied.", "Security Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Clear();
                txtUsername.Focus();
            }
        }

        // Helper method to keep the code clean
        private void ProceedToDashboard(string message)
        {
            MessageBox.Show(message, "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
            Form1 dashboard = new Form1();
            dashboard.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginFormcs login = new LoginFormcs();
            login.Show();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}