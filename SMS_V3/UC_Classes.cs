using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace SMS_V3
{
    public partial class UC_Classes : UserControl
    {
        public UC_Classes()
        {
            InitializeComponent();
            LoadClasses();
        }

        // --- 1. LOAD DATA FROM SQL (Clears CS8604 Null Warnings) ---
        public void LoadClasses()
        {
            dgvClasses.Rows.Clear();
            string query = "SELECT GradeLevel, ClassName, TeacherName, RoomNumber FROM Classes";

            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        dgvClasses.Rows.Add(
                        reader["GradeLevel"]?.ToString() ?? "",
                        reader["ClassName"]?.ToString() ?? "",
                        reader["TeacherName"]?.ToString() ?? "",
                        reader["RoomNumber"]?.ToString() ?? "",
                        "Delete",
                        "Edit");
                    
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading database: " + ex.Message);
            }
        }

        // --- 2. ADD CLASS BUTTON ---
        private void btnAddClass_Click(object sender, EventArgs e)
        {
            AddClassForm popup = new AddClassForm();
            if (popup.ShowDialog() == DialogResult.OK)
            {
                LoadClasses(); // Refresh after successful save in AddClassForm
            }
        }

        // --- 3. EDIT & DELETE LOGIC ---
        private void dgvClasses_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            // DELETE LOGIC
            if (dgvClasses.Columns[e.ColumnIndex].Name == "colDelete")
            {
                // Safely get class name to avoid CS8604 warning
                string className = dgvClasses.Rows[e.RowIndex].Cells["colClassName"].Value?.ToString() ?? "";

                if (!string.IsNullOrEmpty(className) && MessageBox.Show($"Are you sure you want to remove {className}?",
                    "Security Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    DeleteClassFromDB(className);
                    LoadClasses();
                }
            }

            // EDIT LOGIC
            if (dgvClasses.Columns[e.ColumnIndex].Name == "colEdit")
            {
                AddClassForm editForm = new AddClassForm();

                // Populate form fields safely
                editForm.cboGrade.Text = dgvClasses.Rows[e.RowIndex].Cells["colGrade"].Value?.ToString() ?? "";
                editForm.txtClassName.Text = dgvClasses.Rows[e.RowIndex].Cells["colClassName"].Value?.ToString() ?? "";
                editForm.cboTeacher.Text = dgvClasses.Rows[e.RowIndex].Cells["colTeacher"].Value?.ToString() ?? "";
                editForm.txtRoom.Text = dgvClasses.Rows[e.RowIndex].Cells["colRoom"].Value?.ToString() ?? "";

                editForm.lblTitle.Text = "UPDATE CLASS DETAILS";
                editForm.btnCreateClass.Text = "UPDATE";
                editForm.txtClassName.ReadOnly = true;

                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    LoadClasses();
                }
            }
        }

        // --- 4. DATABASE DELETE HELPER ---
        private void DeleteClassFromDB(string className)
        {
            string query = "DELETE FROM Classes WHERE ClassName = @name";
            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@name", className);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message);
            }
        }

        // Event stubs to keep the Designer from breaking
        private void label1_Click(object sender, EventArgs e) { }
        private void pnlHeader_Paint(object sender, PaintEventArgs e) { }
        private void dgvClasses_ColumnHeadersDefaultCellStyleChanged(object sender, EventArgs e) { }
        private void dgvClasses_DefaultCellStyleChanged(object sender, EventArgs e) { }
    }
}