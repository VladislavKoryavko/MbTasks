CREATE TABLE [dbo].[ProductCategories]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY,
	[ProductId] INT NOT NULL,
	[CategoryId] INT NOT NULL

	CONSTRAINT FK_ProductCategories_Products FOREIGN KEY ([ProductId]) REFERENCES Products ([Id])
	CONSTRAINT FK_ProductCategories_Categories FOREIGN KEY ([CategoryId]) REFERENCES Categories ([Id])
)