using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using projectevent.Models;
using projectevent.ViewModel;


namespace projectevent.Models
{
    public class vendorrepo
    {
        private static eventDBEntities context = new eventDBEntities();
        public static List<vendorview> getvendor(int Id)
        {
             eventDBEntities context = new eventDBEntities();
            var q = from v in context.vendors
                    where v.vendorID==Id
                    select new vendorview{
                    vendor_Fname=v.vendor_Fname,
                    vendor_Lname=v.vendor_Lname,
                    vendor_address=v.vendor_address,
                    vendor_category=v.vendor_category,
                    vendor_status=v.vendor_status,
                    vendor_username=v.vendor_username,
                    vendor_password=v.vendor_password};
            return q.ToList();
        }
        public static bool RegisterVendor(vendor NewVendor)
        {
            try
            {
                context.vendors.Add(NewVendor);
                context.SaveChanges();
               
                //var k = (from p in context.vendors
                //        orderby p.vendorID descending
                //        select p)
                return true;
            }
            catch
            {
                throw;
            }
        }
        public static int Login(string username, string password)
        {
            //  eventDBEntities context = new eventDBEntities();
            var u = username;
            int k = 0;
            var p = password;

            var q = from e in context.vendors
                    where e.vendor_username == u && e.vendor_password == p
                    select e.vendorID;

            
            if (q.Any())
            {
                //return getvendor(q).ToList();
                
                //HttpContext con = HttpContext.Current;
                //con.Session["cusid"] = "6";  
                
                //foreach (var s in q)
                //{

                //    var res = getvendor(s.vendorID);
                //}
                //HttpContext ctx = HttpContext.Current;
                //ctx.Session["custid"] = q;
                k= q.First();
                return k;
               
            }
            return k;
        }

    }
}