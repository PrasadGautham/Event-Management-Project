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
    
    public partial class bookedvenue
    {
        public int bookedvenueID { get; set; }
        public System.DateTime bookeddate { get; set; }
        public bool bookingstatus { get; set; }
        public string bookedfoodtype { get; set; }
        public int venueID { get; set; }
        public int customerID { get; set; }
    
        public virtual customer customer { get; set; }
        public virtual venue venue { get; set; }
    }
}