namespace SMS_V3
{
    partial class LoginFormcs
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
            label1 = new Label();
            lblUsername = new Label();
            label2 = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(64, 64, 64, 64);
            label1.Location = new Point(19, 42);
            label1.Name = "label1";
            label1.Size = new Size(369, 31);
            label1.TabIndex = 0;
            label1.Text = "SCHOOL MANAGEMENT SYSTEM";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsername.ForeColor = Color.FromArgb(64, 64, 64);
            lblUsername.Location = new Point(39, 128);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(111, 28);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "Username:";
            lblUsername.Click += lblUsername_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(64, 64, 64);
            label2.Location = new Point(39, 212);
            label2.Name = "label2";
            label2.Size = new Size(106, 28);
            label2.TabIndex = 2;
            label2.Text = "Password:";
            // 
            // txtUsername
            // 
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtUsername.ForeColor = Color.DimGray;
            txtUsername.Location = new Point(172, 132);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(182, 24);
            txtUsername.TabIndex = 3;
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPassword.ForeColor = Color.DimGray;
            txtPassword.Location = new Point(172, 215);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(182, 24);
            txtPassword.TabIndex = 4;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(40, 167, 69);
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(118, 331);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(139, 44);
            btnLogin.TabIndex = 7;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // LoginFormcs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(400, 450);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(label2);
            Controls.Add(lblUsername);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginFormcs";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginFormcs";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblUsername;
        private Label label2;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnLogin;
    }
}