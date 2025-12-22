DROP DATABASE Eductaion

CREATE DATABASE Education


CREATE TABLE University (
    UID INT IDENTITY(1,1) PRIMARY KEY,
    Name VARCHAR(20),
    Chancellor VARCHAR(20)
);

CREATE Table  College (
    CID INT IDENTITY(1,1) PRIMARY key,
    University INT,
    Dean INT,
    Name VARCHAR(20),
    -- CONSTRAINT fk_college_university FOREIGN KEY(University) REFERENCES UNIVERSITY(UID),
    -- CONSTRAINT fk_college_dean FOREIGN KEY (Dean) REFERENCES Dean(DeanID)
)

CREATE TABLE Dean (
    DeanID INT IDENTITY(1,1) PRIMARY KEY,
    Name VARCHAR(20),
    DateOfBirth DATETIME
);

CREATE TABLE Department(

    DID INT IDENTITY(1,1) PRIMARY KEY,
    College INT,
    Name VARCHAR (20),
    -- CONSTRAINT fk_Department_college FOREIGN Key(College) REFERENCES  College(CID),
);

CREATE TABLE Professor(
    PID  INT IDENTITY(1,1) PRIMARY KEY,
    Department Int,
    Name VARCHAR(20),
    -- CONSTRAINT fk_Professor_department FOREIGN key (Department) REFERENCES Department(DID),
);




CREATE TABLE Course (
    CourseID INT IDENTITY(1,1) PRIMARY KEY,
    Department INT,
    Name VARCHAR (20),
    -- CONSTRAINT fk_Course_departmnet FOREIGN key (Department) REFERENCES Department(DID),
);
ALTER TABLE Course ALTER COLUMN Name VARCHAR(50);

CREATE TABLE Subject(
    SubjectID INT IDENTITY(1,1) PRIMARY Key,
    Course INT,
    Professor INT,
    Name VARCHAR (20),
    -- CONSTRAINT fk_Subject_Course   FOREIGN key (Course) REFERENCES Course (CourseID),
    -- CONSTRAINT fk_subject_Professor FOREIGN key (Professor) REFERENCES Professor(PID),
);


CREATE TABLE Student(
    StudentID INT IDENTITY(1,1) PRIMARY key,
    Department INT,
    Name VARCHAR(20),
    DateofEnrollment smalldatetime,
    TelephoneNumber VARCHAR(20),
    -- CONSTRAINT fk_Student_Department FOREIGN key (Department) REFERENCES  Department (DID),
);

CREATE TABLE Student_Registration (
    Student INT,
    Subject INT,
    -- CONSTRAINT fk_Student_registration FOREIGN Key (Student) REFERENCES Student (StudentID),
    -- CONSTRAINT fk_subject_registration FOREIGN key (subject) REFERENCES subject (SubjectID),
)

---Add sample records---

-- University
INSERT INTO University (Name, Chancellor) VALUES ('MG University', 'John Smith');

-- Dean
INSERT INTO Dean (Name, DateOfBirth) VALUES ('Renuka Sharma', '1975-03-15');

-- College
INSERT INTO College (University, Dean, Name) VALUES (1, 1, 'Engineering College');
INSERT INTO College (University, Dean, Name) VALUES (2, 2, 'bharathiyar');
INSERT INTO College (University, Dean, Name) VALUES (3, 3, 'Aitrich');



-- Department
INSERT INTO Department (College, Name) VALUES (1, 'MCA'),(2,'MBA');

-- Professor
INSERT INTO Professor (Name,Department) VALUES ('John',1),('Aysha','2'),('George Peter','3');

SELECT * from Professor;

-- Course
INSERT INTO Course (Department, Name) VALUES (1, 'B.Tech Computer Science');

-- Subject
INSERT INTO Subject (Course, Professor, Name) VALUES (1, 2, 'Data Structures');


DELETE FROM Subject;
select * from Department
INSERT into Subject (Course,Professor,Name) VALUES (3,4,'BBA');

