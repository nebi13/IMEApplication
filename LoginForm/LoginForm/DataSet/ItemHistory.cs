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
    
    public partial class ItemHistory
    {
        public int ID { get; set; }
        public string VoucherNumber { get; set; }
        public Nullable<System.DateTime> VoucherDate { get; set; }
        public Nullable<decimal> VoucherTypeID { get; set; }
        public string CurrentCustomerID { get; set; }
        public Nullable<int> InputQuantity { get; set; }
        public Nullable<decimal> InputAmount { get; set; }
        public Nullable<decimal> InputTotalAmount { get; set; }
        public Nullable<int> OutputQuantity { get; set; }
        public Nullable<decimal> OutputAmount { get; set; }
        public Nullable<decimal> OutputTotalAmount { get; set; }
        public Nullable<decimal> FinalTotal { get; set; }
        public Nullable<decimal> CurrencyID { get; set; }
        public Nullable<decimal> ExchangeRate { get; set; }
        public string CurrentAccountTitle { get; set; }
    
        public virtual Customer Customer { get; set; }
        public virtual VoucherType VoucherType { get; set; }
    }
}
