create database Ado_dotnet 
GO
USE [Ado_dotnet]
GO
/****** Object:  Table [dbo].[employee]    Script Date: 03-03-2020 16:49:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[employee](
	[emp_id] [int] IDENTITY(100,1) NOT NULL,
	[emp_name] [varchar](50) NULL,
	[emp_sal] [money] NULL,
PRIMARY KEY CLUSTERED 
(
	[emp_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[product_inventory]    Script Date: 03-03-2020 16:49:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[product_inventory](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[pro_cateogory] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[productprice]    Script Date: 03-03-2020 16:49:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[productprice](
	[pro_id] [int] IDENTITY(1,1) NOT NULL,
	[pro_name] [varchar](50) NULL,
	[pro_price] [money] NULL,
PRIMARY KEY CLUSTERED 
(
	[pro_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[products]    Script Date: 03-03-2020 16:49:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[products](
	[product_id] [int] IDENTITY(100,1) NOT NULL,
	[product_name] [varchar](50) NULL,
	[quantity] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[product_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[student]    Script Date: 03-03-2020 16:49:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[student](
	[std_id] [int] IDENTITY(1,1) NOT NULL,
	[std_name] [varchar](50) NOT NULL,
	[std_class] [int] NULL,
	[hobby] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[std_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[employee] ON 
GO
INSERT [dbo].[employee] ([emp_id], [emp_name], [emp_sal]) VALUES (100, N'shagun', 5000.0000)
GO
INSERT [dbo].[employee] ([emp_id], [emp_name], [emp_sal]) VALUES (101, N'shakshi', 10000.0000)
GO
INSERT [dbo].[employee] ([emp_id], [emp_name], [emp_sal]) VALUES (102, N'arpit', 21900.0000)
GO
INSERT [dbo].[employee] ([emp_id], [emp_name], [emp_sal]) VALUES (103, N'mohit', 24100.0000)
GO
INSERT [dbo].[employee] ([emp_id], [emp_name], [emp_sal]) VALUES (104, N'mansi', 22200.0000)
GO
SET IDENTITY_INSERT [dbo].[employee] OFF
GO
SET IDENTITY_INSERT [dbo].[product_inventory] ON 
GO
INSERT [dbo].[product_inventory] ([id], [pro_cateogory]) VALUES (1, N'sports')
GO
INSERT [dbo].[product_inventory] ([id], [pro_cateogory]) VALUES (2, N'kitchen')
GO
INSERT [dbo].[product_inventory] ([id], [pro_cateogory]) VALUES (3, N'electronics')
GO
INSERT [dbo].[product_inventory] ([id], [pro_cateogory]) VALUES (4, N'stationary')
GO
SET IDENTITY_INSERT [dbo].[product_inventory] OFF
GO
SET IDENTITY_INSERT [dbo].[productprice] ON 
GO
INSERT [dbo].[productprice] ([pro_id], [pro_name], [pro_price]) VALUES (1, N'AC', 2000.0000)
GO
INSERT [dbo].[productprice] ([pro_id], [pro_name], [pro_price]) VALUES (2, N'Fridge', 1000.0000)
GO
INSERT [dbo].[productprice] ([pro_id], [pro_name], [pro_price]) VALUES (3, N'Fan', 1500.0000)
GO
INSERT [dbo].[productprice] ([pro_id], [pro_name], [pro_price]) VALUES (4, N'Book', 200.0000)
GO
INSERT [dbo].[productprice] ([pro_id], [pro_name], [pro_price]) VALUES (5, N'Chair', 1300.0000)
GO
INSERT [dbo].[productprice] ([pro_id], [pro_name], [pro_price]) VALUES (6, N'Laptop', 800.0000)
GO
INSERT [dbo].[productprice] ([pro_id], [pro_name], [pro_price]) VALUES (7, N'Laptop', 800.0000)
GO
INSERT [dbo].[productprice] ([pro_id], [pro_name], [pro_price]) VALUES (8, N'Laptop', 800.0000)
GO
INSERT [dbo].[productprice] ([pro_id], [pro_name], [pro_price]) VALUES (9, N'Laptop', 800.0000)
GO
INSERT [dbo].[productprice] ([pro_id], [pro_name], [pro_price]) VALUES (10, N'Laptop', 800.0000)
GO
SET IDENTITY_INSERT [dbo].[productprice] OFF
GO
SET IDENTITY_INSERT [dbo].[products] ON 
GO
INSERT [dbo].[products] ([product_id], [product_name], [quantity]) VALUES (100, N'Iphone', 22)
GO
INSERT [dbo].[products] ([product_id], [product_name], [quantity]) VALUES (101, N'Ipad', 11)
GO
INSERT [dbo].[products] ([product_id], [product_name], [quantity]) VALUES (102, N'Fan', 10)
GO
INSERT [dbo].[products] ([product_id], [product_name], [quantity]) VALUES (103, N'Fridge', 8)
GO
INSERT [dbo].[products] ([product_id], [product_name], [quantity]) VALUES (104, N'Icecream', 12)
GO
INSERT [dbo].[products] ([product_id], [product_name], [quantity]) VALUES (105, N'Bat', 8)
GO
SET IDENTITY_INSERT [dbo].[products] OFF
GO
SET IDENTITY_INSERT [dbo].[student] ON 
GO
INSERT [dbo].[student] ([std_id], [std_name], [std_class], [hobby]) VALUES (1, N'Ram', 3, N'Singing')
GO
INSERT [dbo].[student] ([std_id], [std_name], [std_class], [hobby]) VALUES (2, N'Shyam', 6, N'Dancing')
GO
INSERT [dbo].[student] ([std_id], [std_name], [std_class], [hobby]) VALUES (3, N'Mohit', 8, N'Swimming')
GO
INSERT [dbo].[student] ([std_id], [std_name], [std_class], [hobby]) VALUES (4, N'Manish', 2, N'Cricket')
GO
INSERT [dbo].[student] ([std_id], [std_name], [std_class], [hobby]) VALUES (5, N'Gopal', 7, N'Cycling')
GO
INSERT [dbo].[student] ([std_id], [std_name], [std_class], [hobby]) VALUES (6, N'Sonal', 10, N'Eating')
GO
INSERT [dbo].[student] ([std_id], [std_name], [std_class], [hobby]) VALUES (7, N'Vijay', 12, N'Singing')
GO
INSERT [dbo].[student] ([std_id], [std_name], [std_class], [hobby]) VALUES (8, N'Neha', 9, N'Dancing')
GO
INSERT [dbo].[student] ([std_id], [std_name], [std_class], [hobby]) VALUES (9, N'Shubham', 6, N'Swimming')
GO
INSERT [dbo].[student] ([std_id], [std_name], [std_class], [hobby]) VALUES (10, N'Vaibhav', 8, N'Singing')
GO
INSERT [dbo].[student] ([std_id], [std_name], [std_class], [hobby]) VALUES (11, N'Tarun', 11, N'Sleeping')
GO
INSERT [dbo].[student] ([std_id], [std_name], [std_class], [hobby]) VALUES (12, N'Mohan', 3, N'Cricket')
GO
INSERT [dbo].[student] ([std_id], [std_name], [std_class], [hobby]) VALUES (13, N'Mohan', 3, N'Cricket')
GO
INSERT [dbo].[student] ([std_id], [std_name], [std_class], [hobby]) VALUES (14, N'Shagun', 8, N'Dancing')
GO
INSERT [dbo].[student] ([std_id], [std_name], [std_class], [hobby]) VALUES (15, N'Shagun', 8, N'Dancing')
GO
INSERT [dbo].[student] ([std_id], [std_name], [std_class], [hobby]) VALUES (16, N'Shagun', 8, N'Dancing')
GO
INSERT [dbo].[student] ([std_id], [std_name], [std_class], [hobby]) VALUES (17, N'Azeem', 8, N'Dancing')
GO
INSERT [dbo].[student] ([std_id], [std_name], [std_class], [hobby]) VALUES (18, N'Shagun', 8, N'Dancing')
GO
INSERT [dbo].[student] ([std_id], [std_name], [std_class], [hobby]) VALUES (19, N'Shagun', 8, N'Dancing')
GO
INSERT [dbo].[student] ([std_id], [std_name], [std_class], [hobby]) VALUES (20, N'Shagun', 8, N'Dancing')
GO
INSERT [dbo].[student] ([std_id], [std_name], [std_class], [hobby]) VALUES (21, N'Shagun', 8, N'Dancing')
GO
INSERT [dbo].[student] ([std_id], [std_name], [std_class], [hobby]) VALUES (22, N'Shagun', 8, N'Dancing')
GO
SET IDENTITY_INSERT [dbo].[student] OFF
GO
/****** Object:  StoredProcedure [dbo].[getbyname]    Script Date: 03-03-2020 16:49:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[getbyname]

@pro_name varchar(50)

as 
begin 
select * from products where product_name like @pro_name +'%'
end 
GO
/****** Object:  StoredProcedure [dbo].[getval2]    Script Date: 03-03-2020 16:49:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[getval2]
@st_name varchar(50) 
as
begin 
select * from student where std_name like @st_name + '%'
end 
GO
/****** Object:  StoredProcedure [dbo].[getvalname]    Script Date: 03-03-2020 16:49:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[getvalname] 
@st_name varchar(50)
as
begin
select * from student 
end 
GO
/****** Object:  StoredProcedure [dbo].[getvalname1]    Script Date: 03-03-2020 16:49:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[getvalname1]
as
begin
select * from student
end 
GO
