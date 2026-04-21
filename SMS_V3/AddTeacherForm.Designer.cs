namespace SMS_V3
{
    partial class AddTeacherForm
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1 = new Panel();
            cboSubject = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            txtFirstName = new TextBox();
            panel2 = new Panel();
            txtDepartment = new TextBox();
            label3 = new Label();
            label4 = new Label();
            btnCancel = new Button();
            btnAddTeacher = new Button();
            panel3 = new Panel();
            txtSurname = new TextBox();
            label5 = new Label();
            panel4 = new Panel();
            txtStaffID = new TextBox();
            label6 = new Label();
            panel5 = new Panel();
            txtContact = new TextBox();
            label7 = new Label();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel1.BackColor = Color.White;
            flowLayoutPanel1.Controls.Add(panel1);
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Controls.Add(txtFirstName);
            flowLayoutPanel1.Location = new Point(57, 78);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(417, 82);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.White;
            panel1.Controls.Add(cboSubject);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(340, 0);
            panel1.TabIndex = 1;
            // 
            // cboSubject
            // 
            cboSubject.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSubject.FlatStyle = FlatStyle.Flat;
            cboSubject.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cboSubject.ForeColor = Color.FromArgb(64, 64, 64);
            cboSubject.FormattingEnabled = true;
            cboSubject.Items.AddRange(new object[] { "Maths", "Science And Technology ", "English", "Social Studies", "Agriculture", "Heritage Studies" });
            cboSubject.Location = new Point(18, 35);
            cboSubject.Name = "cboSubject";
            cboSubject.Size = new Size(314, 33);
            cboSubject.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(64, 64, 64);
            label2.Location = new Point(13, 9);
            label2.Name = "label2";
            label2.Size = new Size(82, 28);
            label2.TabIndex = 0;
            label2.Text = "Subject";
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(3, 6);
            label1.Name = "label1";
            label1.Size = new Size(136, 30);
            label1.TabIndex = 0;
            label1.Text = "Name";
         
            // 
            // txtFirstName
            // 
            txtFirstName.BorderStyle = BorderStyle.None;
            txtFirstName.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFirstName.ForeColor = Color.FromArgb(64, 64, 64);
            txtFirstName.Location = new Point(3, 39);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(309, 24);
            txtFirstName.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.White;
            panel2.Controls.Add(txtDepartment);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(55, 520);
            panel2.Name = "panel2";
            panel2.Size = new Size(411, 84);
            panel2.TabIndex = 2;
            
            // 
            // txtDepartment
            // 
            txtDepartment.BorderStyle = BorderStyle.None;
            txtDepartment.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDepartment.ForeColor = Color.FromArgb(64, 64, 64);
            txtDepartment.Location = new Point(13, 42);
            txtDepartment.Name = "txtDepartment";
            txtDepartment.Size = new Size(309, 24);
            txtDepartment.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(64, 64, 64);
            label3.Location = new Point(3, 11);
            label3.Name = "label3";
            label3.Size = new Size(194, 28);
            label3.TabIndex = 0;
            label3.Text = "Department/Office";
           
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(64, 64, 64);
            label4.Location = new Point(106, 22);
            label4.Name = "label4";
            label4.Size = new Size(309, 38);
            label4.TabIndex = 3;
            label4.Text = "NEW TEACHER ENTRY";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(220, 53, 69);
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(55, 631);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(100, 40);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "CANCEL";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += button1_Click;
            // 
            // btnAddTeacher
            // 
            btnAddTeacher.BackColor = Color.FromArgb(40, 167, 69);
            btnAddTeacher.FlatStyle = FlatStyle.Flat;
            btnAddTeacher.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddTeacher.ForeColor = Color.White;
            btnAddTeacher.Location = new Point(306, 631);
            btnAddTeacher.Name = "btnAddTeacher";
            btnAddTeacher.Size = new Size(160, 40);
            btnAddTeacher.TabIndex = 5;
            btnAddTeacher.Text = "SAVE TEACHER";
            btnAddTeacher.UseVisualStyleBackColor = false;
            btnAddTeacher.Click += btnAddTeacher_Click;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = Color.White;
            panel3.Controls.Add(txtSurname);
            panel3.Controls.Add(label5);
            panel3.Location = new Point(57, 188);
            panel3.Name = "panel3";
            panel3.Size = new Size(417, 87);
            panel3.TabIndex = 6;
            // 
            // txtSurname
            // 
            txtSurname.BorderStyle = BorderStyle.None;
            txtSurname.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSurname.ForeColor = Color.FromArgb(64, 64, 64);
            txtSurname.Location = new Point(13, 42);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(309, 24);
            txtSurname.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(64, 64, 64);
            label5.Location = new Point(3, 11);
            label5.Name = "label5";
            label5.Size = new Size(95, 28);
            label5.TabIndex = 0;
            label5.Text = "Surname";
            
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel4.BackColor = Color.White;
            panel4.Controls.Add(txtStaffID);
            panel4.Controls.Add(label6);
            panel4.Location = new Point(57, 296);
            panel4.Name = "panel4";
            panel4.Size = new Size(417, 84);
            panel4.TabIndex = 7;
            // 
            // txtStaffID
            // 
            txtStaffID.BorderStyle = BorderStyle.None;
            txtStaffID.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtStaffID.ForeColor = Color.FromArgb(64, 64, 64);
            txtStaffID.Location = new Point(13, 42);
            txtStaffID.Name = "txtStaffID";
            txtStaffID.Size = new Size(309, 24);
            txtStaffID.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(64, 64, 64);
            label6.Location = new Point(3, 11);
            label6.Name = "label6";
            label6.Size = new Size(118, 28);
            label6.TabIndex = 0;
            label6.Text = "Teacher ID ";
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel5.BackColor = Color.White;
            panel5.Controls.Add(txtContact);
            panel5.Controls.Add(label7);
            panel5.Location = new Point(57, 406);
            panel5.Name = "panel5";
            panel5.Size = new Size(414, 89);
            panel5.TabIndex = 3;
            // 
            // txtContact
            // 
            txtContact.BorderStyle = BorderStyle.None;
            txtContact.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtContact.ForeColor = Color.FromArgb(64, 64, 64);
            txtContact.Location = new Point(13, 42);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(309, 24);
            txtContact.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(64, 64, 64);
            label7.Location = new Point(3, 11);
            label7.Name = "label7";
            label7.Size = new Size(157, 28);
            label7.TabIndex = 0;
            label7.Text = "Conatct Details\r\n";
            // 
            // AddTeacherForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(532, 703);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(btnAddTeacher);
            Controls.Add(btnCancel);
            Controls.Add(label4);
            Controls.Add(panel2);
            Controls.Add(flowLayoutPanel1);
            Name = "AddTeacherForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register New Faculty ";
          
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private Label label2;
        private Panel panel2;
        private Label label3;
        private Label label4;
        private Button btnCancel;
        private Label label1;
        public ComboBox cboSubject;
        public TextBox txtFirstName;
        private Panel panel3;
        private Label label5;
        private Panel panel4;
        private Label label6;
        private Panel panel5;
        private Label label7;
        public TextBox txtDepartment;
        public TextBox txtSurname;
        public TextBox txtStaffID;
        public TextBox txtContact;
        public Button btnAddTeacher;
    }
}