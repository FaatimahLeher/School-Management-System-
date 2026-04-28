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
    public partial class UC_UserManagement : UserControl
    {
        public UC_UserManagement()
        {
            InitializeComponent();
        }

        private void UC_UserManagement_Load(object sender, EventArgs e)
        {
            if (UserSession.TeacherID != 0)
            {
                this.Visible = false;
                return;
            }
            LoadUsersFromDatabase();
        }

        private void LoadUsersFromDatabase()
        {
            dgvUsers.Rows.Clear();
            string query = "SELECT Username, Role FROM Users";

            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            dgvUsers.Rows.Add(
                                reader["Username"]?.ToString() ?? "N/A",
                                reader["Role"]?.ToString() ?? "User",
                                "Edit",
                                "Delete"
                            );
                        }
                    }
                }
            }
            catch (Exception)
            {
                // Removed 'ex' to fix CS0168 warning
            }
        }

        private void dgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (dgvUsers.Columns[e.ColumnIndex].Name == "colDeleteUser")
            {
                string? username = dgvUsers.Rows[e.RowIndex].Cells["colUsername"].Value?.ToString();

                if (string.IsNullOrEmpty(username) || username == "admin") return;

                if (MessageBox.Show($"Delete {username}?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    ExecuteDelete(username);
                    LoadUsersFromDatabase();
                }
            }
        }

        private void ExecuteDelete(string user)
        {
            string sql = "DELETE FROM Users WHERE Username = @u";
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@u", user);
                cmd.ExecuteNonQuery();
            }
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            AddUserForm popup = new AddUserForm();
            if (popup.ShowDialog() == DialogResult.OK)
            {
                SaveUserToDB(popup.txtUsername.Text, popup.txtPassword.Text, popup.cmbRole.Text);
                LoadUsersFromDatabase();
            }
        }

        private void SaveUserToDB(string u, string p, string r)
        {
            string sql = "INSERT INTO Users (Username, Password, Role) VALUES (@u, @p, @r)";

            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@u", u);
                    cmd.Parameters.AddWithValue("@p", p);
                    cmd.Parameters.AddWithValue("@r", r);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                // Error numbers 2627 and 2601 relate to Primary Key/Unique Constraint violations
                if (ex.Number == 2627 || ex.Number == 2601)
                {
                    MessageBox.Show("This username already exists. Please choose a different name.", "Duplicate User");
                }
                else
                {
                    MessageBox.Show("Database error: " + ex.Message);
                }
            }
        }

        private void dgvUsers_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
        }
    }
}