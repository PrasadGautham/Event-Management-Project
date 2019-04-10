using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using projectevent.ViewModel;



namespace projectevent.Models
{
    public class Custmerlogrepo
    {
        private static eventDBEntities context = new eventDBEntities();
        public static bool Login(string username,string password)
        {
            //  eventDBEntities context = new eventDBEntities();
            var u = username;

            var p = password;

            var q = from e in context.customers
                    where e.customer_username == u && e.customer_password == p
                    select e.customerID;
                
            if (q.Any())
            {
                return true;
                //HttpContext ctx = HttpContext.Current;
                //ctx.Session["custid"] = q;
                  

            }
            return false;
        }

    }
}