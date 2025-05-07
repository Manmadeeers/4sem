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

create table #tmp_local(
id int,
content varchar(10)
)
set nocount on;

declare @i int = 0;

while @i<1500
	begin
	insert #tmp_local values(floor(rand()*1500)+1,'content'+CAST(@i as varchar(10)));
	set @i = @i+1;
	end;

select * from #tmp_local;


