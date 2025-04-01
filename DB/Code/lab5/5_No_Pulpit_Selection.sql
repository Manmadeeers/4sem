use UNIVER;


select FACULTY_NAME as Faculty from FACULTY fac where not exists(select * from PULPIT pul where fac.FACULTY = pul.FACULTY)
/*it should be empty, it's ok*/