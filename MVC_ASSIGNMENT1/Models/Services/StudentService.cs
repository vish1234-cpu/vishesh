using MVC_ASSIGNMENT1.Models.Entity;
using MVC_ASSIGNMENT1.Models.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_ASSIGNMENT1.Models.Services
{
     public class StudentService:IStudent  
    {
        List<Student> stdlist = new List<Student>()
        {
            new Student(){StudentId=1,StudentName="Azeem Faisal",Gender="Male",Address="Delhi",Email="azeem@ttn.com"},
            new Student(){StudentId=2,StudentName="Arpit Deora",Gender="Male",Address="Dehradun",Email="arpit@ttn.com"},
            new Student(){StudentId=3,StudentName="Vishesh Kapoor",Gender="Male",Address="Delhi",Email="vishesh@ttn.com"},
            new Student(){StudentId=4,StudentName="Vijay Kumar",Gender="Male",Address="Aligargh",Email="vijay@ttn.com"},
            new Student(){StudentId=5,StudentName="Abhishek Kumar",Gender="Male",Address="Allahbad",Email="abhishek@ttn.com"} 
        };

        public IEnumerable<Student> GetAllStudents()
        {
           try
            {
                var result = (from std in stdlist select std).ToList();
                return result; 
            }
            catch(Exception ex)
            {
                throw ex; 
            }

        }
    }
}
