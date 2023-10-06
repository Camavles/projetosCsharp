IF OBJECT_ID(N'__EFMigrationsHistory') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

CREATE TABLE [actor] (
    [actor_Id] int NOT NULL IDENTITY,
    [first_name] varchar(45) NOT NULL,
    [last_name] varchar(45) NOT NULL,
    [last_update] datetime NOT NULL,
    CONSTRAINT [PK_actor] PRIMARY KEY ([actor_Id])
);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20230905172101_Inicial', N'2.0.0-rtm-26452');

GO

DECLARE @var0 sysname;
SELECT @var0 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'actor') AND [c].[name] = N'last_update');
IF @var0 IS NOT NULL EXEC(N'ALTER TABLE [actor] DROP CONSTRAINT [' + @var0 + '];');
ALTER TABLE [actor] ALTER COLUMN [last_update] datetime NOT NULL;
ALTER TABLE [actor] ADD DEFAULT (getdate()) FOR [last_update];

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20230905190957_DateTime', N'2.0.0-rtm-26452');

GO

DECLARE @var1 sysname;
SELECT @var1 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'actor') AND [c].[name] = N'last_update');
IF @var1 IS NOT NULL EXEC(N'ALTER TABLE [actor] DROP CONSTRAINT [' + @var1 + '];');
ALTER TABLE [actor] ALTER COLUMN [last_update] datetime NOT NULL;
ALTER TABLE [actor] ADD DEFAULT (getdate()) FOR [last_update];

GO

CREATE TABLE [category] (
    [category_id] int NOT NULL IDENTITY,
    [Nome] varchar(25) NOT NULL,
    [last_update] datetime NOT NULL DEFAULT (getdate()),
    CONSTRAINT [PK_category] PRIMARY KEY ([category_id])
);

GO

CREATE TABLE [language] (
    [language_id] tinyint NOT NULL,
    [name] char(20) NOT NULL,
    [last_update] datetime NOT NULL DEFAULT (getdate()),
    CONSTRAINT [PK_language] PRIMARY KEY ([language_id])
);

GO

CREATE TABLE [film] (
    [film_id] int NOT NULL IDENTITY,
    [release_year] varchar(4) NULL,
    [rating] varchar(10) NULL,
    [description] text NULL,
    [length] smallint NOT NULL,
    [title] varchar(255) NOT NULL,
    [language_id] tinyint NOT NULL,
    [last_update] datetime NOT NULL DEFAULT (getdate()),
    [original_language_id] tinyint NULL,
    CONSTRAINT [PK_film] PRIMARY KEY ([film_id]),
    CONSTRAINT [FK_film_language_language_id] FOREIGN KEY ([language_id]) REFERENCES [language] ([language_id]) ON DELETE CASCADE,
    CONSTRAINT [FK_film_language_original_language_id] FOREIGN KEY ([original_language_id]) REFERENCES [language] ([language_id]) ON DELETE NO ACTION
);

GO

CREATE TABLE [film_actor] (
    [film_id] int NOT NULL,
    [actor_id] int NOT NULL,
    [AtorId] int NOT NULL,
    [FilmeId] int NOT NULL,
    [last_update] datetime NOT NULL DEFAULT (getdate()),
    CONSTRAINT [PK_film_actor] PRIMARY KEY ([film_id], [actor_id]),
    CONSTRAINT [FK_film_actor_actor_actor_id] FOREIGN KEY ([actor_id]) REFERENCES [actor] ([actor_Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_film_actor_film_film_id] FOREIGN KEY ([film_id]) REFERENCES [film] ([film_id]) ON DELETE CASCADE
);

GO

CREATE TABLE [film_category] (
    [film_id] int NOT NULL,
    [category_id] int NOT NULL,
    [CategoriaId] int NOT NULL,
    [FilmeId] int NOT NULL,
    [last_update] datetime NOT NULL DEFAULT (getdate()),
    CONSTRAINT [PK_film_category] PRIMARY KEY ([film_id], [category_id]),
    CONSTRAINT [FK_film_category_category_category_id] FOREIGN KEY ([category_id]) REFERENCES [category] ([category_id]) ON DELETE CASCADE,
    CONSTRAINT [FK_film_category_film_film_id] FOREIGN KEY ([film_id]) REFERENCES [film] ([film_id]) ON DELETE CASCADE
);

GO

CREATE INDEX [IX_film_language_id] ON [film] ([language_id]);

GO

CREATE INDEX [IX_film_original_language_id] ON [film] ([original_language_id]);

GO

CREATE INDEX [IX_film_actor_actor_id] ON [film_actor] ([actor_id]);

GO

CREATE INDEX [IX_film_category_category_id] ON [film_category] ([category_id]);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20230907133354_Filme_Categoria_Idioma', N'2.0.0-rtm-26452');

GO

DECLARE @var2 sysname;
SELECT @var2 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'language') AND [c].[name] = N'last_update');
IF @var2 IS NOT NULL EXEC(N'ALTER TABLE [language] DROP CONSTRAINT [' + @var2 + '];');
ALTER TABLE [language] ALTER COLUMN [last_update] datetime NOT NULL;
ALTER TABLE [language] ADD DEFAULT (getdate()) FOR [last_update];

