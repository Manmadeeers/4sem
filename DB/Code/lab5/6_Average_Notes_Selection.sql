use UNIVER;



select top(1)(select avg(PROGRESS.NOTE) from PROGRESS where PROGRESS.SUBJECT like 'нюХо')[OAP],
(select avg(PROGRESS.NOTE) from PROGRESS where PROGRESS.SUBJECT like 'ад')[DB],
(select avg(PROGRESS.NOTE)from PROGRESS where PROGRESS.SUBJECT like 'ясад')[DBAS]
from PROGRESS