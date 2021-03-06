USE [dbpruebaschubb]
GO
SET IDENTITY_INSERT [dbo].[Catalogo] ON 

INSERT [dbo].[Catalogo] ([id_Catalogo], [Tipo_tabla], [id_tabla], [Descripcion], [Fecha], [Estado]) VALUES (CAST(1 AS Numeric(18, 0)), N'Tipo_Identificacion', CAST(1 AS Numeric(18, 0)), N'Cedula', CAST(N'2022-05-29' AS Date), N'A')
INSERT [dbo].[Catalogo] ([id_Catalogo], [Tipo_tabla], [id_tabla], [Descripcion], [Fecha], [Estado]) VALUES (CAST(2 AS Numeric(18, 0)), N'Tipo_Identificacion', CAST(2 AS Numeric(18, 0)), N'Ruc', CAST(N'2022-05-26' AS Date), N'A')
INSERT [dbo].[Catalogo] ([id_Catalogo], [Tipo_tabla], [id_tabla], [Descripcion], [Fecha], [Estado]) VALUES (CAST(3 AS Numeric(18, 0)), N'Tipo_Identificacion', CAST(3 AS Numeric(18, 0)), N'Pasaporte', CAST(N'2022-05-29' AS Date), N'A')
INSERT [dbo].[Catalogo] ([id_Catalogo], [Tipo_tabla], [id_tabla], [Descripcion], [Fecha], [Estado]) VALUES (CAST(4 AS Numeric(18, 0)), N'Tipo_Producto', CAST(1 AS Numeric(18, 0)), N'seguro Aduanero', CAST(N'2022-05-29' AS Date), N'A')
INSERT [dbo].[Catalogo] ([id_Catalogo], [Tipo_tabla], [id_tabla], [Descripcion], [Fecha], [Estado]) VALUES (CAST(5 AS Numeric(18, 0)), N'Tipo_Producto', CAST(2 AS Numeric(18, 0)), N'Seguro Automotriz', CAST(N'2022-05-29' AS Date), N'A')
INSERT [dbo].[Catalogo] ([id_Catalogo], [Tipo_tabla], [id_tabla], [Descripcion], [Fecha], [Estado]) VALUES (CAST(6 AS Numeric(18, 0)), N'Tipo_Producto', CAST(3 AS Numeric(18, 0)), N'Seguro Vivienda', CAST(N'2022-05-29' AS Date), N'A')
INSERT [dbo].[Catalogo] ([id_Catalogo], [Tipo_tabla], [id_tabla], [Descripcion], [Fecha], [Estado]) VALUES (CAST(7 AS Numeric(18, 0)), N'Tipo_Producto', CAST(4 AS Numeric(18, 0)), N'Seguro Vida', CAST(N'2022-05-29' AS Date), N'A')
INSERT [dbo].[Catalogo] ([id_Catalogo], [Tipo_tabla], [id_tabla], [Descripcion], [Fecha], [Estado]) VALUES (CAST(8 AS Numeric(18, 0)), N'Tipo_Producto', CAST(5 AS Numeric(18, 0)), N'Seguro Empresarial', CAST(N'2022-05-29' AS Date), N'A')
SET IDENTITY_INSERT [dbo].[Catalogo] OFF
SET IDENTITY_INSERT [dbo].[Persona] ON 

