use FIL_MyBase;


/*1*/

exec sp_helpindex 'Products';
exec sp_helpindex 'Orders';
exec sp_helpindex 'Client';



/*2*/


select * from Products;
select count(*) from Products;

create index #products_nonclusteredU on Products(Product_id,Product_name);

drop index #products_nonclusteredU on Products;