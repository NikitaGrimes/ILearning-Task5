IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230125124559_InitialDb')
BEGIN
    CREATE TABLE [Cities] (
        [Id] int NOT NULL IDENTITY,
        [City] nvarchar(max) NOT NULL,
        [Locale] nvarchar(max) NOT NULL,
        CONSTRAINT [PK_Cities] PRIMARY KEY ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230125124559_InitialDb')
BEGIN
    CREATE TABLE [CityTypes] (
        [Id] int NOT NULL IDENTITY,
        [CityType] nvarchar(max) NOT NULL,
        [Locale] nvarchar(max) NOT NULL,
        CONSTRAINT [PK_CityTypes] PRIMARY KEY ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230125124559_InitialDb')
BEGIN
    CREATE TABLE [Identifiers] (
        [Id] int NOT NULL IDENTITY,
        [Identifier] nvarchar(max) NOT NULL,
        [Locale] nvarchar(max) NOT NULL,
        CONSTRAINT [PK_Identifiers] PRIMARY KEY ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230125124559_InitialDb')
BEGIN
    CREATE TABLE [Names] (
        [Id] int NOT NULL IDENTITY,
        [Name] nvarchar(max) NOT NULL,
        [Locale] nvarchar(max) NOT NULL,
        CONSTRAINT [PK_Names] PRIMARY KEY ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230125124559_InitialDb')
BEGIN
    CREATE TABLE [PhoneTypes] (
        [Id] int NOT NULL IDENTITY,
        [PhoneType] nvarchar(max) NOT NULL,
        [PhoneLenght] int NOT NULL,
        [Locale] nvarchar(max) NOT NULL,
        CONSTRAINT [PK_PhoneTypes] PRIMARY KEY ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230125124559_InitialDb')
BEGIN
    CREATE TABLE [Regions] (
        [Id] int NOT NULL IDENTITY,
        [Region] nvarchar(max) NOT NULL,
        [Locale] nvarchar(max) NOT NULL,
        CONSTRAINT [PK_Regions] PRIMARY KEY ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230125124559_InitialDb')
BEGIN
    CREATE TABLE [Streets] (
        [Id] int NOT NULL IDENTITY,
        [Street] nvarchar(max) NOT NULL,
        [Locale] nvarchar(max) NOT NULL,
        CONSTRAINT [PK_Streets] PRIMARY KEY ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230125124559_InitialDb')
BEGIN
    CREATE TABLE [StreetTypes] (
        [Id] int NOT NULL IDENTITY,
        [StreetType] nvarchar(max) NOT NULL,
        [Locale] nvarchar(max) NOT NULL,
        CONSTRAINT [PK_StreetTypes] PRIMARY KEY ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230125124559_InitialDb')
BEGIN
    CREATE TABLE [Surnames] (
        [Id] int NOT NULL IDENTITY,
        [Surname] nvarchar(max) NOT NULL,
        [Locale] nvarchar(max) NOT NULL,
        CONSTRAINT [PK_Surnames] PRIMARY KEY ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230125124559_InitialDb')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20230125124559_InitialDb', N'7.0.2');
END;
GO

COMMIT;
GO

