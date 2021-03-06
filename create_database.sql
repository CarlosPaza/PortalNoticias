USE [master]
GO
/****** Object:  Database [PortalNoticias]    Script Date: 10/06/2019 21:11:51 ******/
CREATE DATABASE [PortalNoticias]
GO
ALTER DATABASE [PortalNoticias] SET ANSI_NULL_DEFAULT ON 
GO
ALTER DATABASE [PortalNoticias] SET ANSI_NULLS ON 
GO
ALTER DATABASE [PortalNoticias] SET ANSI_PADDING ON 
GO
ALTER DATABASE [PortalNoticias] SET ANSI_WARNINGS ON 
GO
ALTER DATABASE [PortalNoticias] SET ARITHABORT ON 
GO
ALTER DATABASE [PortalNoticias] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [PortalNoticias] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [PortalNoticias] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [PortalNoticias] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [PortalNoticias] SET CURSOR_DEFAULT  LOCAL 
GO
ALTER DATABASE [PortalNoticias] SET CONCAT_NULL_YIELDS_NULL ON 
GO
ALTER DATABASE [PortalNoticias] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [PortalNoticias] SET QUOTED_IDENTIFIER ON 
GO
ALTER DATABASE [PortalNoticias] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [PortalNoticias] SET  DISABLE_BROKER 
GO
ALTER DATABASE [PortalNoticias] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [PortalNoticias] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [PortalNoticias] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [PortalNoticias] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [PortalNoticias] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [PortalNoticias] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [PortalNoticias] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [PortalNoticias] SET RECOVERY FULL 
GO
ALTER DATABASE [PortalNoticias] SET  MULTI_USER 
GO
ALTER DATABASE [PortalNoticias] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [PortalNoticias] SET DB_CHAINING OFF 
GO
ALTER DATABASE [PortalNoticias] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [PortalNoticias] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [PortalNoticias] SET DELAYED_DURABILITY = DISABLED 
GO
USE [PortalNoticias]
GO
/****** Object:  Table [dbo].[Autores]    Script Date: 10/06/2019 21:11:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Autores](
	[id_autor] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](255) NOT NULL,
 CONSTRAINT [PK_Autores] PRIMARY KEY CLUSTERED 
(
	[id_autor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING ON
GO
/****** Object:  Table [dbo].[Noticias]    Script Date: 10/06/2019 21:11:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Noticias](
	[id_noticia] [int] IDENTITY(1,1) NOT NULL,
	[id_autor] [int] NOT NULL,
	[Titulo] [varchar](255) NOT NULL,
	[Texto] [text] NOT NULL,
 CONSTRAINT [PK_Noticias] PRIMARY KEY CLUSTERED 
(
	[id_noticia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING ON
GO
SET IDENTITY_INSERT [dbo].[Autores] ON 

INSERT [dbo].[Autores] ([id_autor], [Nome]) VALUES (1, N'Carlos Cesar Paza')
INSERT [dbo].[Autores] ([id_autor], [Nome]) VALUES (2, N'Diego Ribas')
INSERT [dbo].[Autores] ([id_autor], [Nome]) VALUES (2003, N'Mauricio Meirelles')
INSERT [dbo].[Autores] ([id_autor], [Nome]) VALUES (2004, N'Ricardo de Souza')
SET IDENTITY_INSERT [dbo].[Autores] OFF
SET IDENTITY_INSERT [dbo].[Noticias] ON 

INSERT [dbo].[Noticias] ([id_noticia], [id_autor], [Titulo], [Texto]) VALUES (1, 1, N'Roteiristas quase colocaram Tony Stark em Asgard no filme', N'Stephen McFeely, um dos roteiristas de Vingadores: Ultimato, revelou ao podcast da Empire que o plano original dele e de Christopher Markus era colocar Tony Stark em Asgard, buscando a Joia do Espaço.
Em Thor: O Mundo Sombrio, o Tesseract está em Asgard, bem como o Éter. Nós íamos mandar Tony para Asgard, com uma armadura invisível, e ele lutaria com Heimdall. Joe Russo deu a ideia de mandar eles para o primeiro Vingadores. É o maior filme, o mais divertido, então fomos.
Vingadores: Ultimato está nos cinemas brasileiros e já alcançou a marca de US$ 2,6 bilhões mundialmente, se tornando a segunda maior bilheteria da história ao ultrapassar Titanic.')
INSERT [dbo].[Noticias] ([id_noticia], [id_autor], [Titulo], [Texto]) VALUES (2, 2, N'Engenheiros criam baterias que se consertam sozinhas e duram mais', N'Apesar da grande evolução tecnológica que rodeia todos aparelhos eletrônicos nos dias atuais, ainda há um ponto em comum que precisa ser melhorado em todos eles, a bateria. Elas são as responsáveis por alimentar grande parte do nosso mundo hoje, sendo tão necessárias e indispensáveis duas características se tornam primordiais: sua longevidade e sua capacidade — quanto de carga ela pode armazenar.
Foi com base nessa necessidade que engenheiros da Universidade de Tóquio, no Japão, desenvolveram uma pesquisa que visa novas formas de melhorar a tecnologia de baterias. Comandados pelo professor Atsuo Yamada, os engenheiros desenvolveram um modelo de bateria autorreparável prolonga sua vida útil, e também pode proporcionar capacidades de carga mais altas.')
INSERT [dbo].[Noticias] ([id_noticia], [id_autor], [Titulo], [Texto]) VALUES (2007, 2003, N'Pixel 4: visual do novo top de linha da Google é vazado', N'Diferentemente dos seus outros lançamentos, a Google tem se mantido discreta quanto ao design e as funcionalidades do seu próximo celular — que possivelmente será chamado de Pixel 4. Pouca coisa se sabe do novo modelo, mas uma recente renderização feita pelo Onleaks pode ajudar a ter uma ideia do que virá.

A renderização foi feita com base em esquemas vazados de prototipagem inicial, portanto, pode representar uma imagem fiel ao que será o celular ou uma versão já descartada pela empresa.

Se for real, podemos esperar um Pixel 4 com uma câmera quadrada no canto traseiro superior esquerdo e vidros com bordas curvas. Na parte frontal, o aparelho apresentaria apenas uma grade de alto-falante centralizada na parte superior. Não há registros de leitores de digital, o que indica que provavelmente será alocado sob a tela.

O telefone possivelmente terá uma porta USB-C e dois alto-falantes na parte de baixo. No lado esquerdo poderão estar os tradicionais botões de volume e de energia.')
INSERT [dbo].[Noticias] ([id_noticia], [id_autor], [Titulo], [Texto]) VALUES (2008, 2004, N'No avião, passageira confunde saída de emergência com porta do banheiro', N'Um incidente envolvendo uma mulher confusa e uma porta de emergência de um avião causou um atraso de oito horas em um voo que faz o percurso entre Manchester, na Inglaterra, e Islamabad, capital do Paquistão. Acontece que a passageira, dentro do avião que ainda não havia partido e estava parado no aeroporto, achou que a saída de emergência do avião era o banheiro e simplesmente abriu a porta.

O problema é que o sistema de segurança de um avião comercial como esse da Pakistan International Airlines faz com que aquele tobogã inflável de evacuação, na parte de fora da porta da aeronave, seja ativado automaticamente quando a porta de emergência é aberta. Ninguém se feriu, mas a atitude da mulher — que deveria estar sentada e com o cinto de segurança afivelado — fez com que o voo só fosse liberado para decolar quase oito horas depois do agendado.

A companhia aérea confirmou o acontecimento em uma nota: “Um passageiro equivocadamente abriu a porta de emergência, provocando a ativação do escorregador de emergência.” Os passageiros, que não puderam viajar no horário combinado, receberam toda assistência necessária por parte da Pakistan International Airlines e partiram quando o voo foi liberado.')
INSERT [dbo].[Noticias] ([id_noticia], [id_autor], [Titulo], [Texto]) VALUES (2009, 1, N'Cientistas resolvem paradoxo do gato de Schrödinger', N'Um dos paradoxos mais famosos da física quântica é o do gato de Schrödinger, desenvolvido pelo físico austríaco Erwin Schrödinger em 1935 e usado até hoje para ilustrar o conceito de superposição, que seria a capacidade de dois estados opostos existirem ao mesmo tempo.

A ideia de Schrödinger se baseia na experiência de um gato colocado dentro de uma caixa lacrada com uma fonte radioativa e um veneno que seria ativado se um átomo da substância radioativa se desintegrasse, dessa forma até que se abra a caixa (ponto de observaçao) o gato está ao mesmo tempo vivo e morto. Abrindo a caixa para observar, o gato muda abruptamente o seu estado quântico aleatoriamente, forçando-o a estar vivo ou morto, tal movimento chama-se salto quântico.

Esse paradoxo ressalta a imprevisibilidade da física quântica. O salto quântico é a mudança discreta, não contínua e aleatória no estado quando observada, e foi exatamente esse salto que os cientistas da Universidade de Yale, nos Estados Unidos, conseguiram prever e manipular.')
SET IDENTITY_INSERT [dbo].[Noticias] OFF
/****** Object:  Index [IX_Noticias_id_autor]    Script Date: 10/06/2019 21:11:51 ******/
CREATE NONCLUSTERED INDEX [IX_Noticias_id_autor] ON [dbo].[Noticias]
(
	[id_autor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Noticias]  WITH CHECK ADD  CONSTRAINT [FK_Autores] FOREIGN KEY([id_autor])
REFERENCES [dbo].[Autores] ([id_autor])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Noticias] CHECK CONSTRAINT [FK_Autores]
GO
USE [master]
GO
ALTER DATABASE [PortalNoticias] SET  READ_WRITE 
GO
