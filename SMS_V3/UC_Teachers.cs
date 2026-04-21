using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace SMS_V3
{
    public partial class UC_Teachers : UserControl
    {
        // This is the variable we'll link to your Login system later.
        // For now, it's "Admin" so you can test the buttons.
        public string UserRole = "Admin";

        public UC_Teachers()
        {
            InitializeComponent();
            LoadTeachers();
        }

        // 1. Fetch data from SQL Server and populate the Grid
        public void LoadTeachers()
        {
            // Note: SubjectSpecialty is pulled but we focus on Dept/Contact for your specific grid
            string query = "SELECT TeacherID, FirstName, LastName, Department, Contact FROM Teachers";

            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvTeachers.Rows.Clear();

                    foreach (DataRow row in dt.Rows)
                    {
                        // Match your Designer Columns: Name, Surname, ID, Dept, Contact, Edit, Delete
                          dgvTeachers.Rows.Add(
                         row["FirstName"]?.ToString() ?? "",
                         row["LastName"]?.ToString() ?? "",
                         row["TeacherID"]?.ToString() ?? "",
                         row["Department"]?.ToString() ?? "N/A",
                         row["Contact"]?.ToString() ?? ""
                     );
                                        }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading faculty: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 2. Add Teacher Logic
        private void button1_Click(object sender, EventArgs e)
        {
            AddTeacherForm addForm = new AddTeacherForm();
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                LoadTeachers(); // Refresh after adding
            }
        }

        // 3. Grid Logic (Edit and Delete)
        private void dgvTeachers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            // --- SECURITY CHECK (Applies to both Edit and Delete) ---
            if (dgvTeachers.Columns[e.ColumnIndex].Name == "colEdit" || dgvTeachers.Columns[e.ColumnIndex].Name == "colDelete")
            {
                if (UserRole != "Admin")
                {
                    MessageBox.Show("Access Denied: Only Admins can modify faculty records.", "Security", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
            }

            // --- 1. THE DELETE LOGIC ---
            if (dgvTeachers.Columns[e.ColumnIndex].Name == "colDelete")
            {
                string teacherId = dgvTeachers.Rows[e.RowIndex].Cells["colID"].Value?.ToString() ?? "";
                string teacherName = dgvTeachers.Rows[e.RowIndex].Cells["colName"].Value?.ToString() ?? "";

                DialogResult result = MessageBox.Show($"Are you sure you want to permanently delete {teacherName} (ID: {teacherId})?",
                                                    "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        using (SqlConnection conn = DatabaseHelper.GetConnection())
                        {
                            string query = "DELETE FROM Teachers WHERE TeacherID = @id";
                            SqlCommand cmd = new SqlCommand(query, conn);
                            cmd.Parameters.AddWithValue("@id", teacherId);

                            conn.Open();
                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Record deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadTeachers(); // Refresh grid
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Database Error during delete: " + ex.Message);
                    }
                }
            }

            // --- 2. THE EDIT LOGIC ---
            if (dgvTeachers.Columns[e.ColumnIndex].Name == "colEdit")
            {
                // Pull values safely using null-coalescing ?? ""
                string id = dgvTeachers.Rows[e.RowIndex].Cells["colID"].Value?.ToString() ?? "";
                string fn = dgvTeachers.Rows[e.RowIndex].Cells["colName"].Value?.ToString() ?? "";
                string ln = dgvTeachers.Rows[e.RowIndex].Cells["colSurname"].Value?.ToString() ?? "";
                string dp = dgvTeachers.Rows[e.RowIndex].Cells["colDepartment"].Value?.ToString() ?? "";
                string ct = dgvTeachers.Rows[e.RowIndex].Cells["colContact"].Value?.ToString() ?? "";

                // Use the Edit Constructor we created in AddTeacherForm
                AddTeacherForm editForm = new AddTeacherForm(id, fn, ln, "General", dp, ct);

                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    LoadTeachers(); // Refresh grid after update
                }
            }
        }

        // Empty methods to satisfy Designer events
        private void panel1_Paint(object sender, PaintEventArgs e) { }
        private void lblTitle_Click(object sender, EventArgs e) { }
    }
}