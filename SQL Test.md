В базе данных MS SQL Server есть продукты и категории. Одному продукту может соответствовать много категорий, в одной категории может быть много продуктов. 
Напишите SQL запрос для выбора всех пар «Имя продукта – Имя категории». 
Если у продукта нет категорий, то его имя все равно должно выводиться.

Допустим в базе у нас есть таблица Products, содержащая Id и Name, и таблица Categories, содержащая Id и Name.
БД так или иначе создаст промежуточную таблицу CategoryProducts. Допустим, она связана по Id.

Select "ProductName", "CategoryName" From Products 
Left Join (CategoryProducts Inner Join Categories on CategoryProducts."CategoryId" = Categories."Id")
on Products."ProductId" = CategoryProducts."ProductId"






