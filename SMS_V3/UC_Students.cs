using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace SMS_V3
{
    public partial class UC_Students : UserControl
    {
        public UC_Students()
        {
            InitializeComponent();
            LoadStudents();
        }

        public void LoadStudents()
        {
            string query = "SELECT StudentID, FirstName, LastName, Grade, Contact FROM Students";
            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvStudents.Rows.Clear();
                    foreach (DataRow row in dt.Rows)
                    {
                        dgvStudents.Rows.Add(
                            row["FirstName"]?.ToString() ?? "",
                            row["LastName"]?.ToString() ?? "",
                            row["StudentID"]?.ToString() ?? "",
                            row["Grade"]?.ToString() ?? "",
                            row["Contact"]?.ToString() ?? "",
                            "Edit",
                            "Delete"
                        );
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        // IMPORTANT: Hook this to the DataGridView 'CellContentClick' event!
        private void dgvStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string id = dgvStudents.Rows[e.RowIndex].Cells["colID"].Value?.ToString() ?? "";

            // DELETE ACTION
            if (dgvStudents.Columns[e.ColumnIndex].Name == "colDelete")
            {
                if (MessageBox.Show("Delete " + id + "?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    ExecuteQuery("DELETE FROM Students WHERE StudentID = " + id);
                    LoadStudents();
                }
            }

            // EDIT ACTION
            if (dgvStudents.Columns[e.ColumnIndex].Name == "colEdit")
            {
                string fn = dgvStudents.Rows[e.RowIndex].Cells["colName"].Value?.ToString() ?? "";
                string ln = dgvStudents.Rows[e.RowIndex].Cells["colSurname"].Value?.ToString() ?? "";
                string gr = dgvStudents.Rows[e.RowIndex].Cells["colGrade"].Value?.ToString() ?? "";
                string ct = dgvStudents.Rows[e.RowIndex].Cells["colContact"].Value?.ToString() ?? "";

                AddStudentForm editForm = new AddStudentForm(id, fn, ln, gr, ct);
                if (editForm.ShowDialog() == DialogResult.OK) LoadStudents();
            }
        }

        private void ExecuteQuery(string sql)
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // IMPORTANT: Hook this to the '+ Add Student' Button 'Click' event!
        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            AddStudentForm addForm = new AddStudentForm();
            if (addForm.ShowDialog() == DialogResult.OK) LoadStudents();
        }
    }
}