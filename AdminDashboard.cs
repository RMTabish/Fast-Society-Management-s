using System.Net.Mail;
using System.Net;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static FASTSocietyManagementSystem.AdminDashboard;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace FASTSocietyManagementSystem
{

    public partial class AdminDashboard : Form

    {

        private System.Windows.Forms.TextBox societyNameTextBox;
        private System.Windows.Forms.TextBox presidentIdTextBox;
        private System.Windows.Forms.TextBox mentorIdTextBox;
        private System.Windows.Forms.TextBox departmentTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        string status;
        private System.Windows.Forms.ListView listViewAcceptedInvitations;

        public AdminDashboard()
        {
            InitializeComponent();
            SetupListViewColumns();
            FetchAndDisplaySocieties();
            societyNameTextBox = new System.Windows.Forms.TextBox();
            presidentIdTextBox = new System.Windows.Forms.TextBox();
            mentorIdTextBox = new System.Windows.Forms.TextBox();
            departmentTextBox = new System.Windows.Forms.TextBox();
            descriptionTextBox = new System.Windows.Forms.TextBox();
            emailTextBox = new System.Windows.Forms.TextBox();
            phoneTextBox = new System.Windows.Forms.TextBox();
            // status = new System.Windows.Forms.TextBox();

            // Add TextBox controls to the form's Controls collection
            Controls.Add(societyNameTextBox);
            Controls.Add(presidentIdTextBox);
            Controls.Add(mentorIdTextBox);
            Controls.Add(departmentTextBox);
            Controls.Add(descriptionTextBox);
            Controls.Add(emailTextBox);
            Controls.Add(phoneTextBox);

            // Attach event handler to the "Register" button
            button1AddSociety.Click += Button1AddSociety_Click;
            button3.Click += new EventHandler(button3_Click);

        }
        private void SetupListViewColumns()
        {
            listView1.View = View.Details;
            listView1.Columns.Add("Society Name", -2, HorizontalAlignment.Left);
            listView1.Columns.Add("President ID", -2, HorizontalAlignment.Left);
            listView1.Columns.Add("Mentor ID", -2, HorizontalAlignment.Left);
            listView1.Columns.Add("Department", -2, HorizontalAlignment.Left);
            listView1.Columns.Add("Description", -2, HorizontalAlignment.Left);
            listView1.Columns.Add("Email", -2, HorizontalAlignment.Left);
            listView1.Columns.Add("Phone", -2, HorizontalAlignment.Left);
            listView1.Columns.Add("Status", -2, HorizontalAlignment.Left);
        }
        private void FetchAndDisplaySocieties()
        {
            string connectionString = "server=localhost;port=3306;user=root;password=12345678;database=society_management_system;";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT name, president_id, mentor_id, DEPT, description, email, phone, stats FROM Societies";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            listView1.Items.Clear(); // Clear existing items

                            while (reader.Read())
                            {
                                ListViewItem newItem = new ListViewItem(reader["name"].ToString());
                                newItem.SubItems.Add(reader["president_id"].ToString());
                                newItem.SubItems.Add(reader["mentor_id"].ToString());
                                newItem.SubItems.Add(reader["DEPT"].ToString());
                                newItem.SubItems.Add(reader["description"].ToString());
                                newItem.SubItems.Add(reader["email"].ToString());
                                newItem.SubItems.Add(reader["phone"].ToString());
                                newItem.SubItems.Add(reader["stats"].ToString()); // Assuming 'stats' column holds the 'Status'

                                listView1.Items.Add(newItem);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while fetching data from the database: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void SaveSocietyToDatabase(string societyName, int presidentId, int mentorId, string department, string description, string email, string phone, string status)
        {
            string connectionString = "server=localhost;port=3306;user=root;password=12345678;database=society_management_system;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"INSERT INTO Societies (name, president_id, mentor_id, description, phone, email, DEPT, stats) 
                 VALUES (@name, @presidentId, @mentorId, @description, @phone, @email, @department, @stats)";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        // Add parameters to prevent SQL injection
                        cmd.Parameters.AddWithValue("@name", societyName);
                        cmd.Parameters.AddWithValue("@presidentId", presidentId);
                        cmd.Parameters.AddWithValue("@mentorId", mentorId);
                        cmd.Parameters.AddWithValue("@description", description);
                        cmd.Parameters.AddWithValue("@phone", phone);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@department", department);
                        cmd.Parameters.AddWithValue("@stats", "Not Approved");
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while saving to the database: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Event handler for the "Register" button click event
        private void Button1AddSociety_Click(object sender, EventArgs e)
        {
            // Get society details from text boxes
            string societyName = textBox1.Text;
            int presidentId = int.Parse(textBox2.Text);
            int mentorId = int.Parse(textBox3.Text);
            string department = textBox4.Text;
            string description = textBox5.Text;
            string email = textBox6.Text;
            string phone = textBox7.Text;
            string status = "Not Approved";


            SaveSocietyToDatabase(societyName, presidentId, mentorId, department, description, email, phone, status);

            FetchAndDisplaySocieties();
            // display a message box to confirm registration
            MessageBox.Show("Society registered successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearTextBoxes();
        }

        // Method to save society details to a file


        private void ClearTextBoxes()
        {
            foreach (Control control in panel1.Controls)
            {
                if (control is System.Windows.Forms.TextBox)
                {
                    ((System.Windows.Forms.TextBox)control).Clear();
                }
            }
        }

        private bool ValidateInputFields()
        {
            // Check if any required field is empty
            if (string.IsNullOrWhiteSpace(textBox16.Text) ||
                string.IsNullOrWhiteSpace(textBox12.Text) ||
                string.IsNullOrWhiteSpace(textBox13.Text) ||
                string.IsNullOrWhiteSpace(textBox14.Text) ||
                string.IsNullOrWhiteSpace(textBox15.Text))
            {
                MessageBox.Show("Please fill in all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Validate email format
            if (!IsValidEmail(textBox15.Text))
            {
                MessageBox.Show("Please enter a valid email address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }



            return true;
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            // Retrieve data from text boxes
            string name = textBox16.Text;
            string email = textBox15.Text;
            string department = textBox13.Text;
            string role = textBox14.Text;
            string message = textBox12.Text;

            // Validate input check if email is in correct format
            if (!ValidateInputFields())
            {
                return; // Exit the method if validation fails
            }

            // Send invitation email
            SendInvitationEmail(name, email, department, role, message);

            // clear input fields
            ClearInputFields();
        }

        private void SendInvitationEmail(string name, string email, string department, string role, string message)
        {
            // Construct the email message
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("myprofessionalemail1967@gmail.com");
            mail.To.Add(email);
            mail.Subject = "Invitation to join our society";
            mail.Body = $"Dear {name}+ {message}";

            // Send the email (try-catch for error handling)
            try
            {
                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");
                smtpClient.Port = 587; // Gmail SMTP port
                smtpClient.EnableSsl = true; // Enable SSL/TLS encryption
                smtpClient.UseDefaultCredentials = false; // Don't use default credentials
                smtpClient.Credentials = new NetworkCredential("myprofessionalemail1967@gmail.com", "stanumsada1");


                // Display success message to the user
                MessageBox.Show("Invitation sent successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ListViewItem newItem = new ListViewItem(new string[]
    {
        name,
        email,

        department,
        role,
        message,

    });

                // Add the new ListViewItem to the ListView
                listView2.Items.Add(newItem);


            }
            catch (Exception ex)
            {
                // Handle email sending failure (display error message, log the error, etc.)
                MessageBox.Show($"Failed to send invitation. Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearInputFields()
        {
            // Clear all input fields
            textBox16.Text = "";
            textBox12.Text = "";
            textBox13.Text = "";
            textBox14.Text = "";
            textBox15.Text = "";
        }

        public class InvitationData
        {
            public string Name { get; set; }
            public string Email { get; set; }
            public string Department { get; set; }

            public string Role { get; set; }

            public string Message { get; set; }


            // Constructor
            public InvitationData(string name, string role, string department, string message, string email)
            {
                Name = name;

                Email = email;
                Department = department;
                Role = role;
                Message = message;


            }
        }


        private void HandleInvitationResponse(bool isAccepted, InvitationData invitationData)
        {
            if (isAccepted)
            {
                // Add the invitation data to the ListView
                ListViewItem newItem = new ListViewItem(invitationData.Name);
                newItem.SubItems.Add(invitationData.Email);
                newItem.SubItems.Add(invitationData.Department);
                newItem.SubItems.Add(invitationData.Role);
                // Add more sub-items as needed
                listViewAcceptedInvitations.Items.Add(newItem);
            }
            else
            {
                // Discard the invitation data
            }
        }



        private void AdminTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Event handler logic
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            // Painting logic
        }

        private void label6_Click(object sender, EventArgs e)
        {
            // Click event logic
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            // Text changed event logic
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            // Painting logic for panel2
        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
