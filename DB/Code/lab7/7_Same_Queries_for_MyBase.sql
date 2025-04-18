use FIL_MyBase;

/*1 rollup*/

select
	Pr.Product_name as Product,
	Pr.Price as Price,
	Pr.Product_id as Id,
	sum(Pr.Stock_quantity) as Quantity
from 
	Products Pr
where 
	Pr.Product_name like 'Laptop'
group by rollup( Pr.Product_name,Pr.Price,Pr.Product_id )

/*2 cube*/

select
	Pr.Product_name as Product,
	Pr.Price as Price,
	Pr.Product_id as Id,
	sum(Pr.Stock_quantity) as Quantity
from 
	Products Pr
where 
	Pr.Product_name like 'Laptop'
group by cube( Pr.Product_name,Pr.Price,Pr.Product_id )

/*3 union of two selects*/

select
	Pr.Product_name as Product,
	SUM(Pr.Stock_quantity) as Quantity
from 
	Products Pr
where
	Pr.Product_name like 'Laptop'
group by
	Pr.Product_name
union
select
	Pr.Product_name as Product,
	SUM(Pr.Stock_quantity) as Quantity
from 
	Products Pr
where
	Pr.Product_name like 'Smartphone'
group by
	Pr.Product_name

/*4 same as 3 but with intersect*/

select
	Pr.Product_name as Product,
	SUM(Pr.Stock_quantity) as Quantity
from 
	Products Pr
where
	Pr.Product_name like 'Laptop'
group by
	Pr.Product_name
intersect
select
	Pr.Product_name as Product,
	SUM(Pr.Stock_quantity) as Quantity
from 
	Products Pr
where
	Pr.Product_name like 'Smartphone'
group by
	Pr.Product_name

/*5 same as 3 but with except*/

select
	Pr.Product_name as Product,
	SUM(Pr.Stock_quantity) as Quantity
from 
	Products Pr
where
	Pr.Product_name like 'Laptop'
group by
	Pr.Product_name
except
select
	Pr.Product_name as Product,
	SUM(Pr.Stock_quantity) as Quantity
from 
	Products Pr
where
	Pr.Product_name like 'Smartphone'
group by
	Pr.Product_name