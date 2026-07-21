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