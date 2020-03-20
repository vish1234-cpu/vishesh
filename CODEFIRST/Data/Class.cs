using CODEFIRST.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CODEFIRST.Data
{
    public class Class :IClass
    {
        public ClassContext _con; // dependency injection for my ClassContext() 

        public Class(ClassContext con)
        {
            _con = con; 
        }


        // <summary>
        /// 
        /// GET METHOD  TO GET CUSTOMER AND ORDER DETAILS 
        /// <returns></returns>
        public IEnumerable<Customers> GETDATA()
        {
            try
            { 
                var cus = (from e in _con.Customers.Include("Orders") select e); 
                return cus.ToList();
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        // <summary>
        /// 
        /// GET METHOD TO GET CUSTOMER,ORDER,PRODUCT DETAILS BY ID. 
        /// <returns></returns>

        public IEnumerable<Customers> GETDATAID(int id)
        {
            try
            {
                var cus = (from c in _con.Customers.Where(c => c.CusId == id).Include(s => s.Orders).ThenInclude(s => s.Product) select c);
                return cus.ToList();
            }

            catch (Exception ex)
            {
                throw ex;
            }


        }

        // <summary>
        /// 
        /// INSERT  METHOD  THIS WILL INSERT THE ROW IN CUSTOMER TABLE ONLY. 
        /// <returns></returns>
        /// 

        /*
        * IN Insert Method PASS Following details IN BODY 
        * 
        *{"OrderAddress":**,
        * "Cus":{
        * "CusFirstName":**,
        * "CusLastName":**,
        * },
        * "Product"{
        * "ProductName":**,
        * "ProductQuantity":**,
        * "ProductCost":**
        * }
        * } */ 


        public bool INSERTDATA(Orders orders) 
        {
            
            try
            {

                _con.Orders.Add(orders);
                _con.Customers.Add(orders.Cus);
                _con.Products.Add(orders.Product);
                _con.SaveChanges();
                return true; 

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // <summary>
        /// 
        /// UPDATE  METHOD  WILL UPDATE THE ROW IN ORDERS TABLE. (NOT WORKING UP TO THE MARK) 
        /// <returns></returns>
        /// 
        public bool UPDATEDATA(Orders orders,int id)   
        {
            var result = _con.Orders.Include(c => c.Cus).FirstOrDefault(s=>s.OrderId==id); 
            result.Cus.CusId = (int)orders.CusId;
            result.OrderId = orders.OrderId; 
            _con.Entry(result).State = EntityState.Modified;  
            _con.SaveChanges();
            return true; 
        }


        // <summary>
        /// 
        /// DELETE METHOD   
        /// <returns></returns>


        /*
         * IN DELETE METHOD PASS CUSID ORDERID AND PRODUCTID IN BODY 
         * 
         *{"CUSID":**,
         * "OrderId":**,
         * "ProductId":**
         * } 
         */
        public bool DELETEDATA(Orders orders)  
        {
            try
            {
                 

                var result = _con.Customers.FirstOrDefault(i => i.CusId == orders.CusId);
                _con.Customers.Remove(result);

                var result1 = _con.Orders.FirstOrDefault(i => i.OrderId == orders.OrderId);
                _con.Orders.Remove(result1);

                var result2 = _con.Products.FirstOrDefault(i => i.ProductId == orders.ProductId);
                _con.Products.Remove(result2);




                _con.SaveChanges();

                return true; 

            }




            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
