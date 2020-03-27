 
--- DROP RELATION ---

DROP TABLE IF EXISTS Roles;

--- ROLES RELATION ---

CREATE TABLE Roles(
    Id serial primary key NOT NULL,
    Name varchar(30),
    Description varchar(60)
);

INSERT INTO Roles(Name, Description) VALUES ('Developer', 'Software Developer');
INSERT INTO Roles(Name, Description) VALUES ('Admin', 'Administrator');

---------------------------------------------------------------------------------------
---------------------------------------------------------------------------------------

--- DROP TABLE ---
DROP TABLE IF EXISTS roles cascade;
DROP TABLE IF EXISTS employees cascade;


--- ROLES TABLE ---
create table roles(
  role_id serial primary key NOT NULL,
  role_name varchar(30) NOT NULL,
  role_description varchar(60)
);

--- ROLES SEED ---
INSERT INTO roles(role_id, role_name, role_description) VALUES (1, 'Admin', 'Administrator');
INSERT INTO roles(role_id, role_name, role_description) VALUES (2, 'Developer', 'Software Developer');


--- EMPLOYEES TABLE ---
create table employees(
  employee_id serial primary key NOT NULL,
  employee_fname varchar(30) NOT NULL,
  employee_lname varchar(20) NOT NULL,
  employee_email varchar(20) NOT NULL,
  employee_address varchar(40) NOT NULL,
  role_id integer references roles(role_id) NOT NULL default 2
);

--- EMPLOYEES SEED ---
INSERT INTO employees(employee_fname, employee_lname, employee_email, employee_address) VALUES ('john', 'erbynn', 'john.erbynn@turntabl.io', 'norway, taifa, accra, ghana');
INSERT INTO employees(employee_fname, employee_lname, employee_email, employee_address) VALUES ('alex', 'owusu', 'alex.owusu@turntabl.io', 'golden door, tantra, accra, ghana');