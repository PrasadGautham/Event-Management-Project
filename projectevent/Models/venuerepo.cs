using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using projectevent.ViewModel;
namespace projectevent.Models
{
    public class venuerepo
    {
        private static eventDBEntities context = new eventDBEntities();
        public static List<venueview> getallvenues()
        {
            eventDBEntities context = new eventDBEntities();
            var res2 = (from p in context.venues
                        join s in context.photographies
                        on p.photographyId equals s.photographyID
                        join m in context.agents
                        on p.agentId equals m.agentID
                        select new venueview
                        {
                            venueID = p.venueID,
                            venue_name = p.venue_name,
                            venue_location = p.venue_location,
                            venue_address = p.venue_address,
                            venue_capacity = p.venue_capacity,
                            venue_category = p.venue_category,
                            venue_status = p.venue_status,
                            venue_cost = p.venue_cost,
                            photographer_name = s.photographer_name,
                            agent_name = m.agent_name
                        });
            return res2.ToList();

        }
        public static bool InsertVenue(venue newvenue)
        {
            eventDBEntities context = new eventDBEntities();
            try
            {
                context.venues.Add(newvenue);
                context.SaveChanges();
                return true;
            }
            catch
            {
                throw;
            }
        }
        public static venueorgview GetVenue(int venueid)
        {
            var res1 = from v in context.venues
                       where v.venueID == venueid
                       select new venueorgview
                       {
                           vendorID = v.venueID,
                           venue_name = v.venue_name,
                           venue_address = v.venue_address,
                           venue_capacity = v.venue_capacity,
                           venue_category = v.venue_category,
                           venue_cost = v.venue_cost,
                           venue_location = v.venue_location,
                           venue_status = v.venue_status,
                           venue_video = v.venue_video,
                           venueID = v.venueID,
                           agentId = v.agentId,
                           photographyId = v.agentId

                       };
            return res1.SingleOrDefault();
        }

        public static bool UpdateVenue(venueorgview modvenue)
        {

            var query = from e in context.venues
                        where e.venueID == modvenue.venueID
                        select e;
            if (query.Any())
            {

                var ExEmp = query.First();
                ExEmp.venue_name = modvenue.venue_name;
                ExEmp.venue_location = modvenue.venue_location;
                ExEmp.venue_address = modvenue.venue_address;
                ExEmp.venue_capacity = modvenue.venue_capacity;
                ExEmp.venue_category = modvenue.venue_category;
                ExEmp.venue_video = modvenue.venue_video;
                ExEmp.venue_status = modvenue.venue_status;
                ExEmp.venue_cost = modvenue.venue_cost;
                ExEmp.vendorID = modvenue.vendorID;
                ExEmp.agentId = modvenue.agentId;
                ExEmp.photographyId = modvenue.photographyId;
                context.SaveChanges();

                return true;
            }
            return false;
        }

    }
}