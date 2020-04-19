using BlazorAdvanceAssignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorAdvanceAssignment.Interface
{
    public interface IStudent
    {
        List<Student> GetStudents();
        Student GetStudentsById(int id); 
        bool Insert(Student student);
        bool Update(Student student);
        bool Delete(Student student); 
    }
}
