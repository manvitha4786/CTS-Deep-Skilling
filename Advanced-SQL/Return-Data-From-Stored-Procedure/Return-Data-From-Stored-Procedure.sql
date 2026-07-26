-- Use Database
USE EmployeeManagementSystem;

-- Create Stored Procedure
DELIMITER $$

CREATE PROCEDURE sp_GetEmployeeCountByDepartment(IN deptId INT)
BEGIN
    SELECT
        COUNT(*) AS TotalEmployees
    FROM Employees
    WHERE DepartmentID = deptId;
END $$

DELIMITER ;

-- Execute Stored Procedure
CALL sp_GetEmployeeCountByDepartment(1);

CALL sp_GetEmployeeCountByDepartment(2);

CALL sp_GetEmployeeCountByDepartment(3);

CALL sp_GetEmployeeCountByDepartment(4);