GO

DECLARE @var3 sysname;
SELECT @var3 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'film_category') AND [c].[name] = N'last_update');
IF @var3 IS NOT NULL EXEC(N'ALTER TABLE [film_category] DROP CONSTRAINT [' + @var3 + '];');
ALTER TABLE [film_category] ALTER COLUMN [last_update] datetime NOT NULL;
ALTER TABLE [film_category] ADD DEFAULT (getdate()) FOR [last_update];

GO

DECLARE @var4 sysname;
SELECT @var4 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'film_actor') AND [c].[name] = N'last_update');
IF @var4 IS NOT NULL EXEC(N'ALTER TABLE [film_actor] DROP CONSTRAINT [' + @var4 + '];');
ALTER TABLE [film_actor] ALTER COLUMN [last_update] datetime NOT NULL;
ALTER TABLE [film_actor] ADD DEFAULT (getdate()) FOR [last_update];

GO

DECLARE @var5 sysname;
SELECT @var5 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'film') AND [c].[name] = N'last_update');
IF @var5 IS NOT NULL EXEC(N'ALTER TABLE [film] DROP CONSTRAINT [' + @var5 + '];');
ALTER TABLE [film] ALTER COLUMN [last_update] datetime NOT NULL;
ALTER TABLE [film] ADD DEFAULT (getdate()) FOR [last_update];

GO

DECLARE @var6 sysname;
SELECT @var6 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'category') AND [c].[name] = N'last_update');
IF @var6 IS NOT NULL EXEC(N'ALTER TABLE [category] DROP CONSTRAINT [' + @var6 + '];');
ALTER TABLE [category] ALTER COLUMN [last_update] datetime NOT NULL;
ALTER TABLE [category] ADD DEFAULT (getdate()) FOR [last_update];

GO

DECLARE @var7 sysname;
SELECT @var7 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'actor') AND [c].[name] = N'last_update');
IF @var7 IS NOT NULL EXEC(N'ALTER TABLE [actor] DROP CONSTRAINT [' + @var7 + '];');
ALTER TABLE [actor] ALTER COLUMN [last_update] datetime NOT NULL;
ALTER TABLE [actor] ADD DEFAULT (getdate()) FOR [last_update];

GO

CREATE INDEX [idx_actor_last_name] ON [actor] ([last_name]);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20230907135759_Indice_Ator', N'2.0.0-rtm-26452');

GO

DECLARE @var8 sysname;
SELECT @var8 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'language') AND [c].[name] = N'last_update');
IF @var8 IS NOT NULL EXEC(N'ALTER TABLE [language] DROP CONSTRAINT [' + @var8 + '];');
ALTER TABLE [language] ALTER COLUMN [last_update] datetime NOT NULL;
ALTER TABLE [language] ADD DEFAULT (getdate()) FOR [last_update];

GO

DECLARE @var9 sysname;
SELECT @var9 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'film_category') AND [c].[name] = N'last_update');
IF @var9 IS NOT NULL EXEC(N'ALTER TABLE [film_category] DROP CONSTRAINT [' + @var9 + '];');
ALTER TABLE [film_category] ALTER COLUMN [last_update] datetime NOT NULL;
ALTER TABLE [film_category] ADD DEFAULT (getdate()) FOR [last_update];

GO

DECLARE @var10 sysname;
SELECT @var10 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'film_actor') AND [c].[name] = N'last_update');
IF @var10 IS NOT NULL EXEC(N'ALTER TABLE [film_actor] DROP CONSTRAINT [' + @var10 + '];');
ALTER TABLE [film_actor] ALTER COLUMN [last_update] datetime NOT NULL;
ALTER TABLE [film_actor] ADD DEFAULT (getdate()) FOR [last_update];

GO

DECLARE @var11 sysname;
SELECT @var11 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'film') AND [c].[name] = N'last_update');
IF @var11 IS NOT NULL EXEC(N'ALTER TABLE [film] DROP CONSTRAINT [' + @var11 + '];');
ALTER TABLE [film] ALTER COLUMN [last_update] datetime NOT NULL;
ALTER TABLE [film] ADD DEFAULT (getdate()) FOR [last_update];

GO

