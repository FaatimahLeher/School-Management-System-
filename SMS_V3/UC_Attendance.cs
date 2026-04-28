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
            lblDate.Text = "Date: " + DateTime.Now.ToString("dd MMMM yyyy");
        }

        private void UC_Attendance_Load(object sender, EventArgs e)
        {
            dgvAttendance.Rows.Clear();

            string query = (UserSession.TeacherID == 0)
                ? "SELECT FirstName, LastName, StudentID FROM Students"
                : "SELECT FirstName, LastName, StudentID FROM Students WHERE AssignedTeacherID = @tID";

            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        if (UserSession.TeacherID != 0)
                            cmd.Parameters.AddWithValue("@tID", UserSession.TeacherID);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                dgvAttendance.Rows.Add(
                                    reader["FirstName"]?.ToString() ?? "",
                                    reader["LastName"]?.ToString() ?? "",
                                    reader["StudentID"]?.ToString() ?? "",
                                    false
                                );
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loading Error: " + ex.Message);
            }
        }

        private void btnSubmitAttendance_Click(object sender, EventArgs e)
        {
            int presentCount = 0;
            int totalStudents = 0;

            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    foreach (DataGridViewRow row in dgvAttendance.Rows)
                    {
                        if (row.IsNewRow || row.Cells[2].Value == null) continue;

                        totalStudents++;
                        string sID = row.Cells[2].Value.ToString()!; // '!' fixes the warning

                        bool isPresent = false;
                        if (row.Cells[3].Value != null)
                            isPresent = Convert.ToBoolean(row.Cells[3].Value);

                        string status = isPresent ? "Present" : "Absent";
                        if (isPresent) presentCount++;

                        string sql = "INSERT INTO AttendanceRecords (StudentID, Status, Date) VALUES (@id, @status, GETDATE())";
                        using (SqlCommand cmd = new SqlCommand(sql, conn))
                        {
                            cmd.Parameters.AddWithValue("@id", sID);
                            cmd.Parameters.AddWithValue("@status", status);
                            cmd.ExecuteNonQuery();
                        }
                    }
                }

                MessageBox.Show($"Success! Attendance saved.\nPresent: {presentCount}\nAbsent: {totalStudents - presentCount}",
                                "HIT Management System", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Save Error: " + ex.Message);
            }
        }
    }
}