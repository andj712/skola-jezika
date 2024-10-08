USE [master]
GO
/****** Object:  Database [bazaJezici]    Script Date: 19.2.2024. 12:04:43 ******/
CREATE DATABASE [bazaJezici]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'bazaSeminarski', FILENAME = N'C:\Users\andj7\bazaSeminarski.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'bazaSeminarski_log', FILENAME = N'C:\Users\andj7\bazaSeminarski_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [bazaJezici] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [bazaJezici].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [bazaJezici] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [bazaJezici] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [bazaJezici] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [bazaJezici] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [bazaJezici] SET ARITHABORT OFF 
GO
ALTER DATABASE [bazaJezici] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [bazaJezici] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [bazaJezici] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [bazaJezici] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [bazaJezici] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [bazaJezici] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [bazaJezici] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [bazaJezici] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [bazaJezici] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [bazaJezici] SET  DISABLE_BROKER 
GO
ALTER DATABASE [bazaJezici] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [bazaJezici] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [bazaJezici] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [bazaJezici] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [bazaJezici] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [bazaJezici] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [bazaJezici] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [bazaJezici] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [bazaJezici] SET  MULTI_USER 
GO
ALTER DATABASE [bazaJezici] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [bazaJezici] SET DB_CHAINING OFF 
GO
ALTER DATABASE [bazaJezici] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [bazaJezici] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [bazaJezici] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [bazaJezici] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [bazaJezici] SET QUERY_STORE = OFF
GO
USE [bazaJezici]
GO
/****** Object:  Table [dbo].[Grupa]    Script Date: 19.2.2024. 12:04:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Grupa](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nazivGrupe] [varchar](30) NOT NULL,
	[datumPocetka] [date] NOT NULL,
	[idKursa] [int] NOT NULL,
 CONSTRAINT [PK_Grupa] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Jezik]    Script Date: 19.2.2024. 12:04:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Jezik](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nazivJezika] [varchar](30) NOT NULL,
 CONSTRAINT [PK_Jezik] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Korisnik]    Script Date: 19.2.2024. 12:04:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Korisnik](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[ime] [varchar](30) NOT NULL,
	[prezime] [varchar](30) NOT NULL,
	[korisnickoIme] [varchar](30) NOT NULL,
	[lozinka] [varchar](30) NOT NULL,
	[mejl] [varchar](30) NOT NULL,
	[kontaktTelefon] [varchar](10) NOT NULL,
	[datumRodjenja] [date] NOT NULL,
 CONSTRAINT [PK_Korisnik] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Kurs]    Script Date: 19.2.2024. 12:04:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kurs](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nazivKursa] [varchar](50) NOT NULL,
	[trajanje] [varchar](50) NOT NULL,
	[opisKursa] [varchar](50) NOT NULL,
	[ukupanBrojCasova] [int] NOT NULL,
	[idjezika] [int] NOT NULL,
 CONSTRAINT [PK_Kurs] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Prijava]    Script Date: 19.2.2024. 12:04:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Prijava](
	[idKorisnika] [int] NOT NULL,
	[idGrupe] [int] NOT NULL,
	[datumPrijave] [date] NOT NULL,
 CONSTRAINT [PK_Prijava_1] PRIMARY KEY CLUSTERED 
(
	[idKorisnika] ASC,
	[idGrupe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Raspored]    Script Date: 19.2.2024. 12:04:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Raspored](
	[idGrupe] [int] NOT NULL,
	[dan] [varchar](30) NOT NULL,
	[trajanje] [varchar](30) NOT NULL,
	[brojSale] [varchar](30) NOT NULL,
	[vremePocetka] [varchar](30) NOT NULL,
 CONSTRAINT [PK_Raspored] PRIMARY KEY CLUSTERED 
(
	[idGrupe] ASC,
	[dan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Grupa] ON 

INSERT [dbo].[Grupa] ([id], [nazivGrupe], [datumPocetka], [idKursa]) VALUES (3, N'Grupa april', CAST(N'2024-04-03' AS Date), 2003)
INSERT [dbo].[Grupa] ([id], [nazivGrupe], [datumPocetka], [idKursa]) VALUES (4, N'Grupa februar', CAST(N'2024-02-15' AS Date), 2003)
INSERT [dbo].[Grupa] ([id], [nazivGrupe], [datumPocetka], [idKursa]) VALUES (1009, N'Grupa 1.maj', CAST(N'2024-05-01' AS Date), 4)
INSERT [dbo].[Grupa] ([id], [nazivGrupe], [datumPocetka], [idKursa]) VALUES (1010, N'Junski', CAST(N'2024-06-20' AS Date), 4)
INSERT [dbo].[Grupa] ([id], [nazivGrupe], [datumPocetka], [idKursa]) VALUES (1011, N'Mart A Italijanski', CAST(N'2024-03-06' AS Date), 2003)
INSERT [dbo].[Grupa] ([id], [nazivGrupe], [datumPocetka], [idKursa]) VALUES (2012, N'Junski', CAST(N'2024-06-06' AS Date), 2003)
INSERT [dbo].[Grupa] ([id], [nazivGrupe], [datumPocetka], [idKursa]) VALUES (3011, N'Februarska', CAST(N'2024-02-17' AS Date), 2003)
INSERT [dbo].[Grupa] ([id], [nazivGrupe], [datumPocetka], [idKursa]) VALUES (4011, N'Aprilili', CAST(N'2024-04-01' AS Date), 2003)
INSERT [dbo].[Grupa] ([id], [nazivGrupe], [datumPocetka], [idKursa]) VALUES (4012, N'Aprilska', CAST(N'2024-04-01' AS Date), 2003)
INSERT [dbo].[Grupa] ([id], [nazivGrupe], [datumPocetka], [idKursa]) VALUES (4013, N'februar', CAST(N'2024-02-19' AS Date), 4)
INSERT [dbo].[Grupa] ([id], [nazivGrupe], [datumPocetka], [idKursa]) VALUES (5011, N'Februar 20.', CAST(N'2024-02-20' AS Date), 4)
SET IDENTITY_INSERT [dbo].[Grupa] OFF
GO
SET IDENTITY_INSERT [dbo].[Jezik] ON 

INSERT [dbo].[Jezik] ([id], [nazivJezika]) VALUES (1, N'Francuski')
INSERT [dbo].[Jezik] ([id], [nazivJezika]) VALUES (2, N'Španski')
INSERT [dbo].[Jezik] ([id], [nazivJezika]) VALUES (3, N'Italijanski')
SET IDENTITY_INSERT [dbo].[Jezik] OFF
GO
SET IDENTITY_INSERT [dbo].[Korisnik] ON 

INSERT [dbo].[Korisnik] ([id], [ime], [prezime], [korisnickoIme], [lozinka], [mejl], [kontaktTelefon], [datumRodjenja]) VALUES (1, N'Andjela', N'Kovacevic', N'andj712', N'andj712!', N'andj712@gmail.com', N'0616108669', CAST(N'2001-12-07' AS Date))
INSERT [dbo].[Korisnik] ([id], [ime], [prezime], [korisnickoIme], [lozinka], [mejl], [kontaktTelefon], [datumRodjenja]) VALUES (3, N'Pera', N'Peric', N'pera712', N'pera712!', N'pera@pera', N'0601234567', CAST(N'2001-01-20' AS Date))
INSERT [dbo].[Korisnik] ([id], [ime], [prezime], [korisnickoIme], [lozinka], [mejl], [kontaktTelefon], [datumRodjenja]) VALUES (1002, N'Aleks', N'Tucovic', N'ajdskja', N'djsakjads!', N'da@ddw', N'0616109889', CAST(N'2024-02-05' AS Date))
INSERT [dbo].[Korisnik] ([id], [ime], [prezime], [korisnickoIme], [lozinka], [mejl], [kontaktTelefon], [datumRodjenja]) VALUES (2002, N'Aleksandra', N'Tucovic', N'aleksandra', N'aleksandra!', N'aleks@gmail.com', N'0607333530', CAST(N'2001-02-27' AS Date))
INSERT [dbo].[Korisnik] ([id], [ime], [prezime], [korisnickoIme], [lozinka], [mejl], [kontaktTelefon], [datumRodjenja]) VALUES (2008, N'Aleksandra', N'Tucovic', N'aleks', N'aleks!', N'aleks@gmail.com', N'0616108669', CAST(N'2019-06-12' AS Date))
INSERT [dbo].[Korisnik] ([id], [ime], [prezime], [korisnickoIme], [lozinka], [mejl], [kontaktTelefon], [datumRodjenja]) VALUES (2010, N'Aleksandra', N'Tucovic', N'alekss', N'aleks!', N'aleks@gmail.com', N'0616108669', CAST(N'2019-06-12' AS Date))
INSERT [dbo].[Korisnik] ([id], [ime], [prezime], [korisnickoIme], [lozinka], [mejl], [kontaktTelefon], [datumRodjenja]) VALUES (2011, N'Ana', N'Kovacevic', N'ddsaa', N'sadsa!', N'ansnw@ajajas', N'0616108669', CAST(N'2008-10-29' AS Date))
INSERT [dbo].[Korisnik] ([id], [ime], [prezime], [korisnickoIme], [lozinka], [mejl], [kontaktTelefon], [datumRodjenja]) VALUES (2012, N'Ana', N'Matovic', N'adsada', N'dad!cfs', N'as@das', N'0616108669', CAST(N'2021-06-08' AS Date))
INSERT [dbo].[Korisnik] ([id], [ime], [prezime], [korisnickoIme], [lozinka], [mejl], [kontaktTelefon], [datumRodjenja]) VALUES (2013, N'Marija', N'Matic', N'dsads', N'daddaa!', N'asa@jd', N'0616108669', CAST(N'2023-05-01' AS Date))
INSERT [dbo].[Korisnik] ([id], [ime], [prezime], [korisnickoIme], [lozinka], [mejl], [kontaktTelefon], [datumRodjenja]) VALUES (3011, N'Anastasija', N'Matovic', N'ana712', N'ana712!', N'ana@matovic', N'0616108669', CAST(N'2023-11-22' AS Date))
SET IDENTITY_INSERT [dbo].[Korisnik] OFF
GO
SET IDENTITY_INSERT [dbo].[Kurs] ON 

INSERT [dbo].[Kurs] ([id], [nazivKursa], [trajanje], [opisKursa], [ukupanBrojCasova], [idjezika]) VALUES (4, N'Francuski napredni nivo', N'2 meseca', N'Strucni termini, priprema za studiranje ', 70, 1)
INSERT [dbo].[Kurs] ([id], [nazivKursa], [trajanje], [opisKursa], [ukupanBrojCasova], [idjezika]) VALUES (2003, N'Napredni italijanski', N'10 meseci', N'termini za svakodnevni zivot i strucni', 40, 3)
SET IDENTITY_INSERT [dbo].[Kurs] OFF
GO
INSERT [dbo].[Prijava] ([idKorisnika], [idGrupe], [datumPrijave]) VALUES (1, 3, CAST(N'2024-02-12' AS Date))
INSERT [dbo].[Prijava] ([idKorisnika], [idGrupe], [datumPrijave]) VALUES (3, 3, CAST(N'2024-02-14' AS Date))
INSERT [dbo].[Prijava] ([idKorisnika], [idGrupe], [datumPrijave]) VALUES (3, 4, CAST(N'2024-02-14' AS Date))
INSERT [dbo].[Prijava] ([idKorisnika], [idGrupe], [datumPrijave]) VALUES (3, 1009, CAST(N'2024-02-14' AS Date))
INSERT [dbo].[Prijava] ([idKorisnika], [idGrupe], [datumPrijave]) VALUES (3, 1010, CAST(N'2024-02-17' AS Date))
INSERT [dbo].[Prijava] ([idKorisnika], [idGrupe], [datumPrijave]) VALUES (3, 4012, CAST(N'2024-02-19' AS Date))
INSERT [dbo].[Prijava] ([idKorisnika], [idGrupe], [datumPrijave]) VALUES (3, 4013, CAST(N'2024-02-19' AS Date))
GO
INSERT [dbo].[Raspored] ([idGrupe], [dan], [trajanje], [brojSale], [vremePocetka]) VALUES (3, N'Cetvrtak', N'01:20', N'b103', N'12:20')
INSERT [dbo].[Raspored] ([idGrupe], [dan], [trajanje], [brojSale], [vremePocetka]) VALUES (3, N'Utorak', N'02:00', N'b103', N'12:00')
INSERT [dbo].[Raspored] ([idGrupe], [dan], [trajanje], [brojSale], [vremePocetka]) VALUES (1010, N'Petak', N'02:00', N'b103', N'18:00')
INSERT [dbo].[Raspored] ([idGrupe], [dan], [trajanje], [brojSale], [vremePocetka]) VALUES (1010, N'Sreda', N'12:00', N'b103', N'02:00')
INSERT [dbo].[Raspored] ([idGrupe], [dan], [trajanje], [brojSale], [vremePocetka]) VALUES (1011, N'Ponedeljak', N'02:00', N'b103', N'13:00')
INSERT [dbo].[Raspored] ([idGrupe], [dan], [trajanje], [brojSale], [vremePocetka]) VALUES (1011, N'Sreda', N'01:30', N'cit', N'12:20')
INSERT [dbo].[Raspored] ([idGrupe], [dan], [trajanje], [brojSale], [vremePocetka]) VALUES (3011, N'Petak', N'12:00', N'n12', N'02:00')
INSERT [dbo].[Raspored] ([idGrupe], [dan], [trajanje], [brojSale], [vremePocetka]) VALUES (4011, N'Ponedeljak', N'01:30', N'b103', N'12:00')
INSERT [dbo].[Raspored] ([idGrupe], [dan], [trajanje], [brojSale], [vremePocetka]) VALUES (4011, N'Sreda', N'02:00', N'b1', N'12:00')
INSERT [dbo].[Raspored] ([idGrupe], [dan], [trajanje], [brojSale], [vremePocetka]) VALUES (4012, N'Ponedeljak', N'02:00', N'21', N'12:00')
INSERT [dbo].[Raspored] ([idGrupe], [dan], [trajanje], [brojSale], [vremePocetka]) VALUES (4013, N'Petak', N'02:00', N'B103', N'12:00')
INSERT [dbo].[Raspored] ([idGrupe], [dan], [trajanje], [brojSale], [vremePocetka]) VALUES (4013, N'Sreda', N'00:40', N'b1', N'12:00')
INSERT [dbo].[Raspored] ([idGrupe], [dan], [trajanje], [brojSale], [vremePocetka]) VALUES (4013, N'Utorak', N'12:00', N'b13', N'22:00')
INSERT [dbo].[Raspored] ([idGrupe], [dan], [trajanje], [brojSale], [vremePocetka]) VALUES (5011, N'Ponedeljak', N'02:00', N'b104', N'13:00')
INSERT [dbo].[Raspored] ([idGrupe], [dan], [trajanje], [brojSale], [vremePocetka]) VALUES (5011, N'Sreda', N'02:00', N'cit', N'12:00')
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Grupa]    Script Date: 19.2.2024. 12:04:44 ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_Grupa] ON [dbo].[Grupa]
(
	[nazivGrupe] ASC,
	[idKursa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Korisnik]    Script Date: 19.2.2024. 12:04:44 ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_Korisnik] ON [dbo].[Korisnik]
(
	[korisnickoIme] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Kurs]    Script Date: 19.2.2024. 12:04:44 ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_Kurs] ON [dbo].[Kurs]
(
	[nazivKursa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Grupa]  WITH CHECK ADD  CONSTRAINT [FK_Grupa_Kurs] FOREIGN KEY([idKursa])
REFERENCES [dbo].[Kurs] ([id])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Grupa] CHECK CONSTRAINT [FK_Grupa_Kurs]
GO
ALTER TABLE [dbo].[Kurs]  WITH CHECK ADD  CONSTRAINT [FK_Kurs_Jezik] FOREIGN KEY([idjezika])
REFERENCES [dbo].[Jezik] ([id])
GO
ALTER TABLE [dbo].[Kurs] CHECK CONSTRAINT [FK_Kurs_Jezik]
GO
ALTER TABLE [dbo].[Prijava]  WITH CHECK ADD  CONSTRAINT [FK_Prijava_Grupa] FOREIGN KEY([idGrupe])
REFERENCES [dbo].[Grupa] ([id])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Prijava] CHECK CONSTRAINT [FK_Prijava_Grupa]
GO
ALTER TABLE [dbo].[Prijava]  WITH CHECK ADD  CONSTRAINT [FK_Prijava_Korisnik] FOREIGN KEY([idKorisnika])
REFERENCES [dbo].[Korisnik] ([id])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Prijava] CHECK CONSTRAINT [FK_Prijava_Korisnik]
GO
ALTER TABLE [dbo].[Raspored]  WITH CHECK ADD  CONSTRAINT [FK_DnevniRaspored_Grupa] FOREIGN KEY([idGrupe])
REFERENCES [dbo].[Grupa] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Raspored] CHECK CONSTRAINT [FK_DnevniRaspored_Grupa]
GO
USE [master]
GO
ALTER DATABASE [bazaJezici] SET  READ_WRITE 
GO
