use UNIVER;

select PULPIT.PULPIT_NAME as Department from PULPIT 
inner join FACULTY on PULPIT.FACULTY = FACULTY.FACULTY where FACULTY.FACULTY
in(select FACULTY.FACULTY from FACULTY where FACULTY.FACULTY_NAME like '%технология%' or FACULTY.FACULTY_NAME like '%технологии%')