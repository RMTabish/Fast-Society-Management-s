using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.Sheets.v4;
using Google.Apis.Sheets.v4.Data;
using System.IO;
using System.Threading;
using System.Net.Mail;
using System.Net;

namespace FASTSocietyManagementSystem
{
    public partial class AdminDashboard : Form

    {
        private UserCredential credential;

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

            societyNameTextBox = new System.Windows.Forms.TextBox();
            presidentIdTextBox = new System.Windows.Forms.TextBox();
            mentorIdTextBox = new System.Windows.Forms.TextBox();
            departmentTextBox = new System.Windows.Forms.TextBox();
            descriptionTextBox = new System.Windows.Forms.TextBox();
            emailTextBox = new System.Windows.Forms.TextBox();
            phoneTextBox = new System.Windows.Forms.TextBox();
            //status = new System.Windows.Forms.TextBox();

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
            refreshButton.Click += buttonRefresh_Click;


        }

        // Event handler for the "Register" button click event
        private void Button1AddSociety_Click(object sender, EventArgs e)
        {
            // Get society details from text boxes
            string societyName = textBox1.Text;
            string presidentId = textBox2.Text;
            string mentorId = textBox3.Text;
            string department = textBox4.Text;
            string description = textBox5.Text;
            string email = textBox6.Text;
            string phone = textBox7.Text;
            string status = "Active";



            // Save society details to a file 
            SaveSocietyToFile(societyName, presidentId, mentorId, department, description, email, phone);

            // display a message box to confirm registration
            MessageBox.Show("Society registered successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Method to save society details to a file
        private void SaveSocietyToFile(string societyName, string presidentId, string mentorId, string department, string description, string email, string phone)
        {
            // Specify the file path where you want to save the society details
            string filePath = "society_details.txt";

            // Prepare the data to be written to the file
            string societyDetails = $"{societyName},{presidentId},{mentorId},{department},{description},{email},{phone}";

            try
            {
                // Write the data to the file
                using (StreamWriter writer = new StreamWriter(filePath, true))
                {
                    writer.WriteLine(societyDetails);
                }
            }
            catch (Exception ex)
            {
                // Handle any errors that may occur during file writing
                MessageBox.Show($"Error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            ListViewItem newItem = new ListViewItem(new string[]
    {
        societyName,
        presidentId,
        mentorId,
        department,
        description,
        email,
        phone,
        status
    });

            // Add the new ListViewItem to the ListView
            listView1.Items.Add(newItem);

            // Clear the text boxes for the next entry
            ClearTextBoxes();
        }

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
           
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("myprofessionalemail1967@gmail.com");
            mail.To.Add(email);
            mail.Subject = "Invitation to join our society";
            mail.Body = $"Dear {name}+ {message}";

            try
            {
                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");
                smtpClient.Port = 587;
                smtpClient.EnableSsl = true;
                smtpClient.UseDefaultCredentials = false;
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


        public async void AuthorizeGoogleSheetsAsync()
        {
            using (var stream = new FileStream("credentials.json", FileMode.Open, FileAccess.Read))
            {
                credential = await GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(stream).Secrets,
                    new[] { SheetsService.Scope.SpreadsheetsReadonly },
                    "user",
                    CancellationToken.None
                );
            }
        }


        public void PopulateListViewWithGoogleSheetData()
        {

            if (credential == null)
            {
                MessageBox.Show("Google Sheets authorization is required.", "Authorization Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            string spreadsheetId = "1b2zh6soiGBYfkK9PrCYKN3ZmASV5NqCOmSJDoQLAVeE";
            string range = "Form Responses 1!A1:G"; // Adjust the range base

            // Create Google Sheets service
            var service = new SheetsService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = "Google Sheets API Example",
            });

            // Retrieve data from the spreadsheet
            SpreadsheetsResource.ValuesResource.GetRequest request = service.Spreadsheets.Values.Get(spreadsheetId, range);

            try
            {
                ValueRange response = request.Execute();
                IList<IList<object>> values = response.Values;

                // Clear existing items in listView3
                listView3.Items.Clear();

                // Populate listView3 with the retrieved data
                if (values != null && values.Count > 0)
                {
                    foreach (var row in values)
                    {
                        // Assuming each row contains data for one member
                        ListViewItem item = new ListViewItem(row[0].ToString()); // Timestamp
                        item.SubItems.Add(row[1].ToString()); // Name
                        item.SubItems.Add(row[2].ToString()); // Email
                        item.SubItems.Add(row[3].ToString()); // Department
                        item.SubItems.Add(row[4].ToString()); // Role
                        item.SubItems.Add(row[5].ToString()); // Message
                        item.SubItems.Add(row[6].ToString()); // Approve
                                                              // Add more sub-items as needed
                        listView3.Items.Add(item);
                    }

                    MessageBox.Show("Data successfully fetched from Google Sheets and populated in listView3.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No data found in the specified range.", "Empty Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error occurred while fetching data from Google Sheets: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //writing the announce event method where the admin after filling in the information send notification to every member email
        private void clickAnnounceButton()
        {
            string eventName = textBox20.Text;
            DateTime eventDateAndTime = dateTimePicker1.Value;
            string eventLocation = textBox18.Text;
            string eventOrganizer = textBox17.Text;
            string eventGuests = textBox19.Text;

           
           /* foreach (var guest in GuestList.Items)
            {
                eventGuests += guest.ToString() + "; "; 
            }

            // Remove the trailing "; " from the string
            eventGuests = eventGuests.TrimEnd(' ', ';');*/
            DateTime eventRegisterationDeadline = dateTimePicker2.Value;
            string eventDescription = textBox11.Text;

            if (string.IsNullOrWhiteSpace(eventName) || string.IsNullOrWhiteSpace(eventLocation)
                || string.IsNullOrWhiteSpace(eventOrganizer) || string.IsNullOrWhiteSpace(eventGuests)
                || string.IsNullOrWhiteSpace(eventDescription)
                )
            {
                MessageBox.Show("Please fill in all event details.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //validate date
            DateTime currentDate = dateTimePicker1.Value;
            if (currentDate < DateTime.Now)
            {
                MessageBox.Show("Please select a date and time in the future.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

            DateTime registerDate = dateTimePicker2.Value;
            if (registerDate < DateTime.Now)
            {
                MessageBox.Show("Please select a date and time in the future.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

            /*if (GuestList.Items.Count == 0)
            {
                MessageBox.Show("Please add guests to the list.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }*/

            sendEmails(eventName, eventDateAndTime, eventLocation, eventDescription, eventOrganizer, eventGuests, eventRegisterationDeadline);








            ListViewItem item = new ListViewItem(eventName);
            item.SubItems.Add(eventDateAndTime.ToString()); // Assuming eventDateAndTime is of type DateTime
            item.SubItems.Add(eventLocation);
            item.SubItems.Add(eventOrganizer);
            item.SubItems.Add(eventGuests);
            item.SubItems.Add(eventRegisterationDeadline.ToString());
            item.SubItems.Add(eventDescription);

            // Add the ListViewItem to the ListView
            listView4.Items.Add(item);


        }

        private void sendEmails(string eventName, DateTime eventDateAndTime, string eventLocation, string eventDescription, string eventOrganizer, string eventGuests,
            DateTime eventRegisterationDeadline
            )
        {
            List<string> emails = getEmails();



            string subject = $"Event Announcement: {eventName}";
            string body = $"Dear Member,\n\nWe are pleased to announce the upcoming event: {eventName}.\n\nEvent Details:\nDate&Time:{eventDateAndTime}\nLocation: {eventLocation}\nDescription: {eventDescription}\n\nPlease mark your calendar and join us for this event.\n\nRegards,\nSociety Management Team";


            foreach (string email in emails)
            {
                try
                {
                    SendEmail(email, subject, body);
                }
                catch (Exception ex)
                {

                    MessageBox.Show($"Failed to send email to {email}. Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void SendEmail(string EmailToSend, string emailSubject, string emailBody)
        {

            try
            {

                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("myprofessionalemail1967@gmail.com");
                mail.To.Add(EmailToSend);
                mail.Subject = emailSubject;
                mail.Body = emailBody;

                // Configure the SMTP client
                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");
                smtpClient.Port = 587;
                smtpClient.EnableSsl = true;
                smtpClient.UseDefaultCredentials = false;
                smtpClient.Credentials = new NetworkCredential("myprofessionalemail1967@gmail.com", "uwfv pnjw fdfx damr");

                // Send the email
                smtpClient.Send(mail);

               
              



                mail.Dispose();
                smtpClient.Dispose();
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Failed to send email to {EmailToSend}. Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            MessageBox.Show("Invitation sent successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        //i am validating the inputs
        private List<string> getEmails()
        {
            string filePath = "emails.txt";

            List<string> emails = new List<string>();

            try
            {

                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {

                        emails.Add(line);
                    }
                }


                Console.WriteLine("Retrieved Emails:");
                foreach (string email in emails)
                {
                    Console.WriteLine(email);
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Error reading file: {ex.Message}");
            }

            return emails;
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            // Call a method to fetch data from Google Sheets and populate listView3
            PopulateListViewWithGoogleSheetData();
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            // Authorize Google Sheets API
            AuthorizeGoogleSheetsAsync();
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
            // Text changed event logic for textBox16
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            // Text changed event logic for textBox9
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void listView4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void GuestList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
             clickAnnounceButton();
        }
    }
}
