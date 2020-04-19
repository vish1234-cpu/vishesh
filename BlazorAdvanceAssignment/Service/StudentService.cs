using BlazorAdvanceAssignment.Interface;
using BlazorAdvanceAssignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorAdvanceAssignment.Service
{
    public class StudentService:IStudent  
    {
        private readonly AdvanceBlazorContext _adc;
        public StudentService(AdvanceBlazorContext advanceBlazorContext)
        {
            _adc = advanceBlazorContext; 
        }

        public List<Student> GetStudents()
        {
            try
            {
                var result = _adc.Student.Select(s => s).ToList();
                return result;
            }
            catch(Exception ex)
            {
                throw ex; 
            }
         
        }

        public Student GetStudentsById(int id) 
        {
            try
            {
                Student result = _adc.Student.FirstOrDefault(s=>s.Id==id);  
                return result;
            }
            catch(Exception ex)
            {
                throw ex; 
            }
        }

        public bool Insert(Student student)
        {
          try
            {
                _adc.Student.Add(student);
                _adc.SaveChanges();
                return true;
            }
            catch(Exception ex)
            {
                throw ex; 
            }
        }

        public bool Update(Student student)
        {
            try
            {

                _adc.Student.Update(student);
                _adc.SaveChanges();
                return true;
            }
            catch(Exception ex)
            {
                throw ex; 
            }
        }

        public bool Delete(Student student)
        {
            try
            {

                _adc.Student.Remove(student);
                _adc.SaveChanges();
                return true;
            }
            catch(Exception ex)
            {
                throw ex; 
            }
        }
    }
}
