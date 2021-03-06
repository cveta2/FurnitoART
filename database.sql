USE [master]
GO
/****** Object:  Database [ASPProject]    Script Date: 6/26/2022 9:31:20 AM ******/
CREATE DATABASE [ASPProject]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ASPProject', FILENAME = N'D:\Programi\SQL server express\MSSQL15.SQLEXPRESS\MSSQL\DATA\ASPProject.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'ASPProject_log', FILENAME = N'D:\Programi\SQL server express\MSSQL15.SQLEXPRESS\MSSQL\DATA\ASPProject_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [ASPProject] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ASPProject].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ASPProject] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ASPProject] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ASPProject] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ASPProject] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ASPProject] SET ARITHABORT OFF 
GO
ALTER DATABASE [ASPProject] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ASPProject] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ASPProject] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ASPProject] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ASPProject] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ASPProject] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ASPProject] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ASPProject] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ASPProject] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ASPProject] SET  DISABLE_BROKER 
GO
ALTER DATABASE [ASPProject] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ASPProject] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ASPProject] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ASPProject] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ASPProject] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ASPProject] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ASPProject] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ASPProject] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [ASPProject] SET  MULTI_USER 
GO
ALTER DATABASE [ASPProject] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ASPProject] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ASPProject] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ASPProject] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [ASPProject] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [ASPProject] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [ASPProject] SET QUERY_STORE = OFF
GO
USE [ASPProject]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 6/26/2022 9:31:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AuditLogs]    Script Date: 6/26/2022 9:31:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AuditLogs](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UseCaseName] [nvarchar](200) NOT NULL,
	[UserId] [int] NOT NULL,
	[Date] [datetime2](7) NOT NULL,
	[Data] [nvarchar](max) NULL,
	[IsAuthorized] [bit] NOT NULL,
 CONSTRAINT [PK_AuditLogs] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Carts]    Script Date: 6/26/2022 9:31:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Carts](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [int] NOT NULL,
	[ProductId] [int] NOT NULL,
	[Quantity] [int] NOT NULL,
	[IsActive] [bit] NOT NULL,
	[CreatedAt] [datetime2](7) NOT NULL,
	[UpdatedAt] [datetime2](7) NULL,
	[DeletedAt] [datetime2](7) NULL,
 CONSTRAINT [PK_Carts] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Categories]    Script Date: 6/26/2022 9:31:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categories](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CategoryName] [nvarchar](100) NOT NULL,
	[ParentCategoryId] [int] NULL,
	[IsActive] [bit] NOT NULL,
	[CreatedAt] [datetime2](7) NOT NULL,
	[UpdatedAt] [datetime2](7) NULL,
	[DeletedAt] [datetime2](7) NULL,
 CONSTRAINT [PK_Categories] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ExceptionLogs]    Script Date: 6/26/2022 9:31:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ExceptionLogs](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[OccuredAt] [datetime2](7) NOT NULL,
	[Message] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_ExceptionLogs] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Images]    Script Date: 6/26/2022 9:31:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Images](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Path] [nvarchar](100) NOT NULL,
	[Alt] [nvarchar](100) NOT NULL,
	[ProductId] [int] NOT NULL,
	[IsActive] [bit] NOT NULL,
	[CreatedAt] [datetime2](7) NOT NULL,
	[UpdatedAt] [datetime2](7) NULL,
	[DeletedAt] [datetime2](7) NULL,
 CONSTRAINT [PK_Images] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrderItems]    Script Date: 6/26/2022 9:31:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderItems](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[OrderId] [int] NOT NULL,
	[ProductId] [int] NOT NULL,
	[Quantity] [int] NOT NULL,
	[IsActive] [bit] NOT NULL,
	[CreatedAt] [datetime2](7) NOT NULL,
	[UpdatedAt] [datetime2](7) NULL,
	[DeletedAt] [datetime2](7) NULL,
 CONSTRAINT [PK_OrderItems] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Orders]    Script Date: 6/26/2022 9:31:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [int] NOT NULL,
	[OrderNumber] [int] NOT NULL,
	[Address] [nvarchar](100) NOT NULL,
	[City] [nvarchar](100) NOT NULL,
	[Country] [nvarchar](100) NOT NULL,
	[Phone] [nvarchar](50) NOT NULL,
	[IsActive] [bit] NOT NULL,
	[CreatedAt] [datetime2](7) NOT NULL,
	[UpdatedAt] [datetime2](7) NULL,
	[DeletedAt] [datetime2](7) NULL,
 CONSTRAINT [PK_Orders] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Prices]    Script Date: 6/26/2022 9:31:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Prices](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[PriceValue] [decimal](18, 2) NOT NULL,
	[ProductId] [int] NOT NULL,
	[IsActive] [bit] NOT NULL,
	[CreatedAt] [datetime2](7) NOT NULL,
	[UpdatedAt] [datetime2](7) NULL,
	[DeletedAt] [datetime2](7) NULL,
 CONSTRAINT [PK_Prices] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Products]    Script Date: 6/26/2022 9:31:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ProductName] [nvarchar](50) NOT NULL,
	[Description] [nvarchar](max) NOT NULL,
	[CategoryId] [int] NOT NULL,
	[IsActive] [bit] NOT NULL,
	[CreatedAt] [datetime2](7) NOT NULL,
	[UpdatedAt] [datetime2](7) NULL,
	[DeletedAt] [datetime2](7) NULL,
 CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProductSpecifications]    Script Date: 6/26/2022 9:31:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductSpecifications](
	[SpecificationId] [int] NOT NULL,
	[ProductId] [int] NOT NULL,
	[SpecificationValue] [nvarchar](max) NOT NULL,
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CreatedAt] [datetime2](7) NOT NULL,
	[DeletedAt] [datetime2](7) NULL,
	[IsActive] [bit] NOT NULL,
	[UpdatedAt] [datetime2](7) NULL,
 CONSTRAINT [PK_ProductSpecifications] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Roles]    Script Date: 6/26/2022 9:31:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Roles](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[IsActive] [bit] NOT NULL,
	[CreatedAt] [datetime2](7) NOT NULL,
	[UpdatedAt] [datetime2](7) NULL,
	[DeletedAt] [datetime2](7) NULL,
 CONSTRAINT [PK_Roles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RoleUseCases]    Script Date: 6/26/2022 9:31:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RoleUseCases](
	[RoleId] [int] NOT NULL,
	[UseCaseId] [int] NOT NULL,
 CONSTRAINT [PK_RoleUseCases] PRIMARY KEY CLUSTERED 
(
	[RoleId] ASC,
	[UseCaseId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Specifications]    Script Date: 6/26/2022 9:31:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Specifications](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[SpecificationName] [nvarchar](50) NOT NULL,
	[IsActive] [bit] NOT NULL,
	[CreatedAt] [datetime2](7) NOT NULL,
	[UpdatedAt] [datetime2](7) NULL,
	[DeletedAt] [datetime2](7) NULL,
 CONSTRAINT [PK_Specifications] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 6/26/2022 9:31:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](100) NOT NULL,
	[LastName] [nvarchar](100) NOT NULL,
	[Email] [nvarchar](100) NOT NULL,
	[Password] [nvarchar](100) NOT NULL,
	[RoleId] [int] NOT NULL,
	[IsActive] [bit] NOT NULL,
	[CreatedAt] [datetime2](7) NOT NULL,
	[UpdatedAt] [datetime2](7) NULL,
	[DeletedAt] [datetime2](7) NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220531142514_InitialMigration', N'5.0.17')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220531164033_AddedDataForOrders', N'5.0.17')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220601082718_PhoneNumberTypeChangedToString', N'5.0.17')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220601102051_FullInitialDataAdded', N'5.0.17')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220601102915_FullInitialDataAdded2', N'5.0.17')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220602153929_AddedUseCaseIdsForRoles', N'5.0.17')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220602154832_AddedConfigurationForCart', N'5.0.17')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220602165405_ProductSpecificationModified', N'5.0.17')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220605174317_RoleUseCasesAdded', N'5.0.17')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220609154923_FinalMigration', N'5.0.17')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220624103830_AddedUseCaseForDeletingAllItemsFromCart', N'5.0.17')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220624113147_ChangedImagesForProducts', N'5.0.17')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220625201020_newProductsAdded', N'5.0.17')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220625203548_addedPricesForNewProducts', N'5.0.17')
GO
SET IDENTITY_INSERT [dbo].[AuditLogs] ON 

