using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using project.View_model;
using System.Globalization;

namespace projectevent.Models
{
    public class searchlinq
    {
        private static eventDBEntities context = new eventDBEntities();
        public static List<search> searchby(string searchtext)
        {

            eventDBEntities context = new eventDBEntities();
            var querysearch = from e in context.venues
                              where e.venue_location.Contains(searchtext)
                              select new search
                              {
                                  venueID = e.venueID,
                                  venuename = e.venue_name,
                                  venue_location = e.venue_location,
                                  venue_image = e.venue_video,
                                  venue_capacity = e.venue_capacity,
                                  venue_cost = e.venue_cost,
                                  venue_category = e.venue_category
                              };


            return querysearch.ToList();
        
        }

        
        
        public static List<search> searchall()
        {
            eventDBEntities context = new eventDBEntities();
            var querysearch = from e in context.venues
                              select new search{
                                  venueID=e.venueID,
                              venuename=e.venue_name,
                              venue_location=e.venue_location,
                              venue_image=e.venue_video,
                              venue_capacity=e.venue_capacity,
                              venue_cost=e.venue_cost,
                              venue_category=e.venue_category
                              };
                        

            return querysearch.ToList();
        }

        public static bool Getavail(string date1,int vid)
        {
            string newdate = date1.Replace("-", "/");
            //System.Threading.Thread.CurrentThread.CurrentCulture = new CultureInfo("en-CA");
            DateTime dt = DateTime.Parse(newdate); 
            eventDBEntities context = new eventDBEntities();
            var datecheck = (from d in context.bookedvenues
                             where d.bookeddate ==dt && d.venueID == vid
                             select d).ToList();

            if (datecheck.Any())
            {

                return true;
            }
            else {
                return false;
            
            }
            // return custDBContext.bookeds.Include("customers").ToList();
        }

        public static List<search> Getvenue(int vid)
        {
            eventDBEntities context = new eventDBEntities();
            var query = from e in context.venues
                              where e.venueID==vid
                              select new search
                              {
                                  venueID = e.venueID,
                                  venuename = e.venue_name,
                                  venue_location = e.venue_location,
                                  venue_image = e.venue_video,
                                  venue_capacity = e.venue_capacity,
                                  venue_cost = e.venue_cost,
                                  venue_category = e.venue_category
                              };


            return query.ToList();
        }

        
    }
}