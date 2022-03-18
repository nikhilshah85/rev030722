create database shoppingAPP
use shoppingAPP

create table ProductDetails
(
	pId int primary key identity,
	pName varchar(20),
	pCategoty varchar(20),
	pQty int,
	pPrice int,
	pIsInStock bit
)
select * from ProductDetails
delete from ProductDetails


	update ProductDetails set pPrice = @newPPrice,pName =@newPName,pCategoty = @pNewCategoty,@pqty = @newPQty, pPrice =@newPPrice where pId = @pId
--we will fire this query from C# project 

--insert into ProductDetails values (......);