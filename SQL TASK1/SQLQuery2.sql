--// Database creation script 
--CREATE DATABASE CompanyDB; 
--GO; 
--USE CompanyDB;
--//////////////////////////////////////////
///Department
CREATE TABLE Department
(
Dnumber INT PRIMARY KEY,
Dname VARCHAR(60) NOT NULL UNIQUE,
Mgr_ssn CHAR(9),
Mgr_start_date DATE,
NumberOfEmployees INT DEFAULT 0 CHECK (NumberOfEmployees >= 0)
);
//////////////
////Employee
CREATE TABLE Employee
(
    Ssn CHAR(9) PRIMARY KEY,
    Fname VARCHAR(30) NOT NULL,
    Minit CHAR(1),
    Lname VARCHAR(30) NOT NULL,
    Address VARCHAR(100),
    Sex CHAR(1) NOT NULL CHECK (Sex IN ('M','F')),
    Bdate DATE,
    Salary DECIMAL(10,2) NOT NULL CHECK (Salary > 0),
    Dno INT NOT NULL,
    Super_ssn CHAR(9)
);
//////////////////////////////////
//Dept_Locations
CREATE TABLE Dept_Locations
(
Dnumber  INT NOT NULL,
Dlocation VARCHAR(40) NOT NULL,
PRIMARY KEY (Dnumber, Dlocation),

    FOREIGN KEY (Dnumber)
        REFERENCES Department(Dnumber)
);
///////////////////////////////
//Project
CREATE TABLE Project
(
    Pnumber INT PRIMARY KEY,
    Pname VARCHAR(50) NOT NULL UNIQUE,
    Plocation VARCHAR(50),
    Dnum INT NOT NULL,
    FOREIGN KEY (Dnum)
        REFERENCES Department(Dnumber)
);
/////////////////////////////////////////
///Works_On
CREATE TABLE Works_On
(
    Essn CHAR(9),
    Pno INT,
    Hours DECIMAL(4,1) CHECK (Hours >= 0),
    PRIMARY KEY (Essn, Pno),
    FOREIGN KEY (Essn)
        REFERENCES Employee(Ssn),
    FOREIGN KEY (Pno)
        REFERENCES Project(Pnumber)
);
/////////////////////////////////
//Dependent
CREATE TABLE Dependent
(
    Essn CHAR(9),
    Dependent_name VARCHAR(30),
    Sex CHAR(1) CHECK (Sex IN ('M','F')),
    Bdate DATE,
    Relationship VARCHAR(20),

    PRIMARY KEY (Essn, Dependent_name),

    FOREIGN KEY (Essn)
        REFERENCES Employee(Ssn)
);