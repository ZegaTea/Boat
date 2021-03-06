/*    ==Scripting Parameters==

    Source Server Version : SQL Server 2016 (13.0.4001)
    Source Database Engine Edition : Microsoft SQL Server Express Edition
    Source Database Engine Type : Standalone SQL Server

    Target Server Version : SQL Server 2017
    Target Database Engine Edition : Microsoft SQL Server Standard Edition
    Target Database Engine Type : Standalone SQL Server
*/
USE [master]
GO
/****** Object:  Database [boat]    Script Date: 12/26/2017 8:49:25 PM ******/
CREATE DATABASE [boat]
GO
ALTER DATABASE [boat] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [boat].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [boat] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [boat] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [boat] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [boat] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [boat] SET ARITHABORT OFF 
GO
ALTER DATABASE [boat] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [boat] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [boat] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [boat] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [boat] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [boat] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [boat] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [boat] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [boat] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [boat] SET  DISABLE_BROKER 
GO
ALTER DATABASE [boat] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [boat] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [boat] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [boat] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [boat] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [boat] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [boat] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [boat] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [boat] SET  MULTI_USER 
GO
ALTER DATABASE [boat] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [boat] SET DB_CHAINING OFF 
GO
ALTER DATABASE [boat] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [boat] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [boat] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [boat] SET QUERY_STORE = OFF
GO
USE [boat]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [boat]
GO
/****** Object:  Table [dbo].[conbao]    Script Date: 12/26/2017 8:49:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[conbao](
	[ma] [varchar](50) NOT NULL,
	[tenconbao] [nvarchar](50) NULL,
	[ghichu] [nvarchar](max) NULL,
	[thoigianhinhthanh] [bigint] NULL,
	[matinhtrang] [int] NULL,
 CONSTRAINT [PK_conbao] PRIMARY KEY CLUSTERED 
(
	[ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[hanhtrinh]    Script Date: 12/26/2017 8:49:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[hanhtrinh](
	[ma] [int] IDENTITY(1,1) NOT NULL,
	[matauthuyen] [varchar](50) NULL,
	[trangthai] [int] NULL,
 CONSTRAINT [PK_hanhtrinh] PRIMARY KEY CLUSTERED 
(
	[ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[hanhtrinhbao]    Script Date: 12/26/2017 8:49:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[hanhtrinhbao](
	[ma] [int] IDENTITY(1,1) NOT NULL,
	[maconbao] [varchar](50) NULL,
	[trangthai] [int] NULL,
 CONSTRAINT [PK_hanhtrinhbao] PRIMARY KEY CLUSTERED 
(
	[ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[loaitau]    Script Date: 12/26/2017 8:49:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[loaitau](
	[ma] [varchar](50) NOT NULL,
	[tenloaitau] [nvarchar](50) NULL,
	[kieutau] [nvarchar](50) NULL,
 CONSTRAINT [PK_loaitau] PRIMARY KEY CLUSTERED 
(
	[ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[quocgia]    Script Date: 12/26/2017 8:49:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[quocgia](
	[ma] [varchar](50) NOT NULL,
	[tenquocgia] [nvarchar](50) NULL,
 CONSTRAINT [PK_quocgia] PRIMARY KEY CLUSTERED 
(
	[ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tauthuyen]    Script Date: 12/26/2017 8:49:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tauthuyen](
	[ma] [varchar](50) NOT NULL,
	[tentau] [nvarchar](50) NULL,
	[MMSI] [varchar](50) NULL,
	[maloaitau] [varchar](50) NULL,
	[taitrong] [bigint] NULL,
	[maquocgia] [varchar](50) NULL,
	[image] [varchar](max) NULL,
 CONSTRAINT [PK_tauthuyen] PRIMARY KEY CLUSTERED 
(
	[ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tinhtrang]    Script Date: 12/26/2017 8:49:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tinhtrang](
	[ma] [int] NOT NULL,
	[tinhtrang] [nvarchar](50) NULL,
 CONSTRAINT [PK_tinhtrang] PRIMARY KEY CLUSTERED 
(
	[ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[vitribao]    Script Date: 12/26/2017 8:49:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[vitribao](
	[ma] [int] IDENTITY(1,1) NOT NULL,
	[mahanhtrinh] [int] NULL,
	[vido] [float] NULL,
	[kinhdo] [float] NULL,
	[thoigian] [bigint] NULL,
	[vantoc] [float] NULL,
 CONSTRAINT [PK_vitribao] PRIMARY KEY CLUSTERED 
(
	[ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[vitritauthuyen]    Script Date: 12/26/2017 8:49:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[vitritauthuyen](
	[ma] [int] IDENTITY(1,1) NOT NULL,
	[mahanhtrinh] [int] NULL,
	[vido] [float] NULL,
	[kinhdo] [float] NULL,
	[thoigian] [bigint] NULL,
 CONSTRAINT [PK_vitritauthuyen] PRIMARY KEY CLUSTERED 
(
	[ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[conbao] ([ma], [tenconbao], [ghichu], [thoigianhinhthanh], [matinhtrang]) VALUES (N'ST1', N'Bão số 1', NULL, 1512443735000, 1)
INSERT [dbo].[conbao] ([ma], [tenconbao], [ghichu], [thoigianhinhthanh], [matinhtrang]) VALUES (N'ST2', N'Bão số 2', NULL, 1512530135000, 1)
SET IDENTITY_INSERT [dbo].[hanhtrinh] ON 

INSERT [dbo].[hanhtrinh] ([ma], [matauthuyen], [trangthai]) VALUES (1, N'VN1', 0)
INSERT [dbo].[hanhtrinh] ([ma], [matauthuyen], [trangthai]) VALUES (2, N'VN1', 0)
INSERT [dbo].[hanhtrinh] ([ma], [matauthuyen], [trangthai]) VALUES (3, N'VN1', 0)
INSERT [dbo].[hanhtrinh] ([ma], [matauthuyen], [trangthai]) VALUES (4, N'VN2', 0)
INSERT [dbo].[hanhtrinh] ([ma], [matauthuyen], [trangthai]) VALUES (5, N'VN3', 0)
INSERT [dbo].[hanhtrinh] ([ma], [matauthuyen], [trangthai]) VALUES (6, N'EN1', 0)
INSERT [dbo].[hanhtrinh] ([ma], [matauthuyen], [trangthai]) VALUES (8, N'VN1', 0)
INSERT [dbo].[hanhtrinh] ([ma], [matauthuyen], [trangthai]) VALUES (9, N'VN2', 0)
INSERT [dbo].[hanhtrinh] ([ma], [matauthuyen], [trangthai]) VALUES (10, N'EN1', 0)
INSERT [dbo].[hanhtrinh] ([ma], [matauthuyen], [trangthai]) VALUES (11, N'VN2', 0)
INSERT [dbo].[hanhtrinh] ([ma], [matauthuyen], [trangthai]) VALUES (12, N'EN1', 0)
INSERT [dbo].[hanhtrinh] ([ma], [matauthuyen], [trangthai]) VALUES (13, N'EN1', 0)
INSERT [dbo].[hanhtrinh] ([ma], [matauthuyen], [trangthai]) VALUES (14, N'VN2', 0)
INSERT [dbo].[hanhtrinh] ([ma], [matauthuyen], [trangthai]) VALUES (15, N'EN1', 0)
INSERT [dbo].[hanhtrinh] ([ma], [matauthuyen], [trangthai]) VALUES (16, N'VN2', 0)
INSERT [dbo].[hanhtrinh] ([ma], [matauthuyen], [trangthai]) VALUES (17, N'EN1', 0)
INSERT [dbo].[hanhtrinh] ([ma], [matauthuyen], [trangthai]) VALUES (18, N'VN3', 0)
INSERT [dbo].[hanhtrinh] ([ma], [matauthuyen], [trangthai]) VALUES (19, N'EN1', 0)
INSERT [dbo].[hanhtrinh] ([ma], [matauthuyen], [trangthai]) VALUES (20, N'VN3', 0)
INSERT [dbo].[hanhtrinh] ([ma], [matauthuyen], [trangthai]) VALUES (21, N'VN3', 0)
INSERT [dbo].[hanhtrinh] ([ma], [matauthuyen], [trangthai]) VALUES (22, N'VN3', 0)
INSERT [dbo].[hanhtrinh] ([ma], [matauthuyen], [trangthai]) VALUES (23, N'VN3', 0)
INSERT [dbo].[hanhtrinh] ([ma], [matauthuyen], [trangthai]) VALUES (24, N'VN3', 0)
INSERT [dbo].[hanhtrinh] ([ma], [matauthuyen], [trangthai]) VALUES (25, N'VN3', 0)
INSERT [dbo].[hanhtrinh] ([ma], [matauthuyen], [trangthai]) VALUES (26, N'VN3', 0)
INSERT [dbo].[hanhtrinh] ([ma], [matauthuyen], [trangthai]) VALUES (27, N'EN1', 0)
INSERT [dbo].[hanhtrinh] ([ma], [matauthuyen], [trangthai]) VALUES (28, N'VN3', 0)
INSERT [dbo].[hanhtrinh] ([ma], [matauthuyen], [trangthai]) VALUES (29, N'EN1', 0)
INSERT [dbo].[hanhtrinh] ([ma], [matauthuyen], [trangthai]) VALUES (30, N'VN3', 0)
INSERT [dbo].[hanhtrinh] ([ma], [matauthuyen], [trangthai]) VALUES (31, N'EN1', 0)
INSERT [dbo].[hanhtrinh] ([ma], [matauthuyen], [trangthai]) VALUES (32, N'EN1', 0)
INSERT [dbo].[hanhtrinh] ([ma], [matauthuyen], [trangthai]) VALUES (33, N'VN3', 0)
INSERT [dbo].[hanhtrinh] ([ma], [matauthuyen], [trangthai]) VALUES (34, N'EN1', 0)
INSERT [dbo].[hanhtrinh] ([ma], [matauthuyen], [trangthai]) VALUES (35, N'EN1', 0)
INSERT [dbo].[hanhtrinh] ([ma], [matauthuyen], [trangthai]) VALUES (36, N'EN1', 0)
INSERT [dbo].[hanhtrinh] ([ma], [matauthuyen], [trangthai]) VALUES (37, N'VN1', 0)
INSERT [dbo].[hanhtrinh] ([ma], [matauthuyen], [trangthai]) VALUES (38, N'VN3', 0)
INSERT [dbo].[hanhtrinh] ([ma], [matauthuyen], [trangthai]) VALUES (39, N'VN2', 0)
INSERT [dbo].[hanhtrinh] ([ma], [matauthuyen], [trangthai]) VALUES (40, N'EN1', 0)
INSERT [dbo].[hanhtrinh] ([ma], [matauthuyen], [trangthai]) VALUES (41, N'EN1', 0)
INSERT [dbo].[hanhtrinh] ([ma], [matauthuyen], [trangthai]) VALUES (42, N'EN1', 0)
INSERT [dbo].[hanhtrinh] ([ma], [matauthuyen], [trangthai]) VALUES (43, N'VN2', 0)
INSERT [dbo].[hanhtrinh] ([ma], [matauthuyen], [trangthai]) VALUES (44, N'VN2', 0)
INSERT [dbo].[hanhtrinh] ([ma], [matauthuyen], [trangthai]) VALUES (45, N'VN2', 0)
INSERT [dbo].[hanhtrinh] ([ma], [matauthuyen], [trangthai]) VALUES (46, N'EN1', 0)
INSERT [dbo].[hanhtrinh] ([ma], [matauthuyen], [trangthai]) VALUES (47, N'EN1', 0)
INSERT [dbo].[hanhtrinh] ([ma], [matauthuyen], [trangthai]) VALUES (48, N'EN1', 0)
INSERT [dbo].[hanhtrinh] ([ma], [matauthuyen], [trangthai]) VALUES (49, N'VN1', 0)
INSERT [dbo].[hanhtrinh] ([ma], [matauthuyen], [trangthai]) VALUES (50, N'VN2', 0)
INSERT [dbo].[hanhtrinh] ([ma], [matauthuyen], [trangthai]) VALUES (51, N'VN3', 0)
INSERT [dbo].[hanhtrinh] ([ma], [matauthuyen], [trangthai]) VALUES (52, N'EN1', 0)
INSERT [dbo].[hanhtrinh] ([ma], [matauthuyen], [trangthai]) VALUES (53, N'VN2', 0)
INSERT [dbo].[hanhtrinh] ([ma], [matauthuyen], [trangthai]) VALUES (54, N'VN2', 0)
INSERT [dbo].[hanhtrinh] ([ma], [matauthuyen], [trangthai]) VALUES (55, N'EN1', 0)
INSERT [dbo].[hanhtrinh] ([ma], [matauthuyen], [trangthai]) VALUES (56, N'EN1', 0)
INSERT [dbo].[hanhtrinh] ([ma], [matauthuyen], [trangthai]) VALUES (57, N'EN1', 0)
INSERT [dbo].[hanhtrinh] ([ma], [matauthuyen], [trangthai]) VALUES (58, N'VN2', 0)
INSERT [dbo].[hanhtrinh] ([ma], [matauthuyen], [trangthai]) VALUES (59, N'VN1', 0)
INSERT [dbo].[hanhtrinh] ([ma], [matauthuyen], [trangthai]) VALUES (60, N'VN2', 0)
INSERT [dbo].[hanhtrinh] ([ma], [matauthuyen], [trangthai]) VALUES (61, N'VN2', 0)
INSERT [dbo].[hanhtrinh] ([ma], [matauthuyen], [trangthai]) VALUES (62, N'EN1', 0)
INSERT [dbo].[hanhtrinh] ([ma], [matauthuyen], [trangthai]) VALUES (63, N'EN1', 0)
INSERT [dbo].[hanhtrinh] ([ma], [matauthuyen], [trangthai]) VALUES (64, N'EN1', 0)
INSERT [dbo].[hanhtrinh] ([ma], [matauthuyen], [trangthai]) VALUES (65, N'VN2', 0)
SET IDENTITY_INSERT [dbo].[hanhtrinh] OFF
SET IDENTITY_INSERT [dbo].[hanhtrinhbao] ON 

INSERT [dbo].[hanhtrinhbao] ([ma], [maconbao], [trangthai]) VALUES (3, N'ST1', 0)
INSERT [dbo].[hanhtrinhbao] ([ma], [maconbao], [trangthai]) VALUES (4, N'ST2', 0)
INSERT [dbo].[hanhtrinhbao] ([ma], [maconbao], [trangthai]) VALUES (7, N'ST1', 0)
INSERT [dbo].[hanhtrinhbao] ([ma], [maconbao], [trangthai]) VALUES (8, N'ST2', 0)
INSERT [dbo].[hanhtrinhbao] ([ma], [maconbao], [trangthai]) VALUES (10, N'ST1', 0)
INSERT [dbo].[hanhtrinhbao] ([ma], [maconbao], [trangthai]) VALUES (11, N'ST1', 0)
INSERT [dbo].[hanhtrinhbao] ([ma], [maconbao], [trangthai]) VALUES (12, N'ST1', 0)
INSERT [dbo].[hanhtrinhbao] ([ma], [maconbao], [trangthai]) VALUES (13, N'ST2', 0)
INSERT [dbo].[hanhtrinhbao] ([ma], [maconbao], [trangthai]) VALUES (14, N'ST2', 0)
INSERT [dbo].[hanhtrinhbao] ([ma], [maconbao], [trangthai]) VALUES (15, N'ST2', 0)
SET IDENTITY_INSERT [dbo].[hanhtrinhbao] OFF
INSERT [dbo].[loaitau] ([ma], [tenloaitau], [kieutau]) VALUES (N'CH', N'Chở hàng', NULL)
INSERT [dbo].[loaitau] ([ma], [tenloaitau], [kieutau]) VALUES (N'CK', N'Chở khách', NULL)
INSERT [dbo].[loaitau] ([ma], [tenloaitau], [kieutau]) VALUES (N'OL', N'Tàu chở dầu', NULL)
INSERT [dbo].[quocgia] ([ma], [tenquocgia]) VALUES (N'ENG', N'Anh')
INSERT [dbo].[quocgia] ([ma], [tenquocgia]) VALUES (N'FR', N'Pháp')
INSERT [dbo].[quocgia] ([ma], [tenquocgia]) VALUES (N'USA', N'Mỹ')
INSERT [dbo].[quocgia] ([ma], [tenquocgia]) VALUES (N'VN', N'Việt Nam')
INSERT [dbo].[tauthuyen] ([ma], [tentau], [MMSI], [maloaitau], [taitrong], [maquocgia], [image]) VALUES (N'EN1', N'Tàu EN1', N'12', N'CH', 10000, N'ENG', NULL)
INSERT [dbo].[tauthuyen] ([ma], [tentau], [MMSI], [maloaitau], [taitrong], [maquocgia], [image]) VALUES (N'VN1', N'Tàu VN1', N'123', N'CK', 5000, N'VN', NULL)
INSERT [dbo].[tauthuyen] ([ma], [tentau], [MMSI], [maloaitau], [taitrong], [maquocgia], [image]) VALUES (N'VN2', N'Tàu VN2', N'2', N'CK', 5000, N'VN', NULL)
INSERT [dbo].[tauthuyen] ([ma], [tentau], [MMSI], [maloaitau], [taitrong], [maquocgia], [image]) VALUES (N'VN3', N'Tàu VN3', N'3', N'CK', 5000, N'VN', NULL)
INSERT [dbo].[tinhtrang] ([ma], [tinhtrang]) VALUES (1, N'Mới hình thành')
INSERT [dbo].[tinhtrang] ([ma], [tinhtrang]) VALUES (2, N'Mạnh')
INSERT [dbo].[tinhtrang] ([ma], [tinhtrang]) VALUES (3, N'Siêu bão')
INSERT [dbo].[tinhtrang] ([ma], [tinhtrang]) VALUES (4, N'Suy yếu')
INSERT [dbo].[tinhtrang] ([ma], [tinhtrang]) VALUES (5, N'Áp thấp')
INSERT [dbo].[tinhtrang] ([ma], [tinhtrang]) VALUES (6, N'Tan')
SET IDENTITY_INSERT [dbo].[vitribao] ON 

INSERT [dbo].[vitribao] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian], [vantoc]) VALUES (1, 3, 16.470987, 110.533447, 1514107763580, NULL)
INSERT [dbo].[vitribao] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian], [vantoc]) VALUES (2, 4, 14.863169, 110.88501, 1514107768519, NULL)
INSERT [dbo].[vitribao] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian], [vantoc]) VALUES (4, 7, 16.490987, 110.531447, 1514120287334, NULL)
INSERT [dbo].[vitribao] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian], [vantoc]) VALUES (5, 7, 16.510987, 110.529447, 1514120292367, NULL)
INSERT [dbo].[vitribao] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian], [vantoc]) VALUES (6, 7, 16.530987, 110.527447, 1514120297797, NULL)
INSERT [dbo].[vitribao] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian], [vantoc]) VALUES (7, 7, 16.550987, 110.525447, 1514120302338, NULL)
INSERT [dbo].[vitribao] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian], [vantoc]) VALUES (8, 7, 16.570987, 110.523447, 1514120307343, NULL)
INSERT [dbo].[vitribao] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian], [vantoc]) VALUES (10, 7, 16.610987, 110.519447, 1514120319998, NULL)
INSERT [dbo].[vitribao] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian], [vantoc]) VALUES (11, 7, 16.630987, 110.517447, 1514120323797, NULL)
INSERT [dbo].[vitribao] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian], [vantoc]) VALUES (12, 7, 16.650987, 110.515447, 1514120327343, NULL)
INSERT [dbo].[vitribao] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian], [vantoc]) VALUES (13, 8, 14.963169, 110.90501, 1514120598384, NULL)
INSERT [dbo].[vitribao] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian], [vantoc]) VALUES (14, 8, 15.063169, 110.92501, 1514120603402, NULL)
INSERT [dbo].[vitribao] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian], [vantoc]) VALUES (15, 8, 15.163169, 110.94501, 1514120608400, NULL)
INSERT [dbo].[vitribao] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian], [vantoc]) VALUES (16, 8, 15.263169, 110.96501, 1514120615990, NULL)
INSERT [dbo].[vitribao] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian], [vantoc]) VALUES (17, 8, 15.363169, 110.98501, 1514120618399, NULL)
INSERT [dbo].[vitribao] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian], [vantoc]) VALUES (21, 10, 16.725987, 110.495447, 1514120724839, NULL)
INSERT [dbo].[vitribao] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian], [vantoc]) VALUES (22, 10, 16.800987, 110.475447, 1514120729888, NULL)
INSERT [dbo].[vitribao] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian], [vantoc]) VALUES (23, 10, 16.875987, 110.455447, 1514120734841, NULL)
INSERT [dbo].[vitribao] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian], [vantoc]) VALUES (24, 10, 16.950987, 110.435447, 1514120739943, NULL)
INSERT [dbo].[vitribao] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian], [vantoc]) VALUES (25, 10, 17.025987, 110.415447, 1514120744837, NULL)
INSERT [dbo].[vitribao] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian], [vantoc]) VALUES (26, 11, 17.100987, 110.265447, 1514120789678, NULL)
INSERT [dbo].[vitribao] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian], [vantoc]) VALUES (27, 11, 17.175987, 110.115447, 1514120794897, NULL)
INSERT [dbo].[vitribao] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian], [vantoc]) VALUES (28, 11, 17.250987, 109.965447, 1514120799878, NULL)
INSERT [dbo].[vitribao] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian], [vantoc]) VALUES (29, 11, 17.325987, 109.815447, 1514120804686, NULL)
INSERT [dbo].[vitribao] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian], [vantoc]) VALUES (30, 12, 17.335987, 109.665447, 1514120825186, NULL)
INSERT [dbo].[vitribao] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian], [vantoc]) VALUES (31, 12, 17.345987, 109.515447, 1514120830197, NULL)
INSERT [dbo].[vitribao] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian], [vantoc]) VALUES (32, 12, 17.355987, 109.365447, 1514120835202, NULL)
INSERT [dbo].[vitribao] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian], [vantoc]) VALUES (33, 13, 15.373169, 110.97501, 1514120955188, NULL)
INSERT [dbo].[vitribao] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian], [vantoc]) VALUES (34, 13, 15.383169, 110.96501, 1514120960197, NULL)
INSERT [dbo].[vitribao] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian], [vantoc]) VALUES (35, 13, 15.393169, 110.95501, 1514120965957, NULL)
INSERT [dbo].[vitribao] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian], [vantoc]) VALUES (36, 13, 15.403169, 110.94501, 1514120970197, NULL)
INSERT [dbo].[vitribao] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian], [vantoc]) VALUES (37, 13, 15.413169, 110.93501, 1514120975536, NULL)
INSERT [dbo].[vitribao] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian], [vantoc]) VALUES (38, 13, 15.423169, 110.92501, 1514120980196, NULL)
INSERT [dbo].[vitribao] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian], [vantoc]) VALUES (39, 14, 15.433169, 110.91501, 1514128834037, NULL)
INSERT [dbo].[vitribao] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian], [vantoc]) VALUES (40, 14, 15.443169, 110.90501, 1514128839056, NULL)
INSERT [dbo].[vitribao] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian], [vantoc]) VALUES (41, 15, 15.453169, 110.89501, 1514262462032, NULL)
INSERT [dbo].[vitribao] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian], [vantoc]) VALUES (42, 15, 15.463169, 110.88501, 1514262467053, NULL)
INSERT [dbo].[vitribao] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian], [vantoc]) VALUES (43, 15, 15.473169, 110.87501, 1514262472057, NULL)
SET IDENTITY_INSERT [dbo].[vitribao] OFF
SET IDENTITY_INSERT [dbo].[vitritauthuyen] ON 

INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (1, 2, 18.899141, 106.622314, 1510027871000)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (2, 4, 16.597372, 108.863525, 1510114271000)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (3, 5, 16.302346, 109.017334, 1510114271000)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (4, 6, 17.186059, 109.259033, 1510114271000)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (5, 3, 16.891945, 108.753662, 1510114271000)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (6, 8, 16.391945, 109.303662, 1510243791359)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (7, 8, 17.211945, 108.563662, 1510243796380)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (8, 8, 18.161945, 107.733662, 1510243801380)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (9, 9, 15.957372, 109.233525, 1510244494181)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (10, 9, 15.357372, 110.103525, 1510244499193)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (11, 9, 14.627372, 111.063525, 1510244504193)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (12, 9, 13.767372, 111.113525, 1510244509193)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (13, 9, 12.787372, 111.263525, 1510244514197)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (14, 9, 12.897372, 111.023525, 1510244519192)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (15, 9, 13.137372, 110.693525, 1510244524192)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (16, 9, 12.777372, 111.113525, 1510244529195)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (17, 10, 17.806059, 108.669033, 1510244806158)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (18, 10, 17.346059, 108.739033, 1510244811177)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (19, 10, 17.936059, 108.569033, 1510244816178)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (20, 10, 17.216059, 108.829033, 1510244821177)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (21, 10, 16.376059, 109.179033, 1510244826177)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (22, 10, 15.406059, 109.629033, 1510244831177)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (23, 11, 12.787372, 111.116525, 1510245058251)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (24, 11, 12.797372, 111.119525, 1510245063256)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (25, 11, 12.807372, 111.122525, 1510245068259)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (26, 11, 12.817372, 111.125525, 1510245073255)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (27, 11, 12.827372, 111.128525, 1510245078256)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (28, 11, 12.837372, 111.131525, 1510245083261)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (29, 11, 12.847372, 111.134525, 1510245088256)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (30, 11, 12.857372, 111.137525, 1510245093255)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (31, 12, 15.416059, 109.632033, 1510245321044)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (32, 12, 15.426059, 109.635033, 1510245326067)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (33, 12, 15.436059, 109.638033, 1510245331075)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (34, 12, 15.446059, 109.641033, 1510245336068)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (35, 12, 15.456059, 109.644033, 1510245341372)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (36, 12, 15.466059, 109.647033, 1510245346072)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (37, 13, 15.476059, 109.650033, 1510245533214)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (38, 13, 15.486059, 109.653033, 1510245538224)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (39, 13, 15.496059, 109.656033, 1510245543229)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (40, 13, 15.506059, 109.659033, 1510245548224)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (41, 14, 12.867372, 111.140525, 1510245573813)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (42, 15, 15.516059, 109.662033, 1510245574625)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (43, 15, 12.877372, 111.143525, 1510245578996)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (44, 15, 15.526059, 109.665033, 1510245579632)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (45, 15, 12.887372, 111.146525, 1510245583832)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (46, 15, 15.536059, 109.668033, 1510245584631)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (47, 15, 12.897372, 111.149525, 1510245588834)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (48, 15, 15.546059, 109.671033, 1510245589632)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (49, 16, 12.867372, 111.140525, 1510245651315)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (50, 17, 15.556059, 109.674033, 1510245653031)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (51, 16, 12.877372, 111.143525, 1510245656335)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (52, 17, 17.491168, 108.912964, 1510245658045)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (53, 16, 12.887372, 111.146525, 1510245661335)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (54, 17, 15.576059, 109.680033, 1510245663228)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (55, 16, 12.897372, 111.149525, 1510245666355)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (56, 17, 15.586059, 109.683033, 1510245668037)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (57, 16, 12.907372, 111.152525, 1510245671338)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (58, 17, 15.596059, 109.686033, 1510245673036)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (59, 16, 12.917372, 111.155525, 1510245676333)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (60, 17, 15.606059, 109.689033, 1510245678036)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (61, 16, 12.927372, 111.158525, 1510245681340)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (62, 17, 15.616059, 109.692033, 1510245683036)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (63, 17, 15.626059, 109.695033, 1510245688036)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (64, 17, 15.636059, 109.698033, 1510245693037)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (65, 17, 15.646059, 109.701033, 1510245698037)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (66, 17, 15.656059, 109.704033, 1510245703036)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (67, 18, 16.312346, 109.020334, 1510245828083)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (68, 19, 15.556059, 109.674033, 1510245829383)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (69, 18, 16.322346, 109.023334, 1510245833132)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (70, 19, 15.566059, 109.677033, 1510245834416)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (71, 18, 16.332346, 109.026334, 1510245838131)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (72, 19, 15.576059, 109.680033, 1510245839411)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (73, 18, 16.342346, 109.029334, 1510245843135)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (74, 19, 15.586059, 109.683033, 1510245844411)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (75, 19, 15.596059, 109.686033, 1510245849416)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (76, 20, 16.352346, 109.032334, 1510246575000)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (77, 20, 16.362346, 109.035334, 1510246580021)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (78, 20, 16.372346, 109.038334, 1510246585025)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (79, 21, 16.382346, 109.041334, 1510246832593)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (80, 21, 16.392346, 109.044334, 1510246837663)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (81, 21, 16.402346, 109.047334, 1510246842661)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (82, 21, 16.412346, 109.050334, 1510246847662)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (83, 22, 16.422346, 109.053334, 1510247008500)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (84, 22, 16.432346, 109.056334, 1510247013514)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (85, 22, 16.442346, 109.059334, 1510247018506)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (86, 22, 16.452346, 109.062334, 1510247023506)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (87, 22, 16.462346, 109.06533399999999, 1510247028505)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (88, 22, 16.472346, 109.068334, 1510247033510)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (89, 23, 16.482346, 109.071334, 1510247171401)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (90, 23, 16.492346, 109.074334, 1510247176425)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (91, 23, 16.502346, 109.077334, 1510247181416)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (92, 23, 16.512346, 109.080334, 1510247186411)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (93, 23, 16.522346, 109.083334, 1510247191412)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (94, 24, 16.532346, 109.086334, 1510247254129)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (95, 24, 16.542346, 109.089334, 1510247259147)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (96, 24, 16.552346, 109.092334, 1510247264147)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (97, 24, 16.562346, 109.095334, 1510247269147)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (98, 25, 16.572346, 109.098334, 1510247519225)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (99, 25, 16.582346, 109.101334, 1510247524239)
GO
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (100, 25, 16.592346, 109.104334, 1510247529243)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (101, 25, 16.602346, 109.107334, 1510247534244)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (102, 26, 16.612346, 109.110334, 1510247894013)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (103, 26, 16.622346, 109.113334, 1510247899036)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (104, 26, 16.632346, 109.116334, 1510247904037)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (105, 27, 15.606059, 109.689033, 1510248437337)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (106, 27, 15.616059, 109.692033, 1510248442369)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (107, 27, 15.626059, 109.695033, 1510248447369)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (108, 27, 15.636059, 109.698033, 1510248452364)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (109, 27, 15.646059, 109.701033, 1510248457364)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (110, 27, 15.656059, 109.704033, 1510248462367)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (111, 28, 16.642346, 109.119334, 1510248582820)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (112, 28, 16.652346, 109.122334, 1510248587851)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (113, 28, 16.662346, 109.125334, 1510248592849)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (114, 28, 16.672346, 109.128334, 1510248597850)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (115, 29, 15.666059, 109.707033, 1510248640580)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (116, 29, 15.676059, 109.710033, 1510248645708)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (117, 29, 15.686059, 109.713033, 1510248650715)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (118, 29, 15.696059, 109.716033, 1510248655711)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (119, 30, 16.642346, 109.119334, 1510248658973)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (120, 29, 15.706059, 109.719033, 1510248660708)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (121, 30, 16.652346, 109.122334, 1510248663989)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (122, 29, 15.716059, 109.722033, 1510248665713)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (123, 30, 16.662346, 109.125334, 1510248668995)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (124, 29, 15.726059, 109.725033, 1510248670709)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (125, 31, 15.736059, 109.728033, 1510470690980)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (126, 32, 15.746059, 109.731033, 1510470880873)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (127, 32, 15.756059, 109.734033, 1510470885896)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (128, 32, 15.766059, 109.737033, 1510470890888)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (129, 32, 15.776059, 109.740033, 1510470895896)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (130, 32, 15.786059, 109.743033, 1510470900894)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (131, 32, 15.796059, 109.746033, 1510470905889)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (132, 32, 15.806059, 109.749033, 1510470910891)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (133, 32, 15.816059, 109.752033, 1510470915893)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (134, 33, 16.672346, 109.128334, 1510471309012)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (135, 33, 16.682346, 109.131334, 1510471314043)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (136, 33, 16.692346, 109.134334, 1510471319046)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (137, 34, 15.826059, 109.755033, 1510471356643)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (138, 34, 15.836059, 109.758033, 1510471361692)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (139, 34, 15.846059, 109.761033, 1510471366695)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (140, 35, 15.856059, 109.764033, 1510471532885)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (141, 35, 15.866059, 109.767033, 1510471537918)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (142, 35, 15.876059, 109.770033, 1510471542918)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (143, 35, 15.886059, 109.773033, 1510471547915)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (144, 35, 15.896059, 109.776033, 1510471552919)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (145, 35, 15.906059, 109.779033, 1510471562820)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (146, 35, 15.916059, 109.782033, 1510471567819)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (147, 35, 15.926059, 109.785033, 1510471572813)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (148, 36, 15.936059, 109.788033, 1510471897853)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (149, 36, 15.946059, 109.791033, 1510471902882)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (150, 36, 15.956059, 109.794033, 1510471907878)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (151, 37, 18.171945, 107.736662, 1510481333529)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (152, 37, 18.181945, 107.739662, 1510481338557)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (153, 37, 18.191945, 107.742662, 1510481343547)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (154, 38, 16.702346, 109.137334, 1510481417987)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (155, 38, 16.712346, 109.140334, 1510481423028)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (156, 38, 16.722346, 109.143334, 1510481428016)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (157, 38, 16.732346, 109.146334, 1510481433015)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (158, 39, 12.937372, 111.161525, 1510505804567)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (159, 39, 12.947372, 111.164525, 1510505809611)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (160, 39, 12.957372, 111.167525, 1510505814595)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (161, 39, 12.967372, 111.170525, 1510505819595)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (162, 39, 12.977372, 111.173525, 1510505824877)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (163, 39, 12.987372, 111.176525, 1510505829600)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (164, 40, 15.966059, 109.797033, 1510505989431)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (165, 40, 15.976059, 109.800033, 1510505994458)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (166, 40, 15.986059, 109.803033, 1510505999466)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (167, 41, 15.996059, 109.806033, 1510727655092)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (168, 41, 16.006059, 109.809033, 1510727660163)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (169, 41, 16.016059, 109.812033, 1510727665129)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (170, 41, 16.026059, 109.815033, 1510727670130)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (171, 42, 16.036059, 109.818033, 1510728695449)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (172, 42, 16.046059, 109.821033, 1510728700503)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (173, 42, 16.056059, 109.824033, 1510728705491)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (174, 42, 16.066059, 109.827033, 1510728710473)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (175, 42, 16.076059, 109.830033, 1510728715484)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (176, 43, 12.997372, 111.179525, 1510728739189)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (177, 43, 13.007372, 111.182525, 1510728744269)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (178, 43, 13.017372, 111.185525, 1510728749286)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (179, 43, 13.027372, 111.188525, 1510728754281)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (180, 43, 13.037372, 111.191525, 1510728759279)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (181, 43, 13.047372, 111.194525, 1510728764289)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (182, 44, 13.057372, 111.197525, 1510728776600)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (183, 44, 13.067372, 111.200525, 1510728781620)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (184, 44, 13.077372, 111.203525, 1510728786622)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (185, 44, 13.087372, 111.206525, 1510728791617)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (186, 44, 13.097372, 111.209525, 1510728796660)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (187, 45, 13.107372, 111.212525, 1510728891984)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (188, 45, 13.117372, 111.215525, 1510728897031)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (189, 45, 13.127372, 111.218525, 1510728902007)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (190, 45, 13.137372, 111.221525, 1510728907015)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (191, 45, 13.147372, 111.224525, 1510728912175)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (192, 45, 13.157372, 111.227525, 1510728917023)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (193, 46, 16.086059, 109.833033, 1510728921415)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (194, 45, 13.167372, 111.230525, 1510728922025)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (195, 46, 16.096059, 109.836033, 1510728926458)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (196, 45, 13.177372, 111.233525, 1510728927018)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (197, 46, 16.106059, 109.839033, 1510728931453)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (198, 45, 13.187372, 111.236525, 1510728932011)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (199, 46, 16.116059, 109.842033, 1510728936451)
GO
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (200, 45, 13.197372, 111.239525, 1510728937022)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (201, 46, 16.126059, 109.845033, 1510728941448)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (202, 45, 13.207372, 111.242525, 1510728942021)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (203, 46, 16.136059, 109.848033, 1510728946453)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (204, 45, 13.217372, 111.245525, 1510728947004)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (205, 46, 16.146059, 109.851033, 1510728951458)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (206, 45, 13.227372, 111.248525, 1510728952012)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (207, 47, 16.156059, 109.854033, 1510729111157)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (208, 47, 16.166059, 109.857033, 1510729116191)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (209, 47, 16.176059, 109.860033, 1510729121193)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (210, 48, 16.186059, 109.863033, 1510738387618)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (211, 48, 16.196059, 109.866033, 1510738392749)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (212, 48, 16.206059, 109.869033, 1510738397660)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (213, 48, 16.216059, 109.872033, 1510738402649)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (214, 48, 16.226059, 109.875033, 1510738407659)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (215, 48, 16.236059, 109.878033, 1510738412646)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (216, 49, 18.201945, 107.745662, 1510795564550)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (217, 49, 18.211945, 107.748662, 1510795569645)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (218, 49, 18.221945, 107.751662, 1510795574615)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (219, 49, 18.231945, 107.754662, 1510795579592)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (220, 49, 18.241945, 107.757662, 1510795584607)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (221, 49, 18.251945, 107.760662, 1510795589610)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (222, 50, 13.247372, 111.060525, 1510795879770)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (223, 50, 13.947372, 110.990525, 1510795884812)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (224, 50, 14.777372, 110.825525, 1510795889801)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (225, 50, 15.727372, 110.575525, 1510795894800)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (226, 50, 15.807372, 110.225525, 1510795899802)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (227, 51, 17.092346, 110.025334, 1510804375730)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (228, 51, 17.132346, 109.262334, 1510804380783)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (229, 51, 17.942346, 109.100334, 1510804385757)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (230, 51, 18.872346, 108.845334, 1510804390766)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (231, 51, 14.251739, 110.313721, 1510804395869)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (232, 52, 16.516059, 110.258033, 1514123719455)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (233, 52, 16.526059, 110.250033, 1514123724485)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (234, 52, 17.416059, 110.511033, 1514123729472)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (235, 52, 17.491168, 108.912964, 1514123734471)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (236, 53, 15.817372, 110.228525, 1514123788991)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (237, 53, 15.827372, 110.231525, 1514123794022)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (238, 53, 15.837372, 110.234525, 1514123799015)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (239, 53, 15.847372, 110.237525, 1514123804018)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (240, 53, 15.857372, 110.240525, 1514123809018)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (241, 53, 15.867372, 110.243525, 1514123814019)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (242, 54, 15.577372, 110.246525, 1514128743041)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (243, 55, 17.501168, 108.915964, 1514132468452)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (244, 55, 17.511168, 108.918964, 1514132473477)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (245, 55, 17.521168, 108.921964, 1514132478469)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (246, 55, 17.531168, 108.924964, 1514132483469)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (247, 55, 17.541168, 108.927964, 1514132488471)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (248, 55, 17.551168, 108.930964, 1514132493470)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (249, 56, 17.561168, 108.933964, 1514133807645)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (250, 56, 17.571168, 108.936964, 1514133812674)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (251, 56, 17.581168, 108.939964, 1514133817673)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (252, 56, 17.591168, 108.942964, 1514133822674)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (253, 56, 17.601168, 108.945964, 1514133827672)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (254, 57, 17.611168, 108.948964, 1514133947313)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (255, 57, 17.621168, 108.951964, 1514133952330)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (256, 57, 17.631168, 108.954964, 1514133957331)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (257, 57, 17.641168, 108.957964, 1514133962332)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (258, 58, 15.587372, 110.249525, 1514134084919)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (259, 58, 15.597372, 110.252525, 1514134089975)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (260, 58, 15.607372, 110.255525, 1514134094970)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (261, 58, 15.617372, 110.258525, 1514134099975)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (262, 58, 15.627372, 110.261525, 1514134104981)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (263, 59, 18.261945, 107.763662, 1514134141377)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (264, 59, 18.271945, 107.766662, 1514134146396)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (265, 59, 16.861391, 108.649292, 1514134151393)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (266, 60, 15.637372, 110.264525, 1514135249811)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (267, 60, 15.647372, 110.267525, 1514135254872)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (268, 61, 15.657372, 110.270525, 1514135386695)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (269, 61, 15.667372, 110.273525, 1514135391721)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (270, 62, 17.651168, 108.960964, 1514135606296)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (271, 62, 17.661168, 108.963964, 1514135611333)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (272, 62, 17.671168, 108.966964, 1514135616328)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (273, 62, 17.681168, 108.969964, 1514135621328)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (274, 62, 17.691168, 108.972964, 1514135626331)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (275, 62, 17.701168, 108.975964, 1514135631328)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (276, 63, 17.711168, 108.978964, 1514135644984)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (277, 63, 17.721168, 108.981964, 1514135650067)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (278, 64, 17.731168, 108.984964, 1514135748708)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (279, 64, 17.741168, 108.987964, 1514135753739)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (280, 64, 17.751168, 108.990964, 1514135758737)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (281, 64, 15.716256, 109.390869, 1514135763747)
INSERT [dbo].[vitritauthuyen] ([ma], [mahanhtrinh], [vido], [kinhdo], [thoigian]) VALUES (282, 65, 15.677372, 110.276525, 1514135902217)
SET IDENTITY_INSERT [dbo].[vitritauthuyen] OFF
ALTER TABLE [dbo].[conbao]  WITH CHECK ADD  CONSTRAINT [FK_conbao_tinhtrang] FOREIGN KEY([matinhtrang])
REFERENCES [dbo].[tinhtrang] ([ma])
GO
ALTER TABLE [dbo].[conbao] CHECK CONSTRAINT [FK_conbao_tinhtrang]
GO
ALTER TABLE [dbo].[hanhtrinh]  WITH CHECK ADD  CONSTRAINT [FK_hanhtrinh_tauthuyen] FOREIGN KEY([matauthuyen])
REFERENCES [dbo].[tauthuyen] ([ma])
GO
ALTER TABLE [dbo].[hanhtrinh] CHECK CONSTRAINT [FK_hanhtrinh_tauthuyen]
GO
ALTER TABLE [dbo].[hanhtrinhbao]  WITH CHECK ADD  CONSTRAINT [FK_hanhtrinhbao_conbao] FOREIGN KEY([maconbao])
REFERENCES [dbo].[conbao] ([ma])
GO
ALTER TABLE [dbo].[hanhtrinhbao] CHECK CONSTRAINT [FK_hanhtrinhbao_conbao]
GO
ALTER TABLE [dbo].[tauthuyen]  WITH CHECK ADD  CONSTRAINT [FK_tauthuyen_loaitau] FOREIGN KEY([maloaitau])
REFERENCES [dbo].[loaitau] ([ma])
GO
ALTER TABLE [dbo].[tauthuyen] CHECK CONSTRAINT [FK_tauthuyen_loaitau]
GO
ALTER TABLE [dbo].[tauthuyen]  WITH CHECK ADD  CONSTRAINT [FK_tauthuyen_quocgia] FOREIGN KEY([maquocgia])
REFERENCES [dbo].[quocgia] ([ma])
GO
ALTER TABLE [dbo].[tauthuyen] CHECK CONSTRAINT [FK_tauthuyen_quocgia]
GO
ALTER TABLE [dbo].[vitribao]  WITH CHECK ADD  CONSTRAINT [FK_vitribao_hanhtrinhbao] FOREIGN KEY([mahanhtrinh])
REFERENCES [dbo].[hanhtrinhbao] ([ma])
GO
ALTER TABLE [dbo].[vitribao] CHECK CONSTRAINT [FK_vitribao_hanhtrinhbao]
GO
ALTER TABLE [dbo].[vitritauthuyen]  WITH CHECK ADD  CONSTRAINT [FK_vitritauthuyen_hanhtrinh] FOREIGN KEY([mahanhtrinh])
REFERENCES [dbo].[hanhtrinh] ([ma])
GO
ALTER TABLE [dbo].[vitritauthuyen] CHECK CONSTRAINT [FK_vitritauthuyen_hanhtrinh]
GO
/****** Object:  StoredProcedure [dbo].[suaViTriBao]    Script Date: 12/26/2017 8:49:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 create proc [dbo].[suaViTriBao]
(@ma int,
@kinhDo float,
 @viDo float, 
 @thoiGian bigint, 
 @vanToc float)
 as
 begin
 update vitribao
 set vido = @viDo ,kinhdo = @kinhDo, thoigian = @thoiGian, vantoc = @vanToc
 where ma = @ma
 end
GO
/****** Object:  StoredProcedure [dbo].[themConBao]    Script Date: 12/26/2017 8:49:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[themConBao]
(@ma varchar(50), 
 @tenConBao nvarchar(50),
 @ghiChu nvarchar(MAX),
 @thoiGianHinhThanh bigint,
 @maTinhTrang int,
 @trangThai int
 )
 as
 begin
 insert into conbao(ma,tenconbao,ghichu,thoigianhinhthanh,matinhtrang)
 values(@ma, @tenConBao,@ghiChu,@thoiGianHinhThanh,@maTinhTrang)
 
 insert into hanhtrinhbao(maconbao,trangthai)
 values(@ma, @trangThai)
 end
GO
/****** Object:  StoredProcedure [dbo].[themloaitau]    Script Date: 12/26/2017 8:49:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[themloaitau] @maloaitau varchar(50), @tenloaitau nvarchar(50), @kieutau nvarchar(50)
as
begin
insert into loaitau 
values(@maloaitau, @tenloaitau, @kieutau )
end
GO
/****** Object:  StoredProcedure [dbo].[themViTriBao]    Script Date: 12/26/2017 8:49:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 create proc [dbo].[themViTriBao]
(@mahanhtrinh int, 
 @vido float,
 @kinhDo float,
 @thoiGian bigint,
 @vanToc float
 )
 as
 begin
 insert into vitribao (mahanhtrinh, vido, kinhdo, thoigian, vantoc)
 values(@mahanhtrinh,@vido,@kinhdo, @thoiGian,@vanToc)
 end
GO
/****** Object:  StoredProcedure [dbo].[updateShipType]    Script Date: 12/26/2017 8:49:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[updateShipType] @IDShipType varchar(50), @NameShipType nvarchar(50), @ShipType nvarchar(50)
as
begin
update loaitau
set
   tenloaitau= @NameShipType,
   kieutau= @ShipType

where 
   ma=@IDShipType
end
GO
/****** Object:  StoredProcedure [dbo].[xoaHanhTrinhBao]    Script Date: 12/26/2017 8:49:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[xoaHanhTrinhBao]
(@mahanhtrinh int)
 as
 begin
 delete from vitribao where mahanhtrinh = @mahanhtrinh
 
 delete from hanhtrinhbao where ma =@mahanhtrinh
 end
GO
USE [master]
GO
ALTER DATABASE [boat] SET  READ_WRITE 
GO
