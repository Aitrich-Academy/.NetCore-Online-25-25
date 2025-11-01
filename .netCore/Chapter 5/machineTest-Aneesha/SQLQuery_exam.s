CREATE DATABASE ProductTable

USE ProductTable;
GO

CREATE TABLE Product(
    Product INT Primary Key,
    ProductName VARCHAR(50),
    Price DECIMAL(10,2)
);

INSERT INTO Product
VALUES
(1,'Laptop',50000),
(2,'Smartphone',25000),
(3,'Tablet',30000),
(4,'Smartwatch',10000);

SELECT * from Product;

CREATE Table Sales4(
    SaleID INT Primary KEY,
    ProductID INT,
    Quantity INT ,
    SaleDate DATE,
    FOREIGN KEY (ProductID) REFERENCES Product

);

INSERT INTO Sales4
VALUES
(101,1,3,'2024-03-01'),
(102,2,5,'2024-03-02'),
(103,1,2,'2024-03-05'),
(104,3,1,'2024-03-06'),
(105,2,3,'2024-03-07');

SELECT * FROM Sales4;

-- Revenue = Price * Quantity
SELECT
    p.ProductName,
    SUM(p.Price * s.Quantity) AS TotalRevenue
    FROM Product p
    JOIN Sales4 s ON p.Product = s.ProductID
    GROUP BY ProductName;


SELECT
    p.ProductName,
    SUM(s.Quantity) As TotalQuantity
From product p
JOIN Sales4 s ON p.Product = s.ProductID
GROUP BY p.ProductName;


SELECT
    p.ProductName
    FROM Product p
    LEFT JOIN Sales4 s ON p.Product = s.ProductID
    WHERE s.ProductID IS NULL;

    SELECT 
    SUM(p.Price * s.Quantity) AS MarchRevenue
    FROM Product p
    JOIN Sales4 s ON p.Product = s.ProductID
    WHERE MONTH(s.SaleDate) = 3 And YEAR(s.SaleDate) = 2024;










