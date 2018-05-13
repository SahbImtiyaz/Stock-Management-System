USE [Stock]
GO

/****** Object:  Table [dbo].[Products]    Script Date: 05/05/2018 20:03:22 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Products](
	[ProductCode] [int] NOT NULL,
	[ProductName] [varchar](50) NOT NULL,
	[ProductStatus] [bit] NOT NULL,
	[ProductPrice] [float] NOT NULL,
	[Date] [date] NOT NULL,
 CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED 
(
	[ProductCode] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


