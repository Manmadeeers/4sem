use UNIVER;


select * from PROGRESS


select * from STUDENT;


select PROGRESS.IDSTUDENT as Id, Progress.NOTE as Note, PROGRESS.SUBJECT as Subject from PROGRESS where PROGRESS.NOTE>any(select PROGRESS.NOTE from PROGRESS where PROGRESS.SUBJECT like 'Œ¿Ëœ')