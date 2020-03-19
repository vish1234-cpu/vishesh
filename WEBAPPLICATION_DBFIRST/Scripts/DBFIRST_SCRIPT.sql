USE [DBFIRSTNEW]
GO
/****** Object:  Table [dbo].[Customers]    Script Date: 19-03-2020 22:09:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customers](
	[Cus_Id] [int] IDENTITY(1,1) NOT NULL,
	[Cus_FirstName] [varchar](50) NULL,
	[Cus_LastName] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[Cus_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Orders]    Script Date: 19-03-2020 22:09:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[Order_id] [int] IDENTITY(1,1) NOT NULL,
	[Cus_Id] [int] NULL,
	[Product_Id] [int] NULL,
	[Order_Address] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[Order_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Products]    Script Date: 19-03-2020 22:09:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[Product_Id] [int] IDENTITY(1,1) NOT NULL,
	[Product_Name] [varchar](50) NULL,
	[Product_Quantity] [int] NULL,
	[Product_Cost] [money] NULL,
PRIMARY KEY CLUSTERED 
(
	[Product_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Customers] ON 
GO
INSERT [dbo].[Customers] ([Cus_Id], [Cus_FirstName], [Cus_LastName]) VALUES (1, N'Arpit', N'Deora')
GO
INSERT [dbo].[Customers] ([Cus_Id], [Cus_FirstName], [Cus_LastName]) VALUES (2, N'Mohit', N'Kaushik')
GO
INSERT [dbo].[Customers] ([Cus_Id], [Cus_FirstName], [Cus_LastName]) VALUES (3, N'Azeem', N'Faisel')
GO
INSERT [dbo].[Customers] ([Cus_Id], [Cus_FirstName], [Cus_LastName]) VALUES (4, N'Vijay', N'Kumar')
GO
INSERT [dbo].[Customers] ([Cus_Id], [Cus_FirstName], [Cus_LastName]) VALUES (5, N'Vishesh', N'Kapoor')
GO
INSERT [dbo].[Customers] ([Cus_Id], [Cus_FirstName], [Cus_LastName]) VALUES (6, N'Shagun', N'Gupta')
GO
INSERT [dbo].[Customers] ([Cus_Id], [Cus_FirstName], [Cus_LastName]) VALUES (7, N'Punita', N'Yadav')
GO
INSERT [dbo].[Customers] ([Cus_Id], [Cus_FirstName], [Cus_LastName]) VALUES (8, N'Neha', N'Goel')
GO
INSERT [dbo].[Customers] ([Cus_Id], [Cus_FirstName], [Cus_LastName]) VALUES (9, N'Sonal', N'Jha')
GO
SET IDENTITY_INSERT [dbo].[Customers] OFF
GO
SET IDENTITY_INSERT [dbo].[Orders] ON 
GO
INSERT [dbo].[Orders] ([Order_id], [Cus_Id], [Product_Id], [Order_Address]) VALUES (1, 1, 2, N'Delhi')
GO
INSERT [dbo].[Orders] ([Order_id], [Cus_Id], [Product_Id], [Order_Address]) VALUES (2, 3, 6, N'Mumbai')
GO
INSERT [dbo].[Orders] ([Order_id], [Cus_Id], [Product_Id], [Order_Address]) VALUES (3, 2, 7, N'Bihar')
GO
INSERT [dbo].[Orders] ([Order_id], [Cus_Id], [Product_Id], [Order_Address]) VALUES (4, 5, 6, N'Kerela')
GO
INSERT [dbo].[Orders] ([Order_id], [Cus_Id], [Product_Id], [Order_Address]) VALUES (5, 4, 4, N'Delhi')
GO
INSERT [dbo].[Orders] ([Order_id], [Cus_Id], [Product_Id], [Order_Address]) VALUES (6, 6, 5, N'Mumbai')
GO
INSERT [dbo].[Orders] ([Order_id], [Cus_Id], [Product_Id], [Order_Address]) VALUES (7, 1, 3, N'Jhansi')
GO
INSERT [dbo].[Orders] ([Order_id], [Cus_Id], [Product_Id], [Order_Address]) VALUES (8, 2, 7, N'Kerela')
GO
INSERT [dbo].[Orders] ([Order_id], [Cus_Id], [Product_Id], [Order_Address]) VALUES (9, 9, 1, N'Mumbai')
GO
INSERT [dbo].[Orders] ([Order_id], [Cus_Id], [Product_Id], [Order_Address]) VALUES (11, 7, 3, N'Bangalore')
GO
INSERT [dbo].[Orders] ([Order_id], [Cus_Id], [Product_Id], [Order_Address]) VALUES (12, 8, 2, N'Varanasi')
GO
INSERT [dbo].[Orders] ([Order_id], [Cus_Id], [Product_Id], [Order_Address]) VALUES (13, 9, 5, N'Banglore')
GO
SET IDENTITY_INSERT [dbo].[Orders] OFF
GO
SET IDENTITY_INSERT [dbo].[Products] ON 
GO
INSERT [dbo].[Products] ([Product_Id], [Product_Name], [Product_Quantity], [Product_Cost]) VALUES (1, N'Fridge', 2, 10000.0000)
GO
INSERT [dbo].[Products] ([Product_Id], [Product_Name], [Product_Quantity], [Product_Cost]) VALUES (2, N'TV', 4, 12000.0000)
GO
INSERT [dbo].[Products] ([Product_Id], [Product_Name], [Product_Quantity], [Product_Cost]) VALUES (3, N'Fan', 5, 10000.0000)
GO
INSERT [dbo].[Products] ([Product_Id], [Product_Name], [Product_Quantity], [Product_Cost]) VALUES (4, N'AC', 1, 10000.0000)
GO
INSERT [dbo].[Products] ([Product_Id], [Product_Name], [Product_Quantity], [Product_Cost]) VALUES (5, N'Cooler', 6, 10000.0000)
GO
INSERT [dbo].[Products] ([Product_Id], [Product_Name], [Product_Quantity], [Product_Cost]) VALUES (6, N'Sofa', 4, 10000.0000)
GO
INSERT [dbo].[Products] ([Product_Id], [Product_Name], [Product_Quantity], [Product_Cost]) VALUES (7, N'Bed', 2, 10000.0000)
GO
SET IDENTITY_INSERT [dbo].[Products] OFF
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD FOREIGN KEY([Cus_Id])
REFERENCES [dbo].[Customers] ([Cus_Id])
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD FOREIGN KEY([Product_Id])
REFERENCES [dbo].[Products] ([Product_Id])
GO