INSERT [dbo].[AuditLogs] ([Id], [UseCaseName], [UserId], [Date], [Data], [IsAuthorized]) VALUES (1, N'Get products with search and server-side pagination.', 0, CAST(N'2022-06-25T20:20:06.6809496' AS DateTime2), N'{"Category":0,"Keyword":null,"PerPage":15,"Page":1}', 1)
INSERT [dbo].[AuditLogs] ([Id], [UseCaseName], [UserId], [Date], [Data], [IsAuthorized]) VALUES (2, N'Search categories', 0, CAST(N'2022-06-25T20:20:06.6809436' AS DateTime2), N'{"Keyword":null,"PerPage":15,"Page":1}', 1)
INSERT [dbo].[AuditLogs] ([Id], [UseCaseName], [UserId], [Date], [Data], [IsAuthorized]) VALUES (3, N'Get products with search and server-side pagination.', 0, CAST(N'2022-06-25T20:20:22.3252543' AS DateTime2), N'{"Category":0,"Keyword":null,"PerPage":15,"Page":1}', 1)
INSERT [dbo].[AuditLogs] ([Id], [UseCaseName], [UserId], [Date], [Data], [IsAuthorized]) VALUES (4, N'Get products with search and server-side pagination.', 0, CAST(N'2022-06-25T20:20:27.2981232' AS DateTime2), N'{"Category":0,"Keyword":null,"PerPage":15,"Page":1}', 1)
INSERT [dbo].[AuditLogs] ([Id], [UseCaseName], [UserId], [Date], [Data], [IsAuthorized]) VALUES (5, N'Find product by id', 0, CAST(N'2022-06-25T20:20:29.4055367' AS DateTime2), N'19', 1)
INSERT [dbo].[AuditLogs] ([Id], [UseCaseName], [UserId], [Date], [Data], [IsAuthorized]) VALUES (6, N'Find product by id', 0, CAST(N'2022-06-25T20:36:42.9377050' AS DateTime2), N'19', 1)
INSERT [dbo].[AuditLogs] ([Id], [UseCaseName], [UserId], [Date], [Data], [IsAuthorized]) VALUES (7, N'Get products with search and server-side pagination.', 0, CAST(N'2022-06-25T20:37:03.8226321' AS DateTime2), N'{"Category":0,"Keyword":null,"PerPage":15,"Page":1}', 1)
INSERT [dbo].[AuditLogs] ([Id], [UseCaseName], [UserId], [Date], [Data], [IsAuthorized]) VALUES (8, N'Search categories', 0, CAST(N'2022-06-25T20:37:03.8226396' AS DateTime2), N'{"PerPage":15,"Page":1,"Keyword":null}', 1)
INSERT [dbo].[AuditLogs] ([Id], [UseCaseName], [UserId], [Date], [Data], [IsAuthorized]) VALUES (9, N'Get products with search and server-side pagination.', 0, CAST(N'2022-06-25T20:37:07.2321797' AS DateTime2), N'{"Category":0,"Keyword":null,"PerPage":15,"Page":1}', 1)
INSERT [dbo].[AuditLogs] ([Id], [UseCaseName], [UserId], [Date], [Data], [IsAuthorized]) VALUES (10, N'Get products with search and server-side pagination.', 0, CAST(N'2022-06-25T20:37:14.8293726' AS DateTime2), N'{"Category":0,"Keyword":null,"PerPage":15,"Page":1}', 1)
INSERT [dbo].[AuditLogs] ([Id], [UseCaseName], [UserId], [Date], [Data], [IsAuthorized]) VALUES (11, N'Get products with search and server-side pagination.', 0, CAST(N'2022-06-25T20:37:17.8603501' AS DateTime2), N'{"Category":0,"Keyword":null,"PerPage":15,"Page":1}', 1)
INSERT [dbo].[AuditLogs] ([Id], [UseCaseName], [UserId], [Date], [Data], [IsAuthorized]) VALUES (12, N'Get products with search and server-side pagination.', 0, CAST(N'2022-06-25T20:37:18.8590105' AS DateTime2), N'{"Category":0,"Keyword":null,"PerPage":15,"Page":1}', 1)
INSERT [dbo].[AuditLogs] ([Id], [UseCaseName], [UserId], [Date], [Data], [IsAuthorized]) VALUES (13, N'Get products with search and server-side pagination.', 0, CAST(N'2022-06-25T20:37:19.3746442' AS DateTime2), N'{"Category":0,"Keyword":null,"PerPage":15,"Page":1}', 1)
INSERT [dbo].[AuditLogs] ([Id], [UseCaseName], [UserId], [Date], [Data], [IsAuthorized]) VALUES (14, N'Get products with search and server-side pagination.', 0, CAST(N'2022-06-25T20:37:22.8380991' AS DateTime2), N'{"Category":0,"Keyword":null,"PerPage":15,"Page":1}', 1)
INSERT [dbo].[AuditLogs] ([Id], [UseCaseName], [UserId], [Date], [Data], [IsAuthorized]) VALUES (15, N'Get products with search and server-side pagination.', 0, CAST(N'2022-06-25T20:37:23.8864386' AS DateTime2), N'{"Category":0,"Keyword":null,"PerPage":15,"Page":1}', 1)
INSERT [dbo].[AuditLogs] ([Id], [UseCaseName], [UserId], [Date], [Data], [IsAuthorized]) VALUES (16, N'Get products with search and server-side pagination.', 0, CAST(N'2022-06-25T20:37:24.5963368' AS DateTime2), N'{"Category":0,"Keyword":null,"PerPage":15,"Page":1}', 1)
INSERT [dbo].[AuditLogs] ([Id], [UseCaseName], [UserId], [Date], [Data], [IsAuthorized]) VALUES (17, N'Get products with search and server-side pagination.', 0, CAST(N'2022-06-25T20:37:26.6961058' AS DateTime2), N'{"Category":0,"Keyword":null,"PerPage":15,"Page":1}', 1)
INSERT [dbo].[AuditLogs] ([Id], [UseCaseName], [UserId], [Date], [Data], [IsAuthorized]) VALUES (18, N'Get products with search and server-side pagination.', 0, CAST(N'2022-06-25T20:37:29.6086797' AS DateTime2), N'{"Category":0,"Keyword":null,"PerPage":15,"Page":1}', 1)
INSERT [dbo].[AuditLogs] ([Id], [UseCaseName], [UserId], [Date], [Data], [IsAuthorized]) VALUES (19, N'Get products with search and server-side pagination.', 0, CAST(N'2022-06-25T20:37:30.5468772' AS DateTime2), N'{"Category":0,"Keyword":null,"PerPage":15,"Page":1}', 1)
INSERT [dbo].[AuditLogs] ([Id], [UseCaseName], [UserId], [Date], [Data], [IsAuthorized]) VALUES (20, N'Get products with search and server-side pagination.', 0, CAST(N'2022-06-25T20:37:31.3027181' AS DateTime2), N'{"Category":0,"Keyword":null,"PerPage":15,"Page":1}', 1)
INSERT [dbo].[AuditLogs] ([Id], [UseCaseName], [UserId], [Date], [Data], [IsAuthorized]) VALUES (21, N'Get products with search and server-side pagination.', 0, CAST(N'2022-06-25T20:37:34.0162154' AS DateTime2), N'{"Category":0,"Keyword":null,"PerPage":15,"Page":1}', 1)
INSERT [dbo].[AuditLogs] ([Id], [UseCaseName], [UserId], [Date], [Data], [IsAuthorized]) VALUES (22, N'Get products with search and server-side pagination.', 0, CAST(N'2022-06-25T20:37:34.1063020' AS DateTime2), N'{"Category":0,"Keyword":null,"PerPage":15,"Page":1}', 1)
INSERT [dbo].[AuditLogs] ([Id], [UseCaseName], [UserId], [Date], [Data], [IsAuthorized]) VALUES (23, N'Get products with search and server-side pagination.', 0, CAST(N'2022-06-25T20:37:34.6278997' AS DateTime2), N'{"Category":0,"Keyword":null,"PerPage":15,"Page":1}', 1)
INSERT [dbo].[AuditLogs] ([Id], [UseCaseName], [UserId], [Date], [Data], [IsAuthorized]) VALUES (24, N'Get products with search and server-side pagination.', 0, CAST(N'2022-06-25T20:37:34.7056191' AS DateTime2), N'{"Category":0,"Keyword":null,"PerPage":15,"Page":1}', 1)
INSERT [dbo].[AuditLogs] ([Id], [UseCaseName], [UserId], [Date], [Data], [IsAuthorized]) VALUES (25, N'Get products with search and server-side pagination.', 0, CAST(N'2022-06-25T20:37:37.8383737' AS DateTime2), N'{"Category":0,"Keyword":null,"PerPage":15,"Page":1}', 1)
INSERT [dbo].[AuditLogs] ([Id], [UseCaseName], [UserId], [Date], [Data], [IsAuthorized]) VALUES (26, N'Get products with search and server-side pagination.', 0, CAST(N'2022-06-25T20:40:17.2889983' AS DateTime2), N'{"Category":0,"Keyword":null,"PerPage":15,"Page":1}', 1)
INSERT [dbo].[AuditLogs] ([Id], [UseCaseName], [UserId], [Date], [Data], [IsAuthorized]) VALUES (27, N'Search categories', 0, CAST(N'2022-06-25T20:40:30.2957499' AS DateTime2), N'{"PerPage":15,"Page":1,"Keyword":null}', 1)
INSERT [dbo].[AuditLogs] ([Id], [UseCaseName], [UserId], [Date], [Data], [IsAuthorized]) VALUES (28, N'Get products with search and server-side pagination.', 0, CAST(N'2022-06-25T20:40:30.3305201' AS DateTime2), N'{"Category":0,"Keyword":null,"PerPage":15,"Page":1}', 1)
INSERT [dbo].[AuditLogs] ([Id], [UseCaseName], [UserId], [Date], [Data], [IsAuthorized]) VALUES (29, N'Get products with search and server-side pagination.', 0, CAST(N'2022-06-25T20:40:45.7180161' AS DateTime2), N'{"Category":0,"Keyword":null,"PerPage":15,"Page":1}', 1)
INSERT [dbo].[AuditLogs] ([Id], [UseCaseName], [UserId], [Date], [Data], [IsAuthorized]) VALUES (30, N'Get products with search and server-side pagination.', 0, CAST(N'2022-06-25T20:40:48.4272605' AS DateTime2), N'{"Category":0,"Keyword":null,"PerPage":15,"Page":1}', 1)
INSERT [dbo].[AuditLogs] ([Id], [UseCaseName], [UserId], [Date], [Data], [IsAuthorized]) VALUES (31, N'Get products with search and server-side pagination.', 0, CAST(N'2022-06-25T20:40:50.5420922' AS DateTime2), N'{"Category":0,"Keyword":null,"PerPage":15,"Page":1}', 1)
INSERT [dbo].[AuditLogs] ([Id], [UseCaseName], [UserId], [Date], [Data], [IsAuthorized]) VALUES (32, N'Get products with search and server-side pagination.', 0, CAST(N'2022-06-25T20:40:51.8518594' AS DateTime2), N'{"Category":0,"Keyword":null,"PerPage":15,"Page":1}', 1)
INSERT [dbo].[AuditLogs] ([Id], [UseCaseName], [UserId], [Date], [Data], [IsAuthorized]) VALUES (33, N'Get products with search and server-side pagination.', 0, CAST(N'2022-06-25T20:40:52.2697263' AS DateTime2), N'{"Category":0,"Keyword":null,"PerPage":15,"Page":1}', 1)
INSERT [dbo].[AuditLogs] ([Id], [UseCaseName], [UserId], [Date], [Data], [IsAuthorized]) VALUES (34, N'Get products with search and server-side pagination.', 0, CAST(N'2022-06-25T20:40:52.4236163' AS DateTime2), N'{"Category":0,"Keyword":null,"PerPage":15,"Page":1}', 1)
INSERT [dbo].[AuditLogs] ([Id], [UseCaseName], [UserId], [Date], [Data], [IsAuthorized]) VALUES (35, N'Get products with search and server-side pagination.', 0, CAST(N'2022-06-25T20:40:52.6754540' AS DateTime2), N'{"Category":0,"Keyword":null,"PerPage":15,"Page":1}', 1)
INSERT [dbo].[AuditLogs] ([Id], [UseCaseName], [UserId], [Date], [Data], [IsAuthorized]) VALUES (36, N'Get products with search and server-side pagination.', 0, CAST(N'2022-06-25T20:40:55.0556585' AS DateTime2), N'{"Category":0,"Keyword":null,"PerPage":15,"Page":1}', 1)
INSERT [dbo].[AuditLogs] ([Id], [UseCaseName], [UserId], [Date], [Data], [IsAuthorized]) VALUES (37, N'Get products with search and server-side pagination.', 0, CAST(N'2022-06-25T20:40:57.9133483' AS DateTime2), N'{"Category":0,"Keyword":null,"PerPage":15,"Page":1}', 1)
INSERT [dbo].[AuditLogs] ([Id], [UseCaseName], [UserId], [Date], [Data], [IsAuthorized]) VALUES (38, N'Get products with search and server-side pagination.', 0, CAST(N'2022-06-25T20:40:59.5610398' AS DateTime2), N'{"Category":0,"Keyword":null,"PerPage":15,"Page":1}', 1)
INSERT [dbo].[AuditLogs] ([Id], [UseCaseName], [UserId], [Date], [Data], [IsAuthorized]) VALUES (39, N'Get products with search and server-side pagination.', 0, CAST(N'2022-06-25T20:41:01.3163470' AS DateTime2), N'{"Category":0,"Keyword":null,"PerPage":15,"Page":1}', 1)
INSERT [dbo].[AuditLogs] ([Id], [UseCaseName], [UserId], [Date], [Data], [IsAuthorized]) VALUES (40, N'Get products with search and server-side pagination.', 0, CAST(N'2022-06-25T20:41:06.5814816' AS DateTime2), N'{"Category":0,"Keyword":null,"PerPage":15,"Page":1}', 1)
INSERT [dbo].[AuditLogs] ([Id], [UseCaseName], [UserId], [Date], [Data], [IsAuthorized]) VALUES (41, N'Get products with search and server-side pagination.', 0, CAST(N'2022-06-25T20:41:10.7902544' AS DateTime2), N'{"Category":0,"Keyword":null,"PerPage":15,"Page":1}', 1)
INSERT [dbo].[AuditLogs] ([Id], [UseCaseName], [UserId], [Date], [Data], [IsAuthorized]) VALUES (42, N'Get products with search and server-side pagination.', 0, CAST(N'2022-06-25T20:41:15.3018916' AS DateTime2), N'{"Category":0,"Keyword":null,"PerPage":15,"Page":1}', 1)
INSERT [dbo].[AuditLogs] ([Id], [UseCaseName], [UserId], [Date], [Data], [IsAuthorized]) VALUES (43, N'Get products with search and server-side pagination.', 0, CAST(N'2022-06-25T20:41:16.2415430' AS DateTime2), N'{"Category":0,"Keyword":null,"PerPage":15,"Page":1}', 1)
INSERT [dbo].[AuditLogs] ([Id], [UseCaseName], [UserId], [Date], [Data], [IsAuthorized]) VALUES (44, N'Get products with search and server-side pagination.', 0, CAST(N'2022-06-25T20:41:16.3910826' AS DateTime2), N'{"Category":0,"Keyword":null,"PerPage":15,"Page":1}', 1)
INSERT [dbo].[AuditLogs] ([Id], [UseCaseName], [UserId], [Date], [Data], [IsAuthorized]) VALUES (45, N'Get products with search and server-side pagination.', 0, CAST(N'2022-06-25T20:42:36.0304123' AS DateTime2), N'{"Category":0,"Keyword":null,"PerPage":15,"Page":1}', 1)
INSERT [dbo].[AuditLogs] ([Id], [UseCaseName], [UserId], [Date], [Data], [IsAuthorized]) VALUES (46, N'Search categories', 0, CAST(N'2022-06-25T20:42:36.0308748' AS DateTime2), N'{"PerPage":15,"Page":1,"Keyword":null}', 1)
INSERT [dbo].[AuditLogs] ([Id], [UseCaseName], [UserId], [Date], [Data], [IsAuthorized]) VALUES (47, N'Get products with search and server-side pagination.', 0, CAST(N'2022-06-25T20:42:51.8980876' AS DateTime2), N'{"Category":0,"Keyword":null,"PerPage":15,"Page":1}', 1)
INSERT [dbo].[AuditLogs] ([Id], [UseCaseName], [UserId], [Date], [Data], [IsAuthorized]) VALUES (48, N'Search categories', 0, CAST(N'2022-06-25T20:42:51.9010933' AS DateTime2), N'{"PerPage":15,"Page":1,"Keyword":null}', 1)
INSERT [dbo].[AuditLogs] ([Id], [UseCaseName], [UserId], [Date], [Data], [IsAuthorized]) VALUES (49, N'Get products with search and server-side pagination.', 0, CAST(N'2022-06-25T20:42:55.8715213' AS DateTime2), N'{"Category":0,"Keyword":null,"PerPage":15,"Page":1}', 1)
INSERT [dbo].[AuditLogs] ([Id], [UseCaseName], [UserId], [Date], [Data], [IsAuthorized]) VALUES (50, N'Get products with search and server-side pagination.', 0, CAST(N'2022-06-25T20:42:57.6468950' AS DateTime2), N'{"Category":0,"Keyword":null,"PerPage":15,"Page":1}', 1)
INSERT [dbo].[AuditLogs] ([Id], [UseCaseName], [UserId], [Date], [Data], [IsAuthorized]) VALUES (51, N'Get products with search and server-side pagination.', 0, CAST(N'2022-06-25T20:43:00.3643707' AS DateTime2), N'{"Category":0,"Keyword":null,"PerPage":15,"Page":1}', 1)
INSERT [dbo].[AuditLogs] ([Id], [UseCaseName], [UserId], [Date], [Data], [IsAuthorized]) VALUES (52, N'Get products with search and server-side pagination.', 0, CAST(N'2022-06-25T20:43:00.5888236' AS DateTime2), N'{"Category":0,"Keyword":null,"PerPage":15,"Page":1}', 1)
INSERT [dbo].[AuditLogs] ([Id], [UseCaseName], [UserId], [Date], [Data], [IsAuthorized]) VALUES (53, N'Get products with search and server-side pagination.', 0, CAST(N'2022-06-25T20:43:03.1982081' AS DateTime2), N'{"Category":0,"Keyword":null,"PerPage":15,"Page":1}', 1)
INSERT [dbo].[AuditLogs] ([Id], [UseCaseName], [UserId], [Date], [Data], [IsAuthorized]) VALUES (54, N'Get products with search and server-side pagination.', 0, CAST(N'2022-06-25T20:43:06.5875009' AS DateTime2), N'{"Category":0,"Keyword":null,"PerPage":15,"Page":1}', 1)
INSERT [dbo].[AuditLogs] ([Id], [UseCaseName], [UserId], [Date], [Data], [IsAuthorized]) VALUES (55, N'Get products with search and server-side pagination.', 0, CAST(N'2022-06-25T20:43:07.7492948' AS DateTime2), N'{"Category":0,"Keyword":null,"PerPage":15,"Page":1}', 1)
INSERT [dbo].[AuditLogs] ([Id], [UseCaseName], [UserId], [Date], [Data], [IsAuthorized]) VALUES (56, N'Get products with search and server-side pagination.', 0, CAST(N'2022-06-25T20:43:34.5639547' AS DateTime2), N'{"Category":0,"Keyword":null,"PerPage":15,"Page":1}', 1)
INSERT [dbo].[AuditLogs] ([Id], [UseCaseName], [UserId], [Date], [Data], [IsAuthorized]) VALUES (57, N'Get products with search and server-side pagination.', 0, CAST(N'2022-06-25T20:43:34.7610232' AS DateTime2), N'{"Category":0,"Keyword":null,"PerPage":15,"Page":1}', 1)
INSERT [dbo].[AuditLogs] ([Id], [UseCaseName], [UserId], [Date], [Data], [IsAuthorized]) VALUES (58, N'Get products with search and server-side pagination.', 0, CAST(N'2022-06-25T20:43:40.0218774' AS DateTime2), N'{"Category":0,"Keyword":null,"PerPage":15,"Page":1}', 1)
INSERT [dbo].[AuditLogs] ([Id], [UseCaseName], [UserId], [Date], [Data], [IsAuthorized]) VALUES (59, N'Get products with search and server-side pagination.', 0, CAST(N'2022-06-25T20:43:42.1775718' AS DateTime2), N'{"Category":0,"Keyword":null,"PerPage":15,"Page":1}', 1)
INSERT [dbo].[AuditLogs] ([Id], [UseCaseName], [UserId], [Date], [Data], [IsAuthorized]) VALUES (60, N'Get products with search and server-side pagination.', 0, CAST(N'2022-06-25T20:43:44.8857819' AS DateTime2), N'{"Category":0,"Keyword":null,"PerPage":15,"Page":1}', 1)
INSERT [dbo].[AuditLogs] ([Id], [UseCaseName], [UserId], [Date], [Data], [IsAuthorized]) VALUES (61, N'Get products with search and server-side pagination.', 0, CAST(N'2022-06-25T20:43:46.0368420' AS DateTime2), N'{"Category":0,"Keyword":null,"PerPage":15,"Page":1}', 1)
INSERT [dbo].[AuditLogs] ([Id], [UseCaseName], [UserId], [Date], [Data], [IsAuthorized]) VALUES (62, N'Get products with search and server-side pagination.', 0, CAST(N'2022-06-25T20:43:47.1101560' AS DateTime2), N'{"Category":0,"Keyword":null,"PerPage":15,"Page":1}', 1)
INSERT [dbo].[AuditLogs] ([Id], [UseCaseName], [UserId], [Date], [Data], [IsAuthorized]) VALUES (63, N'Get products with search and server-side pagination.', 0, CAST(N'2022-06-25T20:43:47.3310659' AS DateTime2), N'{"Category":0,"Keyword":null,"PerPage":15,"Page":1}', 1)
INSERT [dbo].[AuditLogs] ([Id], [UseCaseName], [UserId], [Date], [Data], [IsAuthorized]) VALUES (64, N'Get products with search and server-side pagination.', 0, CAST(N'2022-06-25T20:43:48.0102933' AS DateTime2), N'{"Category":0,"Keyword":null,"PerPage":15,"Page":1}', 1)
INSERT [dbo].[AuditLogs] ([Id], [UseCaseName], [UserId], [Date], [Data], [IsAuthorized]) VALUES (65, N'Get products with search and server-side pagination.', 0, CAST(N'2022-06-25T20:43:52.3066947' AS DateTime2), N'{"Category":0,"Keyword":null,"PerPage":15,"Page":1}', 1)
INSERT [dbo].[AuditLogs] ([Id], [UseCaseName], [UserId], [Date], [Data], [IsAuthorized]) VALUES (66, N'Get products with search and server-side pagination.', 0, CAST(N'2022-06-25T20:44:01.0620864' AS DateTime2), N'{"Category":0,"Keyword":null,"PerPage":15,"Page":1}', 1)
INSERT [dbo].[AuditLogs] ([Id], [UseCaseName], [UserId], [Date], [Data], [IsAuthorized]) VALUES (67, N'Get products with search and server-side pagination.', 0, CAST(N'2022-06-25T20:46:28.8175377' AS DateTime2), N'{"Category":0,"Keyword":null,"PerPage":15,"Page":1}', 1)
INSERT [dbo].[AuditLogs] ([Id], [UseCaseName], [UserId], [Date], [Data], [IsAuthorized]) VALUES (68, N'Get products with search and server-side pagination.', 0, CAST(N'2022-06-25T20:46:31.0975733' AS DateTime2), N'{"Category":0,"Keyword":null,"PerPage":15,"Page":1}', 1)
INSERT [dbo].[AuditLogs] ([Id], [UseCaseName], [UserId], [Date], [Data], [IsAuthorized]) VALUES (69, N'Get products with search and server-side pagination.', 0, CAST(N'2022-06-25T20:46:31.2579867' AS DateTime2), N'{"Category":0,"Keyword":null,"PerPage":15,"Page":1}', 1)
INSERT [dbo].[AuditLogs] ([Id], [UseCaseName], [UserId], [Date], [Data], [IsAuthorized]) VALUES (70, N'Get products with search and server-side pagination.', 0, CAST(N'2022-06-25T20:46:31.8121900' AS DateTime2), N'{"Category":0,"Keyword":null,"PerPage":15,"Page":1}', 1)
INSERT [dbo].[AuditLogs] ([Id], [UseCaseName], [UserId], [Date], [Data], [IsAuthorized]) VALUES (71, N'Get products with search and server-side pagination.', 0, CAST(N'2022-06-25T20:46:33.2794274' AS DateTime2), N'{"Category":0,"Keyword":null,"PerPage":15,"Page":1}', 1)
INSERT [dbo].[AuditLogs] ([Id], [UseCaseName], [UserId], [Date], [Data], [IsAuthorized]) VALUES (72, N'Get products with search and server-side pagination.', 0, CAST(N'2022-06-25T20:46:33.5390952' AS DateTime2), N'{"Category":0,"Keyword":null,"PerPage":15,"Page":1}', 1)
INSERT [dbo].[AuditLogs] ([Id], [UseCaseName], [UserId], [Date], [Data], [IsAuthorized]) VALUES (73, N'Get products with search and server-side pagination.', 0, CAST(N'2022-06-25T20:46:33.7702384' AS DateTime2), N'{"Category":0,"Keyword":null,"PerPage":15,"Page":1}', 1)
INSERT [dbo].[AuditLogs] ([Id], [UseCaseName], [UserId], [Date], [Data], [IsAuthorized]) VALUES (74, N'Get products with search and server-side pagination.', 0, CAST(N'2022-06-25T20:46:38.2353052' AS DateTime2), N'{"Category":0,"Keyword":null,"PerPage":15,"Page":1}', 1)
INSERT [dbo].[AuditLogs] ([Id], [UseCaseName], [UserId], [Date], [Data], [IsAuthorized]) VALUES (75, N'Get products with search and server-side pagination.', 0, CAST(N'2022-06-25T20:47:01.8943524' AS DateTime2), N'{"Category":0,"Keyword":null,"PerPage":15,"Page":1}', 1)
INSERT [dbo].[AuditLogs] ([Id], [UseCaseName], [UserId], [Date], [Data], [IsAuthorized]) VALUES (76, N'Search categories', 0, CAST(N'2022-06-25T20:47:01.9032407' AS DateTime2), N'{"PerPage":15,"Page":1,"Keyword":null}', 1)
INSERT [dbo].[AuditLogs] ([Id], [UseCaseName], [UserId], [Date], [Data], [IsAuthorized]) VALUES (77, N'Search categories', 0, CAST(N'2022-06-25T20:48:36.4041335' AS DateTime2), N'{"PerPage":15,"Page":1,"Keyword":null}', 1)
INSERT [dbo].[AuditLogs] ([Id], [UseCaseName], [UserId], [Date], [Data], [IsAuthorized]) VALUES (78, N'Get products with search and server-side pagination.', 0, CAST(N'2022-06-25T20:48:36.4453680' AS DateTime2), N'{"Category":0,"Keyword":null,"PerPage":15,"Page":1}', 1)
INSERT [dbo].[AuditLogs] ([Id], [UseCaseName], [UserId], [Date], [Data], [IsAuthorized]) VALUES (79, N'Search categories', 0, CAST(N'2022-06-25T21:49:55.2472248' AS DateTime2), N'{"Keyword":null,"PerPage":15,"Page":1}', 1)
INSERT [dbo].[AuditLogs] ([Id], [UseCaseName], [UserId], [Date], [Data], [IsAuthorized]) VALUES (80, N'Get products with search and server-side pagination.', 0, CAST(N'2022-06-25T21:49:55.2623458' AS DateTime2), N'{"Category":0,"Keyword":null,"PerPage":15,"Page":1}', 1)
INSERT [dbo].[AuditLogs] ([Id], [UseCaseName], [UserId], [Date], [Data], [IsAuthorized]) VALUES (81, N'Get products with search and server-side pagination.', 0, CAST(N'2022-06-25T21:50:06.2396434' AS DateTime2), N'{"Category":0,"Keyword":null,"PerPage":15,"Page":1}', 1)
INSERT [dbo].[AuditLogs] ([Id], [UseCaseName], [UserId], [Date], [Data], [IsAuthorized]) VALUES (82, N'Search categories', 0, CAST(N'2022-06-25T21:50:06.2377156' AS DateTime2), N'{"Keyword":null,"PerPage":15,"Page":1}', 1)
INSERT [dbo].[AuditLogs] ([Id], [UseCaseName], [UserId], [Date], [Data], [IsAuthorized]) VALUES (83, N'Get products with search and server-side pagination.', 0, CAST(N'2022-06-25T21:50:17.4438685' AS DateTime2), N'{"Category":0,"Keyword":null,"PerPage":15,"Page":1}', 1)
INSERT [dbo].[AuditLogs] ([Id], [UseCaseName], [UserId], [Date], [Data], [IsAuthorized]) VALUES (84, N'Get products with search and server-side pagination.', 0, CAST(N'2022-06-25T21:50:21.4407996' AS DateTime2), N'{"Category":0,"Keyword":null,"PerPage":15,"Page":1}', 1)
INSERT [dbo].[AuditLogs] ([Id], [UseCaseName], [UserId], [Date], [Data], [IsAuthorized]) VALUES (85, N'Get products with search and server-side pagination.', 0, CAST(N'2022-06-25T21:50:22.5489451' AS DateTime2), N'{"Category":0,"Keyword":null,"PerPage":15,"Page":1}', 1)
INSERT [dbo].[AuditLogs] ([Id], [UseCaseName], [UserId], [Date], [Data], [IsAuthorized]) VALUES (86, N'Get products with search and server-side pagination.', 0, CAST(N'2022-06-25T21:50:23.8801540' AS DateTime2), N'{"Category":0,"Keyword":null,"PerPage":15,"Page":1}', 1)
INSERT [dbo].[AuditLogs] ([Id], [UseCaseName], [UserId], [Date], [Data], [IsAuthorized]) VALUES (87, N'Get products with search and server-side pagination.', 0, CAST(N'2022-06-25T21:50:32.4933768' AS DateTime2), N'{"Category":0,"Keyword":null,"PerPage":15,"Page":1}', 1)
INSERT [dbo].[AuditLogs] ([Id], [UseCaseName], [UserId], [Date], [Data], [IsAuthorized]) VALUES (88, N'Get products with search and server-side pagination.', 0, CAST(N'2022-06-25T21:50:35.4407480' AS DateTime2), N'{"Category":0,"Keyword":null,"PerPage":15,"Page":1}', 1)
INSERT [dbo].[AuditLogs] ([Id], [UseCaseName], [UserId], [Date], [Data], [IsAuthorized]) VALUES (89, N'Get products with search and server-side pagination.', 0, CAST(N'2022-06-25T21:50:41.7162833' AS DateTime2), N'{"Category":0,"Keyword":null,"PerPage":15,"Page":1}', 1)
INSERT [dbo].[AuditLogs] ([Id], [UseCaseName], [UserId], [Date], [Data], [IsAuthorized]) VALUES (90, N'Get products with search and server-side pagination.', 0, CAST(N'2022-06-25T21:50:41.8211309' AS DateTime2), N'{"Category":0,"Keyword":null,"PerPage":15,"Page":1}', 1)
INSERT [dbo].[AuditLogs] ([Id], [UseCaseName], [UserId], [Date], [Data], [IsAuthorized]) VALUES (91, N'Get products with search and server-side pagination.', 0, CAST(N'2022-06-25T21:50:43.5616541' AS DateTime2), N'{"Category":0,"Keyword":null,"PerPage":15,"Page":1}', 1)
INSERT [dbo].[AuditLogs] ([Id], [UseCaseName], [UserId], [Date], [Data], [IsAuthorized]) VALUES (92, N'Get products with search and server-side pagination.', 0, CAST(N'2022-06-25T21:50:44.4893367' AS DateTime2), N'{"Category":0,"Keyword":null,"PerPage":15,"Page":1}', 1)
INSERT [dbo].[AuditLogs] ([Id], [UseCaseName], [UserId], [Date], [Data], [IsAuthorized]) VALUES (93, N'Get products with search and server-side pagination.', 0, CAST(N'2022-06-25T21:50:48.2312334' AS DateTime2), N'{"Category":0,"Keyword":null,"PerPage":15,"Page":1}', 1)
INSERT [dbo].[AuditLogs] ([Id], [UseCaseName], [UserId], [Date], [Data], [IsAuthorized]) VALUES (94, N'Get products with search and server-side pagination.', 0, CAST(N'2022-06-25T21:50:51.1812118' AS DateTime2), N'{"Category":0,"Keyword":null,"PerPage":15,"Page":1}', 1)
INSERT [dbo].[AuditLogs] ([Id], [UseCaseName], [UserId], [Date], [Data], [IsAuthorized]) VALUES (95, N'Get products with search and server-side pagination.', 0, CAST(N'2022-06-25T21:50:51.3669210' AS DateTime2), N'{"Category":0,"Keyword":null,"PerPage":15,"Page":1}', 1)
INSERT [dbo].[AuditLogs] ([Id], [UseCaseName], [UserId], [Date], [Data], [IsAuthorized]) VALUES (96, N'Search categories', 0, CAST(N'2022-06-25T21:51:27.2811227' AS DateTime2), N'{"Keyword":null,"PerPage":15,"Page":1}', 1)
INSERT [dbo].[AuditLogs] ([Id], [UseCaseName], [UserId], [Date], [Data], [IsAuthorized]) VALUES (97, N'Get products with search and server-side pagination.', 0, CAST(N'2022-06-25T21:51:27.3123875' AS DateTime2), N'{"Category":0,"Keyword":null,"PerPage":15,"Page":1}', 1)
INSERT [dbo].[AuditLogs] ([Id], [UseCaseName], [UserId], [Date], [Data], [IsAuthorized]) VALUES (98, N'Get products with search and server-side pagination.', 0, CAST(N'2022-06-25T21:51:31.9099320' AS DateTime2), N'{"Category":0,"Keyword":null,"PerPage":15,"Page":1}', 1)
INSERT [dbo].[AuditLogs] ([Id], [UseCaseName], [UserId], [Date], [Data], [IsAuthorized]) VALUES (99, N'Get products with search and server-side pagination.', 0, CAST(N'2022-06-25T21:51:41.7807400' AS DateTime2), N'{"Category":0,"Keyword":null,"PerPage":15,"Page":1}', 1)
GO
INSERT [dbo].[AuditLogs] ([Id], [UseCaseName], [UserId], [Date], [Data], [IsAuthorized]) VALUES (100, N'Get products with search and server-side pagination.', 0, CAST(N'2022-06-25T21:51:41.8547329' AS DateTime2), N'{"Category":0,"Keyword":null,"PerPage":15,"Page":1}', 1)
INSERT [dbo].[AuditLogs] ([Id], [UseCaseName], [UserId], [Date], [Data], [IsAuthorized]) VALUES (101, N'Get products with search and server-side pagination.', 0, CAST(N'2022-06-25T21:58:33.7897769' AS DateTime2), N'{"Category":0,"Keyword":null,"PerPage":15,"Page":1}', 1)
INSERT [dbo].[AuditLogs] ([Id], [UseCaseName], [UserId], [Date], [Data], [IsAuthorized]) VALUES (102, N'Search categories', 0, CAST(N'2022-06-25T21:58:33.7901971' AS DateTime2), N'{"Keyword":null,"PerPage":15,"Page":1}', 1)
INSERT [dbo].[AuditLogs] ([Id], [UseCaseName], [UserId], [Date], [Data], [IsAuthorized]) VALUES (103, N'Get products with search and server-side pagination.', 0, CAST(N'2022-06-25T21:58:38.2060125' AS DateTime2), N'{"Category":0,"Keyword":null,"PerPage":15,"Page":1}', 1)
INSERT [dbo].[AuditLogs] ([Id], [UseCaseName], [UserId], [Date], [Data], [IsAuthorized]) VALUES (104, N'Get products with search and server-side pagination.', 0, CAST(N'2022-06-25T21:58:41.0861331' AS DateTime2), N'{"Category":0,"Keyword":null,"PerPage":15,"Page":1}', 1)
INSERT [dbo].[AuditLogs] ([Id], [UseCaseName], [UserId], [Date], [Data], [IsAuthorized]) VALUES (105, N'Get products with search and server-side pagination.', 0, CAST(N'2022-06-25T21:58:41.2268963' AS DateTime2), N'{"Category":0,"Keyword":null,"PerPage":15,"Page":1}', 1)
INSERT [dbo].[AuditLogs] ([Id], [UseCaseName], [UserId], [Date], [Data], [IsAuthorized]) VALUES (106, N'Get products with search and server-side pagination.', 0, CAST(N'2022-06-25T21:58:43.9170341' AS DateTime2), N'{"Category":0,"Keyword":null,"PerPage":15,"Page":1}', 1)
INSERT [dbo].[AuditLogs] ([Id], [UseCaseName], [UserId], [Date], [Data], [IsAuthorized]) VALUES (107, N'Get products with search and server-side pagination.', 0, CAST(N'2022-06-25T21:58:46.5563724' AS DateTime2), N'{"Category":0,"Keyword":null,"PerPage":15,"Page":1}', 1)
INSERT [dbo].[AuditLogs] ([Id], [UseCaseName], [UserId], [Date], [Data], [IsAuthorized]) VALUES (108, N'Get products with search and server-side pagination.', 0, CAST(N'2022-06-26T06:08:29.5607698' AS DateTime2), N'{"Category":0,"Keyword":null,"PerPage":15,"Page":1}', 1)
INSERT [dbo].[AuditLogs] ([Id], [UseCaseName], [UserId], [Date], [Data], [IsAuthorized]) VALUES (109, N'Get products with search and server-side pagination.', 0, CAST(N'2022-06-26T06:08:36.2412729' AS DateTime2), N'{"Category":0,"Keyword":null,"PerPage":15,"Page":1}', 1)
INSERT [dbo].[AuditLogs] ([Id], [UseCaseName], [UserId], [Date], [Data], [IsAuthorized]) VALUES (110, N'Get products with search and server-side pagination.', 0, CAST(N'2022-06-26T06:08:37.4490290' AS DateTime2), N'{"Category":0,"Keyword":null,"PerPage":15,"Page":1}', 1)
INSERT [dbo].[AuditLogs] ([Id], [UseCaseName], [UserId], [Date], [Data], [IsAuthorized]) VALUES (111, N'Get products with search and server-side pagination.', 0, CAST(N'2022-06-26T06:08:41.0790303' AS DateTime2), N'{"Category":0,"Keyword":null,"PerPage":15,"Page":1}', 1)
INSERT [dbo].[AuditLogs] ([Id], [UseCaseName], [UserId], [Date], [Data], [IsAuthorized]) VALUES (112, N'Get products with search and server-side pagination.', 0, CAST(N'2022-06-26T06:08:45.9539098' AS DateTime2), N'{"Category":0,"Keyword":null,"PerPage":15,"Page":1}', 1)
INSERT [dbo].[AuditLogs] ([Id], [UseCaseName], [UserId], [Date], [Data], [IsAuthorized]) VALUES (113, N'Get products with search and server-side pagination.', 0, CAST(N'2022-06-26T06:08:46.0817747' AS DateTime2), N'{"Category":0,"Keyword":null,"PerPage":15,"Page":1}', 1)
INSERT [dbo].[AuditLogs] ([Id], [UseCaseName], [UserId], [Date], [Data], [IsAuthorized]) VALUES (114, N'Get products with search and server-side pagination.', 0, CAST(N'2022-06-26T06:08:50.9923943' AS DateTime2), N'{"Category":0,"Keyword":null,"PerPage":15,"Page":1}', 1)
INSERT [dbo].[AuditLogs] ([Id], [UseCaseName], [UserId], [Date], [Data], [IsAuthorized]) VALUES (115, N'Get products with search and server-side pagination.', 0, CAST(N'2022-06-26T06:08:51.1844210' AS DateTime2), N'{"Category":0,"Keyword":null,"PerPage":15,"Page":1}', 1)
INSERT [dbo].[AuditLogs] ([Id], [UseCaseName], [UserId], [Date], [Data], [IsAuthorized]) VALUES (116, N'Get products with search and server-side pagination.', 0, CAST(N'2022-06-26T06:08:51.3791746' AS DateTime2), N'{"Category":0,"Keyword":null,"PerPage":15,"Page":1}', 1)
INSERT [dbo].[AuditLogs] ([Id], [UseCaseName], [UserId], [Date], [Data], [IsAuthorized]) VALUES (117, N'Get products with search and server-side pagination.', 0, CAST(N'2022-06-26T06:08:54.3954583' AS DateTime2), N'{"Category":0,"Keyword":null,"PerPage":15,"Page":1}', 1)
INSERT [dbo].[AuditLogs] ([Id], [UseCaseName], [UserId], [Date], [Data], [IsAuthorized]) VALUES (118, N'Get products with search and server-side pagination.', 0, CAST(N'2022-06-26T06:08:54.4790432' AS DateTime2), N'{"Category":0,"Keyword":null,"PerPage":15,"Page":1}', 1)
INSERT [dbo].[AuditLogs] ([Id], [UseCaseName], [UserId], [Date], [Data], [IsAuthorized]) VALUES (119, N'Get products with search and server-side pagination.', 0, CAST(N'2022-06-26T06:08:54.5073661' AS DateTime2), N'{"Category":0,"Keyword":null,"PerPage":15,"Page":1}', 1)
INSERT [dbo].[AuditLogs] ([Id], [UseCaseName], [UserId], [Date], [Data], [IsAuthorized]) VALUES (120, N'Get products with search and server-side pagination.', 0, CAST(N'2022-06-26T06:09:04.3893572' AS DateTime2), N'{"Category":0,"Keyword":null,"PerPage":15,"Page":1}', 1)
INSERT [dbo].[AuditLogs] ([Id], [UseCaseName], [UserId], [Date], [Data], [IsAuthorized]) VALUES (121, N'Get products with search and server-side pagination.', 0, CAST(N'2022-06-26T06:09:04.4874595' AS DateTime2), N'{"Category":0,"Keyword":null,"PerPage":15,"Page":1}', 1)
INSERT [dbo].[AuditLogs] ([Id], [UseCaseName], [UserId], [Date], [Data], [IsAuthorized]) VALUES (122, N'Get products with search and server-side pagination.', 0, CAST(N'2022-06-26T06:09:06.8872134' AS DateTime2), N'{"Category":0,"Keyword":null,"PerPage":15,"Page":1}', 1)
INSERT [dbo].[AuditLogs] ([Id], [UseCaseName], [UserId], [Date], [Data], [IsAuthorized]) VALUES (123, N'Get products with search and server-side pagination.', 0, CAST(N'2022-06-26T06:12:22.7813570' AS DateTime2), N'{"Category":0,"Keyword":null,"PerPage":15,"Page":1}', 1)
INSERT [dbo].[AuditLogs] ([Id], [UseCaseName], [UserId], [Date], [Data], [IsAuthorized]) VALUES (124, N'Search categories', 0, CAST(N'2022-06-26T06:15:42.6424652' AS DateTime2), N'{"Keyword":null,"PerPage":15,"Page":1}', 1)
INSERT [dbo].[AuditLogs] ([Id], [UseCaseName], [UserId], [Date], [Data], [IsAuthorized]) VALUES (125, N'Get products with search and server-side pagination.', 0, CAST(N'2022-06-26T06:15:42.6424303' AS DateTime2), N'{"Category":0,"Keyword":null,"PerPage":15,"Page":1}', 1)
INSERT [dbo].[AuditLogs] ([Id], [UseCaseName], [UserId], [Date], [Data], [IsAuthorized]) VALUES (126, N'Get products with search and server-side pagination.', 0, CAST(N'2022-06-26T06:16:49.7849002' AS DateTime2), N'{"Category":0,"Keyword":null,"PerPage":15,"Page":1}', 1)
INSERT [dbo].[AuditLogs] ([Id], [UseCaseName], [UserId], [Date], [Data], [IsAuthorized]) VALUES (127, N'Search categories', 0, CAST(N'2022-06-26T06:16:49.7848993' AS DateTime2), N'{"Keyword":null,"PerPage":15,"Page":1}', 1)
INSERT [dbo].[AuditLogs] ([Id], [UseCaseName], [UserId], [Date], [Data], [IsAuthorized]) VALUES (128, N'Get products with search and server-side pagination.', 0, CAST(N'2022-06-26T06:17:19.3366534' AS DateTime2), N'{"Category":0,"Keyword":null,"PerPage":15,"Page":1}', 1)
INSERT [dbo].[AuditLogs] ([Id], [UseCaseName], [UserId], [Date], [Data], [IsAuthorized]) VALUES (129, N'Search categories', 0, CAST(N'2022-06-26T06:17:19.3405550' AS DateTime2), N'{"Keyword":null,"PerPage":15,"Page":1}', 1)
INSERT [dbo].[AuditLogs] ([Id], [UseCaseName], [UserId], [Date], [Data], [IsAuthorized]) VALUES (130, N'Get products with search and server-side pagination.', 0, CAST(N'2022-06-26T06:17:22.6074988' AS DateTime2), N'{"Category":0,"Keyword":null,"PerPage":15,"Page":1}', 1)
INSERT [dbo].[AuditLogs] ([Id], [UseCaseName], [UserId], [Date], [Data], [IsAuthorized]) VALUES (131, N'Get products with search and server-side pagination.', 0, CAST(N'2022-06-26T06:17:24.7108920' AS DateTime2), N'{"Category":0,"Keyword":null,"PerPage":15,"Page":1}', 1)
INSERT [dbo].[AuditLogs] ([Id], [UseCaseName], [UserId], [Date], [Data], [IsAuthorized]) VALUES (132, N'Get products with search and server-side pagination.', 0, CAST(N'2022-06-26T06:17:25.7228046' AS DateTime2), N'{"Category":0,"Keyword":null,"PerPage":15,"Page":1}', 1)
INSERT [dbo].[AuditLogs] ([Id], [UseCaseName], [UserId], [Date], [Data], [IsAuthorized]) VALUES (133, N'Get products with search and server-side pagination.', 0, CAST(N'2022-06-26T06:17:26.4732916' AS DateTime2), N'{"Category":0,"Keyword":null,"PerPage":15,"Page":1}', 1)
INSERT [dbo].[AuditLogs] ([Id], [UseCaseName], [UserId], [Date], [Data], [IsAuthorized]) VALUES (134, N'Get products with search and server-side pagination.', 0, CAST(N'2022-06-26T06:17:27.1644708' AS DateTime2), N'{"Category":0,"Keyword":null,"PerPage":15,"Page":1}', 1)
INSERT [dbo].[AuditLogs] ([Id], [UseCaseName], [UserId], [Date], [Data], [IsAuthorized]) VALUES (135, N'Get products with search and server-side pagination.', 0, CAST(N'2022-06-26T06:17:57.0475114' AS DateTime2), N'{"Category":0,"Keyword":null,"PerPage":15,"Page":1}', 1)
INSERT [dbo].[AuditLogs] ([Id], [UseCaseName], [UserId], [Date], [Data], [IsAuthorized]) VALUES (136, N'Search categories', 0, CAST(N'2022-06-26T06:17:57.0635883' AS DateTime2), N'{"Keyword":null,"PerPage":15,"Page":1}', 1)
INSERT [dbo].[AuditLogs] ([Id], [UseCaseName], [UserId], [Date], [Data], [IsAuthorized]) VALUES (137, N'Get products with search and server-side pagination.', 0, CAST(N'2022-06-26T06:18:09.0729301' AS DateTime2), N'{"Category":0,"Keyword":null,"PerPage":15,"Page":1}', 1)
INSERT [dbo].[AuditLogs] ([Id], [UseCaseName], [UserId], [Date], [Data], [IsAuthorized]) VALUES (138, N'Get products with search and server-side pagination.', 0, CAST(N'2022-06-26T06:18:16.0560640' AS DateTime2), N'{"Category":0,"Keyword":null,"PerPage":15,"Page":1}', 1)
INSERT [dbo].[AuditLogs] ([Id], [UseCaseName], [UserId], [Date], [Data], [IsAuthorized]) VALUES (139, N'Get products with search and server-side pagination.', 0, CAST(N'2022-06-26T06:18:16.2837160' AS DateTime2), N'{"Category":0,"Keyword":null,"PerPage":15,"Page":1}', 1)
INSERT [dbo].[AuditLogs] ([Id], [UseCaseName], [UserId], [Date], [Data], [IsAuthorized]) VALUES (140, N'Get products with search and server-side pagination.', 0, CAST(N'2022-06-26T06:18:17.3689216' AS DateTime2), N'{"Category":0,"Keyword":null,"PerPage":15,"Page":1}', 1)
INSERT [dbo].[AuditLogs] ([Id], [UseCaseName], [UserId], [Date], [Data], [IsAuthorized]) VALUES (141, N'Get products with search and server-side pagination.', 0, CAST(N'2022-06-26T06:18:17.4544774' AS DateTime2), N'{"Category":0,"Keyword":null,"PerPage":15,"Page":1}', 1)
INSERT [dbo].[AuditLogs] ([Id], [UseCaseName], [UserId], [Date], [Data], [IsAuthorized]) VALUES (142, N'Get products with search and server-side pagination.', 0, CAST(N'2022-06-26T06:18:18.2304691' AS DateTime2), N'{"Category":0,"Keyword":null,"PerPage":15,"Page":1}', 1)
INSERT [dbo].[AuditLogs] ([Id], [UseCaseName], [UserId], [Date], [Data], [IsAuthorized]) VALUES (143, N'Get products with search and server-side pagination.', 0, CAST(N'2022-06-26T06:18:18.2803456' AS DateTime2), N'{"Category":0,"Keyword":null,"PerPage":15,"Page":1}', 1)
INSERT [dbo].[AuditLogs] ([Id], [UseCaseName], [UserId], [Date], [Data], [IsAuthorized]) VALUES (144, N'Get products with search and server-side pagination.', 0, CAST(N'2022-06-26T06:18:18.7033829' AS DateTime2), N'{"Category":0,"Keyword":null,"PerPage":15,"Page":1}', 1)
INSERT [dbo].[AuditLogs] ([Id], [UseCaseName], [UserId], [Date], [Data], [IsAuthorized]) VALUES (145, N'Get products with search and server-side pagination.', 0, CAST(N'2022-06-26T06:18:18.8403391' AS DateTime2), N'{"Category":0,"Keyword":null,"PerPage":15,"Page":1}', 1)
INSERT [dbo].[AuditLogs] ([Id], [UseCaseName], [UserId], [Date], [Data], [IsAuthorized]) VALUES (146, N'Get products with search and server-side pagination.', 0, CAST(N'2022-06-26T06:18:19.0121300' AS DateTime2), N'{"Category":0,"Keyword":null,"PerPage":15,"Page":1}', 1)
INSERT [dbo].[AuditLogs] ([Id], [UseCaseName], [UserId], [Date], [Data], [IsAuthorized]) VALUES (147, N'Get products with search and server-side pagination.', 0, CAST(N'2022-06-26T06:18:19.1680309' AS DateTime2), N'{"Category":0,"Keyword":null,"PerPage":15,"Page":1}', 1)
INSERT [dbo].[AuditLogs] ([Id], [UseCaseName], [UserId], [Date], [Data], [IsAuthorized]) VALUES (148, N'Get products with search and server-side pagination.', 0, CAST(N'2022-06-26T06:18:19.3057570' AS DateTime2), N'{"Category":0,"Keyword":null,"PerPage":15,"Page":1}', 1)
INSERT [dbo].[AuditLogs] ([Id], [UseCaseName], [UserId], [Date], [Data], [IsAuthorized]) VALUES (149, N'Get products with search and server-side pagination.', 0, CAST(N'2022-06-26T06:18:19.6706116' AS DateTime2), N'{"Category":0,"Keyword":null,"PerPage":15,"Page":1}', 1)
INSERT [dbo].[AuditLogs] ([Id], [UseCaseName], [UserId], [Date], [Data], [IsAuthorized]) VALUES (150, N'Get products with search and server-side pagination.', 0, CAST(N'2022-06-26T06:18:20.1045890' AS DateTime2), N'{"Category":0,"Keyword":null,"PerPage":15,"Page":1}', 1)
INSERT [dbo].[AuditLogs] ([Id], [UseCaseName], [UserId], [Date], [Data], [IsAuthorized]) VALUES (151, N'Get products with search and server-side pagination.', 0, CAST(N'2022-06-26T06:18:20.1498462' AS DateTime2), N'{"Category":0,"Keyword":null,"PerPage":15,"Page":1}', 1)
INSERT [dbo].[AuditLogs] ([Id], [UseCaseName], [UserId], [Date], [Data], [IsAuthorized]) VALUES (152, N'Get products with search and server-side pagination.', 0, CAST(N'2022-06-26T06:18:21.0446290' AS DateTime2), N'{"Category":0,"Keyword":null,"PerPage":15,"Page":1}', 1)
INSERT [dbo].[AuditLogs] ([Id], [UseCaseName], [UserId], [Date], [Data], [IsAuthorized]) VALUES (153, N'Get products with search and server-side pagination.', 0, CAST(N'2022-06-26T06:18:21.2571383' AS DateTime2), N'{"Category":0,"Keyword":null,"PerPage":15,"Page":1}', 1)
INSERT [dbo].[AuditLogs] ([Id], [UseCaseName], [UserId], [Date], [Data], [IsAuthorized]) VALUES (154, N'Get products with search and server-side pagination.', 0, CAST(N'2022-06-26T06:18:22.2632969' AS DateTime2), N'{"Category":0,"Keyword":null,"PerPage":15,"Page":1}', 1)
INSERT [dbo].[AuditLogs] ([Id], [UseCaseName], [UserId], [Date], [Data], [IsAuthorized]) VALUES (155, N'Get products with search and server-side pagination.', 0, CAST(N'2022-06-26T06:18:22.4528011' AS DateTime2), N'{"Category":0,"Keyword":null,"PerPage":15,"Page":1}', 1)
INSERT [dbo].[AuditLogs] ([Id], [UseCaseName], [UserId], [Date], [Data], [IsAuthorized]) VALUES (156, N'Get products with search and server-side pagination.', 0, CAST(N'2022-06-26T06:18:22.6309145' AS DateTime2), N'{"Category":0,"Keyword":null,"PerPage":15,"Page":1}', 1)
INSERT [dbo].[AuditLogs] ([Id], [UseCaseName], [UserId], [Date], [Data], [IsAuthorized]) VALUES (157, N'Get products with search and server-side pagination.', 0, CAST(N'2022-06-26T06:18:22.8610742' AS DateTime2), N'{"Category":0,"Keyword":null,"PerPage":15,"Page":1}', 1)
INSERT [dbo].[AuditLogs] ([Id], [UseCaseName], [UserId], [Date], [Data], [IsAuthorized]) VALUES (158, N'Get products with search and server-side pagination.', 0, CAST(N'2022-06-26T06:18:23.9404672' AS DateTime2), N'{"Category":0,"Keyword":null,"PerPage":15,"Page":1}', 1)
INSERT [dbo].[AuditLogs] ([Id], [UseCaseName], [UserId], [Date], [Data], [IsAuthorized]) VALUES (159, N'Get products with search and server-side pagination.', 0, CAST(N'2022-06-26T06:18:24.3890796' AS DateTime2), N'{"Category":0,"Keyword":null,"PerPage":15,"Page":1}', 1)
INSERT [dbo].[AuditLogs] ([Id], [UseCaseName], [UserId], [Date], [Data], [IsAuthorized]) VALUES (160, N'Get products with search and server-side pagination.', 0, CAST(N'2022-06-26T06:18:24.4375678' AS DateTime2), N'{"Category":0,"Keyword":null,"PerPage":15,"Page":1}', 1)
INSERT [dbo].[AuditLogs] ([Id], [UseCaseName], [UserId], [Date], [Data], [IsAuthorized]) VALUES (161, N'Get products with search and server-side pagination.', 0, CAST(N'2022-06-26T06:18:25.7679916' AS DateTime2), N'{"Category":0,"Keyword":null,"PerPage":15,"Page":1}', 1)
INSERT [dbo].[AuditLogs] ([Id], [UseCaseName], [UserId], [Date], [Data], [IsAuthorized]) VALUES (162, N'Get products with search and server-side pagination.', 0, CAST(N'2022-06-26T06:18:25.9492836' AS DateTime2), N'{"Category":0,"Keyword":null,"PerPage":15,"Page":1}', 1)
INSERT [dbo].[AuditLogs] ([Id], [UseCaseName], [UserId], [Date], [Data], [IsAuthorized]) VALUES (163, N'Get products with search and server-side pagination.', 0, CAST(N'2022-06-26T06:18:26.1253433' AS DateTime2), N'{"Category":0,"Keyword":null,"PerPage":15,"Page":1}', 1)
INSERT [dbo].[AuditLogs] ([Id], [UseCaseName], [UserId], [Date], [Data], [IsAuthorized]) VALUES (164, N'Get products with search and server-side pagination.', 0, CAST(N'2022-06-26T06:18:30.1017943' AS DateTime2), N'{"Category":0,"Keyword":null,"PerPage":15,"Page":1}', 1)
INSERT [dbo].[AuditLogs] ([Id], [UseCaseName], [UserId], [Date], [Data], [IsAuthorized]) VALUES (165, N'Get products with search and server-side pagination.', 0, CAST(N'2022-06-26T06:18:34.1136842' AS DateTime2), N'{"Category":0,"Keyword":null,"PerPage":15,"Page":1}', 1)
INSERT [dbo].[AuditLogs] ([Id], [UseCaseName], [UserId], [Date], [Data], [IsAuthorized]) VALUES (166, N'Get products with search and server-side pagination.', 0, CAST(N'2022-06-26T06:18:37.0049689' AS DateTime2), N'{"Category":0,"Keyword":null,"PerPage":15,"Page":1}', 1)
INSERT [dbo].[AuditLogs] ([Id], [UseCaseName], [UserId], [Date], [Data], [IsAuthorized]) VALUES (167, N'Get products with search and server-side pagination.', 0, CAST(N'2022-06-26T06:18:37.2030403' AS DateTime2), N'{"Category":0,"Keyword":null,"PerPage":15,"Page":1}', 1)
INSERT [dbo].[AuditLogs] ([Id], [UseCaseName], [UserId], [Date], [Data], [IsAuthorized]) VALUES (168, N'Get products with search and server-side pagination.', 0, CAST(N'2022-06-26T06:18:37.3598995' AS DateTime2), N'{"Category":0,"Keyword":null,"PerPage":15,"Page":1}', 1)
INSERT [dbo].[AuditLogs] ([Id], [UseCaseName], [UserId], [Date], [Data], [IsAuthorized]) VALUES (169, N'Get products with search and server-side pagination.', 0, CAST(N'2022-06-26T06:18:37.7033718' AS DateTime2), N'{"Category":0,"Keyword":null,"PerPage":15,"Page":1}', 1)
INSERT [dbo].[AuditLogs] ([Id], [UseCaseName], [UserId], [Date], [Data], [IsAuthorized]) VALUES (170, N'Get products with search and server-side pagination.', 0, CAST(N'2022-06-26T06:18:38.2053113' AS DateTime2), N'{"Category":0,"Keyword":null,"PerPage":15,"Page":1}', 1)
INSERT [dbo].[AuditLogs] ([Id], [UseCaseName], [UserId], [Date], [Data], [IsAuthorized]) VALUES (171, N'Get products with search and server-side pagination.', 0, CAST(N'2022-06-26T06:18:38.7967504' AS DateTime2), N'{"Category":0,"Keyword":null,"PerPage":15,"Page":1}', 1)
INSERT [dbo].[AuditLogs] ([Id], [UseCaseName], [UserId], [Date], [Data], [IsAuthorized]) VALUES (172, N'Get products with search and server-side pagination.', 0, CAST(N'2022-06-26T06:18:38.9403579' AS DateTime2), N'{"Category":0,"Keyword":null,"PerPage":15,"Page":1}', 1)
INSERT [dbo].[AuditLogs] ([Id], [UseCaseName], [UserId], [Date], [Data], [IsAuthorized]) VALUES (173, N'Get products with search and server-side pagination.', 0, CAST(N'2022-06-26T06:18:39.0890227' AS DateTime2), N'{"Category":0,"Keyword":null,"PerPage":15,"Page":1}', 1)
INSERT [dbo].[AuditLogs] ([Id], [UseCaseName], [UserId], [Date], [Data], [IsAuthorized]) VALUES (174, N'Get products with search and server-side pagination.', 0, CAST(N'2022-06-26T06:18:39.2277835' AS DateTime2), N'{"Category":0,"Keyword":null,"PerPage":15,"Page":1}', 1)
INSERT [dbo].[AuditLogs] ([Id], [UseCaseName], [UserId], [Date], [Data], [IsAuthorized]) VALUES (175, N'Get products with search and server-side pagination.', 0, CAST(N'2022-06-26T06:18:39.3652915' AS DateTime2), N'{"Category":0,"Keyword":null,"PerPage":15,"Page":1}', 1)
INSERT [dbo].[AuditLogs] ([Id], [UseCaseName], [UserId], [Date], [Data], [IsAuthorized]) VALUES (176, N'Get products with search and server-side pagination.', 0, CAST(N'2022-06-26T06:21:43.1718813' AS DateTime2), N'{"Category":0,"Keyword":null,"PerPage":15,"Page":1}', 1)
INSERT [dbo].[AuditLogs] ([Id], [UseCaseName], [UserId], [Date], [Data], [IsAuthorized]) VALUES (177, N'Search categories', 0, CAST(N'2022-06-26T06:21:43.1715930' AS DateTime2), N'{"Keyword":null,"PerPage":15,"Page":1}', 1)
INSERT [dbo].[AuditLogs] ([Id], [UseCaseName], [UserId], [Date], [Data], [IsAuthorized]) VALUES (178, N'Get products with search and server-side pagination.', 0, CAST(N'2022-06-26T06:35:54.7051569' AS DateTime2), N'{"Category":0,"Keyword":null,"PerPage":15,"Page":1}', 1)
INSERT [dbo].[AuditLogs] ([Id], [UseCaseName], [UserId], [Date], [Data], [IsAuthorized]) VALUES (179, N'Search categories', 0, CAST(N'2022-06-26T06:35:54.7050685' AS DateTime2), N'{"Keyword":null,"PerPage":15,"Page":1}', 1)
INSERT [dbo].[AuditLogs] ([Id], [UseCaseName], [UserId], [Date], [Data], [IsAuthorized]) VALUES (180, N'Find product by id', 0, CAST(N'2022-06-26T06:37:46.3050861' AS DateTime2), N'8', 1)
INSERT [dbo].[AuditLogs] ([Id], [UseCaseName], [UserId], [Date], [Data], [IsAuthorized]) VALUES (181, N'Get products with search and server-side pagination.', 0, CAST(N'2022-06-26T06:39:25.7860727' AS DateTime2), N'{"Category":0,"Keyword":null,"PerPage":15,"Page":1}', 1)
INSERT [dbo].[AuditLogs] ([Id], [UseCaseName], [UserId], [Date], [Data], [IsAuthorized]) VALUES (182, N'Search categories', 0, CAST(N'2022-06-26T06:39:25.7840477' AS DateTime2), N'{"Keyword":null,"PerPage":15,"Page":1}', 1)
INSERT [dbo].[AuditLogs] ([Id], [UseCaseName], [UserId], [Date], [Data], [IsAuthorized]) VALUES (183, N'Get products with search and server-side pagination.', 0, CAST(N'2022-06-26T06:43:35.4572228' AS DateTime2), N'{"Category":0,"Keyword":null,"PerPage":15,"Page":1}', 1)
INSERT [dbo].[AuditLogs] ([Id], [UseCaseName], [UserId], [Date], [Data], [IsAuthorized]) VALUES (184, N'Search categories', 0, CAST(N'2022-06-26T06:43:35.4600886' AS DateTime2), N'{"Keyword":null,"PerPage":15,"Page":1}', 1)
INSERT [dbo].[AuditLogs] ([Id], [UseCaseName], [UserId], [Date], [Data], [IsAuthorized]) VALUES (185, N'Get user''s cart items', 6, CAST(N'2022-06-26T06:43:58.9167608' AS DateTime2), N'6', 1)
INSERT [dbo].[AuditLogs] ([Id], [UseCaseName], [UserId], [Date], [Data], [IsAuthorized]) VALUES (186, N'Get products with search and server-side pagination.', 6, CAST(N'2022-06-26T06:43:59.7324090' AS DateTime2), N'{"Category":0,"Keyword":null,"PerPage":15,"Page":1}', 1)
INSERT [dbo].[AuditLogs] ([Id], [UseCaseName], [UserId], [Date], [Data], [IsAuthorized]) VALUES (187, N'Search categories', 6, CAST(N'2022-06-26T06:43:59.7334956' AS DateTime2), N'{"Keyword":null,"PerPage":15,"Page":1}', 1)
INSERT [dbo].[AuditLogs] ([Id], [UseCaseName], [UserId], [Date], [Data], [IsAuthorized]) VALUES (188, N'Find product by id', 6, CAST(N'2022-06-26T06:44:00.8624794' AS DateTime2), N'1', 1)
INSERT [dbo].[AuditLogs] ([Id], [UseCaseName], [UserId], [Date], [Data], [IsAuthorized]) VALUES (189, N'Add product to users cart', 6, CAST(N'2022-06-26T06:44:03.2196417' AS DateTime2), N'{"ProductId":1,"UserId":0,"Quantity":1}', 1)
INSERT [dbo].[AuditLogs] ([Id], [UseCaseName], [UserId], [Date], [Data], [IsAuthorized]) VALUES (190, N'Get user''s cart items', 6, CAST(N'2022-06-26T06:44:03.4550526' AS DateTime2), N'6', 1)
INSERT [dbo].[AuditLogs] ([Id], [UseCaseName], [UserId], [Date], [Data], [IsAuthorized]) VALUES (191, N'Search categories', 6, CAST(N'2022-06-26T06:44:06.0391438' AS DateTime2), N'{"Keyword":null,"PerPage":15,"Page":1}', 1)
INSERT [dbo].[AuditLogs] ([Id], [UseCaseName], [UserId], [Date], [Data], [IsAuthorized]) VALUES (192, N'Get products with search and server-side pagination.', 6, CAST(N'2022-06-26T06:44:06.0390547' AS DateTime2), N'{"Category":0,"Keyword":null,"PerPage":15,"Page":1}', 1)
INSERT [dbo].[AuditLogs] ([Id], [UseCaseName], [UserId], [Date], [Data], [IsAuthorized]) VALUES (193, N'Find product by id', 6, CAST(N'2022-06-26T06:44:08.5154534' AS DateTime2), N'9', 1)
INSERT [dbo].[AuditLogs] ([Id], [UseCaseName], [UserId], [Date], [Data], [IsAuthorized]) VALUES (194, N'Add product to users cart', 6, CAST(N'2022-06-26T06:44:10.6498016' AS DateTime2), N'{"ProductId":9,"UserId":0,"Quantity":3}', 1)
INSERT [dbo].[AuditLogs] ([Id], [UseCaseName], [UserId], [Date], [Data], [IsAuthorized]) VALUES (195, N'Get user''s cart items', 6, CAST(N'2022-06-26T06:44:10.6929442' AS DateTime2), N'6', 1)
INSERT [dbo].[AuditLogs] ([Id], [UseCaseName], [UserId], [Date], [Data], [IsAuthorized]) VALUES (196, N'Search orders by date with server-side pagination', 6, CAST(N'2022-06-26T06:47:21.8122615' AS DateTime2), N'{"date":"0001-01-01T00:00:00","PerPage":15,"Page":1}', 1)
INSERT [dbo].[AuditLogs] ([Id], [UseCaseName], [UserId], [Date], [Data], [IsAuthorized]) VALUES (197, N'Find user by Id', 6, CAST(N'2022-06-26T06:47:47.7320097' AS DateTime2), N'6', 1)
INSERT [dbo].[AuditLogs] ([Id], [UseCaseName], [UserId], [Date], [Data], [IsAuthorized]) VALUES (198, N'Get user''s cart items', 6, CAST(N'2022-06-26T06:49:58.5323415' AS DateTime2), N'6', 1)
INSERT [dbo].[AuditLogs] ([Id], [UseCaseName], [UserId], [Date], [Data], [IsAuthorized]) VALUES (199, N'Remove one item from users cart', 6, CAST(N'2022-06-26T06:50:01.6841124' AS DateTime2), N'4', 1)
GO
INSERT [dbo].[AuditLogs] ([Id], [UseCaseName], [UserId], [Date], [Data], [IsAuthorized]) VALUES (200, N'Get user''s cart items', 6, CAST(N'2022-06-26T06:50:01.8330306' AS DateTime2), N'6', 1)
INSERT [dbo].[AuditLogs] ([Id], [UseCaseName], [UserId], [Date], [Data], [IsAuthorized]) VALUES (201, N'Search orders by date with server-side pagination', 6, CAST(N'2022-06-26T06:50:04.8941654' AS DateTime2), N'{"date":"0001-01-01T00:00:00","PerPage":15,"Page":1}', 1)
SET IDENTITY_INSERT [dbo].[AuditLogs] OFF
GO
SET IDENTITY_INSERT [dbo].[Carts] ON 

