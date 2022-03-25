
create table EmployeeInfo
(
	empNo int primary key,
	empName varchar(20),
	empDesignation varchar(20),
	empSalary int
)
---This operations should not be allowd on Friday
insert into EmployeeInfo values(101,'Nikhil','Consultant',6000)
insert into EmployeeInfo values(102,'Priya','Developer',18000)
insert into EmployeeInfo values(103,'Akshay','HR',30000)
insert into EmployeeInfo values(104,'Raj','HR',30000)
insert into EmployeeInfo values(105,'Penny','HR',30000)
update EmployeeInfo set empSalary = 8000
delete from EmployeeInfo
select * from EmployeeInfo

create trigger trg_EmployeeInfo_before_insert
on EmployeeInfo
for insert
as
begin
	if( DATEPART(WEEKDAY,getdate()) = 6)
	begin
		rollback; -- this is your TCL-DCL
		print('You cannot Add new employee on Friday, as it is a holiday')
	end
end

delete from EmployeeInfo

create trigger trg_employeeinfo_before_delete
on Employeeinfo
for delete
as
begin
	if(DATEPART(hour,getdate()) in (15,16))
	begin
		rollback;
		print('You Cannot delete between 3 and 5 PM')
	end
end
delete from employeeInfo
select DATEPART(hour,getdate())

alter trigger trg_employeeInfo_before_update
on employeeInfo
for update
as
begin
	declare @v_empId int =  (select i.empNo  from inserted i)
	declare @v_empSalary int = (select i.empSalary from  inserted i)
	declare @v_designation varchar(20) = (select i.empDesignation from inserted i)
	declare @newId int = (select ISNULL(MAX(id),0) + 1 from employeeUpdate)
	if(@v_designation = 'Developer' and @v_empSalary < 25000)
	begin
		rollback;
		print('This is a very low salary for a developer, please check the Organization standard salary');
		insert into employeeUpdate values(@newId,GETDATE(),@v_empId)
	end
end

select * from EmployeeInfo
update EmployeeInfo set empSalary = 19000 where empDesignation = 'Developer'

create table employeeUpdate
(
	id int primary key,
	during datetime,
	empId int)

	select * from employeeUpdate
	
	
	
	
	---------------------------------------------------------------------------
	                    After trigger
	                    
	  
	  	create table Stockinfo
	(
		sid int primary key,
		productName varchar(20),
		productCategory varchar(20),
		productAvailableQty int,
		productPrice int
	)

	insert into Stockinfo values(101,'Pepsi','Cold-Drinks',200,50)
	insert into Stockinfo values(102,'Coke','Cold-Drinks',200,65)
	insert into Stockinfo values(103,'Maggie','Fast-Food',200,20)
	insert into Stockinfo values(104,'Pasta','Fast-Food',200,35)
	insert into Stockinfo values(105,'Pears','Soap',200,80)
	insert into Stockinfo values(106,'Dove','Soap',200,75)
	insert into Stockinfo values(107,'Appy','Cold-Drinks',200,60)

	create table Sales
	(
		salesid int primary key identity,
		productid int,
		saleQty int,
		SalePrice int,
		DiscountValue int,
		SaleAmount int
	)
	
	
	--- Sales procedure
	
		create procedure proc_newSales
	(
		@productid int,
		@saleQty int
	)
	as
	begin
		declare @price int = (select productPrice from Stockinfo where sid = @productId)
		declare @categoty varchar(20) = (select productCategory from stockinfo where sid=@productid)
		declare @dicountPercentage int;
		declare @discountValue int;
		declare @saleAmount int;
		if(@categoty = 'Cold-Drinks')
		begin
			set @dicountPercentage = 10;
		end
		else if(@categoty = 'Fast-Food')
		begin
			set @dicountPercentage = 15;
		end
		else if(@categoty = 'Soap')
		begin
			set @dicountPercentage = 2
		end

		set @discountValue = (@saleQty * @price) * @dicountPercentage / 100
		set @saleAmount = (@saleQty * @price) - @discountValue

		insert into Sales values(@productid,@saleQty,@price,@discountValue,@saleAmount)
	end

	exec proc_newSales 103,12
		select * from Sales
	
	---------------------------------------------------------------------------
	
	--so we create After insert trigger on Sales, to update the stockinfo

		create trigger trg_sales_after_insert
		on Sales
		after insert
		as
		begin
			--we will have to which product is sold and how many qty is sold
			declare @productSold int;
			declare @qtySold int;
			set @productSold  = (select i.productid  from inserted i)
			set @qtySold  = (select i.saleQty  from inserted i)

			update Stockinfo set productAvailableQty = productAvailableQty - @qtySold 
						where sid = @productSold
		end
	

	select * from Stockinfo
	select * from Sales
	
	exec proc_newSales 104,18
	exec proc_newSales 101,30
	
	
	---------------------------------------------------------------------------
	
	create view empDetails
	as
	select empInfo.empid as [Employee Number],
		empInfo.empName as [Name],
		   empInfo.empDesignation as [Works As],
		   empInfo.empSalary as [Salary],
		   empInfo.empDeptNo as DeptNo,
		   deptInfo.dName as [Department],
		   deptInfo.dCity as City
	from empInfo join deptInfo
	on empInfo.empDeptNo = deptInfo.dId

	select * from empDetails

	--this the object SQL Server developers create on server (empDetails
	)
	--this is the object shared with clients, front end developer, web developers, excel ppl like HR
	insert into empDetails values(503,'Mohan','HR',30000,101,'IT','Mumbai')


	--from here only the empdetails has to go to the empInfo tables, so we will collect those details 
		--and insert them by self


		select * from empDetails
		create trigger trg_empDetails_instead_insert
		on empDetails
		instead of insert
		as
		begin
			declare @newNo int = (select i.[Employee Number]  from inserted i)
			declare @newName varchar(20) = (select i.[Name]  from inserted i)
			declare @newDesigantion varchar(20) = (select i.[Works As]  from inserted i)
			declare @newSalary int = (select i.[Salary]  from inserted i)
			declare @newDeptNo int = (select i.[DeptNo]  from inserted i)

			insert into empInfo values(@newNo,@newName,@newDesigantion,@newSalary,@newDeptNo)
		end

		select * from empInfo
	
	---------------------------------------------------------------------------
	
	
