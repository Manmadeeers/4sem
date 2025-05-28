use UNIVER;

--1
drop procedure PSUBJECT
go
create procedure PSUBJECT
as 
begin
	declare @amount int = (select count(*) from SUBJECT)
	select SUBJECT [код],
	SUBJECT_NAME [дисциплина],
	PULPIT [кафедра] from SUBJECT
	return @amount
end;

declare @output int = 0
exec @output = PSUBJECT
print 'количество строк=' + cast(@output as varchar(5))

--2
go
alter procedure PSUBJECT @p varchar(20), @c int output
as 
begin
	declare @k int = (select count(*) from SUBJECT)

	select SUBJECT [код],
	SUBJECT_NAME [дисциплина],
	PULPIT [кафедра] from SUBJECT
	where SUBJECT = @p
	set @c = @@ROWCOUNT
	return @k
end;

declare @k1 int = 0, @r int = 0, @p1 varchar(20)
set @p1 = 'БД'
exec @k1 = PSUBJECT @p1, @c = @r output
print 'количество дисциплин всего = ' + cast(@k1 as varchar(3))
print 'количесво строк с дисциплиной ' + cast (@p1 as varchar(3)) + '=' + cast(@r as varchar(3))

--3
go
alter procedure PSUBJECT @p varchar(20)
as begin
	select * from SUBJECT where SUBJECT = @p
	end;

create table #SUBJECT
( Код char(10) primary key,
Дисциплина nvarchar(100),
Кафедра char(20))

insert #SUBJECT exec PSUBJECT @p = 'БД'
insert #SUBJECT exec PSUBJECT @p = 'ООП'

select * from #SUBJECT

--4
go
create procedure SUBJECT_REPORT @p varchar(20)
as 
begin try
	declare @rc int = 0, @sn varchar(20)='', @t varchar(200) = ''
	declare subj_cur cursor local static for
	(select SUBJECT from SUBJECT where SUBJECT.PULPIT = @p)

	if not exists (select SUBJECT from SUBJECT where SUBJECT.PULPIT = @p)
		raiserror('ошибка', 11, 1)

	else 
		open subj_cur
		fetch subj_cur into @sn
		print 'Названия дисциплин:'
		while @@FETCH_STATUS = 0
		begin
		set @t += rtrim(@sn) + ', ';  
        set @rc = @rc + 1;       
         fetch subj_cur into @sn; 
     end;   
	 print @t;        
	 close subj_cur;
     return @rc;
end try  
   begin catch              
        print 'ошибка в параметрах' 
        if error_procedure() is not null   
  print 'имя процедуры: ' + error_procedure();
        return @rc;
   end catch; 

declare @count int;
exec @count = SUBJECT_REPORT @p = 'ИСиТ'
print 'количесво дисциплин=' + cast(@count as varchar(3))

drop procedure SUBJECT_REPORT

select * from SUBJECT

--5
go
create procedure PAUDITORIUM_INSERT
	@a char(20), @n varchar(50), @c int = 0, @t char(10)
	as declare @rc int = 1
	begin try
		insert into AUDITORIUM (AUDITORIUM, AUDITORIUM_NAME, AUDITORIUM_CAPACITY, AUDITORIUM_TYPE)
		values (@a,  @n, @c, @t)
		return @rc;
	end try
	begin catch
		print 'номер ошибки: ' + cast(error_number() as varchar(6))
		print 'сообщение: ' + error_message()
		print 'номер строки: ' + cast(error_line() as varchar(6))
		if ERROR_PROCEDURE() is not null
		print 'имя процедуры: ' + error_procedure()
		return -1;
	end catch

declare @rc1 int;
exec @rc1 = PAUDITORIUM_INSERT @a='413-1',  @n='413-1', @c='15', @t='ЛК-К'
print 'код ошибки: ' + cast(@rc as varchar(3))

drop procedure PAUDITORIUM_INSERT

select * from AUDITORIUM

delete from AUDITORIUM where AUDITORIUM = '413-1'


--6

go

create procedure PAUDITORIUM_INSERTX
    @a char(20), @n varchar(50), @c int = 0, @t char(10), @tn varchar(50)                            
as
begin try 
    set transaction isolation level SERIALIZABLE;          
    begin tran
    insert into AUDITORIUM_TYPE
	values (@t, @tn)
	exec PAUDITORIUM_INSERT @a, @n, @c, @t 
    commit tran;            
end try
begin catch 
    print 'номер ошибки  : ' + cast(error_number() as varchar(6));
    print 'сообщение   : ' + error_message();
    print 'уровень     : ' + cast(error_severity()  as varchar(6));
    print 'матка       : ' + cast(error_state()   as varchar(8));
    print 'номер строки  : ' + cast(error_line()  as varchar(8));
    if error_procedure() is not  null   
                     print 'имя процедуры: ' + error_procedure();
     if @@trancount > 0 rollback tran ; 
     return -1;	  
end catch;

declare @rc int;
exec @rc = PAUDITORIUM_INSERTX @a='322-1',  @n='322-1', @c=15, @t='ЛК', @tn = 'ЛБ'

select * from AUDITORIUM
select * from AUDITORIUM_TYPE
drop procedure PAUDITORIUM_INSERTX

delete from AUDITORIUM where AUDITORIUM = '322-1'
delete from AUDITORIUM_TYPE where AUDITORIUM_TYPE = 'ЛБ' 
