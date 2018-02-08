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
    
    public partial class VoucherType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public VoucherType()
        {
            this.AdvancePayments = new HashSet<AdvancePayment>();
            this.CreditNoteMasters = new HashSet<CreditNoteMaster>();
            this.DebitNoteMasters = new HashSet<DebitNoteMaster>();
            this.DeliveryNoteMasters = new HashSet<DeliveryNoteMaster>();
            this.JournalMasters = new HashSet<JournalMaster>();
            this.LedgerPostings = new HashSet<LedgerPosting>();
            this.MaterialReceiptMasters = new HashSet<MaterialReceiptMaster>();
            this.PartyBalances = new HashSet<PartyBalance>();
            this.PartyBalances1 = new HashSet<PartyBalance>();
            this.PaymentMasters = new HashSet<PaymentMaster>();
            this.PDCClearanceMasters = new HashSet<PDCClearanceMaster>();
            this.PDCPayableMasters = new HashSet<PDCPayableMaster>();
            this.PDCReceivableMasters = new HashSet<PDCReceivableMaster>();
            this.PurchaseMasters = new HashSet<PurchaseMaster>();
            this.PurchaseOrders = new HashSet<PurchaseOrder>();
            this.PurchaseReturnMasters = new HashSet<PurchaseReturnMaster>();
            this.Quotations = new HashSet<Quotation>();
            this.RejectionInMasters = new HashSet<RejectionInMaster>();
            this.RejectionOutMasters = new HashSet<RejectionOutMaster>();
            this.SalaryVoucherMasters = new HashSet<SalaryVoucherMaster>();
            this.SaleOrders = new HashSet<SaleOrder>();
            this.SalesMasters = new HashSet<SalesMaster>();
            this.SalesReturnMasters = new HashSet<SalesReturnMaster>();
            this.ServiceMasters = new HashSet<ServiceMaster>();
            this.Stocks = new HashSet<Stock>();
            this.StockPostings = new HashSet<StockPosting>();
            this.SuffixPrefixes = new HashSet<SuffixPrefix>();
            this.AdditionalCosts = new HashSet<AdditionalCost>();
            this.VoucherTypeTaxes = new HashSet<VoucherTypeTax>();
        }
    
        public decimal voucherTypeId { get; set; }
        public string voucherTypeName { get; set; }
        public string typeOfVoucher { get; set; }
        public string methodOfVoucherNumbering { get; set; }
        public Nullable<bool> isTaxApplicable { get; set; }
        public string narration { get; set; }
        public Nullable<bool> isActive { get; set; }
        public Nullable<bool> isDefault { get; set; }
        public Nullable<int> masterId { get; set; }
        public string declaration { get; set; }
        public string heading1 { get; set; }
        public string heading2 { get; set; }
        public string heading3 { get; set; }
        public string heading4 { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AdvancePayment> AdvancePayments { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CreditNoteMaster> CreditNoteMasters { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DebitNoteMaster> DebitNoteMasters { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DeliveryNoteMaster> DeliveryNoteMasters { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<JournalMaster> JournalMasters { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LedgerPosting> LedgerPostings { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MaterialReceiptMaster> MaterialReceiptMasters { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PartyBalance> PartyBalances { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PartyBalance> PartyBalances1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PaymentMaster> PaymentMasters { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PDCClearanceMaster> PDCClearanceMasters { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PDCPayableMaster> PDCPayableMasters { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PDCReceivableMaster> PDCReceivableMasters { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PurchaseMaster> PurchaseMasters { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PurchaseOrder> PurchaseOrders { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PurchaseReturnMaster> PurchaseReturnMasters { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Quotation> Quotations { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RejectionInMaster> RejectionInMasters { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RejectionOutMaster> RejectionOutMasters { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SalaryVoucherMaster> SalaryVoucherMasters { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SaleOrder> SaleOrders { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SalesMaster> SalesMasters { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SalesReturnMaster> SalesReturnMasters { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ServiceMaster> ServiceMasters { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Stock> Stocks { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StockPosting> StockPostings { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SuffixPrefix> SuffixPrefixes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AdditionalCost> AdditionalCosts { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VoucherTypeTax> VoucherTypeTaxes { get; set; }
    }
}
