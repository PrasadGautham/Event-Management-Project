using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace projectevent.ViewModel
{
    public class venueorgview
    {
        public int venueID { get; set; }
        public string venue_name { get; set; }
        public string venue_location { get; set; }
        public string venue_address { get; set; }
        public int venue_capacity { get; set; }
        public string venue_category { get; set; }
        public string venue_video { get; set; }
        public bool venue_status { get; set; }
        public int venue_cost { get; set; }
        public int vendorID { get; set; }
        public int agentId { get; set; }
        public int photographyId { get; set; }
    }
}