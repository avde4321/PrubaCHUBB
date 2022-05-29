USE [dbpruebaschubb]
GO
SET IDENTITY_INSERT [dbo].[Catalogo] ON 

INSERT [dbo].[Catalogo] ([id_Catalogo], [Tipo_tabla], [id_tabla], [Descripcion], [Fecha], [Estado]) VALUES (CAST(1 AS Numeric(18, 0)), N'Tipo_Identificacion', CAST(1 AS Numeric(18, 0)), N'Cedual', CAST(N'2022-05-29' AS Date), N'A')
INSERT [dbo].[Catalogo] ([id_Catalogo], [Tipo_tabla], [id_tabla], [Descripcion], [Fecha], [Estado]) VALUES (CAST(2 AS Numeric(18, 0)), N'Tipo_Identificacion', CAST(2 AS Numeric(18, 0)), N'Ruc', CAST(N'2022-05-26' AS Date), N'A')
INSERT [dbo].[Catalogo] ([id_Catalogo], [Tipo_tabla], [id_tabla], [Descripcion], [Fecha], [Estado]) VALUES (CAST(3 AS Numeric(18, 0)), N'Tipo_Identificacion', CAST(3 AS Numeric(18, 0)), N'Pasaporte', CAST(N'2022-05-29' AS Date), N'A')
INSERT [dbo].[Catalogo] ([id_Catalogo], [Tipo_tabla], [id_tabla], [Descripcion], [Fecha], [Estado]) VALUES (CAST(4 AS Numeric(18, 0)), N'Tipo_Producto', CAST(1 AS Numeric(18, 0)), N'seguro Aduanero', CAST(N'2022-05-29' AS Date), N'A')
INSERT [dbo].[Catalogo] ([id_Catalogo], [Tipo_tabla], [id_tabla], [Descripcion], [Fecha], [Estado]) VALUES (CAST(5 AS Numeric(18, 0)), N'Tipo_Producto', CAST(2 AS Numeric(18, 0)), N'Seguro Automotriz', CAST(N'2022-05-29' AS Date), N'A')
INSERT [dbo].[Catalogo] ([id_Catalogo], [Tipo_tabla], [id_tabla], [Descripcion], [Fecha], [Estado]) VALUES (CAST(6 AS Numeric(18, 0)), N'Tipo_Producto', CAST(3 AS Numeric(18, 0)), N'Seguro Vivienda', CAST(N'2022-05-29' AS Date), N'A')
INSERT [dbo].[Catalogo] ([id_Catalogo], [Tipo_tabla], [id_tabla], [Descripcion], [Fecha], [Estado]) VALUES (CAST(7 AS Numeric(18, 0)), N'Tipo_Producto', CAST(4 AS Numeric(18, 0)), N'Seguro Vida', CAST(N'2022-05-29' AS Date), N'A')
INSERT [dbo].[Catalogo] ([id_Catalogo], [Tipo_tabla], [id_tabla], [Descripcion], [Fecha], [Estado]) VALUES (CAST(8 AS Numeric(18, 0)), N'Tipo_Producto', CAST(5 AS Numeric(18, 0)), N'Seguro Empresarial', CAST(N'2022-05-29' AS Date), N'A')
SET IDENTITY_INSERT [dbo].[Catalogo] OFF
SET IDENTITY_INSERT [dbo].[Persona] ON 

INSERT [dbo].[Persona] ([id_Persona], [Identificacion], [Nombre_cliente], [Telefono], [Edad], [Fecha], [Estado]) VALUES (CAST(1 AS Numeric(18, 0)), N'092390225', N'Arturo Delgado', CAST(954138745 AS Numeric(10, 0)), N'27', CAST(N'2022-05-29' AS Date), N'A')
INSERT [dbo].[Persona] ([id_Persona], [Identificacion], [Nombre_cliente], [Telefono], [Edad], [Fecha], [Estado]) VALUES (CAST(2 AS Numeric(18, 0)), N'0923902217', N'Adalipza Delgado', CAST(987635421 AS Numeric(10, 0)), N'22', CAST(N'2022-05-29' AS Date), N'A')
INSERT [dbo].[Persona] ([id_Persona], [Identificacion], [Nombre_cliente], [Telefono], [Edad], [Fecha], [Estado]) VALUES (CAST(3 AS Numeric(18, 0)), N'0923902220', N'Cliente Prueba', CAST(953658745 AS Numeric(10, 0)), N'27', CAST(N'2022-05-29' AS Date), N'A')
INSERT [dbo].[Persona] ([id_Persona], [Identificacion], [Nombre_cliente], [Telefono], [Edad], [Fecha], [Estado]) VALUES (CAST(4 AS Numeric(18, 0)), N'0923902222', N'Cliente preuba', CAST(923577652 AS Numeric(10, 0)), N'27', CAST(N'2022-05-29' AS Date), N'A')
SET IDENTITY_INSERT [dbo].[Persona] OFF
SET IDENTITY_INSERT [dbo].[Persona_Producto] ON 

INSERT [dbo].[Persona_Producto] ([id_Persona_Producto], [id_Persona], [id_Catalago_Producto], [Prima], [Fecha], [Estado]) VALUES (CAST(1 AS Numeric(18, 0)), CAST(1 AS Numeric(18, 0)), CAST(4 AS Numeric(18, 0)), CAST(500 AS Numeric(18, 0)), CAST(N'2022-05-29' AS Date), N'A')
INSERT [dbo].[Persona_Producto] ([id_Persona_Producto], [id_Persona], [id_Catalago_Producto], [Prima], [Fecha], [Estado]) VALUES (CAST(2 AS Numeric(18, 0)), CAST(2 AS Numeric(18, 0)), CAST(3 AS Numeric(18, 0)), CAST(4000 AS Numeric(18, 0)), CAST(N'2022-05-29' AS Date), N'A')
INSERT [dbo].[Persona_Producto] ([id_Persona_Producto], [id_Persona], [id_Catalago_Producto], [Prima], [Fecha], [Estado]) VALUES (CAST(3 AS Numeric(18, 0)), CAST(3 AS Numeric(18, 0)), CAST(1 AS Numeric(18, 0)), CAST(500 AS Numeric(18, 0)), CAST(N'2022-05-29' AS Date), N'A')
INSERT [dbo].[Persona_Producto] ([id_Persona_Producto], [id_Persona], [id_Catalago_Producto], [Prima], [Fecha], [Estado]) VALUES (CAST(4 AS Numeric(18, 0)), CAST(4 AS Numeric(18, 0)), CAST(4 AS Numeric(18, 0)), CAST(500 AS Numeric(18, 0)), CAST(N'2022-05-29' AS Date), N'A')
INSERT [dbo].[Persona_Producto] ([id_Persona_Producto], [id_Persona], [id_Catalago_Producto], [Prima], [Fecha], [Estado]) VALUES (CAST(5 AS Numeric(18, 0)), CAST(1 AS Numeric(18, 0)), CAST(3 AS Numeric(18, 0)), CAST(5000 AS Numeric(18, 0)), CAST(N'2022-05-29' AS Date), N'A')
INSERT [dbo].[Persona_Producto] ([id_Persona_Producto], [id_Persona], [id_Catalago_Producto], [Prima], [Fecha], [Estado]) VALUES (CAST(6 AS Numeric(18, 0)), CAST(2 AS Numeric(18, 0)), CAST(5 AS Numeric(18, 0)), CAST(4302 AS Numeric(18, 0)), CAST(N'2022-05-29' AS Date), N'A')
SET IDENTITY_INSERT [dbo].[Persona_Producto] OFF
