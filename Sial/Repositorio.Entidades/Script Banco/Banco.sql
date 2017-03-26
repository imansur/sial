USE [SIAL]
GO
/****** Object:  Table [dbo].[ACOMPANHAMENTO]    Script Date: 17/03/2017 08:38:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ACOMPANHAMENTO](
	[ID_ACOMPANHAMENTO] [int] IDENTITY(1,1) NOT NULL,
	[DATA] [date] NULL,
	[EVENTO] [varchar](80) NULL,
	[OBSERVACAO] [text] NULL,
	[ID_EDITAL] [int] NOT NULL,
 CONSTRAINT [PK_ACOMPANHAMENTO] PRIMARY KEY CLUSTERED 
(
	[ID_ACOMPANHAMENTO] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[EDITAL]    Script Date: 17/03/2017 08:38:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[EDITAL](
	[ID_EDITAL] [int] IDENTITY(1,1) NOT NULL,
	[NUMERO_EDITAL] [varchar](30) NOT NULL,
	[APELIDO] [varchar](80) NOT NULL,
	[DATA_HORA_ENTREGA] [datetime] NOT NULL,
	[DESTINO] [int] NULL,
	[LOCAL] [varchar](100) NULL,
	[DATA_DESCARTE] [datetime] NULL,
	[OBJETO] [text] NULL,
	[OBSERVACAO] [text] NULL,
	[ID_ORGAO] [int] NULL,
	[ID_RESPONSAVEL] [int] NULL,
 CONSTRAINT [PK_EDITAL] PRIMARY KEY CLUSTERED 
(
	[ID_EDITAL] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[EMPRESA]    Script Date: 17/03/2017 08:38:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[EMPRESA](
	[ID_EMPRESA] [int] IDENTITY(1,1) NOT NULL,
	[NOME] [varchar](80) NULL,
	[TELEFONE] [varchar](15) NULL,
 CONSTRAINT [PK_EMPRESA] PRIMARY KEY CLUSTERED 
(
	[ID_EMPRESA] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LOTE]    Script Date: 17/03/2017 08:38:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LOTE](
	[ID_LOTE] [int] IDENTITY(1,1) NOT NULL,
	[NUMERO_LOTE] [varchar](30) NOT NULL,
	[DESCRICAO] [varchar](80) NOT NULL,
	[PRAZO_EXECUCAO] [int] NULL,
	[ORCAMENTO] [numeric](18, 2) NULL,
	[VENCEDOR] [bit] NOT NULL,
	[ID_EDITAL] [int] NULL,
 CONSTRAINT [PK_LOTE] PRIMARY KEY CLUSTERED 
(
	[ID_LOTE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LOTE_EMPRESA]    Script Date: 17/03/2017 08:38:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LOTE_EMPRESA](
	[ID_LOTE_EMPRESA] [int] IDENTITY(1,1) NOT NULL,
	[ID_LOTE] [int] NOT NULL,
	[ID_EMPRESA] [int] NOT NULL,
	[PROPOSTA] [numeric](18, 2) NULL,
 CONSTRAINT [PK_LOTE_EMPRESA_1] PRIMARY KEY CLUSTERED 
(
	[ID_LOTE_EMPRESA] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[MENU]    Script Date: 17/03/2017 08:38:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MENU](
	[ID_MENU] [int] IDENTITY(1,1) NOT NULL,
	[PAI] [int] NOT NULL,
	[LINK] [varchar](100) NULL,
	[DESCRICAO] [varchar](50) NULL,
 CONSTRAINT [PK_MENU] PRIMARY KEY CLUSTERED 
(
	[ID_MENU] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ORGAO]    Script Date: 17/03/2017 08:38:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ORGAO](
	[ID_ORGAO] [int] IDENTITY(1,1) NOT NULL,
	[NOME] [varchar](80) NULL,
 CONSTRAINT [PK_ORGAO] PRIMARY KEY CLUSTERED 
(
	[ID_ORGAO] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[RESPONSAVEL]    Script Date: 17/03/2017 08:38:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[RESPONSAVEL](
	[ID_RESPONSAVEL] [int] IDENTITY(1,1) NOT NULL,
	[NOME] [varchar](80) NOT NULL,
 CONSTRAINT [PK_RESPONSAVEL] PRIMARY KEY CLUSTERED 
(
	[ID_RESPONSAVEL] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[ACOMPANHAMENTO]  WITH CHECK ADD  CONSTRAINT [FK_ACOMPANHAMENTO_EDITAL] FOREIGN KEY([ID_EDITAL])
REFERENCES [dbo].[EDITAL] ([ID_EDITAL])
GO
ALTER TABLE [dbo].[ACOMPANHAMENTO] CHECK CONSTRAINT [FK_ACOMPANHAMENTO_EDITAL]
GO
ALTER TABLE [dbo].[EDITAL]  WITH CHECK ADD  CONSTRAINT [FK_EDITAL_ORGAO] FOREIGN KEY([ID_ORGAO])
REFERENCES [dbo].[ORGAO] ([ID_ORGAO])
GO
ALTER TABLE [dbo].[EDITAL] CHECK CONSTRAINT [FK_EDITAL_ORGAO]
GO
ALTER TABLE [dbo].[EDITAL]  WITH CHECK ADD  CONSTRAINT [FK_EDITAL_RESPONSAVEL] FOREIGN KEY([ID_RESPONSAVEL])
REFERENCES [dbo].[RESPONSAVEL] ([ID_RESPONSAVEL])
GO
ALTER TABLE [dbo].[EDITAL] CHECK CONSTRAINT [FK_EDITAL_RESPONSAVEL]
GO
ALTER TABLE [dbo].[LOTE]  WITH CHECK ADD  CONSTRAINT [FK_LOTE_EDITAL] FOREIGN KEY([ID_EDITAL])
REFERENCES [dbo].[EDITAL] ([ID_EDITAL])
GO
ALTER TABLE [dbo].[LOTE] CHECK CONSTRAINT [FK_LOTE_EDITAL]
GO
ALTER TABLE [dbo].[LOTE_EMPRESA]  WITH CHECK ADD  CONSTRAINT [FK_LOTE_EMPRESA_EMPRESA] FOREIGN KEY([ID_EMPRESA])
REFERENCES [dbo].[EMPRESA] ([ID_EMPRESA])
GO
ALTER TABLE [dbo].[LOTE_EMPRESA] CHECK CONSTRAINT [FK_LOTE_EMPRESA_EMPRESA]
GO
ALTER TABLE [dbo].[LOTE_EMPRESA]  WITH CHECK ADD  CONSTRAINT [FK_LOTE_EMPRESA_LOTE] FOREIGN KEY([ID_LOTE])
REFERENCES [dbo].[LOTE] ([ID_LOTE])
GO
ALTER TABLE [dbo].[LOTE_EMPRESA] CHECK CONSTRAINT [FK_LOTE_EMPRESA_LOTE]
GO
