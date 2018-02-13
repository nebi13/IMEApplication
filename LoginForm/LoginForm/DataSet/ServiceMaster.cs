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
    
    public partial class ServiceMaster
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ServiceMaster()
        {
            this.ServiceDetails = new HashSet<ServiceDetail>();
        }
    
        public decimal serviceMasterId { get; set; }
        public string voucherNo { get; set; }
        public string invoiceNo { get; set; }
        public Nullable<decimal> suffixPrefixId { get; set; }
        public Nullable<System.DateTime> date { get; set; }
        public Nullable<decimal> ledgerId { get; set; }
        public Nullable<decimal> totalAmount { get; set; }
        public string narration { get; set; }
        public Nullable<int> creditPeriod { get; set; }
        public Nullable<decimal> serviceAccount { get; set; }
        public Nullable<int> employeeId { get; set; }
        public string customer { get; set; }
        public Nullable<decimal> discount { get; set; }
        public Nullable<decimal> grandTotal { get; set; }
        public Nullable<decimal> voucherTypeId { get; set; }
        public Nullable<decimal> financialYearId { get; set; }
        public Nullable<int> exchangeRateId { get; set; }
    
        public virtual ExchangeRate ExchangeRate { get; set; }
        public virtual FinancialYear FinancialYear { get; set; }
        public virtual LedgerPosting LedgerPosting { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ServiceDetail> ServiceDetails { get; set; }
        public virtual Worker Worker { get; set; }
        public virtual SuffixPrefix SuffixPrefix { get; set; }
        public virtual VoucherType VoucherType { get; set; }
    }
}