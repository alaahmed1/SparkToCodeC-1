-- creating a database
--dropping the DB if already exists cuz i have don it in another file

DROP database IF exists CompanyDB;
GO

CREATE database CompanyDB;
GO

USE CompanyDB;
GO


--TABLE EMPLOYEE
CREATE TABLE Employee (
    Ssn        CHAR(9)        NOT NULL,
    Fname      VARCHAR(30)    NOT NULL,
    Minit      CHAR(1)        NULL,
    Lname      VARCHAR(30)    NOT NULL,
    Bdate      DATE           NULL,
    Address    VARCHAR(100)   NULL,
    Sex        CHAR(1)        NULL,
    Salary     DECIMAL(10,2)  NOT NULL DEFAULT 0,
    Super_ssn  CHAR(9)        NULL, --based on PK for the supervisor employee
    CONSTRAINT PK_Employee PRIMARY KEY (Ssn),
    CONSTRAINT CK_Employee_Sex CHECK (Sex IN ('M','F')),
    CONSTRAINT CK_Employee_Salary CHECK (Salary > 0),
    CONSTRAINT FK_Employee_Super
        FOREIGN KEY (Super_ssn) REFERENCES Employee(Ssn)
        ON DELETE SET NULL
        -- if a supervisor is deleted, subordinates just lose that link
);
GO


CREATE TABLE Department (
    Dnumber           INT           NOT NULL,
    Dname             VARCHAR(50)   NOT NULL,
    NumberOfEmployees INT           NOT NULL DEFAULT 0,
    Mgr_ssn           CHAR(9)       NULL,          -- which employee manages this department
    Mgr_start_date    DATE          NULL,
 
    CONSTRAINT PK_Department PRIMARY KEY (Dnumber),
    CONSTRAINT UQ_Department_Dname UNIQUE (Dname),
    CONSTRAINT CK_Department_NumEmp CHECK (NumberOfEmployees >= 0),
 
    CONSTRAINT FK_Department_Manager
        FOREIGN KEY (Mgr_ssn) REFERENCES Employee(Ssn)
);
GO

--Now that Department exists, give Employee its department link.
-- NOT NULL because every employee must belong to some department.
ALTER TABLE Employee
    ADD Dno INT NOT NULL
        CONSTRAINT FK_Employee_Dept FOREIGN KEY REFERENCES Department(Dnumber);
GO


CREATE TABLE Dept_Locations (
    Dnumber    INT           NOT NULL,
    Dlocation  VARCHAR(50)   NOT NULL,
 
    CONSTRAINT PK_Dept_Locations PRIMARY KEY (Dnumber, Dlocation),
    CONSTRAINT FK_DeptLoc_Dept
        FOREIGN KEY (Dnumber) REFERENCES Department(Dnumber)
        ON DELETE CASCADE   -- if the department is deleted, its locations go with it
);
GO



CREATE TABLE Project (
    Pnumber    INT           NOT NULL,
    Pname      VARCHAR(50)   NOT NULL,
    Plocation  VARCHAR(50)   NULL,
    Dnum       INT           NOT NULL,    -- which department controls this project
 
    CONSTRAINT PK_Project PRIMARY KEY (Pnumber),
    CONSTRAINT UQ_Project_Pname UNIQUE (Pname),
    CONSTRAINT FK_Project_Dept
        FOREIGN KEY (Dnum) REFERENCES Department(Dnumber)
);
GO


-- One employee can work on many projects, and one project can
-- have many employees, so this table connects the two.
CREATE TABLE Works_On (
    Essn   CHAR(9)        NOT NULL,   -- employee
    Pno    INT            NOT NULL,   -- project
    Hours  DECIMAL(4,1)   NOT NULL DEFAULT 0,
 
    CONSTRAINT PK_Works_On PRIMARY KEY (Essn, Pno),
    CONSTRAINT CK_Works_On_Hours CHECK (Hours > 0),
 
    CONSTRAINT FK_WorksOn_Employee
        FOREIGN KEY (Essn) REFERENCES Employee(Ssn)
        ON DELETE CASCADE,   -- if the employee is deleted, their work records go too
    CONSTRAINT FK_WorksOn_Project
        FOREIGN KEY (Pno) REFERENCES Project(Pnumber)
        ON DELETE CASCADE    -- if the project is deleted, its work records go too
);
GO


