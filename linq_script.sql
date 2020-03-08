create database Linq_db 
USE [Linq_db ]
GO
/****** Object:  Table [dbo].[employee]    Script Date: 08-03-2020 14:02:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[employee](
	[emp_id] [int] IDENTITY(100,1) NOT NULL,
	[emp_name] [varchar](50) NOT NULL,
	[emp_address] [varchar](50) NOT NULL,
	[emp_salary] [money] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[emp_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[employee_department]    Script Date: 08-03-2020 14:02:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[employee_department](
	[dep_id] [int] IDENTITY(1,1) NOT NULL,
	[dep_name] [varchar](50) NOT NULL,
	[emp_id] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[dep_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[employee] ON 
GO
INSERT [dbo].[employee] ([emp_id], [emp_name], [emp_address], [emp_salary]) VALUES (100, N'Mohit', N'Delhi', 10000.0000)
GO
INSERT [dbo].[employee] ([emp_id], [emp_name], [emp_address], [emp_salary]) VALUES (101, N'Manish', N'Bengal', 30000.0000)
GO
INSERT [dbo].[employee] ([emp_id], [emp_name], [emp_address], [emp_salary]) VALUES (102, N'Ram', N'Haryana', 20000.0000)
GO
INSERT [dbo].[employee] ([emp_id], [emp_name], [emp_address], [emp_salary]) VALUES (103, N'Shyam', N'Delhi', 40000.0000)
GO
INSERT [dbo].[employee] ([emp_id], [emp_name], [emp_address], [emp_salary]) VALUES (104, N'Arpit', N'Vanarasi', 10000.0000)
GO
INSERT [dbo].[employee] ([emp_id], [emp_name], [emp_address], [emp_salary]) VALUES (105, N'Ankit', N'Haryana', 50000.0000)
GO
INSERT [dbo].[employee] ([emp_id], [emp_name], [emp_address], [emp_salary]) VALUES (106, N'Sakshi', N'Punjab', 30000.0000)
GO
INSERT [dbo].[employee] ([emp_id], [emp_name], [emp_address], [emp_salary]) VALUES (107, N'Sonam', N'Mumbai', 60000.0000)
GO
INSERT [dbo].[employee] ([emp_id], [emp_name], [emp_address], [emp_salary]) VALUES (108, N'Vaibhav', N'Madras', 70000.0000)
GO
INSERT [dbo].[employee] ([emp_id], [emp_name], [emp_address], [emp_salary]) VALUES (109, N'Hitesh', N'Bengal', 50000.0000)
GO
SET IDENTITY_INSERT [dbo].[employee] OFF
GO
SET IDENTITY_INSERT [dbo].[employee_department] ON 
GO
INSERT [dbo].[employee_department] ([dep_id], [dep_name], [emp_id]) VALUES (1, N'IT', 101)
GO
INSERT [dbo].[employee_department] ([dep_id], [dep_name], [emp_id]) VALUES (2, N'Fianace', 103)
GO
INSERT [dbo].[employee_department] ([dep_id], [dep_name], [emp_id]) VALUES (3, N'Sales', 102)
GO
INSERT [dbo].[employee_department] ([dep_id], [dep_name], [emp_id]) VALUES (4, N'Law', 105)
GO
INSERT [dbo].[employee_department] ([dep_id], [dep_name], [emp_id]) VALUES (5, N'Tax', 100)
GO
INSERT [dbo].[employee_department] ([dep_id], [dep_name], [emp_id]) VALUES (6, N'Admin', 107)
GO
SET IDENTITY_INSERT [dbo].[employee_department] OFF
GO
ALTER TABLE [dbo].[employee_department]  WITH CHECK ADD FOREIGN KEY([emp_id])
REFERENCES [dbo].[employee] ([emp_id])
GO
