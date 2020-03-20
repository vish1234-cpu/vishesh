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
        // <summary>
        /// 
        /// GET METHOD  TO GET CUSTOMER AND ORDER DETAILS 
        /// <returns></returns>
        public IEnumerable<Customers> GETDATA()
        {
            try
            {
                var context = new ClassContext();

                var cus = (from e in context.Customers.Include("Orders") select e); 
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
                var context = new ClassContext();
                var cus = (from c in context.Customers.Where(c => c.CusId == id).Include(s => s.Orders).ThenInclude(s => s.Product) select c);
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
            var context = new ClassContext();
            try
            {

                context.Orders.Add(orders);
                context.Customers.Add(orders.Cus);
                context.Products.Add(orders.Product);
                context.SaveChanges();
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
            var context = new ClassContext();
            var result = context.Customers.FirstOrDefault(i => i.CusId == id);  
            var result1 = context.Orders.Add(orders);  
            context.SaveChanges(); 
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
                var context = new ClassContext();  

                var result = context.Customers.FirstOrDefault(i => i.CusId == orders.CusId);
                context.Customers.Remove(result);

                var result1 = context.Orders.FirstOrDefault(i => i.OrderId == orders.OrderId);
                context.Orders.Remove(result1);

                var result2 = context.Products.FirstOrDefault(i => i.ProductId == orders.ProductId);
                context.Products.Remove(result2);




                context.SaveChanges();

                return true; 

            }




            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
