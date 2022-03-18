create database testDB3

use testDB3

create table tbl_chineseDishOrders
(
	orderId int primary key,
	dishName_1 varchar(20),
	dishName_2 varchar(20),
	dishName_3 varchar(20),
	dishName_4 varchar(20)
	)

create table tbl_ItalianDishOrders
(
	orderId int primary key,
	dishName_1 varchar(20),
	dishName_2 varchar(20),
	dishName_3 varchar(20),
	dishName_4 varchar(20)
	)

create table tbl_IceCreamOrders
(
	orderId int primary key,
	dishName_1 varchar(20),
	dishName_2 varchar(20),
	dishName_3 varchar(20),
	dishName_4 varchar(20)
	)

select * from tbl_chineseDishOrders


create sequence seq_orderId
start with 200
increment by 2

--test the sequence 
select Next value for seq_orderId

insert into tbl_IceCreamOrders values (next value for seq_orderId,'Ice 1','Ice 2','Ice 3','Ice 4')
select * from tbl_IceCreamOrders


insert into tbl_chineseDishOrders values (next value for seq_orderId,'Ch 1','CH 2','CH 3','CH 4')

insert into tbl_ItalianDishOrders values (next value for seq_orderId,'ITY 1','ITY 2','ITY 3','ITY 4')

select * from tbl_IceCreamOrders
select * from tbl_chineseDishOrders
select * from tbl_ItalianDishOrders

ALTER TABLE tbl_ItalianDishOrdersADD ordertime datetime;


select * from tbl_IceCreamOrders

insert into tbl_IceCreamOrders values (next value for seq_orderId,'Ice 1','Ice 2','Ice 3','Ice 4')
--how can I insert the system date and time ?
--how can you still add a new record to tbl_IceCreamOrders, without passing the date ?	
	insert into tbl_IceCreamOrders(orderId,dishName_1,dishName_2,dishName_3,dishName_4) values (next value for seq_orderId,'Ice 1','Ice 2','Ice 3','Ice 4')	


	select GETDATE()

	
insert into tbl_IceCreamOrders values (next value for seq_orderId,'Ice 1','Ice 2','Ice 3','Ice 4',GETDATE())