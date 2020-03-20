using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations; 


namespace CODEFIRST.Models
{
    public class Customers
    {
       
            public Customers()
            {
                Orders = new HashSet<Orders>();
            }

            [Key]
            public int CusId { get; set; }
            public string CusFirstName { get; set; }
            public string CusLastName { get; set; }

            public virtual ICollection<Orders> Orders { get; set; }
        
    }
}
