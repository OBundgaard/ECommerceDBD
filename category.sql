-- Create Categories table
CREATE TABLE Categories (
    Id INT PRIMARY KEY,
    Name VARCHAR(255) NOT NULL
);

-- Modify Products table to include category_id
ALTER TABLE Products
ADD category_id INT;

-- Add foreign key constraint between Products and Categories
ALTER TABLE Products
ADD CONSTRAINT fk_category
FOREIGN KEY (category_id) REFERENCES Categories(Id);
