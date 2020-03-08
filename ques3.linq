<Query Kind="Expression">
  <Connection>
    <ID>f4ab813a-334f-4686-a649-5fa13807799f</ID>
    <NamingServiceVersion>2</NamingServiceVersion>
    <Persist>true</Persist>
    <Server>DESKTOP-US930J5\SQLEXPRESS</Server>
    <Database>Linq_db </Database>
  </Connection>
</Query>

(from e in Employees
orderby e.Emp_name descending
select e).Take(2) 


//---Take(n) will take the "n" number of rows.---//
// orderby descending will sort the record on the basis of Emp_name// 
