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
    
    public partial class ContraDetail
    {
        public decimal contraDetailsId { get; set; }
        public Nullable<decimal> contraMasterId { get; set; }
        public Nullable<decimal> ledgerId { get; set; }
        public Nullable<decimal> amount { get; set; }
        public Nullable<int> exchangeRateId { get; set; }
        public string chequeNo { get; set; }
        public Nullable<System.DateTime> chequeDate { get; set; }
    
        public virtual ContraMaster ContraMaster { get; set; }
        public virtual ExchangeRate ExchangeRate { get; set; }
    }
}