
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 10/21/2017 23:23:34
-- Generated from EDMX file: F:\DEN\Ejercicio 4 - GIT -Tienda\Datos\TiendaModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [TiendaElectronica];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_Venta_Producto1]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Venta] DROP CONSTRAINT [FK_Venta_Producto1];
GO
IF OBJECT_ID(N'[dbo].[FK_Venta_Usuario1]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Venta] DROP CONSTRAINT [FK_Venta_Usuario1];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Producto]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Producto];
GO
IF OBJECT_ID(N'[dbo].[Usuario]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Usuario];
GO
IF OBJECT_ID(N'[dbo].[Venta]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Venta];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Producto'
CREATE TABLE [dbo].[Producto] (
    [codigo] int IDENTITY(1,1) NOT NULL,
    [marca] nvarchar(50)  NOT NULL,
    [modelo] nvarchar(50)  NOT NULL,
    [tipo] nvarchar(50)  NOT NULL,
    [precio] int  NOT NULL
);
GO

-- Creating table 'Usuario'
CREATE TABLE [dbo].[Usuario] (
    [usuario1] nvarchar(30)  NOT NULL,
    [contra] nvarchar(30)  NOT NULL
);
GO

-- Creating table 'Venta'
CREATE TABLE [dbo].[Venta] (
    [codigo] int IDENTITY(1,1) NOT NULL,
    [cantidad] int  NOT NULL,
    [fecha] datetime  NOT NULL,
    [cod_producto] int  NOT NULL,
    [usr_venta] nvarchar(30)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [codigo] in table 'Producto'
ALTER TABLE [dbo].[Producto]
ADD CONSTRAINT [PK_Producto]
    PRIMARY KEY CLUSTERED ([codigo] ASC);
GO

-- Creating primary key on [usuario1] in table 'Usuario'
ALTER TABLE [dbo].[Usuario]
ADD CONSTRAINT [PK_Usuario]
    PRIMARY KEY CLUSTERED ([usuario1] ASC);
GO

-- Creating primary key on [codigo] in table 'Venta'
ALTER TABLE [dbo].[Venta]
ADD CONSTRAINT [PK_Venta]
    PRIMARY KEY CLUSTERED ([codigo] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [cod_producto] in table 'Venta'
ALTER TABLE [dbo].[Venta]
ADD CONSTRAINT [FK_Venta_Producto1]
    FOREIGN KEY ([cod_producto])
    REFERENCES [dbo].[Producto]
        ([codigo])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Venta_Producto1'
CREATE INDEX [IX_FK_Venta_Producto1]
ON [dbo].[Venta]
    ([cod_producto]);
GO

-- Creating foreign key on [usr_venta] in table 'Venta'
ALTER TABLE [dbo].[Venta]
ADD CONSTRAINT [FK_Venta_Usuario1]
    FOREIGN KEY ([usr_venta])
    REFERENCES [dbo].[Usuario]
        ([usuario1])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Venta_Usuario1'
CREATE INDEX [IX_FK_Venta_Usuario1]
ON [dbo].[Venta]
    ([usr_venta]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------