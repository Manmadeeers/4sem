use master;
create database UNIVER on primary
(name = N'UNIVER_mdf',
filename = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SARVAR\MSSQL\DATA\UNIVER.mdf',
size = 10240kb, maxsize = unlimited, filegrowth = 1024kb
),
(
name = N'UNIVER_ndf',
filename = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SARVAR\MSSQL\DATA\UNIVER.ndf',
size = 10240kb, maxsize = 1gb, filegrowth = 25%
),
filegroup FG1
(
name = N'UNIVER_fg1_1',
filename = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SARVAR\MSSQL\DATA\UNIVER_fgq-1.ndf',
size = 10240kb, maxsize = 1gb, filegrowth = 25%
),
(name = N'UNIVER_fg1_2',
filename = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SARVAR\MSSQL\DATA\UNIVER_fgq-2.ndf',
size = 10240kb, maxsize = 1gb, filegrowth = 25%
)
log on
(
name = N'UNIVER_log',
filename = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SARVAR\MSSQL\DATA\UNIVER.ldf',
size = 10240kb, maxsize = 2048gb, filegrowth = 10%
)