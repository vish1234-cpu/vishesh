<Query Kind="Expression">
  <Connection>
    <ID>f4ab813a-334f-4686-a649-5fa13807799f</ID>
    <NamingServiceVersion>2</NamingServiceVersion>
    <Persist>true</Persist>
    <Server>DESKTOP-US930J5\SQLEXPRESS</Server>
    <Database>Linq_db </Database>
  </Connection>
</Query>

 from e in Employees 
 select e
 
 // for loop is used to iterate over the table.
 // e is the iterate variable and Employees is the name of the table. 
 // select is the dql. 