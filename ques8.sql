--ques8)Create and invoke one stored procedure from another stored procedure.
-- table used is EMPLOYEE_TABLE
--first stored procedure

create procedure proc1 
as 
begin
select * from EMPLOYEE_DATA 
end 


--second stored procdure
create procedure proc3
as
begin
exec proc1
end 

exec proc3  





