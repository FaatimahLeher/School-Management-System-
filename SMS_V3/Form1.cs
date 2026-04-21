using System;
using System.Windows.Forms;
namespace SMS_V3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // --- 1. DASHBOARD BUTTON (Home) ---
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            // This reloads the form to bring back your original cards/zeros
            Form1 home = new Form1();
            home.Show();
            this.Dispose();
        }

        // --- 2. STUDENTS SIDEBAR BUTTON ---
        private void button2_Click(object sender, EventArgs e)
        {
            // Clear the dashboard cards
            pnlMain.Controls.Clear();

            // Load the Students List (The table view)
            UC_Students uc = new UC_Students();
            uc.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(uc);
        }

        // --- 3. TEACHERS SIDEBAR BUTTON ---
        private void button3_Click(object sender, EventArgs e)
        {
            // Clear the dashboard cards
            pnlMain.Controls.Clear();

            // Load the Teachers List (The table view)
            UC_Teachers uc = new UC_Teachers();
            uc.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(uc);
        }

        // --- 4. ATTENDANCE SIDEBAR BUTTON ---
        /* private void button4_Click(object sender, EventArgs e)
         {
             // Clear the dashboard cards
             pnlMain.Controls.Clear();

             // Load the Attendance Page
             UC_Attendance uc = new UC_Attendance();
             uc.Dock = DockStyle.Fill;
             pnlMain.Controls.Add(uc);
         }
        */

        // This stays empty for now since we are skipping the database
        private void UpdateDashboardNumbers()
        {
            // Future database logic goes here
        }

        // Extra click events (leave these empty or delete if not linked)
        private void label2_Click(object sender, EventArgs e) { }
        private void pnlMain_Paint(object sender, PaintEventArgs e) { }

        private void btnAttendance_Click(object sender, EventArgs e)
        {

            pnlMain.Controls.Clear();
            UC_Attendance uc = new UC_Attendance();
            uc.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(uc);
        }

        private void btnClasses_Click(object sender, EventArgs e)
        {

            pnlMain.Controls.Clear();
            UC_Classes uc = new UC_Classes();
            uc.Dock = DockStyle.Fill; // Makes the whole thing fit your side panel
            pnlMain.Controls.Add(uc);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Clear the main panel and load the User Control you just built
            pnlMain.Controls.Clear();
            UC_UserManagement uc = new UC_UserManagement();
            uc.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(uc);

        }
    }
}