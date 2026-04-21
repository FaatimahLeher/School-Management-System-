namespace SMS_V3
{
    partial class UC_Classes
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
            btnAddClass = new Button();
            label1 = new Label();
            dgvClasses = new DataGridView();
            colGrade = new DataGridViewTextBoxColumn();
            colClassName = new DataGridViewTextBoxColumn();
            colTeacher = new DataGridViewTextBoxColumn();
            colRoom = new DataGridViewTextBoxColumn();
            colDelete = new DataGridViewButtonColumn();
            colEdit = new DataGridViewButtonColumn();
            pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClasses).BeginInit();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.White;
            pnlHeader.Controls.Add(btnAddClass);
            pnlHeader.Controls.Add(label1);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(900, 100);
            pnlHeader.TabIndex = 0;
            pnlHeader.Paint += pnlHeader_Paint;
            // 
            // btnAddClass
            // 
            btnAddClass.BackColor = Color.FromArgb(40, 167, 69);
            btnAddClass.FlatStyle = FlatStyle.Flat;
            btnAddClass.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddClass.ForeColor = Color.White;
            btnAddClass.Location = new Point(0, 0);
            btnAddClass.Name = "btnAddClass";
            btnAddClass.Size = new Size(168, 46);
            btnAddClass.TabIndex = 1;
            btnAddClass.Text = "+ Add Class";
            btnAddClass.UseVisualStyleBackColor = false;
            btnAddClass.Click += btnAddClass_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(360, 32);
            label1.Name = "label1";
            label1.Size = new Size(461, 38);
            label1.TabIndex = 0;
            label1.Text = "CLASS AND SUBJECT DIRECTORY ";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // dgvClasses
            // 
            dgvClasses.AllowUserToAddRows = false;
            dgvClasses.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvClasses.BackgroundColor = Color.White;
            dgvClasses.BorderStyle = BorderStyle.None;
            dgvClasses.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.ButtonFace;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.ButtonShadow;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvClasses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvClasses.ColumnHeadersHeight = 45;
            dgvClasses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvClasses.Columns.AddRange(new DataGridViewColumn[] { colGrade, colClassName, colTeacher, colRoom, colDelete, colEdit });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.Silver;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvClasses.DefaultCellStyle = dataGridViewCellStyle2;
            dgvClasses.Dock = DockStyle.Fill;
            dgvClasses.EnableHeadersVisualStyles = false;
            dgvClasses.Location = new Point(0, 100);
            dgvClasses.Name = "dgvClasses";
            dgvClasses.RowHeadersVisible = false;
            dgvClasses.RowHeadersWidth = 51;
            dgvClasses.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClasses.Size = new Size(900, 500);
            dgvClasses.TabIndex = 1;
            dgvClasses.ColumnHeadersDefaultCellStyleChanged += dgvClasses_ColumnHeadersDefaultCellStyleChanged;
            dgvClasses.DefaultCellStyleChanged += dgvClasses_DefaultCellStyleChanged;
            dgvClasses.CellContentClick += dgvClasses_CellContentClick;
            dgvClasses.CellStyleChanged += dgvClasses_CellContentClick;
            // 
            // colGrade
            // 
            colGrade.HeaderText = "Grade";
            colGrade.MinimumWidth = 6;
            colGrade.Name = "colGrade";
            // 
            // colClassName
            // 
            colClassName.HeaderText = "Class Name";
            colClassName.MinimumWidth = 6;
            colClassName.Name = "colClassName";
            // 
            // colTeacher
            // 
            colTeacher.HeaderText = "Class Teacher";
            colTeacher.MinimumWidth = 6;
            colTeacher.Name = "colTeacher";
            // 
            // colRoom
            // 
            colRoom.HeaderText = "Room";
            colRoom.MinimumWidth = 6;
            colRoom.Name = "colRoom";
            // 
            // colDelete
            // 
            colDelete.HeaderText = "Delete";
            colDelete.MinimumWidth = 6;
            colDelete.Name = "colDelete";
            colDelete.UseColumnTextForButtonValue = true;
            // 
            // colEdit
            // 
            colEdit.HeaderText = "Edit";
            colEdit.MinimumWidth = 6;
            colEdit.Name = "colEdit";
            colEdit.UseColumnTextForButtonValue = true;
            // 
            // UC_Classes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dgvClasses);
            Controls.Add(pnlHeader);
            Name = "UC_Classes";
            Size = new Size(900, 600);
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClasses).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Button btnAddClass;
        private Label label1;
        private DataGridView dgvClasses;
        private DataGridViewTextBoxColumn colGrade;
        private DataGridViewTextBoxColumn colClassName;
        private DataGridViewTextBoxColumn colTeacher;
        private DataGridViewTextBoxColumn colRoom;
        private DataGridViewButtonColumn colDelete;
        private DataGridViewButtonColumn colEdit;
    }
}
