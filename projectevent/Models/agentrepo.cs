using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using projectevent.ViewModel;

namespace projectevent.Models
{
    public class agentrepo
    {
        private static eventDBEntities context = new eventDBEntities();




        public static string getemail(int vendorid, int customerid)
        {
            eventDBEntities context = new eventDBEntities();
            var customerandvenuedetails = from a in context.bookedvenues
                                          join c in context.venues on a.venueID equals c.venueID
                                          join b in context.customers on a.customerID equals b.customerID
                                          join d in context.agents on c.agentId equals d.agentID
                                          join e in context.photographies on c.photographyId equals e.photographyID
                                          where c.vendorID == vendorid && b.customerID == customerid
                                          select new { agent = d.agent_email };
            System.Diagnostics.Debug.WriteLine("hello");
            foreach (var ef in customerandvenuedetails)
                System.Diagnostics.Debug.WriteLine(ef.agent);
            return customerandvenuedetails.ToString();

        }
        public static List<Vvendor_det_to_admin_for_checking> acceptvendor(int id)
        {
            eventDBEntities context = new eventDBEntities();
            var vendordetails = from a in context.vendors
                                where a.vendorID == id
                                select a;


            foreach (var re in vendordetails)
            {
                re.vendor_status = true;

            }
            context.SaveChanges();

            return getvendordetails();

        }

        public static void deletevendor(int id)
        {
            eventDBEntities context = new eventDBEntities();
            var vendordetails = from a in context.vendors
                                where a.vendorID == id
                                select a;

            foreach (var re in vendordetails)
            {
                context.vendors.Remove(re);
            }
            context.SaveChanges();

        }
        public static List<Vvendor_det_to_admin_for_checking> getvendordetails()
        {

            eventDBEntities context = new eventDBEntities();
            var vendordetails = (from a in context.vendors
                                 select new Vvendor_det_to_admin_for_checking { vendorID = a.vendorID, vendor_Fname = a.vendor_Fname, vendor_Lname = a.vendor_Lname, vendor_category = a.vendor_category, vendor_address = a.vendor_address, vendor_status = a.vendor_status, vendor_username = a.vendor_username }).ToList();

            return vendordetails;
        }

        public static bool addreview(review rev)
        {
            eventDBEntities context = new eventDBEntities();
            try
            {
                context.reviews.Add(rev);
                context.SaveChanges();
                return true;
            }
            catch
            {
                throw;
            }
        }
        public static venue Getvenue(int id)
        {
            var r = from i in context.venues
                    where i.venueID == id
                    select i;
            return r.SingleOrDefault();
        }
        public static customer Getcustomer(int id)
        {
            var r = from i in context.customers
                    where i.customerID == id
                    select i;
            return r.SingleOrDefault();
        }
        public static List<reviewview> reviewdatabasedonvenue(int id)
        {
            eventDBEntities context = new eventDBEntities();
            var reviewpost = (from a in context.reviews
                              join c in context.customers on a.customerID equals c.customerID
                              where a.venueID == id


                              select new reviewview { review_content = a.review_content, review_rating = a.review_rating, customer_username = c.customer_username }).ToList();


            return reviewpost;


        }
        public static List<VCustomer_and_agent_details_for_vendor_to_sent_email> acceptbook(int id)
        {
            eventDBEntities context = new eventDBEntities();
            var book = from a in context.bookedvenues
                       where a.bookedvenueID == id
                       select a;


            foreach (var re in book)
            {
                re.bookingstatus = true;

            }
            context.SaveChanges();

            return getcustomerandvenuedetails();

        }
        public static List<VCustomer_and_agent_details_for_vendor_to_sent_email> getcustomerandvenuedetails()
        {
            eventDBEntities context = new eventDBEntities();

            var customerandvenuedetails = (from a in context.bookedvenues
                                           join c in context.venues on a.venueID equals c.venueID
                                           join b in context.customers on a.customerID equals b.customerID
                                           join d in context.agents on c.agentId equals d.agentID
                                           join e in context.photographies on c.photographyId equals e.photographyID


                                           select new VCustomer_and_agent_details_for_vendor_to_sent_email

                                           {
                                               bookedvenueID = a.bookedvenueID,
                                               agentID = d.agentID,
                                               venue_category = c.venue_category,
                                               bookeddate = a.bookeddate,
                                               bookedfoodtype = a.bookedfoodtype,
                                               customer_Fname = b.customer_Fname,
                                               customer_Lname = b.customer_Lname,
                                               customer_address = b.customer_address,
                                               customer_phone = b.customer_phone,
                                               photographer_name = e.photographer_name,
                                               photographer_phone = e.photographer_phone,
                                               agent_name = d.agent_name,
                                               agent_email = d.agent_email,
                                               venue_name = c.venue_name,
                                               bookingstatus = a.bookingstatus
                                           }).ToList();

            return customerandvenuedetails;
        }



        public static bool Login(string username, string password)
        {
            //  eventDBEntities context = new eventDBEntities();
            eventDBEntities context = new eventDBEntities();
            var u = username;

            var p = password;

            var q = from e in context.Admins
                    where e.username == u && e.password == p
                    select e.AdminID;

            if (q.Any())
            {
                return true;


            }
            return false;
        }
        public static List<customerview1> custdet()
        {
            eventDBEntities context = new eventDBEntities();


            var customerandvenuedetails = (from a in context.bookedvenues
                                           join c in context.venues on a.venueID equals c.venueID
                                           join b in context.customers on a.customerID equals b.customerID
                                           join d in context.agents on c.agentId equals d.agentID
                                           join e in context.photographies on c.photographyId equals e.photographyID
                                           join f in context.vendors on c.vendorID equals f.vendorID
                                           select new customerview1

                                           {
                                               customer_username = b.customer_username,
                                               customer_address = b.customer_address,
                                               customer_phone = b.customer_phone,
                                               agent_name = d.agent_name,
                                               agent_email = d.agent_email,
                                               bookingstatus = a.bookingstatus,
                                               venue_name = c.venue_name,
                                               vendor_username = f.vendor_username,
                                               bookeddate = a.bookeddate
                                           }).ToList();

            return customerandvenuedetails;
        }



























        public static List<agentview> getallagent()
        {
          //  eventDBEntities context = new eventDBEntities();
            var q = from e in context.agents
                    select new agentview {agentID=e.agentID,  agent_email = e.agent_email, agent_name = e.agent_name, agent_phone = e.agent_phone };
            return q.ToList();
        }
        public static bool InsertAgent(agent newagent)
        {
            try
            {
                context.agents.Add(newagent);
                context.SaveChanges();
                return true;
            }
            catch
            {
                throw;
            }
        }
        public static agent GetAgent(int agentid)
        {
            var res1 = from emp in context.agents
                       where emp.agentID == agentid
                       select emp;
            return res1.SingleOrDefault();
        }
        public static bool UpdateAgent(agent modagent)
        {
            var query = from e in context.agents
                        where e.agentID == modagent.agentID
                        select e;
            if (query.Any())
            {
                var ExEmp = query.First();
                ExEmp.agent_name = modagent.agent_name;
                ExEmp.agent_phone = modagent.agent_phone;
                ExEmp.agent_email= modagent.agent_email;
                context.SaveChanges();
                
                return true;
            }
            return false;
            }
        public static List<agentview> DeleteAgent(int agentID)
           {
               var agent = GetAgent(agentID);
            if(agent != null)
            {
                context.agents.Remove(agent);
                context.SaveChanges();
                
            }

            return getallagent();
        
          }
    }
}