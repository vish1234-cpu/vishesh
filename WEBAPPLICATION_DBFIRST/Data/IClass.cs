using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WEBAPPLICATION_DBFIRST.Models;

namespace WEBAPPLICATION_DBFIRST.Data
{
    public interface IClass
    {
        public IEnumerable<Customers> GETDATA();
        public IEnumerable<Customers> GETDATAID(int id); 

        public string INSERTDATA(Orders orders); 

        public string UPDATEDATA(int id); 

        public string DELETEDATA(int id);   


    }
}
