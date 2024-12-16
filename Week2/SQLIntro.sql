CREATE DATABASE PetTracker;

USE PetTracker;

CREATE TABLE Pets(
    name VARCHAR(50),
    type VARCHAR(50),
    descriptions VARCHAR(255)
);

SELECT * FROM Pets;

INSERT INTO Pets VALUES('Nyla','Cat','Likes to puke');
INSERT INTO Pets VALUES('Twinchi','Chinchilla','Likes strawberry treats');
INSERT INTO Pets VALUES('Buddy','Beagle','Long walks');
INSERT INTO Pets VALUES('Everest','Dog','Chases tail');
INSERT INTO Pets VALUES('Rosie','Cat','Likes attention');
INSERT INTO Pets VALUES('Chula','Cat','Likes smelly clothes');
INSERT INTO Pets VALUES('','','');

SELECT * FROM Pets
WHERE type = 'Chinchilla';

CREATE TABLE Pets2(
    petID INT PRIMARY KEY IDENTITY,
    name VARCHAR(50),
    type VARCHAR(50),
    descriptions VARCHAR(255)
);

INSERT INTO Pets2 VALUES('Nyla','Cat','Likes to puke');
INSERT INTO Pets2 VALUES(29, 'Nyla','Cat','Likes to puke');
Select * from Pets2;