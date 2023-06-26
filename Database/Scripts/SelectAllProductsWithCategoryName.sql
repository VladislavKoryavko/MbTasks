select p.[Name], c.[Name] from [dbo].[ProductCategories] as pc
left join [dbo].[Categories] as c on c.[Id] = pc.[CategoryId]
right join [dbo].[Products] as p on p.[Id] = pc.[ProductId]