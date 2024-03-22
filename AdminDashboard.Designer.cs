namespace FASTSocietyManagementSystem
{
    partial class AdminDashboard
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
            AdminTabControl = new TabControl();
            SocietyRegistration = new TabPage();
            textBox8 = new TextBox();
            buttonRefreshSociety = new Button();
            buttonSearchSociety = new Button();
            panel1 = new Panel();
            button1AddSociety = new Button();
            textBox7 = new TextBox();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            panel1ListView = new Panel();
            listView1 = new ListView();
            SocietyName = new ColumnHeader();
            PresidentId = new ColumnHeader();
            MentorId = new ColumnHeader();
            Department = new ColumnHeader();
            Description = new ColumnHeader();
            Email = new ColumnHeader();
            Phone = new ColumnHeader();
            Status = new ColumnHeader();
            memberManagement = new TabPage();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            textBox9 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            panel2 = new Panel();
            button3 = new Button();
            textBox12 = new TextBox();
            textBox13 = new TextBox();
            textBox14 = new TextBox();
            textBox15 = new TextBox();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            textBox16 = new TextBox();
            label14 = new Label();
            panel3 = new Panel();
            listView2 = new ListView();
            columnStudentName = new ColumnHeader();
            emailStudent = new ColumnHeader();
            departmentStudent = new ColumnHeader();
            roleStudent = new ColumnHeader();
            messageStudent = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            tabPage2 = new TabPage();
            refreshButton = new Button();
            button5 = new Button();
            textBox10 = new TextBox();
            button4 = new Button();
            listView3 = new ListView();
            timeStamp1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader10 = new ColumnHeader();
            columnHeader11 = new ColumnHeader();
            AdminTabControl.SuspendLayout();
            SocietyRegistration.SuspendLayout();
            panel1.SuspendLayout();
            panel1ListView.SuspendLayout();
            memberManagement.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // AdminTabControl
            // 
            AdminTabControl.Controls.Add(SocietyRegistration);
            AdminTabControl.Controls.Add(memberManagement);
            AdminTabControl.Dock = DockStyle.Fill;
            AdminTabControl.Location = new Point(0, 0);
            AdminTabControl.Name = "AdminTabControl";
            AdminTabControl.SelectedIndex = 0;
            AdminTabControl.Size = new Size(1100, 509);
            AdminTabControl.TabIndex = 0;
            AdminTabControl.SelectedIndexChanged += AdminTabControl_SelectedIndexChanged;
            // 
            // SocietyRegistration
            // 
            SocietyRegistration.BackColor = SystemColors.ActiveCaption;
            SocietyRegistration.Controls.Add(textBox8);
            SocietyRegistration.Controls.Add(buttonRefreshSociety);
            SocietyRegistration.Controls.Add(buttonSearchSociety);
            SocietyRegistration.Controls.Add(panel1);
            SocietyRegistration.Controls.Add(panel1ListView);
            SocietyRegistration.Location = new Point(4, 24);
            SocietyRegistration.Name = "SocietyRegistration";
            SocietyRegistration.Padding = new Padding(3);
            SocietyRegistration.Size = new Size(944, 481);
            SocietyRegistration.TabIndex = 0;
            SocietyRegistration.Text = "Society Registration";
            // 
            // textBox8
            // 
            textBox8.Location = new Point(39, 49);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(129, 23);
            textBox8.TabIndex = 18;
            textBox8.TextChanged += textBox8_TextChanged;
            // 
            // buttonRefreshSociety
            // 
            buttonRefreshSociety.Location = new Point(311, 49);
            buttonRefreshSociety.Name = "buttonRefreshSociety";
            buttonRefreshSociety.Size = new Size(108, 30);
            buttonRefreshSociety.TabIndex = 17;
            buttonRefreshSociety.Tag = "Refresh";
            buttonRefreshSociety.Text = "Refresh";
            buttonRefreshSociety.UseVisualStyleBackColor = true;
            // 
            // buttonSearchSociety
            // 
            buttonSearchSociety.Location = new Point(197, 49);
            buttonSearchSociety.Name = "buttonSearchSociety";
            buttonSearchSociety.Size = new Size(108, 30);
            buttonSearchSociety.TabIndex = 16;
            buttonSearchSociety.Text = "Search";
            buttonSearchSociety.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(button1AddSociety);
            panel1.Controls.Add(textBox7);
            panel1.Controls.Add(textBox6);
            panel1.Controls.Add(textBox5);
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(651, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(290, 475);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // button1AddSociety
            // 
            button1AddSociety.Location = new Point(144, 392);
            button1AddSociety.Name = "button1AddSociety";
            button1AddSociety.Size = new Size(108, 27);
            button1AddSociety.TabIndex = 15;
            button1AddSociety.Text = "Register";
            button1AddSociety.UseVisualStyleBackColor = true;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(133, 346);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(129, 23);
            textBox7.TabIndex = 14;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(133, 308);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(129, 23);
            textBox6.TabIndex = 13;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(133, 251);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(129, 40);
            textBox5.TabIndex = 12;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(133, 198);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(129, 23);
            textBox4.TabIndex = 11;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(133, 147);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(129, 23);
            textBox3.TabIndex = 10;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(133, 104);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(129, 23);
            textBox2.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(38, 349);
            label7.Name = "label7";
            label7.Size = new Size(41, 15);
            label7.TabIndex = 7;
            label7.Text = "Phone";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(38, 311);
            label6.Name = "label6";
            label6.Size = new Size(36, 15);
            label6.TabIndex = 6;
            label6.Text = "Email";
            label6.Click += label6_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(38, 104);
            label5.Name = "label5";
            label5.Size = new Size(69, 15);
            label5.TabIndex = 5;
            label5.Text = "President Id";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(38, 150);
            label4.Name = "label4";
            label4.Size = new Size(59, 15);
            label4.TabIndex = 4;
            label4.Text = "Mentor Id";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 251);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 3;
            label3.Text = "Description";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 201);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 2;
            label2.Text = "Department";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(133, 46);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(129, 23);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 49);
            label1.Name = "label1";
            label1.Size = new Size(80, 15);
            label1.TabIndex = 0;
            label1.Text = "Society Name";
            // 
            // panel1ListView
            // 
            panel1ListView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1ListView.BackColor = SystemColors.ButtonHighlight;
            panel1ListView.Controls.Add(listView1);
            panel1ListView.Location = new Point(0, 137);
            panel1ListView.Name = "panel1ListView";
            panel1ListView.Size = new Size(645, 344);
            panel1ListView.TabIndex = 0;
            // 
            // listView1
            // 
            listView1.BackColor = SystemColors.Menu;
            listView1.Columns.AddRange(new ColumnHeader[] { SocietyName, PresidentId, MentorId, Department, Description, Email, Phone, Status });
            listView1.Dock = DockStyle.Fill;
            listView1.FullRowSelect = true;
            listView1.Location = new Point(0, 0);
            listView1.Name = "listView1";
            listView1.Size = new Size(645, 344);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // SocietyName
            // 
            SocietyName.Text = "Society Name";
            // 
            // PresidentId
            // 
            PresidentId.Text = "PresidenId";
            // 
            // MentorId
            // 
            MentorId.Text = "MentorId";
            // 
            // Department
            // 
            Department.Text = "Department";
            // 
            // Description
            // 
            Description.Text = "Description";
            // 
            // Email
            // 
            Email.Text = "Email";
            // 
            // Phone
            // 
            Phone.Text = "Phone";
            // 
            // Status
            // 
            Status.Text = "Status";
            // 
            // memberManagement
            // 
            memberManagement.Controls.Add(tabControl1);
            memberManagement.Location = new Point(4, 24);
            memberManagement.Name = "memberManagement";
            memberManagement.Padding = new Padding(3);
            memberManagement.Size = new Size(1092, 481);
            memberManagement.TabIndex = 1;
            memberManagement.Text = "Member Management";
            memberManagement.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(3, 3);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1086, 475);
            tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = SystemColors.ActiveCaption;
            tabPage1.Controls.Add(textBox9);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(button2);
            tabPage1.Controls.Add(panel2);
            tabPage1.Controls.Add(panel3);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(930, 447);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Invite Member";
            // 
            // textBox9
            // 
            textBox9.Location = new Point(39, 49);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(129, 23);
            textBox9.TabIndex = 18;
            textBox9.TextChanged += textBox9_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(311, 49);
            button1.Name = "button1";
            button1.Size = new Size(108, 30);
            button1.TabIndex = 17;
            button1.Tag = "Refresh";
            button1.Text = "Refresh";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(197, 49);
            button2.Name = "button2";
            button2.Size = new Size(108, 30);
            button2.TabIndex = 16;
            button2.Text = "Search";
            button2.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonHighlight;
            panel2.Controls.Add(button3);
            panel2.Controls.Add(textBox12);
            panel2.Controls.Add(textBox13);
            panel2.Controls.Add(textBox14);
            panel2.Controls.Add(textBox15);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(label13);
            panel2.Controls.Add(textBox16);
            panel2.Controls.Add(label14);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(615, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(312, 441);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // button3
            // 
            button3.Location = new Point(143, 322);
            button3.Name = "button3";
            button3.Size = new Size(108, 27);
            button3.TabIndex = 15;
            button3.Text = "Invite";
            button3.UseVisualStyleBackColor = true;
            // 
            // textBox12
            // 
            textBox12.Location = new Point(133, 251);
            textBox12.Multiline = true;
            textBox12.Name = "textBox12";
            textBox12.Size = new Size(129, 40);
            textBox12.TabIndex = 12;
            // 
            // textBox13
            // 
            textBox13.Location = new Point(133, 198);
            textBox13.Name = "textBox13";
            textBox13.Size = new Size(129, 23);
            textBox13.TabIndex = 11;
            // 
            // textBox14
            // 
            textBox14.Location = new Point(133, 147);
            textBox14.Name = "textBox14";
            textBox14.Size = new Size(129, 23);
            textBox14.TabIndex = 10;
            // 
            // textBox15
            // 
            textBox15.Location = new Point(133, 104);
            textBox15.Name = "textBox15";
            textBox15.Size = new Size(129, 23);
            textBox15.TabIndex = 9;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(38, 104);
            label10.Name = "label10";
            label10.Size = new Size(39, 15);
            label10.TabIndex = 5;
            label10.Text = "Email ";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(38, 150);
            label11.Name = "label11";
            label11.Size = new Size(70, 15);
            label11.TabIndex = 4;
            label11.Text = "Department";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(38, 251);
            label12.Name = "label12";
            label12.Size = new Size(53, 15);
            label12.TabIndex = 3;
            label12.Text = "Message";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(38, 201);
            label13.Name = "label13";
            label13.Size = new Size(30, 15);
            label13.TabIndex = 2;
            label13.Text = "Role";
            // 
            // textBox16
            // 
            textBox16.Location = new Point(133, 49);
            textBox16.Name = "textBox16";
            textBox16.Size = new Size(129, 23);
            textBox16.TabIndex = 1;
            textBox16.TextChanged += textBox16_TextChanged;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(38, 49);
            label14.Name = "label14";
            label14.Size = new Size(39, 15);
            label14.TabIndex = 0;
            label14.Text = "Name";
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = SystemColors.ButtonHighlight;
            panel3.Controls.Add(listView2);
            panel3.Location = new Point(3, 107);
            panel3.Name = "panel3";
            panel3.Size = new Size(1084, 718);
            panel3.TabIndex = 0;
            // 
            // listView2
            // 
            listView2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listView2.BackColor = SystemColors.Menu;
            listView2.Columns.AddRange(new ColumnHeader[] { columnStudentName, emailStudent, departmentStudent, roleStudent, messageStudent, columnHeader6, columnHeader7, columnHeader8 });
            listView2.FullRowSelect = true;
            listView2.Location = new Point(0, 0);
            listView2.Name = "listView2";
            listView2.Size = new Size(611, 614);
            listView2.TabIndex = 0;
            listView2.UseCompatibleStateImageBehavior = false;
            listView2.View = View.Details;
            // 
            // columnStudentName
            // 
            columnStudentName.Text = "Name";
            // 
            // emailStudent
            // 
            emailStudent.Text = "Email";
            // 
            // departmentStudent
            // 
            departmentStudent.Text = "Department";
            // 
            // roleStudent
            // 
            roleStudent.Text = "Role";
            // 
            // messageStudent
            // 
            messageStudent.Text = "Message";
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Email";
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Phone";
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Status";
            // 
            // tabPage2
            // 
            tabPage2.BackColor = SystemColors.ActiveCaption;
            tabPage2.Controls.Add(refreshButton);
            tabPage2.Controls.Add(button5);
            tabPage2.Controls.Add(textBox10);
            tabPage2.Controls.Add(button4);
            tabPage2.Controls.Add(listView3);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1078, 447);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Aprove Members";
            // 
            // refreshButton
            // 
            refreshButton.Location = new Point(503, 33);
            refreshButton.Name = "refreshButton";
            refreshButton.Size = new Size(121, 26);
            refreshButton.TabIndex = 5;
            refreshButton.Text = "Refresh";
            refreshButton.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(360, 33);
            button5.Name = "button5";
            button5.Size = new Size(121, 26);
            button5.TabIndex = 4;
            button5.Text = "Approve All";
            button5.UseVisualStyleBackColor = true;
            // 
            // textBox10
            // 
            textBox10.Location = new Point(75, 33);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(115, 23);
            textBox10.TabIndex = 3;
            // 
            // button4
            // 
            button4.Location = new Point(218, 33);
            button4.Name = "button4";
            button4.Size = new Size(121, 26);
            button4.TabIndex = 2;
            button4.Text = "Search";
            button4.UseVisualStyleBackColor = true;
            // 
            // listView3
            // 
            listView3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listView3.BackColor = SystemColors.Menu;
            listView3.Columns.AddRange(new ColumnHeader[] { timeStamp1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader10, columnHeader11 });
            listView3.FullRowSelect = true;
            listView3.Location = new Point(6, 94);
            listView3.Name = "listView3";
            listView3.Size = new Size(1066, 350);
            listView3.TabIndex = 1;
            listView3.UseCompatibleStateImageBehavior = false;
            listView3.View = View.Details;
            // 
            // timeStamp1
            // 
            timeStamp1.Text = "Timestamp";
            timeStamp1.Width = 100;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Name";
            columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Email";
            columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Department";
            columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Role";
            columnHeader5.Width = 300;
            // 
            // columnHeader10
            // 
            columnHeader10.Text = "Message";
            columnHeader10.Width = 100;
            // 
            // columnHeader11
            // 
            columnHeader11.DisplayIndex = 6;
            columnHeader11.Text = "Approve";
            columnHeader11.Width = 100;
            // 
            // AdminDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 509);
            Controls.Add(AdminTabControl);
            Name = "AdminDashboard";
            Text = "Admin";
            Load += AdminDashboard_Load;
            AdminTabControl.ResumeLayout(false);
            SocietyRegistration.ResumeLayout(false);
            SocietyRegistration.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel1ListView.ResumeLayout(false);
            memberManagement.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl AdminTabControl;
        private TabPage SocietyRegistration;
        private Panel panel1ListView;
        private TabPage memberManagement;
        private ListView listView1;
        private ColumnHeader SocietyName;
        private ColumnHeader PresidentId;
        private Panel panel1;
        private ColumnHeader MentorId;
        private ColumnHeader Department;
        private ColumnHeader Description;
        private ColumnHeader Email;
        private ColumnHeader Phone;
        private Label label3;
        private Label label2;
        private TextBox textBox1;
        private Label label1;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox textBox7;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private Button button1AddSociety;
        private TextBox textBox8;
        private Button buttonRefreshSociety;
        private Button buttonSearchSociety;
        private ColumnHeader Status;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TextBox textBox9;
        private Button button1;
        private Button button2;
        private Panel panel2;
        private Button button3;
        private TextBox textBox12;
        private TextBox textBox13;
        private TextBox textBox14;
        private TextBox textBox15;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private TextBox textBox16;
        private Label label14;
        private TabPage tabPage2;
        private Panel panel3;
        private ListView listView2;
        private ColumnHeader columnStudentName;
        private ColumnHeader emailStudent;
        private ColumnHeader departmentStudent;
        private ColumnHeader roleStudent;
        private ColumnHeader messageStudent;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ListView listView3;
        private ColumnHeader timeStamp1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader10;
        private ColumnHeader columnHeader11;
        private Button button5;
        private TextBox textBox10;
        private Button button4;
        private Button refreshButton;
    }
}
