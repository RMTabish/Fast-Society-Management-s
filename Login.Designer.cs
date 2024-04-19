namespace FastSocietyManagementSystem
{
    partial class Login
    {
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLoginExecutive;
        private System.Windows.Forms.Button btnLoginStudent;

        private void InitializeComponent()
        {
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLoginExecutive = new System.Windows.Forms.Button();
            this.btnLoginStudent = new System.Windows.Forms.Button();
            this.SuspendLayout();
           
            this.txtUsername.Location = new System.Drawing.Point(300, 100);
            this.txtUsername.Size = new System.Drawing.Size(200, 20);
            this.txtUsername.PlaceholderText = "Username";
           
            this.txtPassword.Location = new System.Drawing.Point(300, 140);
            this.txtPassword.Size = new System.Drawing.Size(200, 20);
            this.txtPassword.PlaceholderText = "Password";
            this.txtPassword.PasswordChar = '*';
           
            this.btnLoginExecutive.Location = new System.Drawing.Point(250, 200);
            this.btnLoginExecutive.Size = new System.Drawing.Size(120, 40);
            this.btnLoginExecutive.Text = "Executive Login";
            this.btnLoginExecutive.Click += new System.EventHandler(this.ExecutiveLogin);
            
            this.btnLoginStudent.Location = new System.Drawing.Point(430, 200);
            this.btnLoginStudent.Size = new System.Drawing.Size(120, 40);
            this.btnLoginStudent.Text = "Student Login";
            this.btnLoginStudent.Click += new System.EventHandler(this.StudentLogin);
           
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnLoginExecutive);
            this.Controls.Add(this.btnLoginStudent);
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
