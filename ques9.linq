<Query Kind="Statements">
  <Connection>
    <ID>f4ab813a-334f-4686-a649-5fa13807799f</ID>
    <NamingServiceVersion>2</NamingServiceVersion>
    <Persist>true</Persist>
    <Server>DESKTOP-US930J5\SQLEXPRESS</Server>
    <Database>Linq_db </Database>
  </Connection>
</Query>

//---Default if empty by using a collection list ---//

IList<int> mylist = new List<int>();

var result1 = mylist.DefaultIfEmpty();  // default value is null 
var result2 = mylist.DefaultIfEmpty(100); // giving the value as 100 

Console.WriteLine("Count:" + result1.Count());
Console.WriteLine("Value:" + result1.ElementAt(0));

Console.WriteLine("Count:" + result2.Count());
Console.WriteLine("Value:" + result2.ElementAt(0)); 