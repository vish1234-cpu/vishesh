<Query Kind="Statements">
  <Connection>
    <ID>03b87378-7e8d-47bb-b48a-386f4aa3dcd4</ID>
    <NamingServiceVersion>2</NamingServiceVersion>
    <Persist>true</Persist>
    <Server>DESKTOP-US930J5\SQLEXPRESS</Server>
    <Database>Linq_db </Database>
  </Connection>
</Query>

//----Inner join-----//

// Inner join will only gives the comman values of the two table. // 

 var res = from e1 in Employees 
                    join e2 in Employee_departments 
                        on e1.Emp_id equals e2.Emp_id 
                            select new 
                            { 
                                Emp_Name = e1.Emp_name, 
                                Emp_Department = e2.Dep_name
                            };
							Console.WriteLine(res);   