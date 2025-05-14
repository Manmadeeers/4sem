use UNIVER;

/*1*/
declare @dsc char(10), @output char(100) = ' '
declare dsc_cur cursor 
for select SUBJECT from SUBJECT where SUBJECT.PULPIT = 'ИСиТ'

open dsc_cur
fetch dsc_cur into @dsc
print 'Дисциплины'
while @@FETCH_STATUS = 0
	begin
	set @output = trim(@dsc) + ', ' + @output 
	fetch dsc_cur into @dsc
	end
print @output
close dsc_cur
deallocate dsc_cur


/*2*/

declare @dsc1 char(10), @output1 char(100) = ' '
declare dsc_cur1 cursor local
for select SUBJECT from SUBJECT
open dsc_cur1
fetch dsc_cur1 into @dsc
print 'Дисциплины'
while @@FETCH_STATUS = 0
	begin
	set @output = trim(@dsc1) + ', ' + @output1 
	fetch dsc_cur1 into @dsc1
	end
print @output1
go

declare @dsc1 char(10)
fetch dsc_cur1 into @dsc1
print @dsc1
go
/*3*/

drop table SUBJECT_COPY

select * into SUBJECT_COPY from SUBJECT
select * from SUBJECT_COPY

declare @dsc2 char(10), @output2 char(150) = ' '

declare dsc_cur2 cursor local static
for select PULPIT from dbo.SUBJECT_COPY
open dsc_cur2
print 'Количество строк: ' + cast(@@cursor_rows as varchar(5))
select * from SUBJECT_COPY
delete SUBJECT_COPY where PULPIT = 'ИСиТ'
fetch dsc_cur2 into @dsc2
while @@FETCH_STATUS = 0
	begin
	set @output2 = trim(@dsc2) + ', ' + @output2 
	fetch dsc_cur2 into @dsc2
	end

print @output2
close dsc_cur2
/*4*/


select * from SUBJECT

declare @dsc3 char(10), @name3 nvarchar(100), @pulpit3 char(20)
declare dsc_cur3 cursor local scroll
for select SUBJECT, SUBJECT_NAME, PULPIT from SUBJECT

open dsc_cur3

fetch first from dsc_cur3 into @dsc3, @name3, @pulpit3
print 'Первая строка: ' + @dsc3 + @name3 + '	' + @pulpit3

fetch last from dsc_cur into @dsc3, @name3, @pulpit3
print 'Последная строка: ' + @dsc3 + @name3 + '	' + @pulpit3

fetch absolute 10 from dsc_cur3 into @dsc3, @name3, @pulpit3
print 'absolute 10: ' + @dsc3 + @name3 + '	' + @pulpit3

fetch relative 5 from dsc_cur3 into @dsc3, @name3, @pulpit3
print 'relative 5 : ' + @dsc3 + @name3 + '	' + @pulpit3

fetch next from dsc_cur3 into @dsc3, @name3, @pulpit3
print 'next : ' + @dsc3 + @name3 + '	' + @pulpit3

fetch prior from dsc_cur3 into @dsc3, @name3, @pulpit3
print 'prior : ' + @dsc3 + @name3 + '	' + @pulpit3

close dsc_cur3
/*5*/


drop table SUBJECT_COPY
select * into SUBJECT_COPY from SUBJECT
select * from SUBJECT_COPY

declare @dsc4 char(10), @name4 nvarchar(100), @pulpit4 char(20)
declare dsc_cur4 cursor local
for select SUBJECT, SUBJECT_NAME, PULPIT from SUBJECT_COPY for update

open dsc_cur4
select * from SUBJECT_COPY
fetch from dsc_cu4r into @dsc4, @name4, @pulpit4
DELETE SUBJECT_COPY where current of dsc_cur4
fetch from dsc_cur4 into @dsc4, @name4, @pulpit4
UPDATE SUBJECT_COPY set SUBJECT_NAME = 'test' where current of dsc_cur4
select * from SUBJECT_COPY

close dsc_cur4
/*6*/

select * from PROGRESS
INSERT INTO PROGRESS(SUBJECT, IDSTUDENT, PDATE, NOTE)
VALUES
('ОАиП', 1006, '2013-01-15', 3),
('БД',   1007, '2013-02-17', 2),
('ОАиП', 1008, '2013-03-18', 1),
('БД',   1009, '2013-04-19', 3),
('ОАиП', 1010, '2013-05-20', 2),
('БД',   1011, '2013-06-21', 3),
('ОАиП', 1012, '2013-07-22', 1),
('БД',   1013, '2013-08-23', 2);

delete PROGRESS where IDSTUDENT between 1006 and 1013


--6-1
declare @sname nvarchar(50), @subj nvarchar(50), @mark int
declare prog_stud cursor local
for select s.NAME, p.SUBJECT, p.NOTE from PROGRESS p
join STUDENT s on s.IDSTUDENT = p.IDSTUDENT
join GROUPS g on g.IDGROUP = s.IDGROUP
where p.NOTE < 4

open prog_stud
fetch prog_stud into @sname, @subj, @mark
while @@FETCH_STATUS = 0
begin
	delete PROGRESS where current of prog_stud
	fetch prog_stud into @sname, @subj, @mark
end
close prog_stud
go

--6-2

declare @sname1 nvarchar(50), @subj1 nvarchar(50), @mark1 int
declare prog_stud1 cursor local
for select s.NAME, p.SUBJECT, p.NOTE from PROGRESS p
join STUDENT s on s.IDSTUDENT = p.IDSTUDENT
join GROUPS g on g.IDGROUP = s.IDGROUP
where p.NOTE < 4

open prog_stud1
fetch prog_stud1 into @sname1, @subj1, @mark1
while @@FETCH_STATUS = 0
begin
	update PROGRESS set NOTE = NOTE + 1 where current of prog_stud1
	fetch prog_stud1 into @sname1, @subj1, @mark1
end
close prog_stud1
go
