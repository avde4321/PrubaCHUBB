USE [dbpruebaschubb]
GO
/****** Object:  Table [dbo].[Catalogo]    Script Date: 29/5/2022 14:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Catalogo](
	[id_Catalogo] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[Tipo_tabla] [varchar](100) NULL,
	[id_tabla] [numeric](18, 0) NULL,
	[Descripcion] [varchar](100) NULL,
	[Fecha] [date] NULL,
	[Estado] [varchar](2) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_Catalogo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Persona]    Script Date: 29/5/2022 14:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Persona](
	[id_Persona] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[Identificacion] [varchar](15) NULL,
	[Nombre_cliente] [varchar](100) NULL,
	[Telefono] [numeric](10, 0) NULL,
	[Edad] [varchar](4) NULL,
	[Fecha] [date] NULL,
	[Estado] [varchar](2) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_Persona] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Persona_Producto]    Script Date: 29/5/2022 14:35:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Persona_Producto](
	[id_Persona_Producto] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[id_Persona] [numeric](18, 0) NULL,
	[id_Catalago_Producto] [numeric](18, 0) NULL,
	[Prima] [numeric](18, 0) NULL,
	[Fecha] [date] NULL,
	[Estado] [varchar](2) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_Persona_Producto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
