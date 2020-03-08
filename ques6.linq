<Query Kind="Statements">
  <Connection>
    <ID>f4ab813a-334f-4686-a649-5fa13807799f</ID>
    <NamingServiceVersion>2</NamingServiceVersion>
    <Persist>true</Persist>
    <Server>DESKTOP-US930J5\SQLEXPRESS</Server>
    <Database>Linq_db </Database>
  </Connection>
</Query>

//-----Average() aggregate function-----// 
 var avg=(from e in Employees select e.Emp_salary).Average();
 Console.WriteLine("Average Salary:"+" "+avg); 
 
 //-----Count() aggregate function-----// 
 
 var c = (from e in Employees select e.Emp_id).Count(); 
 Console.WriteLine("Total number of Rows:"+" "+c); 
 
 //-----Max() aggregate function-----// 
 
 var max = (from e in Employees select e.Emp_salary).Max();
 Console.WriteLine("Maximum salary:"+" "+max); 
 
 //-----Min() aggregate function-----// 
 
 var min = (from e in Employees select e.Emp_salary).Min();
 Console.WriteLine("Minimum Salary:"+" "+min);  
 
 

                         