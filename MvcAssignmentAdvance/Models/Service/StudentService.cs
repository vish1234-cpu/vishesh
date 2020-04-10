using MvcAssignmentAdvance.Models.Entity;
using MvcAssignmentAdvance.Models.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcAssignmentAdvance.Models.Service
{
    public class StudentService:IStudent 
    {
        List<Student> stdlist = new List<Student>()
        {
            new Student() {Id=1,FirstName="Ram",LastName="Singh",Address="Delhi",Gender="Male",DOB= new DateTime(1998, 10, 20),Email="ram@gmail.com",PhotoPath="IMAGES/admin.jpg"},
            new Student() {Id=2,FirstName="Rohan",LastName="Kumar",Address="kerela",Gender="Male",DOB= new DateTime(1998, 1, 2),Email="ram@gmail.com",PhotoPath="IMAGES/admin.jpg"},
            new Student() {Id=3,FirstName="Mohit",LastName="Kapoor",Address="Mumbai",Gender="Male",DOB= new DateTime(1998, 11, 30),Email="ram@gmail.com",PhotoPath="IMAGES/admin.jpg"},
            new Student() {Id=4,FirstName="Salman",LastName="Sethi",Address="Chennai",Gender="Male",DOB= new DateTime(1998, 1, 20),Email="ram@gmail.com",PhotoPath="IMAGES/admin.jpg"},
            new Student() {Id=5,FirstName="Arpit",LastName="Khanna",Address="Banglore",Gender="Male",DOB= new DateTime(1998, 4, 10),Email="ram@gmail.com",PhotoPath="IMAGES/admin.jpg"}  
        };

        public IEnumerable<Student> GetStudents()
        {
            try
            {
                var result = stdlist.Select(s => s).ToList();
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public IEnumerable<Student> GetById(int id)
        {
            try
            {
                var result = stdlist.Select(e => e).Where(e => e.Id == id).ToList();
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

    }
}