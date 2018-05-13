USE [Stock]
GO

/****** Object:  Table [dbo].[Warehouse]    Script Date: 05/05/2018 20:03:40 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Warehouse](
	[Warehouse Name] [varbinary](150) NOT NULL,
	[Incharge] [varchar](50) NOT NULL,
	[Phone] [int] NOT NULL,
	[Address] [varchar](250) NULL,
	[Email] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Warehouse] PRIMARY KEY CLUSTERED 
(
	[Warehouse Name] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


