Insert [dbo].[Products] Values ('Кружка'), ('Ложка'), ('Миска'), ('Нож'), ('Чашка'), ('Вилка'), ('Мяч')

Insert [dbo].[Categories] Values ('Посуда'), ('Столовые приборы'), ('Инструменты')

GO

Insert [dbo].[ProductCategories] Values (1, 1), (1, 2),
										(2, 1), (2, 2),
										(3, 1),
										(4, 2), (4, 3),
										(5, 1), (5, 2),
										(6, 1), (6, 2)

GO