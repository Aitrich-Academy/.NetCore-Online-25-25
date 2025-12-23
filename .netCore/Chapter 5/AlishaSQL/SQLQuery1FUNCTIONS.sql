CREATE TABLE Employees2 (
    EmpID INT PRIMARY KEY IDENTITY(1,1),
    FirstName NVARCHAR(50),
    LastName NVARCHAR(50),
    Department NVARCHAR(30),
    Salary DECIMAL(10,2),
    JoinDate DATE
);
CREATE TABLE SalaryAudit (
    AuditID INT PRIMARY KEY IDENTITY(1,1),
    EmpID INT,
    OldSalary DECIMAL(10,2),
    NewSalary DECIMAL(10,2),
    ChangeDate DATETIME DEFAULT GETDATE()
);
CREATE TABLE DeletedEmployees (
    DelEmpID INT,
    EmpName NVARCHAR(100),
    DeletedOn DATETIME DEFAULT GETDATE()
);
INSERT INTO Employees2(FirstName, LastName, Department, Salary, JoinDate)
VALUES
('John', 'Doe', 'IT', 40000, '2020-01-15'),
('Anita', 'Rao', 'Finance', 65000, '2019-03-10'),
('Ravi', 'Sharma', 'HR', 42000, '2021-06-20'),
('Sara', 'Khan', 'IT', 75000, '2018-11-12'),
('Meena', 'Joshi', 'Finance', 50000, '2022-04-01');


CREATE FUNCTION dbo.fn_AnnualSalary(@EmpID INT)
RETURNS DECIMAL(12,2)
AS
BEGIN
    DECLARE @AnnualSalary DECIMAL(12,2);

    SELECT @AnnualSalary = Salary * 12
    FROM Employees2
    WHERE EmpID = @EmpID;

    RETURN @AnnualSalary;
END;
GO
SELECT FirstName + ' ' + LastName AS EmployeeName,
       dbo.fn_AnnualSalary(EmpID) AS AnnualSalary
FROM Employees2;


CREATE FUNCTION dbo.fn_FullName(@EmpID INT)
RETURNS NVARCHAR(100)
AS
BEGIN
    DECLARE @FullName NVARCHAR(100);

    SELECT @FullName = FirstName + ' ' + LastName
    FROM Employees2
    WHERE EmpID = @EmpID;

    RETURN @FullName;
END;
GO
SELECT dbo.fn_FullName(EmpID) AS FullName FROM Employees2;


CREATE FUNCTION dbo.fn_EmployeesByDept(@Dept NVARCHAR(30))
RETURNS TABLE
AS
RETURN
(
    SELECT EmpID, FirstName, LastName, Department, Salary, JoinDate
    FROM Employees2
    WHERE Department = @Dept
);
SELECT * FROM dbo.fn_EmployeesByDept('IT');
SELECT * FROM dbo.fn_EmployeesByDept('Finance');


CREATE FUNCTION dbo.fn_DeptSalarySummary()
RETURNS @DeptSummary TABLE
(
    Department NVARCHAR(30),
    TotalSalary DECIMAL(12,2),
    EmployeeCount INT,
    AverageSalary DECIMAL(12,2)
)
AS
BEGIN
    INSERT INTO @DeptSummary
    SELECT Department,
           SUM(Salary) AS TotalSalary,
           COUNT(*) AS EmployeeCount,
           AVG(Salary) AS AverageSalary
    FROM Employees2
    GROUP BY Department;
    RETURN;
END;
SELECT * FROM dbo.fn_DeptSalarySummary();


CREATE TRIGGER trg_NewEmployeeInsert
ON Employees2
AFTER INSERT
AS
BEGIN
    DECLARE @FullName NVARCHAR(100), @Dept NVARCHAR(30);

    SELECT @FullName = FirstName + ' ' + LastName, @Dept = Department
    FROM inserted;

    PRINT 'New employee ' + @FullName + ' added to the ' + @Dept + ' department.';
END;
INSERT INTO Employees2 (FirstName, LastName, Department, Salary, JoinDate)
VALUES ('Karan', 'Patel', 'HR', 48000, '2023-02-01');


CREATE TRIGGER trg_SalaryUpdate
ON Employees2
AFTER UPDATE
AS
BEGIN
    INSERT INTO SalaryAudit (EmpID, OldSalary, NewSalary)
    SELECT d.EmpID, d.Salary, i.Salary
    FROM deleted d
    JOIN inserted i ON d.EmpID = i.EmpID
    WHERE d.Salary <> i.Salary;
END;
UPDATE Employees2
SET Salary = 46000
WHERE EmpID = 1;
SELECT * FROM SalaryAudit;


CREATE TRIGGER trg_EmployeeDelete
ON Employees2
AFTER DELETE
AS
BEGIN
    INSERT INTO DeletedEmployees (DelEmpID, EmpName)
    SELECT EmpID, FirstName + ' ' + LastName
    FROM deleted;
END;
DELETE FROM Employees2 WHERE EmpID = 3;
SELECT * FROM DeletedEmployees;
