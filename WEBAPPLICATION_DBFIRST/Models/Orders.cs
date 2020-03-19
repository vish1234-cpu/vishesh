using System;
using System.Collections.Generic;

namespace WEBAPPLICATION_DBFIRST.Models
{
    public partial class Orders
    {
        public int OrderId { get; set; }
        public int? CusId { get; set; }
        public int? ProductId { get; set; }
        public string OrderAddress { get; set; }

        public virtual Customers Cus { get; set; }
        public virtual Products Product { get; set; }
    }
}
