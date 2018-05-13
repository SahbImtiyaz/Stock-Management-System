USE [Stock]
GO

/****** Object:  Table [dbo].[Suppliers]    Script Date: 05/05/2018 20:03:35 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Suppliers](
	[Name] [varchar](50) NOT NULL,
	[Phone] [int] NOT NULL,
	[Email] [varchar](50) NULL,
	[Key Person] [varchar](50) NOT NULL,
	[Address] [varchar](150) NULL,
 CONSTRAINT [PK_Suppliers] PRIMARY KEY CLUSTERED 
(
	[Phone] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


