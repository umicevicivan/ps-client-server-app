USE [master]
GO
/****** Object:  Database [RecenzijaFilma]    Script Date: 17.07.2020. 17:53:40 ******/
CREATE DATABASE [RecenzijaFilma]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'RecenzijaFilma', FILENAME = N'C:\Users\PC\RecenzijaFilma.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'RecenzijaFilma_log', FILENAME = N'C:\Users\PC\RecenzijaFilma_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [RecenzijaFilma] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [RecenzijaFilma].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [RecenzijaFilma] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [RecenzijaFilma] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [RecenzijaFilma] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [RecenzijaFilma] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [RecenzijaFilma] SET ARITHABORT OFF 
GO
ALTER DATABASE [RecenzijaFilma] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [RecenzijaFilma] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [RecenzijaFilma] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [RecenzijaFilma] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [RecenzijaFilma] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [RecenzijaFilma] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [RecenzijaFilma] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [RecenzijaFilma] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [RecenzijaFilma] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [RecenzijaFilma] SET  DISABLE_BROKER 
GO
ALTER DATABASE [RecenzijaFilma] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [RecenzijaFilma] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [RecenzijaFilma] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [RecenzijaFilma] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [RecenzijaFilma] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [RecenzijaFilma] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [RecenzijaFilma] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [RecenzijaFilma] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [RecenzijaFilma] SET  MULTI_USER 
GO
ALTER DATABASE [RecenzijaFilma] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [RecenzijaFilma] SET DB_CHAINING OFF 
GO
ALTER DATABASE [RecenzijaFilma] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [RecenzijaFilma] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [RecenzijaFilma] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [RecenzijaFilma] SET QUERY_STORE = OFF
GO
USE [RecenzijaFilma]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
USE [RecenzijaFilma]
GO
/****** Object:  Table [dbo].[Film]    Script Date: 17.07.2020. 17:53:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Film](
	[IDFilm] [int] NOT NULL,
	[ImeFilma] [varchar](50) NULL,
	[Minutaza] [int] NULL,
	[OpisFilma] [varchar](50) NULL,
	[Budzet] [numeric](18, 2) NULL,
	[Zarada] [numeric](18, 2) NULL,
 CONSTRAINT [PK_Film] PRIMARY KEY CLUSTERED 
(
	[IDFilm] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Glumac]    Script Date: 17.07.2020. 17:53:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Glumac](
	[IDGlumca] [int] NOT NULL,
	[Ime] [varchar](50) NULL,
	[Prezime] [varchar](50) NULL,
	[Drzava] [varchar](50) NULL,
	[Pol] [int] NULL,
 CONSTRAINT [PK_Glumac] PRIMARY KEY CLUSTERED 
(
	[IDGlumca] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Korisnik]    Script Date: 17.07.2020. 17:53:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Korisnik](
	[KorisnikId] [int] NOT NULL,
	[Ime] [varchar](50) NOT NULL,
	[Prezime] [varchar](50) NOT NULL,
	[KorisnickoIme] [varchar](50) NOT NULL,
	[Pass] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Korisnik] PRIMARY KEY CLUSTERED 
(
	[KorisnikId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RecenzijaFilma]    Script Date: 17.07.2020. 17:53:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RecenzijaFilma](
	[IDRecenzijeFilma] [int] NOT NULL,
	[OpisRecenzije] [varchar](50) NULL,
	[IDFilm] [int] NULL,
	[IDKorisnika] [int] NULL,
 CONSTRAINT [PK_RecenzijaFilma] PRIMARY KEY CLUSTERED 
(
	[IDRecenzijeFilma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RecenzijaUloge]    Script Date: 17.07.2020. 17:53:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RecenzijaUloge](
	[IDRecenzijeFilma] [int] NOT NULL,
	[IDRecenzijeUloge] [int] NOT NULL,
	[Recenzija] [varchar](50) NULL,
	[IDFilm] [int] NULL,
	[IDGlumac] [int] NULL,
 CONSTRAINT [PK_RecenzijaUloge] PRIMARY KEY CLUSTERED 
(
	[IDRecenzijeFilma] ASC,
	[IDRecenzijeUloge] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Uloga]    Script Date: 17.07.2020. 17:53:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Uloga](
	[IDFilm] [int] NOT NULL,
	[IDGlumca] [int] NOT NULL,
	[NazivUloge] [varchar](50) NULL,
	[Zarada] [numeric](18, 2) NULL,
 CONSTRAINT [PK_Uloga_1] PRIMARY KEY CLUSTERED 
(
	[IDFilm] ASC,
	[IDGlumca] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Film] ([IDFilm], [ImeFilma], [Minutaza], [OpisFilma], [Budzet], [Zarada]) VALUES (1, N'Star Wars', 1, N'Sci-Fi', CAST(11.00 AS Numeric(18, 2)), CAST(22.00 AS Numeric(18, 2)))
INSERT [dbo].[Film] ([IDFilm], [ImeFilma], [Minutaza], [OpisFilma], [Budzet], [Zarada]) VALUES (2, N'Shutter Island', 123, N'Triller', CAST(1.11 AS Numeric(18, 2)), CAST(2.22 AS Numeric(18, 2)))
INSERT [dbo].[Film] ([IDFilm], [ImeFilma], [Minutaza], [OpisFilma], [Budzet], [Zarada]) VALUES (3, N'The Scent of a Woman', 123, N'Drama', CAST(222.00 AS Numeric(18, 2)), CAST(332.00 AS Numeric(18, 2)))
INSERT [dbo].[Film] ([IDFilm], [ImeFilma], [Minutaza], [OpisFilma], [Budzet], [Zarada]) VALUES (5, N'test', 12, N'test', CAST(123455.00 AS Numeric(18, 2)), CAST(12.12 AS Numeric(18, 2)))
INSERT [dbo].[Film] ([IDFilm], [ImeFilma], [Minutaza], [OpisFilma], [Budzet], [Zarada]) VALUES (6, N'test2', 123, N'test2', CAST(122.12 AS Numeric(18, 2)), CAST(12.12 AS Numeric(18, 2)))
INSERT [dbo].[Film] ([IDFilm], [ImeFilma], [Minutaza], [OpisFilma], [Budzet], [Zarada]) VALUES (7, N'American History X', 132, N'Crime Drama', CAST(12.12 AS Numeric(18, 2)), CAST(12.12 AS Numeric(18, 2)))
INSERT [dbo].[Film] ([IDFilm], [ImeFilma], [Minutaza], [OpisFilma], [Budzet], [Zarada]) VALUES (8, N'Interstellar', 1234, N'Sci-fi', CAST(999.99 AS Numeric(18, 2)), CAST(988.99 AS Numeric(18, 2)))
INSERT [dbo].[Film] ([IDFilm], [ImeFilma], [Minutaza], [OpisFilma], [Budzet], [Zarada]) VALUES (9, N'King Arthur', 1235, N'Akcija Avantura', CAST(12.12 AS Numeric(18, 2)), CAST(12.12 AS Numeric(18, 2)))
INSERT [dbo].[Film] ([IDFilm], [ImeFilma], [Minutaza], [OpisFilma], [Budzet], [Zarada]) VALUES (10, N'The Godfather', 365, N'Crime Mafia Drama', CAST(66546.12 AS Numeric(18, 2)), CAST(654789.12 AS Numeric(18, 2)))
INSERT [dbo].[Film] ([IDFilm], [ImeFilma], [Minutaza], [OpisFilma], [Budzet], [Zarada]) VALUES (11, N'The Dark Knight', 125, N'Akcija Strip', CAST(125487.25 AS Numeric(18, 2)), CAST(125632.25 AS Numeric(18, 2)))
INSERT [dbo].[Film] ([IDFilm], [ImeFilma], [Minutaza], [OpisFilma], [Budzet], [Zarada]) VALUES (12, N'Gladiator', 144, N'Akcija', CAST(999.99 AS Numeric(18, 2)), CAST(999.99 AS Numeric(18, 2)))
INSERT [dbo].[Film] ([IDFilm], [ImeFilma], [Minutaza], [OpisFilma], [Budzet], [Zarada]) VALUES (13, N'Test2', 222, N'dasdas', CAST(2222.22 AS Numeric(18, 2)), CAST(2222.22 AS Numeric(18, 2)))
INSERT [dbo].[Film] ([IDFilm], [ImeFilma], [Minutaza], [OpisFilma], [Budzet], [Zarada]) VALUES (15, N'Lajanje na zvezde', 78, N'Domaci film', CAST(6789.23 AS Numeric(18, 2)), CAST(2323.32 AS Numeric(18, 2)))
INSERT [dbo].[Film] ([IDFilm], [ImeFilma], [Minutaza], [OpisFilma], [Budzet], [Zarada]) VALUES (16, N'Blade Runner', 117, N'Sci-Fi Akcija Triler', CAST(2541212.25 AS Numeric(18, 2)), CAST(2315.25 AS Numeric(18, 2)))
INSERT [dbo].[Film] ([IDFilm], [ImeFilma], [Minutaza], [OpisFilma], [Budzet], [Zarada]) VALUES (17, N'Test', 123, N'Test', CAST(222.22 AS Numeric(18, 2)), CAST(22.22 AS Numeric(18, 2)))
INSERT [dbo].[Film] ([IDFilm], [ImeFilma], [Minutaza], [OpisFilma], [Budzet], [Zarada]) VALUES (18, N'test', 111, N'test', CAST(22.22 AS Numeric(18, 2)), CAST(222.22 AS Numeric(18, 2)))
INSERT [dbo].[Film] ([IDFilm], [ImeFilma], [Minutaza], [OpisFilma], [Budzet], [Zarada]) VALUES (19, N'aaa', 12, N'aaa', CAST(12.12 AS Numeric(18, 2)), CAST(12.12 AS Numeric(18, 2)))
INSERT [dbo].[Film] ([IDFilm], [ImeFilma], [Minutaza], [OpisFilma], [Budzet], [Zarada]) VALUES (20, N'ivan', 987, N'ivan', CAST(99.99 AS Numeric(18, 2)), CAST(99.99 AS Numeric(18, 2)))
INSERT [dbo].[Film] ([IDFilm], [ImeFilma], [Minutaza], [OpisFilma], [Budzet], [Zarada]) VALUES (21, N'aaa', 123, N'aaa', CAST(22.22 AS Numeric(18, 2)), CAST(22.22 AS Numeric(18, 2)))
INSERT [dbo].[Film] ([IDFilm], [ImeFilma], [Minutaza], [OpisFilma], [Budzet], [Zarada]) VALUES (22, N'dasdasd', 12, N'dasdas', CAST(22.22 AS Numeric(18, 2)), CAST(22.22 AS Numeric(18, 2)))
INSERT [dbo].[Glumac] ([IDGlumca], [Ime], [Prezime], [Drzava], [Pol]) VALUES (1, N'Ivan', N'Ivanovic', N'Srbija', 0)
INSERT [dbo].[Glumac] ([IDGlumca], [Ime], [Prezime], [Drzava], [Pol]) VALUES (3, N'Emma', N'Watson', N'Britanija', 1)
INSERT [dbo].[Glumac] ([IDGlumca], [Ime], [Prezime], [Drzava], [Pol]) VALUES (4, N'Ivan', N'Umicevic', N'Srbija', 0)
INSERT [dbo].[Glumac] ([IDGlumca], [Ime], [Prezime], [Drzava], [Pol]) VALUES (5, N'Mila', N'Kunis', N'Ukraina', 1)
INSERT [dbo].[Glumac] ([IDGlumca], [Ime], [Prezime], [Drzava], [Pol]) VALUES (6, N'Hugh', N'Jackman', N'Australia', 0)
INSERT [dbo].[Glumac] ([IDGlumca], [Ime], [Prezime], [Drzava], [Pol]) VALUES (7, N'Leonardo', N'DiCaprio', N'SAD', 0)
INSERT [dbo].[Glumac] ([IDGlumca], [Ime], [Prezime], [Drzava], [Pol]) VALUES (8, N'Jennifer', N'Lawrence', N'SAD', 1)
INSERT [dbo].[Glumac] ([IDGlumca], [Ime], [Prezime], [Drzava], [Pol]) VALUES (9, N'Harison', N'Ford', N'SAD', 0)
INSERT [dbo].[Glumac] ([IDGlumca], [Ime], [Prezime], [Drzava], [Pol]) VALUES (10, N'Mila', N'Jovovich', N'Ukraina', 1)
INSERT [dbo].[Glumac] ([IDGlumca], [Ime], [Prezime], [Drzava], [Pol]) VALUES (11, N'test', N'test', N'srbija', 1)
INSERT [dbo].[Glumac] ([IDGlumca], [Ime], [Prezime], [Drzava], [Pol]) VALUES (12, N'Dzeki', N'Cen', N'Kina', 0)
INSERT [dbo].[Korisnik] ([KorisnikId], [Ime], [Prezime], [KorisnickoIme], [Pass]) VALUES (1, N'Ivan', N'Umicevic', N'ivan', N'123')
INSERT [dbo].[Korisnik] ([KorisnikId], [Ime], [Prezime], [KorisnickoIme], [Pass]) VALUES (2, N'Perica', N'Peric', N'pera', N'123')
INSERT [dbo].[RecenzijaFilma] ([IDRecenzijeFilma], [OpisRecenzije], [IDFilm], [IDKorisnika]) VALUES (1, N'aaaaa', 8, 1)
INSERT [dbo].[RecenzijaFilma] ([IDRecenzijeFilma], [OpisRecenzije], [IDFilm], [IDKorisnika]) VALUES (2, N'Odlican mafijaski film, sve pohvale', 10, 2)
INSERT [dbo].[RecenzijaFilma] ([IDRecenzijeFilma], [OpisRecenzije], [IDFilm], [IDKorisnika]) VALUES (3, N'Odlican sci fi film', 8, 2)
INSERT [dbo].[RecenzijaFilma] ([IDRecenzijeFilma], [OpisRecenzije], [IDFilm], [IDKorisnika]) VALUES (4, N'aaaaaaa', 12, 1)
INSERT [dbo].[RecenzijaFilma] ([IDRecenzijeFilma], [OpisRecenzije], [IDFilm], [IDKorisnika]) VALUES (5, N'Najbolja adaptacija strip junaka do sada', 11, 1)
INSERT [dbo].[RecenzijaFilma] ([IDRecenzijeFilma], [OpisRecenzije], [IDFilm], [IDKorisnika]) VALUES (6, N'Test', 13, 1)
INSERT [dbo].[RecenzijaFilma] ([IDRecenzijeFilma], [OpisRecenzije], [IDFilm], [IDKorisnika]) VALUES (7, N'Krimi drama u kojoj glumi Edvard Norton', 7, 1)
INSERT [dbo].[RecenzijaFilma] ([IDRecenzijeFilma], [OpisRecenzije], [IDFilm], [IDKorisnika]) VALUES (8, N'Odlican domaci film!', 15, 1)
INSERT [dbo].[RecenzijaFilma] ([IDRecenzijeFilma], [OpisRecenzije], [IDFilm], [IDKorisnika]) VALUES (9, N'Odlican akciioni film koji govori o Rimu', 12, 1)
INSERT [dbo].[RecenzijaFilma] ([IDRecenzijeFilma], [OpisRecenzije], [IDFilm], [IDKorisnika]) VALUES (10, N'test', 10, 1)
INSERT [dbo].[RecenzijaFilma] ([IDRecenzijeFilma], [OpisRecenzije], [IDFilm], [IDKorisnika]) VALUES (11, N'tes', 16, 1)
INSERT [dbo].[RecenzijaFilma] ([IDRecenzijeFilma], [OpisRecenzije], [IDFilm], [IDKorisnika]) VALUES (12, N'Domaci film', 15, 1)
INSERT [dbo].[RecenzijaUloge] ([IDRecenzijeFilma], [IDRecenzijeUloge], [Recenzija], [IDFilm], [IDGlumac]) VALUES (1, 1, N'bbbbb', 8, 3)
INSERT [dbo].[RecenzijaUloge] ([IDRecenzijeFilma], [IDRecenzijeUloge], [Recenzija], [IDFilm], [IDGlumac]) VALUES (1, 2, N'cccccc', 8, 5)
INSERT [dbo].[RecenzijaUloge] ([IDRecenzijeFilma], [IDRecenzijeUloge], [Recenzija], [IDFilm], [IDGlumac]) VALUES (2, 3, N'Sjajna gluma!', 10, 5)
INSERT [dbo].[RecenzijaUloge] ([IDRecenzijeFilma], [IDRecenzijeUloge], [Recenzija], [IDFilm], [IDGlumac]) VALUES (2, 4, N'Nikad bolja gluma wow!', 10, 6)
INSERT [dbo].[RecenzijaUloge] ([IDRecenzijeFilma], [IDRecenzijeUloge], [Recenzija], [IDFilm], [IDGlumac]) VALUES (3, 5, N'super!', 8, 5)
INSERT [dbo].[RecenzijaUloge] ([IDRecenzijeFilma], [IDRecenzijeUloge], [Recenzija], [IDFilm], [IDGlumac]) VALUES (3, 6, N'najbolja gluma', 8, 3)
INSERT [dbo].[RecenzijaUloge] ([IDRecenzijeFilma], [IDRecenzijeUloge], [Recenzija], [IDFilm], [IDGlumac]) VALUES (4, 1, N'bbbbbbbbb', 12, 5)
INSERT [dbo].[RecenzijaUloge] ([IDRecenzijeFilma], [IDRecenzijeUloge], [Recenzija], [IDFilm], [IDGlumac]) VALUES (4, 2, N'ccccccccccc', 12, 7)
INSERT [dbo].[RecenzijaUloge] ([IDRecenzijeFilma], [IDRecenzijeUloge], [Recenzija], [IDFilm], [IDGlumac]) VALUES (4, 3, N'ddddddddddd', 12, 6)
INSERT [dbo].[RecenzijaUloge] ([IDRecenzijeFilma], [IDRecenzijeUloge], [Recenzija], [IDFilm], [IDGlumac]) VALUES (5, 1, N'Uloga koja je osvojila oskara!', 11, 5)
INSERT [dbo].[RecenzijaUloge] ([IDRecenzijeFilma], [IDRecenzijeUloge], [Recenzija], [IDFilm], [IDGlumac]) VALUES (5, 2, N'Cristian Bale se pronasao u ovoj ulozi', 11, 6)
INSERT [dbo].[RecenzijaUloge] ([IDRecenzijeFilma], [IDRecenzijeUloge], [Recenzija], [IDFilm], [IDGlumac]) VALUES (7, 1, N'Test1', 7, 5)
INSERT [dbo].[RecenzijaUloge] ([IDRecenzijeFilma], [IDRecenzijeUloge], [Recenzija], [IDFilm], [IDGlumac]) VALUES (8, 1, N'Savrseno odglumljeno', 15, 7)
INSERT [dbo].[RecenzijaUloge] ([IDRecenzijeFilma], [IDRecenzijeUloge], [Recenzija], [IDFilm], [IDGlumac]) VALUES (9, 1, N'Odlicno odglumljen negativac!', 12, 7)
INSERT [dbo].[RecenzijaUloge] ([IDRecenzijeFilma], [IDRecenzijeUloge], [Recenzija], [IDFilm], [IDGlumac]) VALUES (9, 2, N'Najbolji protagonista ikada', 12, 6)
INSERT [dbo].[RecenzijaUloge] ([IDRecenzijeFilma], [IDRecenzijeUloge], [Recenzija], [IDFilm], [IDGlumac]) VALUES (10, 1, N'test', 10, 3)
INSERT [dbo].[RecenzijaUloge] ([IDRecenzijeFilma], [IDRecenzijeUloge], [Recenzija], [IDFilm], [IDGlumac]) VALUES (10, 2, N'test', 10, 3)
INSERT [dbo].[RecenzijaUloge] ([IDRecenzijeFilma], [IDRecenzijeUloge], [Recenzija], [IDFilm], [IDGlumac]) VALUES (11, 1, N'test', 16, 9)
INSERT [dbo].[RecenzijaUloge] ([IDRecenzijeFilma], [IDRecenzijeUloge], [Recenzija], [IDFilm], [IDGlumac]) VALUES (11, 2, N'aaaa', 16, 5)
INSERT [dbo].[RecenzijaUloge] ([IDRecenzijeFilma], [IDRecenzijeUloge], [Recenzija], [IDFilm], [IDGlumac]) VALUES (12, 1, N'test lajanje', 15, 7)
INSERT [dbo].[Uloga] ([IDFilm], [IDGlumca], [NazivUloge], [Zarada]) VALUES (5, 5, N'aaaa', CAST(123.12 AS Numeric(18, 2)))
INSERT [dbo].[Uloga] ([IDFilm], [IDGlumca], [NazivUloge], [Zarada]) VALUES (6, 3, N'hhhhh', CAST(123.20 AS Numeric(18, 2)))
INSERT [dbo].[Uloga] ([IDFilm], [IDGlumca], [NazivUloge], [Zarada]) VALUES (7, 5, N'dasdsadasd', CAST(777.77 AS Numeric(18, 2)))
INSERT [dbo].[Uloga] ([IDFilm], [IDGlumca], [NazivUloge], [Zarada]) VALUES (8, 3, N'sporedni', CAST(88.88 AS Numeric(18, 2)))
INSERT [dbo].[Uloga] ([IDFilm], [IDGlumca], [NazivUloge], [Zarada]) VALUES (8, 5, N'glavni', CAST(77.77 AS Numeric(18, 2)))
INSERT [dbo].[Uloga] ([IDFilm], [IDGlumca], [NazivUloge], [Zarada]) VALUES (9, 6, N'Artur', CAST(77.77 AS Numeric(18, 2)))
INSERT [dbo].[Uloga] ([IDFilm], [IDGlumca], [NazivUloge], [Zarada]) VALUES (10, 3, N'Sonny Corleone', CAST(698751.15 AS Numeric(18, 2)))
INSERT [dbo].[Uloga] ([IDFilm], [IDGlumca], [NazivUloge], [Zarada]) VALUES (10, 5, N'Don Vito Corleone', CAST(100000.10 AS Numeric(18, 2)))
INSERT [dbo].[Uloga] ([IDFilm], [IDGlumca], [NazivUloge], [Zarada]) VALUES (10, 6, N'Michael Corleone', CAST(6589745.12 AS Numeric(18, 2)))
INSERT [dbo].[Uloga] ([IDFilm], [IDGlumca], [NazivUloge], [Zarada]) VALUES (11, 5, N'Joker', CAST(5697452.36 AS Numeric(18, 2)))
INSERT [dbo].[Uloga] ([IDFilm], [IDGlumca], [NazivUloge], [Zarada]) VALUES (11, 6, N'The Batman', CAST(55643352.12 AS Numeric(18, 2)))
INSERT [dbo].[Uloga] ([IDFilm], [IDGlumca], [NazivUloge], [Zarada]) VALUES (12, 5, N'Lucilla', CAST(369857.36 AS Numeric(18, 2)))
INSERT [dbo].[Uloga] ([IDFilm], [IDGlumca], [NazivUloge], [Zarada]) VALUES (12, 6, N'Maximus', CAST(125478.36 AS Numeric(18, 2)))
INSERT [dbo].[Uloga] ([IDFilm], [IDGlumca], [NazivUloge], [Zarada]) VALUES (12, 7, N'Commodus', CAST(25986.58 AS Numeric(18, 2)))
INSERT [dbo].[Uloga] ([IDFilm], [IDGlumca], [NazivUloge], [Zarada]) VALUES (13, 6, N'Test', CAST(232323.00 AS Numeric(18, 2)))
INSERT [dbo].[Uloga] ([IDFilm], [IDGlumca], [NazivUloge], [Zarada]) VALUES (15, 7, N'Filozof', CAST(1234.23 AS Numeric(18, 2)))
INSERT [dbo].[Uloga] ([IDFilm], [IDGlumca], [NazivUloge], [Zarada]) VALUES (16, 5, N'Rachael', CAST(254872.25 AS Numeric(18, 2)))
INSERT [dbo].[Uloga] ([IDFilm], [IDGlumca], [NazivUloge], [Zarada]) VALUES (16, 9, N'Rick Deckard', CAST(125876.25 AS Numeric(18, 2)))
INSERT [dbo].[Uloga] ([IDFilm], [IDGlumca], [NazivUloge], [Zarada]) VALUES (17, 10, N'test', CAST(222.22 AS Numeric(18, 2)))
INSERT [dbo].[Uloga] ([IDFilm], [IDGlumca], [NazivUloge], [Zarada]) VALUES (18, 9, N'dasds', CAST(2222.00 AS Numeric(18, 2)))
INSERT [dbo].[Uloga] ([IDFilm], [IDGlumca], [NazivUloge], [Zarada]) VALUES (19, 9, N'aaa', CAST(12.12 AS Numeric(18, 2)))
INSERT [dbo].[Uloga] ([IDFilm], [IDGlumca], [NazivUloge], [Zarada]) VALUES (19, 10, N'aaa', CAST(12.12 AS Numeric(18, 2)))
INSERT [dbo].[Uloga] ([IDFilm], [IDGlumca], [NazivUloge], [Zarada]) VALUES (20, 8, N'pppp', CAST(33.33 AS Numeric(18, 2)))
INSERT [dbo].[Uloga] ([IDFilm], [IDGlumca], [NazivUloge], [Zarada]) VALUES (20, 12, N'ivan', CAST(12.12 AS Numeric(18, 2)))
INSERT [dbo].[Uloga] ([IDFilm], [IDGlumca], [NazivUloge], [Zarada]) VALUES (21, 6, N'bbb', CAST(88.88 AS Numeric(18, 2)))
INSERT [dbo].[Uloga] ([IDFilm], [IDGlumca], [NazivUloge], [Zarada]) VALUES (21, 10, N'aaa', CAST(12.12 AS Numeric(18, 2)))
INSERT [dbo].[Uloga] ([IDFilm], [IDGlumca], [NazivUloge], [Zarada]) VALUES (22, 8, N'dasdas', CAST(22.22 AS Numeric(18, 2)))
INSERT [dbo].[Uloga] ([IDFilm], [IDGlumca], [NazivUloge], [Zarada]) VALUES (22, 9, N'dasdasd', CAST(22.22 AS Numeric(18, 2)))
ALTER TABLE [dbo].[RecenzijaFilma]  WITH CHECK ADD  CONSTRAINT [FK_RecenzijaFilma_Film] FOREIGN KEY([IDFilm])
REFERENCES [dbo].[Film] ([IDFilm])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[RecenzijaFilma] CHECK CONSTRAINT [FK_RecenzijaFilma_Film]
GO
ALTER TABLE [dbo].[RecenzijaFilma]  WITH CHECK ADD  CONSTRAINT [FK_RecenzijaFilma_Korisnik] FOREIGN KEY([IDKorisnika])
REFERENCES [dbo].[Korisnik] ([KorisnikId])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[RecenzijaFilma] CHECK CONSTRAINT [FK_RecenzijaFilma_Korisnik]
GO
ALTER TABLE [dbo].[RecenzijaUloge]  WITH CHECK ADD FOREIGN KEY([IDFilm])
REFERENCES [dbo].[Film] ([IDFilm])
GO
ALTER TABLE [dbo].[RecenzijaUloge]  WITH CHECK ADD FOREIGN KEY([IDGlumac])
REFERENCES [dbo].[Glumac] ([IDGlumca])
GO
ALTER TABLE [dbo].[RecenzijaUloge]  WITH CHECK ADD  CONSTRAINT [FK_RecenzijaUloge_RecenzijaFilma] FOREIGN KEY([IDRecenzijeFilma])
REFERENCES [dbo].[RecenzijaFilma] ([IDRecenzijeFilma])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[RecenzijaUloge] CHECK CONSTRAINT [FK_RecenzijaUloge_RecenzijaFilma]
GO
ALTER TABLE [dbo].[Uloga]  WITH CHECK ADD  CONSTRAINT [FK_Uloga_Film] FOREIGN KEY([IDGlumca])
REFERENCES [dbo].[Film] ([IDFilm])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Uloga] CHECK CONSTRAINT [FK_Uloga_Film]
GO
ALTER TABLE [dbo].[Uloga]  WITH CHECK ADD  CONSTRAINT [FK_Uloga_Glumac] FOREIGN KEY([IDGlumca])
REFERENCES [dbo].[Glumac] ([IDGlumca])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Uloga] CHECK CONSTRAINT [FK_Uloga_Glumac]
GO
USE [master]
GO
ALTER DATABASE [RecenzijaFilma] SET  READ_WRITE 
GO
