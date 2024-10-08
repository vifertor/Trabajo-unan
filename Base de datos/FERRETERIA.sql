USE [Ferreteria]
GO
/****** Object:  Table [dbo].[Acabados]    Script Date: 25/8/2024 23:52:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Acabados](
	[ID_Acabado] [int] IDENTITY(1,1) NOT NULL,
	[Name_Acabados] [nvarchar](100) NOT NULL,
	[Estado] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_Acabado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Categorias]    Script Date: 25/8/2024 23:52:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categorias](
	[ID_Categoria] [int] IDENTITY(1,1) NOT NULL,
	[Name_Categoria] [nvarchar](100) NOT NULL,
	[Estado] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_Categoria] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Colores]    Script Date: 25/8/2024 23:52:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Colores](
	[ID_Colores] [int] IDENTITY(1,1) NOT NULL,
	[Name_Colores] [nvarchar](100) NOT NULL,
	[Estado] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_Colores] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Compras]    Script Date: 25/8/2024 23:52:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Compras](
	[ID_Numero_Compra] [int] IDENTITY(1,1) NOT NULL,
	[Fecha] [datetime] NOT NULL,
	[ID_Proveedor] [int] NOT NULL,
	[ID_Empleado] [int] NOT NULL,
	[Observaciones] [nvarchar](255) NULL,
	[Sub_Total] [decimal](18, 2) NOT NULL,
	[Total] [decimal](18, 2) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_Numero_Compra] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Diametros]    Script Date: 25/8/2024 23:52:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Diametros](
	[ID_Diametros] [int] IDENTITY(1,1) NOT NULL,
	[Name_Diametro] [nvarchar](100) NOT NULL,
	[Estado] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_Diametros] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Empleados]    Script Date: 25/8/2024 23:52:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Empleados](
	[ID_Empleados] [int] IDENTITY(1,1) NOT NULL,
	[Name_Empleados] [nvarchar](100) NOT NULL,
	[Apellido_Empleado] [nvarchar](100) NOT NULL,
	[segundoApellido_Empleado] [nvarchar](100) NULL,
	[Detalle_Empleado] [nvarchar](255) NULL,
	[Estado] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_Empleados] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Inventario]    Script Date: 25/8/2024 23:52:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Inventario](
	[ID_Inventario] [int] IDENTITY(1,1) NOT NULL,
	[ID_Producto] [int] NULL,
	[ID_Categoria] [int] NULL,
	[ID_Marca] [int] NULL,
	[ID_Modelos] [int] NULL,
	[ID_Tipos] [int] NULL,
	[ID_Colores] [int] NULL,
	[ID_Diametros] [int] NULL,
	[ID_Peso] [int] NULL,
	[ID_Material] [int] NULL,
	[ID_Acabados] [int] NULL,
	[Cantidad_Articulo] [int] NULL,
	[Precio_Unidad] [decimal](18, 2) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_Inventario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Marcas]    Script Date: 25/8/2024 23:52:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Marcas](
	[ID_Marca] [int] IDENTITY(1,1) NOT NULL,
	[Name_Marca] [nvarchar](100) NOT NULL,
	[Estado] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_Marca] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Materiales]    Script Date: 25/8/2024 23:52:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Materiales](
	[ID_Material] [int] IDENTITY(1,1) NOT NULL,
	[Name_Material] [nvarchar](100) NOT NULL,
	[Estado] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_Material] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Modelos]    Script Date: 25/8/2024 23:52:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Modelos](
	[ID_Modelos] [int] IDENTITY(1,1) NOT NULL,
	[Name_Modelos] [nvarchar](100) NOT NULL,
	[Estado] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_Modelos] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pesos]    Script Date: 25/8/2024 23:52:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pesos](
	[ID_Peso] [int] IDENTITY(1,1) NOT NULL,
	[Name_Peso] [nvarchar](100) NOT NULL,
	[Libras] [decimal](10, 2) NOT NULL,
	[Detalles_Peso] [nvarchar](255) NULL,
	[Estado] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_Peso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Productos]    Script Date: 25/8/2024 23:52:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Productos](
	[ID_Producto] [int] IDENTITY(1,1) NOT NULL,
	[Name_Producto] [nvarchar](100) NOT NULL,
	[Estado] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_Producto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Proveedor]    Script Date: 25/8/2024 23:52:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Proveedor](
	[ID_Proveedor] [int] IDENTITY(1,1) NOT NULL,
	[Name_Proveedor] [nvarchar](100) NOT NULL,
	[Nombre_Encargado] [nvarchar](100) NULL,
	[Apellido_Encargado] [nvarchar](100) NULL,
	[segundoApellido_Encargado] [nvarchar](100) NULL,
	[Numero_Cell] [nvarchar](20) NULL,
	[Gmail] [nvarchar](100) NULL,
	[Estado] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_Proveedor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tipos]    Script Date: 25/8/2024 23:52:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tipos](
	[ID_Tipos] [int] IDENTITY(1,1) NOT NULL,
	[Name_Tipo] [nvarchar](100) NOT NULL,
	[Estado] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_Tipos] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Acabados] ON 

INSERT [dbo].[Acabados] ([ID_Acabado], [Name_Acabados], [Estado]) VALUES (1, N'Brillante', 0)
INSERT [dbo].[Acabados] ([ID_Acabado], [Name_Acabados], [Estado]) VALUES (2, N'Mateds', 1)
INSERT [dbo].[Acabados] ([ID_Acabado], [Name_Acabados], [Estado]) VALUES (3, N'dsd', 0)
SET IDENTITY_INSERT [dbo].[Acabados] OFF
GO
SET IDENTITY_INSERT [dbo].[Categorias] ON 

INSERT [dbo].[Categorias] ([ID_Categoria], [Name_Categoria], [Estado]) VALUES (1, N'Pinturas', 0)
INSERT [dbo].[Categorias] ([ID_Categoria], [Name_Categoria], [Estado]) VALUES (2, N'lll', 1)
INSERT [dbo].[Categorias] ([ID_Categoria], [Name_Categoria], [Estado]) VALUES (3, N'vfgg', 0)
INSERT [dbo].[Categorias] ([ID_Categoria], [Name_Categoria], [Estado]) VALUES (4, N'sggg', 1)
SET IDENTITY_INSERT [dbo].[Categorias] OFF
GO
SET IDENTITY_INSERT [dbo].[Colores] ON 

INSERT [dbo].[Colores] ([ID_Colores], [Name_Colores], [Estado]) VALUES (1, N'HG', 1)
INSERT [dbo].[Colores] ([ID_Colores], [Name_Colores], [Estado]) VALUES (2, N'fd', 0)
INSERT [dbo].[Colores] ([ID_Colores], [Name_Colores], [Estado]) VALUES (3, N'gggf', 0)
INSERT [dbo].[Colores] ([ID_Colores], [Name_Colores], [Estado]) VALUES (4, N'dcvb', 0)
INSERT [dbo].[Colores] ([ID_Colores], [Name_Colores], [Estado]) VALUES (5, N'BHJU', 0)
INSERT [dbo].[Colores] ([ID_Colores], [Name_Colores], [Estado]) VALUES (6, N'5555', 0)
SET IDENTITY_INSERT [dbo].[Colores] OFF
GO
SET IDENTITY_INSERT [dbo].[Diametros] ON 

INSERT [dbo].[Diametros] ([ID_Diametros], [Name_Diametro], [Estado]) VALUES (1, N'12 mm', 1)
INSERT [dbo].[Diametros] ([ID_Diametros], [Name_Diametro], [Estado]) VALUES (2, N'yyy', 1)
INSERT [dbo].[Diametros] ([ID_Diametros], [Name_Diametro], [Estado]) VALUES (3, N'jhhh', 0)
SET IDENTITY_INSERT [dbo].[Diametros] OFF
GO
SET IDENTITY_INSERT [dbo].[Inventario] ON 

INSERT [dbo].[Inventario] ([ID_Inventario], [ID_Producto], [ID_Categoria], [ID_Marca], [ID_Modelos], [ID_Tipos], [ID_Colores], [ID_Diametros], [ID_Peso], [ID_Material], [ID_Acabados], [Cantidad_Articulo], [Precio_Unidad]) VALUES (1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 100, CAST(25.50 AS Decimal(18, 2)))
SET IDENTITY_INSERT [dbo].[Inventario] OFF
GO
SET IDENTITY_INSERT [dbo].[Marcas] ON 

INSERT [dbo].[Marcas] ([ID_Marca], [Name_Marca], [Estado]) VALUES (1, N'MarcaYX', 1)
INSERT [dbo].[Marcas] ([ID_Marca], [Name_Marca], [Estado]) VALUES (2, N'ASA', 1)
INSERT [dbo].[Marcas] ([ID_Marca], [Name_Marca], [Estado]) VALUES (3, N'FDF', 0)
INSERT [dbo].[Marcas] ([ID_Marca], [Name_Marca], [Estado]) VALUES (4, N'FDSDF', 1)
INSERT [dbo].[Marcas] ([ID_Marca], [Name_Marca], [Estado]) VALUES (5, N'DSDSDS', 1)
INSERT [dbo].[Marcas] ([ID_Marca], [Name_Marca], [Estado]) VALUES (6, N'ASA', 1)
SET IDENTITY_INSERT [dbo].[Marcas] OFF
GO
SET IDENTITY_INSERT [dbo].[Materiales] ON 

INSERT [dbo].[Materiales] ([ID_Material], [Name_Material], [Estado]) VALUES (1, N'Aluminio', 1)
SET IDENTITY_INSERT [dbo].[Materiales] OFF
GO
SET IDENTITY_INSERT [dbo].[Modelos] ON 

INSERT [dbo].[Modelos] ([ID_Modelos], [Name_Modelos], [Estado]) VALUES (1, N'ModeloY', 1)
INSERT [dbo].[Modelos] ([ID_Modelos], [Name_Modelos], [Estado]) VALUES (2, N'4e', 0)
INSERT [dbo].[Modelos] ([ID_Modelos], [Name_Modelos], [Estado]) VALUES (3, N'sdsd', 1)
INSERT [dbo].[Modelos] ([ID_Modelos], [Name_Modelos], [Estado]) VALUES (4, N'sd', 1)
INSERT [dbo].[Modelos] ([ID_Modelos], [Name_Modelos], [Estado]) VALUES (5, N'fddffd', 1)
INSERT [dbo].[Modelos] ([ID_Modelos], [Name_Modelos], [Estado]) VALUES (6, N'as', 0)
SET IDENTITY_INSERT [dbo].[Modelos] OFF
GO
SET IDENTITY_INSERT [dbo].[Pesos] ON 

INSERT [dbo].[Pesos] ([ID_Peso], [Name_Peso], [Libras], [Detalles_Peso], [Estado]) VALUES (1, N'Saco', CAST(50.00 AS Decimal(10, 2)), N'Saco para transporte', 0)
INSERT [dbo].[Pesos] ([ID_Peso], [Name_Peso], [Libras], [Detalles_Peso], [Estado]) VALUES (2, N'asa', CAST(23.00 AS Decimal(10, 2)), N'r444', 1)
INSERT [dbo].[Pesos] ([ID_Peso], [Name_Peso], [Libras], [Detalles_Peso], [Estado]) VALUES (3, N'asa', CAST(2.00 AS Decimal(10, 2)), N'd', 1)
SET IDENTITY_INSERT [dbo].[Pesos] OFF
GO
SET IDENTITY_INSERT [dbo].[Productos] ON 

INSERT [dbo].[Productos] ([ID_Producto], [Name_Producto], [Estado]) VALUES (1, N'isaias', 1)
INSERT [dbo].[Productos] ([ID_Producto], [Name_Producto], [Estado]) VALUES (2, N'Fernando', 1)
INSERT [dbo].[Productos] ([ID_Producto], [Name_Producto], [Estado]) VALUES (3, N'FERNANDO', 1)
INSERT [dbo].[Productos] ([ID_Producto], [Name_Producto], [Estado]) VALUES (4, N'SASAS', 0)
INSERT [dbo].[Productos] ([ID_Producto], [Name_Producto], [Estado]) VALUES (5, N'hhhfgf', 1)
INSERT [dbo].[Productos] ([ID_Producto], [Name_Producto], [Estado]) VALUES (6, N'', 0)
INSERT [dbo].[Productos] ([ID_Producto], [Name_Producto], [Estado]) VALUES (7, N'dsdsd', 0)
INSERT [dbo].[Productos] ([ID_Producto], [Name_Producto], [Estado]) VALUES (8, N'df', 1)
INSERT [dbo].[Productos] ([ID_Producto], [Name_Producto], [Estado]) VALUES (9, N'fff', 0)
INSERT [dbo].[Productos] ([ID_Producto], [Name_Producto], [Estado]) VALUES (10, N'dsads', 0)
INSERT [dbo].[Productos] ([ID_Producto], [Name_Producto], [Estado]) VALUES (11, N'', 0)
SET IDENTITY_INSERT [dbo].[Productos] OFF
GO
SET IDENTITY_INSERT [dbo].[Tipos] ON 

INSERT [dbo].[Tipos] ([ID_Tipos], [Name_Tipo], [Estado]) VALUES (1, N'Tipo B', 1)
SET IDENTITY_INSERT [dbo].[Tipos] OFF
GO
ALTER TABLE [dbo].[Compras]  WITH CHECK ADD FOREIGN KEY([ID_Empleado])
REFERENCES [dbo].[Empleados] ([ID_Empleados])
GO
ALTER TABLE [dbo].[Compras]  WITH CHECK ADD FOREIGN KEY([ID_Proveedor])
REFERENCES [dbo].[Proveedor] ([ID_Proveedor])
GO
ALTER TABLE [dbo].[Inventario]  WITH CHECK ADD FOREIGN KEY([ID_Acabados])
REFERENCES [dbo].[Acabados] ([ID_Acabado])
GO
ALTER TABLE [dbo].[Inventario]  WITH CHECK ADD FOREIGN KEY([ID_Categoria])
REFERENCES [dbo].[Categorias] ([ID_Categoria])
GO
ALTER TABLE [dbo].[Inventario]  WITH CHECK ADD FOREIGN KEY([ID_Colores])
REFERENCES [dbo].[Colores] ([ID_Colores])
GO
ALTER TABLE [dbo].[Inventario]  WITH CHECK ADD FOREIGN KEY([ID_Diametros])
REFERENCES [dbo].[Diametros] ([ID_Diametros])
GO
ALTER TABLE [dbo].[Inventario]  WITH CHECK ADD FOREIGN KEY([ID_Marca])
REFERENCES [dbo].[Marcas] ([ID_Marca])
GO
ALTER TABLE [dbo].[Inventario]  WITH CHECK ADD FOREIGN KEY([ID_Material])
REFERENCES [dbo].[Materiales] ([ID_Material])
GO
ALTER TABLE [dbo].[Inventario]  WITH CHECK ADD FOREIGN KEY([ID_Modelos])
REFERENCES [dbo].[Modelos] ([ID_Modelos])
GO
ALTER TABLE [dbo].[Inventario]  WITH CHECK ADD FOREIGN KEY([ID_Peso])
REFERENCES [dbo].[Pesos] ([ID_Peso])
GO
ALTER TABLE [dbo].[Inventario]  WITH CHECK ADD FOREIGN KEY([ID_Producto])
REFERENCES [dbo].[Productos] ([ID_Producto])
GO
ALTER TABLE [dbo].[Inventario]  WITH CHECK ADD FOREIGN KEY([ID_Tipos])
REFERENCES [dbo].[Tipos] ([ID_Tipos])
GO
/****** Object:  StoredProcedure [dbo].[listaracabados]    Script Date: 25/8/2024 23:52:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Procedimiento para listar acabados
CREATE PROCEDURE [dbo].[listaracabados]
AS
BEGIN
    SELECT ID_Acabado, Name_Acabados, Estado
    FROM Acabados
    ORDER BY Name_Acabados ASC;
END;
GO
/****** Object:  StoredProcedure [dbo].[listarcategorias]    Script Date: 25/8/2024 23:52:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Procedimiento para listar categorías
CREATE PROCEDURE [dbo].[listarcategorias]
AS
BEGIN
    SELECT ID_Categoria, Name_Categoria, Estado
    FROM Categorias
    ORDER BY Name_Categoria ASC;
END;
GO
/****** Object:  StoredProcedure [dbo].[listarcolores]    Script Date: 25/8/2024 23:52:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Procedimiento para listar colores
CREATE PROCEDURE [dbo].[listarcolores]
AS
BEGIN
    SELECT ID_Colores, Name_Colores, Estado
    FROM Colores
    ORDER BY Name_Colores ASC;
END;
GO
/****** Object:  StoredProcedure [dbo].[listardiametros]    Script Date: 25/8/2024 23:52:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Procedimiento para listar diámetros
CREATE PROCEDURE [dbo].[listardiametros]
AS
BEGIN
    SELECT ID_Diametros, Name_Diametro, Estado
    FROM Diametros
    ORDER BY Name_Diametro ASC;
END;
GO
/****** Object:  StoredProcedure [dbo].[listarmarcas]    Script Date: 25/8/2024 23:52:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Procedimiento para listar marcas
CREATE PROCEDURE [dbo].[listarmarcas]
AS
BEGIN
    SELECT ID_Marca, Name_Marca, Estado
    FROM Marcas
    ORDER BY Name_Marca ASC;
END;
GO
/****** Object:  StoredProcedure [dbo].[listarmateriales]    Script Date: 25/8/2024 23:52:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Procedimiento para listar materiales
CREATE PROCEDURE [dbo].[listarmateriales]
AS
BEGIN
    SELECT ID_Material, Name_Material, Estado
    FROM Materiales
    ORDER BY Name_Material ASC;
END;
GO
/****** Object:  StoredProcedure [dbo].[listarmodelos]    Script Date: 25/8/2024 23:52:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Procedimiento para listar modelos
CREATE PROCEDURE [dbo].[listarmodelos]
AS
BEGIN
    SELECT ID_Modelos, Name_Modelos, Estado
    FROM Modelos
    ORDER BY Name_Modelos ASC;
END;
GO
/****** Object:  StoredProcedure [dbo].[listarpesos]    Script Date: 25/8/2024 23:52:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Procedimiento para listar pesos
CREATE PROCEDURE [dbo].[listarpesos]
AS
BEGIN
    SELECT ID_Peso, Name_Peso, Libras, Detalles_Peso, Estado
    FROM Pesos
    ORDER BY Name_Peso ASC;
END;
GO
/****** Object:  StoredProcedure [dbo].[listarproductos]    Script Date: 25/8/2024 23:52:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[listarproductos]
AS
BEGIN
    SELECT ID_Producto, Name_Producto, Estado
    FROM Productos
    ORDER BY Name_Producto ASC;
END;
GO
/****** Object:  StoredProcedure [dbo].[listartipos]    Script Date: 25/8/2024 23:52:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Procedimiento para listar tipos
CREATE PROCEDURE [dbo].[listartipos]
AS
BEGIN
    SELECT ID_Tipos, Name_Tipo, Estado
    FROM Tipos
    ORDER BY Name_Tipo ASC;
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_actualizarAcabado]    Script Date: 25/8/2024 23:52:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_actualizarAcabado]
    @ID_Acabado INT,
    @Name_Acabados NVARCHAR(100)
AS
BEGIN
    UPDATE Acabados
    SET Name_Acabados = @Name_Acabados
    WHERE ID_Acabado = @ID_Acabado;
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_actualizarCategoria]    Script Date: 25/8/2024 23:52:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_actualizarCategoria]
    @ID_Categoria INT,
    @Name_Categoria NVARCHAR(100)
AS
BEGIN
    UPDATE Categorias
    SET Name_Categoria = @Name_Categoria
    WHERE ID_Categoria = @ID_Categoria;
END;

GO
/****** Object:  StoredProcedure [dbo].[sp_actualizarColor]    Script Date: 25/8/2024 23:52:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_actualizarColor]
    @ID_Colores INT,
    @Name_Colores NVARCHAR(100)
AS
BEGIN
    UPDATE Colores
    SET Name_Colores = @Name_Colores
    WHERE ID_Colores = @ID_Colores;
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_actualizarDiametro]    Script Date: 25/8/2024 23:52:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_actualizarDiametro]
    @ID_Diametros INT,
    @Name_Diametro NVARCHAR(100)
AS
BEGIN
    UPDATE Diametros
    SET Name_Diametro = @Name_Diametro
    WHERE ID_Diametros = @ID_Diametros;
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_actualizarInventario]    Script Date: 25/8/2024 23:52:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_actualizarInventario]
    @ID_Inventario INT,
    @ID_Producto INT,
    @ID_Categoria INT,
    @ID_Marca INT,
    @ID_Modelos INT,
    @ID_Tipos INT,
    @ID_Colores INT,
    @ID_Diametros INT,
    @ID_Peso INT,
    @ID_Material INT,
    @ID_Acabados INT,
    @Cantidad_Articulo INT,
    @Precio_Unidad DECIMAL(18, 2)
AS
BEGIN
    UPDATE Inventario
    SET 
        ID_Producto = @ID_Producto,
        ID_Categoria = @ID_Categoria,
        ID_Marca = @ID_Marca,
        ID_Modelos = @ID_Modelos,
        ID_Tipos = @ID_Tipos,
        ID_Colores = @ID_Colores,
        ID_Diametros = @ID_Diametros,
        ID_Peso = @ID_Peso,
        ID_Material = @ID_Material,
        ID_Acabados = @ID_Acabados,
        Cantidad_Articulo = @Cantidad_Articulo,
        Precio_Unidad = @Precio_Unidad
    WHERE ID_Inventario = @ID_Inventario;
END;

GO
/****** Object:  StoredProcedure [dbo].[sp_actualizarMarca]    Script Date: 25/8/2024 23:52:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_actualizarMarca]
    @ID_Marca INT,
    @Name_Marca NVARCHAR(100)
AS
BEGIN
    UPDATE Marcas
    SET Name_Marca = @Name_Marca
    WHERE ID_Marca = @ID_Marca;
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_actualizarMaterial]    Script Date: 25/8/2024 23:52:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_actualizarMaterial]
    @ID_Material INT,
    @Name_Material NVARCHAR(100)
AS
BEGIN
    UPDATE Materiales
    SET Name_Material = @Name_Material
    WHERE ID_Material = @ID_Material;
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_actualizarModelo]    Script Date: 25/8/2024 23:52:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_actualizarModelo]
    @ID_Modelos INT,
    @Name_Modelos NVARCHAR(100)
AS
BEGIN
    UPDATE Modelos
    SET Name_Modelos = @Name_Modelos
    WHERE ID_Modelos = @ID_Modelos;
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_actualizarPeso]    Script Date: 25/8/2024 23:52:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_actualizarPeso]
    @ID_Peso INT,
    @Name_Peso NVARCHAR(100),
    @Libras FLOAT,
    @Detalles_Peso NVARCHAR(255)
AS
BEGIN
    UPDATE Pesos
    SET NAME_Peso = @Name_Peso,
        Libras = @Libras,
        Detalles_peso = @Detalles_Peso
    WHERE ID_Peso = @ID_Peso;
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_actualizarProducto]    Script Date: 25/8/2024 23:52:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_actualizarProducto]
    @ID_Producto INT,
    @Name_Producto NVARCHAR(100)
   
AS
BEGIN
    UPDATE Productos
    SET Name_Producto = @Name_Producto
        
    WHERE ID_Producto = @ID_Producto;
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_actualizarTipo]    Script Date: 25/8/2024 23:52:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_actualizarTipo]
    @ID_Tipo INT,
    @Name_Tipo NVARCHAR(100)
AS
BEGIN
    UPDATE Tipos
    SET Name_Tipo = @Name_Tipo
    WHERE ID_Tipos = @ID_Tipo;
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_eliminarAcabado]    Script Date: 25/8/2024 23:52:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_eliminarAcabado]
    @ID_Acabado INT
AS
BEGIN
    UPDATE Acabados
    SET Estado = 0
    WHERE ID_Acabado = @ID_Acabado;
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_eliminarCategoria]    Script Date: 25/8/2024 23:52:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_eliminarCategoria]
    @ID_Categoria INT
AS
BEGIN
    UPDATE Categorias
    SET Estado = 0
    WHERE ID_Categoria = @ID_Categoria;
END;

GO
/****** Object:  StoredProcedure [dbo].[sp_eliminarColor]    Script Date: 25/8/2024 23:52:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_eliminarColor]
    @ID_Colores INT
AS
BEGIN
    UPDATE Colores
    SET Estado = 0
    WHERE ID_Colores = @ID_Colores;
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_eliminarDiametro]    Script Date: 25/8/2024 23:52:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_eliminarDiametro]
    @ID_Diametros INT
AS
BEGIN
    UPDATE Diametros
    SET Estado = 0
    WHERE ID_Diametros = @ID_Diametros;
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_eliminarMarca]    Script Date: 25/8/2024 23:52:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_eliminarMarca]
    @ID_Marca INT
AS
BEGIN
    UPDATE Marcas
    SET Estado = 0
    WHERE ID_Marca = @ID_Marca;
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_eliminarMaterial]    Script Date: 25/8/2024 23:52:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_eliminarMaterial]
    @ID_Material INT
AS
BEGIN
    UPDATE Materiales
    SET Estado = 0
    WHERE ID_Material = @ID_Material;
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_eliminarModelo]    Script Date: 25/8/2024 23:52:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_eliminarModelo]
    @ID_Modelos INT
AS
BEGIN
    UPDATE Modelos
    SET Estado = 0
    WHERE ID_Modelos = @ID_Modelos;
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_eliminarPeso]    Script Date: 25/8/2024 23:52:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_eliminarPeso]
    @ID_Peso INT
AS
BEGIN
    UPDATE Pesos
    SET Estado = 0
    WHERE ID_Peso = @ID_Peso;
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_eliminarProducto]    Script Date: 25/8/2024 23:52:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_eliminarProducto]
    @ID_producto INT
AS
BEGIN
    UPDATE Productos
    SET Estado = 0
    WHERE ID_Producto = @id_producto;
END;

GO
/****** Object:  StoredProcedure [dbo].[sp_eliminarTipo]    Script Date: 25/8/2024 23:52:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_eliminarTipo]
    @ID_Tipo INT
AS
BEGIN
    UPDATE Tipos
    SET Estado = 0
    WHERE ID_Tipos = @ID_Tipo;
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_ingresarAcabado]    Script Date: 25/8/2024 23:52:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ingresarAcabado]
    @Name_Acabados NVARCHAR(100)
AS
BEGIN
    INSERT INTO Acabados 
    VALUES (@Name_Acabados, 1);
END;

GO
/****** Object:  StoredProcedure [dbo].[sp_ingresarCategoria]    Script Date: 25/8/2024 23:52:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ingresarCategoria]
    @Name_Categoria NVARCHAR(100)
AS
BEGIN
    INSERT INTO Categorias 
    VALUES (@Name_Categoria, 1);
END;

GO
/****** Object:  StoredProcedure [dbo].[sp_ingresarColor]    Script Date: 25/8/2024 23:52:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ingresarColor]
    @Name_Colores NVARCHAR(100)
AS
BEGIN
    INSERT INTO Colores 
    VALUES (@Name_Colores, 1);
END;

GO
/****** Object:  StoredProcedure [dbo].[sp_ingresarDiametro]    Script Date: 25/8/2024 23:52:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ingresarDiametro]
    @Name_Diametro NVARCHAR(100)
AS
BEGIN
    INSERT INTO Diametros 
    VALUES (@Name_Diametro, 1);
END;

GO
/****** Object:  StoredProcedure [dbo].[sp_ingresarInventario]    Script Date: 25/8/2024 23:52:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ingresarInventario]
    @ID_Producto INT,
    @ID_Categoria INT,
    @ID_Marca INT,
    @ID_Modelos INT,
    @ID_Tipos INT,
    @ID_Colores INT,
    @ID_Diametros INT,
    @ID_Peso INT,
    @ID_Material INT,
    @ID_Acabados INT,
    @Cantidad_Articulo INT,
    @Precio_Unidad DECIMAL(18, 2)
AS
BEGIN
    INSERT INTO Inventario 
    (ID_Producto, ID_Categoria, ID_Marca, ID_Modelos, ID_Tipos, ID_Colores, ID_Diametros, ID_Peso, ID_Material, ID_Acabados, Cantidad_Articulo, Precio_Unidad)
    VALUES 
    (@ID_Producto, @ID_Categoria, @ID_Marca, @ID_Modelos, @ID_Tipos, @ID_Colores, @ID_Diametros, @ID_Peso, @ID_Material, @ID_Acabados, @Cantidad_Articulo, @Precio_Unidad);
END;

GO
/****** Object:  StoredProcedure [dbo].[sp_ingresarMarca]    Script Date: 25/8/2024 23:52:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ingresarMarca]
    @Name_Marca NVARCHAR(100)
AS
BEGIN
    INSERT INTO Marcas 
    VALUES (@Name_Marca, 1);
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_ingresarMaterial]    Script Date: 25/8/2024 23:52:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ingresarMaterial]
    @Name_Material NVARCHAR(100)
AS
BEGIN
    INSERT INTO Materiales 
    VALUES (@Name_Material, 1);
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_ingresarModelo]    Script Date: 25/8/2024 23:52:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ingresarModelo]
    @Name_Modelos NVARCHAR(100)
AS
BEGIN
    INSERT INTO Modelos 
    VALUES (@Name_Modelos, 1);
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_ingresarPeso]    Script Date: 25/8/2024 23:52:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ingresarPeso]
    @Name_Peso NVARCHAR(100),
    @Libras FLOAT,
    @Detalles_Peso NVARCHAR(255)
AS
BEGIN
    INSERT INTO Pesos 
    (NAME_Peso, Libras, Detalles_peso, Estado)
    VALUES (@Name_Peso, @Libras, @Detalles_Peso, 1);
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_ingresarProducto]    Script Date: 25/8/2024 23:52:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_ingresarProducto]
    @Name_Producto NVARCHAR(100)

AS
BEGIN
    INSERT INTO Productos 
    VALUES (@Name_Producto, 1);
END;

GO
/****** Object:  StoredProcedure [dbo].[sp_ingresarTipo]    Script Date: 25/8/2024 23:52:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ingresarTipo]
    @Name_Tipo NVARCHAR(100)
AS
BEGIN
    INSERT INTO Tipos 
    VALUES (@Name_Tipo, 1);
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_mostrarAcabados]    Script Date: 25/8/2024 23:52:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_mostrarAcabados]
AS
BEGIN
    SELECT ID_Acabado, Name_Acabados, Estado
    FROM Acabados
	WHERE Estado =1
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_mostrarCategorias]    Script Date: 25/8/2024 23:52:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_mostrarCategorias]
AS
BEGIN
    SELECT ID_Categoria, Name_Categoria
    FROM Categorias
	WHERE Estado =1
END;

GO
/****** Object:  StoredProcedure [dbo].[sp_mostrarColores]    Script Date: 25/8/2024 23:52:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_mostrarColores]
AS
BEGIN
    SELECT ID_Colores, Name_Colores
    FROM Colores
	WHERE Estado =1
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_mostrarDiametros]    Script Date: 25/8/2024 23:52:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_mostrarDiametros]
AS
BEGIN
    SELECT ID_Diametros, Name_Diametro
    FROM Diametros
	where Estado=1

END;
GO
/****** Object:  StoredProcedure [dbo].[sp_mostrarInventarios]    Script Date: 25/8/2024 23:52:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_mostrarInventarios]
AS
BEGIN
    SELECT 
        ID_Inventario,
        ID_Producto,
        ID_Categoria,
        ID_Marca,
        ID_Modelos,
        ID_Tipos,
        ID_Colores,
        ID_Diametros,
        ID_Peso,
        ID_Material,
        ID_Acabados,
        Cantidad_Articulo,
        Precio_Unidad
    FROM Inventario;
END;

GO
/****** Object:  StoredProcedure [dbo].[sp_mostrarMarcas]    Script Date: 25/8/2024 23:52:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_mostrarMarcas]
AS
BEGIN
    SELECT ID_Marca, Name_Marca
    FROM Marcas
	where Estado=1;
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_mostrarMateriales]    Script Date: 25/8/2024 23:52:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_mostrarMateriales]
AS
BEGIN
    SELECT ID_Material, Name_Material, Estado
    FROM Materiales;
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_mostrarModelos]    Script Date: 25/8/2024 23:52:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_mostrarModelos]
AS
BEGIN
    SELECT ID_Modelos, Name_Modelos
    FROM Modelos
	where Estado=1
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_mostrarPesos]    Script Date: 25/8/2024 23:52:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_mostrarPesos]
AS
BEGIN
    SELECT ID_Peso, NAME_Peso, Libras, Detalles_peso
    FROM Pesos
	where Estado=1
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_mostrarProductos]    Script Date: 25/8/2024 23:52:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_mostrarProductos]
AS
BEGIN
    SELECT ID_Producto, Name_Producto
    FROM Productos
	  WHERE Estado = 1;
END;

GO
/****** Object:  StoredProcedure [dbo].[sp_mostrarTipos]    Script Date: 25/8/2024 23:52:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_mostrarTipos]
AS
BEGIN
    SELECT ID_Tipos, Name_Tipo, Estado
    FROM Tipos;
END;
GO
