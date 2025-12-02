USE [master]
GO
/****** Object:  Database [pharmacie]    Script Date: 01-Dec-25 7:43:40 PM ******/
CREATE DATABASE [pharmacie]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'pharmacie', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\pharmacie.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'pharmacie_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\pharmacie_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [pharmacie] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [pharmacie].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [pharmacie] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [pharmacie] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [pharmacie] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [pharmacie] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [pharmacie] SET ARITHABORT OFF 
GO
ALTER DATABASE [pharmacie] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [pharmacie] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [pharmacie] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [pharmacie] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [pharmacie] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [pharmacie] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [pharmacie] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [pharmacie] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [pharmacie] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [pharmacie] SET  ENABLE_BROKER 
GO
ALTER DATABASE [pharmacie] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [pharmacie] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [pharmacie] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [pharmacie] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [pharmacie] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [pharmacie] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [pharmacie] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [pharmacie] SET RECOVERY FULL 
GO
ALTER DATABASE [pharmacie] SET  MULTI_USER 
GO
ALTER DATABASE [pharmacie] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [pharmacie] SET DB_CHAINING OFF 
GO
ALTER DATABASE [pharmacie] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [pharmacie] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [pharmacie] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [pharmacie] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'pharmacie', N'ON'
GO
ALTER DATABASE [pharmacie] SET QUERY_STORE = ON
GO
ALTER DATABASE [pharmacie] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [pharmacie]
GO
/****** Object:  Table [dbo].[client]    Script Date: 01-Dec-25 7:43:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[client](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[date_creation] [datetime] NULL,
	[date_modification] [datetime] NULL,
	[nom_complet] [varchar](255) NULL,
	[telephone] [varchar](20) NULL,
	[adresse] [varchar](255) NULL,
	[email] [varchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[commande]    Script Date: 01-Dec-25 7:43:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[commande](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[client_id] [int] NOT NULL,
	[utilisateur_id] [int] NOT NULL,
	[date_commande] [datetime] NULL,
	[date_livraison] [datetime] NULL,
	[statut] [varchar](20) NOT NULL,
	[total] [decimal](10, 2) NULL,
	[date_creation] [datetime] NULL,
	[date_modification] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[commande_details]    Script Date: 01-Dec-25 7:43:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[commande_details](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[commande_id] [int] NOT NULL,
	[medicament_id] [int] NOT NULL,
	[quantite] [int] NOT NULL,
	[prix_unitaire] [decimal](10, 2) NOT NULL,
	[subtotal]  AS ([quantite]*[prix_unitaire]) PERSISTED,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[commande_lot_usage]    Script Date: 01-Dec-25 7:43:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[commande_lot_usage](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[commande_details_id] [int] NOT NULL,
	[lot_id] [int] NOT NULL,
	[quantite_utilisee] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[facture]    Script Date: 01-Dec-25 7:43:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[facture](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[commande_id] [int] NOT NULL,
	[date_facture] [datetime] NULL,
	[montant_total] [decimal](10, 2) NOT NULL,
	[statut_paiement] [varchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[fournisseur]    Script Date: 01-Dec-25 7:43:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[fournisseur](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nom] [varchar](150) NOT NULL,
	[telephone] [varchar](20) NULL,
	[adresse] [nvarchar](max) NULL,
	[email] [varchar](100) NULL,
	[date_creation] [datetime] NULL,
	[date_modification] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[lot]    Script Date: 01-Dec-25 7:43:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[lot](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[numero_lot] [varchar](50) NULL,
	[medicament_id] [int] NULL,
	[date_fabrication] [date] NULL,
	[date_peremption] [date] NULL,
	[quantite_stock] [int] NOT NULL,
	[seuil_alerte] [int] NOT NULL,
	[fournisseur_id] [int] NULL,
	[date_creation] [datetime] NULL,
	[date_modification] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[medicament]    Script Date: 01-Dec-25 7:43:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[medicament](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nom] [varchar](150) NOT NULL,
	[reference] [varchar](50) NOT NULL,
	[description] [nvarchar](max) NULL,
	[dosage] [varchar](50) NULL,
	[categorie] [varchar](50) NULL,
	[prix_achat] [decimal](10, 2) NOT NULL,
	[prix_vente] [decimal](10, 2) NOT NULL,
	[date_creation] [datetime] NULL,
	[date_modification] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[reference] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[utilisateur]    Script Date: 01-Dec-25 7:43:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[utilisateur](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nom] [varchar](100) NOT NULL,
	[prenom] [varchar](100) NOT NULL,
	[email] [varchar](100) NOT NULL,
	[mot_de_passe] [varchar](255) NOT NULL,
	[telephone] [varchar](15) NULL,
	[adresse] [nvarchar](max) NULL,
	[date_creation] [datetime] NULL,
	[date_modification] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Index [idx_commande_client]    Script Date: 01-Dec-25 7:43:40 PM ******/
