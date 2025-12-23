CREATE TABLE Customer (
    CustomerID INT PRIMARY KEY,
    Name VARCHAR(100),
    City VARCHAR(50),
    Email VARCHAR(100)
);

CREATE TABLE Orders2 (
    OrderID INT PRIMARY KEY,
    CustomerID INT,
    OrderDate DATE,
    TotalAmount DECIMAL(12,2),
   
);


CREATE TABLE OrderItems1 (
    ItemID INT PRIMARY KEY,
    OrderID INT,
    ProductID INT,
    Quantity INT,
    Price DECIMAL(10,2),
   
);


CREATE TABLE Products1 (
    ProductID INT PRIMARY KEY,
    ProductName VARCHAR(100),
    CategoryID INT,
    UnitPrice DECIMAL(10,2),
    
);

CREATE TABLE Categories (
    CategoryID INT PRIMARY KEY,
    CategoryName VARCHAR(100)
);


CREATE TABLE Employee1 (
    EmployeeID INT PRIMARY KEY,
    FirstName VARCHAR(50),
    LastName VARCHAR(50),
    DepartmentID INT,
    
);


CREATE TABLE Departments (
    DepartmentID INT PRIMARY KEY,
    DepartmentName VARCHAR(100)
);


CREATE TABLE Suppliers (
    SupplierID INT PRIMARY KEY,
    SupplierName VARCHAR(100),
    Country VARCHAR(50)
);

INSERT INTO Customer (CustomerID, Name, City, Email) VALUES
(1, 'Arjun Kumar', 'Chennai', 'arjun@gmail.com'),
(2, 'Priya Sharma', 'Bangalore', 'priya@yahoo.com'),
(3, 'Rahul Mehta', 'Delhi', 'rahul@hotmail.com'),
(4, 'Sneha Das', 'Mumbai', 'sneha@gmail.com'),
(5, 'Karan Patel', 'Pune', 'karan@outlook.com'),
(6, 'Nisha Rao', 'Hyderabad', 'nisha@gmail.com');

INSERT INTO Orders2 (OrderID, CustomerID, OrderDate, TotalAmount) VALUES
(201, 1, '2024-02-15', 120000),
(202, 2, '2024-03-10', 55000),
(203, 3, '2024-03-22', 76500),
(204, 1, '2024-04-05', 2000),
(205, 4, '2024-04-25', 80000),
(206, 5, '2024-05-02', 75000);

INSERT INTO OrderItems1 (ItemID, OrderID, ProductID, Quantity, Price) VALUES
(1, 201, 101, 2, 60000),
(2, 202, 102, 1, 55000),
(3, 203, 104, 1, 75000),
(4, 203, 105, 1, 1500),
(5, 204, 105, 2, 1000),
(6, 205, 103, 1, 80000),
(7, 206, 104, 1, 75000);

INSERT INTO Products1 (ProductID, ProductName, CategoryID, UnitPrice) VALUES
(101, 'Dell Inspiron', 1, 60000),
(102, 'HP Pavilion', 1, 55000),
(103, 'iPhone 15', 2, 80000),
(104, 'Samsung Galaxy S23', 2, 75000),
(105, 'Wireless Mouse', 3, 1200),
(106, 'Keyboard Combo', 3, 2500),
(107, 'HP Laser Printer', 4, 15000),
(108, 'MS Office License', 5, 9000);

INSERT INTO Categories (CategoryID, CategoryName) VALUES
(1, 'Laptops'),
(2, 'Mobiles'),
(3, 'Accessories'),
(4, 'Printers'),
(5, 'Software');


INSERT INTO Employee1 (EmployeeID, FirstName, LastName, DepartmentID) VALUES
(1, 'Amit', 'Verma', 1),
(2, 'Riya', 'Nair', 2),
(3, 'Vikram', 'Singh', 3),
(4, 'Anjali', 'Menon', NULL),
(5, 'Suresh', 'Kumar', 4);

INSERT INTO Departments (DepartmentID, DepartmentName) VALUES
(1, 'Sales'),
(2, 'HR'),
(3, 'IT'),
(4, 'Logistics'),
(5, 'Finance');


INSERT INTO Suppliers (SupplierID, SupplierName, Country) VALUES
(1, 'TechWorld Ltd', 'USA'),
(2, 'GadgetHub', 'India'),
(3, 'NextGen Supplies', 'Germany'),
(4, 'InfoTech Distributors', 'Japan'),
(5, 'DigitalZone', 'China');

SELECT 
    C.CustomerID,
    C.Name AS CustomerName,
    O.OrderDate,
    O.TotalAmount
FROM Customer C
INNER JOIN Orders2 O 
    ON C.CustomerID = O.CustomerID;



SELECT 
    O.OrderID,
    O.CustomerID,
    O.OrderDate,
    O.TotalAmount
FROM Orders2 O
LEFT JOIN Customer C 
    ON O.CustomerID = C.CustomerID
WHERE C.CustomerID IS NULL;


SELECT 
    P.ProductName,
    C.CategoryName
