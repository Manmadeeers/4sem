/*1 basic work with variables*/

declare @first_chr char  = 'A',
@second_chr varchar = 'B',
@third_datetime datetime ,
@fourth_time time ,
@fivth_int int,
@sixth_tinyint tinyint,
@seventh_smallint smallint,
@eighth_numeric numeric(12,5);

set @third_datetime = getdate();
set @fourth_time = cast(getdate() as time);
set @fivth_int = 155667;

select @sixth_tinyint = 12,
	   @seventh_smallint = 1234,
	   @eighth_numeric = 12345.67890;
	

select
	@first_chr as [Char Value],
	@second_chr as [Varchar Value],
	@third_datetime as [Datetime Value],
	@fourth_time as [Time Value];
	

print 'Fivth int value: ' + cast(@fivth_int as varchar(10));
print 'Sixth tinyint value: ' + cast(@sixth_tinyint as varchar(10));
print 'Seventh smallint value: ' + cast(@seventh_smallint as varchar(12));
print 'Eighth numeric value: ' + cast(@eighth_numeric as varchar(17));

/*2 count auditorium sits*/

use UNIVER;

declare @sum_capacity int  = (select cast(sum(AUDITORIUM.AUDITORIUM_CAPACITY) as int ) from AUDITORIUM)
select @sum_capacity as [Summarized Capacity];
declare	
	@auditoriums_quantity int,
	@avg_calacity real,
	@less_then_avg_auds int,
	@below_avg_percentage decimal(5,2);

if @sum_capacity>200
begin
	select
		@auditoriums_quantity = (select cast(count(*) as int) from AUDITORIUM),
		@avg_calacity = (select avg(AUDITORIUM.AUDITORIUM_CAPACITY) from AUDITORIUM);

	set @less_then_avg_auds = (select count(*) from AUDITORIUM where AUDITORIUM.AUDITORIUM_CAPACITY<@avg_calacity);
	set @below_avg_percentage = cast(@less_then_avg_auds*100/@auditoriums_quantity as numeric(5,2))

	select 
		@auditoriums_quantity as [Auditoriums quantity],
		@avg_calacity as [Average capacity],
		@less_then_avg_auds as [Less then average],
		@below_avg_percentage as [Below Average Percentage %]
	select
		* 
	from 
		AUDITORIUM
end
else
	print 'Summarized capacity: ' + cast(@sum_capacity as varchar(10));


/*3 hell lot of printing*/

print 'Total strings processed: '+ cast(@@rowcount as varchar(20));
print 'SQl Server version: ' + cast(@@version as varchar(1000));
print 'System process identifier: '+ cast(@@spid as varchar(100));
print 'Last error code: ' + cast(@@error as varchar(5));
print 'Server name: ' + cast(@@servername as varchar(30));
print 'Transaction level: '+cast(@@trancount as varchar(3));
print 'Fetch status: '+cast(@@fetch_status as varchar(20));
print 'Procedure level: '+cast(@@nestlevel as varchar(3));


/*4.1 some math*/

declare @t int = 10;
declare @x float = 8.2;
declare @z float; 

if (@t>@x) set @z = sin(@t)*sin(@t)
else if(@t<@x) set @z = 4*(@t+@x)
else if(@t=@x)set @z = 1-exp(@x-2)

select @z as [Counted value]

/*4.2 name split*/

SELECT 
    STUDENT.NAME AS [Full name],
    LEFT( STUDENT.NAME, CHARINDEX(' ',  STUDENT.NAME) - 1) + ' ' +
    SUBSTRING( SUBSTRING( STUDENT.NAME, CHARINDEX(' ',  STUDENT.NAME) + 1,LEN( STUDENT.NAME) - CHARINDEX(' ',  STUDENT.NAME)),1,1) 
	+ '. ' +
    SUBSTRING(SUBSTRING( STUDENT.NAME,CHARINDEX(' ',  STUDENT.NAME, CHARINDEX(' ',  STUDENT.NAME) + 1) + 1,LEN( STUDENT.NAME)),1,1)
	+ '.' AS Initials
FROM STUDENT;

/*4.3 students bd search*/


select
	STUDENT.NAME as [Student's full name],
	 year(getdate())- year(STUDENT.BDAY) as [Student's age]
from
	STUDENT
where
	month(STUDENT.BDAY)=month(getdate())+1
/*4.4 Search for the exam day*/


select
	GROUPS.IDGROUP as [Group],
	day(PROGRESS.PDATE) as [Exam Day],
	PROGRESS.PDATE as [Exam date]
from
	GROUPS inner join STUDENT on GROUPS.IDGROUP = STUDENT.IDGROUP
	inner join PROGRESS on PROGRESS.IDSTUDENT = STUDENT.IDSTUDENT
where
	PROGRESS.SUBJECT like 'ÑÓÁÄ'


/*5 if...else usage with data analysis*/

declare @total_students int  = (select count(*) from STUDENT);
select @total_students as [Total students]

if(@total_students<100)
begin
	declare @average_note float = (select avg(PROGRESS.NOTE) from PROGRESS);
	print 'There is less then 100 students. Average exam note is : ' + cast(@average_note as varchar(10));
end
else
print 'There is 100 students or more. The exact amount of students: ' + cast( @total_students as varchar(10));


/*6 exam marks analysis */

select case
	when PROGRESS.NOTE between 4 and 5 then 'Bad'
	when PROGRESS.NOTE between 5 and 7 then 'Mid'
	when PROGRESS.NOTE between 7 and 9 then 'Good'
	when PROGRESS.NOTE between 9 and 10 then 'Excelent'
	else 'What the hell is that?!'
	end [Description], count(*)[Notes Quantity]
from 
	PROGRESS
group by case
	when PROGRESS.NOTE between 4 and 5 then 'Bad'
	when PROGRESS.NOTE between 5 and 7 then 'Mid'
	when PROGRESS.NOTE between 7 and 9 then 'Good'
	when PROGRESS.NOTE between 9 and 10 then 'Excelent'
	else 'What the hell is that?!'
	end

/*7 temp table creation*/


create table #temp(
id int ,
name varchar(10),
age int
);


set nocount on;
declare @i int = 0;
while @i<10
	begin
	insert #temp values (@i,'John',@i*10);
	set @i = @i+1;
	end

select * from #temp

/*8  return usage*/


declare @F int = 1;

print @F+1;
print @F+2;
print @F+3;
return;
print @F+4


/*9 error handling*/


begin try
	update FACULTY set FACULTY = 'FIT' where FACULTY = 'ÕÒèÒ'
end try

begin catch
	print 'Error number: ' + cast(error_number() as varchar(10));
	print 'Error message: '+cast(error_message() as varchar(1000));
	print 'Line where error occured: ' + cast(error_line() as varchar(3));
	print 'Error procedure: ' + cast(error_procedure() as varchar(100));
	print 'Level of severity: '+ cast(error_severity() as varchar(100));
	print 'Error state: ' + cast(error_state() as varchar(3));
end catch

select * from FACULTY;

