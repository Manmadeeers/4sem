use FIL_MyBase;
CREATE TABLE Client(
	Client_id nvarchar(20) primary key,
	First_name nvarchar(50) not null,
	Second_name nvarchar(50) not null,
	Last_name nvarchar(50) not null,
	Address nvarchar(50) not null,
	Phone varchar(15) not null,
	Email nvarchar(50) not null,
	Has_Discount bit not null
)on FG1;

CREATE TABLE Products(
Product_id nvarchar(20) primary key,
Product_name nvarchar(50) not null,
Stock_quantity int not null,
Price money not null,
Measurement nvarchar(20) not null
);

CREATE TABLE Orders(
	Order_id nvarchar(20) primary key,
	Client_id nvarchar(20) not null foreign key references Client(Client_id),
	Product_id nvarchar(20) not null foreign key references Products(Product_id),
	Ordered_quantity int not null,
	Sale_date date not null
);