INSERT [dbo].[Carts] ([Id], [UserId], [ProductId], [Quantity], [IsActive], [CreatedAt], [UpdatedAt], [DeletedAt]) VALUES (1, 6, 3, 3, 0, CAST(N'2022-06-25T22:35:46.3689486' AS DateTime2), NULL, NULL)
INSERT [dbo].[Carts] ([Id], [UserId], [ProductId], [Quantity], [IsActive], [CreatedAt], [UpdatedAt], [DeletedAt]) VALUES (2, 6, 5, 6, 0, CAST(N'2022-06-25T22:35:46.3689596' AS DateTime2), NULL, NULL)
INSERT [dbo].[Carts] ([Id], [UserId], [ProductId], [Quantity], [IsActive], [CreatedAt], [UpdatedAt], [DeletedAt]) VALUES (3, 6, 1, 1, 1, CAST(N'2022-06-26T06:44:03.3052612' AS DateTime2), NULL, NULL)
INSERT [dbo].[Carts] ([Id], [UserId], [ProductId], [Quantity], [IsActive], [CreatedAt], [UpdatedAt], [DeletedAt]) VALUES (4, 6, 9, 3, 0, CAST(N'2022-06-26T06:44:10.6634186' AS DateTime2), NULL, CAST(N'2022-06-26T06:50:01.7462552' AS DateTime2))
SET IDENTITY_INSERT [dbo].[Carts] OFF
GO
SET IDENTITY_INSERT [dbo].[Categories] ON 

