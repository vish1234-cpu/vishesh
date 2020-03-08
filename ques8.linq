<Query Kind="Statements">
  <Connection>
    <ID>f4ab813a-334f-4686-a649-5fa13807799f</ID>
    <NamingServiceVersion>2</NamingServiceVersion>
    <Persist>true</Persist>
    <Server>DESKTOP-US930J5\SQLEXPRESS</Server>
    <Database>Linq_db </Database>
  </Connection>
</Query>

//---First()---//

//Returns the first element of a collection, or the first element that satisfies a condition.
var result = (from e in Employees
where e.Emp_address=="Delhi"
select e).First(); 
Console.WriteLine("First() Method \n");
Console.WriteLine(result);



//---FirstOrDefault()---// 

//Returns the first element of a collection, or the first element that satisfies a condition. Returns a default value if index is out of range.

var re = (from e in Employees
where e.Emp_address=="Pakistan"
select e).FirstOrDefault(); 
Console.WriteLine("FirstOrdefault() Method \n");
Console.WriteLine(re);

