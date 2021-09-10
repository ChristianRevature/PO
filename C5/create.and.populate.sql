--Create the Db
CREATE DATABASE sql_challenege;

CREATE TABLE Workers(
  Worker_Id INT PRIMARY KEY,
  First_Name VARCHAR(50),
  Last_Name VARCHAR(50),
  Salary INT,
  Joining_Date DATETIME,
  Department VARCHAR(50)
);

CREATE TABLE Bonuses(
  Worker_Ref_Id INT Foreign Key REFERENCES Workers(Worker_Id),  
  Bonus_Date DATETIME,
  Bonus_Amount INT,
);

CREATE TABLE Titles(
  Worker_Ref_Id INT Foreign Key REFERENCES Workers(Worker_Id), 
  Worker_Title VARCHAR(100),
  Affected_from DATETIME,
);

--Populate the DB
INSERT INTO Workers (Worker_Id, First_Name, Last_Name, Salary, Joining_Date, Department)
VALUES (1,	'Rick',	'Smith'	,100000,'2021-02-20 09:00:00','HR');
INSERT INTO Workers (Worker_Id, First_Name, Last_Name, Salary, Joining_Date, Department)
VALUES (2,	'Sam',	'Williams',	80000,'2021-06-11 09:00:00','Admin');
INSERT INTO Workers (Worker_Id, First_Name, Last_Name, Salary, Joining_Date, Department)
VALUES (3,	'John',	'Brown'	,300000,'2021-02-20 09:00:00','HR');
INSERT INTO Workers (Worker_Id, First_Name, Last_Name, Salary, Joining_Date, Department)
VALUES (4,	'Amy',	'Jones'	,500000,'2021-02-20 09:00:00','Admin');
INSERT INTO Workers (Worker_Id, First_Name, Last_Name, Salary, Joining_Date, Department)
VALUES (5,	'Sean',	'Garcia',500000,'2021-06-11 09:00:00','Admin');
INSERT INTO Workers (Worker_Id, First_Name, Last_Name, Salary, Joining_Date, Department)
VALUES (6,	'Ryan',	'Miller',200000,'2021-06-11 09:00:00','Account');
INSERT INTO Workers (Worker_Id, First_Name, Last_Name, Salary, Joining_Date, Department)
VALUES (7,	'Patty','Davis',75000,'2021-01-20 09:00:00','Account');
INSERT INTO Workers (Worker_Id, First_Name, Last_Name, Salary, Joining_Date, Department)
VALUES (8,	'Monica','Rodriguez',90000,'2021-04-11 09:00:00','Admin');

INSERT INTO Bonuses (Worker_Ref_Id, Bonus_Date, Bonus_Amount)
VALUES (1,	'2021-02-20 00:00:00',5000);
INSERT INTO Bonuses (Worker_Ref_Id, Bonus_Date, Bonus_Amount)
VALUES (2,	'2021-06-11 00:00:00',3000);
INSERT INTO Bonuses (Worker_Ref_Id, Bonus_Date, Bonus_Amount)
VALUES (3,	'2021-02-20 00:00:00',4000);
INSERT INTO Bonuses (Worker_Ref_Id, Bonus_Date, Bonus_Amount)
VALUES (1,	'2021-02-20 00:00:00',4500);
INSERT INTO Bonuses (Worker_Ref_Id, Bonus_Date, Bonus_Amount)
VALUES (2,	'2021-06-11 00:00:00',3500);

INSERT INTO Titles (Worker_Title, Worker_Title, Affected_from)
VALUES (1,	'Manager','2021-02-20 00:00:00');
INSERT INTO Titles (Worker_Title, Worker_Title, Affected_from)
VALUES (2,	'Executive','2021-06-11 00:00:00');
INSERT INTO Titles (Worker_Title, Worker_Title, Affected_from)
VALUES (8,	'Executive','2021-06-11 00:00:00');
INSERT INTO Titles (Worker_Title, Worker_Title, Affected_from)
VALUES (5,	'Manager','2021-06-11 00:00:00');
INSERT INTO Titles (Worker_Title, Worker_Title, Affected_from)
VALUES (4,	'Asst. Manager','2021-06-11 00:00:00');
INSERT INTO Titles (Worker_Title, Worker_Title, Affected_from)
VALUES (7,	'Executive','2021-06-11 00:00:00');
INSERT INTO Titles (Worker_Title, Worker_Title, Affected_from)
VALUES (6,	'Lead',	'2021-06-11 00:00:00');
INSERT INTO Titles (Worker_Title, Worker_Title, Affected_from)
VALUES (3,	'Lead',	'2021-06-11 00:00:00');