INSERT [dbo].[Categories] ([Id], [CategoryName], [ParentCategoryId], [IsActive], [CreatedAt], [UpdatedAt], [DeletedAt]) VALUES (1, N'Table', NULL, 1, CAST(N'2022-06-25T22:35:46.3643012' AS DateTime2), NULL, NULL)
INSERT [dbo].[Categories] ([Id], [CategoryName], [ParentCategoryId], [IsActive], [CreatedAt], [UpdatedAt], [DeletedAt]) VALUES (2, N'Bed', NULL, 1, CAST(N'2022-06-25T22:35:46.3645735' AS DateTime2), NULL, NULL)
INSERT [dbo].[Categories] ([Id], [CategoryName], [ParentCategoryId], [IsActive], [CreatedAt], [UpdatedAt], [DeletedAt]) VALUES (3, N'Chair', NULL, 1, CAST(N'2022-06-25T22:35:46.3645785' AS DateTime2), NULL, NULL)
INSERT [dbo].[Categories] ([Id], [CategoryName], [ParentCategoryId], [IsActive], [CreatedAt], [UpdatedAt], [DeletedAt]) VALUES (4, N'Decoration', NULL, 1, CAST(N'2022-06-25T22:35:46.3645797' AS DateTime2), NULL, NULL)
INSERT [dbo].[Categories] ([Id], [CategoryName], [ParentCategoryId], [IsActive], [CreatedAt], [UpdatedAt], [DeletedAt]) VALUES (5, N'Dining table', 1, 1, CAST(N'2022-06-25T22:35:46.3645809' AS DateTime2), NULL, NULL)
INSERT [dbo].[Categories] ([Id], [CategoryName], [ParentCategoryId], [IsActive], [CreatedAt], [UpdatedAt], [DeletedAt]) VALUES (6, N'Coffee table', 1, 1, CAST(N'2022-06-25T22:35:46.3646001' AS DateTime2), NULL, NULL)
INSERT [dbo].[Categories] ([Id], [CategoryName], [ParentCategoryId], [IsActive], [CreatedAt], [UpdatedAt], [DeletedAt]) VALUES (9, N'Single bed', 2, 1, CAST(N'2022-06-25T22:35:46.3646019' AS DateTime2), NULL, NULL)
INSERT [dbo].[Categories] ([Id], [CategoryName], [ParentCategoryId], [IsActive], [CreatedAt], [UpdatedAt], [DeletedAt]) VALUES (10, N'Duble bed', 2, 1, CAST(N'2022-06-25T22:35:46.3646030' AS DateTime2), NULL, NULL)
INSERT [dbo].[Categories] ([Id], [CategoryName], [ParentCategoryId], [IsActive], [CreatedAt], [UpdatedAt], [DeletedAt]) VALUES (11, N'Sofa', 2, 1, CAST(N'2022-06-25T22:35:46.3646042' AS DateTime2), NULL, NULL)
INSERT [dbo].[Categories] ([Id], [CategoryName], [ParentCategoryId], [IsActive], [CreatedAt], [UpdatedAt], [DeletedAt]) VALUES (12, N'Two-seater', 2, 1, CAST(N'2022-06-25T22:35:46.3646057' AS DateTime2), NULL, NULL)
INSERT [dbo].[Categories] ([Id], [CategoryName], [ParentCategoryId], [IsActive], [CreatedAt], [UpdatedAt], [DeletedAt]) VALUES (13, N'Three-seater', 2, 1, CAST(N'2022-06-25T22:35:46.3646068' AS DateTime2), NULL, NULL)
INSERT [dbo].[Categories] ([Id], [CategoryName], [ParentCategoryId], [IsActive], [CreatedAt], [UpdatedAt], [DeletedAt]) VALUES (14, N'Dining chair', 3, 1, CAST(N'2022-06-25T22:35:46.3646078' AS DateTime2), NULL, NULL)
INSERT [dbo].[Categories] ([Id], [CategoryName], [ParentCategoryId], [IsActive], [CreatedAt], [UpdatedAt], [DeletedAt]) VALUES (15, N'Computer chair', 3, 1, CAST(N'2022-06-25T22:35:46.3646088' AS DateTime2), NULL, NULL)
INSERT [dbo].[Categories] ([Id], [CategoryName], [ParentCategoryId], [IsActive], [CreatedAt], [UpdatedAt], [DeletedAt]) VALUES (16, N'Office chair', 3, 1, CAST(N'2022-06-25T22:35:46.3646099' AS DateTime2), NULL, NULL)
INSERT [dbo].[Categories] ([Id], [CategoryName], [ParentCategoryId], [IsActive], [CreatedAt], [UpdatedAt], [DeletedAt]) VALUES (19, N'Wardrobe', NULL, 1, CAST(N'2022-06-25T22:35:46.3646109' AS DateTime2), NULL, NULL)
INSERT [dbo].[Categories] ([Id], [CategoryName], [ParentCategoryId], [IsActive], [CreatedAt], [UpdatedAt], [DeletedAt]) VALUES (20, N'Shelf', NULL, 1, CAST(N'2022-06-25T22:35:46.3646120' AS DateTime2), NULL, NULL)
INSERT [dbo].[Categories] ([Id], [CategoryName], [ParentCategoryId], [IsActive], [CreatedAt], [UpdatedAt], [DeletedAt]) VALUES (21, N'Bookshelf', 20, 1, CAST(N'2022-06-25T22:35:46.3646130' AS DateTime2), NULL, NULL)
INSERT [dbo].[Categories] ([Id], [CategoryName], [ParentCategoryId], [IsActive], [CreatedAt], [UpdatedAt], [DeletedAt]) VALUES (22, N'Wall shelf', 20, 1, CAST(N'2022-06-25T22:35:46.3646143' AS DateTime2), NULL, NULL)
SET IDENTITY_INSERT [dbo].[Categories] OFF
GO
SET IDENTITY_INSERT [dbo].[Images] ON 

