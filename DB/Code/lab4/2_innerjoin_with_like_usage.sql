use UNIVER;

select Auditorium.AUDITORIUM, Auditorium.AUDITORIUM_TYPE, Auditorium_Type.AUDITORIUM_TYPENAME from Auditorium inner join Auditorium_Type on Auditorium.AUDITORIUM_TYPE = Auditorium_Type.AUDITORIUM_TYPE and Auditorium_Type.AUDITORIUM_TYPENAME like 'Компьютерный%'