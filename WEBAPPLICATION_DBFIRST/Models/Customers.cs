using System;
using System.Collections.Generic;

namespace WEBAPPLICATION_DBFIRST.Models
{
    public partial class Customers
    {
        public Customers()
        {
            Orders = new HashSet<Orders>();
        }

        public int CusId { get; set; }
        public string CusFirstName { get; set; }
        public string CusLastName { get; set; }

        public virtual ICollection<Orders> Orders { get; set; }
    }
}
