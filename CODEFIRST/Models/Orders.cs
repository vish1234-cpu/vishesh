using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace CODEFIRST.Models
{
    public class Orders
    {
        [Key]
        public int OrderId { get; set; }
        public int? CusId { get; set; }
        public int? ProductId { get; set; }
        public string OrderAddress { get; set; }

        public virtual Customers Cus { get; set; }
        public virtual Products Product { get; set; }
    }
}
