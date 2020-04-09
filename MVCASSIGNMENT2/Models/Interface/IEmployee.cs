using MVCASSIGNMENT2.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCASSIGNMENT2.Models.Interface
{
    public interface IEmployee
    {
        IEnumerable<Employee> GetEmployees(); 
        bool InsertEmployee(Employee employee); 
    }
}
