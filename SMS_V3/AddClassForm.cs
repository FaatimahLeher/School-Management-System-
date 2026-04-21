using Microsoft.Data.SqlClient;
using System;
using System.Windows.Forms;

namespace SMS_V3
{
    public partial class AddClassForm : Form
    {
        public AddClassForm()
        {
            InitializeComponent();
        }

        private void btnSaveClass_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtClassName.Text))
            {
                MessageBox.Show("Please enter a Class Name.", "Missing Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query;
            if (txtClassName.ReadOnly)
            {
                query = "UPDATE Classes SET GradeLevel = @level, TeacherName = @teacher, RoomNumber = @room WHERE ClassName = @name";
            }
            else
            {
                query = "INSERT INTO Classes (ClassName, GradeLevel, TeacherName, RoomNumber) VALUES (@name, @level, @teacher, @room)";
            }

            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    if (conn == null) throw new Exception("Database connection failed.");

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@name", txtClassName.Text.Trim() ?? "");
                    cmd.Parameters.AddWithValue("@level", cboGrade.Text ?? "");
                    cmd.Parameters.AddWithValue("@teacher", cboTeacher.Text ?? "");
                    cmd.Parameters.AddWithValue("@room", txtRoom.Text.Trim() ?? "");

                    conn.Open();
                    cmd.ExecuteNonQuery();

                    string msg = txtClassName.ReadOnly ? "Class updated!" : "Class registered!";
                    MessageBox.Show(msg, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (SqlException sqlEx) when (sqlEx.Number == 2627)
            {
                MessageBox.Show("This Class Name already exists.", "Duplicate", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // This handles the Cancel button click
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close(); // This explicitly closes the window
        }

        // If your designer created a second handler, point it to the first one
        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            btnCancel_Click(sender, e);
        }

        // Cleaning up unused handlers to prevent errors
        private void txtRoom_TextChanged(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
    }
}