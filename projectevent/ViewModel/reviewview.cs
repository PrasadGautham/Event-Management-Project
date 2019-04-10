using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace projectevent.ViewModel
{
    public class reviewview
    {
        public int reviewID { get; set; }
        public string review_content { get; set; }
        public double review_rating { get; set; }
        public string customer_username{get;set;}
        public int customerID { get; set; }
        public int venueID { get; set; }
    }
}