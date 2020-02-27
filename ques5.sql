--ques5) user defined functions. 


select * from EMPLOYEE_DATA

--1)scalar valued functions : A Scalar UDF accepts zero or more parameters and return a single value.
--The functions are created using EMPLOYEE_TABLE. 
create function getid(@eid int)
returns varchar(50)
as 
begin
return(select emp_name from EMPLOYEE_DATA where emp_id=@eid)
end 

print dbo.getid(107) 
----------------------------------------------------------------------------------------------------------
--2) Table valued function : A Table Valued UDF accepts zero or more parameters and return a table variable.

create function getidgreat(@eid int)
returns table 
as 
return 
select * from EMPLOYEE_DATA where emp_id>=@eid 


select * from getidgreat(103) 


