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
    
    public partial class SalesReturnBillTax
    {
        public decimal salesReturnBillTaxId { get; set; }
        public Nullable<decimal> salesReturnMasterId { get; set; }
        public Nullable<decimal> taxId { get; set; }
        public Nullable<decimal> taxAmount { get; set; }
    
        public virtual SalesReturnMaster SalesReturnMaster { get; set; }
    }
}
