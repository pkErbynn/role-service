--- DROP RELATION ---
DROP TABLE IF EXISTS Employees;

--- EMPLOYEE RELATION ---
CREATE TABLE Employees(
    EmployeeId serial primary key NOT NULL,
    EmployeeFname varchar(30) NOT NULL,
    EmployeeLname varchar(30) NOT NULL,
    EmployeeEmail varchar(35) NOT NULL,
    EmployeeAddress text NOT NULL,
    EmployeeRole varchar(20) NOT NULL
);

--- EMPLOYEE SEED ---
INSERT INTO Employees(EmployeeFname, EmployeeLname, EmployeeEmail, EmployeeAddress, EmployeeRole) VALUES ('John', 'Erbynn', 'john.erbynn.turntabl.io', 'norway, taifa, accra, ghana', 'Developer');
INSERT INTO Employees(EmployeeFname, EmployeeLname, EmployeeEmail, EmployeeAddress, EmployeeRole) VALUES ('alex', 'owusu', 'alex.owusu@turntabl.io', 'golden door, tantra, accra, ghana', 'Developer');
INSERT INTO Employees(EmployeeFname, EmployeeLname, EmployeeEmail, EmployeeAddress, EmployeeRole) VALUES ('sam', 'moorehouse', 'sam.moorehouse@turntabl.io', 'lancaster, lancashire, uk', 'Admin');