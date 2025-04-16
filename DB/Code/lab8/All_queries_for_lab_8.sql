use UNIVER;
go


/*1 teacher view*/

/*create view [Teach]
as
select
	TEACHER_NAME [Name],
	GENDER [Gender],
	PULPIT [Department]
from
	TEACHER*/

select * from [Teach]

/*2 Depts quantity view*/


/*create view [Departments quantity]
as
select
	FACULTY_NAME as Faculty,
	count(PULPIT) as Quantity
from
	FACULTY inner join PULPIT on FACULTY.FACULTY = PULPIT.FACULTY
group by
	FACULTY_NAME*/

select * from [Departments quantity]


/*3 Auditoriums view*/




/*create view [Auditoriums]
as
select
	AUDITORIUM_TYPE as Type ,
	AUDITORIUM_NAME as Number
from
	AUDITORIUM
where
	AUDITORIUM.AUDITORIUM_TYPE like 'À '
with check option*/


select * from [Auditoriums]


/*4 Lection auditoriums view*/




/*create view [Lection Auditoriums]
as
select
	AUDITORIUM.AUDITORIUM_TYPE,
	AUDITORIUM.AUDITORIUM_NAME
from 
	AUDITORIUM
where
	AUDITORIUM.AUDITORIUM_TYPE like 'À '*/

select * from [Lection Auditoriums]

/*5 Disciplines view*/


/*create view [Disciplines]
as
select
	top
	150
	SUBJECT.SUBJECT as Code,
	SUBJECT.SUBJECT_NAME as [Subject name],
	SUBJECT.PULPIT as [Department code]
from
	SUBJECT
order by
	SUBJECT_NAME*/



select * from Disciplines

/*6 altered Departments qunatity*/

go
alter view [Departments quantity]
with schemabinding

as
select
	F.FACULTY_NAME as Faculty,
	Count(P.PULPIT) as Quantity
from 
	dbo.FACULTY F join dbo.PULPIT P
on
	F.FACULTY = P.PULPIT
group by
	F.FACULTY_NAME

go
select * from [Departments quantity]


