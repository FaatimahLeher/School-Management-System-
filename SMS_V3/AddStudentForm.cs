using Microsoft.Data.SqlClient;
using System;
using System.Windows.Forms;

namespace SMS_V3
{
    public partial class AddStudentForm : Form
    {
        private bool isEdit = false;

        public AddStudentForm(string id = "", string fn = "", string ln = "", string gr = "", string ct = "")
        {
            InitializeComponent();
            if (!string.IsNullOrEmpty(id))
            {
                isEdit = true;
                txtStudentID.Text = id; // Ensure Name property is 'txtStudentID'
                txtFirstName.Text = fn;
                txtLastName.Text = ln;
                txtGrade.Text = gr;
                txtContact.Text = ct;
            }
        }

        // SAVE BUTTON
        private void btnSaveStudent_Click(object sender, EventArgs e)
        {
            string query = isEdit
                ? "UPDATE Students SET FirstName=@fn, LastName=@ln, Grade=@gr, Contact=@ct WHERE StudentID=@id"
                : "INSERT INTO Students (FirstName, LastName, Grade, Contact) VALUES (@fn, @ln, @gr, @ct)";

            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                if (isEdit) cmd.Parameters.AddWithValue("@id", txtStudentID.Text);
                cmd.Parameters.AddWithValue("@fn", txtFirstName.Text);
                cmd.Parameters.AddWithValue("@ln", txtLastName.Text);
                cmd.Parameters.AddWithValue("@gr", txtGrade.Text);
                cmd.Parameters.AddWithValue("@ct", txtContact.Text);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            this.DialogResult = DialogResult.OK;
        }

        // CANCEL BUTTON
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}