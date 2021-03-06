USE [Igraionica]
GO
ALTER TABLE [dbo].[AccSony] DROP CONSTRAINT [FK__AccSony__TipS__145C0A3F]
GO
ALTER TABLE [dbo].[AccPc] DROP CONSTRAINT [FK__AccPc__TipP__173876EA]
GO
/****** Object:  Table [dbo].[TipSony]    Script Date: 7/24/2017 8:32:14 PM ******/
DROP TABLE [dbo].[TipSony]
GO
/****** Object:  Table [dbo].[TipPc]    Script Date: 7/24/2017 8:32:14 PM ******/
DROP TABLE [dbo].[TipPc]
GO
/****** Object:  Table [dbo].[AdminAcc]    Script Date: 7/24/2017 8:32:14 PM ******/
DROP TABLE [dbo].[AdminAcc]
GO
/****** Object:  Table [dbo].[AccSony]    Script Date: 7/24/2017 8:32:14 PM ******/
DROP TABLE [dbo].[AccSony]
GO
/****** Object:  Table [dbo].[AccPc]    Script Date: 7/24/2017 8:32:14 PM ******/
DROP TABLE [dbo].[AccPc]
GO
USE [master]
GO
/****** Object:  Database [Igraionica]    Script Date: 7/24/2017 8:32:14 PM ******/
DROP DATABASE [Igraionica]
GO
/****** Object:  Database [Igraionica]    Script Date: 7/24/2017 8:32:14 PM ******/
CREATE DATABASE [Igraionica]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Igraionica', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\Igraionica.mdf' , SIZE = 3264KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Igraionica_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\Igraionica_log.ldf' , SIZE = 816KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Igraionica] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Igraionica].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Igraionica] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Igraionica] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Igraionica] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Igraionica] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Igraionica] SET ARITHABORT OFF 
GO
ALTER DATABASE [Igraionica] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [Igraionica] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Igraionica] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Igraionica] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Igraionica] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Igraionica] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Igraionica] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Igraionica] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Igraionica] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Igraionica] SET  ENABLE_BROKER 
GO
ALTER DATABASE [Igraionica] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Igraionica] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Igraionica] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Igraionica] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Igraionica] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Igraionica] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Igraionica] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Igraionica] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Igraionica] SET  MULTI_USER 
GO
ALTER DATABASE [Igraionica] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Igraionica] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Igraionica] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Igraionica] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [Igraionica] SET DELAYED_DURABILITY = DISABLED 
GO
USE [Igraionica]
GO
/****** Object:  Table [dbo].[AccPc]    Script Date: 7/24/2017 8:32:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[AccPc](
	[Sifra] [int] NOT NULL,
	[username] [varchar](30) NOT NULL,
	[pass] [varchar](30) NOT NULL,
	[TipP] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Sifra] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[AccSony]    Script Date: 7/24/2017 8:32:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[AccSony](
	[Sifra] [int] NOT NULL,
	[username] [varchar](30) NOT NULL,
	[pass] [varchar](30) NOT NULL,
	[TipS] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Sifra] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[AdminAcc]    Script Date: 7/24/2017 8:32:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[AdminAcc](
	[username] [varchar](30) NOT NULL,
	[pass] [varchar](30) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TipPc]    Script Date: 7/24/2017 8:32:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TipPc](
	[TipP] [int] NOT NULL,
	[Opis] [varchar](30) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[TipP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TipSony]    Script Date: 7/24/2017 8:32:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TipSony](
	[TipS] [int] NOT NULL,
	[Opis] [varchar](30) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[TipS] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[AccPc] ([Sifra], [username], [pass], [TipP]) VALUES (1, N'aaa', N'bbb', 1)
INSERT [dbo].[AccPc] ([Sifra], [username], [pass], [TipP]) VALUES (2, N'bbb', N'ccc', 1)
INSERT [dbo].[AccSony] ([Sifra], [username], [pass], [TipS]) VALUES (1, N'zika', N'mika', 2)
INSERT [dbo].[AccSony] ([Sifra], [username], [pass], [TipS]) VALUES (2, N'Has', N'has', 1)
INSERT [dbo].[AccSony] ([Sifra], [username], [pass], [TipS]) VALUES (3, N'ama23', N'aaa', 3)
INSERT [dbo].[AdminAcc] ([username], [pass]) VALUES (N'Dusan', N'123')
INSERT [dbo].[TipPc] ([TipP], [Opis]) VALUES (1, N'Jeftiniji')
INSERT [dbo].[TipPc] ([TipP], [Opis]) VALUES (2, N'Skuplji')
INSERT [dbo].[TipSony] ([TipS], [Opis]) VALUES (1, N'Playstation1')
INSERT [dbo].[TipSony] ([TipS], [Opis]) VALUES (2, N'Playstaiton2')
INSERT [dbo].[TipSony] ([TipS], [Opis]) VALUES (3, N'Playstation3')
INSERT [dbo].[TipSony] ([TipS], [Opis]) VALUES (4, N'Playstation4')
ALTER TABLE [dbo].[AccPc]  WITH CHECK ADD FOREIGN KEY([TipP])
REFERENCES [dbo].[TipPc] ([TipP])
GO
ALTER TABLE [dbo].[AccSony]  WITH CHECK ADD FOREIGN KEY([TipS])
REFERENCES [dbo].[TipSony] ([TipS])
GO
USE [master]
GO
ALTER DATABASE [Igraionica] SET  READ_WRITE 
GO
