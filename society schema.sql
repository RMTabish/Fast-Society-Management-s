create Table Users(
    user_id INT AUTO_INCREMENT PRIMARY KEY,
    username VARCHAR(255) UNIQUE NOT NULL,
    password VARCHAR(255) NOT NULL,
    email VARCHAR(255) UNIQUE NOT NULL,
    first_name VARCHAR(255) NOT NULL,
    last_name VARCHAR(255) NOT NULL,
    phone VARCHAR(20),
    dob DATE, -- Date of Birth
    gender ENUM('male', 'female', 'other'),
    address TEXT,
	DEPT TEXT,
    role ENUM('admin', 'member', 'student', 'president', 'vice_president', 'executive_council', 'mentor') NOT NULL,
    created_at DATETIME DEFAULT CURRENT_TIMESTAMP
);

CREATE TABLE Societies (
    society_id INT AUTO_INCREMENT PRIMARY KEY,
    name VARCHAR(255) UNIQUE NOT NULL,
    description TEXT,
    mentor_id INT, 
    president_id INT,
    phone VARCHAR(20),
    email VARCHAR(255) UNIQUE NOT NULL,
	DEPT TEXT,
    created_at DATETIME DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (mentor_id) REFERENCES Users(user_id),
    FOREIGN KEY (president_id) REFERENCES Users(user_id)
);
ALTER TABLE Societies
Add COLUMN stats text;
Select * from Societies;
CREATE TABLE Society_Members (
    society_member_id INT AUTO_INCREMENT PRIMARY KEY,
    user_id INT NOT NULL,
    society_id INT NOT NULL,
    join_date DATETIME DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (user_id) REFERENCES Users(user_id),
    FOREIGN KEY (society_id) REFERENCES Societies(society_id)
);
ALTER TABLE Societies MODIFY COLUMN mentor_id INT NULL;
ALTER TABLE Societies MODIFY COLUMN president_id INT NULL;

INSERT INTO Users (username, password, email, role, first_name, last_name)
VALUES 
('mentoruser', 'password', 'mentor@example.com', 'mentor', 'Mentor', 'User'),
('presidentuser', 'password', 'president@example.com', 'president', 'President', 'User');

SELECT user_id FROM Users WHERE username = 'mentoruser';
SELECT user_id FROM Users WHERE username = 'presidentuser';

CREATE TABLE Executive_Council_Members (
    ec_member_id INT AUTO_INCREMENT PRIMARY KEY,
    user_id INT NOT NULL,
    society_id INT NOT NULL,
    position VARCHAR(255), 
    FOREIGN KEY (user_id) REFERENCES Users(user_id),
    FOREIGN KEY (society_id) REFERENCES Societies(society_id)
);

CREATE TABLE Events (
    event_id INT AUTO_INCREMENT PRIMARY KEY,
    society_id INT NOT NULL,
    name VARCHAR(255) NOT NULL,
    description TEXT,
    event_date DATETIME NOT NULL,
    location TEXT,
    created_at DATETIME DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (society_id) REFERENCES Societies(society_id)
);

CREATE TABLE Event_participants (
    participation_id INT AUTO_INCREMENT PRIMARY KEY,
    event_id INT NOT NULL,
    user_id INT NOT NULL,
    status ENUM('attending', 'interested', 'declined'),
    FOREIGN KEY (event_id) REFERENCES Events(event_id),
    FOREIGN KEY (user_id) REFERENCES Users(user_id)
);
DELETE FROM Societies WHERE society_id > 0;
DELETE FROM Users WHERE user_id > 0;
INSERT INTO Users (username, password, email, role, first_name, last_name) VALUES
('president_user', 'securepassword', 'president@fastuniversity.com', 'president', 'Ayesha', 'Khan'),
('mentor_user', 'securepassword', 'mentor@fastuniversity.com', 'mentor', 'Ali', 'Ahmed');

SELECT user_id FROM Users WHERE username = 'mentor_user';
INSERT INTO Societies (name, description, mentor_id, president_id, phone, email, DEPT, stats) VALUES
('FAST Computing Society', 'Dedicated to computing technologies and innovations.', 4, 3, '1234567890', 'computing@fastuniversity.com', 'Computer Science', 'Active'),
('FAST Literary Society', 'A society for lovers of literature and poetry.', 4, 3, '0987654321', 'literary@fastuniversity.com', 'Arts and Humanities', 'Active');

