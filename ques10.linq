<Query Kind="Statements">
  <Connection>
    <ID>f4ab813a-334f-4686-a649-5fa13807799f</ID>
    <NamingServiceVersion>2</NamingServiceVersion>
    <Persist>true</Persist>
    <Server>DESKTOP-US930J5\SQLEXPRESS</Server>
    <Database>Linq_db </Database>
  </Connection>
</Query>

//---get the thired highest salary---// 
var result = (from e in Employees orderby e.Emp_salary descending 
select e.Emp_salary).Take(3);
Console.WriteLine("Thired Highest Salary:\n");
Console.WriteLine(result.Skip(2));  // skip(2) will skip the 2 values and return the thired value. 


