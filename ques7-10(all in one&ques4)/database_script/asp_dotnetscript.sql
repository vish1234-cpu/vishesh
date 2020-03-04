create database ASP_DOTNET
GO
USE [ASP_DOTNET]
GO
/****** Object:  Table [dbo].[student_data]    Script Date: 04-03-2020 21:26:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[student_data](
	[student_name] [varchar](50) NULL,
	[student_age] [int] NULL,
	[std_password] [varchar](50) NULL,
	[std_email] [varchar](50) NULL
) ON [PRIMARY]
GO
INSERT [dbo].[student_data] ([student_name], [student_age], [std_password], [std_email]) VALUES (N'vish', 13, N'123', N'vishesh@gmail.com')
GO
INSERT [dbo].[student_data] ([student_name], [student_age], [std_password], [std_email]) VALUES (N'vishesh kapoor ', 13, N'12345', N'vishesh@gmail.com')
GO
INSERT [dbo].[student_data] ([student_name], [student_age], [std_password], [std_email]) VALUES (N'vishesh kapoor ', 13, N'12345', N'vishesh@gmail.com')
GO
USE [master]
GO
ALTER DATABASE [ASP_DOTNET] SET  READ_WRITE 
GO
