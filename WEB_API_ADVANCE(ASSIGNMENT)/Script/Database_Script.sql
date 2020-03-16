create database WEB_API_ADVANCE 
USE [WEB_API_ADVANCE]
GO
/****** Object:  Table [dbo].[Employees]    Script Date: 16-03-2020 13:01:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employees]( 
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [varchar](50) NULL,
	[LastName] [varchar](50) NULL,
	[Gender] [varchar](50) NULL,
	[Salary] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Employees] ON 
GO
INSERT [dbo].[Employees] ([Id], [FirstName], [LastName], [Gender], [Salary]) VALUES (1, N'Manjulika', N'Tyagi', N'M', 30000)
GO
INSERT [dbo].[Employees] ([Id], [FirstName], [LastName], [Gender], [Salary]) VALUES (2, N'Mohit', N'Sethi', N'M', 23000)
GO
INSERT [dbo].[Employees] ([Id], [FirstName], [LastName], [Gender], [Salary]) VALUES (4, N'Shiva', N'Tagore', N'M', 66000)
GO
INSERT [dbo].[Employees] ([Id], [FirstName], [LastName], [Gender], [Salary]) VALUES (5, N'Manohar', N'Lal', N'M', 22000)
GO
INSERT [dbo].[Employees] ([Id], [FirstName], [LastName], [Gender], [Salary]) VALUES (6, N'Manish', N'TyagRaj', N'M', 69000)
GO
INSERT [dbo].[Employees] ([Id], [FirstName], [LastName], [Gender], [Salary]) VALUES (7, N'Manu', N'Singh', N'M', 28000)
GO
INSERT [dbo].[Employees] ([Id], [FirstName], [LastName], [Gender], [Salary]) VALUES (8, N'Vijay', N'Kumar', N'M', 34000)
GO
INSERT [dbo].[Employees] ([Id], [FirstName], [LastName], [Gender], [Salary]) VALUES (9, N'Vishesh', N'Kapoor', N'M', 29000)
GO
INSERT [dbo].[Employees] ([Id], [FirstName], [LastName], [Gender], [Salary]) VALUES (10, N'Vaibhav', N'Gupta', N'M', 26000)
GO
INSERT [dbo].[Employees] ([Id], [FirstName], [LastName], [Gender], [Salary]) VALUES (11, N'Ram', N'Kumar', N'M', 40000)
GO
SET IDENTITY_INSERT [dbo].[Employees] OFF
GO
USE [master]
GO
ALTER DATABASE [WEB_API_ADVANCE] SET  READ_WRITE 
GO
