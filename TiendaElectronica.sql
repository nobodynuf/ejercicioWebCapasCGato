USE [TiendaElectronica]
GO
/****** Object:  Table [dbo].[Producto]    Script Date: 17-10-2017 19:12:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Producto](
	[codigo] [int] IDENTITY(1,1) NOT NULL,
	[marca] [nvarchar](50) NOT NULL,
	[modelo] [nvarchar](50) NOT NULL,
	[tipo] [nvarchar](50) NOT NULL,
	[precio] [int] NOT NULL,
 CONSTRAINT [PK_Producto] PRIMARY KEY CLUSTERED 
(
	[codigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 17-10-2017 19:12:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[usuario] [nvarchar](30) NOT NULL,
	[contra] [nvarchar](30) NOT NULL,
 CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED 
(
	[usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Venta]    Script Date: 17-10-2017 19:12:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Venta](
	[codigo] [int] IDENTITY(1,1) NOT NULL,
	[cantidad] [int] NOT NULL,
	[fecha] [date] NOT NULL,
	[cod_producto] [int] NOT NULL,
	[usr_venta] [nvarchar](30) NOT NULL,
 CONSTRAINT [PK_Venta] PRIMARY KEY CLUSTERED 
(
	[codigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[Venta]  WITH CHECK ADD  CONSTRAINT [FK_Venta_Producto1] FOREIGN KEY([cod_producto])
REFERENCES [dbo].[Producto] ([codigo])
GO
ALTER TABLE [dbo].[Venta] CHECK CONSTRAINT [FK_Venta_Producto1]
GO
ALTER TABLE [dbo].[Venta]  WITH CHECK ADD  CONSTRAINT [FK_Venta_Usuario1] FOREIGN KEY([usr_venta])
REFERENCES [dbo].[Usuario] ([usuario])
GO
ALTER TABLE [dbo].[Venta] CHECK CONSTRAINT [FK_Venta_Usuario1]
GO
