--1
use UNIVER;
go
alter function COUNT_STUDENTS(@faculty varchar(20)) returns int
as
begin
	declare @amount int = (select count(*) from STUDENT inner join GROUPS on STUDENT.IDGROUP = GROUPS.IDGROUP
														inner join FACULTY on GROUPS.FACULTY = FACULTY.FACULTY
											where FACULTY.FACULTY = @faculty); 
	return @amount;
end
go
select dbo.COUNT_STUDENTS('ТОВ') as amount
go
alter function dbo.COUNT_STUDENTS (@faculty varchar(20) = null, @prof varchar(20) = null)
returns int
as 
begin
	declare @amount int = (select count(*) from STUDENT inner join GROUPS on STUDENT.IDGROUP = GROUPS.IDGROUP
														inner join FACULTY on GROUPS.FACULTY = FACULTY.FACULTY
											where FACULTY.FACULTY = @faculty 
											and GROUPS.PROFESSION = isnull(@prof, GROUPS.PROFESSION)); 
	return @amount;
end
go
select dbo.COUNT_STUDENTS('ТОВ', null) as amount

--2
use UNIVER
go

create function FSUBJECT(@p varchar(20)) returns varchar(300)
as
begin
	declare @subjects varchar(300) = 'Дисциплины: ', @subject varchar(20);
	declare subjectCursor cursor local for
	select SUBJECT.SUBJECT from SUBJECT where SUBJECT.PULPIT = @p;
	open subjectCursor;
	fetch subjectCursor into @subject;
	while @@FETCH_STATUS = 0
	begin
		set @subjects = @subjects + @subject + ',';
		fetch subjectCursor into @subject;
	end
	close subjectCursor;
	deallocate subjectCursor;
	return @subjects;
end
go
select distinct Subject.PULPIT, dbo.FSUBJECT(SUBJECT.PULPIT) 
from SUBJECT;
--3
use UNIVER
go
create function FFACPUL(@f varchar(20), @p varchar(20))
returns table	
as return 
	select Faculty.FACULTY, PULPIT.PULPIT 
	from FACULTY left outer join  PULPIT on FACULTY.FACULTY = PULPIT.FACULTY
	where FACULTY.FACULTY = isnull(@f, FACULTY.FACULTY)
	and PULPIT.PULPIT = isnull(@p, PULPIT.PULPIT);
go
select * from  FFACPUL(null, null);
select * from  FFACPUL('ИДиП', null);
select * from  FFACPUL(null, 'ЛМиЛЗ');
--4
use UNIVER
go
create function FCTEACHER (@p varchar(20))
returns int
as 
begin
	declare @tc int = (select count(*) from TEACHER
	where TEACHER.PULPIT = isnull(@p, TEACHER.PULPIT));
	return @tc;
	end
go
select PULPIT.PULPIT, dbo.FCTEACHER(PULPIT.PULPIT) as [Количество преподавателей] from PULPIT;
select dbo.FCTEACHER(null) as [Всего преподавателей]

--6
use UNIVER
go

create function FACULTY_REPORT(@c int) returns @fr table
	                        ( [Факультет] varchar(50), [Количество кафедр] int, [Количество групп]  int, 
	                                                                 [Количество студентов] int, [Количество специальностей] int )
	as begin 
                 declare cc CURSOR static for 
	       select FACULTY from FACULTY 
                                                    where dbo.COUNT_STUDENTS(FACULTY, default) > @c; 
	       declare @f varchar(30);
	       open cc;  
                 fetch cc into @f;
	       while @@fetch_status = 0
	       begin
	            insert @fr values( @f,  dbo.COUNT_PULPITS(@f),
	            dbo.COUNT_GROUPS(@f),   dbo.COUNT_STUDENTS(@f, default),
	            dbo.COUNT_PROFS(@f)   ); 
	            fetch cc into @f;  
	       end;   
                 return; 
	end;
	go
	create function COUNT_PULPITS(@f varchar(20)) returns int
	as
	begin
	declare @amount int = (select count(*) 
	from PULPIT where PULPIT.FACULTY = @f);
	return @amount;
	end
	go
	create function COUNT_GROUPS(@f varchar(20)) returns int
	as 
	begin
		declare @amount int = (select count(*) from GROUPS where GROUPS.FACULTY = @f);
		return @amount;
	end
	go
	create function COUNT_PROFS(@f varchar(20)) returns int
	as 
	begin 
	declare @amount int= (select count(*) from PROFESSION where FACULTY = @f);
	return @amount;
	end 
	go
	select * from FACULTY_REPORT(-1);

