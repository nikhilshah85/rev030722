create procedure addEmployee(@empNo int, @empName varchar(20),@empDesignation varchar(20))
as
begin
	declare @sal int = 0;
	if(@empDesignation = 'Sales')
		set @sal = 1000
	else if (@empDesignation = 'HR')
		set @sal = 1500
	else if(@empDesignation = 'Developer')
		set @sal = 2500
	else if(@empDesignation = 'Consultant')
		set @sal = 6000
	else
		set @sal = 500

	insert into employee values(@empNo,@empName,@empDesignation,@sal)
end



exec addEmployee 501,'Rocky','Developer'
select *from employee

exec addEmployee 502,'Monica','Consultant'
select *from employee


create procedure deleteEmployee(@empno int)
as
begin
	delete from employee where empno = @empno
end

exec deleteEmployee 501
select * from employee

--in the employee table, your will never be asked empNo, (what empNo you want ?)
	--this are like auto geneated / system generated values
	--this are created using procedures


alter procedure addEmp(@empName varchar(20),@empDesignation varchar(20),@empNo int output)
as
begin
	declare @sal int = 0;
	if(@empDesignation = 'Sales')
		set @sal = 1000			
	else if (@empDesignation = 'HR')
		set @sal = 1500
	else if(@empDesignation = 'Developer')
		set @sal = 2500
	else if(@empDesignation = 'Consultant')
		set @sal = 6000
	else
		set @sal = 500

	set @empNo= (select max(empNo) + 1 from employee)
	insert into employee values(@empNo,@empName,@empDesignation,@sal)
end


declare @result int;
exec addEmp 'Mariah','Sales',@result output
print 'Employee Added, new emp No is : '
print(@result)


select * from employee



