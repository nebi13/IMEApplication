//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LoginForm.DataSet
{
    using System;
    using System.Collections.Generic;
    
    public partial class DiscountValue
    {
        public int ID { get; set; }
        public string Arcticle_No { get; set; }
        public string Arcticle_Name { get; set; }
        public string BrandID { get; set; }
        public string SectionID { get; set; }
        public string SuperSection_No { get; set; }
        public string CustomerID { get; set; }
        public Nullable<int> RepresentativeID { get; set; }
        public Nullable<System.DateTime> First_date { get; set; }
        public Nullable<System.DateTime> Finish_date { get; set; }
        public string Discount_Rate { get; set; }
    
        public virtual SlidingPrice SlidingPrice { get; set; }
        public virtual Worker Worker { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