FROM Products1 P
INNER JOIN Categories C 
    ON P.CategoryID = C.CategoryID;



SELECT 
    C.CategoryID,
    C.CategoryName
FROM Categories C
LEFT JOIN Products1 P 
    ON C.CategoryID = P.CategoryID
WHERE P.ProductID IS NULL;


SELECT 
    E.EmployeeID,
    E.FirstName,
    E.LastName,
    D.DepartmentName
FROM Employee1 E
LEFT JOIN Departments D 
    ON E.DepartmentID = D.DepartmentID;


SELECT 
    C.CustomerID,
    C.Name AS CustomerName,
    SUM(O.TotalAmount) AS TotalSpent
FROM Customer C
INNER JOIN Orders2 O 
    ON C.CustomerID = O.CustomerID
GROUP BY C.CustomerID, C.Name;


SELECT 
    O.OrderID,
    P.ProductName,
    OI.Quantity,
    (OI.Quantity * OI.Price) AS TotalPrice
FROM Orders2 O
INNER JOIN OrderItems1 OI 
    ON O.OrderID = OI.OrderID
INNER JOIN Products1 P 
    ON OI.ProductID = P.ProductID;


SELECT TOP 5
    P.ProductName,
    SUM(OI.Quantity) AS TotalQuantitySold
FROM OrderItems1 OI
INNER JOIN Products1 P 
    ON OI.ProductID = P.ProductID
GROUP BY P.ProductName
ORDER BY TotalQuantitySold DESC;


SELECT 
    C.CustomerID,
    C.Name AS CustomerName,
    C.City
FROM Customer C
LEFT JOIN Orders2 O 
    ON C.CustomerID = O.CustomerID
WHERE O.OrderID IS NULL;





DECLARE @i INT = 1;
WHILE @i <= 10
BEGIN
    IF @i = 6
        BREAK; 
   PRINT 'Value: ' + CAST(@i AS NVARCHAR(10));
    SET @i = @i + 1;
END


DECLARE @num INT = 0;
WHILE @num < 10
BEGIN
    SET @num = @num + 1;
    IF @num % 2 = 0
    CONTINUE; 
PRINT 'Odd Number: ' + CAST(@num AS NVARCHAR(10));
END



CREATE PROCEDURE GetAllOrders
AS
BEGIN
    SELECT * FROM Orders2;
END;

EXEC GetAllOrders;



CREATE PROCEDURE GetCustomerOrders
    @CustomerID INT
AS
BEGIN
    SELECT o.OrderID, o.OrderDate, p.ProductName
    FROM Orders2 o
    JOIN Products1 p ON o.ProductID = p.ProductID
    WHERE o.CustomerID = @CustomerID;
END;




CREATE TABLE OrderAudit (
    AuditID INT PRIMARY KEY IDENTITY,
    OrderID INT,
    Action VARCHAR(50),
    Timestamp DATETIME
);

CREATE TRIGGER LogNewOrder2
ON Orders2
AFTER INSERT
AS
BEGIN
    DECLARE @OrderID INT;
    SELECT @OrderID = OrderID FROM INSERTED;
    INSERT INTO OrderAudit (OrderID, Action, Timestamp)
    VALUES (@OrderID, 'INSERT', GETDATE());
END;
INSERT INTO Orders2 VALUES (220, 1, '2024-02-15', 120000);
SELECT * FROM Orders2
SELECT * FROM OrderAudit;




CREATE TRIGGER PreventPriceDrop
ON Products1
FOR UPDATE
AS
BEGIN
    DECLARE @OldPrice DECIMAL(10, 2), @NewPrice DECIMAL(10, 2);
    SELECT @OldPrice = UnitPrice FROM DELETED;
    SELECT @NewPrice = UnitPrice FROM INSERTED;
    IF @NewPrice < @OldPrice * 0.80
    BEGIN
        RAISERROR('Price cannot be reduced by more than 20%%.', 16, 1);
        ROLLBACK TRANSACTION;
    END
END;

INSERT INTO Products1 VALUES (202, 'HP laptop', 1, 55000);
SELECT * FROM Products1;
UPDATE Products1 SET UnitPrice = 51000.00 WHERE ProductID = 202;




CREATE TABLE CustomerDeletionAudit1 (
    AuditID INT PRIMARY KEY IDENTITY,
    CustomerID INT,
    Name VARCHAR(100),
    Action VARCHAR(50),
    Timestamp DATETIME
);
CREATE TRIGGER LogCustomerDeletion
ON Customer
AFTER DELETE
AS
BEGIN
    DECLARE @CustomerID INT, @Name VARCHAR(100);
    SELECT @CustomerID = CustomerID, @Name = Name FROM DELETED;
    INSERT INTO CustomerDeletionAudit1 (CustomerID, Name, Action, Timestamp)
    VALUES (@CustomerID, @Name, 'DELETE', GETDATE());
END;
SELECT * FROM Customer;
DELETE FROM Customer WHERE CustomerID = 1;

SELECT * FROM CustomerDeletionAudit1;






