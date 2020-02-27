--ques10)Difference between stored procedures and user defined functions. Explain with suitable examples.

--ans10) differences between procedure and function :
--Procedure can return zero or n values whereas function can return one value which is mandatory.
--Procedures can have input/output parameters for it whereas functions can have only input parameters.
--Procedure allows select as well as DML statement in it whereas function allows only select statement in it.
--Functions can be called from procedure whereas procedures cannot be called from function.


-- stored procedure 

create procedure getnameagain(@ename varchar(50))
as 
begin 
select * from EMPLOYEE_DATA where emp_name=@ename
end 

exec getnameagain @ename="Ram" 


-- user defined functions (table valued functions)

create function getsalary(@empsal money) 
returns table 
as
return
select * from EMPLOYEE_DATA where emp_salary>@empsal   

select * from getsalary(700) 





