# ECommerceDBD
Manual branch: `main-manual`

EF branch: `main-ef`

## Setup instructions
For either part you still need to have a database regardless.

For the EF part you'd have to update the connection string in the project also, but other than that, it should be good to go for dealing with migrations.

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
For the migrations I first ran `Add-Migration addCategories` when adding the categories to my project. Then after adding the product ratings, I added `Add-Migration addRatings`

As provided in the `main-ef` branch on the path `ECommerceAPI/Migrations` the files are provided for the migrations.

### Rollback
To do a rollback, first call `Get-Migration` to get a list of the different migrations, then `Update-Database <previous-migration-name>` to rollback
