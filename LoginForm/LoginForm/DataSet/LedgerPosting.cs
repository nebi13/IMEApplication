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
    
    public partial class LedgerPosting
    {
        public decimal ledgerPostingId { get; set; }
        public Nullable<System.DateTime> date { get; set; }
        public Nullable<decimal> voucherTypeId { get; set; }
        public string voucherNo { get; set; }
        public Nullable<decimal> ledgerId { get; set; }
        public Nullable<decimal> debit { get; set; }
        public Nullable<decimal> credit { get; set; }
        public Nullable<decimal> detailsId { get; set; }
        public Nullable<decimal> yearId { get; set; }
        public string invoiceNo { get; set; }
        public string chequeNo { get; set; }
        public Nullable<System.DateTime> chequeDate { get; set; }
        public Nullable<System.DateTime> extraDate { get; set; }
        public string extra1 { get; set; }
        public string extra2 { get; set; }
    
        public virtual AccountLedger AccountLedger { get; set; }
        public virtual FinancialYear FinancialYear { get; set; }
        public virtual VoucherType VoucherType { get; set; }
    }
}