--ques9) Difference b/w having clause and where clause provide examples.

--The difference between the having and where clause in SQL is that
--the where clause cannot be used with aggregates, but the having clause can.


--1)where clause 
--using table EMPLOYEE_TABLE 

-- below query is to display the data where emp_id is greater than 104. 

select * from EMPLOYEE_DATA 
where emp_id>104  
--------------------------------------------------------------------------------------------------------


--2) having clause 
--below query is to display the count of the employees living in same address. 

select emp_address, count(emp_id)
from EMPLOYEE_DATA
group by emp_address 
having count(emp_id) > 1 

----------------------------------------------------------------------------------------------------------