-- Create Database
CREATE DATABASE EmployeeManagementSystem;

USE EmployeeManagementSystem;

-- Create Departments Table
CREATE TABLE Departments
(
    DepartmentID INT PRIMARY KEY,
    DepartmentName VARCHAR(100)
);

-- Create Employees Table
CREATE TABLE Employees
(
    EmployeeID INT AUTO_INCREMENT PRIMARY KEY,
    FirstName VARCHAR(50),
    LastName VARCHAR(50),
    DepartmentID INT,
    Salary DECIMAL(10,2),
    JoinDate DATE,
    FOREIGN KEY (DepartmentID) REFERENCES Departments(DepartmentID)
);

-- Insert Sample Data into Departments
INSERT INTO Departments
VALUES
(1,'HR'),
(2,'Finance'),
(3,'IT'),
(4,'Marketing');

-- Insert Sample Data into Employees
INSERT INTO Employees
(EmployeeID, FirstName, LastName, DepartmentID, Salary, JoinDate)
VALUES
(1,'John','Doe',1,5000.00,'2020-01-15'),
(2,'Jane','Smith',2,6000.00,'2019-03-22'),
(3,'Michael','Johnson',3,7000.00,'2018-07-30'),
(4,'Emily','Davis',4,5500.00,'2021-11-05');

-- Create Stored Procedure to Get Employees by Department
DELIMITER $$

CREATE PROCEDURE sp_GetEmployeesByDepartment(IN deptId INT)
BEGIN
    SELECT *
    FROM Employees
    WHERE DepartmentID = deptId;
END $$

DELIMITER ;

-- Execute Stored Procedure
CALL sp_GetEmployeesByDepartment(1);

-- Create Stored Procedure to Insert Employee
DELIMITER $$

CREATE PROCEDURE sp_InsertEmployee
(
    IN p_FirstName VARCHAR(50),
    IN p_LastName VARCHAR(50),
    IN p_DepartmentID INT,
    IN p_Salary DECIMAL(10,2),
    IN p_JoinDate DATE
)
BEGIN
    INSERT INTO Employees
    (
        FirstName,
        LastName,
        DepartmentID,
        Salary,
        JoinDate
    )
    VALUES
    (
        p_FirstName,
        p_LastName,
        p_DepartmentID,
        p_Salary,
        p_JoinDate
    );
END $$

DELIMITER ;

-- Execute Insert Procedure
CALL sp_InsertEmployee
(
    'David',
    'Wilson',
    3,
    6500.00,
    '2024-01-10'
);

-- Display Employees Table
SELECT * FROM Employees;