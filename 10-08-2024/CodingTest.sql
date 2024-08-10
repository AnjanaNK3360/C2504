CREATE DATABASE CodingTest_db;
USE CodingTest_db;

---1)Find Departments with No Employees
----Problem: Given a `Departments` table and an `Employees` table,
----find departments that do not have any employees.
--Table Structure:

CREATE TABLE Departments (
	DepartmentID INT,
	DepartmentName VARCHAR(100)
);

INSERT INTO Departments (DepartmentID, DepartmentName)
VALUES
	(1, 'Human Resources'),
	(2, 'Engineering'),
	(3, 'Sales'),
	(4, 'Marketing'),
	(5, 'Finance');

SELECT * FROM Departments;

CREATE TABLE Employees (
	EmployeeID INT,
	DepartmentID INT
);

INSERT INTO Employees (EmployeeID, DepartmentID)
VALUES
	(1, 2),
	(2, 2),
	(3, 3),
	(4, 5);
SELECT * FROM Employees;

SELECT d.DepartmentName 
FROM Departments  d
LEFT JOIN Employees e ON d.DepartmentID = e.DepartmentID
WHERE e.EmployeeID IS NULL;



--2)Find the Day with the Highest Sales
--Problem: Given a `Sales` table
--with columns `SaleAmount` and `SaleDate`,
--find the day with the highest total sales.


CREATE TABLE Sales (
    SaleID INT PRIMARY KEY,
    SaleAmount DECIMAL(10, 2),
    SaleDate DATE
);

INSERT INTO Sales (SaleID, SaleAmount, SaleDate)
VALUES
	(1, 100.50, '2024-08-01'),
	(2, 200.00, '2024-08-01'),
	(3, 150.75, '2024-08-02'),
	(4, 250.00, '2024-08-03'),
	(5, 50.00,  '2024-08-03'),
	(6, 300.00, '2024-08-03'),
	(7, 400.00, '2024-08-04'),
	(8, 100.00, '2024-08-04');


SELECT * FROM Sales;

SELECT TOP 1 DAY(SaleDate) AS SaleDay ,SaleDate, SUM(SaleAmounT) AS TotalSales
FROM Sales
GROUP BY SaleDate 
ORDER BY TotalSales  DESC
--LIMIT 1;


--3)Find Employees with No Manager
--Problem:
--Given an `Employees` table
--with columns `EmployeeID`, `Name`, and `ManagerID`
---(which refers to `EmployeeID` of the manager),
--find all employees who do not have a manager.

CREATE TABLE Employees (
	EmployeeID INT,
	Name VARCHAR(100),
	ManagerID INT
);

INSERT INTO Employees (EmployeeID, Name, ManagerID)
VALUES
	(1, 'Alice', NULL),    
	(2, 'Bob', 1),       
	(3, 'Charlie', 1),     
	(4, 'David', 2),       
	(5, 'Eve', 3);     

SELECT * FROM Employees;

SELECT EmployeeID , Name
FROM Employees 
WHERE ManagerID IS NULL


--4)Find Employees with the Most Orders
--Problem: Given an `Employees` table and an `Orders` table,
--find the employee who has processed the most orders.
--Table Structure:

CREATE TABLE Employeees (
	EmployeeeID INT,
	Name VARCHAR(100)
);

INSERT INTO Employeees (EmployeeeID, Name)
VALUES
	(1, 'Alice'),
	(2, 'Bob'),
	(3, 'Charlie'),
	(4, 'David');
SELECT*FROM Employeees;

CREATE TABLE Orders (
	OrderID INT,
	EmployeeeID INT
);

INSERT INTO Orders (OrderID, EmployeeeID)
VALUES
	(1, 1),   
	(2, 2),  
	(3, 1),   
	(4, 3),   
	(5, 1),  
	(6, 4),   
	(7, 1),  
	(8, 2);   
SELECT*FROM Orders;

SELECT TOP 1 e.EmployeeeID , e.Name,COUNT(OrderID) AS OrderCount
FROM Employeees e
INNER JOIN Orders o ON e.EmployeeeID = o.EmployeeeID
GROUP BY e.EmployeeeID, e.Name
ORDER BY OrderCount DESC;


----5)Find the Top N Products by Sales Volume
----Problem: Given a `Sales` table
----with columns `ProductID`, `SaleAmount`, and `SaleDate`,
----find the top 5 products by total sales volume.
----Table Structure:

CREATE TABLE Business (
	ProductID INT,
	SaleAmount DECIMAL(10, 2),
	SaleDate DATE
);


INSERT INTO Business(ProductID, SaleAmount, SaleDate)
VALUES
(1, 100.00, '2024-08-01'),
(2, 200.00, '2024-08-01'),
(3, 150.00, '2024-08-01'),
(1, 50.00, '2024-08-02'),
(2, 250.00, '2024-08-02'),
(3, 300.00, '2024-08-02'),
(4, 400.00, '2024-08-03'),
(5, 500.00, '2024-08-03'),
(1, 100.00, '2024-08-03'),
(2, 200.00, '2024-08-03'),
(3, 150.00, '2024-08-03'),
(4, 100.00, '2024-08-04'),
(5, 200.00, '2024-08-04');

SELECT*FROM Business;


SELECT TOP 5 ProductID, SUM(SaleAmount) AS TotalSale
FROM Business
GROUP BY ProductID
ORDER BY  TotalSale DESC;

