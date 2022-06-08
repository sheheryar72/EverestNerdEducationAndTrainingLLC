USE [master]
GO
/****** Object:  Database [EverestNerdEducationAndTrainingLLC]    Script Date: 6/8/2022 12:31:22 AM ******/
CREATE DATABASE [EverestNerdEducationAndTrainingLLC]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'EverestNerdEducationAndTrainingLLC', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\EverestNerdEducationAndTrainingLLC.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'EverestNerdEducationAndTrainingLLC_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\EverestNerdEducationAndTrainingLLC_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [EverestNerdEducationAndTrainingLLC] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [EverestNerdEducationAndTrainingLLC].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [EverestNerdEducationAndTrainingLLC] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [EverestNerdEducationAndTrainingLLC] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [EverestNerdEducationAndTrainingLLC] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [EverestNerdEducationAndTrainingLLC] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [EverestNerdEducationAndTrainingLLC] SET ARITHABORT OFF 
GO
ALTER DATABASE [EverestNerdEducationAndTrainingLLC] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [EverestNerdEducationAndTrainingLLC] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [EverestNerdEducationAndTrainingLLC] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [EverestNerdEducationAndTrainingLLC] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [EverestNerdEducationAndTrainingLLC] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [EverestNerdEducationAndTrainingLLC] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [EverestNerdEducationAndTrainingLLC] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [EverestNerdEducationAndTrainingLLC] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [EverestNerdEducationAndTrainingLLC] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [EverestNerdEducationAndTrainingLLC] SET  ENABLE_BROKER 
GO
ALTER DATABASE [EverestNerdEducationAndTrainingLLC] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [EverestNerdEducationAndTrainingLLC] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [EverestNerdEducationAndTrainingLLC] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [EverestNerdEducationAndTrainingLLC] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [EverestNerdEducationAndTrainingLLC] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [EverestNerdEducationAndTrainingLLC] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [EverestNerdEducationAndTrainingLLC] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [EverestNerdEducationAndTrainingLLC] SET RECOVERY FULL 
GO
ALTER DATABASE [EverestNerdEducationAndTrainingLLC] SET  MULTI_USER 
GO
ALTER DATABASE [EverestNerdEducationAndTrainingLLC] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [EverestNerdEducationAndTrainingLLC] SET DB_CHAINING OFF 
GO
ALTER DATABASE [EverestNerdEducationAndTrainingLLC] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [EverestNerdEducationAndTrainingLLC] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [EverestNerdEducationAndTrainingLLC] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [EverestNerdEducationAndTrainingLLC] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'EverestNerdEducationAndTrainingLLC', N'ON'
GO
ALTER DATABASE [EverestNerdEducationAndTrainingLLC] SET QUERY_STORE = OFF
GO
USE [EverestNerdEducationAndTrainingLLC]
GO
/****** Object:  Table [dbo].[ClientFeedBack]    Script Date: 6/8/2022 12:31:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ClientFeedBack](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NULL,
	[Feedback] [varchar](500) NULL,
	[department] [varchar](150) NULL,
	[ImageUrl] [varchar](500) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Contact]    Script Date: 6/8/2022 12:31:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Contact](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Email] [varchar](50) NOT NULL,
	[Subject] [varchar](200) NULL,
	[Phone] [bigint] NULL,
	[Message] [varchar](1500) NULL,
 CONSTRAINT [PK__Contact__3214EC0791CFD76B] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 6/8/2022 12:31:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [varchar](50) NULL,
	[Email] [varchar](50) NULL,
	[Age] [int] NULL,
	[ContactNo] [varchar](50) NULL,
	[Password] [varchar](50) NULL,
	[Interestofstudy] [varchar](50) NULL,
	[Grade] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[ClientFeedBack] ON 
GO
INSERT [dbo].[ClientFeedBack] ([Id], [Name], [Feedback], [department], [ImageUrl]) VALUES (1, N'Rubina Helen', N'Aliquetn sollicitudirem quibibendum auci elit cons equat ipsutis sem nibh id elit. Duis sed odio sit amet sem nibh id elit sollicitudirem', N'Bsc, Engineering', N'/WebsiteTemplate/images/testimonial/t-2.jpg')
GO
INSERT [dbo].[ClientFeedBack] ([Id], [Name], [Feedback], [department], [ImageUrl]) VALUES (2, N'John Helen', N'Aliquetn sollicitudirem quibibendum auci elit cons equat ipsutis sem nibh id elit. Duis sed odio sit amet sem nibh id elit sollicitudirem', N'Computer Scienve', N'/WebsiteTemplate/images/testimonial/t-2.jpg')
GO
INSERT [dbo].[ClientFeedBack] ([Id], [Name], [Feedback], [department], [ImageUrl]) VALUES (4, N'Elizy Beth', N'Aliquetn sollicitudirem quibibendum auci elit cons equat ipsutis sem nibh id elit. Duis sed odio sit amet sem nibh id elit sollicitudirem', N'Bsc, Engineering', N'/WebsiteTemplate/images/testimonial/t-2.jpg')
GO
SET IDENTITY_INSERT [dbo].[ClientFeedBack] OFF
GO
SET IDENTITY_INSERT [dbo].[Contact] ON 
GO
INSERT [dbo].[Contact] ([Id], [Name], [Email], [Subject], [Phone], [Message]) VALUES (1, N'sheherayar', N'Sheheryarizhar@gmail.com', N'First Subject', 923102475070, NULL)
GO
INSERT [dbo].[Contact] ([Id], [Name], [Email], [Subject], [Phone], [Message]) VALUES (2, N'ad', N'asd@gmail.com', N'dfdsf', 3434343, NULL)
GO
INSERT [dbo].[Contact] ([Id], [Name], [Email], [Subject], [Phone], [Message]) VALUES (3, N'ad', N'asd@gmail.com', N'dfdsf', 3434343, NULL)
GO
INSERT [dbo].[Contact] ([Id], [Name], [Email], [Subject], [Phone], [Message]) VALUES (5, N'sheheryar', N'Sheheryarizhar@gmail.com', NULL, 923102475070, NULL)
GO
INSERT [dbo].[Contact] ([Id], [Name], [Email], [Subject], [Phone], [Message]) VALUES (6, N'sheherayar', N'Sheheryarizhar@gmail.com', N'rgtr', 923102475070, N'resresrse')
GO
INSERT [dbo].[Contact] ([Id], [Name], [Email], [Subject], [Phone], [Message]) VALUES (7, N'sheherayar', N'Sheheryarizhar@gmail.com', N'ee', 923102475070, N'eeeere')
GO
INSERT [dbo].[Contact] ([Id], [Name], [Email], [Subject], [Phone], [Message]) VALUES (8, N'sheherayar', N'Sheheryarizhar@gmail.com', N'awraer', 923102475070, N'aerer')
GO
INSERT [dbo].[Contact] ([Id], [Name], [Email], [Subject], [Phone], [Message]) VALUES (9, N'yaseen izhar', N'yaseenizhar01@gmail.com', N'ugkhh', 989898, N'jhguughgbkj')
GO
SET IDENTITY_INSERT [dbo].[Contact] OFF
GO
SET IDENTITY_INSERT [dbo].[User] ON 
GO
INSERT [dbo].[User] ([Id], [UserName], [Email], [Age], [ContactNo], [Password], [Interestofstudy], [Grade]) VALUES (1, N'Sheheryar', N'Sheheryarizhar@gmail.com', 22, N'03102475070', N'123', NULL, NULL)
GO
INSERT [dbo].[User] ([Id], [UserName], [Email], [Age], [ContactNo], [Password], [Interestofstudy], [Grade]) VALUES (2, N'yaseen', N'yaseenizhar@gmail.com', 20, N'03113211004', N'123', NULL, NULL)
GO
INSERT [dbo].[User] ([Id], [UserName], [Email], [Age], [ContactNo], [Password], [Interestofstudy], [Grade]) VALUES (3, N'Sheheryar1', N'Sheheryari1zhar@gmail.com', 212, N'031012475070', N'123', NULL, NULL)
GO
INSERT [dbo].[User] ([Id], [UserName], [Email], [Age], [ContactNo], [Password], [Interestofstudy], [Grade]) VALUES (4, N'jhdcfbvasdhvc', N'ssdsa@gmail.com', 525, N'210939127873216', N'232', NULL, NULL)
GO
INSERT [dbo].[User] ([Id], [UserName], [Email], [Age], [ContactNo], [Password], [Interestofstudy], [Grade]) VALUES (5, N'sddfsdf', N'as@gmail.com1', 33, N'34353433', N'1323', NULL, NULL)
GO
INSERT [dbo].[User] ([Id], [UserName], [Email], [Age], [ContactNo], [Password], [Interestofstudy], [Grade]) VALUES (6, N'sefrsdf', N'yaseenizh333ar@gmail.com', 33, N'33333', N'333', NULL, NULL)
GO
INSERT [dbo].[User] ([Id], [UserName], [Email], [Age], [ContactNo], [Password], [Interestofstudy], [Grade]) VALUES (1002, N'john', N'johnsteve@gmail.com', 29, N'03126545614', N'123', NULL, NULL)
GO
INSERT [dbo].[User] ([Id], [UserName], [Email], [Age], [ContactNo], [Password], [Interestofstudy], [Grade]) VALUES (1003, N'sheheryar1', N'Sheheryarizhar1@gmail.com', 25, N'03161654545', N'123', NULL, NULL)
GO
INSERT [dbo].[User] ([Id], [UserName], [Email], [Age], [ContactNo], [Password], [Interestofstudy], [Grade]) VALUES (2002, N'yaseen', N'yaseen@gmail.com', 21, N'031169984585', N'123', NULL, NULL)
GO
INSERT [dbo].[User] ([Id], [UserName], [Email], [Age], [ContactNo], [Password], [Interestofstudy], [Grade]) VALUES (2003, N'yaseen', N'yaseen@gmail.cm', 21, N'031169984585', N'123', NULL, NULL)
GO
INSERT [dbo].[User] ([Id], [UserName], [Email], [Age], [ContactNo], [Password], [Interestofstudy], [Grade]) VALUES (3002, N'sdfsd', N'dfd@gmail.com', 2, N'23123213213', N'123', NULL, NULL)
GO
INSERT [dbo].[User] ([Id], [UserName], [Email], [Age], [ContactNo], [Password], [Interestofstudy], [Grade]) VALUES (3003, N'asdas', N'dfsdd@gmail.com', 33, N'dsfs', N'4343434', N'11', N'sadas')
GO
INSERT [dbo].[User] ([Id], [UserName], [Email], [Age], [ContactNo], [Password], [Interestofstudy], [Grade]) VALUES (4003, N'dfsdf', N'aa@gmail.com', -4, N'1', N'-3', N'111', N'1')
GO
INSERT [dbo].[User] ([Id], [UserName], [Email], [Age], [ContactNo], [Password], [Interestofstudy], [Grade]) VALUES (4004, NULL, NULL, 0, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[User] ([Id], [UserName], [Email], [Age], [ContactNo], [Password], [Interestofstudy], [Grade]) VALUES (4005, NULL, NULL, 0, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[User] ([Id], [UserName], [Email], [Age], [ContactNo], [Password], [Interestofstudy], [Grade]) VALUES (4006, NULL, NULL, 0, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[User] ([Id], [UserName], [Email], [Age], [ContactNo], [Password], [Interestofstudy], [Grade]) VALUES (4007, NULL, NULL, 0, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[User] ([Id], [UserName], [Email], [Age], [ContactNo], [Password], [Interestofstudy], [Grade]) VALUES (4008, NULL, NULL, 0, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[User] ([Id], [UserName], [Email], [Age], [ContactNo], [Password], [Interestofstudy], [Grade]) VALUES (4009, NULL, NULL, 0, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[User] ([Id], [UserName], [Email], [Age], [ContactNo], [Password], [Interestofstudy], [Grade]) VALUES (4010, NULL, NULL, 0, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[User] ([Id], [UserName], [Email], [Age], [ContactNo], [Password], [Interestofstudy], [Grade]) VALUES (4011, NULL, NULL, 0, NULL, NULL, NULL, NULL)
GO
SET IDENTITY_INSERT [dbo].[User] OFF
GO
USE [master]
GO
ALTER DATABASE [EverestNerdEducationAndTrainingLLC] SET  READ_WRITE 
GO
