CREATE TABLE Customers2(
CustomerID INT PRIMARY KEY,
CustomerName VARCHAR(50),
City VARCHAR(50));

CREATE TABLE Orders3(
OrderID INT PRIMARY KEY,
CustomerID INT,
OrderDate DATE,
TotalAmount DECIMAL(10,2)
FOREIGN KEY (CustomerID) REFERENCES Customers2 (CustomerID));

INSERT INTO Customers2(CustomerID, CustomerName, City)VALUES
(1, 'Alice', 'New York'),
(2, 'Bob', 'Chicago'),
(3, 'Charlie', 'Los Angeles'),
(4, 'David', 'Houston');
SELECT * FROM Customers2;

INSERT INTO Orders3(OrderID ,CustomerID, OrderDate ,TotalAmount)VALUES
(101, 1, '2024-02-15', 500),
(102, 2, '2024-02-16', 700),
(103, 1, '2024-03-01', 200),
(104, 3, '2024-03-05', 900),
(105, 2, '2024-03-07', 450);


SELECT
c.CustomerName,
SUM(o.TotalAmount) AS Total
FROM Customers2 c 
JOIN Orders3 o
ON c.CustomerID=o.CustomerID
GROUP BY c.CustomerName;


SELECT CustomerName FROM Customers2
WHERE CustomerID NOT IN (SELECT CustomerID FROM Orders3);


SELECT
c.CustomerName,
MAX(o.OrderDate) AS RecentOrder
FROM Customers2 c
JOIN Orders3 o ON c.CustomerID=o.CustomerID
GROUP BY c.CustomerName;


SELECT
c.CustomerName,
SUM(o.TotalAmount) AS MostSpent
FROM Customers2 c 
JOIN Orders3 o
ON c.CustomerID=o.CustomerID
GROUP BY c.CustomerName
ORDER BY MostSpent DESC;

SELECT
COUNT(*) AS March2024Orders
FROM Orders3 WHERE MONTH(OrderDate)=3;

