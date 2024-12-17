CREATE TABLE Departments(
    id INT PRIMARY KEY IDENTITY,
    name VARCHAR(50)    
);

CREATE TABLE Employees(
    id INT PRIMARY KEY IDENTITY,
    name VARCHAR(50),
    departmentId INT FOREIGN KEY REFERENCES Departments(id),
    managerId INT FOREIGN KEY REFERENCES Employees(id)
);

CREATE TABLE Projects(
    id INT PRIMARY KEY IDENTITY,
    name VARCHAR(50),
    employeeId INT FOREIGN KEY REFERENCES Employees(id)
);

INSERT INTO Departments VALUES
('HR'),
('IT'),
('Sales'),
('Marketing');

INSERT INTO Departments VALUES
(NULL);

INSERT INTO Employees VALUES
('Kung', 1, NULL),
('Bob', 2, 1),
('Sara', NULL, 2),
('Dylan', 3, 1),
('Hannah', 4, NULL),
('Gina', 4, NULL);

INSERT INTO Projects VALUES
('Soft Dev', 2),
('Market Audience', 5),
('Void Project', NULL),
('Selling', 4);

SELECT * FROM Departments;
SELECT * FROM Employees;
SELECT * FROM Projects;

--Joins

--Join SQL SERVER by default JOIN = INNER JOIN

SELECT *
FROM Employees AS e
JOIN Departments AS d ON e.departmentId = d.id;

SELECT *
FROM Employees AS e
INNER JOIN Departments AS d ON e.departmentId = d.id;

--LEFT JOIN

SELECT *
FROM Employees AS e
LEFT JOIN Departments AS d ON e.departmentId = d.id;

--RIGHT JOIN

SELECT *
FROM Employees AS e
RIGHT JOIN Departments AS d ON e.departmentId = d.id;

--FULL OUTER JOIN

SELECT *
FROM Employees AS e
FULL OUTER JOIN Departments AS d ON e.departmentId = d.id;

--SELF JOIN, useful for hierarchical analysis
 SELECT * FROM Employees;

 SELECT e1.name AS EMP_NAME, e2.name AS MAN_NAME
 FROM Employees AS e1
 JOIN Employees AS e2 ON e1.managerId = e2.id;

-- Shows even employees without a manager
 SELECT e1.name AS EMP_NAME, e2.name AS MAN_NAME
 FROM Employees AS e1
 LEFT JOIN Employees AS e2 ON e1.managerId = e2.id;

--CROSS JOIN, Cartesian Product, for everyone match to everything else
 SELECT * 
 FROM Employees
 CROSS JOIN Departments;