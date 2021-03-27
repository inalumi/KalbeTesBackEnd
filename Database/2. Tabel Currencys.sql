USE [InvoiceDB]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Currencys](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Code] [varchar](40) NOT NULL,
	[Desc] [varchar](255) NOT NULL,
 CONSTRAINT [PK_Currencys_ID] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


