
---ques3) How data can be copied from one table to another table ? 

create table copy_table
(emp_id int identity(100,1) primary key ,
emp_name varchar(50))

--command to copy the content of table to another table.
insert into copy_table(emp_id,emp_name)
select emp_id,emp_name
from EMPLOYEE_DATA

select * from copy_table 

--insert command and select command is used to copy the data from one table to other table.
--first insert values in copy_table then select the columns you want to copy from existing table. 









