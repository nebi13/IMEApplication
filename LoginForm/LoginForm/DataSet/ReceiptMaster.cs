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
    
    public partial class ReceiptMaster
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ReceiptMaster()
        {
            this.PurchaseMasters = new HashSet<PurchaseMaster>();
            this.PurchaseMasters1 = new HashSet<PurchaseMaster>();
            this.ReceiptDetails = new HashSet<ReceiptDetail>();
        }
    
        public decimal receiptMasterId { get; set; }
        public string voucherNo { get; set; }
        public string invoiceNo { get; set; }
        public Nullable<decimal> suffixPrefixId { get; set; }
        public Nullable<System.DateTime> date { get; set; }
        public Nullable<decimal> ledgerId { get; set; }
        public Nullable<decimal> totalAmount { get; set; }
        public string narration { get; set; }
        public Nullable<decimal> voucherTypeId { get; set; }
        public Nullable<decimal> userId { get; set; }
        public Nullable<decimal> financialYearId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PurchaseMaster> PurchaseMasters { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PurchaseMaster> PurchaseMasters1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ReceiptDetail> ReceiptDetails { get; set; }
    }
}
