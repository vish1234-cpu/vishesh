using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WEBAPPLICATION_DBFIRST.Models;

namespace WEBAPPLICATION_DBFIRST.Data
{
    public class Class : IClass
    {

        // <summary>
        /// 
        /// GET METHOD  TO GET CUSTOMER AND ORDER DETAILS 
        /// <returns></returns>
        public IEnumerable<Customers> GETDATA()
        {
            try
            {
                var context = new DBFIRSTNEWContext();

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
                var context = new DBFIRSTNEWContext();
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

        public string INSERTDATA(Orders orders) 
        {
            var context = new DBFIRSTNEWContext();
            try
            {

                context.Orders.Add(orders);
                context.Customers.Add(orders.Cus);
                context.Products.Add(orders.Product);  
                context.SaveChanges();
                return "DATA INSERTED SUCCESSFULLY!!";

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // <summary>
        /// 
        /// UPDATE METHOD THIS METHOD IS NOT UPDATING THE VALUES INSTEAD IT IS CREATING A NEW RECORD. 
        /// <returns></returns>

        public string UPDATEDATA(int id)
        {
            try
            {
                var context = new DBFIRSTNEWContext();

                var result = context.Customers.FirstOrDefault(c => c.CusId == id);
                context.Customers.Update(result);
                context.SaveChanges();

                return "DATA UPDATED SUCCESSFULLY";
            }
            catch(Exception ex)
            {
                throw ex; 
            }
           
        }

        // <summary>
        /// 
        /// DELETE METHOD   
        /// <returns></returns>

        public string DELETEDATA(int id)    
        {
            try
            {

                var context = new DBFIRSTNEWContext();

                var result = context.Customers.FirstOrDefault(i => i.CusId == id);
                context.Customers.Remove(result);

                var result1 = context.Orders.FirstOrDefault(i => i.OrderId == id); 
                context.Orders.Remove(result1); 

               

                context.SaveChanges(); 

                return "DATA DELETED SUCCESSFULLY!!";

            }


               
            
            catch(Exception ex)
            {
                throw ex; 
            }

        }
    }
}
