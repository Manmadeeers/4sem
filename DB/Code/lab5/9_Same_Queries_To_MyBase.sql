use FIL_MyBase;
/*
select * from Client;
select * from Orders;
select * from Products;*/

/*first query*/
select Orders.Order_id as Id from Orders where Orders.Product_id in(select Product_id from Products where(Products.Product_name like 'Laptop'))

/*second query*/
select Orders.Order_id as Id from Orders inner join Products on Orders.Product_id = Products.Product_id where Products.Product_id
in (select Products.Product_id from Products where Products.Product_name like 'Laptop')


/*third query*/

select Orders.Order_id as Id from Orders inner join Products on Orders.Product_id = Products.Product_id where Products.Product_name like 'Laptop'

/*fourth query*/

select Order_id as Id, Ordered_quantity as Quantity from Orders o where o.Ordered_quantity 
= (select top(1) Ordered_quantity from Orders oo where o.Order_id = oo.Order_id) order by Ordered_quantity

/*fivth query*/

select Client.First_name as Name, Client.Client_id as Id from Client where not exists(select* from Orders where Orders.Client_id = Client.Client_id)

/*sixth query*/
select top 1
	(select avg(Products.Price) from Products where Products.Product_name like 'Laptop')[Laptop],
	(select avg(Products.Price)from Products where Products.Product_name like 'Printer')[Printer]
from Products


/* seventh query*/

select Products.Product_name as Name,Products.Price as Price from Products where Products.Price
>=all(select Products.Price from Products where Products.Product_name like 'Laptop')

/*eights query*/

select Products.Product_name as Name, Products.Price as Prie from Products where Products.Price>=any(select Products.Price from Products where Products.Product_name like 'Laptop')

