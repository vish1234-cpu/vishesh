using System;
using System.Collections.Generic;

namespace BlazorAdvanceAssignment.Models
{
    public partial class Student
    {
        public int Id { get; set; }
        public string StudentName { get; set; }
        public string StudentGender { get; set; }
        public string StudentAddress { get; set; }
        public int StudentAge { get; set; }
    }
}
