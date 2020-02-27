--ques4) What are the benifits of using views also give an example ?
 -- craete view is used to create a virtual table. 

create view 
view_table as
select emp_id, emp_name
from EMPLOYEE_DATA

select * from view_table 

--benifits of view:
--Views can represent a subset of the data contained in a table.
--Consequently, a view can limit the degree of exposure of the underlying
--tables to the outer world: a given user may have permission to query the view,
--while denied access to the rest of the base table. 

