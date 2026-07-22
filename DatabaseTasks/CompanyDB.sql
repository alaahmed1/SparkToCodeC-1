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


