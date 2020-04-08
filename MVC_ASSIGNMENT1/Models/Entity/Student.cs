using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_ASSIGNMENT1.Models.Entity
{
    public class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }

    }
}