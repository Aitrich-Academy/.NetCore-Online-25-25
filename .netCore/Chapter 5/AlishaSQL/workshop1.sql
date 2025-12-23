CREATE DATABASE HireMeNowDB;
USE HireMeNowDB;
CREATE TABLE Company (
    Id UNIQUEIDENTIFIER DEFAULT NEWID() PRIMARY KEY,
    Name varchar(100) NULL,
    Email varchar(50) NOT NULL UNIQUE,
    Website varchar(50) NULL,
    Phone varchar(50) NULL,
    About varchar(300) NULL,
    Location varchar(50) NULL,
    Status varchar(50) NULL
);
EXEC sp_rename 'Company', 'Companies';
ALTER TABLE Companies ALTER COLUMN About varchar(300);
INSERT INTO Companies (Name, Email, Website, Phone, About, Location, Status)VALUES 
('TechNova Pvt Ltd', 'contact@technova.com', 'www.technova.com', '9876543210', 'A software company specializing in AI solutions.', 'Bangalore', 'Active'),
('GreenLeaf Solutions', 'info@greenleaf.com', 'www.greenleaf.com', '9123456780', 'Provides eco-friendly products and services.', 'Mumbai', 'Active'),
('BuildRight Constructions', 'support@buildright.com', 'www.buildright.com', '9988776655', 'Leading construction company with 15 years of experience.', 'Chennai', 'Inactive'),
('Skyline Travels', 'hello@skyline.com', 'www.skyline.com', '9001234567', 'Travel and tourism company offering worldwide packages.', 'Delhi', 'Active');
SELECT * FROM Companies;
UPDATE Companies SET Name = 'Aitrich Academy' WHERE Email = 'hello@skyline.com';
DELETE FROM Companies WHERE Email = 'info@greenleaf.com';




CREATE TABLE Users (
    Id UNIQUEIDENTIFIER DEFAULT NEWID() PRIMARY KEY,
    [FirstName] [varchar](50) NULL,
    [LastName] [varchar](50) NULL,
    [Email] [varchar](50) NOT NULL UNIQUE,
    [Gender] [varchar](50) NULL,
    [Location] [varchar](50) NULL,
    [CompanyId] [uniqueidentifier] NULL,
    [Status] [varchar](50) NULL
);
ALTER TABLE Users ADD CONSTRAINT email_unique UNIQUE (Email);
INSERT INTO Users (FirstName, LastName, Email, Gender, Location, CompanyId, Status)
VALUES ('Ravi', 'Kumar', 'ravi.kumar@technova.com', 'Male', 'Bangalore', NULL, 'Job Provider');
INSERT INTO Users (FirstName, LastName, Email, Gender, Location, CompanyId, Status)
VALUES ('Priya', 'Menon', 'priya.menon@gmail.com', 'Female', 'Chennai', NULL, 'Job Seeker');
INSERT INTO Users (FirstName, LastName, Email, Gender, Location, CompanyId, Status)
VALUES ('Arjun', 'Patel', 'arjun.patel@greenleaf.com', 'Male', 'Mumbai', NULL, 'Company Member');
SELECT * FROM Users;
UPDATE Users SET Location = 'Kochi' WHERE Email = 'ravi.kumar@technova.com';
SELECT * FROM Users WHERE status = 'Job Seeker';




select * from students;

