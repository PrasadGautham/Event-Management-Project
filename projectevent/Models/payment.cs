//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace projectevent.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class payment
    {
        public int paymentID { get; set; }
        public System.DateTime payment_date { get; set; }
        public double total_amount { get; set; }
        public int customerID { get; set; }
        public int venueID { get; set; }
    
        public virtual customer customer { get; set; }
        public virtual venue venue { get; set; }
    }
}