REATE TABLE Dependent (
    Essn             CHAR(9)       NOT NULL,
    Dependent_name   VARCHAR(30)   NOT NULL,
    Sex              CHAR(1)       NULL,
    Bdate            DATE          NULL,
    Relationship     VARCHAR(20)   NULL,
 
    CONSTRAINT PK_Dependent PRIMARY KEY (Essn, Dependent_name),
    CONSTRAINT CK_Dependent_Sex CHECK (Sex IN ('M','F')),
 
    CONSTRAINT FK_Dependent_Employee
        FOREIGN KEY (Essn) REFERENCES Employee(Ssn)
        ON DELETE CASCADE   -- if the employee is deleted, their dependents go too
);
GO


--inserting sample data
INSERT INTO Department (Dnumber, Dname, NumberOfEmployees, Mgr_ssn, Mgr_start_date)
VALUES
    (1, 'Research',      0, NULL, NULL),
    (2, 'Administration',0, NULL, NULL),
    (3, 'Headquarters',  0, NULL, NULL);
GO


INSERT INTO Employee (Ssn, Fname, Minit, Lname, Bdate, Address, Sex, Salary, Super_ssn, Dno)
VALUES
    ('111111111','James','B','Borg',   '1955-11-10','911 Pine, Boston, MA','M', 55000, NULL,        3),
    ('222222222','Franklin','T','Wong','1965-01-09','638 Voss, Boston, MA','M', 40000, '111111111', 1),
    ('333333333','Alicia','J','Zelaya','1978-06-20','3321 Castle, Boston, MA','F', 25000, '222222222',2),
    ('444444444','Jennifer','S','Wallace','1971-03-31','291 Berry, Boston, MA','F', 43000, '111111111',2),
    ('555555555','Ramesh','K','Narayan','1972-09-15','975 Fire Oak, Boston, MA','M', 38000, '222222222',1);
GO
 

-- Now that employees exist, assign each department a manager.
UPDATE Department SET Mgr_ssn = '111111111', Mgr_start_date = '2016-05-01' WHERE Dnumber = 3;
UPDATE Department SET Mgr_ssn = '222222222', Mgr_start_date = '2018-05-22' WHERE Dnumber = 1;
UPDATE Department SET Mgr_ssn = '333333333', Mgr_start_date = '2019-01-01' WHERE Dnumber = 2;
GO

-- Department locations
INSERT INTO Dept_Locations (Dnumber, Dlocation)
VALUES
    (1, 'Boston'),
    (1, 'Cambridge'),
    (2, 'Boston'),
    (3, 'Boston');
GO

-- Projects
INSERT INTO Project (Pnumber, Pname, Plocation, Dnum)
VALUES
    (10, 'ProductX',    'Boston',    1),
    (20, 'ProductY',    'Cambridge', 1),
    (30, 'Newbenefits', 'Boston',    2);
GO


-- Works_On: who is working on which project, and for how many hours
INSERT INTO Works_On (Essn, Pno, Hours)
VALUES
    ('222222222', 10, 20.0),
    ('222222222', 20, 15.0),
    ('555555555', 10, 30.0),
    ('444444444', 30, 40.0);
GO

-- Dependents
INSERT INTO Dependent (Essn, Dependent_name, Sex, Bdate, Relationship)
VALUES
    ('222222222','Anna',  'F','1990-04-05','Daughter'),
    ('222222222','Marco', 'M','1988-12-08','Son'),
    ('444444444','Alice', 'F','2005-02-14','Daughter');
GO


--UPDATE EXAMPLES
-- give an employee a raise
UPDATE Employee
SET Salary = Salary + 3000
WHERE Ssn = '555555555';
GO
 
-- move an employee to a new department
UPDATE Employee
SET Dno = 3
WHERE Ssn = '444444444';
GO
 
-- change a project's location
UPDATE Project
SET Plocation = 'Somerville'
WHERE Pnumber = 20;
GO
 
-- update hours worked
UPDATE Works_On
SET Hours = 35.0
WHERE Essn = '222222222' AND Pno = 10;
GO

UPDATE Dependent
SET Relationship = 'Son'
WHERE Essn = '222222222' AND Dependent_name = 'Marco';
GO


--DELETE EXAMPLES
-- deleting an employee
DELETE FROM Employee
WHERE Ssn = '222222222';
GO


--to check results
SELECT * FROM Department;
SELECT * FROM Employee;
SELECT * FROM Dept_Locations;
SELECT * FROM Project;
SELECT * FROM Works_On;
SELECT * FROM Dependent;
GO