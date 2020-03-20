using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace CODEFIRST.Models
{
    public class Products
    {
        public Products()
        {
            Orders = new HashSet<Orders>();
        }

        [Key]
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int ProductQuantity { get; set; }
        public int ProductCost { get; set; }

        public virtual ICollection<Orders> Orders { get; set; } 
    }
}
