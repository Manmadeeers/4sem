use UNIVER;

/*1 Average notes for TOV
it should be empty, it's OK*/

select
	F.Faculty_name as Faculty,
	P.Profession as Profession,
	PR.SUBJECT as Subject,
	round(avg(cast(PR.NOTE as float(4))),2)as [Average Note]
from
	FACULTY F inner join PROFESSION P on F.FACULTY = P.FACULTY
	inner join GROUPS G on G.PROFESSION = P.PROFESSION
	inner join STUDENT S on S.IDGROUP = G.IDGROUP
	inner join PROGRESS PR on PR.IDSTUDENT = S.IDSTUDENT
where
	F.FACULTY_NAME like '“Œ¬'
group by rollup(F.FACULTY_NAME,P.PROFESSION,PR.SUBJECT)

/*2 same firt query but with cube groupping
it should also be empty it's also ok*/

select
	F.Faculty_name as Faculty,
	P.Profession as Profession,
	PR.SUBJECT as Subject,
	round(avg(cast(PR.NOTE as float(4))),2)as [Average Note]
from
	FACULTY F inner join PROFESSION P on F.FACULTY = P.FACULTY
	inner join GROUPS G on G.PROFESSION = P.PROFESSION
	inner join STUDENT S on S.IDGROUP = G.IDGROUP
	inner join PROGRESS PR on PR.IDSTUDENT = S.IDSTUDENT
where
	F.FACULTY_NAME like '“Œ¬'
group by cube(F.FACULTY_NAME,P.PROFESSION,PR.SUBJECT)


/*3 Exams results for TOV unioned with HTIT*/

select
	F.FACULTY_NAME as Faculty,
	PR.SUBJECT as Subject,
	G.PROFESSION as Profession,
	round(avg(cast(PR.NOTE as float(4))),2) as [Average Note]
from
	FACULTY F
	inner join PROFESSION P on F.FACULTY = P.FACULTY
	inner join GROUPS G on P.PROFESSION = G.PROFESSION
	inner join STUDENT S on G.IDGROUP = S.IDGROUP
	inner join PROGRESS PR on PR.IDSTUDENT = S.IDSTUDENT
where
	F.FACULTY_NAME like '“Œ¬'
group by
	F.FACULTY_NAME,
	PR.SUBJECT,
	G.PROFESSION
union
select
	F.FACULTY_NAME as Faculty,
	PR.SUBJECT as Subject,
	G.PROFESSION as Profession,
	round(avg(cast(PR.NOTE as float(4))),2) as [Average Note]
from
	FACULTY F
	inner join PROFESSION P on F.FACULTY = P.FACULTY
	inner join GROUPS G on P.PROFESSION = G.PROFESSION
	inner join STUDENT S on G.IDGROUP = S.IDGROUP
	inner join PROGRESS PR on PR.IDSTUDENT = S.IDSTUDENT
where
	F.FACULTY_NAME like '’“Ë“'
group by
	F.FACULTY_NAME,
	PR.SUBJECT,
	G.PROFESSION


/*4 intersection usage*/
select
	F.FACULTY_NAME as Faculty,
	PR.SUBJECT as Subject,
	G.PROFESSION as Profession,
	round(avg(cast(PR.NOTE as float(4))),2) as [Average Note]
from
	FACULTY F
	inner join PROFESSION P on F.FACULTY = P.FACULTY
	inner join GROUPS G on P.PROFESSION = G.PROFESSION
	inner join STUDENT S on G.IDGROUP = S.IDGROUP
	inner join PROGRESS PR on PR.IDSTUDENT = S.IDSTUDENT
where
	F.FACULTY_NAME like '“Œ¬'
group by
	F.FACULTY_NAME,
	PR.SUBJECT,
	G.PROFESSION
intersect
select
	F.FACULTY_NAME as Faculty,
	PR.SUBJECT as Subject,
	G.PROFESSION as Profession,
	round(avg(cast(PR.NOTE as float(4))),2) as [Average Note]
from
	FACULTY F
	inner join PROFESSION P on F.FACULTY = P.FACULTY
	inner join GROUPS G on P.PROFESSION = G.PROFESSION
	inner join STUDENT S on G.IDGROUP = S.IDGROUP
	inner join PROGRESS PR on PR.IDSTUDENT = S.IDSTUDENT
where
	F.FACULTY_NAME like '’“Ë“'
group by
	F.FACULTY_NAME,
	PR.SUBJECT,
	G.PROFESSION


/*5 exception usage*/
select
	F.FACULTY_NAME as Faculty,
	PR.SUBJECT as Subject,
	G.PROFESSION as Profession,
	round(avg(cast(PR.NOTE as float(4))),2) as [Average Note]
from
	FACULTY F
	inner join PROFESSION P on F.FACULTY = P.FACULTY
	inner join GROUPS G on P.PROFESSION = G.PROFESSION
	inner join STUDENT S on G.IDGROUP = S.IDGROUP
	inner join PROGRESS PR on PR.IDSTUDENT = S.IDSTUDENT
where
	F.FACULTY_NAME like '“Œ¬'
group by
	F.FACULTY_NAME,
	PR.SUBJECT,
	G.PROFESSION
except
select
	F.FACULTY_NAME as Faculty,
	PR.SUBJECT as Subject,
	G.PROFESSION as Profession,
	round(avg(cast(PR.NOTE as float(4))),2) as [Average Note]
from
	FACULTY F
	inner join PROFESSION P on F.FACULTY = P.FACULTY
	inner join GROUPS G on P.PROFESSION = G.PROFESSION
	inner join STUDENT S on G.IDGROUP = S.IDGROUP
	inner join PROGRESS PR on PR.IDSTUDENT = S.IDSTUDENT
where
	F.FACULTY_NAME like '’“Ë“'
group by
	F.FACULTY_NAME,
	PR.SUBJECT,
	G.PROFESSION
