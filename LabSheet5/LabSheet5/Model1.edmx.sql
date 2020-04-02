
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 04/02/2020 18:01:49
-- Generated from EDMX file: C:\Users\Jason\Documents\GitHub\Object-Oriented-Development\LabSheet5\LabSheet5\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [BandandAlbums];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Bands'
CREATE TABLE [dbo].[Bands] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [YearFormed] int  NOT NULL,
    [Members] nvarchar(max)  NOT NULL,
    [BandImage] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Albums'
CREATE TABLE [dbo].[Albums] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Released] datetime  NOT NULL,
    [Sales] int  NOT NULL,
    [AlbumImage] nvarchar(max)  NOT NULL,
    [BandsId] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Bands'
ALTER TABLE [dbo].[Bands]
ADD CONSTRAINT [PK_Bands]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Albums'
ALTER TABLE [dbo].[Albums]
ADD CONSTRAINT [PK_Albums]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [BandsId] in table 'Albums'
ALTER TABLE [dbo].[Albums]
ADD CONSTRAINT [FK_BandsAlbum]
    FOREIGN KEY ([BandsId])
    REFERENCES [dbo].[Bands]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_BandsAlbum'
CREATE INDEX [IX_FK_BandsAlbum]
ON [dbo].[Albums]
    ([BandsId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------