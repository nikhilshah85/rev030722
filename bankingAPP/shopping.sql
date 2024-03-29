USE [shoppingAPPMVC]
GO
/****** Object:  Table [dbo].[customers]    Script Date: 3/31/2022 12:27:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[customers](
	[cId] [int] NOT NULL,
	[cName] [varchar](20) NULL,
	[cCity] [varchar](20) NULL,
	[cWalletBalance] [int] NULL,
	[cIsActive] [bit] NULL,
	[cCustomerType] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[cId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EmployeeInfo]    Script Date: 3/31/2022 12:27:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EmployeeInfo](
	[empNo] [int] NOT NULL,
	[empName] [varchar](20) NULL,
	[empDesignation] [varchar](20) NULL,
	[empSalary] [int] NULL,
	[empDept] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[empNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[products]    Script Date: 3/31/2022 12:27:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[products](
	[pId] [int] NOT NULL,
	[pName] [varchar](20) NULL,
	[pCategory] [varchar](20) NULL,
	[pPrice] [int] NULL,
	[pIsInStock] [bit] NULL,
	[pDiscount] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[pId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[EmployeeInfo]  WITH CHECK ADD  CONSTRAINT [fk_empDept] FOREIGN KEY([empDept])
REFERENCES [dbo].[deptInfo] ([deptNo])
GO
ALTER TABLE [dbo].[EmployeeInfo] CHECK CONSTRAINT [fk_empDept]
GO
ALTER TABLE [dbo].[customers]  WITH CHECK ADD  CONSTRAINT [chk_Balance] CHECK  (([cWalletBalance]>=(1000) AND [cWalletBalance]<=(15000)))
GO
ALTER TABLE [dbo].[customers] CHECK CONSTRAINT [chk_Balance]
GO
ALTER TABLE [dbo].[EmployeeInfo]  WITH CHECK ADD  CONSTRAINT [chk_designation] CHECK  (([empDesignation]='HR' OR [empDesignation]='Accounts' OR [empDesignation]='Developer'))
GO
ALTER TABLE [dbo].[EmployeeInfo] CHECK CONSTRAINT [chk_designation]
GO
