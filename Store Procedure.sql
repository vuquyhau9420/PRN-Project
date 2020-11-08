CREATE PROCEDURE spCheckLogin(@STAFF_USERNAME VARCHAR(100), @STAFF_PASSWORD VARCHAR(30))
AS
	BEGIN
		SELECT staff_id, staff_username, staff_password, staff_fullname, staff_citizen_identification, staff_sex, staff_phone, staff_address, staff_birthday, staff_role, staff_status
        FROM staff 
        WHERE staff_username = @STAFF_USERNAME 
              AND staff_password = @STAFF_PASSWORD AND staff_status = 1
	END
GO

DROP PROC spCheckLogin

EXEC spCheckLogin @STAFF_USERNAME = 'hieulm', @STAFF_PASSWORD = '123456'



/* Category */

CREATE PROCEDURE spGetAllCategories
AS
	BEGIN
		SELECT category_id, category_name, category_status
        FROM category 
	END
GO

DROP PROC spGetAllCategories

EXEC spGetAllCategories

CREATE PROCEDURE spGetCategoriesActive
AS
	BEGIN
		SELECT category_id, category_name, category_status
        FROM category 
		WHERE category_status = 1
	END
GO

DROP PROC spGetCategoriesActive

EXEC spGetCategoriesActive

/* Product Group */

CREATE PROCEDURE spGetProductGroupActive(@CATEGORY_ID int)
AS
	BEGIN
		SELECT product_group_id, product_group_name, supplier_name, category_name, product_group_stocking, product_group_status
        FROM product_group, category, supplier 
        WHERE product_group_status = 1 AND product_group_catgory = @CATEGORY_ID AND category.category_id = product_group.product_group_catgory
				AND supplier.supplier_id = product_group.supplier_id
	END
GO

drop proc spGetProductGroupActive

EXEC spGetProductGroupActive @CATEGORY_ID = 1

CREATE PROCEDURE spGetAllProductGroup(@CATEGORY_ID int)
AS
	BEGIN
		SELECT product_group_id, product_group_name, supplier_name, category_name, product_group_stocking, product_group_status
        FROM product_group, category, supplier 
        WHERE product_group_catgory = @CATEGORY_ID AND category.category_id = product_group.product_group_catgory
				AND supplier.supplier_id = product_group.supplier_id
	END
GO

drop proc spGetAllProductGroup

EXEC spGetAllProductGroup @CATEGORY_ID = 1

CREATE PROCEDURE spCheckStocking(@PRODUCT_GROUP_ID varchar(10))
AS
	BEGIN
		SELECT SUM(product_quantity) AS 'Total Quantity'
        FROM product
        WHERE product_group_id = @PRODUCT_GROUP_ID AND product_status = 1
	END
GO

drop proc spCheckStocking

EXEC spCheckStocking @PRODUCT_GROUP_ID = 'AP10'

CREATE PROCEDURE spUpdateStocking(@PRODUCT_GROUP_ID varchar(10), @STATUS bit)
AS
	BEGIN
		UPDATE product_group
		SET product_group_stocking = @STATUS
		WHERE product_group_id = @PRODUCT_GROUP_ID
	END
GO

drop proc spUpdateStocking

EXEC spUpdateStocking 'AP018', 1

CREATE PROCEDURE spInsertProductGroup(
					@PRODUCT_GROUP_ID varchar(10),
					@PRODUCT_GROUP_NAME nvarchar(50),
					@SUPPLIER_ID int,
					@PRODUCT_GROUP_CATEGORY int,
					@PRODUCT_GROUP_STOCKING bit,
					@PRODUCT_GROUP_STATUS bit)
AS
BEGIN
	INSERT INTO product_group(product_group_id, product_group_name, supplier_id, product_group_catgory, product_group_stocking, product_group_status)
	VALUES(
		@PRODUCT_GROUP_ID,
		@PRODUCT_GROUP_NAME,
		@SUPPLIER_ID,
		@PRODUCT_GROUP_CATEGORY,
		@PRODUCT_GROUP_STOCKING,
		@PRODUCT_GROUP_STATUS)
END

CREATE PROCEDURE spUpdateProductGroup(
					@PRODUCT_GROUP_ID varchar(10),
					@PRODUCT_GROUP_NAME nvarchar(50),
					@SUPPLIER_ID int,
					@PRODUCT_GROUP_CATEGORY int,
					@PRODUCT_GROUP_STOCKING bit,
					@PRODUCT_GROUP_STATUS bit)
