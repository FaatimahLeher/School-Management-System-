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

        private void dgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ignore clicks on header rows or empty space
            if (e.RowIndex < 0) return;

            // --- 1. DELETE LOGIC ---
            if (dgvUsers.Columns[e.ColumnIndex].Name == "colDeleteUser")
            {
                DialogResult result = MessageBox.Show("Are you sure you want to revoke access for this user?",
                                                    "Security Warning",
                                                    MessageBoxButtons.YesNo,
                                                    MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    dgvUsers.Rows.RemoveAt(e.RowIndex);
                }
            }

            // --- 2. EDIT LOGIC ---
            if (dgvUsers.Columns[e.ColumnIndex].Name == "colEditUser")
            {
                AddUserForm editPopup = new AddUserForm();

                // PULL: Transfer current row data into the Popup textboxes/combos
                // Check these Column Names (colUsername, etc) against your Designer names!
                editPopup.txtUsername.Text = dgvUsers.Rows[e.RowIndex].Cells["colUsername"].Value?.ToString();
                editPopup.cmbRole.Text = dgvUsers.Rows[e.RowIndex].Cells["colRole"].Value?.ToString();
                editPopup.cmbStatus.Text = dgvUsers.Rows[e.RowIndex].Cells["cmbStatus"].Value?.ToString();

                editPopup.lblTitle.Text = "EDIT USER DETAILS";

                if (editPopup.ShowDialog() == DialogResult.OK)
                {
                    // PUSH: Transfer data from Popup back to the specific row
                    dgvUsers.Rows[e.RowIndex].Cells["colUsername"].Value = editPopup.txtUsername.Text;
                    dgvUsers.Rows[e.RowIndex].Cells["colRole"].Value = editPopup.cmbRole.Text;
                    dgvUsers.Rows[e.RowIndex].Cells["cmbStatus"].Value = editPopup.cmbStatus.Text;

                    dgvUsers.Refresh();
                    MessageBox.Show("User updated successfully.");
                }
            }
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            AddUserForm popup = new AddUserForm();

            if (popup.ShowDialog() == DialogResult.OK)
            {
                // 1. Validation 
                if (string.IsNullOrWhiteSpace(popup.txtUsername.Text) || string.IsNullOrWhiteSpace(popup.txtPassword.Text))
                {
                    MessageBox.Show("Username and Password cannot be empty.", "Security Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                dgvUsers.Rows.Add(
                popup.txtUsername.Text,
                popup.cmbRole.Text,      // This pulls what the user picked in the popup
                DateTime.Now.ToString("dd/MM/yyyy HH:mm"),
                popup.cmbStatus.Text,    // This pulls "Active" or "Inactive"
                "Edit",
                "Delete");
            }
          

                dgvUsers.ClearSelection();
            }
        

        // Prevents the "DataGridViewComboBoxCell value is not valid" crash
        private void dgvUsers_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            // Do not remove this. It handles data mismatches in ComboBox columns silently.
            e.ThrowException = false;
        }
    }
}