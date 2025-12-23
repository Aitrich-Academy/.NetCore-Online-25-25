CREATE TABLE University (
    UID INT PRIMARY KEY,
    Name VARCHAR(20),
    Chancellor VARCHAR(20)
);
CREATE TABLE College (
    CID INT PRIMARY KEY,
    University INT,
    Dean INT,
    Name VARCHAR(20),
    FOREIGN KEY (University) REFERENCES University(UID),
    FOREIGN KEY (Dean) REFERENCES Dean(DeanID)
);
CREATE TABLE Dean (
    DeanID INT PRIMARY KEY,
    Name VARCHAR(20),
    DateOfBirth DATETIME
);
CREATE TABLE Department (
    DID INT PRIMARY KEY,
    College INT,
    Name VARCHAR(20),
    FOREIGN KEY (College) REFERENCES College(CID)
);
CREATE TABLE Professor (
    PID INT PRIMARY KEY,
    Department INT,
    Name VARCHAR(20),
    FOREIGN KEY (Department) REFERENCES Department(DID)
);
CREATE TABLE Course (
    CourseID INT PRIMARY KEY,
    Department INT,
    Name VARCHAR(50),
    FOREIGN KEY (Department) REFERENCES Department(DID)
);
ALTER TABLE Course ALTER COLUMN Name VARCHAR(30);


CREATE TABLE Subject (
    SubjectID INT PRIMARY KEY,
    Course INT,
    Professor INT,
    Name VARCHAR(20),
    FOREIGN KEY (Course) REFERENCES Course(CourseID),
    FOREIGN KEY (Professor) REFERENCES Professor(PID)
);
CREATE TABLE Student (
    StudentID INT PRIMARY KEY,
    Department INT,
    Name VARCHAR(20),
    DateOfEnrollment SMALLDATETIME,
    TelephoneNumber VARCHAR(20),
    FOREIGN KEY (Department) REFERENCES Department(DID)
);
CREATE TABLE Student_Registration (
    Student INT,
    Subject INT,
    FOREIGN KEY (Student) REFERENCES Student(StudentID),
    FOREIGN KEY (Subject) REFERENCES Subject(SubjectID)
);
INSERT INTO University VALUES
(1, 'Kerala University', 'Dr. A. Menon'),
(2, 'Madras University', 'Dr. L. Thomas'),
(3, 'Delhi University', 'Dr. S. Kapoor'),
(4, 'Mumbai University', 'Dr. A. Desai');
INSERT INTO Dean VALUES
(1, 'Renuka Sharma', '1970-03-12'),
(2, 'Prakash Nair', '1968-07-25'),
(3, 'Anita George', '1975-02-10'),
(4, 'Vijay Kumar', '1969-11-05');
INSERT INTO College VALUES
(1, 1, 1, 'Engineering College'),
(2, 2, 2, 'Arts College'),
(3, 3, 3, 'Science College'),
(4, 4, 4, 'Commerce College');
INSERT INTO Department VALUES
(1, 1, 'Computer Science'),
(2, 1, 'Electronics'),
(3, 2, 'English'),
(4, 3, 'Physics');
INSERT INTO Professor VALUES
(1, 1, 'George Peter'),
(2, 1, 'Ravi Das'),
(3, 2, 'Anil Raj'),
(4, 3, 'Maria Dsouza');
INSERT INTO Course VALUES
(1, 1, 'B.Tech Computer Science'),
(2, 1, 'B.Tech Electronics'),
(3, 2, 'BA English'),
(4, 3, 'BSc Physics');
INSERT INTO Subject VALUES
(1, 1, 1, 'Computer Networks'),
(2, 1, 2, 'Data Structures'),
(3, 3, 4, 'English Grammar'),
(4, 4, 3, 'Quantum Mechanics');
INSERT INTO Student VALUES
(1, 1, 'Kumar Varma', '2023-06-10', '9876543210'),
(2, 1, 'Asha Thomas', '2023-06-12', '9123456789'),
(3, 3, 'Neha Sharma', '2023-07-01', '9000012345'),
(4, 4, 'Rohit Das', '2023-08-15', '9898989898');
INSERT INTO Student_Registration VALUES
(1, 1),
(1, 2),
(2, 1),
(3, 3),
(4, 4);
select * from University
select * from Dean
select * from College
select * from Department
select * from Professor
select * from Course
select * from Subject
select * from Student
select * from Student_Registration


SELECT s.Name AS StudentName, c.Name AS CourseName
FROM Student s
JOIN Department d ON s.Department = d.DID
JOIN Course c ON d.DID = c.Department;


UPDATE Dean
SET Name = 'Renuka Mukerjee'
WHERE Name = 'Renuka Sharma';


UPDATE Student
SET TelephoneNumber = '8105874639'
WHERE Name = 'Kumar Varma';


SELECT s.Name AS Student, co.Name AS College, c.Name AS Course, p.Name AS Professor
FROM Student s
JOIN Department d ON s.Department = d.DID
JOIN College co ON d.College = co.CID
JOIN Course c ON d.DID = c.Department
JOIN Professor p ON d.DID = p.Department;