INSERT [dbo].[Images] ([Id], [Path], [Alt], [ProductId], [IsActive], [CreatedAt], [UpdatedAt], [DeletedAt]) VALUES (1, N'cheney-coffee-table.jpg', N'Image for product 1', 1, 1, CAST(N'2022-06-25T22:35:46.3668249' AS DateTime2), NULL, NULL)
INSERT [dbo].[Images] ([Id], [Path], [Alt], [ProductId], [IsActive], [CreatedAt], [UpdatedAt], [DeletedAt]) VALUES (2, N'aula-coffee-table.jpg', N'Image for product 2', 2, 1, CAST(N'2022-06-25T22:35:46.3671501' AS DateTime2), NULL, NULL)
INSERT [dbo].[Images] ([Id], [Path], [Alt], [ProductId], [IsActive], [CreatedAt], [UpdatedAt], [DeletedAt]) VALUES (3, N'anderson-set-coffee-tables.jpg', N'Image for product 3', 3, 1, CAST(N'2022-06-25T22:35:46.3671545' AS DateTime2), NULL, NULL)
INSERT [dbo].[Images] ([Id], [Path], [Alt], [ProductId], [IsActive], [CreatedAt], [UpdatedAt], [DeletedAt]) VALUES (4, N'haku-dining-table.jpg', N'Image for product 4', 4, 1, CAST(N'2022-06-25T22:35:46.3671556' AS DateTime2), NULL, NULL)
INSERT [dbo].[Images] ([Id], [Path], [Alt], [ProductId], [IsActive], [CreatedAt], [UpdatedAt], [DeletedAt]) VALUES (5, N'mora-dinning-table.jpg', N'Image for product 5', 5, 1, CAST(N'2022-06-25T22:35:46.3671566' AS DateTime2), NULL, NULL)
INSERT [dbo].[Images] ([Id], [Path], [Alt], [ProductId], [IsActive], [CreatedAt], [UpdatedAt], [DeletedAt]) VALUES (6, N'marcel-bookcase.jpg', N'Image for product 6', 6, 1, CAST(N'2022-06-25T22:35:46.3671585' AS DateTime2), NULL, NULL)
INSERT [dbo].[Images] ([Id], [Path], [Alt], [ProductId], [IsActive], [CreatedAt], [UpdatedAt], [DeletedAt]) VALUES (7, N'markus-office-chair.jpg', N'Image for product 7', 7, 1, CAST(N'2022-06-25T22:35:46.3671596' AS DateTime2), NULL, NULL)
INSERT [dbo].[Images] ([Id], [Path], [Alt], [ProductId], [IsActive], [CreatedAt], [UpdatedAt], [DeletedAt]) VALUES (8, N'jaku-dining-chair.jpg', N'Image for product 8', 8, 1, CAST(N'2022-06-25T22:35:46.3671606' AS DateTime2), NULL, NULL)
INSERT [dbo].[Images] ([Id], [Path], [Alt], [ProductId], [IsActive], [CreatedAt], [UpdatedAt], [DeletedAt]) VALUES (9, N'kooper-kingsize-bed.jpg', N'Image for product 9', 9, 1, CAST(N'2022-06-25T22:35:46.3671616' AS DateTime2), NULL, NULL)
INSERT [dbo].[Images] ([Id], [Path], [Alt], [ProductId], [IsActive], [CreatedAt], [UpdatedAt], [DeletedAt]) VALUES (10, N'bourbon-wardrobe.jpg', N'Image for product 10', 10, 1, CAST(N'2022-06-25T22:35:46.3671774' AS DateTime2), NULL, NULL)
INSERT [dbo].[Images] ([Id], [Path], [Alt], [ProductId], [IsActive], [CreatedAt], [UpdatedAt], [DeletedAt]) VALUES (11, N'keaton-wardrobe.jpg', N'Image for product 11', 11, 1, CAST(N'2022-06-25T22:35:46.3671790' AS DateTime2), NULL, NULL)
INSERT [dbo].[Images] ([Id], [Path], [Alt], [ProductId], [IsActive], [CreatedAt], [UpdatedAt], [DeletedAt]) VALUES (12, N'haru-two-seater-sofa.jpg', N'Image for product 12', 12, 1, CAST(N'2022-06-25T22:35:46.3671801' AS DateTime2), NULL, NULL)
INSERT [dbo].[Images] ([Id], [Path], [Alt], [ProductId], [IsActive], [CreatedAt], [UpdatedAt], [DeletedAt]) VALUES (13, N'kooper-two-seater-sofa.jpg', N'Image for product 13', 13, 1, CAST(N'2022-06-25T22:35:46.3671811' AS DateTime2), NULL, NULL)
INSERT [dbo].[Images] ([Id], [Path], [Alt], [ProductId], [IsActive], [CreatedAt], [UpdatedAt], [DeletedAt]) VALUES (14, N'lottie-three-seater-sofa.jpg', N'Image for product 14', 14, 1, CAST(N'2022-06-25T22:35:46.3671821' AS DateTime2), NULL, NULL)
INSERT [dbo].[Images] ([Id], [Path], [Alt], [ProductId], [IsActive], [CreatedAt], [UpdatedAt], [DeletedAt]) VALUES (15, N'faces-wall-set.jpg', N'Image for product 15', 15, 1, CAST(N'2022-06-25T22:35:46.3671832' AS DateTime2), NULL, NULL)
INSERT [dbo].[Images] ([Id], [Path], [Alt], [ProductId], [IsActive], [CreatedAt], [UpdatedAt], [DeletedAt]) VALUES (16, N'florals-wall-set.jpg', N'Image for product 16', 16, 1, CAST(N'2022-06-25T22:35:46.3671842' AS DateTime2), NULL, NULL)
INSERT [dbo].[Images] ([Id], [Path], [Alt], [ProductId], [IsActive], [CreatedAt], [UpdatedAt], [DeletedAt]) VALUES (17, N'leyla-wall-shelf.jpg', N'Image for product 17', 17, 1, CAST(N'2022-06-25T22:35:46.3671852' AS DateTime2), NULL, NULL)
INSERT [dbo].[Images] ([Id], [Path], [Alt], [ProductId], [IsActive], [CreatedAt], [UpdatedAt], [DeletedAt]) VALUES (18, N'besley-single-bed.jpg', N'Image for product 18', 18, 1, CAST(N'2022-06-25T22:35:46.3671868' AS DateTime2), NULL, NULL)
INSERT [dbo].[Images] ([Id], [Path], [Alt], [ProductId], [IsActive], [CreatedAt], [UpdatedAt], [DeletedAt]) VALUES (19, N'harlow-corner-sofa.jpg', N'Image for product 19', 19, 1, CAST(N'2022-06-25T22:35:46.3671878' AS DateTime2), NULL, NULL)
SET IDENTITY_INSERT [dbo].[Images] OFF
GO
SET IDENTITY_INSERT [dbo].[OrderItems] ON 

