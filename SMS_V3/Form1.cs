using System;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace SMS_V3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Load += new EventHandler(Form1_Load);
            UpdateDashboardStats();
        }

        private void Form1_Load(object? sender, EventArgs e)
        {
            bool isAdmin = (UserSession.TeacherID == 0);

            btnUserManagement.Visible = isAdmin;
            btnTeachers.Visible = isAdmin;

            label6.Text = "EDU-TRACK | " + (isAdmin ? "Admin Portal" : "Staff Portal");
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(tableLayoutPanel1);
            pnlMain.Controls.Add(panel5);
            UpdateDashboardStats();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            UC_Students uc = new UC_Students { Dock = DockStyle.Fill };
            pnlMain.Controls.Add(uc);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            UC_Teachers uc = new UC_Teachers { Dock = DockStyle.Fill };
            pnlMain.Controls.Add(uc);
        }

        private void btnAttendance_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            UC_Attendance uc = new UC_Attendance { Dock = DockStyle.Fill };
            pnlMain.Controls.Add(uc);
        }

        private void btnClasses_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            UC_Classes uc = new UC_Classes { Dock = DockStyle.Fill };
            pnlMain.Controls.Add(uc);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            UC_UserManagement uc = new UC_UserManagement { Dock = DockStyle.Fill };
            pnlMain.Controls.Add(uc);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            UserSession.TeacherID = -1;
            UserSession.TeacherName = string.Empty;

            this.Hide();
            LoginFormcs login = new LoginFormcs();
            login.ShowDialog();

            this.Close();
        }

        private void UpdateDashboardStats()
        {
            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    SqlCommand cmdStu = new SqlCommand("SELECT COUNT(*) FROM Students", conn);
                    lblTotalStudents.Text = cmdStu.ExecuteScalar()?.ToString() ?? "0";

                    SqlCommand cmdTea = new SqlCommand("SELECT COUNT(*) FROM Teachers", conn);
                    lblTotalTeachers.Text = cmdTea.ExecuteScalar()?.ToString() ?? "0";

                    SqlCommand cmdAtt = new SqlCommand("SELECT COUNT(*) FROM AttendanceRecords WHERE CAST(Date as DATE) = CAST(GETDATE() as DATE)", conn);
                    lblAttendanceCount.Text = cmdAtt.ExecuteScalar()?.ToString() ?? "0";

                 
                }
            }
            catch (Exception)
            {
                lblTotalStudents.Text = "0";
                lblTotalTeachers.Text = "0";
                lblAttendanceCount.Text = "0";
                
            }
        }

        private void label2_Click(object sender, EventArgs e) { }
        private void pnlMain_Paint(object sender, PaintEventArgs e) { }
    }
}