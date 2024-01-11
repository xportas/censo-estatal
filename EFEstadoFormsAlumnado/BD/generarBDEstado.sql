Create DataBase Estado
Go

USE [Estado]
GO
/****** Object:  Table [dbo].[Localidades]  ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Localidades](
	[Id] [int] NOT NULL,
	[Nombre] [nvarchar](30) NOT NULL,
	[IdProv] [nvarchar](2) NOT NULL,
	[NumHab] [int] NULL,
 CONSTRAINT [PK_Localidades] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Provincias]    ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Provincias](
	[Id] [nvarchar](2) NOT NULL,
	[Nombre] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK_Provincias] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Localidades]  WITH CHECK ADD  CONSTRAINT [FK_Localidades_Provincias] FOREIGN KEY([IdProv])
REFERENCES [dbo].[Provincias] ([Id])
GO
ALTER TABLE [dbo].[Localidades] CHECK CONSTRAINT [FK_Localidades_Provincias]
GO
