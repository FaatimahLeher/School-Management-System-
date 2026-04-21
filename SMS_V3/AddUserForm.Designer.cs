namespace SMS_V3
{
    partial class AddUserForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitle = new Label();
            name = new Label();
            txtUsername = new TextBox();
            label2 = new Label();
            txtPassword = new TextBox();
            label3 = new Label();
            cmbRole = new ComboBox();
            btnNewAccount = new Button();
            label1 = new Label();
            cmbStatus = new ComboBox();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(64, 64, 64, 64);
            lblTitle.Location = new Point(92, 44);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(264, 38);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "NEW USER ENTRY ";
            lblTitle.Click += label1_Click;
            // 
            // name
            // 
            name.AutoSize = true;
            name.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            name.ForeColor = Color.FromArgb(64, 64, 64);
            name.Location = new Point(33, 158);
            name.Name = "name";
            name.Size = new Size(117, 28);
            name.TabIndex = 3;
            name.Text = "Username: ";
            // 
            // txtUsername
            // 
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            txtUsername.ForeColor = Color.FromArgb(64, 64, 64);
            txtUsername.Location = new Point(203, 162);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(191, 24);
            txtUsername.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(64, 64, 64);
            label2.Location = new Point(33, 230);
            label2.Name = "label2";
            label2.Size = new Size(112, 28);
            label2.TabIndex = 5;
            label2.Text = "Password: ";
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            txtPassword.ForeColor = Color.FromArgb(64, 64, 64);
            txtPassword.Location = new Point(203, 230);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(191, 24);
            txtPassword.TabIndex = 6;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(64, 64, 64);
            label3.Location = new Point(33, 289);
            label3.Name = "label3";
            label3.Size = new Size(65, 28);
            label3.TabIndex = 7;
            label3.Text = "Role: ";
            // 
            // cmbRole
            // 
            cmbRole.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRole.FlatStyle = FlatStyle.Flat;
            cmbRole.FormattingEnabled = true;
            cmbRole.Items.AddRange(new object[] { "Admin", "Staff" });
            cmbRole.Location = new Point(203, 293);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(191, 28);
            cmbRole.TabIndex = 8;
            // 
            // btnNewAccount
            // 
            btnNewAccount.BackColor = Color.FromArgb(40, 167, 69);
            btnNewAccount.FlatStyle = FlatStyle.Flat;
            btnNewAccount.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNewAccount.ForeColor = Color.White;
            btnNewAccount.Location = new Point(115, 424);
            btnNewAccount.Name = "btnNewAccount";
            btnNewAccount.Size = new Size(207, 44);
            btnNewAccount.TabIndex = 9;
            btnNewAccount.Text = "CREATE ACCOUNT";
            btnNewAccount.UseVisualStyleBackColor = false;
            btnNewAccount.Click += btnNewAccount_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(33, 357);
            label1.Name = "label1";
            label1.Size = new Size(71, 28);
            label1.TabIndex = 10;
            label1.Text = "Status";
            // 
            // cmbStatus
            // 
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.FlatStyle = FlatStyle.Flat;
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Items.AddRange(new object[] { "Active,", "Inactive" });
            cmbStatus.Location = new Point(203, 361);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(191, 28);
            cmbStatus.TabIndex = 11;
            // 
            // AddUserForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(432, 553);
            Controls.Add(cmbStatus);
            Controls.Add(label1);
            Controls.Add(btnNewAccount);
            Controls.Add(cmbRole);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtPassword);
            Controls.Add(name);
            Controls.Add(txtUsername);
            Controls.Add(lblTitle);
            Name = "AddUserForm";
            Text = "AddUserForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label name;
        private Label label2;
        private Label label3;
        private Button btnNewAccount;
        public TextBox txtUsername;
        public ComboBox cmbRole;
        public Label lblTitle;
        public TextBox txtPassword;
        private Label label1;
        public ComboBox cmbStatus;
    }
}