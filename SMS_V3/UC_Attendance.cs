using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace SMS_V3
{
    public partial class UC_Attendance : UserControl
    {
        public UC_Attendance()
        {
            InitializeComponent();
            // Sets the label to show today's date automatically
            lblDate.Text = "Date: " + DateTime.Now.ToString("dd MMMM yyyy");
        }

        private void UC_Attendance_Load(object sender, EventArgs e)
        {
            // 1. Clear the old rows
            dgvAttendance.Rows.Clear();

            // 2. Define the SQL query
            string query = "SELECT FirstName, LastName, StudentID FROM Students";

            try
            {
                // 3. Use your new DatabaseHelper to open the connection
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        // The reader finds the data in SQL using the SQL names:
                        string fName = reader["FirstName"].ToString() ??"";
                        string lName = reader["LastName"].ToString() ??"";
                        string sID = reader["StudentID"].ToString() ??"";

                        // The Grid puts them into colName, colSurname, and colID automatically 
                        // based on the order they appear in your Designer:
                        dgvAttendance.Rows.Add(fName, lName, sID, false);
                    }
                }
            }
            catch (Exception ex)
            {
                // If there is still a version error, it will show up here
                MessageBox.Show("Database Connection Failed: " + ex.Message);
            }
        }

        private void btnSubmitAttendance_Click(object sender, EventArgs e)
        {
            int presentCount = 0;
            int totalStudents = 0;

            foreach (DataGridViewRow row in dgvAttendance.Rows)
            {
                // Skip the empty "ghost row" at the very bottom
                if (row.IsNewRow) continue;

                totalStudents++;

                // IMPORTANT: Ensure the column name "cPresent" matches your Designer (Edit Columns)
                bool isPresent = false;
                if (row.Cells["chbPresent"].Value != null)
                {
                    isPresent = Convert.ToBoolean(row.Cells["chbPresent"].Value);
                }

                if (isPresent)
                {
                    presentCount++;
                    // FUTURE DB LOGIC: 
                    // string id = row.Cells["colID"].Value.ToString();
                    // SaveToDatabase(id, DateTime.Now, "Present");
                }
            }

            int absentCount = totalStudents - presentCount;

            MessageBox.Show($"Attendance for {DateTime.Now.ToString("dd MMM yyyy")} submitted!\n\n" +
                            $"Total Students: {totalStudents}\n" +
                            $"Present: {presentCount}\n" +
                            $"Absent: {absentCount}",
                            "HIT Attendance System",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }

        // Keep these empty or delete them if you aren't using them
        private void dgvAttendance_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
    }
}