INSERT [dbo].[Persona] ([id_Persona], [Identificacion], [Nombre_cliente], [Telefono], [Edad], [Fecha], [Estado]) VALUES (CAST(1 AS Numeric(18, 0)), N'0923902225', N'Arturo Delgado', N'0956387541', N'27', CAST(N'2022-05-30' AS Date), N'I')
INSERT [dbo].[Persona] ([id_Persona], [Identificacion], [Nombre_cliente], [Telefono], [Edad], [Fecha], [Estado]) VALUES (CAST(2 AS Numeric(18, 0)), N'1202471098', N'Vicente Delgado ', N'0956342564', N'54', CAST(N'2022-05-31' AS Date), N'A')
INSERT [dbo].[Persona] ([id_Persona], [Identificacion], [Nombre_cliente], [Telefono], [Edad], [Fecha], [Estado]) VALUES (CAST(4 AS Numeric(18, 0)), N'1313504019', N'Anthony Castillo', N'2051755', N'22', CAST(N'2022-05-31' AS Date), N'A')
INSERT [dbo].[Persona] ([id_Persona], [Identificacion], [Nombre_cliente], [Telefono], [Edad], [Fecha], [Estado]) VALUES (CAST(5 AS Numeric(18, 0)), N'0924062482', N'Christian Campodoni', N'0965876354', N'32', CAST(N'2022-05-31' AS Date), N'A')
INSERT [dbo].[Persona] ([id_Persona], [Identificacion], [Nombre_cliente], [Telefono], [Edad], [Fecha], [Estado]) VALUES (CAST(6 AS Numeric(18, 0)), N'0923902217', N'Adalipza Delgado', N'0926874625', N'22', CAST(N'2022-05-31' AS Date), N'A')
INSERT [dbo].[Persona] ([id_Persona], [Identificacion], [Nombre_cliente], [Telefono], [Edad], [Fecha], [Estado]) VALUES (CAST(7 AS Numeric(18, 0)), N'0923902218', N'Cliente Prueba', N'0956874123', N'24', CAST(N'2022-05-31' AS Date), N'A')
INSERT [dbo].[Persona] ([id_Persona], [Identificacion], [Nombre_cliente], [Telefono], [Edad], [Fecha], [Estado]) VALUES (CAST(8 AS Numeric(18, 0)), N'0923902219', N'Cliente Prueba', N'0926874625', N'22', CAST(N'2022-05-31' AS Date), N'A')
INSERT [dbo].[Persona] ([id_Persona], [Identificacion], [Nombre_cliente], [Telefono], [Edad], [Fecha], [Estado]) VALUES (CAST(9 AS Numeric(18, 0)), N'0923902220', N'Cliente Prueba', N'0956874123', N'24', CAST(N'2022-05-31' AS Date), N'A')
SET IDENTITY_INSERT [dbo].[Persona] OFF
SET IDENTITY_INSERT [dbo].[Persona_Producto] ON 

INSERT [dbo].[Persona_Producto] ([id_Persona_Producto], [id_Persona], [id_Producto], [Prima], [Fecha], [Estado]) VALUES (CAST(1 AS Numeric(18, 0)), CAST(1 AS Numeric(18, 0)), N'SV01', CAST(5000 AS Numeric(18, 0)), CAST(N'2022-05-30' AS Date), N'A')
INSERT [dbo].[Persona_Producto] ([id_Persona_Producto], [id_Persona], [id_Producto], [Prima], [Fecha], [Estado]) VALUES (CAST(2 AS Numeric(18, 0)), CAST(1 AS Numeric(18, 0)), N'SV02', CAST(500 AS Numeric(18, 0)), CAST(N'2022-05-30' AS Date), N'A')
INSERT [dbo].[Persona_Producto] ([id_Persona_Producto], [id_Persona], [id_Producto], [Prima], [Fecha], [Estado]) VALUES (CAST(3 AS Numeric(18, 0)), CAST(2 AS Numeric(18, 0)), N'SA02', CAST(2000 AS Numeric(18, 0)), CAST(N'2022-05-31' AS Date), N'A')
INSERT [dbo].[Persona_Producto] ([id_Persona_Producto], [id_Persona], [id_Producto], [Prima], [Fecha], [Estado]) VALUES (CAST(4 AS Numeric(18, 0)), CAST(2 AS Numeric(18, 0)), N'SV02', CAST(500 AS Numeric(18, 0)), CAST(N'2022-05-31' AS Date), N'A')
INSERT [dbo].[Persona_Producto] ([id_Persona_Producto], [id_Persona], [id_Producto], [Prima], [Fecha], [Estado]) VALUES (CAST(5 AS Numeric(18, 0)), CAST(1 AS Numeric(18, 0)), N'SA02', CAST(700 AS Numeric(18, 0)), CAST(N'2022-05-31' AS Date), N'A')
INSERT [dbo].[Persona_Producto] ([id_Persona_Producto], [id_Persona], [id_Producto], [Prima], [Fecha], [Estado]) VALUES (CAST(7 AS Numeric(18, 0)), CAST(4 AS Numeric(18, 0)), N'SE01', CAST(500 AS Numeric(18, 0)), CAST(N'2022-05-31' AS Date), N'A')
INSERT [dbo].[Persona_Producto] ([id_Persona_Producto], [id_Persona], [id_Producto], [Prima], [Fecha], [Estado]) VALUES (CAST(8 AS Numeric(18, 0)), CAST(4 AS Numeric(18, 0)), N'SV01', CAST(2500 AS Numeric(18, 0)), CAST(N'2022-05-31' AS Date), N'A')
INSERT [dbo].[Persona_Producto] ([id_Persona_Producto], [id_Persona], [id_Producto], [Prima], [Fecha], [Estado]) VALUES (CAST(9 AS Numeric(18, 0)), CAST(4 AS Numeric(18, 0)), N'ABC132', CAST(900 AS Numeric(18, 0)), CAST(N'2022-05-31' AS Date), N'A')
INSERT [dbo].[Persona_Producto] ([id_Persona_Producto], [id_Persona], [id_Producto], [Prima], [Fecha], [Estado]) VALUES (CAST(10 AS Numeric(18, 0)), CAST(5 AS Numeric(18, 0)), N'SV02', CAST(5000 AS Numeric(18, 0)), CAST(N'2022-05-31' AS Date), N'A')
INSERT [dbo].[Persona_Producto] ([id_Persona_Producto], [id_Persona], [id_Producto], [Prima], [Fecha], [Estado]) VALUES (CAST(11 AS Numeric(18, 0)), CAST(5 AS Numeric(18, 0)), N'SA01', CAST(20000 AS Numeric(18, 0)), CAST(N'2022-05-31' AS Date), N'A')
INSERT [dbo].[Persona_Producto] ([id_Persona_Producto], [id_Persona], [id_Producto], [Prima], [Fecha], [Estado]) VALUES (CAST(12 AS Numeric(18, 0)), CAST(6 AS Numeric(18, 0)), N'SA01', CAST(500 AS Numeric(18, 0)), CAST(N'2022-05-31' AS Date), N'A')
INSERT [dbo].[Persona_Producto] ([id_Persona_Producto], [id_Persona], [id_Producto], [Prima], [Fecha], [Estado]) VALUES (CAST(13 AS Numeric(18, 0)), CAST(7 AS Numeric(18, 0)), N'SA02', CAST(600 AS Numeric(18, 0)), CAST(N'2022-05-31' AS Date), N'A')
INSERT [dbo].[Persona_Producto] ([id_Persona_Producto], [id_Persona], [id_Producto], [Prima], [Fecha], [Estado]) VALUES (CAST(14 AS Numeric(18, 0)), CAST(8 AS Numeric(18, 0)), N'SA01', CAST(500 AS Numeric(18, 0)), CAST(N'2022-05-31' AS Date), N'A')
INSERT [dbo].[Persona_Producto] ([id_Persona_Producto], [id_Persona], [id_Producto], [Prima], [Fecha], [Estado]) VALUES (CAST(15 AS Numeric(18, 0)), CAST(9 AS Numeric(18, 0)), N'SV02', CAST(600 AS Numeric(18, 0)), CAST(N'2022-05-31' AS Date), N'A')
SET IDENTITY_INSERT [dbo].[Persona_Producto] OFF
SET IDENTITY_INSERT [dbo].[Producto] ON 

