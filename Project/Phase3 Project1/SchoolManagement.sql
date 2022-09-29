create database SchoolManagement
use SchoolManagement
create table student(student_id int primary key,student_name varchar(25),student_class int check(student_class<=12))
create table subjects(subjects_id int primary key,subjects_name varchar(25))
create table class(class_id int primary key,class_strength int)

create index student_index on student(student_id,student_name,student_class)
create index subjects_index on subjects(subjects_id,subjects_name)
create index class_index on class(class_id,class_strength)

insert into student values(1,'Ram',10)
insert into student values(2,'Sai',11)
insert into student values(3,'Daniel',6)
insert into student values(4,'Gowtham',12)
insert into student values(5,'Karthi',11)

insert into subjects values(101,'Tamil')
insert into subjects values(102,'English')
insert into subjects values(103,'Maths')
insert into subjects values(104,'Science')
insert into subjects values(105,'Social')

insert into class values(1,42)
insert into class values(2,35)
insert into class values(3,40)

select*from student
select*from subjects
select*from class