DECLARE @var12 sysname;
SELECT @var12 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'category') AND [c].[name] = N'last_update');
IF @var12 IS NOT NULL EXEC(N'ALTER TABLE [category] DROP CONSTRAINT [' + @var12 + '];');
ALTER TABLE [category] ALTER COLUMN [last_update] datetime NOT NULL;
ALTER TABLE [category] ADD DEFAULT (getdate()) FOR [last_update];

GO

DECLARE @var13 sysname;
SELECT @var13 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'actor') AND [c].[name] = N'last_update');
IF @var13 IS NOT NULL EXEC(N'ALTER TABLE [actor] DROP CONSTRAINT [' + @var13 + '];');
ALTER TABLE [actor] ALTER COLUMN [last_update] datetime NOT NULL;
ALTER TABLE [actor] ADD DEFAULT (getdate()) FOR [last_update];

GO

ALTER TABLE [actor] ADD CONSTRAINT [AK_actor_first_name_last_name] UNIQUE ([first_name], [last_name]);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20230907140758_Unique_Restricao_Ator', N'2.0.0-rtm-26452');

GO

DECLARE @var14 sysname;
SELECT @var14 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'language') AND [c].[name] = N'last_update');
IF @var14 IS NOT NULL EXEC(N'ALTER TABLE [language] DROP CONSTRAINT [' + @var14 + '];');
ALTER TABLE [language] ALTER COLUMN [last_update] datetime NOT NULL;
ALTER TABLE [language] ADD DEFAULT (getdate()) FOR [last_update];

GO

DECLARE @var15 sysname;
SELECT @var15 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'film_category') AND [c].[name] = N'last_update');
IF @var15 IS NOT NULL EXEC(N'ALTER TABLE [film_category] DROP CONSTRAINT [' + @var15 + '];');
ALTER TABLE [film_category] ALTER COLUMN [last_update] datetime NOT NULL;
ALTER TABLE [film_category] ADD DEFAULT (getdate()) FOR [last_update];

GO

DECLARE @var16 sysname;
SELECT @var16 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'film_actor') AND [c].[name] = N'last_update');
IF @var16 IS NOT NULL EXEC(N'ALTER TABLE [film_actor] DROP CONSTRAINT [' + @var16 + '];');
ALTER TABLE [film_actor] ALTER COLUMN [last_update] datetime NOT NULL;
ALTER TABLE [film_actor] ADD DEFAULT (getdate()) FOR [last_update];

GO

DECLARE @var17 sysname;
SELECT @var17 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'film') AND [c].[name] = N'last_update');
IF @var17 IS NOT NULL EXEC(N'ALTER TABLE [film] DROP CONSTRAINT [' + @var17 + '];');
ALTER TABLE [film] ALTER COLUMN [last_update] datetime NOT NULL;
ALTER TABLE [film] ADD DEFAULT (getdate()) FOR [last_update];

GO

DECLARE @var18 sysname;
SELECT @var18 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'category') AND [c].[name] = N'last_update');
IF @var18 IS NOT NULL EXEC(N'ALTER TABLE [category] DROP CONSTRAINT [' + @var18 + '];');
ALTER TABLE [category] ALTER COLUMN [last_update] datetime NOT NULL;
ALTER TABLE [category] ADD DEFAULT (getdate()) FOR [last_update];

GO

DECLARE @var19 sysname;
SELECT @var19 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'actor') AND [c].[name] = N'last_update');
IF @var19 IS NOT NULL EXEC(N'ALTER TABLE [actor] DROP CONSTRAINT [' + @var19 + '];');
ALTER TABLE [actor] ALTER COLUMN [last_update] datetime NOT NULL;
ALTER TABLE [actor] ADD DEFAULT (getdate()) FOR [last_update];

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20230907164848_Alter_DateTime', N'2.0.0-rtm-26452');

GO

ALTER TABLE [dbo].[film] 
                ADD CONSTRAINT [check_rating] 
                        CHECK ([rating]='NC-17' 
                        OR [rating]='R' 
                        OR [rating]='PG-13' 
                        OR [rating]='PG' 
                        OR [rating]='G')

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20230907165026_Filme_Restricao_Check', N'2.0.0-rtm-26452');

GO

DECLARE @var20 sysname;
SELECT @var20 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'language') AND [c].[name] = N'last_update');
IF @var20 IS NOT NULL EXEC(N'ALTER TABLE [language] DROP CONSTRAINT [' + @var20 + '];');
ALTER TABLE [language] ALTER COLUMN [last_update] datetime NOT NULL;
ALTER TABLE [language] ADD DEFAULT (getdate()) FOR [last_update];

GO

DECLARE @var21 sysname;
SELECT @var21 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'film_category') AND [c].[name] = N'last_update');
IF @var21 IS NOT NULL EXEC(N'ALTER TABLE [film_category] DROP CONSTRAINT [' + @var21 + '];');
ALTER TABLE [film_category] ALTER COLUMN [last_update] datetime NOT NULL;
ALTER TABLE [film_category] ADD DEFAULT (getdate()) FOR [last_update];

