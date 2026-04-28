using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SMS_V3
{
    public partial class AddUserForm : Form
    {
        public AddUserForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnNewAccount_Click(object sender, EventArgs e)
        {


            if (cmbRole.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a user role.", "Security Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Set the result to OK so the parent form knows to update the table
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void dgvUsers_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            // Do nothing. This prevents the red "X" dialog from popping up.
            e.ThrowException = false;
        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
