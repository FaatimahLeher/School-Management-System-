namespace SMS_V3
{
    partial class UC_Teachers
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            lblTitle = new Label();
            btnAddTeacher = new Button();
            dgvTeachers = new DataGridView();
            colName = new DataGridViewTextBoxColumn();
            colSurname = new DataGridViewTextBoxColumn();
            colID = new DataGridViewTextBoxColumn();
            colDepartment = new DataGridViewTextBoxColumn();
            colContact = new DataGridViewTextBoxColumn();
            colEdit = new DataGridViewButtonColumn();
            colDelete = new DataGridViewButtonColumn();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvTeachers).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.White;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(64, 64, 64);
            lblTitle.Location = new Point(240, 23);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(325, 41);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "FACULTY DIRECTORY ";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnAddTeacher
            // 
            btnAddTeacher.BackColor = Color.FromArgb(40, 167, 69);
            btnAddTeacher.FlatAppearance.BorderSize = 0;
            btnAddTeacher.FlatStyle = FlatStyle.Flat;
            btnAddTeacher.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddTeacher.ForeColor = Color.White;
            btnAddTeacher.Location = new Point(0, 0);
            btnAddTeacher.Name = "btnAddTeacher";
            btnAddTeacher.Size = new Size(152, 39);
            btnAddTeacher.TabIndex = 1;
            btnAddTeacher.Text = "+ Add Teacher ";
            btnAddTeacher.UseVisualStyleBackColor = false;
            btnAddTeacher.Click += button1_Click;
            // 
            // dgvTeachers
            // 
            dgvTeachers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTeachers.BackgroundColor = Color.White;
            dgvTeachers.BorderStyle = BorderStyle.None;
            dgvTeachers.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvTeachers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvTeachers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTeachers.Columns.AddRange(new DataGridViewColumn[] { colName, colSurname, colID, colDepartment, colContact, colEdit, colDelete });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.Gray;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvTeachers.DefaultCellStyle = dataGridViewCellStyle3;
            dgvTeachers.Dock = DockStyle.Fill;
            dgvTeachers.EnableHeadersVisualStyles = false;
            dgvTeachers.Location = new Point(0, 100);
            dgvTeachers.Name = "dgvTeachers";
            dgvTeachers.RowHeadersVisible = false;
            dgvTeachers.RowHeadersWidth = 51;
            dgvTeachers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTeachers.Size = new Size(900, 500);
            dgvTeachers.TabIndex = 2;
            dgvTeachers.CellClick += dgvTeachers_CellContentClick;
            // 
            // colName
            // 
            colName.HeaderText = "Name";
            colName.MinimumWidth = 6;
            colName.Name = "colName";
            // 
            // colSurname
            // 
            colSurname.HeaderText = "Surname";
            colSurname.MinimumWidth = 6;
            colSurname.Name = "colSurname";
            // 
            // colID
            // 
            colID.HeaderText = "Teacher ID ";
            colID.MinimumWidth = 6;
            colID.Name = "colID";
            // 
            // colDepartment
            // 
            colDepartment.HeaderText = "Department";
            colDepartment.MinimumWidth = 6;
            colDepartment.Name = "colDepartment";
            // 
            // colContact
            // 
            colContact.HeaderText = "Contact Details";
            colContact.MinimumWidth = 6;
            colContact.Name = "colContact";
            // 
            // colEdit
            // 
            colEdit.HeaderText = "Edit";
            colEdit.MinimumWidth = 6;
            colEdit.Name = "colEdit";
            colEdit.UseColumnTextForButtonValue = true;
            // 
            // colDelete
            // 
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.ForeColor = Color.Red;
            colDelete.DefaultCellStyle = dataGridViewCellStyle2;
            colDelete.HeaderText = "Delete";
            colDelete.MinimumWidth = 6;
            colDelete.Name = "colDelete";
            colDelete.UseColumnTextForButtonValue = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnAddTeacher);
            panel1.Controls.Add(lblTitle);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(900, 100);
            panel1.TabIndex = 0;
            // 
            // UC_Teachers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(dgvTeachers);
            Controls.Add(panel1);
            Margin = new Padding(0);
            Name = "UC_Teachers";
            Size = new Size(900, 600);
            ((System.ComponentModel.ISupportInitialize)dgvTeachers).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitle;
        private Button btnAddTeacher;
        private Panel panel1;
        public DataGridView dgvTeachers;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colSurname;
        private DataGridViewTextBoxColumn colID;
        private DataGridViewTextBoxColumn colDepartment;
        private DataGridViewTextBoxColumn colContact;
        private DataGridViewButtonColumn colEdit;
        private DataGridViewButtonColumn colDelete;
    }
}
