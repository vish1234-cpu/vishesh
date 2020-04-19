create database AdvanceBlazor
USE [AdvanceBlazor]
GO
/****** Object:  Table [dbo].[Admins]    Script Date: 19-04-2020 15:28:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Admins](
	[AdminId] [int] IDENTITY(1,1) NOT NULL,
	[AdminName] [varchar](50) NOT NULL,
	[Passkey] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[AdminId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Menu]    Script Date: 19-04-2020 15:28:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Menu](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[MenuItem] [varchar](50) NOT NULL,
	[Reference] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Student]    Script Date: 19-04-2020 15:28:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Student](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[StudentName] [varchar](50) NOT NULL,
	[StudentGender] [varchar](50) NOT NULL,
	[StudentAddress] [varchar](50) NOT NULL,
	[StudentAge] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Admins] ON 
GO
INSERT [dbo].[Admins] ([AdminId], [AdminName], [Passkey]) VALUES (1, N'Vishesh Kapoor', N'vish123')
GO
SET IDENTITY_INSERT [dbo].[Admins] OFF
GO
SET IDENTITY_INSERT [dbo].[Menu] ON 
GO
INSERT [dbo].[Menu] ([Id], [MenuItem], [Reference]) VALUES (1, N'Home', N'home')
GO
INSERT [dbo].[Menu] ([Id], [MenuItem], [Reference]) VALUES (2, N'Student Page', N'studentpage')
GO
INSERT [dbo].[Menu] ([Id], [MenuItem], [Reference]) VALUES (3, N'Admin Page', N'adminpage')
GO
SET IDENTITY_INSERT [dbo].[Menu] OFF
GO
SET IDENTITY_INSERT [dbo].[Student] ON 
GO
INSERT [dbo].[Student] ([Id], [StudentName], [StudentGender], [StudentAddress], [StudentAge]) VALUES (1, N'Ram', N'Male', N'Delhi', 15)
GO
INSERT [dbo].[Student] ([Id], [StudentName], [StudentGender], [StudentAddress], [StudentAge]) VALUES (2, N'Shyam', N'Male', N'Mumbai', 13)
GO
INSERT [dbo].[Student] ([Id], [StudentName], [StudentGender], [StudentAddress], [StudentAge]) VALUES (3, N'Mohit', N'Male', N'Kerela', 15)
GO
INSERT [dbo].[Student] ([Id], [StudentName], [StudentGender], [StudentAddress], [StudentAge]) VALUES (4, N'Rahul', N'Male', N'Chennai', 17)
GO
INSERT [dbo].[Student] ([Id], [StudentName], [StudentGender], [StudentAddress], [StudentAge]) VALUES (7, N'Ashish ', N'Male', N'Noida ', 28)
GO
SET IDENTITY_INSERT [dbo].[Student] OFF
GO
