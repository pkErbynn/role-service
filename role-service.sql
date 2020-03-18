 
--- DATABASE FOR HOLIDAY ME ---

DROP TABLE IF EXISTS Roles;

--- REQUEST STATUS ---

CREATE TABLE Roles(
    Id serial primary key NOT NULL,
    Name varchar(30),
    Description varchar(60)
);

INSERT INTO Roles(Name, Description) VALUES ('Developer', 'Software Developer');
INSERT INTO Roles(Name, Description) VALUES ('Admin', 'Administrator');
