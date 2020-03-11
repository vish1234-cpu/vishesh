use database [Linq_db ] 
USE [Linq_db ]
GO
/****** Object:  Table [dbo].[employee]    Script Date: 11-03-2020 17:17:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[employee](
	[emp_id] [int] IDENTITY(100,1) NOT NULL,
	[emp_name] [varchar](50) NOT NULL,
	[emp_address] [varchar](50) NOT NULL,
	[emp_salary] [money] NOT NULL,
	[emp_job] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[emp_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[employee] ON 
GO
INSERT [dbo].[employee] ([emp_id], [emp_name], [emp_address], [emp_salary], [emp_job]) VALUES (100, N'Mohit', N'Delhi', 10000.0000, NULL)
GO
INSERT [dbo].[employee] ([emp_id], [emp_name], [emp_address], [emp_salary], [emp_job]) VALUES (101, N'Majid', N'Jhilmil', 30000.0000, NULL)
GO
INSERT [dbo].[employee] ([emp_id], [emp_name], [emp_address], [emp_salary], [emp_job]) VALUES (103, N'Shyam', N'Delhi', 40000.0000, NULL)
GO
INSERT [dbo].[employee] ([emp_id], [emp_name], [emp_address], [emp_salary], [emp_job]) VALUES (104, N'Arpit', N'Vanarasi', 10000.0000, NULL)
GO
INSERT [dbo].[employee] ([emp_id], [emp_name], [emp_address], [emp_salary], [emp_job]) VALUES (105, N'Ankit', N'Haryana', 50000.0000, NULL)
GO
INSERT [dbo].[employee] ([emp_id], [emp_name], [emp_address], [emp_salary], [emp_job]) VALUES (106, N'Sakshi', N'Punjab', 30000.0000, NULL)
GO
INSERT [dbo].[employee] ([emp_id], [emp_name], [emp_address], [emp_salary], [emp_job]) VALUES (107, N'Sonam', N'Mumbai', 60000.0000, NULL)
GO
INSERT [dbo].[employee] ([emp_id], [emp_name], [emp_address], [emp_salary], [emp_job]) VALUES (108, N'Vaibhav', N'Madras', 70000.0000, NULL)
GO
INSERT [dbo].[employee] ([emp_id], [emp_name], [emp_address], [emp_salary], [emp_job]) VALUES (109, N'Hitesh', N'Bengal', 50000.0000, NULL)
GO
INSERT [dbo].[employee] ([emp_id], [emp_name], [emp_address], [emp_salary], [emp_job]) VALUES (110, N'Rajesh', N'Kerela', 40000.0000, NULL)
GO
INSERT [dbo].[employee] ([emp_id], [emp_name], [emp_address], [emp_salary], [emp_job]) VALUES (111, N'Rajesh', N'Kerela', 40000.0000, NULL)
GO
SET IDENTITY_INSERT [dbo].[employee] OFF
GO