--this is a trigger in every org -- logging -- backup

create table employeeInformation
(empNo int primary key,
empname varchar(20),
empdesignation varchar(20),
empsalary int,
empdept int,
empcontactNo bigint,
empemail varchar(20),
empaddress varchar(4000))

create table employeeInformation_backup
(
id int primary key identity,
empNo int,
action varchar(20),
dateofaction datetime,
empname varchar(20),
empdesignation varchar(20),
empsalary int,
empdept int,
empcontactNo bigint,
empemail varchar(20),
empaddress varchar(4000),
)  -- this could have been a description




select * from employeeInformation_backup









--in 2020 - empJoined - salary is 8900
--   2021 - apprisal - salary is 12000
--   2022 - appriasal - salary is 18000
--   2023 - designation is now 'sr manager'
--   2024 - left the job - so the data will be deleted

   in 2030 - came back for an interview -- hr must have changed by now
		in 2030, we will get to know the whole history 

   this are all updates, which we fire on empinformation table, the vales gets over ridden

   alter trigger trg_employeeinformation_backup_insert
   on employeeinformation
   after insert
   as
   begin
   declare @empNo int = (select i.empNo from inserted i)
declare @empname varchar(20)= (select i.empname from inserted i)
declare @empdesignation varchar(20)= (select i.empdesignation from inserted i)
declare @empsalary int= (select i.empsalary from inserted i)
declare @empdept int= (select i.empdept from inserted i)
declare @empcontactNo bigint= (select i.empcontactNo from inserted i)
declare @empemail varchar(20)= (select i.empemail from inserted i)
declare @empaddress varchar(4000)= (select i.empaddress from inserted i)
declare @action varchar(20)= 'Joined'

insert into employeeInformation_backup values(@empNo,@action,getdate(),@empname,@empdesignation,@empsalary,@empdept,@empcontactNo,@empemail,@empaddress)


   end

     create trigger trg_employeeinformation_backup_update
   on employeeinformation
   after update
   as
   begin
     declare @empNo int = (select i.empNo from inserted i)
declare @empname varchar(20)= (select i.empname from inserted i)
declare @empdesignation varchar(20)= (select i.empdesignation from inserted i)
declare @empsalary int= (select i.empsalary from inserted i)
declare @empdept int= (select i.empdept from inserted i)
declare @empcontactNo bigint= (select i.empcontactNo from inserted i)
declare @empemail varchar(20)= (select i.empemail from inserted i)
declare @empaddress varchar(4000)= (select i.empaddress from inserted i)
declare @action varchar(20)= 'Updated'

insert into employeeInformation_backup values(@empNo,@action,getdate(),@empname,@empdesignation,@empsalary,@empdept,@empcontactNo,@empemail,@empaddress)

   end

     create trigger trg_employeeinformation_backup_delte
   on employeeinformation
   after delete
   as
   begin
     declare @empNo int = (select i.empNo from inserted i)
declare @empname varchar(20)= (select i.empname from inserted i)
declare @empdesignation varchar(20)= (select i.empdesignation from inserted i)
declare @empsalary int= (select i.empsalary from inserted i)
declare @empdept int= (select i.empdept from inserted i)
declare @empcontactNo bigint= (select i.empcontactNo from inserted i)
declare @empemail varchar(20)= (select i.empemail from inserted i)
declare @empaddress varchar(4000)= (select i.empaddress from inserted i)
declare @action varchar(20)= 'Left the company'

insert into employeeInformation_backup values(@empNo,@action,getdate(),@empname,@empdesignation,@empsalary,@empdept,@empcontactNo,@empemail,@empaddress)

   end






   select * from employeeinformation
   select * from employeeinformation_backup where empno = 1




   insert into employeeinformation values(2,'Karan','HR',6000,102,6363,'kar@org.com','Chennai')
   
   update employeeinformation set empemail = 'nik@org.co.us'
			where empNo = 1

	delete from employeeinformation where empNo = 1
	
	---------------------------------------------------------------------------
	
	

            Sequencece



	--For auto generated values, we had 2 ways
		a. mark a column as identity
		b. use max(colname) + 1 and insert 

		this values were tied up to a single table
		Many a time, we have use the same sequence for multiple tables

		MensProduct (productID) - auto generated
				1,2,3,4, 8,9,14,15

		FemalsProduct (productId) - auto generated
			  5,10,12,13 (we will have to go to that table mensproduct, fire max(


		Kids Product (productId) - auto generated 
				6,7,11,16,17


		---sequence object

		create sequence seq_productid
		as int
		start with 100
		increment by 2

		select * from sys.sequences  where name = 'seq_productid'

		select next value for seq_productid


		create table MensProduct
		(
			pId int primary key,
			pName varchar(20)
		)

		create table FemaleProduct
		(
			pId int primary key,
			pName varchar(20)
		)

		create table KidsProduct
		(
			pId int primary key,
			pName varchar(20)
		)

		insert into MensProduct values(next value for seq_productid,'T-Shirt')
		select * from MensProduct
		select * from KidsProduct
		select * from FemaleProduct

		insert into KidsProduct values(next value FOR seq_productid,'Cap')
		insert into FemaleProduct values(next value FOR seq_productid,'Make-up')





















	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
