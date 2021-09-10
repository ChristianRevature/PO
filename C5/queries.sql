-- a) Write an SQL query to fetch worker names with salaries >= 50000 and <= 100000
SELECT First_Name.Workers, Last_Name.Workers
FROM Workers
WHERE Salary >= 50000 AND Salary <= 10000;
-- b) Write a SQL query to fetch the no. of workers for each department in the descending order.
SELECT COUNT(*)
FROM Workers
GROUP BY Department
ORDER BY DESC;
-- c) Write an SQL query to fetch intersecting records of two tables.
SELECT *
FROM Workers w 
INNER JOIN Bonuses b on w.Worker_Id = b.Worker_Ref_Id; 

SELECT *
FROM Workers w 
INNER JOIN Titles t on w.Worker_Id = t.Worker_Ref_Id; 
-- d) Write an SQL query to determine the 5th highest salary without using TOP or limit method.
SELECT First_Name, Last_Name, Salary 
FROM (
SELECT w.*, ROW_NUMBER() OVER (ORDER BY Salary DESC) R 
FROM Workers w
) WHERE R = 5;
