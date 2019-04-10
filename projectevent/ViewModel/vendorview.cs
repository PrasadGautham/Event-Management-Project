using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace projectevent.ViewModel
{
    public class vendorview
    {
        public int vendorID { get; set; }
        public string vendor_Fname { get; set; }
        public string vendor_Lname { get; set; }
        public string vendor_address { get; set; }
        public string vendor_phone { get; set; }
        public string vendor_username { get; set; }
        public string vendor_password { get; set; }
        public string vendor_category { get; set; }
        public bool vendor_status { get; set; }
    }
}