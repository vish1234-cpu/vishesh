using MvcAssignmentAdvance.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcAssignmentAdvance.Models.Interface
{
    public interface IStudent
    {
        IEnumerable<Student> GetStudents();
        IEnumerable<Student> GetById(int id);
    }
}
