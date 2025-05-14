use FIL_MyBase;


/*1*/

declare @crs char(20);
declare @tmp char(200) = '';
declare ClntName cursor for select First_name from Client;
open ClntName;
fetch ClntName into @crs;
print 'Client';
while @@FETCH_STATUS = 0
	begin
	set @tmp = RTRIM(@crs)+','+@tmp;
	fetch ClntName into @crs;
	end;
	print @tmp;
close ClntName;


/*2*/

declare Prod cursor local for select Product_name,Price from Products;
declare @tmp1 char(20);
declare @prc decimal;
open Prod;
fetch Prod into @tmp1,@prc;
print '1.'+@tmp1+cast(@prc as varchar(5));
go
declare @tmp1 char(20);
declare @prc decimal;
open Prod;
fetch Prod into @tmp1,@prc;
print '2.'+@tmp1+cast(@prc as varchar(5));

--global cursor
declare Goods cursor global for select Product_name,Price from Products;
declare @tmp2 char(20);
declare @prc2 decimal;
open Goods;
fetch Goods into @tmp2,@prc2;
print '1.'+@tmp2+cast(@prc2 as varchar(5));
go
declare @tmp2 char(20);
declare @prc2 decimal;
open Goods;
fetch Goods into @tmp2,@prc2;
print '2.'+@tmp2+cast(@prc2 as varchar(5));

--3


select * into Client_Copy from Client;
select * from Client_Copy;

declare @tmp3 char(20);
declare @output3 char(300) = '';

declare CopyCursor cursor local static for select Second_name from Client_Copy;

open CopyCursor;
fetch CopyCursor into @tmp3;


