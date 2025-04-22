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


/*4 some math*/

