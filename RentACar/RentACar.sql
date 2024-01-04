USE [master]
GO
/****** Object:  Database [RentACar]    Script Date: 25.10.2023 2:55:18 ÖS ******/
CREATE DATABASE [RentACar]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'RentACar', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\RentACar.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'RentACar_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\RentACar_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [RentACar] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [RentACar].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [RentACar] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [RentACar] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [RentACar] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [RentACar] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [RentACar] SET ARITHABORT OFF 
GO
ALTER DATABASE [RentACar] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [RentACar] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [RentACar] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [RentACar] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [RentACar] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [RentACar] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [RentACar] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [RentACar] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [RentACar] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [RentACar] SET  DISABLE_BROKER 
GO
ALTER DATABASE [RentACar] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [RentACar] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [RentACar] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [RentACar] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [RentACar] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [RentACar] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [RentACar] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [RentACar] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [RentACar] SET  MULTI_USER 
GO
ALTER DATABASE [RentACar] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [RentACar] SET DB_CHAINING OFF 
GO
ALTER DATABASE [RentACar] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [RentACar] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [RentACar] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [RentACar] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [RentACar] SET QUERY_STORE = ON
GO
ALTER DATABASE [RentACar] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [RentACar]
GO
/****** Object:  Table [dbo].[CorporateDetails]    Script Date: 25.10.2023 2:55:18 ÖS ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CorporateDetails](
	[CorporateID] [int] IDENTITY(1,1) NOT NULL,
	[CorporateName] [nvarchar](50) NULL,
	[CustomerTaxNumber] [int] NULL,
	[CarNumber] [int] NULL,
	[CityName] [nvarchar](50) NULL,
	[CountyName] [nvarchar](50) NULL,
	[CustomerName] [nvarchar](50) NULL,
	[CustomerSurname] [nvarchar](50) NULL,
	[CustomerTelephoneNumber] [nvarchar](50) NULL,
	[CustomerEmail] [nvarchar](50) NULL,
 CONSTRAINT [PK_CorporateDetails] PRIMARY KEY CLUSTERED 
(
	[CorporateID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 25.10.2023 2:55:18 ÖS ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[UserID] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [nvarchar](50) NULL,
	[Password] [nvarchar](50) NULL,
	[FullName] [nvarchar](50) NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[VehicleBrands]    Script Date: 25.10.2023 2:55:18 ÖS ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VehicleBrands](
	[VehicleBrandID] [int] IDENTITY(1,1) NOT NULL,
	[VehicleBrandName] [nvarchar](50) NULL,
 CONSTRAINT [PK_VehicleBrands] PRIMARY KEY CLUSTERED 
(
	[VehicleBrandID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[VehicleModels]    Script Date: 25.10.2023 2:55:18 ÖS ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VehicleModels](
	[VehicleModelID] [int] IDENTITY(1,1) NOT NULL,
	[VehicleModelName] [nvarchar](50) NULL,
	[VehicleYear] [int] NULL,
	[VehicleTransmission] [nvarchar](50) NULL,
	[VehicleFuelOil] [nvarchar](50) NULL,
	[VehicleBrandID] [int] NULL,
	[PerDayPrice] [int] NULL,
 CONSTRAINT [PK_VehicleModels] PRIMARY KEY CLUSTERED 
(
	[VehicleModelID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([UserID], [UserName], [Password], [FullName]) VALUES (1, N'admin', N'12345', N'System Manager')
INSERT [dbo].[Users] ([UserID], [UserName], [Password], [FullName]) VALUES (2, N'abc', N'12345', N'Abc Abc')
SET IDENTITY_INSERT [dbo].[Users] OFF
GO
SET IDENTITY_INSERT [dbo].[VehicleBrands] ON 

INSERT [dbo].[VehicleBrands] ([VehicleBrandID], [VehicleBrandName]) VALUES (1, N'Ford')
INSERT [dbo].[VehicleBrands] ([VehicleBrandID], [VehicleBrandName]) VALUES (2, N'Opel')
INSERT [dbo].[VehicleBrands] ([VehicleBrandID], [VehicleBrandName]) VALUES (3, N'Renault')
INSERT [dbo].[VehicleBrands] ([VehicleBrandID], [VehicleBrandName]) VALUES (4, N'Hyundai')
INSERT [dbo].[VehicleBrands] ([VehicleBrandID], [VehicleBrandName]) VALUES (5, N'Citroen')
INSERT [dbo].[VehicleBrands] ([VehicleBrandID], [VehicleBrandName]) VALUES (6, N'BMW')
INSERT [dbo].[VehicleBrands] ([VehicleBrandID], [VehicleBrandName]) VALUES (7, N'Mercedes')
INSERT [dbo].[VehicleBrands] ([VehicleBrandID], [VehicleBrandName]) VALUES (8, N'Audi')
INSERT [dbo].[VehicleBrands] ([VehicleBrandID], [VehicleBrandName]) VALUES (9, N'Peugeot')
INSERT [dbo].[VehicleBrands] ([VehicleBrandID], [VehicleBrandName]) VALUES (10, N'Toyota')
INSERT [dbo].[VehicleBrands] ([VehicleBrandID], [VehicleBrandName]) VALUES (11, N'Volkswagen')
INSERT [dbo].[VehicleBrands] ([VehicleBrandID], [VehicleBrandName]) VALUES (12, N'Volvo')
INSERT [dbo].[VehicleBrands] ([VehicleBrandID], [VehicleBrandName]) VALUES (13, N'Fiat')
SET IDENTITY_INSERT [dbo].[VehicleBrands] OFF
GO
SET IDENTITY_INSERT [dbo].[VehicleModels] ON 

INSERT [dbo].[VehicleModels] ([VehicleModelID], [VehicleModelName], [VehicleYear], [VehicleTransmission], [VehicleFuelOil], [VehicleBrandID], [PerDayPrice]) VALUES (1, N'Focus', 2020, N'Otomatik', N'Dizel', 1, 500)
INSERT [dbo].[VehicleModels] ([VehicleModelID], [VehicleModelName], [VehicleYear], [VehicleTransmission], [VehicleFuelOil], [VehicleBrandID], [PerDayPrice]) VALUES (2, N'Fiesta', 2020, N'Manuel', N'Benzin', 1, 350)
INSERT [dbo].[VehicleModels] ([VehicleModelID], [VehicleModelName], [VehicleYear], [VehicleTransmission], [VehicleFuelOil], [VehicleBrandID], [PerDayPrice]) VALUES (3, N'Astra', 2021, N'Otomatik', N'Benzin', 2, 500)
INSERT [dbo].[VehicleModels] ([VehicleModelID], [VehicleModelName], [VehicleYear], [VehicleTransmission], [VehicleFuelOil], [VehicleBrandID], [PerDayPrice]) VALUES (4, N'Corsa', 2021, N'Manuel', N'Dizel', 2, 300)
INSERT [dbo].[VehicleModels] ([VehicleModelID], [VehicleModelName], [VehicleYear], [VehicleTransmission], [VehicleFuelOil], [VehicleBrandID], [PerDayPrice]) VALUES (5, N'Megane', 2021, N'Otomatik', N'Dizel', 3, 450)
INSERT [dbo].[VehicleModels] ([VehicleModelID], [VehicleModelName], [VehicleYear], [VehicleTransmission], [VehicleFuelOil], [VehicleBrandID], [PerDayPrice]) VALUES (6, N'Taliant', 2023, N'Manuel', N'Dizel', 3, 250)
INSERT [dbo].[VehicleModels] ([VehicleModelID], [VehicleModelName], [VehicleYear], [VehicleTransmission], [VehicleFuelOil], [VehicleBrandID], [PerDayPrice]) VALUES (7, N'Accent Blue', 2020, N'Otomatik', N'Dizel', 4, 300)
INSERT [dbo].[VehicleModels] ([VehicleModelID], [VehicleModelName], [VehicleYear], [VehicleTransmission], [VehicleFuelOil], [VehicleBrandID], [PerDayPrice]) VALUES (8, N'Accent Era', 2010, N'Manuel', N'Dizel', 4, 200)
INSERT [dbo].[VehicleModels] ([VehicleModelID], [VehicleModelName], [VehicleYear], [VehicleTransmission], [VehicleFuelOil], [VehicleBrandID], [PerDayPrice]) VALUES (9, N'5.30i', 2021, N'Otomatik', N'Benzin', 6, 1200)
INSERT [dbo].[VehicleModels] ([VehicleModelID], [VehicleModelName], [VehicleYear], [VehicleTransmission], [VehicleFuelOil], [VehicleBrandID], [PerDayPrice]) VALUES (10, N'307', 2021, N'Manuel', N'Dizel', 9, 450)
INSERT [dbo].[VehicleModels] ([VehicleModelID], [VehicleModelName], [VehicleYear], [VehicleTransmission], [VehicleFuelOil], [VehicleBrandID], [PerDayPrice]) VALUES (11, N'Passat', 2018, N'Otomatik', N'Dizel', 11, 700)
INSERT [dbo].[VehicleModels] ([VehicleModelID], [VehicleModelName], [VehicleYear], [VehicleTransmission], [VehicleFuelOil], [VehicleBrandID], [PerDayPrice]) VALUES (12, N'A4', 2018, N'Otomatik', N'Benzin', 8, 1000)
INSERT [dbo].[VehicleModels] ([VehicleModelID], [VehicleModelName], [VehicleYear], [VehicleTransmission], [VehicleFuelOil], [VehicleBrandID], [PerDayPrice]) VALUES (13, N'301', 2016, N'Manuel', N'Dizel', 9, 350)
SET IDENTITY_INSERT [dbo].[VehicleModels] OFF
GO
ALTER TABLE [dbo].[VehicleModels]  WITH CHECK ADD  CONSTRAINT [FK_VehicleModels_VehicleBrands] FOREIGN KEY([VehicleBrandID])
REFERENCES [dbo].[VehicleBrands] ([VehicleBrandID])
GO
ALTER TABLE [dbo].[VehicleModels] CHECK CONSTRAINT [FK_VehicleModels_VehicleBrands]
GO
USE [master]
GO
ALTER DATABASE [RentACar] SET  READ_WRITE 
GO
