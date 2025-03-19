use UNIVER;

select PULPIT.PULPIT as dept, isnull(TEACHER.TEACHER_NAME,'***' ) as teach from PULPIT left outer join TEACHER on PULPIT.PULPIT = TEACHER.PULPIT order by PULPIT.PULPIT