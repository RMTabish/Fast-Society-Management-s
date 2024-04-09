using FASTSocietyManagementSystem;
using System;
using System.IO;
using System.Windows.Forms;

namespace FastSocietyManagementSystem
{
    public partial class Login : Form
    {
        private string filePath = "loginInfo.txt";

        public Login()
        {
            InitializeComponent();
        }

        private void ExecutiveLogin(object sender, EventArgs e)
        {
            string Username = txtUsername.Text.Trim();
            string Password = txtPassword.Text.Trim();

            if (Validate(Username, Password))
            {
               
               
               // this.Hide();

               
                AdminDashboard adminDashboard = new AdminDashboard();
                adminDashboard.ShowDialog();

               
                this.Show();
            }
            else
            {
                MessageBox.Show("Incorrect username or password");
            }
        }

        private bool Validate(string enteredUsername, string enteredPassword)
        {
            try
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    string storeUsername = sr.ReadLine();
                    string storePassword = sr.ReadLine();

                    return enteredUsername == storeUsername && enteredPassword == storePassword;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(" credentials file cannot be read: " + ex.Message);
                return false;
            }
        }

        private void StudentLogin(object sender, EventArgs e)
        {
            string enteredUsername = txtUsername.Text.Trim();
            string enteredPassword = txtPassword.Text.Trim();

           
            if (Validate(enteredUsername, enteredPassword))
            {
                MessageBox.Show("Student login successful");
               
            }
            else
            {
                MessageBox.Show("username or password is incorrect");
            }
        }
    }
}
