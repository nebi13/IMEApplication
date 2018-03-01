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
    
    public partial class Unit
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Unit()
        {
            this.DeliveryNoteDetails = new HashSet<DeliveryNoteDetail>();
            this.MaterialReceiptDetails = new HashSet<MaterialReceiptDetail>();
            this.PhysicalStockDetails = new HashSet<PhysicalStockDetail>();
            this.PurchaseDetails = new HashSet<PurchaseDetail>();
            this.PurchaseOrderDetails = new HashSet<PurchaseOrderDetail>();
            this.PurchaseReturnDetails = new HashSet<PurchaseReturnDetail>();
            this.RejectionInDetails = new HashSet<RejectionInDetail>();
            this.RejectionOutDetails = new HashSet<RejectionOutDetail>();
            this.SalesDetails = new HashSet<SalesDetail>();
            this.StockJournalDetails = new HashSet<StockJournalDetail>();
            this.StockPostings = new HashSet<StockPosting>();
            this.UnitConvertions = new HashSet<UnitConvertion>();
        }
    
        public decimal unitId { get; set; }
        public string unitName { get; set; }
        public string narration { get; set; }
        public Nullable<int> noOfDecimalplaces { get; set; }
        public string formalName { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DeliveryNoteDetail> DeliveryNoteDetails { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MaterialReceiptDetail> MaterialReceiptDetails { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PhysicalStockDetail> PhysicalStockDetails { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PurchaseDetail> PurchaseDetails { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PurchaseOrderDetail> PurchaseOrderDetails { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PurchaseReturnDetail> PurchaseReturnDetails { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RejectionInDetail> RejectionInDetails { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RejectionOutDetail> RejectionOutDetails { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SalesDetail> SalesDetails { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StockJournalDetail> StockJournalDetails { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StockPosting> StockPostings { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UnitConvertion> UnitConvertions { get; set; }
    }
}
