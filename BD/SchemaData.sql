USE [BdPrematriculas]
GO
/****** Object:  Table [dbo].[Alumnos]    Script Date: 7/04/2019 06:55:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Alumnos](
	[NroDni] [char](8) NOT NULL,
	[Nombres] [varchar](20) NOT NULL,
	[ApellidoPaterno] [varchar](20) NOT NULL,
	[ApellidoMaterno] [varchar](20) NOT NULL,
	[Sexo] [char](10) NOT NULL,
	[FechaNacimiento] [date] NOT NULL,
	[IdNivel] [int] NOT NULL,
	[Usuario] [varchar](20) NULL,
	[Password] [varchar](20) NULL,
	[DniApoderado] [varchar](8) NULL,
 CONSTRAINT [PK_Alumnos_1] PRIMARY KEY CLUSTERED 
(
	[NroDni] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Apoderados]    Script Date: 7/04/2019 06:55:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Apoderados](
	[NroDni] [char](8) NOT NULL,
	[Nombres] [varchar](20) NOT NULL,
	[ApellidoPaterno] [varchar](20) NOT NULL,
	[ApellidoMaterno] [varchar](20) NOT NULL,
	[Direccion] [varchar](50) NULL,
	[NroCelular] [varchar](50) NOT NULL,
	[Correo] [varchar](20) NULL,
	[Parentesco] [varchar](20) NOT NULL,
 CONSTRAINT [PK_Apoderados] PRIMARY KEY CLUSTERED 
(
	[NroDni] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[AuditoriaMensajes]    Script Date: 7/04/2019 06:55:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[AuditoriaMensajes](
	[IdAuditoriaMensaje] [int] IDENTITY(1,1) NOT NULL,
	[TipoMensaje] [varchar](20) NULL,
	[Destino] [varchar](20) NULL,
	[Estado] [varchar](20) NULL,
	[IdPrematricula] [int] NOT NULL,
 CONSTRAINT [PK_AuditoriaMensajes] PRIMARY KEY CLUSTERED 
(
	[IdAuditoriaMensaje] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Cursos]    Script Date: 7/04/2019 06:55:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Cursos](
	[IdCurso] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](20) NOT NULL,
	[IdNivel] [int] NOT NULL,
	[TipoCurso] [varchar](20) NOT NULL,
 CONSTRAINT [PK_Cursos] PRIMARY KEY CLUSTERED 
(
	[IdCurso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Niveles]    Script Date: 7/04/2019 06:55:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Niveles](
	[IdNivel] [int] IDENTITY(1,1) NOT NULL,
	[Año] [int] NOT NULL,
	[Nivel] [varchar](20) NOT NULL,
	[Grado] [varchar](20) NOT NULL,
	[Seccion] [char](1) NOT NULL,
	[Turno] [varchar](20) NOT NULL,
	[VacantesTotal] [int] NOT NULL,
	[VacastesDisponible] [int] NOT NULL,
 CONSTRAINT [PK_Niveles] PRIMARY KEY CLUSTERED 
(
	[IdNivel] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Prematriculas]    Script Date: 7/04/2019 06:55:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Prematriculas](
	[IdPrematricula] [int] IDENTITY(1,1) NOT NULL,
	[NroDniAlumno] [char](8) NOT NULL,
	[Certificado] [varchar](50) NULL,
	[IdNivel] [int] NOT NULL,
	[Tipo] [varchar](20) NOT NULL,
	[Estado] [varchar](20) NOT NULL,
	[Observaciones] [varchar](max) NULL,
	[FechaSolicitud] [date] NULL,
	[FechaRespuesta] [date] NULL,
	[FechaCita] [date] NULL,
 CONSTRAINT [PK_Prematriculas] PRIMARY KEY CLUSTERED 
(
	[IdPrematricula] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 7/04/2019 06:55:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuarios](
	[IdUsuario] [int] IDENTITY(1,1) NOT NULL,
	[Login] [nvarchar](50) NULL,
	[Clave] [nvarchar](50) NULL,
	[Nombres] [nvarchar](50) NULL,
	[Apellidos] [nvarchar](50) NULL,
	[Correo] [nvarchar](50) NULL,
	[Telefono] [nvarchar](50) NULL,
	[DNI] [nvarchar](50) NULL,
 CONSTRAINT [PK_Usuarios] PRIMARY KEY CLUSTERED 
(
	[IdUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[Alumnos] ([NroDni], [Nombres], [ApellidoPaterno], [ApellidoMaterno], [Sexo], [FechaNacimiento], [IdNivel], [Usuario], [Password], [DniApoderado]) VALUES (N'44553322', N'Juan', N'Perez', N'Lopez', N'Masculino ', CAST(N'2010-02-01' AS Date), 3, N'jperez', N'1234', NULL)
INSERT [dbo].[Alumnos] ([NroDni], [Nombres], [ApellidoPaterno], [ApellidoMaterno], [Sexo], [FechaNacimiento], [IdNivel], [Usuario], [Password], [DniApoderado]) VALUES (N'55443322', N'Maria', N'Palomino', N'Cardenas', N'Femenino  ', CAST(N'2010-01-01' AS Date), 3, N'mpalomino', N'4321', NULL)
INSERT [dbo].[Apoderados] ([NroDni], [Nombres], [ApellidoPaterno], [ApellidoMaterno], [Direccion], [NroCelular], [Correo], [Parentesco]) VALUES (N'66553322', N'Martha', N'Nuñez', N'Barreto', N'Peru #554', N'987656784', N'mnunez@gmail.com', N'Abuela')
INSERT [dbo].[Apoderados] ([NroDni], [Nombres], [ApellidoPaterno], [ApellidoMaterno], [Direccion], [NroCelular], [Correo], [Parentesco]) VALUES (N'77665544', N'Pedro', N'Garcia', N'Prado', N'Lima #666', N'987654321', N'pgarcia@gmail.com', N'Tío')
SET IDENTITY_INSERT [dbo].[Niveles] ON 

INSERT [dbo].[Niveles] ([IdNivel], [Año], [Nivel], [Grado], [Seccion], [Turno], [VacantesTotal], [VacastesDisponible]) VALUES (1, 2019, N'Primario', N'1', N'A', N'Mañana', 40, 40)
INSERT [dbo].[Niveles] ([IdNivel], [Año], [Nivel], [Grado], [Seccion], [Turno], [VacantesTotal], [VacastesDisponible]) VALUES (2, 2019, N'Primario', N'2', N'A', N'Mañana', 40, 40)
INSERT [dbo].[Niveles] ([IdNivel], [Año], [Nivel], [Grado], [Seccion], [Turno], [VacantesTotal], [VacastesDisponible]) VALUES (3, 2019, N'Primario', N'3', N'A', N'Mañana', 40, 40)
INSERT [dbo].[Niveles] ([IdNivel], [Año], [Nivel], [Grado], [Seccion], [Turno], [VacantesTotal], [VacastesDisponible]) VALUES (4, 2019, N'Primario', N'4', N'A', N'Mañana', 40, 40)
INSERT [dbo].[Niveles] ([IdNivel], [Año], [Nivel], [Grado], [Seccion], [Turno], [VacantesTotal], [VacastesDisponible]) VALUES (5, 2019, N'Primario', N'5', N'A', N'Mañana', 40, 40)
INSERT [dbo].[Niveles] ([IdNivel], [Año], [Nivel], [Grado], [Seccion], [Turno], [VacantesTotal], [VacastesDisponible]) VALUES (6, 2019, N'Primario', N'6', N'A', N'Mañana', 40, 40)
INSERT [dbo].[Niveles] ([IdNivel], [Año], [Nivel], [Grado], [Seccion], [Turno], [VacantesTotal], [VacastesDisponible]) VALUES (7, 2019, N'Secundario', N'1', N'A', N'Mañana', 40, 40)
INSERT [dbo].[Niveles] ([IdNivel], [Año], [Nivel], [Grado], [Seccion], [Turno], [VacantesTotal], [VacastesDisponible]) VALUES (8, 2019, N'Secundario', N'2', N'A', N'Mañana', 40, 40)
INSERT [dbo].[Niveles] ([IdNivel], [Año], [Nivel], [Grado], [Seccion], [Turno], [VacantesTotal], [VacastesDisponible]) VALUES (9, 2019, N'Secundario', N'3', N'A', N'Mañana', 40, 40)
INSERT [dbo].[Niveles] ([IdNivel], [Año], [Nivel], [Grado], [Seccion], [Turno], [VacantesTotal], [VacastesDisponible]) VALUES (10, 2019, N'Secundario', N'4', N'A', N'Mañana', 40, 40)
INSERT [dbo].[Niveles] ([IdNivel], [Año], [Nivel], [Grado], [Seccion], [Turno], [VacantesTotal], [VacastesDisponible]) VALUES (11, 2019, N'Secundario', N'5', N'A', N'Mañana', 40, 40)
SET IDENTITY_INSERT [dbo].[Niveles] OFF

SET IDENTITY_INSERT [dbo].[Usuarios] ON 

INSERT [dbo].[Usuarios] ([IdUsuario], [Login], [Clave], [Nombres], [Apellidos], [Correo], [Telefono], [DNI]) VALUES (1, N'secretaria01', N'1234', N'Paola', N'Paredes', N'pparedes@gmail.com', N'987654567', N'77668899')
SET IDENTITY_INSERT [dbo].[Usuarios] OFF
ALTER TABLE [dbo].[AuditoriaMensajes]  WITH CHECK ADD  CONSTRAINT [FK_AuditoriaMensajes_Prematriculas] FOREIGN KEY([IdPrematricula])
REFERENCES [dbo].[Prematriculas] ([IdPrematricula])
GO
ALTER TABLE [dbo].[AuditoriaMensajes] CHECK CONSTRAINT [FK_AuditoriaMensajes_Prematriculas]
GO
ALTER TABLE [dbo].[Cursos]  WITH CHECK ADD  CONSTRAINT [FK_Cursos_Niveles] FOREIGN KEY([IdNivel])
REFERENCES [dbo].[Niveles] ([IdNivel])
GO
ALTER TABLE [dbo].[Cursos] CHECK CONSTRAINT [FK_Cursos_Niveles]
GO
ALTER TABLE [dbo].[Prematriculas]  WITH CHECK ADD  CONSTRAINT [FK_Prematriculas_Alumnos] FOREIGN KEY([NroDniAlumno])
REFERENCES [dbo].[Alumnos] ([NroDni])
GO
ALTER TABLE [dbo].[Prematriculas] CHECK CONSTRAINT [FK_Prematriculas_Alumnos]
GO
ALTER TABLE [dbo].[Prematriculas]  WITH CHECK ADD  CONSTRAINT [FK_Prematriculas_Niveles] FOREIGN KEY([IdNivel])
REFERENCES [dbo].[Niveles] ([IdNivel])
GO
ALTER TABLE [dbo].[Prematriculas] CHECK CONSTRAINT [FK_Prematriculas_Niveles]
GO
