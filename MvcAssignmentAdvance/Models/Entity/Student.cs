﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcAssignmentAdvance.Models.Entity
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string  Email { get; set; } 
        public DateTime DOB { get; set; }
        public string   Gender { get; set; }
        public string PhotoPath { get; set; } 
    }
}