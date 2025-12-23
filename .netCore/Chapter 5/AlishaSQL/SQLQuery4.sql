CREATE TABLE Classroom (
    RollNo INT PRIMARY KEY,         
    StudentName VARCHAR(50),       
    AdmissionNo VARCHAR(20) UNIQUE 
);
INSERT INTO Classroom (RollNo, StudentName, AdmissionNo)
VALUES (1, 'Alisha', '100');
INSERT INTO Classroom (RollNo, StudentName, AdmissionNo)\
VALUES (2, 'Aneesha', '101');
INSERT INTO Classroom (RollNo, StudentName, AdmissionNo)
VALUES (2, 'Aleesha', '101');


CREATE TABLE Exams (
    ExamID INT PRIMARY KEY,            
    StudentID INT,           
    Marks INT CHECK (Marks >= 0 AND Marks <= 100) 
);
INSERT INTO Exams (ExamID, StudentID, Marks)
VALUES (1, 100, 75); 
INSERT INTO Exams (ExamID, StudentID, Marks)
VALUES (2, 200, 90); 
INSERT INTO Exams (ExamID, StudentID, Marks)
VALUES (3, 300, 150);



CREATE TABLE Transactions (
    TxnID INT PRIMARY KEY,          
    AccountNo VARCHAR(20),         
    TxnDate DATETIME DEFAULT GETDATE(), 
    Amount DECIMAL(10,2)            
);
INSERT INTO Transactions (TxnID, AccountNo, Amount)
VALUES (1, '1234', 1000);
INSERT INTO Transactions (TxnID, AccountNo, TxnDate, Amount)
VALUES (2, '4321', '03-10-2001', 1500);



CREATE TABLE Staff (
    StaffID INT PRIMARY KEY,    
    Name VARCHAR(50) NOT NULL,  
    Department VARCHAR(30)      
);



