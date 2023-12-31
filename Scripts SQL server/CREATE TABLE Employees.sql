--USE [Central]
--GO
/****** Object:  Table [dbo].[Employees]    Script Date: 14/12/2023 10:43:19 p. m. ******/
--DROP TABLE [dbo].[Employees]
--GO
/****** Object:  Table [dbo].[Employees]    Script Date: 14/12/2023 10:43:19 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employees](
	[EmployeeId] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[Salary] [decimal](10, 2) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[EmployeeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
--SET IDENTITY_INSERT [dbo].[Employees] ON 

--GO
--INSERT [dbo].[Employees] ([EmployeeId], [FirstName], [LastName], [Salary]) VALUES (1, N'John', N'Doe', CAST(70000.00 AS Decimal(10, 2)))
--GO
--INSERT [dbo].[Employees] ([EmployeeId], [FirstName], [LastName], [Salary]) VALUES (2, N'Jane', N'Smith', CAST(85000.00 AS Decimal(10, 2)))
--GO
--INSERT [dbo].[Employees] ([EmployeeId], [FirstName], [LastName], [Salary]) VALUES (3, N'Carlos', N'Gonzalez', CAST(65000.00 AS Decimal(10, 2)))
--GO
--INSERT [dbo].[Employees] ([EmployeeId], [FirstName], [LastName], [Salary]) VALUES (4, N'Lisa', N'Wong', CAST(72000.00 AS Decimal(10, 2)))
--GO
--INSERT [dbo].[Employees] ([EmployeeId], [FirstName], [LastName], [Salary]) VALUES (5, N'Ahmed', N'Khan', CAST(78000.00 AS Decimal(10, 2)))
--GO
--SET IDENTITY_INSERT [dbo].[Employees] OFF
--GO
