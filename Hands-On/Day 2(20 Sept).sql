
--1
create database Library
use Library

create table Member(
Member_ID numeric(5) primary key, 
Member_Name Char(25), 
Acc_Open_Date Date,
Max_Books_Allowed numeric(2),
Penalty_Amount numeric(7,2))

create table Book(
Book_No numeric(6) primary key,
Book_Name varchar(30), 
Author Char(30), 
Cost numeric(7,2), 
Category Char(10))

create table Issue(
Lib_Issue_Id numeric(10) primary key, 
Book_No numeric(6) foreign key references Book(Book_No),
Member_Id numeric(5) foreign key references Member(Member_Id), 
Issue_Date Date, Return_date Date)

--2
sp_help Member
sp_help Book
sp_help Issue

--3
alter table issue
add Comment varchar(100) 

--4
alter table Member 
alter column Member_Name Char(30)

--5
alter table Issue
add Reference varchar(30)

--6
alter table Issue
drop column Reference 

--7
exec sp_rename 'Issue',  'Lib_Issue';

--8

insert into Member values(1,'Richi Sharma','2005-12-10',5,50)
insert into Member values(2,'Garima Sen',SYSDATETIME(),3,null)
insert into Member values(3,'Ramu','2015-01-24',3,105)
insert into Member values(4,'Diya','2022-04-14',8,10)
insert into Member values(5,'Rahul','2010-12-21',2,50)
select * from Member
--9
alter table Member 
alter column Member_Name Char(20)

--10
insert into Member values(5,'Sam','2020-12-23',110,50)
--not completed successfully.
--Error: Arithmetic overflow error converting int to data type numeric.

--11
use Library
select * into Member101 from Member
select * into Member102 from Member where 1=2

--12
insert into Book values(101,'Let us C',	'Denis Ritchie', 450 , 'System')
insert into Book values(102, 'Oracle – Complete Ref', 'Loni', 550	,'Database')
insert into Book values(103, 'Mastering SQL', 'Loni', 250, 'Database')
insert into Book values(104, 'PL SQL-Ref', 'Scott Urman', 750, 'Database')

--13
insert into Book values(105 , 'Learn c' , 'Raj' , 550 , 'System')
insert into Book values(106 & 'Learn c#' & 'John' & 450 & 'System')

--14
select * into Book101 from Book where 1=2

--15
insert into Book101 select * from Book

--16,17
select * from Member
select * from Member101
select * from Book
select * from Book101
select * from Issue

--18
insert into Book values(107,'National Geographic', 'Adis Scott', 1000,  'Science')

--19
delete from book where Book_no = 105

--20
update Book set Cost = 300, Category = 'RDBMS' where Book_No = 103

--21
exec sp_rename 'Lib_Issue', 'Issue'

--22
alter table Issue drop column Comment
insert into Issue values(7001,101,1,'10-Dec-06','')
insert into Issue values(7002,102,2,'25-Dec-06','')
insert into Issue values(7003,104,1,'15-Jan-06','')
insert into Issue values(7004,101,1,'04-Jul-06','')
insert into Issue values(7005,104,2,'15-Nov-06','')
insert into Issue values(7006,101,3,'18-Feb-06','')

--23
insert into Issue values(7007,103,3,'11-Aug-06','')
insert into Issue values(7008,102,1,'28-May-06','')

--24
update Issue set Return_date = '19-Jul-06' where Lib_Issue_Id = 7004
update Issue set Return_date = '30-Nov-06' where Lib_Issue_Id = 7005

--25
update Member set Penalty_Amount = 300 where Member_Name = 'Garima Sen'

--26
delete from Issue where Member_Id = 1 and Issue_Date < '10-Dec-06'

--27
delete from Book where Category != 'RDBMS' and  Category != 'Database'

--28
drop table Member101

--29
drop table Book101

--30
sp_help Member
sp_help Book
sp_help Issue

--31
select * from Member
select * from Book
select * from Issue


-----------------------------------Task 2---------------------------------------------------------------

--1
select * from Member where Year(Acc_Open_Date) = 2006

--2
select * from Book where Author = 'Loni' and Cost < 600

--3
select * from Issue where Return_date > GETDATE()

--4
update Issue set Return_date = '31-Dec-06 ' where Lib_Issue_Id != 7005 and Lib_Issue_Id != 7006

--5
select * from Issue where (Day(Return_date) - Day(Issue_Date)) > 30

--6
select * from Book where (Cost >= 500 and Cost <= 750) and Category = 'Database'

--7
select * from Book where Category = 'Science' or Category = 'Database'or  Category ='Fiction'or  Category = 'Management'

--8
select * from Member order by Penalty_Amount desc

--9
select * from Book order by Category, Cost desc

--10
select * from Book where Book_Name like '%SQL%'

--11
select * from Member where Member_Name like 'R%' or Member_Name  like 'G%' and Member_Name  like '%I%'

--12
select upper(Author) as Author_In_Upper from Book order by Book_Name desc

--13
select Book_No,('is written by') as '--------------------',Book_Name from Book

--18
select Lib_Issue_Id, Issue_Date, Return_Date, (Return_Date - Issue_Date) as No_of_Days_Book_issued  from Issue

--20
select count(Book_No) from Issue where Member_Id = 101

--21
select sum(Penalty_Amount) as Total_Penalty from Member

--22
select sum(Cost) as Total_Cost from Book where Category = 'Database'

--23
select min(Cost) as Cheapest_Book from Book

--26
select avg(Cost) as Average_Price_Book from Book