INSERT [dbo].[Producto] ([Id_Producto], [Cod_Producto], [descripcion], [Fecha], [Estado]) VALUES (CAST(1 AS Numeric(18, 0)), N'SA01', N'seguro Aduanero', CAST(N'2022-05-30' AS Date), N'A')
INSERT [dbo].[Producto] ([Id_Producto], [Cod_Producto], [descripcion], [Fecha], [Estado]) VALUES (CAST(2 AS Numeric(18, 0)), N'SA02', N'Seguro Automotriz', CAST(N'2022-05-30' AS Date), N'A')
INSERT [dbo].[Producto] ([Id_Producto], [Cod_Producto], [descripcion], [Fecha], [Estado]) VALUES (CAST(3 AS Numeric(18, 0)), N'SV01', N'Seguro Vivienda', CAST(N'2022-05-30' AS Date), N'A')
INSERT [dbo].[Producto] ([Id_Producto], [Cod_Producto], [descripcion], [Fecha], [Estado]) VALUES (CAST(4 AS Numeric(18, 0)), N'SV02', N'Seguro Vivida', CAST(N'2022-05-30' AS Date), N'A')
INSERT [dbo].[Producto] ([Id_Producto], [Cod_Producto], [descripcion], [Fecha], [Estado]) VALUES (CAST(5 AS Numeric(18, 0)), N'SE01', N'Seguro Empresa', CAST(N'2022-05-31' AS Date), N'A')
INSERT [dbo].[Producto] ([Id_Producto], [Cod_Producto], [descripcion], [Fecha], [Estado]) VALUES (CAST(6 AS Numeric(18, 0)), N'ABC132', N'Seguros Electronicos', CAST(N'2022-05-31' AS Date), N'A')
INSERT [dbo].[Producto] ([Id_Producto], [Cod_Producto], [descripcion], [Fecha], [Estado]) VALUES (CAST(7 AS Numeric(18, 0)), N'ST01', N'Seguro Terceros', CAST(N'2022-05-31' AS Date), N'A')
SET IDENTITY_INSERT [dbo].[Producto] OFF
