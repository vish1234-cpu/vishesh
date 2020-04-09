create database MVC2
USE [MVC2]
GO
/****** Object:  Table [dbo].[Employee]    Script Date: 09-04-2020 17:09:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employee](
	[EmployeeId] [int] IDENTITY(1,1) NOT NULL,
	[EmployeeFirstName] [varchar](50) NOT NULL,
	[EmployeeLastName] [varchar](50) NOT NULL,
	[EmployeeAddress] [varchar](50) NOT NULL,
	[EmployeeGender] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[EmployeeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Employee] ON 
GO
INSERT [dbo].[Employee] ([EmployeeId], [EmployeeFirstName], [EmployeeLastName], [EmployeeAddress], [EmployeeGender]) VALUES (1, N'Vishesh', N'Kapoor', N'Delhi ', N'Male')
GO
INSERT [dbo].[Employee] ([EmployeeId], [EmployeeFirstName], [EmployeeLastName], [EmployeeAddress], [EmployeeGender]) VALUES (2, N'Azeem ', N'Faisel', N'Delhi ', N'Male')
GO
INSERT [dbo].[Employee] ([EmployeeId], [EmployeeFirstName], [EmployeeLastName], [EmployeeAddress], [EmployeeGender]) VALUES (3, N'Neha', N'Goel', N'Delhi ', N'Female')
GO
INSERT [dbo].[Employee] ([EmployeeId], [EmployeeFirstName], [EmployeeLastName], [EmployeeAddress], [EmployeeGender]) VALUES (4, N'Vijay', N'Kumar', N'Delhi ', N'Male')
GO
SET IDENTITY_INSERT [dbo].[Employee] OFF
GO
