USE [SITECE]
GO
/****** Object:  Table [dbo].[Asociado]    Script Date: 29/04/2019 01:26:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Asociado](
	[IdAsociado] [bigint] IDENTITY(1,1) NOT NULL,
	[CodigoModular] [varchar](50) NULL,
	[NombreColegio] [varchar](150) NULL,
	[Email] [varchar](150) NULL,
	[Token] [varchar](max) NULL,
 CONSTRAINT [PK_Asociado] PRIMARY KEY CLUSTERED 
(
	[IdAsociado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Estudiante]    Script Date: 29/04/2019 01:26:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Estudiante](
	[IdEstudiante] [bigint] IDENTITY(1,1) NOT NULL,
	[Dni] [varchar](50) NULL,
	[Anho] [int] NULL,
	[Nombres] [varchar](50) NULL,
	[Apellidos] [varchar](50) NULL,
	[Deuda] [decimal](18, 2) NULL,
	[fechaRegistro] [date] NULL,
	[IdAsociado] [bigint] NULL,
 CONSTRAINT [PK_Estudiante] PRIMARY KEY CLUSTERED 
(
	[IdEstudiante] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
