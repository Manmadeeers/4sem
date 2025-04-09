use FIL_MyBase;

/*1 */
select
	Products.Product_name as Name,
	Orders.Order_id as [Ordered Id],
	Max(Orders.Ordered_quantity)as [Max Ordered]
from
	Products inner join Orders on Products.Product_id = Orders.Product_id
group by
	Products.Product_name, Orders.Order_id

/*2-3*/

select
	*
from
	(select Case when Orders.Ordered_quantity between 1 and 3 then '1-3'
				when Orders.Ordered_quantity between 3 and 6 then '3-6'
				else 'More then 6'
				end[Price Ranges],count(*)[Quantity]
	from Orders group by Orders.Ordered_quantity)as O order by Quantity desc


/*4 */

select
	C.First_name as Name,
	C.Last_name as Surename,
	round(avg(cast(O.Ordered_quantity as float(4))),2)as[Average ordered]
from
	Client C inner join Orders O on C.Client_id = O.Client_id
group by
	C.First_name,C.Last_name



/*5*/

select
	C.First_name as Name,
	C.Last_name as Surename,
	round(avg(cast(O.Ordered_quantity as float(4))),2)as[Average ordered]
from
	Client C inner join Orders O on C.Client_id = O.Client_id inner join Products P on O.Product_id = P.Product_id
where
	P.Product_name like 'Laptop' or P.Product_name like 'Smartphone'
group by
	C.First_name,C.Last_name	



/*6*/
select
	C.First_name as Name,
	C.Last_name as Surename,
	P.Product_name as [Ordered product],
	sum(O.Ordered_quantity)[Sum]
from
	Client C inner join Orders O on C.Client_id = O.Client_id inner join Products P on P.Product_id = O.Product_id
where
	O.Ordered_quantity between 3 and 6
group by
	C.First_name,
	C.Last_name,
	P.Product_name,
	O.Ordered_quantity

/*7*/

select
	Products.Product_name as Product,
	count(Orders.Ordered_quantity)as[Amount ordered]
from
	Orders inner join Products on Orders.Product_id = Products.Product_id
group by
	Products.Product_name,
	Orders.Ordered_quantity
having Orders.Ordered_quantity>=5 and Orders.Ordered_quantity<=6