AS
BEGIN
	UPDATE product_group
	SET product_group_name = @PRODUCT_GROUP_NAME,
		supplier_id = @SUPPLIER_ID,
		product_group_catgory = @PRODUCT_GROUP_CATEGORY,
		product_group_stocking = @PRODUCT_GROUP_STOCKING,
		product_group_status = @PRODUCT_GROUP_STATUS
	WHERE product_group_id = @PRODUCT_GROUP_ID
END

CREATE PROCEDURE spDeleteProductGroup(@PRODUCT_GROUP_ID varchar(10))
AS
BEGIN
	UPDATE product_group
	SET product_group_status = 0
	WHERE product_group_id = @PRODUCT_GROUP_ID;
END

/* Product */
CREATE PROCEDURE spGetProductsActive(@PRODUCT_GROUP_ID varchar(10))
AS
	BEGIN
		SELECT product_group_id, product_id, product_name, product_quantity, product_import_price, product_sale_price, product_description, product_image, product_status
        FROM product 
        WHERE product_status = 1 AND product_group_id = @PRODUCT_GROUP_ID
	END
GO

DROP PROC spGetProductsActive

EXEC spGetProductsActive AP06

CREATE PROCEDURE spGetAllProducts(@PRODUCT_GROUP_ID varchar(10))
AS
	BEGIN
		SELECT product_group_id, product_id, product_name, product_quantity, product_import_price, product_sale_price, product_description, product_image, product_status
        FROM product 
        WHERE product_group_id = @PRODUCT_GROUP_ID
	END
GO

DROP PROC spGetAllProducts

EXEC spGetAllProducts AP06

CREATE PROCEDURE spUpdateProduct(
					@PRODUCT_GROUP_ID varchar(10),
					@PRODUCT_ID nvarchar(50),
					@PRODUCT_NAME nvarchar(100),
					@PRODUCT_QUANTITY int,
					@PRODUCT_IMPORT_PRICE decimal,
					@PRODUCT_SALE_PRICE decimal,
					@PRODUCT_DESCRIPTION nvarchar(MAX),
					@PRODUCT_IMAGE varchar(MAX),
					@PRODUCT_STATUS bit)
AS
BEGIN
	UPDATE product
	SET product_name = @PRODUCT_NAME,
		product_quantity = @PRODUCT_QUANTITY,
		product_import_price = @PRODUCT_IMPORT_PRICE,
		product_sale_price = @PRODUCT_SALE_PRICE,
		product_description = @PRODUCT_DESCRIPTION,
		product_image = @PRODUCT_IMAGE,
		product_status = @PRODUCT_STATUS,
		product_group_id = @PRODUCT_GROUP_ID
	WHERE product_id = @PRODUCT_ID
END

drop proc spUpdateProduct

CREATE PROCEDURE spInsertProduct(
					@PRODUCT_GROUP_ID varchar(10),
					@PRODUCT_ID nvarchar(50),
					@PRODUCT_NAME nvarchar(100),
					@PRODUCT_QUANTITY int,
					@PRODUCT_IMPORT_PRICE decimal,
					@PRODUCT_SALE_PRICE decimal,
					@PRODUCT_DESCRIPTION nvarchar(MAX),
					@PRODUCT_IMAGE varchar(MAX),
					@PRODUCT_STATUS bit)
AS
BEGIN
	INSERT INTO product(product_id, product_name, product_quantity, product_import_price, product_sale_price, product_description, product_image, product_status, product_group_id)
	VALUES(
		@PRODUCT_ID,
		@PRODUCT_NAME,
		@PRODUCT_QUANTITY,
		@PRODUCT_IMPORT_PRICE,
		@PRODUCT_SALE_PRICE,
		@PRODUCT_DESCRIPTION,
		@PRODUCT_IMAGE,
		@PRODUCT_STATUS,
		@PRODUCT_GROUP_ID)
END

CREATE PROCEDURE spDeleteProduct(@PRODUCT_ID nvarchar(50))
AS
BEGIN
	UPDATE product
	SET product_status = 0
	WHERE product_id = @PRODUCT_ID
END

CREATE PROCEDURE spDeleteProducts(@PRODUCT_GROUP_ID varchar(10))
AS
BEGIN
	UPDATE product
	SET product_status = 0
	WHERE product_group_id = @PRODUCT_GROUP_ID
END

/* Supplier */
CREATE PROCEDURE spGetSupplierActive
AS
	BEGIN
		SELECT supplier_id, supplier_name, supplier_phone, supplier_address, supplier_status
        FROM supplier 
        WHERE supplier_status = 1
	END
GO

CREATE PROCEDURE spGetAllSupplier
AS
	BEGIN
		SELECT supplier_id, supplier_name, supplier_phone, supplier_address, supplier_status
        FROM supplier
	END
GO