INSERT [dbo].[OrderItems] ([Id], [OrderId], [ProductId], [Quantity], [IsActive], [CreatedAt], [UpdatedAt], [DeletedAt]) VALUES (1, 1, 1, 2, 0, CAST(N'2022-06-25T22:35:46.3681946' AS DateTime2), NULL, NULL)
SET IDENTITY_INSERT [dbo].[OrderItems] OFF
GO
SET IDENTITY_INSERT [dbo].[Orders] ON 

INSERT [dbo].[Orders] ([Id], [UserId], [OrderNumber], [Address], [City], [Country], [Phone], [IsActive], [CreatedAt], [UpdatedAt], [DeletedAt]) VALUES (1, 6, 8695482, N'Address 1', N'CIty 1', N'Country 1', N'0666665522', 1, CAST(N'2022-06-25T22:35:46.3673676' AS DateTime2), NULL, NULL)
SET IDENTITY_INSERT [dbo].[Orders] OFF
GO
SET IDENTITY_INSERT [dbo].[Prices] ON 

INSERT [dbo].[Prices] ([Id], [PriceValue], [ProductId], [IsActive], [CreatedAt], [UpdatedAt], [DeletedAt]) VALUES (1, CAST(90.99 AS Decimal(18, 2)), 1, 0, CAST(N'2022-06-25T22:35:46.3664284' AS DateTime2), NULL, NULL)
INSERT [dbo].[Prices] ([Id], [PriceValue], [ProductId], [IsActive], [CreatedAt], [UpdatedAt], [DeletedAt]) VALUES (2, CAST(85.99 AS Decimal(18, 2)), 2, 0, CAST(N'2022-06-25T22:35:46.3666924' AS DateTime2), NULL, NULL)
INSERT [dbo].[Prices] ([Id], [PriceValue], [ProductId], [IsActive], [CreatedAt], [UpdatedAt], [DeletedAt]) VALUES (3, CAST(156.99 AS Decimal(18, 2)), 3, 0, CAST(N'2022-06-25T22:35:46.3666975' AS DateTime2), NULL, NULL)
INSERT [dbo].[Prices] ([Id], [PriceValue], [ProductId], [IsActive], [CreatedAt], [UpdatedAt], [DeletedAt]) VALUES (4, CAST(275.99 AS Decimal(18, 2)), 4, 0, CAST(N'2022-06-25T22:35:46.3666987' AS DateTime2), NULL, NULL)
INSERT [dbo].[Prices] ([Id], [PriceValue], [ProductId], [IsActive], [CreatedAt], [UpdatedAt], [DeletedAt]) VALUES (5, CAST(350.99 AS Decimal(18, 2)), 5, 0, CAST(N'2022-06-25T22:35:46.3666997' AS DateTime2), NULL, NULL)
INSERT [dbo].[Prices] ([Id], [PriceValue], [ProductId], [IsActive], [CreatedAt], [UpdatedAt], [DeletedAt]) VALUES (6, CAST(132.99 AS Decimal(18, 2)), 6, 0, CAST(N'2022-06-25T22:35:46.3667015' AS DateTime2), NULL, NULL)
INSERT [dbo].[Prices] ([Id], [PriceValue], [ProductId], [IsActive], [CreatedAt], [UpdatedAt], [DeletedAt]) VALUES (7, CAST(230.99 AS Decimal(18, 2)), 7, 0, CAST(N'2022-06-25T22:35:46.3667025' AS DateTime2), NULL, NULL)
INSERT [dbo].[Prices] ([Id], [PriceValue], [ProductId], [IsActive], [CreatedAt], [UpdatedAt], [DeletedAt]) VALUES (8, CAST(62.99 AS Decimal(18, 2)), 8, 0, CAST(N'2022-06-25T22:35:46.3667035' AS DateTime2), NULL, NULL)
INSERT [dbo].[Prices] ([Id], [PriceValue], [ProductId], [IsActive], [CreatedAt], [UpdatedAt], [DeletedAt]) VALUES (9, CAST(355.99 AS Decimal(18, 2)), 9, 0, CAST(N'2022-06-25T22:35:46.3667046' AS DateTime2), NULL, NULL)
INSERT [dbo].[Prices] ([Id], [PriceValue], [ProductId], [IsActive], [CreatedAt], [UpdatedAt], [DeletedAt]) VALUES (10, CAST(210.99 AS Decimal(18, 2)), 10, 0, CAST(N'2022-06-25T22:35:46.3667058' AS DateTime2), NULL, NULL)
INSERT [dbo].[Prices] ([Id], [PriceValue], [ProductId], [IsActive], [CreatedAt], [UpdatedAt], [DeletedAt]) VALUES (11, CAST(250.99 AS Decimal(18, 2)), 11, 0, CAST(N'2022-06-25T22:35:46.3667069' AS DateTime2), NULL, NULL)
INSERT [dbo].[Prices] ([Id], [PriceValue], [ProductId], [IsActive], [CreatedAt], [UpdatedAt], [DeletedAt]) VALUES (12, CAST(195.99 AS Decimal(18, 2)), 12, 0, CAST(N'2022-06-25T22:35:46.3667079' AS DateTime2), NULL, NULL)
INSERT [dbo].[Prices] ([Id], [PriceValue], [ProductId], [IsActive], [CreatedAt], [UpdatedAt], [DeletedAt]) VALUES (13, CAST(155.99 AS Decimal(18, 2)), 13, 0, CAST(N'2022-06-25T22:35:46.3667089' AS DateTime2), NULL, NULL)
INSERT [dbo].[Prices] ([Id], [PriceValue], [ProductId], [IsActive], [CreatedAt], [UpdatedAt], [DeletedAt]) VALUES (14, CAST(195.99 AS Decimal(18, 2)), 14, 0, CAST(N'2022-06-25T22:35:46.3667099' AS DateTime2), NULL, NULL)
INSERT [dbo].[Prices] ([Id], [PriceValue], [ProductId], [IsActive], [CreatedAt], [UpdatedAt], [DeletedAt]) VALUES (15, CAST(50.99 AS Decimal(18, 2)), 15, 0, CAST(N'2022-06-25T22:35:46.3667109' AS DateTime2), NULL, NULL)
INSERT [dbo].[Prices] ([Id], [PriceValue], [ProductId], [IsActive], [CreatedAt], [UpdatedAt], [DeletedAt]) VALUES (16, CAST(68.99 AS Decimal(18, 2)), 16, 0, CAST(N'2022-06-25T22:35:46.3667119' AS DateTime2), NULL, NULL)
INSERT [dbo].[Prices] ([Id], [PriceValue], [ProductId], [IsActive], [CreatedAt], [UpdatedAt], [DeletedAt]) VALUES (17, CAST(129.99 AS Decimal(18, 2)), 17, 0, CAST(N'2022-06-25T22:35:46.3667129' AS DateTime2), NULL, NULL)
INSERT [dbo].[Prices] ([Id], [PriceValue], [ProductId], [IsActive], [CreatedAt], [UpdatedAt], [DeletedAt]) VALUES (18, CAST(205.99 AS Decimal(18, 2)), 18, 0, CAST(N'2022-06-25T22:35:46.3667142' AS DateTime2), NULL, NULL)
INSERT [dbo].[Prices] ([Id], [PriceValue], [ProductId], [IsActive], [CreatedAt], [UpdatedAt], [DeletedAt]) VALUES (19, CAST(399.99 AS Decimal(18, 2)), 19, 0, CAST(N'2022-06-25T22:35:46.3667154' AS DateTime2), NULL, NULL)
SET IDENTITY_INSERT [dbo].[Prices] OFF
GO
SET IDENTITY_INSERT [dbo].[Products] ON 

