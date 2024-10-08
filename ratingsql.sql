CREATE TABLE ProductRatings (
    Id INT PRIMARY KEY,
    ProductId INT,
    Rating INT CHECK (Rating >= 1 AND Rating <= 5),  -- Rating from 1 to 5
    Review VARCHAR(1000),
    FOREIGN KEY (ProductId) REFERENCES Products(Id)
);