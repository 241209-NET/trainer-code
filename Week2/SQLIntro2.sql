CREATE SCHEMA Project1;
GO

CREATE TABLE Project1.Owners(
    id int PRIMARY KEY IDENTITY,
    name VARCHAR(50) NOT NULL,
    phone VARCHAR(10) UNIQUE,
    address VARCHAR(255) UNIQUE
);

CREATE TABLE Project1.Pets(
    id int PRIMARY KEY IDENTITY,
    name VARCHAR(255) NOT NULL,
    animal_type VARCHAR(255) NOT NULL,
    age int CHECK (age > 0),
    birthday DATE DEFAULT '1990-01-01',
    ownerID int FOREIGN KEY REFERENCES Project1.Owners(id) ON DELETE CASCADE
);

-- INSERT INTO Pets VALUES('Nyla','Cat','Likes to puke');
-- INSERT INTO Pets VALUES('Twinchi','Chinchilla','Likes strawberry treats');
-- INSERT INTO Pets VALUES('Buddy','Beagle','Long walks');
-- INSERT INTO Pets VALUES('Everest','Dog','Chases tail');
-- INSERT INTO Pets VALUES('Rosie','Cat','Likes attention');
-- INSERT INTO Pets VALUES('Chula','Cat','Likes smelly clothes');

SELECT * FROM Project1.Owners;
SELECT * FROM Project1.Pets;

INSERT INTO Project1.Owners (name, phone, address) VALUES ('Kung', '6098675309', '123 My.st USA');
INSERT INTO Project1.Owners (name, phone, address) VALUES ('Justin W', '6098675310', '1234 My.st USA');

INSERT INTO Project1.Pets (name, animal_type, ownerID) VALUES ('Nyla', 'Cat', 1);
INSERT INTO Project1.Pets (name, animal_type, ownerID) VALUES('Twinchi','Chinchilla', 2);

DELETE FROM Project1.Owners
WHERE id = 1;




