--Scalar functions are built-in functions that return a single value.

/*
UPPER()
LOWER()
SUBSTRING()
LEN()
ROUND()
GETDATE()
FORMAT()
*/

SELECT UPPER('hello world') AS UPPERCASE;
SELECT LOWER('HELLO WORLD') AS LOWERCASE;

--sql server substring starts counting at 1 >.<
SELECT SUBSTRING('hello world', 1, 5);

SELECT LEN('hello world');

SELECT ROUND(12345.6789,2);

SELECT GETDATE();

--https://learn.microsoft.com/en-us/sql/t-sql/functions/format-transact-sql?view=sql-server-ver16
SELECT FORMAT(12345.678, 'C');
SELECT FORMAT(12345.678, 'N4');
SELECT FORMAT(GETDATE(), 'MM/dd/yyyy');
