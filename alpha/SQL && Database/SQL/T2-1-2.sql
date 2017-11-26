--Task 1
--------------------------------------------------
SELECT FirstName, LastName, Salary FROM Employees
WHERE Salary = (SELECT MIN(Salary) FROM Employees);
--Task 2
--------------------------------------------------
SELECT FirstName, LastName, Salary FROM Employees
WHERE Salary 
 BETWEEN (SELECT MIN(Salary) FROM Employees) AND ((SELECT MIN(Salary) FROM Employees)+(SELECT MIN(Salary) FROM Employees) * 0.1);