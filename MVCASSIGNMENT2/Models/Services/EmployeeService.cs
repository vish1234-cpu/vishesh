using MVCASSIGNMENT2.Models.Entity;
using MVCASSIGNMENT2.Models.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCASSIGNMENT2.Models.Services
{
    public class EmployeeService:IEmployee 
    {
        private readonly MVC2Entities _ent; 
        public EmployeeService()
        {
            _ent = new MVC2Entities(); 
        }

        public IEnumerable<Employee> GetEmployees()
        {
            try
            {
                var result = _ent.Employees.Select(e => e).ToList(); // using method syntext form of linq . 
                return result;
            }
            catch(Exception ex)
            {
                throw ex; 
            }
          
        }
        public bool InsertEmployee(Employee employee) // insert method 
        {
            try
            {
                _ent.Employees.Add(employee);
                _ent.SaveChanges();
                return true; 
            }
            catch(Exception ex)
            {
                throw ex; 
            }
           
        }
    }
}