INSERT [dbo].[Products] ([Id], [ProductName], [Description], [CategoryId], [IsActive], [CreatedAt], [UpdatedAt], [DeletedAt]) VALUES (1, N'Cheney coffee table', N'This coffee table with glass surface will elevate the look of your space. It is perfect for luxury homes.', 6, 1, CAST(N'2022-06-25T22:35:46.3653982' AS DateTime2), NULL, NULL)
INSERT [dbo].[Products] ([Id], [ProductName], [Description], [CategoryId], [IsActive], [CreatedAt], [UpdatedAt], [DeletedAt]) VALUES (2, N'Aula coffee table', N'Golden details on this table makes it look really refinedand we are sure that this is the right choice if you are looking for something simple yet effective.', 6, 1, CAST(N'2022-06-25T22:35:46.3657553' AS DateTime2), NULL, NULL)
INSERT [dbo].[Products] ([Id], [ProductName], [Description], [CategoryId], [IsActive], [CreatedAt], [UpdatedAt], [DeletedAt]) VALUES (3, N'Andreson coffee table', N'Made of solid wood with fine details and a smooth surface, the Andreson coffee table brings a classic charm to your room.', 6, 1, CAST(N'2022-06-25T22:35:46.3657605' AS DateTime2), NULL, NULL)
INSERT [dbo].[Products] ([Id], [ProductName], [Description], [CategoryId], [IsActive], [CreatedAt], [UpdatedAt], [DeletedAt]) VALUES (4, N'Haku dining table', N'Haku is dining table for 6 persons. As gold and glass are erfect match, we are sure that this table will be perfect in any type of home.', 5, 1, CAST(N'2022-06-25T22:35:46.3657618' AS DateTime2), NULL, NULL)
INSERT [dbo].[Products] ([Id], [ProductName], [Description], [CategoryId], [IsActive], [CreatedAt], [UpdatedAt], [DeletedAt]) VALUES (5, N'Mora dining table', N'Mora is dining table for 4 persons. ', 5, 1, CAST(N'2022-06-25T22:35:46.3657631' AS DateTime2), NULL, NULL)
INSERT [dbo].[Products] ([Id], [ProductName], [Description], [CategoryId], [IsActive], [CreatedAt], [UpdatedAt], [DeletedAt]) VALUES (6, N'Marcel bookshelf', N'White bookshelf gives you so much freedom to decorate it in any way you like! You can store books, magazines or any type of decoration pieces.', 21, 1, CAST(N'2022-06-25T22:35:46.3657653' AS DateTime2), NULL, NULL)
INSERT [dbo].[Products] ([Id], [ProductName], [Description], [CategoryId], [IsActive], [CreatedAt], [UpdatedAt], [DeletedAt]) VALUES (7, N'Markus office chair', N'Adjust the height and angle of this chair to make you comfortable during the working day. The mesh backrest leaks air, so you won''t heat the chair even when the workload increases.', 16, 1, CAST(N'2022-06-25T22:35:46.3657666' AS DateTime2), NULL, NULL)
INSERT [dbo].[Products] ([Id], [ProductName], [Description], [CategoryId], [IsActive], [CreatedAt], [UpdatedAt], [DeletedAt]) VALUES (8, N'Jaku dining chair', N' Description for jaku dinning chair', 14, 1, CAST(N'2022-06-25T22:35:46.3657680' AS DateTime2), NULL, NULL)
INSERT [dbo].[Products] ([Id], [ProductName], [Description], [CategoryId], [IsActive], [CreatedAt], [UpdatedAt], [DeletedAt]) VALUES (9, N'Kooper double bed', N'Fransoa double bed is so comfortable that you will want to stay in it as long as possible every morning', 10, 1, CAST(N'2022-06-25T22:35:46.3657691' AS DateTime2), NULL, NULL)
INSERT [dbo].[Products] ([Id], [ProductName], [Description], [CategoryId], [IsActive], [CreatedAt], [UpdatedAt], [DeletedAt]) VALUES (10, N'Bourbon wardrobe', N'Description for bourbon wardrobe', 19, 1, CAST(N'2022-06-25T22:35:46.3657707' AS DateTime2), NULL, NULL)
INSERT [dbo].[Products] ([Id], [ProductName], [Description], [CategoryId], [IsActive], [CreatedAt], [UpdatedAt], [DeletedAt]) VALUES (11, N'Keaton wardrobe', N'Description for keaton wardrobe', 19, 1, CAST(N'2022-06-25T22:35:46.3657719' AS DateTime2), NULL, NULL)
INSERT [dbo].[Products] ([Id], [ProductName], [Description], [CategoryId], [IsActive], [CreatedAt], [UpdatedAt], [DeletedAt]) VALUES (12, N'Haru two seater sofa', N'Description for Haru two seater sofa', 12, 1, CAST(N'2022-06-25T22:35:46.3657731' AS DateTime2), NULL, NULL)
INSERT [dbo].[Products] ([Id], [ProductName], [Description], [CategoryId], [IsActive], [CreatedAt], [UpdatedAt], [DeletedAt]) VALUES (13, N'Kooper two seater sofa', N'Description for Kooper two seater sofa', 12, 1, CAST(N'2022-06-25T22:35:46.3657742' AS DateTime2), NULL, NULL)
INSERT [dbo].[Products] ([Id], [ProductName], [Description], [CategoryId], [IsActive], [CreatedAt], [UpdatedAt], [DeletedAt]) VALUES (14, N'Lottie three seater sofa', N'Description for Kooper Lottie seater sofa', 13, 1, CAST(N'2022-06-25T22:35:46.3657754' AS DateTime2), NULL, NULL)
INSERT [dbo].[Products] ([Id], [ProductName], [Description], [CategoryId], [IsActive], [CreatedAt], [UpdatedAt], [DeletedAt]) VALUES (15, N'Faces wall set', N'Description for Faces wall set', 4, 1, CAST(N'2022-06-25T22:35:46.3657765' AS DateTime2), NULL, NULL)
INSERT [dbo].[Products] ([Id], [ProductName], [Description], [CategoryId], [IsActive], [CreatedAt], [UpdatedAt], [DeletedAt]) VALUES (16, N'Florals wall set', N'Description for Florals wall set', 4, 1, CAST(N'2022-06-25T22:35:46.3657778' AS DateTime2), NULL, NULL)
INSERT [dbo].[Products] ([Id], [ProductName], [Description], [CategoryId], [IsActive], [CreatedAt], [UpdatedAt], [DeletedAt]) VALUES (17, N'Leyla wall shelf', N'Description for Leyla wall shelf', 22, 1, CAST(N'2022-06-25T22:35:46.3657790' AS DateTime2), NULL, NULL)
INSERT [dbo].[Products] ([Id], [ProductName], [Description], [CategoryId], [IsActive], [CreatedAt], [UpdatedAt], [DeletedAt]) VALUES (18, N'Besley single bed', N'Description for Besley single bed', 9, 1, CAST(N'2022-06-25T22:35:46.3658059' AS DateTime2), NULL, NULL)
INSERT [dbo].[Products] ([Id], [ProductName], [Description], [CategoryId], [IsActive], [CreatedAt], [UpdatedAt], [DeletedAt]) VALUES (19, N'Harlow corner sofa', N'Description for Harlow corner sofa', 11, 1, CAST(N'2022-06-25T22:35:46.3658083' AS DateTime2), NULL, NULL)
SET IDENTITY_INSERT [dbo].[Products] OFF
GO
SET IDENTITY_INSERT [dbo].[ProductSpecifications] ON 

INSERT [dbo].[ProductSpecifications] ([SpecificationId], [ProductId], [SpecificationValue], [Id], [CreatedAt], [DeletedAt], [IsActive], [UpdatedAt]) VALUES (1, 1, N'55cm', 1, CAST(N'2022-06-25T22:35:46.3659248' AS DateTime2), NULL, 1, NULL)
INSERT [dbo].[ProductSpecifications] ([SpecificationId], [ProductId], [SpecificationValue], [Id], [CreatedAt], [DeletedAt], [IsActive], [UpdatedAt]) VALUES (3, 1, N'90cm', 2, CAST(N'2022-06-25T22:35:46.3662743' AS DateTime2), NULL, 1, NULL)
INSERT [dbo].[ProductSpecifications] ([SpecificationId], [ProductId], [SpecificationValue], [Id], [CreatedAt], [DeletedAt], [IsActive], [UpdatedAt]) VALUES (2, 1, N'45cm', 3, CAST(N'2022-06-25T22:35:46.3662792' AS DateTime2), NULL, 1, NULL)
INSERT [dbo].[ProductSpecifications] ([SpecificationId], [ProductId], [SpecificationValue], [Id], [CreatedAt], [DeletedAt], [IsActive], [UpdatedAt]) VALUES (1, 2, N'40cm', 4, CAST(N'2022-06-25T22:35:46.3662803' AS DateTime2), NULL, 1, NULL)
INSERT [dbo].[ProductSpecifications] ([SpecificationId], [ProductId], [SpecificationValue], [Id], [CreatedAt], [DeletedAt], [IsActive], [UpdatedAt]) VALUES (3, 2, N'50cm', 5, CAST(N'2022-06-25T22:35:46.3662814' AS DateTime2), NULL, 1, NULL)
INSERT [dbo].[ProductSpecifications] ([SpecificationId], [ProductId], [SpecificationValue], [Id], [CreatedAt], [DeletedAt], [IsActive], [UpdatedAt]) VALUES (2, 2, N'45cm', 6, CAST(N'2022-06-25T22:35:46.3662833' AS DateTime2), NULL, 1, NULL)
INSERT [dbo].[ProductSpecifications] ([SpecificationId], [ProductId], [SpecificationValue], [Id], [CreatedAt], [DeletedAt], [IsActive], [UpdatedAt]) VALUES (1, 3, N'60cm', 7, CAST(N'2022-06-25T22:35:46.3662843' AS DateTime2), NULL, 1, NULL)
INSERT [dbo].[ProductSpecifications] ([SpecificationId], [ProductId], [SpecificationValue], [Id], [CreatedAt], [DeletedAt], [IsActive], [UpdatedAt]) VALUES (3, 3, N'95cm', 8, CAST(N'2022-06-25T22:35:46.3662853' AS DateTime2), NULL, 1, NULL)
INSERT [dbo].[ProductSpecifications] ([SpecificationId], [ProductId], [SpecificationValue], [Id], [CreatedAt], [DeletedAt], [IsActive], [UpdatedAt]) VALUES (2, 3, N'50cm', 9, CAST(N'2022-06-25T22:35:46.3662864' AS DateTime2), NULL, 1, NULL)
INSERT [dbo].[ProductSpecifications] ([SpecificationId], [ProductId], [SpecificationValue], [Id], [CreatedAt], [DeletedAt], [IsActive], [UpdatedAt]) VALUES (1, 4, N'80cm', 10, CAST(N'2022-06-25T22:35:46.3662876' AS DateTime2), NULL, 1, NULL)
INSERT [dbo].[ProductSpecifications] ([SpecificationId], [ProductId], [SpecificationValue], [Id], [CreatedAt], [DeletedAt], [IsActive], [UpdatedAt]) VALUES (3, 4, N'180cm', 11, CAST(N'2022-06-25T22:35:46.3662888' AS DateTime2), NULL, 1, NULL)
INSERT [dbo].[ProductSpecifications] ([SpecificationId], [ProductId], [SpecificationValue], [Id], [CreatedAt], [DeletedAt], [IsActive], [UpdatedAt]) VALUES (2, 4, N'75cm', 12, CAST(N'2022-06-25T22:35:46.3662898' AS DateTime2), NULL, 1, NULL)
INSERT [dbo].[ProductSpecifications] ([SpecificationId], [ProductId], [SpecificationValue], [Id], [CreatedAt], [DeletedAt], [IsActive], [UpdatedAt]) VALUES (1, 5, N'900cm', 13, CAST(N'2022-06-25T22:35:46.3662908' AS DateTime2), NULL, 1, NULL)
INSERT [dbo].[ProductSpecifications] ([SpecificationId], [ProductId], [SpecificationValue], [Id], [CreatedAt], [DeletedAt], [IsActive], [UpdatedAt]) VALUES (3, 5, N'180cm', 14, CAST(N'2022-06-25T22:35:46.3662918' AS DateTime2), NULL, 1, NULL)
INSERT [dbo].[ProductSpecifications] ([SpecificationId], [ProductId], [SpecificationValue], [Id], [CreatedAt], [DeletedAt], [IsActive], [UpdatedAt]) VALUES (2, 5, N'75cm', 15, CAST(N'2022-06-25T22:35:46.3662928' AS DateTime2), NULL, 1, NULL)
INSERT [dbo].[ProductSpecifications] ([SpecificationId], [ProductId], [SpecificationValue], [Id], [CreatedAt], [DeletedAt], [IsActive], [UpdatedAt]) VALUES (1, 6, N'80cm', 16, CAST(N'2022-06-25T22:35:46.3662938' AS DateTime2), NULL, 1, NULL)
INSERT [dbo].[ProductSpecifications] ([SpecificationId], [ProductId], [SpecificationValue], [Id], [CreatedAt], [DeletedAt], [IsActive], [UpdatedAt]) VALUES (2, 6, N'150cm', 17, CAST(N'2022-06-25T22:35:46.3662948' AS DateTime2), NULL, 1, NULL)
INSERT [dbo].[ProductSpecifications] ([SpecificationId], [ProductId], [SpecificationValue], [Id], [CreatedAt], [DeletedAt], [IsActive], [UpdatedAt]) VALUES (1, 6, N'30cm', 18, CAST(N'2022-06-25T22:35:46.3662961' AS DateTime2), NULL, 1, NULL)
INSERT [dbo].[ProductSpecifications] ([SpecificationId], [ProductId], [SpecificationValue], [Id], [CreatedAt], [DeletedAt], [IsActive], [UpdatedAt]) VALUES (1, 9, N'160cm', 19, CAST(N'2022-06-25T22:35:46.3662971' AS DateTime2), NULL, 1, NULL)
INSERT [dbo].[ProductSpecifications] ([SpecificationId], [ProductId], [SpecificationValue], [Id], [CreatedAt], [DeletedAt], [IsActive], [UpdatedAt]) VALUES (3, 9, N'200cm', 20, CAST(N'2022-06-25T22:35:46.3662982' AS DateTime2), NULL, 1, NULL)
INSERT [dbo].[ProductSpecifications] ([SpecificationId], [ProductId], [SpecificationValue], [Id], [CreatedAt], [DeletedAt], [IsActive], [UpdatedAt]) VALUES (1, 9, N'45cm', 21, CAST(N'2022-06-25T22:35:46.3662991' AS DateTime2), NULL, 1, NULL)
INSERT [dbo].[ProductSpecifications] ([SpecificationId], [ProductId], [SpecificationValue], [Id], [CreatedAt], [DeletedAt], [IsActive], [UpdatedAt]) VALUES (2, 10, N'80cm', 22, CAST(N'2022-06-25T22:35:46.3663002' AS DateTime2), NULL, 1, NULL)
INSERT [dbo].[ProductSpecifications] ([SpecificationId], [ProductId], [SpecificationValue], [Id], [CreatedAt], [DeletedAt], [IsActive], [UpdatedAt]) VALUES (1, 10, N'200cm', 23, CAST(N'2022-06-25T22:35:46.3663012' AS DateTime2), NULL, 1, NULL)
INSERT [dbo].[ProductSpecifications] ([SpecificationId], [ProductId], [SpecificationValue], [Id], [CreatedAt], [DeletedAt], [IsActive], [UpdatedAt]) VALUES (4, 10, N'50cm', 24, CAST(N'2022-06-25T22:35:46.3663022' AS DateTime2), NULL, 1, NULL)
INSERT [dbo].[ProductSpecifications] ([SpecificationId], [ProductId], [SpecificationValue], [Id], [CreatedAt], [DeletedAt], [IsActive], [UpdatedAt]) VALUES (2, 11, N'80cm', 25, CAST(N'2022-06-25T22:35:46.3663032' AS DateTime2), NULL, 1, NULL)
INSERT [dbo].[ProductSpecifications] ([SpecificationId], [ProductId], [SpecificationValue], [Id], [CreatedAt], [DeletedAt], [IsActive], [UpdatedAt]) VALUES (1, 11, N'200cm', 26, CAST(N'2022-06-25T22:35:46.3663042' AS DateTime2), NULL, 1, NULL)
INSERT [dbo].[ProductSpecifications] ([SpecificationId], [ProductId], [SpecificationValue], [Id], [CreatedAt], [DeletedAt], [IsActive], [UpdatedAt]) VALUES (4, 11, N'50cm', 27, CAST(N'2022-06-25T22:35:46.3663052' AS DateTime2), NULL, 1, NULL)
INSERT [dbo].[ProductSpecifications] ([SpecificationId], [ProductId], [SpecificationValue], [Id], [CreatedAt], [DeletedAt], [IsActive], [UpdatedAt]) VALUES (1, 12, N'120cm', 28, CAST(N'2022-06-25T22:35:46.3663062' AS DateTime2), NULL, 1, NULL)
INSERT [dbo].[ProductSpecifications] ([SpecificationId], [ProductId], [SpecificationValue], [Id], [CreatedAt], [DeletedAt], [IsActive], [UpdatedAt]) VALUES (1, 13, N'120cm', 29, CAST(N'2022-06-25T22:35:46.3663073' AS DateTime2), NULL, 1, NULL)
INSERT [dbo].[ProductSpecifications] ([SpecificationId], [ProductId], [SpecificationValue], [Id], [CreatedAt], [DeletedAt], [IsActive], [UpdatedAt]) VALUES (1, 14, N'200cm', 30, CAST(N'2022-06-25T22:35:46.3663083' AS DateTime2), NULL, 1, NULL)
INSERT [dbo].[ProductSpecifications] ([SpecificationId], [ProductId], [SpecificationValue], [Id], [CreatedAt], [DeletedAt], [IsActive], [UpdatedAt]) VALUES (1, 18, N'120cm', 31, CAST(N'2022-06-25T22:35:46.3663094' AS DateTime2), NULL, 1, NULL)
INSERT [dbo].[ProductSpecifications] ([SpecificationId], [ProductId], [SpecificationValue], [Id], [CreatedAt], [DeletedAt], [IsActive], [UpdatedAt]) VALUES (3, 18, N'200cm', 32, CAST(N'2022-06-25T22:35:46.3663104' AS DateTime2), NULL, 1, NULL)
INSERT [dbo].[ProductSpecifications] ([SpecificationId], [ProductId], [SpecificationValue], [Id], [CreatedAt], [DeletedAt], [IsActive], [UpdatedAt]) VALUES (1, 19, N'240cm', 33, CAST(N'2022-06-25T22:35:46.3663114' AS DateTime2), NULL, 1, NULL)
SET IDENTITY_INSERT [dbo].[ProductSpecifications] OFF
GO
SET IDENTITY_INSERT [dbo].[Roles] ON 

