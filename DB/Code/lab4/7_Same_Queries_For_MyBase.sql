use FIL_MyBase;

select Client.First_name as Name, Client.Last_name as Surename, Orders.Ordered_quantity as Quantity , Products.Product_name as Product from
Client inner join Orders on Client.Client_id=Orders.Client_id inner join Products on Orders.Product_id=Products.Product_id



select Client.First_name as Name, Client.Last_name as Surename, Orders.Ordered_quantity as Quantity, Orders.Sale_date as Date, Products.Product_name as Product
from Client inner join Orders on Client.Client_id=Orders.Client_id inner join Products on Orders.Product_id=Products.Product_id where Client.Has_Discount=1
order by Date desc



