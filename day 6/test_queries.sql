create database bankingDB

create table Login
(
	userName varchar(20), -- this is a column
	password varchar(20) -- this is column 2
)

insert into Login values('nikhil','nik@123')
insert into Login values('mike','mike@123')
insert into Login values('peter','parker@123')

select * from Login