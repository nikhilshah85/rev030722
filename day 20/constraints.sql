
create table employee
(
	empNo int,
	empName varchar(20), -- should be minimum 3 characters, name cannot be blank
	empDesignatioon varchar(20), -- designation can be Developer, Manager, HR, Accounts, (no other values)
	empSalary int, -- should be min 10K and max 60K
	empAge int -- should be more than 18, and less than 60
)

--insert into employee values(101,'Nikhil','Consultant',5000,30)

--insert into employee values(101,'   ','President',80000,-20)
--insert into employee(empNo,empDesignatioon,empSalary) values(102,'Sports',-9000)


drop table employee



create table Department (deptNo int, deptName varchar(20),deptLocation varchar(20),
			constraint pk_deptNo primary key(deptNo))
		insert into Department values(101,'IT','NYK');
		insert into Department values(102,'Accounts','Paris');
		insert into Department values(103,'HR','HKG');
create table employee
(
	empNo int, --no duplication and this is the identity for every record
	empName varchar(20) not null, -- should be minimum 3 characters, name cannot be blank
	empDesignation varchar(20) not null, -- designation can be Developer, Manager, HR, Accounts, (no other values)
	empSalary int not null, -- should be min 10K and max ckeck
	empAge int not null, -- should be more than 18, and less than 60,
	empSSN varchar(10) not null, -- needs to be unique and has to be 10 characters)
	empDept int,

	constraint pk_empNo primary key(empNo),
	constraint chk_empName check (len(empName) >= 3),
	constraint chk_empDesignation check (empDesignation in ('Developer','Manager','HR','Accounts')),
	constraint chk_empSalary check (empSalary between 10000 and 60000),
	constraint chk_empAge check (empAge between 18 and 60),
	constraint unk_empssn unique(empSSN),
	constraint fk_empDepartment foreign key(empDept) references Department(deptNo)
	)
	insert into employee values(101,'Nikhil','Developer',15000,30,'1234ABCD12',101)

	insert into employee values(102,'Nikh','Sales',15000,30,'1234ABCD13',101)