INSERT [dbo].[Roles] ([Id], [Name], [IsActive], [CreatedAt], [UpdatedAt], [DeletedAt]) VALUES (1, N'User', 1, CAST(N'2022-06-25T22:35:46.3525884' AS DateTime2), NULL, NULL)
INSERT [dbo].[Roles] ([Id], [Name], [IsActive], [CreatedAt], [UpdatedAt], [DeletedAt]) VALUES (2, N'Admin', 1, CAST(N'2022-06-25T22:35:46.3626520' AS DateTime2), NULL, NULL)
SET IDENTITY_INSERT [dbo].[Roles] OFF
GO
INSERT [dbo].[RoleUseCases] ([RoleId], [UseCaseId]) VALUES (1, 1)
INSERT [dbo].[RoleUseCases] ([RoleId], [UseCaseId]) VALUES (1, 3)
INSERT [dbo].[RoleUseCases] ([RoleId], [UseCaseId]) VALUES (1, 4)
INSERT [dbo].[RoleUseCases] ([RoleId], [UseCaseId]) VALUES (1, 6)
INSERT [dbo].[RoleUseCases] ([RoleId], [UseCaseId]) VALUES (1, 7)
INSERT [dbo].[RoleUseCases] ([RoleId], [UseCaseId]) VALUES (1, 8)
INSERT [dbo].[RoleUseCases] ([RoleId], [UseCaseId]) VALUES (1, 9)
INSERT [dbo].[RoleUseCases] ([RoleId], [UseCaseId]) VALUES (1, 10)
INSERT [dbo].[RoleUseCases] ([RoleId], [UseCaseId]) VALUES (1, 11)
INSERT [dbo].[RoleUseCases] ([RoleId], [UseCaseId]) VALUES (1, 13)
INSERT [dbo].[RoleUseCases] ([RoleId], [UseCaseId]) VALUES (1, 15)
INSERT [dbo].[RoleUseCases] ([RoleId], [UseCaseId]) VALUES (1, 16)
INSERT [dbo].[RoleUseCases] ([RoleId], [UseCaseId]) VALUES (1, 19)
INSERT [dbo].[RoleUseCases] ([RoleId], [UseCaseId]) VALUES (1, 28)
INSERT [dbo].[RoleUseCases] ([RoleId], [UseCaseId]) VALUES (2, 1)
INSERT [dbo].[RoleUseCases] ([RoleId], [UseCaseId]) VALUES (2, 2)
INSERT [dbo].[RoleUseCases] ([RoleId], [UseCaseId]) VALUES (2, 3)
INSERT [dbo].[RoleUseCases] ([RoleId], [UseCaseId]) VALUES (2, 4)
INSERT [dbo].[RoleUseCases] ([RoleId], [UseCaseId]) VALUES (2, 5)
INSERT [dbo].[RoleUseCases] ([RoleId], [UseCaseId]) VALUES (2, 6)
INSERT [dbo].[RoleUseCases] ([RoleId], [UseCaseId]) VALUES (2, 7)
INSERT [dbo].[RoleUseCases] ([RoleId], [UseCaseId]) VALUES (2, 8)
INSERT [dbo].[RoleUseCases] ([RoleId], [UseCaseId]) VALUES (2, 9)
INSERT [dbo].[RoleUseCases] ([RoleId], [UseCaseId]) VALUES (2, 10)
INSERT [dbo].[RoleUseCases] ([RoleId], [UseCaseId]) VALUES (2, 11)
INSERT [dbo].[RoleUseCases] ([RoleId], [UseCaseId]) VALUES (2, 12)
INSERT [dbo].[RoleUseCases] ([RoleId], [UseCaseId]) VALUES (2, 13)
INSERT [dbo].[RoleUseCases] ([RoleId], [UseCaseId]) VALUES (2, 14)
INSERT [dbo].[RoleUseCases] ([RoleId], [UseCaseId]) VALUES (2, 15)
INSERT [dbo].[RoleUseCases] ([RoleId], [UseCaseId]) VALUES (2, 16)
INSERT [dbo].[RoleUseCases] ([RoleId], [UseCaseId]) VALUES (2, 17)
INSERT [dbo].[RoleUseCases] ([RoleId], [UseCaseId]) VALUES (2, 18)
INSERT [dbo].[RoleUseCases] ([RoleId], [UseCaseId]) VALUES (2, 19)
INSERT [dbo].[RoleUseCases] ([RoleId], [UseCaseId]) VALUES (2, 20)
INSERT [dbo].[RoleUseCases] ([RoleId], [UseCaseId]) VALUES (2, 21)
INSERT [dbo].[RoleUseCases] ([RoleId], [UseCaseId]) VALUES (2, 22)
INSERT [dbo].[RoleUseCases] ([RoleId], [UseCaseId]) VALUES (2, 23)
INSERT [dbo].[RoleUseCases] ([RoleId], [UseCaseId]) VALUES (2, 24)
INSERT [dbo].[RoleUseCases] ([RoleId], [UseCaseId]) VALUES (2, 25)
INSERT [dbo].[RoleUseCases] ([RoleId], [UseCaseId]) VALUES (2, 26)
INSERT [dbo].[RoleUseCases] ([RoleId], [UseCaseId]) VALUES (2, 27)
INSERT [dbo].[RoleUseCases] ([RoleId], [UseCaseId]) VALUES (2, 28)
GO
SET IDENTITY_INSERT [dbo].[Specifications] ON 

INSERT [dbo].[Specifications] ([Id], [SpecificationName], [IsActive], [CreatedAt], [UpdatedAt], [DeletedAt]) VALUES (1, N'Width', 1, CAST(N'2022-06-25T22:35:46.3648767' AS DateTime2), NULL, NULL)
INSERT [dbo].[Specifications] ([Id], [SpecificationName], [IsActive], [CreatedAt], [UpdatedAt], [DeletedAt]) VALUES (2, N'Height', 1, CAST(N'2022-06-25T22:35:46.3650103' AS DateTime2), NULL, NULL)
INSERT [dbo].[Specifications] ([Id], [SpecificationName], [IsActive], [CreatedAt], [UpdatedAt], [DeletedAt]) VALUES (3, N'Length', 1, CAST(N'2022-06-25T22:35:46.3650150' AS DateTime2), NULL, NULL)
INSERT [dbo].[Specifications] ([Id], [SpecificationName], [IsActive], [CreatedAt], [UpdatedAt], [DeletedAt]) VALUES (4, N'Depth', 1, CAST(N'2022-06-25T22:35:46.3650162' AS DateTime2), NULL, NULL)
INSERT [dbo].[Specifications] ([Id], [SpecificationName], [IsActive], [CreatedAt], [UpdatedAt], [DeletedAt]) VALUES (5, N'Color', 1, CAST(N'2022-06-25T22:35:46.3650174' AS DateTime2), NULL, NULL)
SET IDENTITY_INSERT [dbo].[Specifications] OFF
GO
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([Id], [FirstName], [LastName], [Email], [Password], [RoleId], [IsActive], [CreatedAt], [UpdatedAt], [DeletedAt]) VALUES (1, N'John', N'Smith', N'johnsmith@gmail.com', N'$2a$11$hPsl4hFksFlOiMv5bSBT8eJ23/PShHt3ixygI9V.LYqw6nQwDn4Zu', 1, 1, CAST(N'2022-06-25T22:35:46.3633812' AS DateTime2), NULL, NULL)
INSERT [dbo].[Users] ([Id], [FirstName], [LastName], [Email], [Password], [RoleId], [IsActive], [CreatedAt], [UpdatedAt], [DeletedAt]) VALUES (2, N'Mike', N'Legend', N'mikelegend@gmail.com', N'$2a$11$hPsl4hFksFlOiMv5bSBT8eJ23/PShHt3ixygI9V.LYqw6nQwDn4Zu', 1, 1, CAST(N'2022-06-25T22:35:46.3640022' AS DateTime2), NULL, NULL)
INSERT [dbo].[Users] ([Id], [FirstName], [LastName], [Email], [Password], [RoleId], [IsActive], [CreatedAt], [UpdatedAt], [DeletedAt]) VALUES (3, N'Maria', N'Jameson', N'mariajameson@gmail.com', N'$2a$11$hPsl4hFksFlOiMv5bSBT8eJ23/PShHt3ixygI9V.LYqw6nQwDn4Zu', 1, 1, CAST(N'2022-06-25T22:35:46.3640080' AS DateTime2), NULL, NULL)
INSERT [dbo].[Users] ([Id], [FirstName], [LastName], [Email], [Password], [RoleId], [IsActive], [CreatedAt], [UpdatedAt], [DeletedAt]) VALUES (4, N'Julia', N'Williams', N'juliawilliams@gmail.com', N'$2a$11$hPsl4hFksFlOiMv5bSBT8eJ23/PShHt3ixygI9V.LYqw6nQwDn4Zu', 1, 1, CAST(N'2022-06-25T22:35:46.3640095' AS DateTime2), NULL, NULL)
INSERT [dbo].[Users] ([Id], [FirstName], [LastName], [Email], [Password], [RoleId], [IsActive], [CreatedAt], [UpdatedAt], [DeletedAt]) VALUES (5, N'Michele', N'Roberts', N'micheleroberts@gmail.com', N'$2a$11$hPsl4hFksFlOiMv5bSBT8eJ23/PShHt3ixygI9V.LYqw6nQwDn4Zu', 1, 1, CAST(N'2022-06-25T22:35:46.3640106' AS DateTime2), NULL, NULL)
INSERT [dbo].[Users] ([Id], [FirstName], [LastName], [Email], [Password], [RoleId], [IsActive], [CreatedAt], [UpdatedAt], [DeletedAt]) VALUES (6, N'Anastasija', N'Jokovic', N'anastasija@gmail.com', N'$2a$11$hPsl4hFksFlOiMv5bSBT8eJ23/PShHt3ixygI9V.LYqw6nQwDn4Zu', 2, 1, CAST(N'2022-06-25T22:35:46.3640129' AS DateTime2), NULL, NULL)
SET IDENTITY_INSERT [dbo].[Users] OFF
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AuditLogs_UseCaseName]    Script Date: 6/26/2022 9:31:21 AM ******/
CREATE NONCLUSTERED INDEX [IX_AuditLogs_UseCaseName] ON [dbo].[AuditLogs]
(
	[UseCaseName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Carts_ProductId]    Script Date: 6/26/2022 9:31:21 AM ******/
CREATE NONCLUSTERED INDEX [IX_Carts_ProductId] ON [dbo].[Carts]
(
	[ProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Carts_UserId]    Script Date: 6/26/2022 9:31:21 AM ******/
CREATE NONCLUSTERED INDEX [IX_Carts_UserId] ON [dbo].[Carts]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Categories_CategoryName]    Script Date: 6/26/2022 9:31:21 AM ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_Categories_CategoryName] ON [dbo].[Categories]
(
	[CategoryName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Categories_ParentCategoryId]    Script Date: 6/26/2022 9:31:21 AM ******/
CREATE NONCLUSTERED INDEX [IX_Categories_ParentCategoryId] ON [dbo].[Categories]
(
	[ParentCategoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Images_ProductId]    Script Date: 6/26/2022 9:31:21 AM ******/
CREATE NONCLUSTERED INDEX [IX_Images_ProductId] ON [dbo].[Images]
(
	[ProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_OrderItems_OrderId]    Script Date: 6/26/2022 9:31:21 AM ******/
CREATE NONCLUSTERED INDEX [IX_OrderItems_OrderId] ON [dbo].[OrderItems]
(
	[OrderId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_OrderItems_ProductId]    Script Date: 6/26/2022 9:31:21 AM ******/
CREATE NONCLUSTERED INDEX [IX_OrderItems_ProductId] ON [dbo].[OrderItems]
(
	[ProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Orders_OrderNumber]    Script Date: 6/26/2022 9:31:21 AM ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_Orders_OrderNumber] ON [dbo].[Orders]
(
	[OrderNumber] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Orders_UserId]    Script Date: 6/26/2022 9:31:21 AM ******/
CREATE NONCLUSTERED INDEX [IX_Orders_UserId] ON [dbo].[Orders]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Prices_ProductId]    Script Date: 6/26/2022 9:31:21 AM ******/
CREATE NONCLUSTERED INDEX [IX_Prices_ProductId] ON [dbo].[Prices]
(
	[ProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Products_CategoryId]    Script Date: 6/26/2022 9:31:21 AM ******/
CREATE NONCLUSTERED INDEX [IX_Products_CategoryId] ON [dbo].[Products]
(
	[CategoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Products_ProductName]    Script Date: 6/26/2022 9:31:21 AM ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_Products_ProductName] ON [dbo].[Products]
(
	[ProductName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_ProductSpecifications_ProductId]    Script Date: 6/26/2022 9:31:21 AM ******/
CREATE NONCLUSTERED INDEX [IX_ProductSpecifications_ProductId] ON [dbo].[ProductSpecifications]
(
	[ProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_ProductSpecifications_SpecificationId]    Script Date: 6/26/2022 9:31:21 AM ******/
CREATE NONCLUSTERED INDEX [IX_ProductSpecifications_SpecificationId] ON [dbo].[ProductSpecifications]
(
	[SpecificationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Users_Email]    Script Date: 6/26/2022 9:31:21 AM ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_Users_Email] ON [dbo].[Users]
(
	[Email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Users_FirstName]    Script Date: 6/26/2022 9:31:21 AM ******/
CREATE NONCLUSTERED INDEX [IX_Users_FirstName] ON [dbo].[Users]
(
	[FirstName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Users_LastName]    Script Date: 6/26/2022 9:31:21 AM ******/
CREATE NONCLUSTERED INDEX [IX_Users_LastName] ON [dbo].[Users]
(
	[LastName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Users_RoleId]    Script Date: 6/26/2022 9:31:21 AM ******/
CREATE NONCLUSTERED INDEX [IX_Users_RoleId] ON [dbo].[Users]
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Carts] ADD  DEFAULT (CONVERT([bit],(1))) FOR [IsActive]
GO
ALTER TABLE [dbo].[Categories] ADD  DEFAULT (CONVERT([bit],(1))) FOR [IsActive]
GO
ALTER TABLE [dbo].[ExceptionLogs] ADD  DEFAULT (getdate()) FOR [OccuredAt]
GO
ALTER TABLE [dbo].[Images] ADD  DEFAULT (CONVERT([bit],(1))) FOR [IsActive]
GO
ALTER TABLE [dbo].[Orders] ADD  DEFAULT (CONVERT([bit],(1))) FOR [IsActive]
GO
ALTER TABLE [dbo].[Products] ADD  DEFAULT (CONVERT([bit],(1))) FOR [IsActive]
GO
ALTER TABLE [dbo].[ProductSpecifications] ADD  DEFAULT ('0001-01-01T00:00:00.0000000') FOR [CreatedAt]
GO
ALTER TABLE [dbo].[ProductSpecifications] ADD  DEFAULT (CONVERT([bit],(1))) FOR [IsActive]
GO
ALTER TABLE [dbo].[Roles] ADD  DEFAULT (CONVERT([bit],(1))) FOR [IsActive]
GO
ALTER TABLE [dbo].[Specifications] ADD  DEFAULT (CONVERT([bit],(1))) FOR [IsActive]
GO
ALTER TABLE [dbo].[Users] ADD  DEFAULT (CONVERT([bit],(1))) FOR [IsActive]
GO
ALTER TABLE [dbo].[Carts]  WITH CHECK ADD  CONSTRAINT [FK_Carts_Products_ProductId] FOREIGN KEY([ProductId])
REFERENCES [dbo].[Products] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Carts] CHECK CONSTRAINT [FK_Carts_Products_ProductId]
GO
ALTER TABLE [dbo].[Carts]  WITH CHECK ADD  CONSTRAINT [FK_Carts_Users_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[Users] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Carts] CHECK CONSTRAINT [FK_Carts_Users_UserId]
GO
ALTER TABLE [dbo].[Categories]  WITH CHECK ADD  CONSTRAINT [FK_Categories_Categories_ParentCategoryId] FOREIGN KEY([ParentCategoryId])
REFERENCES [dbo].[Categories] ([Id])
GO
ALTER TABLE [dbo].[Categories] CHECK CONSTRAINT [FK_Categories_Categories_ParentCategoryId]
GO
ALTER TABLE [dbo].[Images]  WITH CHECK ADD  CONSTRAINT [FK_Images_Products_ProductId] FOREIGN KEY([ProductId])
REFERENCES [dbo].[Products] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Images] CHECK CONSTRAINT [FK_Images_Products_ProductId]
GO
ALTER TABLE [dbo].[OrderItems]  WITH CHECK ADD  CONSTRAINT [FK_OrderItems_Orders_OrderId] FOREIGN KEY([OrderId])
REFERENCES [dbo].[Orders] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[OrderItems] CHECK CONSTRAINT [FK_OrderItems_Orders_OrderId]
GO
ALTER TABLE [dbo].[OrderItems]  WITH CHECK ADD  CONSTRAINT [FK_OrderItems_Products_ProductId] FOREIGN KEY([ProductId])
REFERENCES [dbo].[Products] ([Id])
GO
ALTER TABLE [dbo].[OrderItems] CHECK CONSTRAINT [FK_OrderItems_Products_ProductId]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_Users_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[Users] ([Id])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_Users_UserId]
GO
ALTER TABLE [dbo].[Prices]  WITH CHECK ADD  CONSTRAINT [FK_Prices_Products_ProductId] FOREIGN KEY([ProductId])
REFERENCES [dbo].[Products] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Prices] CHECK CONSTRAINT [FK_Prices_Products_ProductId]
GO
ALTER TABLE [dbo].[Products]  WITH CHECK ADD  CONSTRAINT [FK_Products_Categories_CategoryId] FOREIGN KEY([CategoryId])
REFERENCES [dbo].[Categories] ([Id])
GO
ALTER TABLE [dbo].[Products] CHECK CONSTRAINT [FK_Products_Categories_CategoryId]
GO
ALTER TABLE [dbo].[ProductSpecifications]  WITH CHECK ADD  CONSTRAINT [FK_ProductSpecifications_Products_ProductId] FOREIGN KEY([ProductId])
REFERENCES [dbo].[Products] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ProductSpecifications] CHECK CONSTRAINT [FK_ProductSpecifications_Products_ProductId]
GO
ALTER TABLE [dbo].[ProductSpecifications]  WITH CHECK ADD  CONSTRAINT [FK_ProductSpecifications_Specifications_SpecificationId] FOREIGN KEY([SpecificationId])
REFERENCES [dbo].[Specifications] ([Id])
GO
ALTER TABLE [dbo].[ProductSpecifications] CHECK CONSTRAINT [FK_ProductSpecifications_Specifications_SpecificationId]
GO
ALTER TABLE [dbo].[RoleUseCases]  WITH CHECK ADD  CONSTRAINT [FK_RoleUseCases_Roles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[Roles] ([Id])
GO
ALTER TABLE [dbo].[RoleUseCases] CHECK CONSTRAINT [FK_RoleUseCases_Roles_RoleId]
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [FK_Users_Roles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[Roles] ([Id])
GO
ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [FK_Users_Roles_RoleId]
GO
USE [master]
GO
ALTER DATABASE [ASPProject] SET  READ_WRITE 
GO
