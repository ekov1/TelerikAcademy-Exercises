use TelerikAcademy;

--SELECT * FROM Departments;
--SELECT Name FROM Departments;
--SELECT Salary From Employees;
--SELECT FirstName, LastName FROM Employees;
--SELECT FirstName + '.' + LastName + '@telerik.com' AS Email FROM Employees;
--SELECT DISTINCT Salary FROM Employees;
--SELECT * FROM Employees WHERE JobTitle = 'Sales Representative';
--SELECT FirstName FROM Employees WHERE FirstName LIKE 'SA%';
--SELECT LastName FROM Employees WHERE LastName LIKE '%ei%';
--SELECT Salary FROM Employees WHERE Salary BETWEEN 20000 AND 30000;
--SELECT Salary FROM Employees WHERE Salary IN(25000, 14000, 12500 , 23600);
--SELECT FirstName FROM Employees WHERE SALARY = 25000 OR SALARY = 14000 OR SALARY = 12500 OR SALARY = 23600;
--SELECT * FROM Employees WHERE ManagerID IS NULL;
--SELECT * FROM Employees WHERE Salary > 50000 ORDER BY Salary DESC;
--SELECT TOP(5) * FROM Employees ORDER BY Salary DESC;
--SELECT Employees.FirstName, Addresses.AddressText FROM Employees INNER JOIN Addresses ON Employees.EmployeeID = Addresses.AddressID;
--SELECT FirstName + ' ' + LastName AS [Full name], a.AddressText FROM Employees e, Addresses a WHERE e.AddressID = a.AddressID;
--SELECT e.FirstName + ' ' + e.LastName AS [Employee name],  m.FirstName + ' ' + m.LastName AS [Manager name] FROM Employees e INNER JOIN Employees m ON e.ManagerID = m.EmployeeID;
--SELECT e.FirstName + ' ' + e.LastName AS [Employee name], m.FirstName + ' ' + m.LastName AS [Manager Name] FROM Employees e LEFT OUTER JOIN Employees m ON e.ManagerID = m.EmployeeID;
SELECT e.FirstName + ' ' + e.LastName AS [Employee name] FROM Employees e INNER JOIN Departments d ON e.DepartmentID = d.DepartmentID WHERE (d.Name IN('Sales', 'Finance'))  AND (YEAR(e.HireDate) BETWEEN 1995 AND 2005)