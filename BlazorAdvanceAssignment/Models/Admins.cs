using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations; 

namespace BlazorAdvanceAssignment.Models
{
    public partial class Admins
    {
        public int AdminId { get; set; }

        [Required(ErrorMessage = "This is a Required Field ")]
        public string AdminName { get; set; }

        [Required(ErrorMessage = "This is a Required Field ")] 
        public string Passkey { get; set; }
    }
}
