<Query Kind="Statements">
  <Connection>
    <ID>03b87378-7e8d-47bb-b48a-386f4aa3dcd4</ID>
    <NamingServiceVersion>2</NamingServiceVersion>
    <Persist>true</Persist>
    <Server>DESKTOP-US930J5\SQLEXPRESS</Server>
    <Database>Linq_db </Database>
  </Connection>
</Query>

//---Left Join ---// 

// whole left table and comman values of right table. //

var res = from e1 in Employees 
                    join e2 in Employee_departments 
                        on e1.Emp_id equals e2.Emp_id 
                            select new 
                            { 	Emp_id = e1.Emp_id,
								Emp_address = e1.Emp_address,
                                Emp_Name = e1.Emp_name, 
								Emp_salary =e1.Emp_salary, 
                                Emp_Department = e2.Dep_name
                            };
							Console.WriteLine(res);   