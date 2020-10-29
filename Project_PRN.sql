USE [master]
GO
/****** Object:  Database [Project_PRN]    Script Date: 10/29/2020 5:24:01 PM ******/
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
/****** Object:  Table [dbo].[category]    Script Date: 10/29/2020 5:24:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[category](
	[category_id] [int] IDENTITY(1,1) NOT NULL,
	[category_name] [nvarchar](50) NOT NULL,
	[category_status] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[category_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[cusomter]    Script Date: 10/29/2020 5:24:01 PM ******/
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
/****** Object:  Table [dbo].[import_log]    Script Date: 10/29/2020 5:24:01 PM ******/
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
/****** Object:  Table [dbo].[order_detail]    Script Date: 10/29/2020 5:24:01 PM ******/
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
/****** Object:  Table [dbo].[product]    Script Date: 10/29/2020 5:24:01 PM ******/
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
	[product_description] [nvarchar](max) NOT NULL,
	[product_imgage] [varchar](max) NOT NULL,
	[product_status] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[product_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[product_group]    Script Date: 10/29/2020 5:24:01 PM ******/
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
	[product_group_stocking] [bit] NOT NULL,
	[product_group_status] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[product_group_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[promotion]    Script Date: 10/29/2020 5:24:01 PM ******/
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
/****** Object:  Table [dbo].[promotion_status]    Script Date: 10/29/2020 5:24:01 PM ******/
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
/****** Object:  Table [dbo].[staff]    Script Date: 10/29/2020 5:24:01 PM ******/
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
	[staff_birthDate] [date] NOT NULL,
	[staff_role] [varchar](5) NOT NULL,
	[staff_status] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[staff_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[staff_role]    Script Date: 10/29/2020 5:24:01 PM ******/
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
/****** Object:  Table [dbo].[store_order]    Script Date: 10/29/2020 5:24:01 PM ******/
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
/****** Object:  Table [dbo].[supplier]    Script Date: 10/29/2020 5:24:01 PM ******/
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
	[supplier_status] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[supplier_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [UQ__product___225F7A766FD0CBA0]    Script Date: 10/29/2020 5:24:01 PM ******/
ALTER TABLE [dbo].[product_group] ADD UNIQUE NONCLUSTERED 
(
	[product_group_name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [UQ__supplier__821868347A2E8FC4]    Script Date: 10/29/2020 5:24:01 PM ******/
ALTER TABLE [dbo].[supplier] ADD UNIQUE NONCLUSTERED 
(
	[supplier_name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[category] ADD  DEFAULT ((1)) FOR [category_status]
GO
ALTER TABLE [dbo].[cusomter] ADD  DEFAULT ((0)) FOR [customer_points]
GO
ALTER TABLE [dbo].[import_log] ADD  DEFAULT (getdate()) FOR [import_time]
GO
ALTER TABLE [dbo].[product] ADD  DEFAULT ((1)) FOR [product_status]
GO
ALTER TABLE [dbo].[product_group] ADD  DEFAULT ((1)) FOR [product_group_stocking]
GO
ALTER TABLE [dbo].[product_group] ADD  DEFAULT ((1)) FOR [product_group_status]
GO
ALTER TABLE [dbo].[staff] ADD  DEFAULT ((1)) FOR [staff_status]
GO
ALTER TABLE [dbo].[store_order] ADD  DEFAULT (newid()) FOR [order_id]
GO
ALTER TABLE [dbo].[supplier] ADD  DEFAULT ((1)) FOR [supplier_status]
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
USE [master]
GO
ALTER DATABASE [Project_PRN] SET  READ_WRITE 
GO
