use FIL_MyBase;

/*1 product view */

/*go
create view [Product view]
as
select
	Products.Product_name as Product,
	Products.Product_id as Id,
	Products.Stock_quantity as Quantity
from
	Products
go*/

select * from [Product view]


/*2 Orders quantity view*/

/*go
create view [Orders quantity]
as 
select
	Products.Product_name as Product,
	Count(Orders.Order_id) as [Quantity]
from
	Products inner join Orders on Products.Product_id = Orders.Product_id
group by
	Products.Product_name

go*/
select * from [Orders quantity]

/*3 Order view*/

/*go
create view [Orders view]
as
select
	Orders.Order_id as [Order id],
	Orders.Client_id as [Client id],
	Orders.Product_id as [Product id],
	Orders.Ordered_quantity as [Quantity]
from
	Orders
go*/
select * from [Orders view]

/*4 Client view */

/*go
create view [Client view]
as 
select
	Client.Client_id as Id,
	Client.First_name as Name,
	Client.Last_name as Surename,
	Client.Email as Email
from
	Client
go*/
select * from [Client view]

/*5 altered Client view*/

go
alter view [Client view]
with schemabinding
as
select
	C.Client_id as Id,
	C.First_name as Name,
	C.Last_name as Surename,
	C.Phone as [Phone number]
from dbo.Client C
go
select * from [Client view]