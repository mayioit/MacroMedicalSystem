USE [master]
GO
/****** Object:  Database [++DB++]    Script Date: 07/23/2007 17:16:02 ******/
CREATE DATABASE [++DB++] ON  PRIMARY 
( NAME = N'++DB++', FILENAME = N'++DBFOLDER++\++DB++.mdf' , SIZE = 64MB , MAXSIZE = UNLIMITED, FILEGROWTH = 64MB ), 
 FILEGROUP [INDEXES] 
( NAME = N'++DB++_Indexes', FILENAME = N'++INDEXFOLDER++\++DB++ Indexes.ndf' , SIZE = 64MB , MAXSIZE = UNLIMITED, FILEGROWTH = 64MB ), 
 FILEGROUP [QUEUES] 
( NAME = N'++DB++ Queues', FILENAME = N'++QUEUEFOLDER++\++DB++ Queues.ndf' , SIZE = 64MB , MAXSIZE = UNLIMITED, FILEGROWTH = 64MB ), 
 FILEGROUP [STATIC] 
( NAME = N'++DB++ Static Tables', FILENAME = N'++STATICFOLDER++\++DB++ Static Tables.ndf' , SIZE = 4MB , MAXSIZE = UNLIMITED, FILEGROWTH = 2MB )
 LOG ON 
( NAME = N'++DB++_log', FILENAME = N'++LOGFOLDER++\++DB++_log.LDF' , SIZE = 32MB , MAXSIZE = 20GB , FILEGROWTH = 10%)
GO
EXEC dbo.sp_dbcmptlevel @dbname=N'++DB++', @new_cmptlevel=90
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [++DB++].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [++DB++] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [++DB++] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [++DB++] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [++DB++] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [++DB++] SET ARITHABORT OFF 
GO
ALTER DATABASE [++DB++] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [++DB++] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [++DB++] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [++DB++] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [++DB++] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [++DB++] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [++DB++] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [++DB++] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [++DB++] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [++DB++] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [++DB++] SET  ENABLE_BROKER 
GO
ALTER DATABASE [++DB++] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [++DB++] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [++DB++] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [++DB++] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [++DB++] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [++DB++] SET  READ_WRITE 
GO
ALTER DATABASE [++DB++] SET RECOVERY FULL 
GO
ALTER DATABASE [++DB++] SET  MULTI_USER 
GO
ALTER DATABASE [++DB++] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [++DB++] SET DB_CHAINING OFF 
