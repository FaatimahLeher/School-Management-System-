namespace SMS_V3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlSidebar = new Panel();
            btnLogout = new Button();
            btnUserManagement = new Button();
            btnAttendance = new Button();
            btnClasses = new Button();
            btnTeachers = new Button();
            btnStudents = new Button();
            btnDashboard = new Button();
            pnlHeader = new Panel();
            label6 = new Label();
            pnlMain = new Panel();
            panel5 = new Panel();
            label5 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            lblTotalStudents = new Label();
            label1 = new Label();
            panel2 = new Panel();
            lblTotalTeachers = new Label();
            label2 = new Label();
            panel3 = new Panel();
            lblAttendanceCount = new Label();
            label3 = new Label();
            panel4 = new Panel();
            lblNotificationsCount = new Label();
            label4 = new Label();
            pnlSidebar.SuspendLayout();
            pnlHeader.SuspendLayout();
            pnlMain.SuspendLayout();
            panel5.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSidebar
            // 
            pnlSidebar.BackColor = Color.FromArgb(45, 45, 48);
            pnlSidebar.Controls.Add(btnLogout);
            pnlSidebar.Controls.Add(btnUserManagement);
            pnlSidebar.Controls.Add(btnAttendance);
            pnlSidebar.Controls.Add(btnClasses);
            pnlSidebar.Controls.Add(btnTeachers);
            pnlSidebar.Controls.Add(btnStudents);
            pnlSidebar.Controls.Add(btnDashboard);
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.Location = new Point(0, 0);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Padding = new Padding(20);
            pnlSidebar.Size = new Size(220, 553);
            pnlSidebar.TabIndex = 0;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(220, 53, 69);
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(43, 462);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(110, 44);
            btnLogout.TabIndex = 8;
            btnLogout.Text = "LOG OUT ";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnUserManagement
            // 
            btnUserManagement.Dock = DockStyle.Top;
            btnUserManagement.FlatAppearance.BorderSize = 0;
            btnUserManagement.FlatStyle = FlatStyle.Flat;
            btnUserManagement.Font = new Font("Segoe UI", 12F);
            btnUserManagement.ForeColor = Color.White;
            btnUserManagement.Location = new Point(20, 270);
            btnUserManagement.Name = "btnUserManagement";
            btnUserManagement.Size = new Size(180, 50);
            btnUserManagement.TabIndex = 5;
            btnUserManagement.Text = "System Control";
            btnUserManagement.TextAlign = ContentAlignment.MiddleLeft;
            btnUserManagement.UseVisualStyleBackColor = true;
            btnUserManagement.Click += button1_Click;
            // 
            // btnAttendance
            // 
            btnAttendance.Dock = DockStyle.Top;
            btnAttendance.FlatAppearance.BorderSize = 0;
            btnAttendance.FlatStyle = FlatStyle.Flat;
            btnAttendance.Font = new Font("Segoe UI", 12F);
            btnAttendance.ForeColor = Color.White;
            btnAttendance.Location = new Point(20, 220);
            btnAttendance.Name = "btnAttendance";
            btnAttendance.Size = new Size(180, 50);
            btnAttendance.TabIndex = 4;
            btnAttendance.Text = "Attendance";
            btnAttendance.TextAlign = ContentAlignment.MiddleLeft;
            btnAttendance.UseVisualStyleBackColor = true;
            btnAttendance.Click += btnAttendance_Click;
            // 
            // btnClasses
            // 
            btnClasses.Dock = DockStyle.Top;
            btnClasses.FlatAppearance.BorderSize = 0;
            btnClasses.FlatStyle = FlatStyle.Flat;
            btnClasses.Font = new Font("Segoe UI", 12F);
            btnClasses.ForeColor = Color.White;
            btnClasses.Location = new Point(20, 170);
            btnClasses.Name = "btnClasses";
            btnClasses.Size = new Size(180, 50);
            btnClasses.TabIndex = 3;
            btnClasses.Text = "Classes";
            btnClasses.TextAlign = ContentAlignment.MiddleLeft;
            btnClasses.UseVisualStyleBackColor = true;
            btnClasses.Click += btnClasses_Click;
            // 
            // btnTeachers
            // 
            btnTeachers.Dock = DockStyle.Top;
            btnTeachers.FlatAppearance.BorderSize = 0;
            btnTeachers.FlatStyle = FlatStyle.Flat;
            btnTeachers.Font = new Font("Segoe UI", 12F);
            btnTeachers.ForeColor = Color.White;
            btnTeachers.Location = new Point(20, 120);
            btnTeachers.Name = "btnTeachers";
            btnTeachers.Size = new Size(180, 50);
            btnTeachers.TabIndex = 2;
            btnTeachers.Text = "Teachers";
            btnTeachers.TextAlign = ContentAlignment.MiddleLeft;
            btnTeachers.UseVisualStyleBackColor = true;
            btnTeachers.Click += button3_Click;
            // 
            // btnStudents
            // 
            btnStudents.Dock = DockStyle.Top;
            btnStudents.FlatAppearance.BorderSize = 0;
            btnStudents.FlatStyle = FlatStyle.Flat;
            btnStudents.Font = new Font("Segoe UI", 12F);
            btnStudents.ForeColor = Color.White;
            btnStudents.Location = new Point(20, 70);
            btnStudents.Name = "btnStudents";
            btnStudents.Size = new Size(180, 50);
            btnStudents.TabIndex = 1;
            btnStudents.Text = "Students";
            btnStudents.TextAlign = ContentAlignment.MiddleLeft;
            btnStudents.UseVisualStyleBackColor = true;
            btnStudents.Click += button2_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.Dock = DockStyle.Top;
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Segoe UI", 12F);
            btnDashboard.ForeColor = Color.White;
            btnDashboard.Location = new Point(20, 20);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(180, 50);
            btnDashboard.TabIndex = 0;
            btnDashboard.Text = "Dashboard";
            btnDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnDashboard.UseVisualStyleBackColor = true;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.White;
            pnlHeader.Controls.Add(label6);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(220, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Padding = new Padding(20);
            pnlHeader.Size = new Size(662, 60);
            pnlHeader.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(64, 64, 64, 64);
            label6.Location = new Point(234, 9);
            label6.Name = "label6";
            label6.Size = new Size(173, 38);
            label6.TabIndex = 0;
            label6.Text = "EDU-TRACK";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlMain
            // 
            pnlMain.BackColor = SystemColors.ButtonFace;
            pnlMain.Controls.Add(panel5);
            pnlMain.Controls.Add(tableLayoutPanel1);
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(220, 60);
            pnlMain.Name = "pnlMain";
            pnlMain.Padding = new Padding(20);
            pnlMain.Size = new Size(662, 493);
            pnlMain.TabIndex = 2;
            pnlMain.Paint += pnlMain_Paint;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Controls.Add(label5);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(20, 196);
            panel5.Margin = new Padding(3, 30, 3, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(622, 277);
            panel5.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(64, 64, 64);
            label5.Location = new Point(3, 12);
            label5.Name = "label5";
            label5.Size = new Size(163, 28);
            label5.TabIndex = 0;
            label5.Text = "Recent Activity ";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(panel2, 1, 0);
            tableLayoutPanel1.Controls.Add(panel3, 2, 0);
            tableLayoutPanel1.Controls.Add(panel4, 3, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(20, 20);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(622, 176);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 122, 204);
            panel1.Controls.Add(lblTotalStudents);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(10, 10);
            panel1.Margin = new Padding(10);
            panel1.Name = "panel1";
            panel1.Size = new Size(135, 156);
            panel1.TabIndex = 0;
            // 
            // lblTotalStudents
            // 
            lblTotalStudents.AutoSize = true;
            lblTotalStudents.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalStudents.ForeColor = Color.White;
            lblTotalStudents.Location = new Point(3, 86);
            lblTotalStudents.Name = "lblTotalStudents";
            lblTotalStudents.Size = new Size(43, 50);
            lblTotalStudents.TabIndex = 1;
            lblTotalStudents.Text = "0";
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 5);
            label1.Margin = new Padding(5);
            label1.Name = "label1";
            label1.Size = new Size(130, 24);
            label1.TabIndex = 0;
            label1.Text = " Total Students";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(43, 181, 155);
            panel2.Controls.Add(lblTotalTeachers);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(165, 10);
            panel2.Margin = new Padding(10);
            panel2.Name = "panel2";
            panel2.Size = new Size(135, 156);
            panel2.TabIndex = 1;
            // 
            // lblTotalTeachers
            // 
            lblTotalTeachers.AutoSize = true;
            lblTotalTeachers.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalTeachers.ForeColor = Color.White;
            lblTotalTeachers.Location = new Point(12, 86);
            lblTotalTeachers.Name = "lblTotalTeachers";
            lblTotalTeachers.Size = new Size(43, 50);
            lblTotalTeachers.TabIndex = 1;
            lblTotalTeachers.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(3, 10);
            label2.Name = "label2";
            label2.Size = new Size(77, 23);
            label2.TabIndex = 0;
            label2.Text = "Teachers";
            label2.Click += label2_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(108, 196, 110);
            panel3.Controls.Add(lblAttendanceCount);
            panel3.Controls.Add(label3);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(320, 10);
            panel3.Margin = new Padding(10);
            panel3.Name = "panel3";
            panel3.Size = new Size(135, 156);
            panel3.TabIndex = 2;
            // 
            // lblAttendanceCount
            // 
            lblAttendanceCount.AutoSize = true;
            lblAttendanceCount.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAttendanceCount.ForeColor = Color.White;
            lblAttendanceCount.Location = new Point(13, 86);
            lblAttendanceCount.Name = "lblAttendanceCount";
            lblAttendanceCount.Size = new Size(43, 50);
            lblAttendanceCount.TabIndex = 1;
            lblAttendanceCount.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(0, 10);
            label3.Name = "label3";
            label3.Size = new Size(165, 23);
            label3.TabIndex = 0;
            label3.Text = "Today's Attendance";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(235, 153, 31);
            panel4.Controls.Add(lblNotificationsCount);
            panel4.Controls.Add(label4);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(475, 10);
            panel4.Margin = new Padding(10);
            panel4.Name = "panel4";
            panel4.Size = new Size(137, 156);
            panel4.TabIndex = 3;
            // 
            // lblNotificationsCount
            // 
            lblNotificationsCount.AutoSize = true;
            lblNotificationsCount.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNotificationsCount.ForeColor = Color.White;
            lblNotificationsCount.Location = new Point(14, 86);
            lblNotificationsCount.Name = "lblNotificationsCount";
            lblNotificationsCount.Size = new Size(43, 50);
            lblNotificationsCount.TabIndex = 2;
            lblNotificationsCount.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(3, 10);
            label4.Name = "label4";
            label4.Size = new Size(113, 23);
            label4.TabIndex = 1;
            label4.Text = "Notifications";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(882, 553);
            Controls.Add(pnlMain);
            Controls.Add(pnlHeader);
            Controls.Add(pnlSidebar);
            Name = "Form1";
            Text = "Form1";
            pnlSidebar.ResumeLayout(false);
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlMain.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlSidebar;
        private Panel pnlHeader;
        private Panel pnlMain;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Label lblTotalStudents;
        private Label label1;
        private Panel panel2;
        private Label lblTotalTeachers;
        private Label label2;
        private Panel panel3;
        private Label label3;
        private Label lblAttendanceCount;
        private Panel panel4;
        private Label lblNotificationsCount;
        private Label label4;
        private Button btnStudents;
        private Button btnDashboard;
        private Button btnAttendance;
        private Button btnClasses;
        private Button btnTeachers;
        private Panel panel5;
        private Label label5;
        private Button btnUserManagement;
        private Label label6;
        private Button btnLogout;
    }
}
