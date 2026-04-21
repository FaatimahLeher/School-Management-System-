namespace SMS_V3
{
    partial class UC_Students
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            label1 = new Label();
            btnAddStudent = new Button();
            dgvStudents = new DataGridView();
            colName = new DataGridViewTextBoxColumn();
            colSurname = new DataGridViewTextBoxColumn();
            colID = new DataGridViewTextBoxColumn();
            colGrade = new DataGridViewTextBoxColumn();
            colContact = new DataGridViewTextBoxColumn();
            colEdit = new DataGridViewButtonColumn();
            colDelete = new DataGridViewButtonColumn();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(64, 64, 64, 64);
            label1.Location = new Point(364, 0);
            label1.Name = "label1";
            label1.Size = new Size(336, 41);
            label1.TabIndex = 0;
            label1.Text = "STUDENT DIRECTORY \r\n";
            // 
            // btnAddStudent
            // 
            btnAddStudent.BackColor = Color.FromArgb(40, 167, 69);
            btnAddStudent.FlatAppearance.BorderSize = 0;
            btnAddStudent.FlatStyle = FlatStyle.Flat;
            btnAddStudent.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddStudent.ForeColor = Color.White;
            btnAddStudent.Location = new Point(0, 0);
            btnAddStudent.Name = "btnAddStudent";
            btnAddStudent.Size = new Size(162, 37);
            btnAddStudent.TabIndex = 1;
            btnAddStudent.Text = "+ Add Student";
            btnAddStudent.UseVisualStyleBackColor = false;
            btnAddStudent.Click += btnAddStudent_Click;
            // 
            // dgvStudents
            // 
            dgvStudents.AllowUserToDeleteRows = false;
            dgvStudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvStudents.BackgroundColor = Color.White;
            dgvStudents.BorderStyle = BorderStyle.None;
            dgvStudents.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvStudents.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudents.Columns.AddRange(new DataGridViewColumn[] { colName, colSurname, colID, colGrade, colContact, colEdit, colDelete });
            dgvStudents.Dock = DockStyle.Fill;
            dgvStudents.Location = new Point(0, 100);
            dgvStudents.Name = "dgvStudents";
            dgvStudents.RowHeadersVisible = false;
            dgvStudents.RowHeadersWidth = 51;
            dgvStudents.ShowRowErrors = false;
            dgvStudents.Size = new Size(900, 500);
            dgvStudents.TabIndex = 2;
            dgvStudents.CellContentClick += dgvStudents_CellContentClick;
            // 
            // colName
            // 
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.ForeColor = Color.Black;
            colName.DefaultCellStyle = dataGridViewCellStyle2;
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
            colID.HeaderText = "Student ID ";
            colID.MinimumWidth = 6;
            colID.Name = "colID";
            // 
            // colGrade
            // 
            colGrade.HeaderText = "Grade";
            colGrade.MinimumWidth = 6;
            colGrade.Name = "colGrade";
            // 
            // colContact
            // 
            colContact.HeaderText = "Contact Details";
            colContact.MinimumWidth = 6;
            colContact.Name = "colContact";
            // 
            // colEdit
            // 
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(224, 224, 224);
            colEdit.DefaultCellStyle = dataGridViewCellStyle3;
            colEdit.HeaderText = "Edit";
            colEdit.MinimumWidth = 6;
            colEdit.Name = "colEdit";
            colEdit.UseColumnTextForButtonValue = true;
            // 
            // colDelete
            // 
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.ForeColor = Color.Red;
            colDelete.DefaultCellStyle = dataGridViewCellStyle4;
            colDelete.HeaderText = "Delete";
            colDelete.MinimumWidth = 6;
            colDelete.Name = "colDelete";
            colDelete.UseColumnTextForButtonValue = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnAddStudent);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(900, 100);
            panel1.TabIndex = 3;
            // 
            // UC_Students
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            Controls.Add(dgvStudents);
            Controls.Add(panel1);
            Name = "UC_Students";
            Size = new Size(900, 600);
            ((System.ComponentModel.ISupportInitialize)dgvStudents).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button btnAddStudent;
        private DataGridView dgvStudents;
        private Panel panel1;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colSurname;
        private DataGridViewTextBoxColumn colID;
        private DataGridViewTextBoxColumn colGrade;
        private DataGridViewTextBoxColumn colContact;
        private DataGridViewButtonColumn colEdit;
        private DataGridViewButtonColumn colDelete;
    }
}
