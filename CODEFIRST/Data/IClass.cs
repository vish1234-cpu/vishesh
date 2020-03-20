using CODEFIRST.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CODEFIRST.Data
{
    public interface IClass
    {
        public IEnumerable<Customers> GETDATA();
        public IEnumerable<Customers> GETDATAID(int id);
        public bool INSERTDATA(Orders orders);
        public bool UPDATEDATA(Orders orders,int id);    
        public bool DELETEDATA(Orders orders);
       
    }
}
