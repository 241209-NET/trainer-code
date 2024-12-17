--Triggers
--They are SP that executes automatically upon certain conditions

CREATE TRIGGER NewDeptAfterNewEmp
ON Employees
AFTER INSERT
AS
BEGIN
    INSERT INTO Departments VALUES ('NewDept');
END

SELECT * FROM Departments;
INSERT INTO Employees VALUES ('Hank', NULL, NULL);
SELECT * FROM Departments;

--Sequence, an object that generates a sequence

CREATE SEQUENCE MySEQ
START WITH 2
INCREMENT BY 3;

SELECT NEXT VALUE FOR MySEQ;

CREATE SEQUENCE MySEQ2
START WITH 2
MAXVALUE 100
INCREMENT BY 3;

SELECT NEXT VALUE FOR MySEQ2;

CREATE SEQUENCE MySEQ3
START WITH 2
MAXVALUE 100
CYCLE
INCREMENT BY 3;

SELECT NEXT VALUE FOR MySEQ3;

CREATE SEQUENCE MySEQ4
START WITH 2
MINVALUE 2
MAXVALUE 100
CYCLE
INCREMENT BY 3;

SELECT NEXT VALUE FOR MySEQ4;

--Views, virtual tables that represent a result set from a select query. They don't store data instead they derive their data.

GO
--Create a new view
CREATE VIEW CrossJoin
AS
SELECT e.name EMP, d.name DEPT
FROM Employees e
CROSS JOIN Departments d

GO
--Select from view
SELECT * FROM CrossJoin;

SELECT COUNT(EMP) Amount 
FROM CrossJoin
WHERE EMP = 'Kung';

--Index
-- Structure associated with a table or view that speeds up the retrieval of rows from the table or view, based on the values in one or more columns.

-- - Clustered Index: Defines the physical order of data rows in a table. Each table can have only one clustered index because it physically reorders the table rows. It is particularly effective for range queries and sorting.

-- - Non-Clustered Index: A separate structure from the data rows, containing pointers to the rows. Each table can have multiple non-clustered indexes. It is useful for improving the performance of frequently used queries that do not return large result sets.

-- Indexes are used automatically by the SQL Server query optimizer to enhance query performance. 

-- You do not need to explicitly use indexes in your queries

--If you want to optimize filtering and sorting on a specific column in a specific table.
CREATE NONCLUSTERED INDEX MyNCIndex
ON Employees(name);