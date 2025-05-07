use UNIVER;
/*1 all usiver indecies and clastered index for tmp_table*/
exec sp_helpindex'AUDITORIUM'
exec sp_helpindex'AUDITORIUM_TYPE'
exec sp_helpindex'SUBJECT'
exec sp_helpindex'STUDENT'
exec sp_helpindex'PROGRESS'
exec sp_helpindex'GROUPS'
exec sp_helpindex'PROFESSION'
exec sp_helpindex'FACULTY'
exec sp_helpindex'PULPIT'
exec sp_helpindex'TEACHER'

create table #tmp_table(
content int
)

declare @iter int = 0;
while @iter<1500
	begin
	insert #tmp_table values(floor(rand()*1500)+1)
	set @iter = @iter+1;
	end;


select * from #tmp_table where content between 200 and 500;

checkpoint;
dbcc dropcleanbuffers;

create clustered index #tmp_cl on #tmp_table(content asc);
drop index #tmp_cl on #tmp_table;

/*2 new tmp local table with non clastered index*/

create table #tmp_2(
id int,
content varchar(10),
something int
)
set nocount on;

declare @i int = 0;

while @i<10000
	begin
	insert #tmp_2 values(floor(rand()*100)+1,'content',@i);
	set @i = @i+1;
	end;



drop table #tmp_2
select * from #tmp_2;
select count(*) from #tmp_2

create index #tmp_nonclusterU on #tmp_local(id,content);

select * from #tmp_local where id>200 and something<100;

select * from #tmp_local order by id,content;

select * from #tmp_local where id=222 and something >1

drop index #tmp_nonclusterU on #tmp_local

/*3 non clustered cover index*/


create table #tmp_3local(
id int,
content varchar(10),
something int
)

declare @i3 int  = 0;
while @i3<11000
	begin
	insert into #tmp_3local values(floor(rand()*100)+1,'content',@i3);
	set @i3 = @i3+1;
	end;

select * from #tmp_3local;
select count(*) from #tmp_3local

create index #tmp_nonclusteredCov on #tmp_3local(id) include (something)

select something from #tmp_3local where id>40

drop index #tmp_nonclusteredCov on #tmp_3local


/*4 */


create table #tmp_4local(
id int,
content varchar(10),
something int
)

declare @i4 int  = 0;

while @i4<11000
	begin
	insert into #tmp_4local values(floor(rand()*100)+1,'content',@i4);
	set @i4 = @i4+1;
	end;

select * from #tmp_4local;
select count(*) from #tmp_4local


select id from #tmp_4local where id between 30 and 70;
select id from #tmp_4local where id>30 and id<71;
select id from #tmp_4local where id=77;


create index #tmp_4where on #tmp_4local(id) where (id>=30 and id<71);

drop index #tmp_4where on #tmp_4local;


/*5*/
use tempdb

create table #tmp_5local(
id int,
content varchar(10),
something int
)

declare @i5 int = 0;

while @i5<11000
	begin
	insert into #tmp_5local values(floor(rand()*100)+1,'content',@i5);
	set @i5 = @i5+1;
	end;
select * from #tmp_5local;
select count(*) from #tmp_5local;

create index #tmp_5index on #tmp_5local(id);

select name[Index],avg_fragmentation_in_percent[Fragmentation %] from sys.dm_db_index_physical_stats(DB_ID(),
OBJECT_ID(N'#tmp_5local'), NULL, NULL, NULL) ss  JOIN sys.indexes ii on ss.object_id = 
ii.object_id and ss.index_id = ii.index_id  WHERE name is not null;

INSERT top(10000) #tmp_5local(id, content) select id, content from #tmp_5local;

select name[Index],avg_fragmentation_in_percent[Fragmentation %] from sys.dm_db_index_physical_stats(DB_ID(),
OBJECT_ID(N'#tmp_5local'), NULL, NULL, NULL) ss  JOIN sys.indexes ii on ss.object_id = 
ii.object_id and ss.index_id = ii.index_id  WHERE name is not null;

/*drop index #tmp_5index on #tmp_5local*/

alter index #tmp_5index on #tmp_5local reorganize
select name[Index],avg_fragmentation_in_percent[Fragmentation %] from sys.dm_db_index_physical_stats(DB_ID(),
OBJECT_ID(N'#tmp_5local'), NULL, NULL, NULL) ss  JOIN sys.indexes ii on ss.object_id = 
ii.object_id and ss.index_id = ii.index_id  WHERE name is not null;

alter index #tmp_5index on #tmp_5local rebuild with(online=off);
select name[Index],avg_fragmentation_in_percent[Fragmentation %] from sys.dm_db_index_physical_stats(DB_ID(),
OBJECT_ID(N'#tmp_5local'), NULL, NULL, NULL) ss  JOIN sys.indexes ii on ss.object_id = 
ii.object_id and ss.index_id = ii.index_id  WHERE name is not null;



drop table #tmp_5local


/*6*/

drop index #tmp_5index on #tmp_5local;

create index #tmp_5index on #tmp_5local(id)with (fillfactor=65);

insert top(50)percent into #tmp_5local(id,content)
select id,content from #tmp_5local

select name[Index],avg_fragmentation_in_percent[Fragmentation %] from sys.dm_db_index_physical_stats(DB_ID(),
OBJECT_ID(N'#tmp_5local'), NULL, NULL, NULL) ss  JOIN sys.indexes ii on ss.object_id = 
ii.object_id and ss.index_id = ii.index_id  WHERE name is not null;
