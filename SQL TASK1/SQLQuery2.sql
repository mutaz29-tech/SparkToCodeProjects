--// Database creation script 
--CREATE DATABASE CompanyDB; 
--GO; 
----USE CompanyDB;
----//////////////////////////////////////////
--///Department
--CREATE TABLE Department
--(
--Dnumber INT PRIMARY KEY,
--Dname VARCHAR(60) NOT NULL UNIQUE,
--Mgr_ssn CHAR(9),
--Mgr_start_date DATE,
--NumberOfEmployees INT DEFAULT 0 CHECK (NumberOfEmployees >= 0)
--);
--//////////////
--////Employee
--CREATE TABLE Employee
--(
--    Ssn CHAR(9) PRIMARY KEY,
--    Fname VARCHAR(30) NOT NULL,
--    Minit CHAR(1),
--    Lname VARCHAR(30) NOT NULL,
--    Address VARCHAR(100),
--    Sex CHAR(1) NOT NULL CHECK (Sex IN ('M','F')),
--    Bdate DATE,
--    Salary DECIMAL(10,2) NOT NULL CHECK (Salary > 0),
--    Dno INT NOT NULL,
--    Super_ssn CHAR(9)
--);
--//////////////////////////////////
--//Dept_Locations
--CREATE TABLE Dept_Locations
--(
--Dnumber  INT NOT NULL,
--Dlocation VARCHAR(40) NOT NULL,
--PRIMARY KEY (Dnumber, Dlocation),

--    FOREIGN KEY (Dnumber)
--        REFERENCES Department(Dnumber)
--);
--///////////////////////////////
--//Project
--CREATE TABLE Project
--(
--    Pnumber INT PRIMARY KEY,
--    Pname VARCHAR(50) NOT NULL UNIQUE,
--    Plocation VARCHAR(50),
--    Dnum INT NOT NULL,
--    FOREIGN KEY (Dnum)
--        REFERENCES Department(Dnumber)
--);
--/////////////////////////////////////////
--///Works_On
--CREATE TABLE Works_On
--(
--    Essn CHAR(9),
--    Pno INT,
--    Hours DECIMAL(4,1) CHECK (Hours >= 0),
--    PRIMARY KEY (Essn, Pno),
--    FOREIGN KEY (Essn)
--        REFERENCES Employee(Ssn),
--    FOREIGN KEY (Pno)
--        REFERENCES Project(Pnumber)
--);
--/////////////////////////////////
--//Dependent
--CREATE TABLE Dependent
--(
--    Essn CHAR(9),
--    Dependent_name VARCHAR(30),
--    Sex CHAR(1) CHECK (Sex IN ('M','F')),
--    Bdate DATE,
--    Relationship VARCHAR(20),

--    PRIMARY KEY (Essn, Dependent_name),

--    FOREIGN KEY (Essn)
--        REFERENCES Employee(Ssn)
--);
--///////////////////////////////////////////
///ALTER TABLE Department
ALTER TABLE Department
ADD CONSTRAINT FK_Department_Manager
FOREIGN KEY (ManagerSSN)
REFERENCES Employee(Ssn)
///////////////////////
//SECTION 2 — SAMPLE DATA (INSERTS)
/* Insert Departments */
INSERT INTO Department
VALUES
(1,'Research',0,NULL,NULL),
(2,'Administration',0,NULL,NULL);
//////////////////////////////
///* Assign Manager to Department */

UPDATE Department
SET ManagerSSN='111111111',
    ManagerStartDate='2023-01-01'
WHERE DeptNumber=1;
///////////////
///* Insert Employees with Supervisor */

INSERT INTO Employee
VALUES
('222222222','Sara','B','Ali',
 'Muscat','F','1992-08-10',
 55000,1,'111111111'),

('333333333','Ahmed','C','Khan',
 'Seeb','M','1995-11-21',
 50000,2,'111111111');

 ////////////////// Insert Remaining Records
 ///* Insert Department Locations */
INSERT INTO Department_Location VALUES (1,'Muscat');
INSERT INTO Department_Location VALUES (1,'Salalah');

/* Insert Projects */
INSERT INTO Project
VALUES
(101,'Payroll System','Muscat',2),
(102,'AI Research Platform','Muscat',1);

/* Insert Works_On Records */
INSERT INTO Works_On
VALUES
('222222222',102,25.5),
('333333333',101,18);

/* Insert Dependents */
INSERT INTO Dependent
VALUES
('222222222','Mariam','F',
 '2018-07-15','Daughter');
 /////////////////
 //update 1
UPDATE Employee
SET Salary = Salary + 5000
WHERE Ssn='222222222';
////////////////////////
//update 2


UPDATE Employee
SET DeptNumber=2
WHERE Ssn='222222222';
//////
//update 3
UPDATE Project
SET ProjectLocation='Salalah'
WHERE ProjectNumber=102;
////
//update 4


UPDATE Works_On
SET Hours=30
WHERE EmployeeSSN='222222222'
AND ProjectNumber=102;

//update 5
UPDATE Dependent
SET Relationship='Child'
WHERE EmployeeSSN='222222222'
AND DependentName='Mariam';
--//
--//Delete 1
DELETE FROM Employee
WHERE Ssn='222222222';
//delete 2
DELETE FROM Department_Location
WHERE DeptNumber=1
AND Location='Salalah';