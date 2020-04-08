using MVC_ASSIGNMENT1.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_ASSIGNMENT1.Models.Interface
{
    public interface IStudent
    {
        IEnumerable<Student> GetAllStudents(); 
    }
}
