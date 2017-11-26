--Task 4
--------------------------------------------------
--Write a SQL query to find the average salary in the department #1.

SELECT AVG(Salary) AS [AverageSalary] FROM Employees WHERE DepartmentID = 1;

SELECT DISTINCT d.NAme AS DepartmentName, AVG (Salary) AS AverageSalary 
FROM Employees e JOIN Departments d ON '1' = d.DepartmentID GROUP BY d.Name;

SELECT * FROM Employees WHERE DepartmentID='1';
SELECT * FROM Departments WHERE DepartmentID='1';