GO

DECLARE @var22 sysname;
SELECT @var22 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'film_actor') AND [c].[name] = N'last_update');
IF @var22 IS NOT NULL EXEC(N'ALTER TABLE [film_actor] DROP CONSTRAINT [' + @var22 + '];');
ALTER TABLE [film_actor] ALTER COLUMN [last_update] datetime NOT NULL;
ALTER TABLE [film_actor] ADD DEFAULT (getdate()) FOR [last_update];

GO

DECLARE @var23 sysname;
SELECT @var23 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'film') AND [c].[name] = N'last_update');
IF @var23 IS NOT NULL EXEC(N'ALTER TABLE [film] DROP CONSTRAINT [' + @var23 + '];');
ALTER TABLE [film] ALTER COLUMN [last_update] datetime NOT NULL;
ALTER TABLE [film] ADD DEFAULT (getdate()) FOR [last_update];

GO

DECLARE @var24 sysname;
SELECT @var24 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'category') AND [c].[name] = N'last_update');
IF @var24 IS NOT NULL EXEC(N'ALTER TABLE [category] DROP CONSTRAINT [' + @var24 + '];');
ALTER TABLE [category] ALTER COLUMN [last_update] datetime NOT NULL;
ALTER TABLE [category] ADD DEFAULT (getdate()) FOR [last_update];

GO

DECLARE @var25 sysname;
SELECT @var25 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'actor') AND [c].[name] = N'last_update');
IF @var25 IS NOT NULL EXEC(N'ALTER TABLE [actor] DROP CONSTRAINT [' + @var25 + '];');
ALTER TABLE [actor] ALTER COLUMN [last_update] datetime NOT NULL;
ALTER TABLE [actor] ADD DEFAULT (getdate()) FOR [last_update];

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20230912135507_DateTime_Change', N'2.0.0-rtm-26452');

GO

DECLARE @var26 sysname;
SELECT @var26 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'language') AND [c].[name] = N'last_update');
IF @var26 IS NOT NULL EXEC(N'ALTER TABLE [language] DROP CONSTRAINT [' + @var26 + '];');
ALTER TABLE [language] ALTER COLUMN [last_update] datetime NOT NULL;
ALTER TABLE [language] ADD DEFAULT (getdate()) FOR [last_update];

GO

DECLARE @var27 sysname;
SELECT @var27 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'film_category') AND [c].[name] = N'last_update');
IF @var27 IS NOT NULL EXEC(N'ALTER TABLE [film_category] DROP CONSTRAINT [' + @var27 + '];');
ALTER TABLE [film_category] ALTER COLUMN [last_update] datetime NOT NULL;
ALTER TABLE [film_category] ADD DEFAULT (getdate()) FOR [last_update];

GO

DECLARE @var28 sysname;
SELECT @var28 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'film_actor') AND [c].[name] = N'last_update');
IF @var28 IS NOT NULL EXEC(N'ALTER TABLE [film_actor] DROP CONSTRAINT [' + @var28 + '];');
ALTER TABLE [film_actor] ALTER COLUMN [last_update] datetime NOT NULL;
ALTER TABLE [film_actor] ADD DEFAULT (getdate()) FOR [last_update];

GO

DECLARE @var29 sysname;
SELECT @var29 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'film') AND [c].[name] = N'last_update');
IF @var29 IS NOT NULL EXEC(N'ALTER TABLE [film] DROP CONSTRAINT [' + @var29 + '];');
ALTER TABLE [film] ALTER COLUMN [last_update] datetime NOT NULL;
ALTER TABLE [film] ADD DEFAULT (getdate()) FOR [last_update];

GO

DECLARE @var30 sysname;
SELECT @var30 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'category') AND [c].[name] = N'last_update');
IF @var30 IS NOT NULL EXEC(N'ALTER TABLE [category] DROP CONSTRAINT [' + @var30 + '];');
ALTER TABLE [category] ALTER COLUMN [last_update] datetime NOT NULL;
ALTER TABLE [category] ADD DEFAULT (getdate()) FOR [last_update];

GO

DECLARE @var31 sysname;
SELECT @var31 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'actor') AND [c].[name] = N'last_update');
IF @var31 IS NOT NULL EXEC(N'ALTER TABLE [actor] DROP CONSTRAINT [' + @var31 + '];');
ALTER TABLE [actor] ALTER COLUMN [last_update] datetime NOT NULL;
ALTER TABLE [actor] ADD DEFAULT (getdate()) FOR [last_update];

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20230912140230_DateTime_Teste', N'2.0.0-rtm-26452');

GO

