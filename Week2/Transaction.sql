-- Transaction
-- Transaction is a collection of SQL statements that either succeed or fail together/as a unit
-- You manage transactions with TCL sublaguage: transaction control language
-- TCL ex: Commit, Savepoint, Rollback

-- Properties of Transaction (ACID)
-- Atomicity : all statements in a transaction either succeeds or fails as a whole
-- Consistency : When a transaction commits, it should follow the rules in the db tables
-- Isolation : Transaction should be isolated and free from other sql operations
-- Durability : When the transaction commits, it's saved to a persistent/durable storage

-- Isolation Levels
-- Read Uncommitted : allows all 3 phenomena
-- Read Committed : does not allow dirty read
-- Repeatable Read : does not allow dirty and non-repeatable read
-- Serializable : does not allow all 3 phenomena

-- Read phenomena
-- Dirty Read: your transaction is reading changes made by other transactions that hasn't been commited (it has chances of rolling back)
-- NonRepeatable Read: your transaction is reading committed changes made by other transactions
-- Phantom Read: your transaction is seeing newly created records or not seeing certain records because it got delete by other transactions

-- Microsoft Learn on Transaction: https://learn.microsoft.com/en-us/sql/t-sql/language-elements/transactions-transact-sql?view=sql-server-ver16
-- Microsoft Ref on Isolation Levels: https://learn.microsoft.com/en-us/sql/odbc/reference/develop-app/transaction-isolation-levels?view=sql-server-ver16


--Setup bank accounts and two accounts for Kung and Nyla
CREATE TABLE BankAccount(
    id int PRIMARY KEY IDENTITY,
    name VARCHAR(50),
    balance DECIMAL(10,2) CHECK (balance >= 0)
);

INSERT INTO BankAccount VALUES
('Kung', 500),
('Nyla', 500);

SELECT * FROM BankAccount;
SELECT SUM(balance) Total FROM BankAccount;

--Transfer money from Kung -> Nyla without using transactions
UPDATE BankAccount
SET balance -= 100
WHERE name = 'Kung';

--Simulate a problem
--WAITFOR DELAY '00:00:05';

UPDATE BankAccount
SET balance += 100
WHERE name = 'Nyla';

--Wrap the transfer in transaction to prevent inconsistent state
BEGIN TRANSACTION
BEGIN TRY
    UPDATE BankAccount
    SET balance -= 100
    WHERE name = 'Kung';

    --Simulate a problem
    --PRINT 'Waiting for no reason!';
    --WAITFOR DELAY '00:00:05';
    --SELECT 10/0;

    UPDATE BankAccount
    SET balance += 100
    WHERE name = 'Nyla';
    COMMIT;
END TRY
BEGIN CATCH
    PRINT 'Rolling Back...';
    SELECT ERROR_MESSAGE();
    ROLLBACK;
END CATCH