create database Shopping
use Shopping
create table customer
(
custid int,
custname varchar(20),
city varchar(20),
custstate varchar(20),
)

create table products
(
prodid int,
prodname varchar(20),
unitprice float,
unitofmeasurement int,
qtyinstock int,
)

create table sales_header
(
invno int primary key,
invdate date,
invamt float,
disPercent float,
)

create table sales_detail
(
invno int ,
custid  int primary key ,
prodid  int  ,
qtysold int,
)


alter table sales_detail
add invono int foreign key references sales_header(invono)


alter table sales_detail
add custid  int foreign key references sales_header(custid)


alter table sales_detail
add prodid int foreign key references sales_header(prodid)

alter table sales_detail
drop column qtysold 
add Qty int