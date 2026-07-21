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