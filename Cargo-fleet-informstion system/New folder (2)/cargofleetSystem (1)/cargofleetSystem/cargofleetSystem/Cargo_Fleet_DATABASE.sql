USE [master]
GO

/****** Object:  Database [Cargo_Fleet_Database]    Script Date: 2021/11/03 23:26:50 ******/
DROP DATABASE [Cargo_Fleet_Database]
GO

/****** Object:  Database [Cargo_Fleet_Database]    Script Date: 2021/11/03 23:26:50 ******/
CREATE DATABASE [Cargo_Fleet_Database]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Cargo_Fleet_Database', FILENAME = N'C:\Users\EDDIE\Cargo_Fleet_Database.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Cargo_Fleet_Database_log', FILENAME = N'C:\Users\EDDIE\Cargo_Fleet_Database_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Cargo_Fleet_Database].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [Cargo_Fleet_Database] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [Cargo_Fleet_Database] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [Cargo_Fleet_Database] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [Cargo_Fleet_Database] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [Cargo_Fleet_Database] SET ARITHABORT OFF 
GO

ALTER DATABASE [Cargo_Fleet_Database] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [Cargo_Fleet_Database] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [Cargo_Fleet_Database] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [Cargo_Fleet_Database] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [Cargo_Fleet_Database] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [Cargo_Fleet_Database] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [Cargo_Fleet_Database] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [Cargo_Fleet_Database] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [Cargo_Fleet_Database] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [Cargo_Fleet_Database] SET  DISABLE_BROKER 
GO

ALTER DATABASE [Cargo_Fleet_Database] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [Cargo_Fleet_Database] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [Cargo_Fleet_Database] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [Cargo_Fleet_Database] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [Cargo_Fleet_Database] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [Cargo_Fleet_Database] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [Cargo_Fleet_Database] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [Cargo_Fleet_Database] SET RECOVERY SIMPLE 
GO

ALTER DATABASE [Cargo_Fleet_Database] SET  MULTI_USER 
GO

ALTER DATABASE [Cargo_Fleet_Database] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [Cargo_Fleet_Database] SET DB_CHAINING OFF 
GO

ALTER DATABASE [Cargo_Fleet_Database] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [Cargo_Fleet_Database] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO

ALTER DATABASE [Cargo_Fleet_Database] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [Cargo_Fleet_Database] SET QUERY_STORE = OFF
GO

USE [Cargo_Fleet_Database]
GO

ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO

ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO

ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO

ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO

ALTER DATABASE [Cargo_Fleet_Database] SET  READ_WRITE 
GO

