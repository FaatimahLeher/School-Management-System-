namespace SMS_V3
{
    partial class AddClassForm
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
            panel1 = new Panel();
            txtClassName = new TextBox();
            label2 = new Label();
            panel2 = new Panel();
            cboGrade = new ComboBox();
            label3 = new Label();
            panel3 = new Panel();
            cboTeacher = new ComboBox();
            label4 = new Label();
            panel4 = new Panel();
            label5 = new Label();
            txtRoom = new TextBox();
            btnCreateClass = new Button();
            btnCancel = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(64, 64, 64, 64);
            lblTitle.Location = new Point(53, 30);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(310, 38);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "REGISTER NEW CLASS";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(txtClassName);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(30, 89);
            panel1.Name = "panel1";
            panel1.Size = new Size(380, 68);
            panel1.TabIndex = 2;
            // 
            // txtClassName
            // 
            txtClassName.BorderStyle = BorderStyle.None;
            txtClassName.Font = new Font("Segoe UI", 10.8F);
            txtClassName.ForeColor = Color.Gray;
            txtClassName.Location = new Point(23, 38);
            txtClassName.Name = "txtClassName";
            txtClassName.Size = new Size(334, 24);
            txtClassName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(3, 9);
            label2.Name = "label2";
            label2.Size = new Size(121, 28);
            label2.TabIndex = 0;
            label2.Text = "Class Name";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(cboGrade);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(30, 183);
            panel2.Name = "panel2";
            panel2.Size = new Size(380, 67);
            panel2.TabIndex = 3;
            // 
            // cboGrade
            // 
            cboGrade.DropDownStyle = ComboBoxStyle.DropDownList;
            cboGrade.FlatStyle = FlatStyle.Flat;
            cboGrade.FormattingEnabled = true;
            cboGrade.Items.AddRange(new object[] { "Grade 1,", "Grade 2,", "Grade 3,", "Grade 4", "Grade 5", "Grade 6", "Grade 7" });
            cboGrade.Location = new Point(23, 35);
            cboGrade.Name = "cboGrade";
            cboGrade.Size = new Size(334, 28);
            cboGrade.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.ForeColor = Color.DimGray;
            label3.Location = new Point(3, 9);
            label3.Name = "label3";
            label3.Size = new Size(123, 28);
            label3.TabIndex = 0;
            label3.Text = "Grade Level";
            label3.Click += label3_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(cboTeacher);
            panel3.Controls.Add(label4);
            panel3.Location = new Point(30, 272);
            panel3.Name = "panel3";
            panel3.Size = new Size(380, 67);
            panel3.TabIndex = 4;
            // 
            // cboTeacher
            // 
            cboTeacher.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTeacher.FlatStyle = FlatStyle.Flat;
            cboTeacher.FormattingEnabled = true;
            cboTeacher.Items.AddRange(new object[] { "Teacher A", "Teacher B", "Teacher C" });
            cboTeacher.Location = new Point(23, 35);
            cboTeacher.Name = "cboTeacher";
            cboTeacher.Size = new Size(334, 28);
            cboTeacher.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.ForeColor = Color.DimGray;
            label4.Location = new Point(3, 9);
            label4.Name = "label4";
            label4.Size = new Size(138, 28);
            label4.TabIndex = 0;
            label4.Text = "Class Teacher";
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(label5);
            panel4.Controls.Add(txtRoom);
            panel4.Location = new Point(30, 357);
            panel4.Name = "panel4";
            panel4.Size = new Size(380, 70);
            panel4.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.ForeColor = Color.DimGray;
            label5.Location = new Point(3, 9);
            label5.Name = "label5";
            label5.Size = new Size(67, 28);
            label5.TabIndex = 1;
            label5.Text = "Room";
            // 
            // txtRoom
            // 
            txtRoom.BorderStyle = BorderStyle.None;
            txtRoom.Font = new Font("Segoe UI", 10.8F);
            txtRoom.ForeColor = Color.Gray;
            txtRoom.Location = new Point(23, 35);
            txtRoom.Name = "txtRoom";
            txtRoom.Size = new Size(334, 24);
            txtRoom.TabIndex = 0;
            txtRoom.TextChanged += txtRoom_TextChanged;
            // 
            // btnCreateClass
            // 
            btnCreateClass.BackColor = Color.FromArgb(40, 167, 69);
            btnCreateClass.FlatStyle = FlatStyle.Flat;
            btnCreateClass.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCreateClass.ForeColor = Color.White;
            btnCreateClass.Location = new Point(271, 472);
            btnCreateClass.Name = "btnCreateClass";
            btnCreateClass.Size = new Size(139, 44);
            btnCreateClass.TabIndex = 6;
            btnCreateClass.Text = "CREATE CLASS";
            btnCreateClass.UseVisualStyleBackColor = false;
            btnCreateClass.Click += btnSaveClass_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(220, 53, 69);
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(30, 472);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(110, 44);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "CANCEL";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // AddClassForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(442, 553);
            Controls.Add(btnCancel);
            Controls.Add(btnCreateClass);
            Controls.Add(panel3);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "AddClassForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Class Setup";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private Label label2;
        private Panel panel2;
        private Label label3;
        private Panel panel3;
        private Label label4;
        private Panel panel4;
        private Label label5;
        private Button btnCancel;
        public TextBox txtClassName;
        public Label lblTitle;
        public ComboBox cboGrade;
        public ComboBox cboTeacher;
        public TextBox txtRoom;
        public Button btnCreateClass;
    }
}