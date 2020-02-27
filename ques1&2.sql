create database sqlassignnew
use sqlassignnew

--ques1) creation of two tables.

----------------------------------------------------------------------------------------------------------------------------------------
create table EMPLOYEE_DATA 
(emp_id int identity(100,1) primary key,
emp_name varchar(50),
mobile_num varchar(10) constraint verify_mno check(mobile_num like '[7-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'),
emp_dob datetime,
emp_address varchar(50),
emp_salary money,
emp_zipcode varchar(6) constraint verify_zip check(emp_zipcode like '[0-9][0-9][0-9][0-9][0-9][0-9]' ),
created_date datetime2 default getdate(),
modified_date datetime2, 
Is_Active bit default 0
) 

insert into EMPLOYEE_DATA(emp_name,mobile_num,emp_dob,emp_address,emp_salary,emp_zipcode,Is_Active)
values('Ram',9999015585,'1998-08-22','Delhi',NULL,100001,1) 

insert into EMPLOYEE_DATA(emp_name,mobile_num,emp_dob,emp_address,emp_salary,emp_zipcode,Is_Active)
values('Shyam',9250062713,'1997-09-02','Punjab',NULL,100002,0) 

insert into EMPLOYEE_DATA(emp_name,mobile_num,emp_dob,emp_address,emp_salary,emp_zipcode,Is_Active)
values('Soham',9811994239,'1997-09-09','Haryana',NULL,100003,0) 

insert into EMPLOYEE_DATA(emp_name,mobile_num,emp_dob,emp_address,emp_salary,emp_zipcode,Is_Active)
values('Mohan',9811994223,'1997-10-10','Bengal',NULL,100004,1) 

insert into EMPLOYEE_DATA(emp_name,mobile_num,emp_dob,emp_address,emp_salary,emp_zipcode,Is_Active)
values('Pravesh',9811991122,'1997-01-04','Punjab',NULL,100005,1) 

insert into EMPLOYEE_DATA(emp_name,mobile_num,emp_dob,emp_address,emp_salary,emp_zipcode,Is_Active)
values('Vishesh',8811994239,'1997-12-19','Haryana',NULL,100006,0) 

insert into EMPLOYEE_DATA(emp_name,mobile_num,emp_dob,emp_address,emp_salary,emp_zipcode,Is_Active)
values('Azeem',7711994239,'1997-11-17','Mumbai',NULL,100007,0) 

insert into EMPLOYEE_DATA(emp_name,mobile_num,emp_dob,emp_address,emp_salary,emp_zipcode,Is_Active)
values('Arpit',9911004239,'1997-06-09','Chennai',NULL,100008,1) 

select * from EMPLOYEE_DATA 


------------------------------------------
--table no. 2 
------------------------------------------


create table Salary_info
( sal_id int identity(1,1)  primary key,
month_name varchar(50) ,
emp_id int,
salary money,
foreign key(emp_id) references EMPLOYEE_DATA(emp_id))

insert into Salary_info(month_name,emp_id,salary)
values('jan',100,700)

insert into Salary_info(month_name,emp_id,salary)
values('feb',100,600)

insert into Salary_info(month_name,emp_id,salary)
values('mar',100,500)

insert into Salary_info(month_name,emp_id,salary)
values('jan',101,700)

insert into Salary_info(month_name,emp_id,salary)
values('feb',101,400)

insert into Salary_info(month_name,emp_id,salary)
values('mar',101,600)

insert into Salary_info(month_name,emp_id,salary)
values('april',101,200)

insert into Salary_info(month_name,emp_id,salary)
values('jan',102,500)

insert into Salary_info(month_name,emp_id,salary)
values('feb',102,500)

insert into Salary_info(month_name,emp_id,salary)
values('mar',102,600)

insert into Salary_info(month_name,emp_id,salary)
values('jan',103,600)

insert into Salary_info(month_name,emp_id,salary)
values('feb',103,700)

insert into Salary_info(month_name,emp_id,salary)
values('mar',103,800)

insert into Salary_info(month_name,emp_id,salary)
values('april',103,400)

insert into Salary_info(month_name,emp_id,salary)
values('jan',104,400)


insert into Salary_info(month_name,emp_id,salary)
values('feb',104,300)

insert into Salary_info(month_name,emp_id,salary)
values('jan',105,1200)

insert into Salary_info(month_name,emp_id,salary)
values('jan',106,1000)

insert into Salary_info(month_name,emp_id,salary)
values('feb',106,200)

insert into Salary_info(month_name,emp_id,salary)
values('mar',106,400)

insert into Salary_info(month_name,emp_id,salary)
values('april',106,800)

insert into Salary_info(month_name,emp_id,salary)
values('jan',107,500)

insert into Salary_info(month_name,emp_id,salary)
values('feb',107,200)

insert into Salary_info(month_name,emp_id,salary)
values('mar',107,1000)

insert into Salary_info(month_name,emp_id,salary)
values('jan',108,400)

insert into Salary_info(month_name,emp_id,salary)
values('feb',108,600)

insert into Salary_info(month_name,emp_id,salary)
values('mar',108,400)

select * from Salary_info



----------------------------------------------------------------------------------------------------------------------------------------------

---ques2) update a column name.


exec sp_rename 'Salary_info.salary','SALARY';  -- this command will change the "salary" to "SALARY". 

select * from Salary_info 


------------------------------------------------------------------------------------------------------------------

--ques1) moving the total salary from salary_info to employee_data 

select EMPLOYEE_DATA.emp_id,Salary_info.SALARY
from EMPLOYEE_DATA 
full outer join Salary_info on
EMPLOYEE_DATA.emp_id=Salary_info.emp_id 
order by EMPLOYEE_DATA.emp_id

select emp_id,sum(SALARY),
count(emp_id)
from Salary_info
group by emp_id

update EMPLOYEE_DATA
set 
EMPLOYEE_DATA.emp_salary=Salary_info.SALARY 
from EMPLOYEE_DATA inner join 
(select emp_id,sum(SALARY) as SALARY 
from Salary_info 
group by emp_id) 
as Salary_info on EMPLOYEE_DATA.emp_id=Salary_info.emp_id

select * from EMPLOYEE_DATA 