INSERT INTO Subject (Course, Professor, Name)
VALUES (3, 4, 'Maths');

SELECT *FROM Subject

-- Student
INSERT INTO Student (Department, Name, DateOfEnrollment, TelephoneNumber)
VALUES 
(1, 'Kumar Varma', '2025-08-01', '9000000000'),
(2, 'Anamika', '2024-08-07', '70000000'),
(3, 'Mini', '2025-08-09', '800000');

SELECT * from student;
-- Student Registration
INSERT INTO Student_Registration (Student, Subject) VALUES (1, 1);

SELECT * from Dean

CREATE VIEW StudentCourses AS
SELECT s.Name AS StudentName,c.Name As CourseName
FROM Student s
JOIN Department d ON s.Department = d.DID 
JOIN Course c ON d.DID = c.Department;

DROP VIEW StudentCourses;




SELECT * from StudentCourses
SELECT * from Course;

UPDATE Dean
SET Name = 'Renuka Mukerjee'
WHERE Name = 'Renuka Sharma';

select * from Dean


UPDATE Student
set TelephoneNumber = 8105874639
WHERE Name = 'Kumar Varma';

ALTER TABLE Professor ADD Name VARCHAR(20);
ALTER TABLE Department ADD Name VARCHAR(20);


SELECT p.PID, p.Name AS Professor, d.Name AS Department
FROM Professor p
JOIN Department d ON p.Department = d.DID
WHERE d.Name = 'MCA';

SELECT * FROM Professor;
SELECT * FROM Department;

DROP TABLE IF EXISTS Professor;
DROP TABLE IF EXISTS Department;



SELECT p.PID, p.Name AS Professor, d.Name AS Department
FROM Professor p
JOIN Department d ON p.Department = d.DID
WHERE d.Name = 'MCA';

UPDATE Professor SET Name = 'George Peter' WHERE PID = 1;

SELECT c.Name AS CourseName
FROM Course c
JOIN Subject s ON c.CourseID = s.Course
JOIN Professor p ON s.Professor = p.PID
WHERE p.Name = 'George Peter';

SELECT * FROM Professor;
SELECT * FROM Subject;
SELECT * FROM Course;

SELECT d.Name AS DepartmentName, COUNT(s.StudentID) AS NoOfStudents
FROM Student s
JOIN Department d ON s.Department = d.DID
GROUP BY d.Name;

SELECT Name AS CollegeName
From College
ORDER BY Name DESC

SELECT s.Name AS SubjectName
FROM Subject s 
JOIN Course c ON s.Course = c.CourseID
WHERE c.Name = 'B.Tech Computer Science';


INSERT INTO Course (Department, Name) VALUES (2, 'BBA');
INSERT INTO Course (Department, Name) VALUES (3, 'MBA');


INSERT INTO Subject (Course, Professor, Name) VALUES (2, 4, 'Marketing');
INSERT INTO Subject (Course, Professor, Name) VALUES (2, 4, 'Accounting');
INSERT INTO Subject (Course, Professor, Name) VALUES (3, 4, 'Economics');

SELECT * FROM Course;
SELECT * FROM Subject;

UPDATE Subject
SET Course = 2
WHERE Name IN ('Marketing', 'Accounting');

UPDATE Subject
SET Course = 2
WHERE Name = 'Data Structures';

DELETE FROM Subject
WHERE SubjectID IN (
    SELECT TOP 1 SubjectID 
    FROM Subject
    WHERE Name = 'Data Structures'
);


SELECT COUNT(Distinct c.CourseID) AS NoOfCourses
FROM Course c 
JOIN Subject s ON c.CourseID = s.Course
WHERE s.Name LIKE '%Computer';

INSERT INTO Subject (Course, Professor, Name) VALUES (1, 1, 'Computer Networks');



UPDATE Subject
SET Course = 2
WHERE SubjectID IN (1008, 1009);


SELECT s.Name AS SubjectName,p.Name As ProfessorName
From Subject s 
JOIN Professor P ON s.Professor = p.PID 
ORDER BY s.Name;














