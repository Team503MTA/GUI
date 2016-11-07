USE [master]
GO
/****** Object:  Database [POPULATION]    Script Date: 9/12/2016 8:31:48 PM ******/
CREATE DATABASE [POPULATION]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Population', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\Population.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Population_log', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\Population_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [POPULATION] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [POPULATION].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [POPULATION] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [POPULATION] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [POPULATION] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [POPULATION] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [POPULATION] SET ARITHABORT OFF 
GO
ALTER DATABASE [POPULATION] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [POPULATION] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [POPULATION] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [POPULATION] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [POPULATION] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [POPULATION] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [POPULATION] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [POPULATION] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [POPULATION] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [POPULATION] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [POPULATION] SET  DISABLE_BROKER 
GO
ALTER DATABASE [POPULATION] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [POPULATION] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [POPULATION] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [POPULATION] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [POPULATION] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [POPULATION] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [POPULATION] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [POPULATION] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [POPULATION] SET  MULTI_USER 
GO
ALTER DATABASE [POPULATION] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [POPULATION] SET DB_CHAINING OFF 
GO
ALTER DATABASE [POPULATION] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [POPULATION] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [POPULATION]
GO
/****** Object:  Table [dbo].[Age]    Script Date: 9/12/2016 8:31:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Age](
	[AgeID] [int] IDENTITY(1,1) NOT NULL,
	[AgeStart] [int] NULL,
	[AgeEnd] [int] NULL,
 CONSTRAINT [PK_Age] PRIMARY KEY CLUSTERED 
(
	[AgeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Job]    Script Date: 9/12/2016 8:31:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Job](
	[JobID] [int] NOT NULL,
	[JobName] [nvarchar](50) NULL,
 CONSTRAINT [PK_Job] PRIMARY KEY CLUSTERED 
(
	[JobID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[MemberInfo]    Script Date: 9/12/2016 8:31:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MemberInfo](
	[MemberId] [int] IDENTITY(1,1) NOT NULL,
	[MemberName] [nvarchar](50) NULL,
	[MemberTypeId] [int] NULL,
	[MemberParent] [int] NULL,
 CONSTRAINT [PK_MemberInfo] PRIMARY KEY CLUSTERED 
(
	[MemberId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[MemberQuantity]    Script Date: 9/12/2016 8:31:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MemberQuantity](
	[MemberId] [int] NOT NULL,
	[AgeID] [int] NOT NULL,
	[SexID] [int] NOT NULL,
	[JobID] [int] NOT NULL,
	[Year] [int] NOT NULL,
	[Quantity] [int] NULL,
 CONSTRAINT [PK_MemberQuantity] PRIMARY KEY CLUSTERED 
(
	[MemberId] ASC,
	[AgeID] ASC,
	[SexID] ASC,
	[JobID] ASC,
	[Year] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[MemberType]    Script Date: 9/12/2016 8:31:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MemberType](
	[MemberTypeId] [int] NOT NULL,
	[MemberTypeName] [nchar](10) NULL,
 CONSTRAINT [PK_MemberType] PRIMARY KEY CLUSTERED 
(
	[MemberTypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Sex]    Script Date: 9/12/2016 8:31:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sex](
	[SexID] [int] NOT NULL,
	[SexName] [nvarchar](10) NULL,
 CONSTRAINT [PK_Sex] PRIMARY KEY CLUSTERED 
(
	[SexID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[MemberInfo]  WITH CHECK ADD  CONSTRAINT [FK_MemberInfo_MemberType] FOREIGN KEY([MemberTypeId])
REFERENCES [dbo].[MemberType] ([MemberTypeId])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[MemberInfo] CHECK CONSTRAINT [FK_MemberInfo_MemberType]
GO
ALTER TABLE [dbo].[MemberQuantity]  WITH CHECK ADD  CONSTRAINT [FK_MemberQuantity_Age] FOREIGN KEY([AgeID])
REFERENCES [dbo].[Age] ([AgeID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[MemberQuantity] CHECK CONSTRAINT [FK_MemberQuantity_Age]
GO
ALTER TABLE [dbo].[MemberQuantity]  WITH CHECK ADD  CONSTRAINT [FK_MemberQuantity_Job] FOREIGN KEY([JobID])
REFERENCES [dbo].[Job] ([JobID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[MemberQuantity] CHECK CONSTRAINT [FK_MemberQuantity_Job]
GO
ALTER TABLE [dbo].[MemberQuantity]  WITH CHECK ADD  CONSTRAINT [FK_MemberQuantity_MemberInfo] FOREIGN KEY([MemberId])
REFERENCES [dbo].[MemberInfo] ([MemberId])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[MemberQuantity] CHECK CONSTRAINT [FK_MemberQuantity_MemberInfo]
GO
ALTER TABLE [dbo].[MemberQuantity]  WITH CHECK ADD  CONSTRAINT [FK_MemberQuantity_Sex] FOREIGN KEY([SexID])
REFERENCES [dbo].[Sex] ([SexID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[MemberQuantity] CHECK CONSTRAINT [FK_MemberQuantity_Sex]
GO
USE [master]
GO
ALTER DATABASE [POPULATION] SET  READ_WRITE 
GO
