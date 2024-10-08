# ECommerceDBD

## Setup instructions

## Manual migrations
### Documentation
For the manual part of the project, each of the sql script files are in its own entity. You would start with the initial_schema to lay a foundation for the other scripts.
Next we would add the category table. The category ID does not exist in the product table, that's why a simple alter was needed to make sure the contraints were met.
The rating table was the last script to be added. Its directly tied to the product table using a foreign key, to make sure we can request each of the products' ratings.

### Rollback
For our rollback strategy we are using a simple strategy:
rollback-initial-schema.sql:
```
DROP TABLE IF EXISTS Products;
```
rollback-add-categories.sql:
```
ALTER TABLE Products DROP CONSTRAINT fk_category;
ALTER TABLE Products DROP COLUMN category_id;
DROP TABLE IF EXISTS Categories;
```
rollback-add-ratings.sql:
```
DROP TABLE IF EXISTS ProductRatings;
```


## EF Core migrations
### Documentation

### Rollback
