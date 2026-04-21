namespace SMS_V3
{
    partial class UC_Attendance
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
            label1 = new Label();
            lblDate = new Label();
            dgvAttendance = new DataGridView();
            colName = new DataGridViewTextBoxColumn();
            colSurname = new DataGridViewTextBoxColumn();
            colID = new DataGridViewTextBoxColumn();
            chbPresent = new DataGridViewCheckBoxColumn();
            panel1 = new Panel();
            btnSubmitAttendance = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvAttendance).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(64, 63, 63, 63);
            label1.Location = new Point(269, 14);
            label1.Name = "label1";
            label1.Size = new Size(308, 41);
            label1.TabIndex = 0;
            label1.Text = "DAILY ATTENDANCE";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.BackColor = Color.White;
            lblDate.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDate.ForeColor = Color.FromArgb(64, 64, 64, 64);
            lblDate.Location = new Point(377, 55);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(168, 23);
            lblDate.TabIndex = 1;
            lblDate.Text = "Date: 14 April 2026";
            lblDate.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgvAttendance
            // 
            dgvAttendance.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAttendance.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.LightGray;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvAttendance.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvAttendance.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAttendance.Columns.AddRange(new DataGridViewColumn[] { colName, colSurname, colID, chbPresent });
            dgvAttendance.Dock = DockStyle.Fill;
            dgvAttendance.Location = new Point(0, 100);
            dgvAttendance.Name = "dgvAttendance";
            dgvAttendance.RowHeadersVisible = false;
            dgvAttendance.RowHeadersWidth = 51;
            dgvAttendance.Size = new Size(900, 500);
            dgvAttendance.TabIndex = 2;
            // 
            // colName
            // 
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.ButtonFace;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            colName.DefaultCellStyle = dataGridViewCellStyle2;
            colName.HeaderText = "Name ";
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
            colID.HeaderText = "Student ID";
            colID.MinimumWidth = 6;
            colID.Name = "colID";
            // 
            // chbPresent
            // 
            chbPresent.HeaderText = "Is Present?";
            chbPresent.MinimumWidth = 6;
            chbPresent.Name = "chbPresent";
            chbPresent.Resizable = DataGridViewTriState.True;
            chbPresent.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btnSubmitAttendance);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lblDate);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(900, 100);
            panel1.TabIndex = 3;
            // 
            // btnSubmitAttendance
            // 
            btnSubmitAttendance.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSubmitAttendance.BackColor = Color.FromArgb(40, 167, 69);
            btnSubmitAttendance.FlatAppearance.BorderSize = 0;
            btnSubmitAttendance.FlatStyle = FlatStyle.Flat;
            btnSubmitAttendance.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSubmitAttendance.ForeColor = Color.White;
            btnSubmitAttendance.Location = new Point(0, 0);
            btnSubmitAttendance.Name = "btnSubmitAttendance";
            btnSubmitAttendance.Size = new Size(199, 42);
            btnSubmitAttendance.TabIndex = 0;
            btnSubmitAttendance.Text = "Submit Attendance";
            btnSubmitAttendance.UseVisualStyleBackColor = false;
            btnSubmitAttendance.Click += btnSubmitAttendance_Click;
            // 
            // UC_Attendance
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dgvAttendance);
            Controls.Add(panel1);
            Name = "UC_Attendance";
            Size = new Size(900, 600);
            Load += UC_Attendance_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAttendance).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label lblDate;
        private DataGridView dgvAttendance;
        private Panel panel1;
        private Button btnSubmitAttendance;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colSurname;
        private DataGridViewTextBoxColumn colID;
        private DataGridViewCheckBoxColumn chbPresent;
    }
}
