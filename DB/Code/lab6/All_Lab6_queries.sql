use UNIVER;
/*select * from AUDITORIUM*/

/*1 average, max and min capacity for auditoriums*/
select AUDITORIUM_TYPE.AUDITORIUM_TYPE,
	max(AUDITORIUM.AUDITORIUM_CAPACITY)[Max Capacity],
	min(AUDITORIUM.AUDITORIUM_CAPACITY)[Min Capacity],
	avg(AUDITORIUM.AUDITORIUM_CAPACITY)[Avg Capacity]
from AUDITORIUM inner join AUDITORIUM_TYPE on AUDITORIUM.AUDITORIUM_TYPE = AUDITORIUM_TYPE.AUDITORIUM_TYPE group by AUDITORIUM_TYPE.AUDITORIUM_TYPE

/*2 widened first query*/

select AUDITORIUM_TYPE.AUDITORIUM_TYPE,
	max(AUDITORIUM.AUDITORIUM_CAPACITY)[Max Capacity],
	min(AUDITORIUM.AUDITORIUM_CAPACITY)[Min Capacity],
	avg(AUDITORIUM.AUDITORIUM_CAPACITY)[Avg Capacity],
	sum(AUDITORIUM.AUDITORIUM_CAPACITY)[Total capacity],
	count(AUDITORIUM.AUDITORIUM_TYPE)[Count]
from 
	AUDITORIUM inner join AUDITORIUM_TYPE on AUDITORIUM.AUDITORIUM_TYPE = AUDITORIUM_TYPE.AUDITORIUM_TYPE
group by 
	AUDITORIUM_TYPE.AUDITORIUM_TYPE

/*3 Note ranges and their count*/

/*select * from PROGRESS*/

select * from(select Case when PROGRESS.NOTE between 4 and 5 then '4-5' 
						  when PROGRESS.NOTE between 5 and 6 then '5-6'
						  when PROGRESS.NOTE between 6 and 7 then '6-7'
						  when PROGRESS.NOTE between 7 and 8 then '7-8'
						  when PROGRESS.NOTE between 8 and 9 then '8-9'
						  when PROGRESS.NOTE between 9 and 10 then '9-10'
						  end[Ranges],  
											  Count(*)[Amount] from PROGRESS group by Case 
											  when PROGRESS.NOTE between 4 and 5 then '4-5'
											  when PROGRESS.NOTE between 5 and 6 then '5-6'
											  when PROGRESS.NOTE between 6 and 7 then '6-7'
											  when PROGRESS.NOTE between 7 and 8 then '7-8'
											  when PROGRESS.NOTE between 8 and 9 then '8-9'
											  when PROGRESS.NOTE between 9 and 10 then '9-10'
end)as dingei  order by Case[Ranges] 
when '9-10' then 1
when '8-9' then 2
when '7-8' then 3
when '6-7' then 4
when '5-6'then 5
when '4-5' then 6
else 0
end


/*4 Average notes for professions*/

select F.FACULTY_NAME as Faculty,
		P.PROFESSION_NAME as Speciality,
		round(avg(cast(PR.NOTE as float(4))),2)as [Average note]
from
	FACULTY F
	inner join PROFESSION P on F.FACULTY = P.FACULTY
	inner join GROUPS G on P.PROFESSION = G.PROFESSION
	inner join STUDENT S on G.IDGROUP = S.IDGROUP
	inner join PROGRESS PR on PR.IDSTUDENT = S.IDSTUDENT
group by 
	F.FACULTY_NAME,
	P.PROFESSION_NAME
order by
	[Average note] desc


/*5 Average note for specific discipline*/
select F.FACULTY_NAME as Faculty,
		P.PROFESSION_NAME as Speciality,
		round(avg(cast(PR.NOTE as float(4))),2)as [Average note]
from
	FACULTY F
	inner join PROFESSION P on F.FACULTY = P.FACULTY
	inner join GROUPS G on P.PROFESSION = G.PROFESSION
	inner join STUDENT S on G.IDGROUP = S.IDGROUP
	inner join PROGRESS PR on PR.IDSTUDENT = S.IDSTUDENT
where
	PR.SUBJECT like 'ÎÀèÏ' or PR.SUBJECT like 'ÁÄ'
group by 
	F.FACULTY_NAME,
	P.PROFESSION_NAME
order by
	[Average note] desc


/*6 Average notes for TOV*/

select 
	F.FACULTY_NAME as Faculty,
	P.PROFESSION_NAME as Profession,
	PR.SUBJECT as Discipline,
	round(avg(cast(PR.NOTE as float(4))),2)as [Average note]
from FACULTY F
	inner join PROFESSION P on F.FACULTY = P.FACULTY
	inner join GROUPS G on G.PROFESSION = P.PROFESSION
	inner join STUDENT S on S.IDGROUP = G.IDGROUP
	inner join PROGRESS PR on PR.IDSTUDENT = S.IDSTUDENT
where
	F.FACULTY_NAME like 'ÒÎÂ'
group by
	F.FACULTY_NAME,
	P.PROFESSION_NAME,
	PR.SUBJECT


/*7 count students with 8 and 9*/

select
	PROGRESS.SUBJECT as Discipline,
	count(STUDENT.IDSTUDENT)as [Amount]
from
	PROGRESS inner join STUDENT on PROGRESS.IDSTUDENT = STUDENT.IDSTUDENT
group by 
	PROGRESS.NOTE,PROGRESS.SUBJECT
having
	PROGRESS.NOTE>=8 and PROGRESS.NOTE<=9
order by 
	[Amount] desc



