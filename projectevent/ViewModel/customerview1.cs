using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace projectevent.ViewModel
{
    public class customerview1
    {
        public int customerID { get; set; }
        public string customer_username { get; set; }
        public string customer_address { get; set; }
        public int customer_phone { get; set; }
        public bool bookingstatus { get; set; }
        public string agent_name { get; set; }
        public string agent_email { get; set; }
        public string venue_name { get; set; }
        public string vendor_username { get; set; }
        public DateTime bookeddate { get; set; }
        
    }
}