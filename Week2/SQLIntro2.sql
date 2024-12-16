CREATE TABLE Owners(
    id int PRIMARY KEY IDENTITY,
    name VARCHAR(50) NOT NULL,
    phone VARCHAR(10) UNIQUE,
    address VARCHAR(255) UNIQUE
);

CREATE TABLE Pets(
    id int PRIMARY KEY IDENTITY,
    name VARCHAR(255) NOT NULL,
    animal_type VARCHAR(255) NOT NULL,
    age int CHECK (age > 0),
    birthday DATE DEFAULT '1990-01-01',
    ownerID int FOREIGN KEY REFERENCES Owners(id) ON DELETE CASCADE
);

-- INSERT INTO Pets VALUES('Nyla','Cat','Likes to puke');
-- INSERT INTO Pets VALUES('Twinchi','Chinchilla','Likes strawberry treats');
-- INSERT INTO Pets VALUES('Buddy','Beagle','Long walks');
-- INSERT INTO Pets VALUES('Everest','Dog','Chases tail');
-- INSERT INTO Pets VALUES('Rosie','Cat','Likes attention');
-- INSERT INTO Pets VALUES('Chula','Cat','Likes smelly clothes');

SELECT * FROM Owners;
SELECT * FROM Pets;

INSERT INTO Owners (name, phone, address) VALUES ('Kung', '6098675309', '123 My.st USA');
INSERT INTO Owners (name, phone, address) VALUES ('Justin W', '6098675310', '1234 My.st USA');
INSERT INTO Owners (name, phone, address) VALUES ('Sara', '6098675311', '12 My.st USA');

INSERT INTO Pets (name, animal_type, ownerID) VALUES ('Nyla', 'Cat', 3);
INSERT INTO Pets (name, animal_type, ownerID) VALUES('Twinchi','Chinchilla', 2);

INSERT INTO Pets (name, animal_type, ownerID, age) VALUES ('Nyla', 'Cat', 3, 12);

DELETE FROM Owners
WHERE id = 1;

/*
SELECT <column names>
FROM <table name>
WHERE id > 2
ORDER BY 
*/

SELECT name
FROM Owners
WHERE id >= 3
ORDER BY name ASC --DESC




