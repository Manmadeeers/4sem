use FIL_MyBase;

INSERT INTO dbo.Client VALUES
	('111AAA','John','Edward','Doe','First Lane 22-15', '+1295493021','johnDoe@email.com',0),
	('222BBB','Michael','James','Smith','Oak Street 45-12', '+1786543210','mikeSmith@email.com',1),
	('333CCC','Sarah','Elizabeth','Johnson','Maple Avenue 78-34', '+1567892345','sarahJ@email.com',0),
	('444DDD','William','Robert','Brown','Pine Road 123-56', '+1345678901','willBrown@email.com',1),
	('555EEE','Emma','Alice','Wilson','Cedar Drive 90-78', '+1678234567','emmaW@email.com',0),
	('666FFF','David','Richard','Miller','Spruce Boulevard 34-90', '+1987654321','davidM@email.com',1),
	('777GGG','Olivia','Margaret','Davis','Cherry Lane 56-78', '+1567890123','oliviaD@email.com',0),
	('888HHH','Joseph','Charles','Garcia','Walnut Street 12-34', '+1789456789','joeG@email.com',1),
	('999III','Jessica','Susan','Rodriguez','Birch Avenue 78-90', '+1345678902','jessR@email.com',0),
	('000JJJ','Robert','Thomas','Martinez','Ash Tree Road 45-67', '+1567890124','bobM@email.com',1)


INSERT INTO dbo.Products VALUES
	('00AA','Laptop',10,1000.50,'-'),
	('01BB','Mouse',5,29.99,'-'),
	('02CC','Keyboard',8,59.00,'-'),
	('03DD','Monitor',3,299.99,'-'),
	('04EE','Headphones',12,89.50,'-'),
	('05FF','Printer',2,149.00,'-'),
	('06GG','Scanner',1,199.99,'-'),
	('07HH','Tablet',4,399.99,'-'),
	('08II','Smartphone',6,599.00,'-'),
	('09JJ','Laptop',7,899.99,'-')

INSERT INTO Orders VALUES
	('123ABC','111AAA','00AA',3,'2025-03-03'),
	('234DEF','222BBB','01BB',2,'2025-03-04'),
	('345GHI','333CCC','02CC',1,'2025-03-05'),
	('456JKL','444DDD','03DD',4,'2025-03-06'),
	('567MNO','555EEE','04EE',3,'2025-03-07'),
	('678PQR','666FFF','05FF',2,'2025-03-08'),
	('789STU','777GGG','06GG',5,'2025-03-09'),
	('890VWX','888HHH','07HH',1,'2025-03-10'),
	('901YZA','999III','08II',6,'2025-03-11'),
	('012BCD','000JJJ','09JJ',3,'2025-03-12')