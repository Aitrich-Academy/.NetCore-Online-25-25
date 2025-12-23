CREATE DATABASE CompanyDB;
CREATE TABLE Employees (
    EmpID INT PRIMARY KEY,
    FirstName VARCHAR(50),
    LastName VARCHAR(50),
    Salary DECIMAL(10,2),
    JoiningDate DATE
);

ALTER TABLE Employees
ADD Department VARCHAR(30);
ALTER TABLE Employees
ALTER COLUMN Salary DECIMAL(12,2);
select * from Employees


ALTER TABLE Employees
DROP COLUMN JoiningDate;


DROP TABLE Employees;
DROP DATABASE Company;


CREATE TABLE Authors (
    AuthorID INT PRIMARY KEY,
    AuthorName VARCHAR(50)
);

CREATE TABLE Books (
    BookID INT PRIMARY KEY,
    Title VARCHAR(100),
    AuthorID INT,
    FOREIGN KEY (AuthorID) REFERENCES Authors(AuthorID)
);






