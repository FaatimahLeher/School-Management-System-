using Microsoft.Data.SqlClient;
using System;
using System.Windows.Forms;

namespace SMS_V3
{
    public partial class AddTeacherForm : Form
    {
        private bool isEditMode = false;

        public AddTeacherForm() // New Teacher
        {
            InitializeComponent();
            isEditMode = false;
            txtStaffID.ReadOnly = true;
            txtStaffID.Text = "Auto-Gen";
        }

        public AddTeacherForm(string id, string name, string surname, string subject, string dept, string contact)
        {
            InitializeComponent();
            isEditMode = true;
            txtStaffID.Text = id;
            txtFirstName.Text = name;
            txtSurname.Text = surname;
            txtDepartment.Text = dept;
            txtContact.Text = contact;
            txtStaffID.ReadOnly = true;
        }

        private void btnAddTeacher_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                MessageBox.Show("Please enter a name.");
                return;
            }

            // Fixed Query: Notice the INSERT does NOT include TeacherID
            string query = isEditMode
                ? "UPDATE Teachers SET FirstName=@fname, LastName=@lname, Department=@dept, Contact=@contact WHERE TeacherID=@id"
                : "INSERT INTO Teachers (FirstName, LastName, Department, Contact) VALUES (@fname, @lname, @dept, @contact)";

            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    if (isEditMode) cmd.Parameters.AddWithValue("@id", txtStaffID.Text);

                    cmd.Parameters.AddWithValue("@fname", txtFirstName.Text.Trim());
                    cmd.Parameters.AddWithValue("@lname", txtSurname.Text.Trim());
                    cmd.Parameters.AddWithValue("@dept", txtDepartment.Text.Trim());
                    cmd.Parameters.AddWithValue("@contact", txtContact.Text.Trim());

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void button1_Click(object sender, EventArgs e) { this.Close(); }
    }
}
