USE [master]
GO
/****** Object:  Database [Project_PRN]    Script Date: 11/8/2020 9:18:48 PM ******/
CREATE DATABASE [Project_PRN]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Project_PRN', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\Project_PRN.mdf' , SIZE = 3264KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Project_PRN_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\Project_PRN_log.ldf' , SIZE = 832KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Project_PRN] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Project_PRN].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Project_PRN] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Project_PRN] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Project_PRN] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Project_PRN] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Project_PRN] SET ARITHABORT OFF 
GO
ALTER DATABASE [Project_PRN] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [Project_PRN] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Project_PRN] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Project_PRN] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Project_PRN] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Project_PRN] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Project_PRN] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Project_PRN] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Project_PRN] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Project_PRN] SET  ENABLE_BROKER 
GO
ALTER DATABASE [Project_PRN] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Project_PRN] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Project_PRN] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Project_PRN] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Project_PRN] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Project_PRN] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Project_PRN] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Project_PRN] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Project_PRN] SET  MULTI_USER 
GO
ALTER DATABASE [Project_PRN] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Project_PRN] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Project_PRN] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Project_PRN] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [Project_PRN] SET DELAYED_DURABILITY = DISABLED 
GO
USE [Project_PRN]
GO
/****** Object:  Table [dbo].[category]    Script Date: 11/8/2020 9:18:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[category](
	[category_id] [int] IDENTITY(1,1) NOT NULL,
	[category_name] [nvarchar](50) NOT NULL,
	[category_status] [bit] NOT NULL DEFAULT ((1)),
PRIMARY KEY CLUSTERED 
(
	[category_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[cusomter]    Script Date: 11/8/2020 9:18:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[cusomter](
	[customer_phone] [varchar](20) NOT NULL,
	[customer_name] [nvarchar](50) NOT NULL,
	[customer_address] [nvarchar](200) NULL,
	[customer_birth_date] [date] NULL,
	[customer_points] [float] NOT NULL,
	[customer_email] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[customer_phone] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[import_log]    Script Date: 11/8/2020 9:18:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[import_log](
	[log_id] [int] IDENTITY(1,1) NOT NULL,
	[staff_id] [int] NOT NULL,
	[product_id] [nvarchar](50) NOT NULL,
	[product_import_quantity] [int] NOT NULL,
	[import_time] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[log_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[order_detail]    Script Date: 11/8/2020 9:18:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[order_detail](
	[order_id] [uniqueidentifier] NOT NULL,
	[order_detail_id] [int] IDENTITY(1,1) NOT NULL,
	[product_id] [nvarchar](50) NOT NULL,
	[product_price] [decimal](18, 0) NOT NULL,
	[order_detail_quantity] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[order_detail_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[product]    Script Date: 11/8/2020 9:18:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[product](
	[product_group_id] [varchar](10) NOT NULL,
	[product_id] [nvarchar](50) NOT NULL,
	[product_name] [nvarchar](100) NOT NULL,
	[product_quantity] [int] NOT NULL,
	[product_import_price] [decimal](18, 0) NOT NULL,
	[product_sale_price] [decimal](18, 0) NOT NULL,
	[product_description] [nvarchar](max) NULL,
	[product_image] [varchar](max) NOT NULL,
	[product_status] [bit] NOT NULL DEFAULT ((1)),
PRIMARY KEY CLUSTERED 
(
	[product_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[product_group]    Script Date: 11/8/2020 9:18:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[product_group](
	[product_group_id] [varchar](10) NOT NULL,
	[product_group_name] [nvarchar](50) NOT NULL,
	[supplier_id] [int] NOT NULL,
	[product_group_catgory] [int] NOT NULL,
	[product_group_stocking] [bit] NOT NULL DEFAULT ((1)),
	[product_group_status] [bit] NOT NULL DEFAULT ((1)),
PRIMARY KEY CLUSTERED 
(
	[product_group_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[promotion]    Script Date: 11/8/2020 9:18:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[promotion](
	[promotion_id] [uniqueidentifier] NOT NULL,
	[promotion_value] [int] NOT NULL,
	[promotion_end_time] [date] NOT NULL,
	[promotion_type] [varchar](20) NOT NULL,
	[promotion_status] [varchar](5) NULL,
PRIMARY KEY CLUSTERED 
(
	[promotion_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[promotion_status]    Script Date: 11/8/2020 9:18:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[promotion_status](
	[promotion_status_id] [varchar](5) NOT NULL,
	[promotion_status_name] [nvarchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[promotion_status_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[staff]    Script Date: 11/8/2020 9:18:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[staff](
	[staff_id] [int] IDENTITY(1,1) NOT NULL,
	[staff_username] [varchar](100) NOT NULL,
	[staff_password] [varchar](30) NOT NULL,
	[staff_fullname] [nvarchar](50) NOT NULL,
	[staff_citizen_identification] [varchar](12) NOT NULL,
	[staff_sex] [bit] NOT NULL,
	[staff_phone] [varchar](20) NOT NULL,
	[staff_address] [nvarchar](200) NOT NULL,
	[staff_birthday] [date] NOT NULL,
	[staff_role] [varchar](5) NOT NULL,
	[staff_status] [bit] NOT NULL DEFAULT ((1)),
	[staff_image] [varchar](max) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[staff_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[staff_role]    Script Date: 11/8/2020 9:18:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[staff_role](
	[role_id] [varchar](5) NOT NULL,
	[role_name] [nvarchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[role_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[store_order]    Script Date: 11/8/2020 9:18:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[store_order](
	[order_id] [uniqueidentifier] NOT NULL,
	[order_day] [datetime] NOT NULL,
	[customer_phone] [varchar](20) NULL,
	[order_total_price] [decimal](18, 0) NOT NULL,
	[order_total_pay] [decimal](18, 0) NOT NULL,
	[order_points] [float] NOT NULL,
	[promotion_id] [uniqueidentifier] NULL,
	[staff_id] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[order_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[supplier]    Script Date: 11/8/2020 9:18:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[supplier](
	[supplier_id] [int] IDENTITY(300,1) NOT NULL,
	[supplier_name] [nvarchar](100) NOT NULL,
	[supplier_phone] [varchar](20) NOT NULL,
	[supplier_address] [nvarchar](200) NOT NULL,
	[supplier_status] [bit] NOT NULL DEFAULT ((1)),
PRIMARY KEY CLUSTERED 
(
	[supplier_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[category] ON 

INSERT [dbo].[category] ([category_id], [category_name], [category_status]) VALUES (1, N'Áo Phao', 1)
INSERT [dbo].[category] ([category_id], [category_name], [category_status]) VALUES (2, N'Áo Khoác', 1)
INSERT [dbo].[category] ([category_id], [category_name], [category_status]) VALUES (3, N'Giày', 0)
SET IDENTITY_INSERT [dbo].[category] OFF
INSERT [dbo].[product] ([product_group_id], [product_id], [product_name], [product_quantity], [product_import_price], [product_sale_price], [product_description], [product_image], [product_status]) VALUES (N'AP018', N'AP018_L', N'Áo phao ghi lê xanh size L', 1000, CAST(20 AS Decimal(18, 0)), CAST(35 AS Decimal(18, 0)), N'Hello', N'D:\Study\CN5\PRN292\Project Final\PRN-Project\Project_Final\Image\Product Image\cry.jpeg', 1)
INSERT [dbo].[product] ([product_group_id], [product_id], [product_name], [product_quantity], [product_import_price], [product_sale_price], [product_description], [product_image], [product_status]) VALUES (N'AP018', N'AP018_M', N'Áo phao ghi lê xanh size M', 1000, CAST(16 AS Decimal(18, 0)), CAST(21 AS Decimal(18, 0)), N'U', N'D:\Study\CN5\PRN292\Project Final\PRN-Project\Project_Final\Image\Product Image\aaaaaaaaaaa.jpeg', 1)
INSERT [dbo].[product] ([product_group_id], [product_id], [product_name], [product_quantity], [product_import_price], [product_sale_price], [product_description], [product_image], [product_status]) VALUES (N'AP018', N'AP018_S', N'Áo phao ghi lê xanh size S', 1000, CAST(15 AS Decimal(18, 0)), CAST(20 AS Decimal(18, 0)), N'U', N'a', 1)
INSERT [dbo].[product] ([product_group_id], [product_id], [product_name], [product_quantity], [product_import_price], [product_sale_price], [product_description], [product_image], [product_status]) VALUES (N'AP02', N'AP02_L', N'Áo phao vịt size L', 1000, CAST(25 AS Decimal(18, 0)), CAST(30 AS Decimal(18, 0)), N'U', N'a', 0)
INSERT [dbo].[product] ([product_group_id], [product_id], [product_name], [product_quantity], [product_import_price], [product_sale_price], [product_description], [product_image], [product_status]) VALUES (N'AP02', N'AP02_M', N'Áo phao vịt size M', 100, CAST(23 AS Decimal(18, 0)), CAST(28 AS Decimal(18, 0)), N'U', N'a', 1)
INSERT [dbo].[product] ([product_group_id], [product_id], [product_name], [product_quantity], [product_import_price], [product_sale_price], [product_description], [product_image], [product_status]) VALUES (N'AP02', N'AP02_S', N'Áo phao vịt size S', 1000, CAST(22 AS Decimal(18, 0)), CAST(27 AS Decimal(18, 0)), N'U', N'a', 0)
INSERT [dbo].[product] ([product_group_id], [product_id], [product_name], [product_quantity], [product_import_price], [product_sale_price], [product_description], [product_image], [product_status]) VALUES (N'AP06', N'AP06_L', N'Áo phao tai gấu đen size L', 1000, CAST(12 AS Decimal(18, 0)), CAST(17 AS Decimal(18, 0)), N'U', N'a', 1)
INSERT [dbo].[product] ([product_group_id], [product_id], [product_name], [product_quantity], [product_import_price], [product_sale_price], [product_description], [product_image], [product_status]) VALUES (N'AP06', N'AP06_M', N'Áo phao tai gấu đen size M', 1000, CAST(11 AS Decimal(18, 0)), CAST(16 AS Decimal(18, 0)), N'U', N'a', 1)
INSERT [dbo].[product] ([product_group_id], [product_id], [product_name], [product_quantity], [product_import_price], [product_sale_price], [product_description], [product_image], [product_status]) VALUES (N'AP06', N'AP06_S', N'Áo phao tai gấu đen size S', 1000, CAST(10 AS Decimal(18, 0)), CAST(15 AS Decimal(18, 0)), N'Unknown', N'a', 0)
INSERT [dbo].[product] ([product_group_id], [product_id], [product_name], [product_quantity], [product_import_price], [product_sale_price], [product_description], [product_image], [product_status]) VALUES (N'AP10', N'AP10_L', N'Áo phao ếch size L', 1000, CAST(25 AS Decimal(18, 0)), CAST(30 AS Decimal(18, 0)), N'U', N'a', 1)
INSERT [dbo].[product] ([product_group_id], [product_id], [product_name], [product_quantity], [product_import_price], [product_sale_price], [product_description], [product_image], [product_status]) VALUES (N'AP10', N'AP10_M', N'Áo phao ếch size M', 1000, CAST(25 AS Decimal(18, 0)), CAST(30 AS Decimal(18, 0)), N'U', N'a', 1)
INSERT [dbo].[product] ([product_group_id], [product_id], [product_name], [product_quantity], [product_import_price], [product_sale_price], [product_description], [product_image], [product_status]) VALUES (N'AP10', N'AP10_S', N'Áo phao ếch size S', 1000, CAST(25 AS Decimal(18, 0)), CAST(30 AS Decimal(18, 0)), N'Alo', N'D:\Study\CN5\PRN292\Project Final\PRN-Project\Project_Final\Image\Product Image\meme.jpg', 0)
INSERT [dbo].[product] ([product_group_id], [product_id], [product_name], [product_quantity], [product_import_price], [product_sale_price], [product_description], [product_image], [product_status]) VALUES (N'AP10', N'AP10_T', N'Test', 1000, CAST(100 AS Decimal(18, 0)), CAST(500 AS Decimal(18, 0)), N'Ola', N'D:\Study\CN5\PRN292\Project Final\PRN-Project\Project_Final\Image\Product Image\taro.jpg', 0)
INSERT [dbo].[product] ([product_group_id], [product_id], [product_name], [product_quantity], [product_import_price], [product_sale_price], [product_description], [product_image], [product_status]) VALUES (N'GIAY063', N'GIAY063_X26', N'Giày size 26', 100, CAST(50 AS Decimal(18, 0)), CAST(100 AS Decimal(18, 0)), NULL, N'D:\Study\CN5\PRN292\Project Final\PRN-Project\Project_Final\Image\Product Image\Bánh nhân khoai môn.jpeg', 1)
INSERT [dbo].[product] ([product_group_id], [product_id], [product_name], [product_quantity], [product_import_price], [product_sale_price], [product_description], [product_image], [product_status]) VALUES (N'GIAY063', N'GIAY063_X27', N'Giày đen xám size 27', 1000, CAST(60 AS Decimal(18, 0)), CAST(100 AS Decimal(18, 0)), N'Hello', N'D:\Study\CN5\PRN292\Project Final\PRN-Project\Project_Final\Image\Product Image\pic2.jpg', 0)
INSERT [dbo].[product_group] ([product_group_id], [product_group_name], [supplier_id], [product_group_catgory], [product_group_stocking], [product_group_status]) VALUES (N'AK037', N'Áo khoác khủng long xanhh', 300, 2, 1, 1)
INSERT [dbo].[product_group] ([product_group_id], [product_group_name], [supplier_id], [product_group_catgory], [product_group_stocking], [product_group_status]) VALUES (N'AK039', N'Áo khoác trơn đỏ', 301, 2, 1, 1)
INSERT [dbo].[product_group] ([product_group_id], [product_group_name], [supplier_id], [product_group_catgory], [product_group_stocking], [product_group_status]) VALUES (N'AK048', N'Áo khoác cá voi xanh', 300, 2, 1, 1)
INSERT [dbo].[product_group] ([product_group_id], [product_group_name], [supplier_id], [product_group_catgory], [product_group_stocking], [product_group_status]) VALUES (N'AK050', N'Áo khoác vịt đỏ', 301, 2, 1, 1)
INSERT [dbo].[product_group] ([product_group_id], [product_group_name], [supplier_id], [product_group_catgory], [product_group_stocking], [product_group_status]) VALUES (N'AP018', N'Áo phao ghi lê xanh', 301, 1, 1, 1)
INSERT [dbo].[product_group] ([product_group_id], [product_group_name], [supplier_id], [product_group_catgory], [product_group_stocking], [product_group_status]) VALUES (N'AP02', N'Áo phao vịt', 300, 1, 1, 1)
INSERT [dbo].[product_group] ([product_group_id], [product_group_name], [supplier_id], [product_group_catgory], [product_group_stocking], [product_group_status]) VALUES (N'AP06', N'Áo phao tai gấu đen', 300, 1, 1, 1)
INSERT [dbo].[product_group] ([product_group_id], [product_group_name], [supplier_id], [product_group_catgory], [product_group_stocking], [product_group_status]) VALUES (N'AP10', N'Áo phao ếch', 302, 1, 1, 1)
INSERT [dbo].[product_group] ([product_group_id], [product_group_name], [supplier_id], [product_group_catgory], [product_group_stocking], [product_group_status]) VALUES (N'GIAY020', N'Giày thể thao cam', 303, 3, 0, 0)
INSERT [dbo].[product_group] ([product_group_id], [product_group_name], [supplier_id], [product_group_catgory], [product_group_stocking], [product_group_status]) VALUES (N'GIAY028', N'Giày sandal đen', 303, 3, 1, 1)
INSERT [dbo].[product_group] ([product_group_id], [product_group_name], [supplier_id], [product_group_catgory], [product_group_stocking], [product_group_status]) VALUES (N'GIAY030', N'Giày thể thao xanh', 303, 3, 1, 1)
INSERT [dbo].[product_group] ([product_group_id], [product_group_name], [supplier_id], [product_group_catgory], [product_group_stocking], [product_group_status]) VALUES (N'GIAY063', N'Giày đen xám', 303, 3, 1, 1)
SET IDENTITY_INSERT [dbo].[staff] ON 

INSERT [dbo].[staff] ([staff_id], [staff_username], [staff_password], [staff_fullname], [staff_citizen_identification], [staff_sex], [staff_phone], [staff_address], [staff_birthday], [staff_role], [staff_status], [staff_image]) VALUES (1, N'hieulm', N'1', N'Hieu Le', N'0123456', 1, N'0987654321', N'Ai Biet', CAST(N'2000-01-01' AS Date), N'O', 1, N'D:\Study\CN5\PRN292\Project Final\PRN-Project\Project_Final\Image\Staff Image\hieulm.png')
SET IDENTITY_INSERT [dbo].[staff] OFF
INSERT [dbo].[staff_role] ([role_id], [role_name]) VALUES (N'A', N'Admin')
INSERT [dbo].[staff_role] ([role_id], [role_name]) VALUES (N'O', N'Owner')
INSERT [dbo].[staff_role] ([role_id], [role_name]) VALUES (N'S', N'Staff')
SET IDENTITY_INSERT [dbo].[supplier] ON 

INSERT [dbo].[supplier] ([supplier_id], [supplier_name], [supplier_phone], [supplier_address], [supplier_status]) VALUES (300, N'H&M', N'0123456789', N'Ai biết', 1)
INSERT [dbo].[supplier] ([supplier_id], [supplier_name], [supplier_phone], [supplier_address], [supplier_status]) VALUES (301, N'Louise Vuiton', N'0987654321', N'Biết ai', 1)
INSERT [dbo].[supplier] ([supplier_id], [supplier_name], [supplier_phone], [supplier_address], [supplier_status]) VALUES (302, N'Gucchi', N'0456789123', N'Đố biết', 1)
INSERT [dbo].[supplier] ([supplier_id], [supplier_name], [supplier_phone], [supplier_address], [supplier_status]) VALUES (303, N'Channel', N'0789456123', N'Biết đố', 1)
SET IDENTITY_INSERT [dbo].[supplier] OFF
SET ANSI_PADDING ON

GO
/****** Object:  Index [UQ__product___225F7A766FD0CBA0]    Script Date: 11/8/2020 9:18:48 PM ******/
ALTER TABLE [dbo].[product_group] ADD UNIQUE NONCLUSTERED 
(
	[product_group_name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [UQ__supplier__821868347A2E8FC4]    Script Date: 11/8/2020 9:18:48 PM ******/
ALTER TABLE [dbo].[supplier] ADD UNIQUE NONCLUSTERED 
(
	[supplier_name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[cusomter] ADD  DEFAULT ((0)) FOR [customer_points]
GO
ALTER TABLE [dbo].[import_log] ADD  DEFAULT (getdate()) FOR [import_time]
GO
ALTER TABLE [dbo].[store_order] ADD  DEFAULT (newid()) FOR [order_id]
GO
ALTER TABLE [dbo].[import_log]  WITH CHECK ADD FOREIGN KEY([product_id])
REFERENCES [dbo].[product] ([product_id])
GO
ALTER TABLE [dbo].[import_log]  WITH CHECK ADD FOREIGN KEY([staff_id])
REFERENCES [dbo].[staff] ([staff_id])
GO
ALTER TABLE [dbo].[order_detail]  WITH CHECK ADD FOREIGN KEY([order_id])
REFERENCES [dbo].[store_order] ([order_id])
GO
ALTER TABLE [dbo].[order_detail]  WITH CHECK ADD FOREIGN KEY([product_id])
REFERENCES [dbo].[product] ([product_id])
GO
ALTER TABLE [dbo].[product]  WITH CHECK ADD FOREIGN KEY([product_group_id])
REFERENCES [dbo].[product_group] ([product_group_id])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[product_group]  WITH CHECK ADD FOREIGN KEY([product_group_catgory])
REFERENCES [dbo].[category] ([category_id])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[product_group]  WITH CHECK ADD FOREIGN KEY([supplier_id])
REFERENCES [dbo].[supplier] ([supplier_id])
GO
ALTER TABLE [dbo].[promotion]  WITH CHECK ADD FOREIGN KEY([promotion_status])
REFERENCES [dbo].[promotion_status] ([promotion_status_id])
GO
ALTER TABLE [dbo].[staff]  WITH CHECK ADD FOREIGN KEY([staff_role])
REFERENCES [dbo].[staff_role] ([role_id])
GO
ALTER TABLE [dbo].[store_order]  WITH CHECK ADD FOREIGN KEY([customer_phone])
REFERENCES [dbo].[cusomter] ([customer_phone])
GO
ALTER TABLE [dbo].[store_order]  WITH CHECK ADD FOREIGN KEY([promotion_id])
REFERENCES [dbo].[promotion] ([promotion_id])
GO
ALTER TABLE [dbo].[store_order]  WITH CHECK ADD FOREIGN KEY([staff_id])
REFERENCES [dbo].[staff] ([staff_id])
GO
/****** Object:  StoredProcedure [dbo].[spCheckLogin]    Script Date: 11/8/2020 9:18:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[spCheckLogin](@STAFF_USERNAME VARCHAR(100), @STAFF_PASSWORD VARCHAR(30))
AS
	BEGIN
		SELECT staff_id, staff_username, staff_password, staff_fullname, staff_citizen_identification, staff_sex, staff_phone, staff_address, staff_birthday, staff_role, staff_status
        FROM staff 
        WHERE staff_username = @STAFF_USERNAME 
              AND staff_password = @STAFF_PASSWORD AND staff_status = 'TRUE'
	END

GO
/****** Object:  StoredProcedure [dbo].[spCheckStocking]    Script Date: 11/8/2020 9:18:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spCheckStocking](@PRODUCT_GROUP_ID varchar(10))
AS
	BEGIN
		SELECT SUM(product_quantity) AS 'Total Quantity'
        FROM product
        WHERE product_group_id = @PRODUCT_GROUP_ID AND product_status = 1
	END

GO
/****** Object:  StoredProcedure [dbo].[spDeleteProduct]    Script Date: 11/8/2020 9:18:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spDeleteProduct](@PRODUCT_ID nvarchar(50))
AS
BEGIN
	UPDATE product
	SET product_status = 0
	WHERE product_id = @PRODUCT_ID
END
GO
/****** Object:  StoredProcedure [dbo].[spDeleteProductGroup]    Script Date: 11/8/2020 9:18:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spDeleteProductGroup](@PRODUCT_GROUP_ID varchar(10))
AS
BEGIN
	UPDATE product_group
	SET product_group_status = 0
	WHERE product_group_id = @PRODUCT_GROUP_ID;
END
GO
/****** Object:  StoredProcedure [dbo].[spDeleteProducts]    Script Date: 11/8/2020 9:18:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spDeleteProducts](@PRODUCT_GROUP_ID varchar(10))
AS
BEGIN
	UPDATE product
	SET product_status = 0
	WHERE product_group_id = @PRODUCT_GROUP_ID
END
GO
/****** Object:  StoredProcedure [dbo].[spGetAllCategories]    Script Date: 11/8/2020 9:18:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spGetAllCategories]
AS
	BEGIN
		SELECT category_id, category_name, category_status
        FROM category 
	END

GO
/****** Object:  StoredProcedure [dbo].[spGetAllProductGroup]    Script Date: 11/8/2020 9:18:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spGetAllProductGroup](@CATEGORY_ID int)
AS
	BEGIN
		SELECT product_group_id, product_group_name, supplier_name, category_name, product_group_stocking, product_group_status
        FROM product_group, category, supplier 
        WHERE product_group_catgory = @CATEGORY_ID AND category.category_id = product_group.product_group_catgory
				AND supplier.supplier_id = product_group.supplier_id
	END

GO
/****** Object:  StoredProcedure [dbo].[spGetAllProducts]    Script Date: 11/8/2020 9:18:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spGetAllProducts](@PRODUCT_GROUP_ID varchar(10))
AS
	BEGIN
		SELECT product_group_id, product_id, product_name, product_quantity, product_import_price, product_sale_price, product_description, product_image, product_status
        FROM product 
        WHERE product_group_id = @PRODUCT_GROUP_ID
	END

GO
/****** Object:  StoredProcedure [dbo].[spGetAllSupplier]    Script Date: 11/8/2020 9:18:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spGetAllSupplier]
AS
	BEGIN
		SELECT supplier_id, supplier_name, supplier_phone, supplier_address, supplier_status
        FROM supplier
	END

GO
/****** Object:  StoredProcedure [dbo].[spGetCategoriesActive]    Script Date: 11/8/2020 9:18:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spGetCategoriesActive]
AS
	BEGIN
		SELECT category_id, category_name, category_status
        FROM category 
		WHERE category_status = 1
	END

GO
/****** Object:  StoredProcedure [dbo].[spGetProductGroupActive]    Script Date: 11/8/2020 9:18:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spGetProductGroupActive](@CATEGORY_ID int)
AS
	BEGIN
		SELECT product_group_id, product_group_name, supplier_name, category_name, product_group_stocking, product_group_status
        FROM product_group, category, supplier 
        WHERE product_group_status = 1 AND product_group_catgory = @CATEGORY_ID AND category.category_id = product_group.product_group_catgory
				AND supplier.supplier_id = product_group.supplier_id
	END

GO
/****** Object:  StoredProcedure [dbo].[spGetProductsActive]    Script Date: 11/8/2020 9:18:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spGetProductsActive](@PRODUCT_GROUP_ID varchar(10))
AS
	BEGIN
		SELECT product_group_id, product_id, product_name, product_quantity, product_import_price, product_sale_price, product_description, product_image, product_status
        FROM product 
        WHERE product_status = 1 AND product_group_id = @PRODUCT_GROUP_ID
	END

GO
/****** Object:  StoredProcedure [dbo].[spGetSupplierActive]    Script Date: 11/8/2020 9:18:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spGetSupplierActive]
AS
	BEGIN
		SELECT supplier_id, supplier_name, supplier_phone, supplier_address, supplier_status
        FROM supplier 
        WHERE supplier_status = 1
	END

GO
/****** Object:  StoredProcedure [dbo].[spInsertProduct]    Script Date: 11/8/2020 9:18:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spInsertProduct](
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
GO
/****** Object:  StoredProcedure [dbo].[spInsertProductGroup]    Script Date: 11/8/2020 9:18:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spInsertProductGroup](
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
GO
/****** Object:  StoredProcedure [dbo].[spUpdateProduct]    Script Date: 11/8/2020 9:18:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spUpdateProduct](
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
GO
/****** Object:  StoredProcedure [dbo].[spUpdateProductGroup]    Script Date: 11/8/2020 9:18:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spUpdateProductGroup](
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
GO
/****** Object:  StoredProcedure [dbo].[spUpdateStocking]    Script Date: 11/8/2020 9:18:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spUpdateStocking](@PRODUCT_GROUP_ID varchar(10), @STATUS bit)
AS
	BEGIN
		UPDATE product_group
		SET product_group_stocking = @STATUS
		WHERE product_group_id = @PRODUCT_GROUP_ID
	END

GO
USE [master]
GO
ALTER DATABASE [Project_PRN] SET  READ_WRITE 
GO
