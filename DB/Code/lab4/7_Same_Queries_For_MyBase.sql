use FIL_MyBase;

--first
select Client.Client_id, Orders.Order_id from Client inner join Orders on Client.Client_id=Orders.Client_id

--second
select Client.First_name as Name, Client.Last_name as Surename,Orders.Ordered_quantity as Quantity, Products.Product_name as Product from
Client inner join Orders on Client.Client_id=Orders.Client_id inner join Products on Orders.Product_id = Products.Product_id and Products.Product_name like N'Laptop'

--third
select Client.First_name as Name, Client.Last_name as Surename,Products.Product_name as Product,
	case
		when Orders.Ordered_quantity=3 then 'three'
		when Orders.Ordered_quantity=4 then 'four'
		when Orders.Ordered_quantity=5 then 'five'
		when Orders.Ordered_quantity=6 then 'six'
	end as Quantity
from Client inner join Orders on Client.Client_id=Orders.Client_id inner join Products on Orders.Product_id=Products.Product_id
where Orders.Ordered_quantity between 3 and 6
order by Orders.Ordered_quantity desc


--fourth
select Client.First_name as Name, ISNULL(Orders.Client_id,'Nope!') as Ord from Client left outer join Orders on Client.Client_id=Orders.Client_id




select Client.Client_id , Client.First_name as Name,Orders.Order_id as Ord , Orders.Ordered_quantity as Quantity from Client cross join Orders where Client.Client_id=Orders.Client_id