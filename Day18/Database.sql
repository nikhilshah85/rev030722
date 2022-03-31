create database employeeManagement
 use employeeManagement

 create table employeeInfo
 (
	empNo int primary key,
	empName varchar(20),
	empDesignation varchar(20),
	empSalary int,
	empIsPermenant bit
	)
insert into employeeInfo values(101, 'Mike','Sales',8000,1)
insert into employeeInfo values(102, 'Russel','HR',18000,1)
insert into employeeInfo values(103, 'Tim','Sales',8000,0)
insert into employeeInfo values(104, 'Mac','Sales',8000,1)
insert into employeeInfo values(105, 'John','Sales',28000,1)
insert into employeeInfo values(106, 'Peter','Developer',8000,1)
insert into employeeInfo values(107, 'Marry','Sales',8000,1)
insert into employeeInfo values(108, 'May','Sales',8000,0)
insert into employeeInfo values(109, 'Cody','Sales',8000,1)
insert into employeeInfo values(1010, 'Jorge','Sales',800,1)
insert into employeeInfo values(111, 'Justin','Developer',8000,1)
insert into employeeInfo values(112, 'Santca','Sales',8000,0)
insert into employeeInfo values(113, 'Kristyna','Sales',25500,1)
insert into employeeInfo values(114, 'Jinhwa','Sales',8000,1)
insert into employeeInfo values(115, 'Joushua','Sales',8000,1)
insert into employeeInfo values(116, 'Davis','Developer',38000,0)
insert into employeeInfo values(117, 'Erick','Sales',8000,1)
insert into employeeInfo values(118, 'Gerome','Developer',8000,0)

select * from employeeInfo

create table ContactInfo
(
	empNo int,
	empEmail varchar(20),
	empCellNo bigint,
	empEmergencyContact bigint,
	empLinkedInProfile varchar(300),
	empAddress varchar(300)
	constraint fk_empNo foreign key(empNo) references employeeInfo
)

insert into ContactInfo values(102,'russel@somewhere.com',93754,93875,'http:....//something','New Yark')
insert into ContactInfo values(103,'tim@gmail.com',93754,93875,'http:....//something','Mumbai')
insert into ContactInfo values(104,'mac@yahoo.com',93754,93875,'http:....//something','HKG')
insert into ContactInfo values(105,'john@rediff.com',93754,93875,'http:....//something','Makatti')