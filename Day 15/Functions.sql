create database TSQLDemo
use TSQLDemo

create function greetUser() returns varchar(20)
as 
begin
	return 'Welcome to the TSQL World'
end

select dbo.greetUser() as Message

--------------------------------------------------------------------------------
create function greetUser2(@guestName varchar(20)) returns varchar(20)
as
begin
	return 'Hello ' + @guestName
end

select dbo.greetUser2('Mike') as Greet

create table employee 
(
	empNo int primary key,
	empName varchar(20),
	empDesignation varchar(20),
	empSal int
)
insert into employee values(101,'Nik','Consultant',100)
insert into employee values(102,'Mike','HR',100)
insert into employee values(103,'Monica','Sales',100)
insert into employee values(104,'Sandra','Sales',100)
insert into employee values(105,'Britney','Consultant',100)

select dbo.greetUser2(empName) as Greet,empDesignation  from employee


create function getCTC(@empNo int) returns bigint
as
begin
	declare @currentSal int
	set @currentSal = (select empsal from employee where empNo = @empNo)
	
	declare @travelCost int = 10
	declare @weeklyBonus int = 5
	declare @lunchallowance int = 8
	declare @taxRate int = 10

	declare @pay int = (@currentSal + @travelCost  + @weeklyBonus  +@lunchallowance)
	declare @transferValue int = @pay - ((@pay * @taxRate) / 100)

	return @transferValue

end



select * from employee


select empName,empSal,dbo.getCTC(empNo) as CTC from employee







create function calculateDiscount(@billamount int,@discountCode varchar(20)) returns int
as
begin
	if(@discountCode = 'Summer20')
		return (@billamount  * 20 / 100)
	else if (@discountCode = 'APR22')
		return (@billamount * 15 / 100)
	else if (@discountCode = 'NEWUSER')
		return (@billamount * 10 / 100)
	else
		return @billamount

		return 0
end

select dbo.calculateDiscount(1000,'HJLHRLJ')

create table DicscountCodes
(
	code varchar(20) primary key,
	percentage int
)
insert into DicscountCodes values('Winter',10)
insert into DicscountCodes values('Summer',15)
insert into DicscountCodes values('Rainy',20)
insert into DicscountCodes values('Spring',25)

alter function calculateDiscount(@billamount int,@discountCode varchar(20)) returns int
as
begin

	declare @rate int = (select percentage from DicscountCodes where code = @discountCode)
	return (@billamount * @rate) / 100
end

select dbo.calculateDiscount(1000,'Rainy') 