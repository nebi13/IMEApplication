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
    
    public partial class Receipt
    {
        public int ReceiptID { get; set; }
        public int ReceiptTypeID { get; set; }
        public string No { get; set; }
        public decimal Amount { get; set; }
        public decimal CurrencyID { get; set; }
        public System.DateTime Date { get; set; }
        public int CurrentID { get; set; }
        public string Description { get; set; }
        public int RepresentativeID { get; set; }
    
        public virtual Currency Currency { get; set; }
        public virtual Current Current { get; set; }
        public virtual ReceiptType ReceiptType { get; set; }
        public virtual Worker Worker { get; set; }
    }
}
