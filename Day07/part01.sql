--Part 01 
--Q1
use ITI
CREATE PROC GetStudentCountPerDepartment
AS
BEGIN
    SELECT 
        d.Dept_Name AS DepartmentName,
        COUNT(s.St_Id) AS StudentCount
    FROM 
        Department d
        LEFT JOIN Student s ON d.Dept_Id = s.Dept_Id
    GROUP BY 
        d.Dept_Name
    ORDER BY 
        StudentCount DESC;
END;

execute GetStudentCountPerDepartment

--------------------------------------------------------
--Q2
use MyCompany

CREATE PROCEDURE CheckEmployeesInProject1
AS
BEGIN
    DECLARE @EmployeeCount INT;

    SELECT @EmployeeCount = COUNT(DISTINCT E.SSN)
    FROM Employee E
    JOIN Works_for W ON E.SSN = W.ESSN
    JOIN Project P ON W.Pno = P.Pnumber
    WHERE P.Pname = 'AL Solimaniah';

    IF @EmployeeCount >= 3
    BEGIN
        PRINT 'The number of employees in the project p1 is 3 or more';
    END
    ELSE
    BEGIN
        PRINT 'The following employees work for the project p1:';

        SELECT E.Fname, E.Lname
        FROM Employee E
        JOIN Works_for W ON E.SSN = W.ESSN
        JOIN Project P ON W.Pno = P.Pnumber
        WHERE P.Pname = 'AL Solimaniah';
    END
END;

exec CheckEmployeesInProject1


--------------------------------------------
--Q3
use MyCompany

CREATE PROCEDURE ReplaceEmployee
    @OldEmpSSN CHAR(6),
    @NewEmpSSN CHAR(6),
    @ProjectNo INT
AS
BEGIN
    DECLARE @OldEmpHours FLOAT;

    SELECT @OldEmpHours = Hours
    FROM Works_for
    WHERE ESSN = @OldEmpSSN AND Pno = @ProjectNo;

    IF @OldEmpHours IS NULL
    BEGIN
        PRINT 'The old employee is not assigned to this project.';
        RETURN;
    END

    DELETE FROM Works_for
    WHERE ESSN = @OldEmpSSN AND Pno = @ProjectNo;

    INSERT INTO Works_for (ESSN, Pno, Hours)
    VALUES (@NewEmpSSN, @ProjectNo, @OldEmpHours);

    PRINT 'Employee replacement completed successfully.';
END;

EXEC ReplaceEmployee '223344', '512463', 500;

