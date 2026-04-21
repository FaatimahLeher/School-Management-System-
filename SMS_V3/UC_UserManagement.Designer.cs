namespace SMS_V3
{
    partial class UC_UserManagement
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            pnlHeader = new Panel();
            btnAddUser = new Button();
            lblTitle = new Label();
            dgvUsers = new DataGridView();
            colUsername = new DataGridViewTextBoxColumn();
            colRole = new DataGridViewComboBoxColumn();
            colLogin = new DataGridViewTextBoxColumn();
            cmbStatus = new DataGridViewComboBoxColumn();
            colEditUser = new DataGridViewButtonColumn();
            colDeleteUser = new DataGridViewButtonColumn();
            pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.White;
            pnlHeader.Controls.Add(btnAddUser);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(900, 100);
            pnlHeader.TabIndex = 1;
            // 
            // btnAddUser
            // 
            btnAddUser.BackColor = Color.FromArgb(40, 167, 69);
            btnAddUser.FlatStyle = FlatStyle.Flat;
            btnAddUser.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddUser.ForeColor = Color.White;
            btnAddUser.Location = new Point(0, 0);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(141, 40);
            btnAddUser.TabIndex = 1;
            btnAddUser.Text = "+ Add User";
            btnAddUser.UseVisualStyleBackColor = false;
            btnAddUser.Click += btnAddUser_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(64, 64, 64);
            lblTitle.Location = new Point(261, 27);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(369, 38);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "SYSTEM ACCESS CONTROL";
            // 
            // dgvUsers
            // 
            dgvUsers.AllowUserToAddRows = false;
            dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUsers.BackgroundColor = Color.White;
            dgvUsers.BorderStyle = BorderStyle.None;
            dgvUsers.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.ButtonFace;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvUsers.ColumnHeadersHeight = 45;
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvUsers.Columns.AddRange(new DataGridViewColumn[] { colUsername, colRole, colLogin, cmbStatus, colEditUser, colDeleteUser });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.ButtonShadow;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvUsers.DefaultCellStyle = dataGridViewCellStyle2;
            dgvUsers.Dock = DockStyle.Fill;
            dgvUsers.EnableHeadersVisualStyles = false;
            dgvUsers.Location = new Point(0, 100);
            dgvUsers.Name = "dgvUsers";
            dgvUsers.RowHeadersVisible = false;
            dgvUsers.RowHeadersWidth = 51;
            dgvUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsers.Size = new Size(900, 500);
            dgvUsers.TabIndex = 2;
            dgvUsers.CellContentClick += dgvUsers_CellContentClick;
            dgvUsers.DataError += dgvUsers_DataError;
            // 
            // colUsername
            // 
            colUsername.HeaderText = "Username";
            colUsername.MinimumWidth = 6;
            colUsername.Name = "colUsername";
            // 
            // colRole
            // 
            colRole.HeaderText = "Role";
            colRole.Items.AddRange(new object[] { "Admin,", "Staff" });
            colRole.MinimumWidth = 6;
            colRole.Name = "colRole";
            colRole.ReadOnly = true;
            // 
            // colLogin
            // 
            colLogin.HeaderText = "Last Login Date";
            colLogin.MinimumWidth = 6;
            colLogin.Name = "colLogin";
            colLogin.ReadOnly = true;
            // 
            // cmbStatus
            // 
            cmbStatus.HeaderText = "Status";
            cmbStatus.Items.AddRange(new object[] { "Active,", "Inactive" });
            cmbStatus.MinimumWidth = 6;
            cmbStatus.Name = "cmbStatus";
            cmbStatus.ReadOnly = true;
            // 
            // colEditUser
            // 
            colEditUser.HeaderText = "Edit";
            colEditUser.MinimumWidth = 6;
            colEditUser.Name = "colEditUser";
            // 
            // colDeleteUser
            // 
            colDeleteUser.HeaderText = "Delete";
            colDeleteUser.MinimumWidth = 6;
            colDeleteUser.Name = "colDeleteUser";
            // 
            // UC_UserManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(dgvUsers);
            Controls.Add(pnlHeader);
            Name = "UC_UserManagement";
            Size = new Size(900, 600);
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Button btnAddUser;
        public Label lblTitle;
        public DataGridView dgvUsers;
        private DataGridViewTextBoxColumn colUsername;
        private DataGridViewComboBoxColumn colRole;
        private DataGridViewTextBoxColumn colLogin;
        private DataGridViewComboBoxColumn cmbStatus;
        private DataGridViewButtonColumn colEditUser;
        private DataGridViewButtonColumn colDeleteUser;
    }
}
