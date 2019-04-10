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
    
    public partial class venue
    {
        public venue()
        {
            this.bookedvenues = new HashSet<bookedvenue>();
            this.payments = new HashSet<payment>();
            this.reviews = new HashSet<review>();
         
        }
    
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
    
        public virtual agent agent { get; set; }
        public virtual ICollection<bookedvenue> bookedvenues { get; set; }
        public virtual ICollection<payment> payments { get; set; }
        public virtual photography photography { get; set; }
        public virtual ICollection<review> reviews { get; set; }
        public virtual vendor vendor { get; set; }
    }
}
