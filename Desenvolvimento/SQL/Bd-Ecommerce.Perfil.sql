USE [dbEcommerce]
GO

/****** Object:  Table [perfil].[Sexo]    Script Date: 03/12/2019 19:43:28 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [perfil].[Sexo](
	[IDSexo] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](50) NOT NULL,
	[Descricao] [varchar](150) NOT NULL,
	[Status] [bit] NOT NULL,
	[Usuario] [varchar](100) NOT NULL,
	[CriadoEm] [datetime] NOT NULL,
	[AtualizadoEm] [datetime] NOT NULL,
 CONSTRAINT [PK_perfil.Sexo] PRIMARY KEY CLUSTERED 
(
	[IDSexo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


--
USE [dbEcommerce]
GO

/****** Object:  Table [perfil].[Clientes]    Script Date: 03/12/2019 19:40:40 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [perfil].[Clientes](
	[ClienteId] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](8000) NOT NULL,
	[Senha] [varchar](50) NOT NULL,
	[Tipo] [bit] NOT NULL,
	[Foto] [varchar](200) NOT NULL,
	[Status] [bit] NOT NULL,
	[Usuario] [varchar](100) NOT NULL,
	[CriadoEm] [datetime] NOT NULL,
	[AtualizadoEm] [datetime] NOT NULL,
 CONSTRAINT [PK_perfil.Clientes] PRIMARY KEY CLUSTERED 
(
	[ClienteId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

-- 

USE [dbEcommerce]
GO

/****** Object:  Table [perfil].[Email]    Script Date: 03/12/2019 19:41:58 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [perfil].[Email](
	[IDEmail] [int] IDENTITY(1,1) NOT NULL,
	[IDCliente] [int] NOT NULL,
	[E_mail] [varchar](200) NOT NULL,
	[Tipo] [bit] NOT NULL,
	[Status] [bit] NOT NULL,
	[Usuario] [varchar](100) NOT NULL,
	[CriadoEm] [datetime] NOT NULL,
	[AtualizadoEm] [datetime] NOT NULL,
	[Cliente_ClienteId] [int] NULL,
 CONSTRAINT [PK_perfil.Email] PRIMARY KEY CLUSTERED 
(
	[IDEmail] ASC,
	[IDCliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [perfil].[Email]  WITH CHECK ADD  CONSTRAINT [FK_perfil.Email_perfil.Clientes_Cliente_ClienteId] FOREIGN KEY([Cliente_ClienteId])
REFERENCES [perfil].[Clientes] ([ClienteId])
GO

ALTER TABLE [perfil].[Email] CHECK CONSTRAINT [FK_perfil.Email_perfil.Clientes_Cliente_ClienteId]
GO

ALTER TABLE [perfil].[Email]  WITH CHECK ADD  CONSTRAINT [FK_perfil.Email_perfil.Clientes_IDCliente] FOREIGN KEY([IDCliente])
REFERENCES [perfil].[Clientes] ([ClienteId])
ON DELETE CASCADE
GO

ALTER TABLE [perfil].[Email] CHECK CONSTRAINT [FK_perfil.Email_perfil.Clientes_IDCliente]
GO


--

USE [dbEcommerce]
GO

/****** Object:  Table [perfil].[Fisico]    Script Date: 03/12/2019 19:42:46 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [perfil].[Fisico](
	[IDCliente] [int] NOT NULL,
	[CPF] [varchar](11) NOT NULL,
	[DataNascimento] [datetime] NOT NULL,
	[IDSexo] [int] NOT NULL,
 CONSTRAINT [PK_perfil.Fisico] PRIMARY KEY CLUSTERED 
(
	[IDCliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [perfil].[Fisico]  WITH CHECK ADD  CONSTRAINT [FK_perfil.Fisico_perfil.Clientes_IDCliente] FOREIGN KEY([IDCliente])
REFERENCES [perfil].[Clientes] ([ClienteId])
GO

ALTER TABLE [perfil].[Fisico] CHECK CONSTRAINT [FK_perfil.Fisico_perfil.Clientes_IDCliente]
GO

ALTER TABLE [perfil].[Fisico]  WITH CHECK ADD  CONSTRAINT [FK_perfil.Fisico_perfil.Sexo_IDSexo] FOREIGN KEY([IDSexo])
REFERENCES [perfil].[Sexo] ([IDSexo])
ON DELETE CASCADE
GO

ALTER TABLE [perfil].[Fisico] CHECK CONSTRAINT [FK_perfil.Fisico_perfil.Sexo_IDSexo]
GO


--

USE [dbEcommerce]
GO

/****** Object:  Table [perfil].[Juridico]    Script Date: 03/12/2019 19:43:03 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [perfil].[Juridico](
	[IDCliente] [int] NOT NULL,
	[CNPJ] [varchar](14) NOT NULL,
	[InscricaoEstatual] [varchar](20) NOT NULL,
	[Responsavel] [varchar](150) NOT NULL,
 CONSTRAINT [PK_perfil.Juridico] PRIMARY KEY CLUSTERED 
(
	[IDCliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [perfil].[Juridico]  WITH CHECK ADD  CONSTRAINT [FK_perfil.Juridico_perfil.Clientes_IDCliente] FOREIGN KEY([IDCliente])
REFERENCES [perfil].[Clientes] ([ClienteId])
GO

ALTER TABLE [perfil].[Juridico] CHECK CONSTRAINT [FK_perfil.Juridico_perfil.Clientes_IDCliente]
GO


--



--

USE [dbEcommerce]
GO

/****** Object:  Table [perfil].[Telefone]    Script Date: 03/12/2019 19:43:46 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [perfil].[Telefone](
	[IDTelefone] [int] IDENTITY(1,1) NOT NULL,
	[IDCliente] [int] NOT NULL,
	[Numero] [varchar](8000) NOT NULL,
	[DDD] [varchar](8000) NOT NULL,
	[Tipo] [varchar](50) NOT NULL,
	[Status] [bit] NOT NULL,
	[Usuario] [varchar](100) NOT NULL,
	[CriadoEm] [datetime] NOT NULL,
	[AtualizadoEm] [datetime] NOT NULL,
	[Cliente_ClienteId] [int] NULL,
 CONSTRAINT [PK_perfil.Telefone] PRIMARY KEY CLUSTERED 
(
	[IDTelefone] ASC,
	[IDCliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [perfil].[Telefone]  WITH CHECK ADD  CONSTRAINT [FK_perfil.Telefone_perfil.Clientes_Cliente_ClienteId] FOREIGN KEY([Cliente_ClienteId])
REFERENCES [perfil].[Clientes] ([ClienteId])
GO

ALTER TABLE [perfil].[Telefone] CHECK CONSTRAINT [FK_perfil.Telefone_perfil.Clientes_Cliente_ClienteId]
GO

ALTER TABLE [perfil].[Telefone]  WITH CHECK ADD  CONSTRAINT [FK_perfil.Telefone_perfil.Clientes_IDCliente] FOREIGN KEY([IDCliente])
REFERENCES [perfil].[Clientes] ([ClienteId])
ON DELETE CASCADE
GO

ALTER TABLE [perfil].[Telefone] CHECK CONSTRAINT [FK_perfil.Telefone_perfil.Clientes_IDCliente]
GO



