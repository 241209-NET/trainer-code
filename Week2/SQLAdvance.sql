SELECT * FROM Customer;
SELECT FirstName, Lastname, Phone FROM Customer;

SELECT FirstName + ' ' + Lastname AS FullName, Phone FROM Customer;
SELECT CONCAT(FirstName, ' ', Lastname) FullName, Phone FROM Customer;

-- Aggregates 
-- Count, Avg, Sum

SELECT COUNT(*) TotalNumCustomers FROM Customer;
SELECT COUNT(Company) TotalNumCompany FROM Customer;

SELECT * FROM Invoice;

SELECT SUM(Total) AS Revenue FROM Invoice
SELECT AVG(Total) AS AVGSale FROM Invoice

--Where vs Having
SELECT * 
FROM Customer
WHERE Country = 'Germany';

SELECT Count(*) AS NumOfCust, Country
FROM Customer
GROUP BY Country
HAVING Count(*) > 1

SELECT AVG(Total) as Total, BillingCountry
FROM Invoice
WHERE BillingCountry != 'USA'
GROUP BY BillingCountry
HAVING AVG(Total) > 5.5

--Joins
SELECT * FROM Album;
SELECT * FROM Artist;

SELECT * 
FROM Album
JOIN Artist ON Album.ArtistID = Artist.ArtistID

SELECT Al.Title, Ar.Name
FROM Album Al
JOIN Artist Ar ON Al.ArtistID = Ar.ArtistID