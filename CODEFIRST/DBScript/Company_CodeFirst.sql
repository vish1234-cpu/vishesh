USE [Company]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 20-03-2020 13:42:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customers]    Script Date: 20-03-2020 13:42:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customers](
	[CusId] [int] IDENTITY(1,1) NOT NULL,
	[CusFirstName] [nvarchar](max) NULL,
	[CusLastName] [nvarchar](max) NULL,
 CONSTRAINT [PK_Customers] PRIMARY KEY CLUSTERED 
(
	[CusId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Orders]    Script Date: 20-03-2020 13:42:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[OrderId] [int] IDENTITY(1,1) NOT NULL,
	[CusId] [int] NULL,
	[ProductId] [int] NULL,
	[OrderAddress] [nvarchar](max) NULL,
 CONSTRAINT [PK_Orders] PRIMARY KEY CLUSTERED 
(
	[OrderId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Products]    Script Date: 20-03-2020 13:42:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[ProductId] [int] IDENTITY(1,1) NOT NULL,
	[ProductName] [nvarchar](max) NULL,
	[ProductQuantity] [int] NOT NULL,
	[ProductCost] [int] NOT NULL,
 CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED 
(
	[ProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20200320063134_Createcodefirst', N'5.0.0-preview.2.20120.8')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20200320063406_CreateCompany', N'5.0.0-preview.2.20120.8')
GO
SET IDENTITY_INSERT [dbo].[Customers] ON 
GO
INSERT [dbo].[Customers] ([CusId], [CusFirstName], [CusLastName]) VALUES (1, N'Arpit', N'Deora')
GO
INSERT [dbo].[Customers] ([CusId], [CusFirstName], [CusLastName]) VALUES (2, N'Mohit', N'Kaushik')
GO
INSERT [dbo].[Customers] ([CusId], [CusFirstName], [CusLastName]) VALUES (3, N'Azeem', N'Faisel')
GO
INSERT [dbo].[Customers] ([CusId], [CusFirstName], [CusLastName]) VALUES (4, N'Vijay', N'Kumar')
GO
INSERT [dbo].[Customers] ([CusId], [CusFirstName], [CusLastName]) VALUES (5, N'Vishesh', N'Kapoor')
GO
INSERT [dbo].[Customers] ([CusId], [CusFirstName], [CusLastName]) VALUES (6, N'Shagun', N'Gupta')
GO
INSERT [dbo].[Customers] ([CusId], [CusFirstName], [CusLastName]) VALUES (7, N'Punita', N'Yadav')
GO
INSERT [dbo].[Customers] ([CusId], [CusFirstName], [CusLastName]) VALUES (8, N'Neha', N'Goel')
GO
INSERT [dbo].[Customers] ([CusId], [CusFirstName], [CusLastName]) VALUES (9, N'Sonal', N'Jha')
GO
INSERT [dbo].[Customers] ([CusId], [CusFirstName], [CusLastName]) VALUES (10, N'Abhishek', N'Srivastava')
GO
SET IDENTITY_INSERT [dbo].[Customers] OFF
GO
SET IDENTITY_INSERT [dbo].[Orders] ON 
GO
INSERT [dbo].[Orders] ([OrderId], [CusId], [ProductId], [OrderAddress]) VALUES (1, 1, 2, N'Delhi')
GO
INSERT [dbo].[Orders] ([OrderId], [CusId], [ProductId], [OrderAddress]) VALUES (2, 3, 6, N'Mumbai')
GO
INSERT [dbo].[Orders] ([OrderId], [CusId], [ProductId], [OrderAddress]) VALUES (3, 2, 7, N'Bihar')
GO
INSERT [dbo].[Orders] ([OrderId], [CusId], [ProductId], [OrderAddress]) VALUES (4, 5, 6, N'Kerela')
GO
INSERT [dbo].[Orders] ([OrderId], [CusId], [ProductId], [OrderAddress]) VALUES (5, 4, 4, N'Delhi')
GO
INSERT [dbo].[Orders] ([OrderId], [CusId], [ProductId], [OrderAddress]) VALUES (6, 6, 5, N'Mumbai')
GO
INSERT [dbo].[Orders] ([OrderId], [CusId], [ProductId], [OrderAddress]) VALUES (7, 1, 3, N'Jhansi')
GO
INSERT [dbo].[Orders] ([OrderId], [CusId], [ProductId], [OrderAddress]) VALUES (8, 2, 7, N'Kerela')
GO
INSERT [dbo].[Orders] ([OrderId], [CusId], [ProductId], [OrderAddress]) VALUES (9, 9, 1, N'Mumbai')
GO
INSERT [dbo].[Orders] ([OrderId], [CusId], [ProductId], [OrderAddress]) VALUES (10, 10, 7, N'Varanasi')
GO
INSERT [dbo].[Orders] ([OrderId], [CusId], [ProductId], [OrderAddress]) VALUES (11, 7, 3, N'Bangalore')
GO
INSERT [dbo].[Orders] ([OrderId], [CusId], [ProductId], [OrderAddress]) VALUES (12, 8, 2, N'Varanasi')
GO
INSERT [dbo].[Orders] ([OrderId], [CusId], [ProductId], [OrderAddress]) VALUES (13, 9, 5, N'Banglore')
GO
SET IDENTITY_INSERT [dbo].[Orders] OFF
GO
SET IDENTITY_INSERT [dbo].[Products] ON 
GO
INSERT [dbo].[Products] ([ProductId], [ProductName], [ProductQuantity], [ProductCost]) VALUES (1, N'Fridge', 2, 10000)
GO
INSERT [dbo].[Products] ([ProductId], [ProductName], [ProductQuantity], [ProductCost]) VALUES (2, N'TV', 4, 12000)
GO
INSERT [dbo].[Products] ([ProductId], [ProductName], [ProductQuantity], [ProductCost]) VALUES (3, N'Fan', 5, 10000)
GO
INSERT [dbo].[Products] ([ProductId], [ProductName], [ProductQuantity], [ProductCost]) VALUES (4, N'AC', 1, 10000)
GO
INSERT [dbo].[Products] ([ProductId], [ProductName], [ProductQuantity], [ProductCost]) VALUES (5, N'Cooler', 6, 10000)
GO
INSERT [dbo].[Products] ([ProductId], [ProductName], [ProductQuantity], [ProductCost]) VALUES (6, N'Sofa', 4, 10000)
GO
INSERT [dbo].[Products] ([ProductId], [ProductName], [ProductQuantity], [ProductCost]) VALUES (7, N'Bed', 2, 10000)
GO
SET IDENTITY_INSERT [dbo].[Products] OFF
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_Customers_CusId] FOREIGN KEY([CusId])
REFERENCES [dbo].[Customers] ([CusId])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_Customers_CusId]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_Products_ProductId] FOREIGN KEY([ProductId])
REFERENCES [dbo].[Products] ([ProductId])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_Products_ProductId]
GO
