<Query Kind="Statements">
  <Connection>
    <ID>f4ab813a-334f-4686-a649-5fa13807799f</ID>
    <NamingServiceVersion>2</NamingServiceVersion>
    <Persist>true</Persist>
    <Server>DESKTOP-US930J5\SQLEXPRESS</Server>
    <Database>Linq_db </Database>
  </Connection>
</Query>

//--Group by operation groups the employee on the basis of their salary--// 

var re = from e in Employees
group e by e.Emp_salary;
Console.WriteLine(re); 
 
 
//--Group by operation groups the employee on the basis of their address--// 

 var r = from e in Employees
group e by e.Emp_address;
Console.WriteLine(r); 
 