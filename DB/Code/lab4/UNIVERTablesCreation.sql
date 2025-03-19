use UNIVER;

create table Auditorium_Type
(
Auditorium_Type char(10) primary key
)
create table Auditorium
(
Auditorium char(20) primary key,
Auditorium_Type char(10) foreign key references Auditorium_Type(Auditorium_Type),
Auditorium_Capacity int default 1 check(Auditorium_Capacity between 1 and 300),
Auditorium_Name varchar(50)
)on FG1;
