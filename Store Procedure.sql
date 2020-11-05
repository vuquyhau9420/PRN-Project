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

CREATE PROCEDURE spGetCategorys
AS
	BEGIN
		SELECT category_id, category_name, category_status
        FROM category 
        WHERE category_status = 1
	END
GO

EXEC spGetCategorys

CREATE PROCEDURE spGetProductGroup(@CATEGORY_ID int)
AS
	BEGIN
		SELECT product_group_id, product_group_name, supplier_name, category_name, product_group_stocking, product_group_status
        FROM product_group, category, supplier 
        WHERE product_group_status = 1 AND product_group_catgory = @CATEGORY_ID AND category.category_id = product_group.product_group_catgory
				AND supplier.supplier_id = product_group.supplier_id
	END
GO

drop proc spGetProductGroup

EXEC spGetProductGroup @CATEGORY_ID = 1

CREATE PROCEDURE spGetProducts(@PRODUCT_GROUP_ID varchar(10))
AS
	BEGIN
		SELECT product_group_id, product_id, product_name, product_quantity, product_import_price, product_sale_price, product_description, product_image, product_status
        FROM product 
        WHERE product_status = 1 AND product_group_id = @PRODUCT_GROUP_ID
	END
GO

EXEC spGetProducts AP06

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