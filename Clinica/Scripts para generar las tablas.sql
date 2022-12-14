USE [master]
GO

/****** Object:  Database [Clinic]    Script Date: 11/12/2022 19:24:19 ******/
CREATE DATABASE [Clinic]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Clinica', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Clinica.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Clinica_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Clinica.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Clinic].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [Clinic] SET ANSI_NULL_DEFAULT ON 
GO

ALTER DATABASE [Clinic] SET ANSI_NULLS ON 
GO

ALTER DATABASE [Clinic] SET ANSI_PADDING ON 
GO

ALTER DATABASE [Clinic] SET ANSI_WARNINGS ON 
GO

ALTER DATABASE [Clinic] SET ARITHABORT ON 
GO

ALTER DATABASE [Clinic] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [Clinic] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [Clinic] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [Clinic] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [Clinic] SET CURSOR_DEFAULT  LOCAL 
GO

ALTER DATABASE [Clinic] SET CONCAT_NULL_YIELDS_NULL ON 
GO

ALTER DATABASE [Clinic] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [Clinic] SET QUOTED_IDENTIFIER ON 
GO

ALTER DATABASE [Clinic] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [Clinic] SET  DISABLE_BROKER 
GO

ALTER DATABASE [Clinic] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [Clinic] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [Clinic] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [Clinic] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [Clinic] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [Clinic] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [Clinic] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [Clinic] SET RECOVERY FULL 
GO

ALTER DATABASE [Clinic] SET  MULTI_USER 
GO

ALTER DATABASE [Clinic] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [Clinic] SET DB_CHAINING OFF 
GO

ALTER DATABASE [Clinic] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [Clinic] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO

ALTER DATABASE [Clinic] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [Clinic] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO

ALTER DATABASE [Clinic] SET QUERY_STORE = OFF
GO

ALTER DATABASE [Clinic] SET  READ_WRITE 
GO

