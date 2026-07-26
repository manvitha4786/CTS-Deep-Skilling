-- Create Database
CREATE DATABASE OnlineRetailStore;

USE OnlineRetailStore;

-- Create Products Table
CREATE TABLE Products
(
    ProductID INT PRIMARY KEY,
    ProductName VARCHAR(100),
    Category VARCHAR(50),
    Price DECIMAL(10,2)
);

-- Insert Sample Data
INSERT INTO Products
VALUES
(1,'Laptop','Electronics',75000),
(2,'Mobile','Electronics',55000),
(3,'Headphones','Electronics',3500),
(4,'Smart Watch','Electronics',12000),
(5,'Refrigerator','Electronics',45000),

(6,'T-Shirt','Clothing',1200),
(7,'Jeans','Clothing',2200),
(8,'Jacket','Clothing',3500),
(9,'Shoes','Clothing',2800),
(10,'Cap','Clothing',600),

(11,'Rice Bag','Groceries',1200),
(12,'Cooking Oil','Groceries',1800),
(13,'Sugar','Groceries',900),
(14,'Milk','Groceries',60),
(15,'Tea Powder','Groceries',750);

-- Display Products
SELECT * FROM Products;

-- ROW_NUMBER()
SELECT
    ProductID,
    ProductName,
    Category,
    Price,
    ROW_NUMBER() OVER
    (
        PARTITION BY Category
        ORDER BY Price DESC
    ) AS Row_Num
FROM Products;

-- Top 3 Products using ROW_NUMBER()
SELECT *
FROM
(
    SELECT
        ProductID,
        ProductName,
        Category,
        Price,
        ROW_NUMBER() OVER
        (
            PARTITION BY Category
            ORDER BY Price DESC
        ) AS Row_Num
    FROM Products
) AS RankedProducts
WHERE Row_Num <= 3;

-- RANK()
SELECT
    ProductID,
    ProductName,
    Category,
    Price,
    RANK() OVER
    (
        PARTITION BY Category
        ORDER BY Price DESC
    ) AS Product_Rank
FROM Products;

-- Top 3 Products using RANK()
SELECT *
FROM
(
    SELECT
        ProductID,
        ProductName,
        Category,
        Price,
        RANK() OVER
        (
            PARTITION BY Category
            ORDER BY Price DESC
        ) AS Product_Rank
    FROM Products
) AS RankedProducts
WHERE Product_Rank <= 3;

-- DENSE_RANK()
SELECT
    ProductID,
    ProductName,
    Category,
    Price,
    DENSE_RANK() OVER
    (
        PARTITION BY Category
        ORDER BY Price DESC
    ) AS Dense_Rank
FROM Products;

-- Top 3 Products using DENSE_RANK()
SELECT *
FROM
(
    SELECT
        ProductID,
        ProductName,
        Category,
        Price,
        DENSE_RANK() OVER
        (
            PARTITION BY Category
            ORDER BY Price DESC
        ) AS Dense_Rank
    FROM Products
) AS RankedProducts
WHERE Dense_Rank <= 3;