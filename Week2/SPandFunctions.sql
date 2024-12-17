--Stored Procedures and User Define Functions

--Stored Procedures

-- It is a prepared SQL code that you can save, reuse, and share among applications.
-- Can accept parameters, return values, and be used to encapsulate and execute complex SQL logic.

--Without SP
SELECT TOP(1) o.name Owner, p.name Pet, p.birthday
FROM Owners o
JOIN Pets p ON o.id = p.ownerID;
--Go to make batch statements
GO

--Once run it is stored in the DB and can be called back
CREATE PROCEDURE GetOwnersAndPets
    @TopNum INT
AS
BEGIN
    SELECT TOP(@TopNum) o.name Owner, p.name Pet, p.birthday
    FROM Owners o
    JOIN Pets p ON o.id = p.ownerID;
END;
--Go to make batch statements
GO

--Excute above procedure
EXEC GetOwnersAndPets @TopNum = 3;


--User Define Functions
-- Reusable SQL code blocks that accept parameters, perform calculations, and return a single value or a table of values.

--Go to make batch statements
GO

--Once run it is stored in the DB and can be called back
CREATE FUNCTION CalculateTax
(
    @Amount DECIMAL(10,2),
    @Tax DECIMAL(10,2)
)
RETURNS DECIMAL(10,2)
AS
BEGIN
    DECLARE @Total DECIMAL(10,2);
    SET @Total = @Amount + (@Amount * @Tax);
    RETURN @Total;
END

--Go to make batch statements
GO

--Calling back the function defined above
SELECT dbo.CalculateTax(100, .03) TotalAmount;

-- Function vs Procedure
-- Main differecne is how they return values, their usage in SQL queries.

-- Procedures

-- No Return Value Requirement: Procedures may or may not return values. If they do, it’s through OUT or INOUT parameters rather than a direct RETURN statement.
-- CALL Statement: Procedures are called using the EXEC statement rather than being embedded directly within SQL queries.
-- Functions

-- Return Value: Functions are designed to compute and return a single value using the RETURN statement. They encapsulate logic to calculate or derive values based on input parameters.

-- Within SQL Queries: Functions can be used within SQL queries wherever an expression is valid. They can be part of SELECT, WHERE, ORDER BY, and other clauses.

-- Data Transformation: Use functions for calculations, formatting data (like dates, currencies), and reusable computations.

-- Use Procedures When:

-- Performing complex data manipulations, transactions, or actions that do not require returning a value directly to the caller.
-- Needing to execute multiple SQL statements or procedural logic as a single unit.
-- Managing tasks such as data updates, inserts, deletes, or other administrative actions.

-- Use Functions When:

-- Needing to compute and return a value for use within SQL queries or applications.
-- Requiring reusable calculations or transformations (e.g., formatting dates, calculating totals).
-- Avoiding repetition of logic by encapsulating it into a single callable unit.