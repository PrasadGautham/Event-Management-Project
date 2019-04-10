using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace projectevent.ViewModel
{
    public class VCustomer_and_agent_details_for_vendor_to_sent_email
    {
        public int bookedvenueID { get; set; }
        public int agentID { get; set; }
        public int customerID { get; set; }
        public int vendorID { get; set; }
        public string venue_category { get; set; }
        public DateTime bookeddate { get; set; }
        public string bookedfoodtype { get; set; }
        public string customer_Fname { get; set; }
        public string customer_Lname { get; set; }
        public string customer_address { get; set; }
        public int customer_phone { get; set; }
        public string photographer_name { get; set; }
        public int photographer_phone { get; set; }
        public string agent_name { get; set; }
        public string agent_email { get; set; }
        public bool bookingstatus { get; set; }
        public string venue_name { get; set; }
        
    }
}