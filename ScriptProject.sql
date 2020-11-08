CREATE DATABASE Project_PRN

USE Project_PRN
--/////////Product//////--
CREATE TABLE category(
	category_id int identity(1,1) PRIMARY KEY not null,
	category_name nvarchar(50) not null,
	category_status bit default 1 not null,
)

CREATE TABLE product(
	product_group_id varchar(10) not null,
	product_id nvarchar(50) PRIMARY KEY not null,--Mã
	product_name nvarchar(100) not null,--Tên
	product_quantity int not null,
	product_import_price decimal not null,-- gia tien nhap
	product_sale_price decimal not null,--Giá tiền bán
	product_description nvarchar(max) not null,--Ghi chú
	product_image varchar(max) not null,--Ảnh
	product_status bit default 1 not null,
	Foreign Key(product_group_id) REFERENCES product_group(product_group_id)
	ON UPDATE CASCADE
)


CREATE TABLE product_group(
	product_group_id varchar(10) Primary key not null,
	product_group_name nvarchar(50) unique not null,
	supplier_id int not null foreign key references supplier(supplier_id), 
	product_group_catgory int not null,
	product_group_stocking bit default 1 not null,
	product_group_status bit default 1 not null,
	Foreign key (product_group_catgory) REFERENCES category(category_id)
	ON UPDATE CASCADE
)

CREATE TABLE supplier(
	supplier_id int identity(300,1) PRIMARY KEY NOT NULL,
	supplier_name nvarchar(100) UNIQUE NOT NULL,
	supplier_phone varchar(20) NOT NULL,
	supplier_address nvarchar(200) NOT NULL,
	supplier_status bit DEFAULT 1 NOT NULL
)

create table staff(
	staff_id int identity(1,1) primary key not null,
	staff_username varchar(100) not null,
	staff_password varchar(30) not null,
	staff_fullname nvarchar(50) not null,
	staff_citizen_identification varchar(12) not null,
	staff_sex bit not null,
	staff_phone varchar(20) not null,
	staff_address nvarchar(200) not null,
	staff_birthDate date not null,
	staff_image varchar(MAX) not null,
	staff_role varchar(5) foreign key references staff_role(role_id) not null,
	staff_status bit default 1 not null
)

create table staff_role(
	role_id varchar(5) primary key not null,
	role_name nvarchar(20) not null
)

create table cusomter(
	customer_phone varchar(20) primary key not null,
	customer_name nvarchar(50) not null,
	customer_address nvarchar(200),
	customer_birth_date date,
	customer_points float default 0 not null,
	customer_email varchar(100),
)

create table store_order(
	order_id uniqueidentifier default newid() primary key not null,
	order_day datetime not null,
	customer_phone varchar(20) foreign key references cusomter(customer_phone),
	staff_id int foreign key references staff(staff_id) not null,
	order_total_price decimal not null,
	order_total_pay decimal not null,
	order_points float not null,
	promotion_id uniqueidentifier foreign key references promotion(promotion_id)
)

create table order_detail(
	order_id uniqueidentifier foreign key references store_order(order_id) not null,
	order_detail_id int identity(1,1) primary key not null,
	product_id  nvarchar(50) foreign key references product(product_id) not null,
	product_price decimal not null,
	order_detail_quantity int not null
)

create table promotion(
	promotion_id uniqueidentifier primary key not null,
	promotion_value int not null,
	promotion_end_time date not null,
	promotion_type varchar(20) not null,
	promotion_status varchar(5) foreign key references promotion_status(promotion_status_id)
)

create table promotion_status(
	promotion_status_id varchar(5) primary key not null,
	promotion_type nvarchar(20) not null
)

create table import_log(
	log_id int identity(1,1) primary key not null,
	staff_id int foreign key references staff(staff_id) not null,
	product_id nvarchar(50) foreign key references product(product_id) not null,
	product_import_quantity int not null,
	import_time datetime default getdate() not null
)

/*DROP Table Product
DROP Table Categories
DROP Table ProductGroup

 INSERT Category(CategoryName, status) VALUES (N'Áo phao', 1), (N'Áo khoác', 1), (N'Giầy', 1)
 INSERT ProductGroup(ProductGroupID, Name, Catgory, Stocking, Status) VALUES ('AP06',N'Áo phao tai gấu AP06 Đen', 1, 1, 1)
 INSERT Product(ProductGroupID, ProductID, ProductName, ProductQuantity, ProductImportPrice, ProductSalePrice, ProductDescription, ProductImg, ProductStatus)
	VALUES('AP06', 'AP06110', N'Áo phao tai gấu AP06 Đen 110', 2, 370, '', '', 1),
		  ('AP06', 'AP06120', N'Áo phao tai gấu AP06 Đen 120', 5, 370, '', '', 1),
		  ('AP06', 'AP06130', N'Áo phao tai gấu AP06 Đen 130', 2, 370, '', '' , 1)

SELECT Name, CategoryName, Status FROM ProductGroup JOIN Categories ON ProductGroup.Catgory = Categories.CategoryID

SELECT Name, CategoryName, Status 
                         FROM ProductGroup JOIN Categories ON ProductGroup.Catgory = Categories.CategoryID

--INSERT INTO Supplier(SupplierName, SupplierPhone, SupplierAddress) VALUES(N'H&M', N'0987654321' , N'United State')

--///--

/*DECLARE 
@Quantity int;

SET @Quantity = (SELECT SUM(ProductQuantity) FROM Products JOIN ProductSize ON Products.ProductID =  ProductSize.ProductID WHERE Products.ProductID = 'AK')
   


DROP TABLE ProductGroup
DROP TABLE Product
DROP TABLE Categories */



/*DECLARE
    @num1 DECIMAL(19,4),
    @num2 DECIMAL(19,4),
    @num3 DECIMAL(19,4),
    @num4 DECIMAL(19,4)
 
    SELECT
    @num1 = 100, @num2 = 400, @num3 = 10000
 
    SET @num4 = @num1/@num2*@num3
 
    SELECT FORMAT(1000000, 'N0')  
     AS numericresult*/