CREATE NONCLUSTERED INDEX [idx_commande_client] ON [dbo].[commande]
(
	[client_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [idx_commande_utilisateur]    Script Date: 01-Dec-25 7:43:40 PM ******/
CREATE NONCLUSTERED INDEX [idx_commande_utilisateur] ON [dbo].[commande]
(
	[utilisateur_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [idx_details_commande]    Script Date: 01-Dec-25 7:43:40 PM ******/
CREATE NONCLUSTERED INDEX [idx_details_commande] ON [dbo].[commande_details]
(
	[commande_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [idx_details_medicament]    Script Date: 01-Dec-25 7:43:40 PM ******/
CREATE NONCLUSTERED INDEX [idx_details_medicament] ON [dbo].[commande_details]
(
	[medicament_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [idx_usage_commande_details]    Script Date: 01-Dec-25 7:43:40 PM ******/
CREATE NONCLUSTERED INDEX [idx_usage_commande_details] ON [dbo].[commande_lot_usage]
(
	[lot_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [idx_usage_lot]    Script Date: 01-Dec-25 7:43:40 PM ******/
CREATE NONCLUSTERED INDEX [idx_usage_lot] ON [dbo].[commande_lot_usage]
(
	[lot_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [idx_lot_fournisseur]    Script Date: 01-Dec-25 7:43:40 PM ******/
CREATE NONCLUSTERED INDEX [idx_lot_fournisseur] ON [dbo].[lot]
(
	[fournisseur_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [idx_lot_medicament]    Script Date: 01-Dec-25 7:43:40 PM ******/
CREATE NONCLUSTERED INDEX [idx_lot_medicament] ON [dbo].[lot]
(
	[medicament_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[client] ADD  DEFAULT (getdate()) FOR [date_creation]
GO
ALTER TABLE [dbo].[client] ADD  DEFAULT (getdate()) FOR [date_modification]
GO
ALTER TABLE [dbo].[commande] ADD  DEFAULT (getdate()) FOR [date_commande]
GO
ALTER TABLE [dbo].[commande] ADD  DEFAULT ((0)) FOR [total]
GO
ALTER TABLE [dbo].[commande] ADD  DEFAULT (getdate()) FOR [date_creation]
GO
ALTER TABLE [dbo].[commande] ADD  DEFAULT (getdate()) FOR [date_modification]
GO
ALTER TABLE [dbo].[facture] ADD  DEFAULT (getdate()) FOR [date_facture]
GO
ALTER TABLE [dbo].[fournisseur] ADD  DEFAULT (getdate()) FOR [date_creation]
GO
ALTER TABLE [dbo].[fournisseur] ADD  DEFAULT (getdate()) FOR [date_modification]
GO
ALTER TABLE [dbo].[lot] ADD  DEFAULT ((0)) FOR [quantite_stock]
GO
ALTER TABLE [dbo].[lot] ADD  DEFAULT ((0)) FOR [seuil_alerte]
GO
ALTER TABLE [dbo].[lot] ADD  DEFAULT (getdate()) FOR [date_creation]
GO
ALTER TABLE [dbo].[lot] ADD  DEFAULT (getdate()) FOR [date_modification]
GO
ALTER TABLE [dbo].[medicament] ADD  DEFAULT (getdate()) FOR [date_creation]
GO
ALTER TABLE [dbo].[medicament] ADD  DEFAULT (getdate()) FOR [date_modification]
GO
ALTER TABLE [dbo].[utilisateur] ADD  DEFAULT (getdate()) FOR [date_creation]
GO
ALTER TABLE [dbo].[utilisateur] ADD  DEFAULT (getdate()) FOR [date_modification]
GO
ALTER TABLE [dbo].[commande]  WITH CHECK ADD FOREIGN KEY([client_id])
REFERENCES [dbo].[client] ([id])
GO
ALTER TABLE [dbo].[commande]  WITH CHECK ADD FOREIGN KEY([utilisateur_id])
REFERENCES [dbo].[utilisateur] ([id])
GO
ALTER TABLE [dbo].[commande_details]  WITH CHECK ADD FOREIGN KEY([commande_id])
REFERENCES [dbo].[commande] ([id])
GO
ALTER TABLE [dbo].[commande_details]  WITH CHECK ADD FOREIGN KEY([medicament_id])
REFERENCES [dbo].[medicament] ([id])
GO
ALTER TABLE [dbo].[commande_lot_usage]  WITH CHECK ADD FOREIGN KEY([commande_details_id])
REFERENCES [dbo].[commande_details] ([id])
GO
ALTER TABLE [dbo].[commande_lot_usage]  WITH CHECK ADD FOREIGN KEY([lot_id])
REFERENCES [dbo].[lot] ([id])
GO
ALTER TABLE [dbo].[facture]  WITH CHECK ADD FOREIGN KEY([commande_id])
REFERENCES [dbo].[commande] ([id])
GO
ALTER TABLE [dbo].[lot]  WITH CHECK ADD FOREIGN KEY([fournisseur_id])
REFERENCES [dbo].[fournisseur] ([id])
GO
ALTER TABLE [dbo].[lot]  WITH CHECK ADD FOREIGN KEY([medicament_id])
REFERENCES [dbo].[medicament] ([id])
GO
ALTER TABLE [dbo].[commande]  WITH CHECK ADD CHECK  (([statut]='annulee' OR [statut]='livree' OR [statut]='en_cours'))
GO
ALTER TABLE [dbo].[facture]  WITH CHECK ADD CHECK  (([statut_paiement]='non_payee' OR [statut_paiement]='payee'))
GO
USE [master]
GO
ALTER DATABASE [pharmacie] SET  READ_WRITE 
GO
