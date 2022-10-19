
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 07/11/2022 14:33:28
-- Generated from EDMX file: C:\Users\Administrator\Documents\Visual Studio 2013\Projects\dynamicField\dynamicField\ModelFirstApp.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Ankit_Practice];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_ModelFirst_TestModelFirst_TestFirst]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ModelFirst_TestFirst] DROP CONSTRAINT [FK_ModelFirst_TestModelFirst_TestFirst];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[ModelFirst_Test]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ModelFirst_Test];
GO
IF OBJECT_ID(N'[dbo].[ModelFirst_TestFirst]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ModelFirst_TestFirst];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'ModelFirst_Test'
CREATE TABLE [dbo].[ModelFirst_Test] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [StudentName] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'ModelFirst_TestFirst'
CREATE TABLE [dbo].[ModelFirst_TestFirst] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [ClassName] nvarchar(max)  NOT NULL,
    [ModelFirst_TestId] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'ModelFirst_Test'
ALTER TABLE [dbo].[ModelFirst_Test]
ADD CONSTRAINT [PK_ModelFirst_Test]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ModelFirst_TestFirst'
ALTER TABLE [dbo].[ModelFirst_TestFirst]
ADD CONSTRAINT [PK_ModelFirst_TestFirst]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [ModelFirst_TestId] in table 'ModelFirst_TestFirst'
ALTER TABLE [dbo].[ModelFirst_TestFirst]
ADD CONSTRAINT [FK_ModelFirst_TestModelFirst_TestFirst]
    FOREIGN KEY ([ModelFirst_TestId])
    REFERENCES [dbo].[ModelFirst_Test]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ModelFirst_TestModelFirst_TestFirst'
CREATE INDEX [IX_FK_ModelFirst_TestModelFirst_TestFirst]
ON [dbo].[ModelFirst_TestFirst]
    ([ModelFirst_TestId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------