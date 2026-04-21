namespace SMS_V3
{
    partial class AddStudentForm
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
            btnCancel = new Button();
            btnSave = new Button();
            txtLastName = new TextBox();
            label4 = new Label();
            txtGrade = new TextBox();
            label3 = new Label();
            name = new Label();
            txtFirstName = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtStudentID = new TextBox();
            txtContact = new TextBox();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(64, 64, 64);
            lblTitle.Location = new Point(52, 35);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(313, 38);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "NEW STUDENT ENTRY";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(220, 53, 69);
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(30, 395);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(100, 40);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "CANCEL";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(40, 167, 69);
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(225, 395);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(160, 40);
            btnSave.TabIndex = 4;
            btnSave.Text = "SAVE STUDENT";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSaveStudent_Click;
            // 
            // txtLastName
            // 
            txtLastName.BorderStyle = BorderStyle.None;
            txtLastName.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            txtLastName.ForeColor = Color.FromArgb(64, 64, 64);
            txtLastName.Location = new Point(186, 160);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(191, 24);
            txtLastName.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(64, 64, 64);
            label4.Location = new Point(30, 157);
            label4.Name = "label4";
            label4.Size = new Size(123, 28);
            label4.TabIndex = 1;
            label4.Text = "Last Name :";
            // 
            // txtGrade
            // 
            txtGrade.BorderStyle = BorderStyle.None;
            txtGrade.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            txtGrade.ForeColor = Color.FromArgb(64, 64, 64);
            txtGrade.Location = new Point(186, 265);
            txtGrade.Name = "txtGrade";
            txtGrade.Size = new Size(191, 24);
            txtGrade.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(64, 64, 64);
            label3.Location = new Point(21, 261);
            label3.Name = "label3";
            label3.Size = new Size(135, 28);
            label3.TabIndex = 0;
            label3.Text = "Class/Grade :";
            // 
            // name
            // 
            name.AutoSize = true;
            name.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            name.ForeColor = Color.FromArgb(64, 64, 64);
            name.Location = new Point(30, 101);
            name.Name = "name";
            name.Size = new Size(126, 28);
            name.TabIndex = 0;
            name.Text = "First Name :";
            // 
            // txtFirstName
            // 
            txtFirstName.BorderStyle = BorderStyle.None;
            txtFirstName.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            txtFirstName.ForeColor = Color.FromArgb(64, 64, 64);
            txtFirstName.Location = new Point(186, 105);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(191, 24);
            txtFirstName.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(64, 64, 64);
            label5.Location = new Point(30, 338);
            label5.Name = "label5";
            label5.Size = new Size(0, 28);
            label5.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(64, 64, 64);
            label6.Location = new Point(12, 321);
            label6.Name = "label6";
            label6.Size = new Size(168, 28);
            label6.TabIndex = 6;
            label6.Text = "Contact Details :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label7.ForeColor = Color.FromArgb(64, 64, 64);
            label7.Location = new Point(29, 209);
            label7.Name = "label7";
            label7.Size = new Size(124, 28);
            label7.TabIndex = 7;
            label7.Text = "Student ID :";
            // 
            // txtStudentID
            // 
            txtStudentID.BorderStyle = BorderStyle.None;
            txtStudentID.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            txtStudentID.ForeColor = Color.FromArgb(64, 64, 64);
            txtStudentID.Location = new Point(186, 213);
            txtStudentID.Name = "txtStudentID";
            txtStudentID.Size = new Size(191, 24);
            txtStudentID.TabIndex = 8;
            // 
            // txtContact
            // 
            txtContact.BorderStyle = BorderStyle.None;
            txtContact.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            txtContact.ForeColor = Color.FromArgb(64, 64, 64);
            txtContact.Location = new Point(186, 321);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(191, 24);
            txtContact.TabIndex = 9;
            // 
            // AddStudentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(413, 503);
            Controls.Add(txtContact);
            Controls.Add(txtStudentID);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtFirstName);
            Controls.Add(txtGrade);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(name);
            Controls.Add(txtLastName);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            Controls.Add(lblTitle);
            Name = "AddStudentForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Enroll New Student ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblTitle;
        private Button btnCancel;
        private Button btnSave;
        private Label label4;
        private Label label3;
        private Label name;
        private Label label5;
        private Label label6;
        private Label label7;
        public TextBox txtStudentID;
        public TextBox txtGrade;
        public TextBox txtContact;
        public TextBox txtFirstName;
        public TextBox txtLastName;
    }
}