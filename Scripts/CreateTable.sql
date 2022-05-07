USE [DB_PracticaTecnica]
GO

/****** Object:  Table [dbo].[CustomerTable]    Script Date: 07/05/2022 02:28:44 p. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[CustomerTable](
	[Id] [uniqueidentifier] NOT NULL,
	[Name] [varchar](100) NOT NULL,
	[PhoneNumber] [varchar](100) NULL,
	[Email] [varchar](200) NOT NULL,
	[Notes] [varchar](1000) NULL,
	[State] [bit] NOT NULL,
	[RegisterNumber] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_UsersTable] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[CustomerTable] ADD  CONSTRAINT [DF_UsersTable_Id]  DEFAULT (newid()) FOR [Id]
GO


