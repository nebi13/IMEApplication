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
    
    public partial class PurchaseOrder
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PurchaseOrder()
        {
            this.MaterialReceiptMasters = new HashSet<MaterialReceiptMaster>();
            this.PurchaseMasters = new HashSet<PurchaseMaster>();
            this.PurchaseMasters1 = new HashSet<PurchaseMaster>();
            this.PurchaseOrderDetails = new HashSet<PurchaseOrderDetail>();
        }
    
        public string CustomerID { get; set; }
        public Nullable<System.DateTime> PurchaseOrderDate { get; set; }
        public Nullable<System.DateTime> CameDate { get; set; }
        public string Reason { get; set; }
        public string FicheNo { get; set; }
        public Nullable<int> exchangeRateID { get; set; }
        public Nullable<int> userId { get; set; }
        public string voucherNo { get; set; }
        public string invoiceNo { get; set; }
        public Nullable<decimal> suffixPrefixId { get; set; }
        public Nullable<System.DateTime> date { get; set; }
        public Nullable<System.DateTime> dueDate { get; set; }
        public Nullable<bool> cancelled { get; set; }
        public Nullable<decimal> ledgerId { get; set; }
        public string narration { get; set; }
        public Nullable<decimal> totalAmount { get; set; }
        public Nullable<decimal> voucherTypeId { get; set; }
    
        public virtual AccountLedger AccountLedger { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual ExchangeRate ExchangeRate { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MaterialReceiptMaster> MaterialReceiptMasters { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PurchaseMaster> PurchaseMasters { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PurchaseMaster> PurchaseMasters1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PurchaseOrderDetail> PurchaseOrderDetails { get; set; }
        public virtual SuffixPrefix SuffixPrefix { get; set; }
        public virtual Worker Worker { get; set; }
        public virtual VoucherType VoucherType { get; set; }
    }
}
