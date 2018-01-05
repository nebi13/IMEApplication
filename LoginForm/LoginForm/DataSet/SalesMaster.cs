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
    
    public partial class SalesMaster
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SalesMaster()
        {
            this.SalesDetails = new HashSet<SalesDetail>();
        }
    
        public decimal salesMasterId { get; set; }
        public string voucherNo { get; set; }
        public string invoiceNo { get; set; }
        public Nullable<decimal> voucherTypeId { get; set; }
        public Nullable<decimal> suffixPrefixId { get; set; }
        public Nullable<System.DateTime> date { get; set; }
        public int creditPeriod { get; set; }
        public Nullable<decimal> ledgerId { get; set; }
        public Nullable<decimal> pricinglevelId { get; set; }
        public Nullable<decimal> salesAccount { get; set; }
        public Nullable<decimal> deliveryNoteMasterId { get; set; }
        public Nullable<decimal> orderMasterId { get; set; }
        public string narration { get; set; }
        public string customerName { get; set; }
        public Nullable<int> exchangeRateId { get; set; }
        public Nullable<decimal> taxAmount { get; set; }
        public Nullable<decimal> additionalCost { get; set; }
        public Nullable<decimal> billDiscount { get; set; }
        public Nullable<decimal> grandTotal { get; set; }
        public Nullable<decimal> totalAmount { get; set; }
        public Nullable<int> WorkerId { get; set; }
        public string lrNo { get; set; }
        public string transportationCompany { get; set; }
        public string quotationNoId { get; set; }
        public Nullable<bool> POS { get; set; }
        public Nullable<decimal> counterId { get; set; }
        public Nullable<decimal> financialYearId { get; set; }
    
        public virtual DeliveryNoteMaster DeliveryNoteMaster { get; set; }
        public virtual ExchangeRate ExchangeRate { get; set; }
        public virtual FinancialYear FinancialYear { get; set; }
        public virtual LedgerPosting LedgerPosting { get; set; }
        public virtual PricingLevel PricingLevel { get; set; }
        public virtual Quotation Quotation { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SalesDetail> SalesDetails { get; set; }
        public virtual SuffixPrefix SuffixPrefix { get; set; }
        public virtual VoucherType VoucherType { get; set; }
        public virtual Worker Worker { get; set; }
    }
}
