USE [Teste]
GO
/****** Object:  Table [dbo].[Estado]    Script Date: 06/03/2013 02:24:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Estado](
	[Sigla] [varchar](50) NULL,
	[Nome] [varchar](150) NULL,
	[Pais] [varchar](150) NULL,
	[Regiao] [varchar](50) NULL,
	[Codigo] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_Estado] PRIMARY KEY CLUSTERED 
(
	[Codigo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Cidade]    Script Date: 06/03/2013 02:24:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Cidade](
	[Nome] [varchar](150) NULL,
	[Estado] [int] NULL,
	[Capital] [bit] NULL,
	[Codigo] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_Cidade] PRIMARY KEY CLUSTERED 
(
	[Codigo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[pr_Estado_Listar]    Script Date: 06/03/2013 02:24:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_Estado_Listar] 
( 
 @Sigla varchar = null
 , @Nome varchar = null
 , @Pais varchar = null
 , @Regiao varchar = null
 , @Codigo int = null ) 
 AS 
 BEGIN 
 SELECT 
 Sigla
 ,Nome
 ,Pais
 ,Regiao
 ,Codigo 
 FROM [Teste].[dbo].[Estado] 
 WHERE 
 (Sigla = @Sigla OR @Sigla IS NULL)  
 AND (Nome = @Nome OR @Nome IS NULL)  
 AND (Pais = @Pais OR @Pais IS NULL)  
 AND (Regiao = @Regiao OR @Regiao IS NULL)  
 AND (Codigo = @Codigo OR @Codigo IS NULL)  
 END
GO
/****** Object:  StoredProcedure [dbo].[pr_Estado_Inserir]    Script Date: 06/03/2013 02:24:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_Estado_Inserir] 
  ( 
@Sigla varchar = null
, @Nome varchar = null
, @Pais varchar = null
, @Regiao varchar = null
) 
 AS 
 BEGIN 
 INSERT INTO [Teste].[dbo].[Estado] 
       (
 Sigla
 ,Nome
 ,Pais
 ,Regiao
) 
 VALUES (
 @Sigla
 ,@Nome
 ,@Pais
 ,@Regiao
) 
 END
GO
/****** Object:  StoredProcedure [dbo].[pr_Estado_Deletar]    Script Date: 06/03/2013 02:24:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_Estado_Deletar] 
( 
 @Sigla varchar = null
 , @Nome varchar = null
 , @Pais varchar = null
 , @Regiao varchar = null
 , @Codigo int = null ) 
 AS 
 BEGIN 
 DELETE FROM [Teste].[dbo].[Estado] 
 WHERE 
 (Sigla = @Sigla OR @Sigla IS NULL)  
 AND (Nome = @Nome OR @Nome IS NULL)  
 AND (Pais = @Pais OR @Pais IS NULL)  
 AND (Regiao = @Regiao OR @Regiao IS NULL)  
 AND (Codigo = @Codigo OR @Codigo IS NULL)  
 END
GO
/****** Object:  StoredProcedure [dbo].[pr_Estado_Alterar]    Script Date: 06/03/2013 02:24:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_Estado_Alterar] 
  ( 
@Sigla varchar = null
, @Nome varchar = null
, @Pais varchar = null
, @Regiao varchar = null
, @Codigo int = null 
) 
 AS 
 BEGIN 
 UPDATE [Teste].[dbo].[Estado] 
       SET 
Sigla = @Sigla
,Nome = @Nome
,Pais = @Pais
,Regiao = @Regiao
        WHERE 
(Sigla = @Sigla OR @Sigla IS NULL) 
 AND (Nome = @Nome OR @Nome IS NULL) 
 AND (Pais = @Pais OR @Pais IS NULL) 
 AND (Regiao = @Regiao OR @Regiao IS NULL) 
 AND (Codigo = @Codigo OR @Codigo IS NULL)  
 END
GO
/****** Object:  StoredProcedure [dbo].[pr_do_Inserir]    Script Date: 06/03/2013 02:24:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_do_Inserir] 
  ( 
@Sigla varchar = null
, @Nome varchar = null
, @Pais varchar = null
, @Regiao varchar = null
, @Codigo int = null 
) 
 AS 
 BEGIN 
 INSERT INTO [Teste].[dbo].[Estado] 
       (
 Sigla
 ,Nome
 ,Pais
 ,Regiao
 ,Codigo 
) 
 VALUES (
 @Sigla
 ,@Nome
 ,@Pais
 ,@Regiao
 ,@Codigo
) 
 END
GO
/****** Object:  StoredProcedure [dbo].[pr_do_Deletar]    Script Date: 06/03/2013 02:24:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_do_Deletar] 
( 
 @Sigla varchar = null
 , @Nome varchar = null
 , @Pais varchar = null
 , @Regiao varchar = null
 , @Codigo int = null ) 
 AS 
 BEGIN 
 DELETE FROM [Teste].[dbo].[Estado] 
 WHERE 
 (Sigla = @Sigla OR @Sigla IS NULL)  
 AND (Nome = @Nome OR @Nome IS NULL)  
 AND (Pais = @Pais OR @Pais IS NULL)  
 AND (Regiao = @Regiao OR @Regiao IS NULL)  
 AND (Codigo = @Codigo OR @Codigo IS NULL)  
 END
GO
/****** Object:  StoredProcedure [dbo].[pr_Cidade_Listar]    Script Date: 06/03/2013 02:24:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_Cidade_Listar] 
( 
 @Nome varchar = null
 , @Estado int = null
 , @Capital bit = null
 , @Codigo int = null ) 
 AS 
 BEGIN 
 SELECT 
 Nome
 ,Estado
 ,Capital
 ,Codigo 
 FROM [Teste].[dbo].[Cidade] 
 WHERE 
 (Nome = @Nome OR @Nome IS NULL)  
 AND (Estado = @Estado OR @Estado IS NULL)  
 AND (Capital = @Capital OR @Capital IS NULL)  
 AND (Codigo = @Codigo OR @Codigo IS NULL)  
 END
GO
/****** Object:  StoredProcedure [dbo].[pr_Cidade_Inserir]    Script Date: 06/03/2013 02:24:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_Cidade_Inserir] 
  ( 
@Nome varchar = null
, @Estado int = null
, @Capital bit = null
) 
 AS 
 BEGIN 
 INSERT INTO [Teste].[dbo].[Cidade] 
       (
 Nome
 ,Estado
 ,Capital
) 
 VALUES (
 @Nome
 ,@Estado
 ,@Capital
) 
 END
GO
/****** Object:  StoredProcedure [dbo].[pr_Cidade_Deletar]    Script Date: 06/03/2013 02:24:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_Cidade_Deletar] 
( 
 @Nome varchar = null
 , @Estado int = null
 , @Capital bit = null
 , @Codigo int = null ) 
 AS 
 BEGIN 
 DELETE FROM [Teste].[dbo].[Cidade] 
 WHERE 
 (Nome = @Nome OR @Nome IS NULL)  
 AND (Estado = @Estado OR @Estado IS NULL)  
 AND (Capital = @Capital OR @Capital IS NULL)  
 AND (Codigo = @Codigo OR @Codigo IS NULL)  
 END
GO
/****** Object:  StoredProcedure [dbo].[pr_Cidade_Alterar]    Script Date: 06/03/2013 02:24:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_Cidade_Alterar] 
  ( 
@Nome varchar = null
, @Estado int = null
, @Capital bit = null
, @Codigo int = null 
) 
 AS 
 BEGIN 
 UPDATE [Teste].[dbo].[Cidade] 
       SET 
Nome = @Nome
,Estado = @Estado
,Capital = @Capital
        WHERE 
(Nome = @Nome OR @Nome IS NULL) 
 AND (Estado = @Estado OR @Estado IS NULL) 
 AND (Capital = @Capital OR @Capital IS NULL) 
 AND (Codigo = @Codigo OR @Codigo IS NULL)  
 END
GO
/****** Object:  ForeignKey [FK_Cidade_Estado]    Script Date: 06/03/2013 02:24:18 ******/
ALTER TABLE [dbo].[Cidade]  WITH CHECK ADD  CONSTRAINT [FK_Cidade_Estado] FOREIGN KEY([Estado])
REFERENCES [dbo].[Estado] ([Codigo])
GO
ALTER TABLE [dbo].[Cidade] CHECK CONSTRAINT [FK_Cidade_Estado]
GO
