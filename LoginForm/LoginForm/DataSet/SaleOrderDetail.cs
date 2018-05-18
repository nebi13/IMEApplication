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
    
    public partial class SaleOrderDetail
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SaleOrderDetail()
        {
            this.DeliveryNoteDetails = new HashSet<DeliveryNoteDetail>();
            this.SalesDetails = new HashSet<SalesDetail>();
            this.SalesReturnDetails = new HashSet<SalesReturnDetail>();
        }
    
        public int ID { get; set; }
        public string ItemCode { get; set; }
        public int Quantity { get; set; }
        public decimal UCUPCurr { get; set; }
        public Nullable<decimal> Discount { get; set; }
        public decimal Total { get; set; }
        public Nullable<decimal> TargetUP { get; set; }
        public string Competitor { get; set; }
        public string CustomerDescription { get; set; }
        public string CustomerStockCode { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
        public Nullable<decimal> UPIME { get; set; }
        public Nullable<decimal> Margin { get; set; }
        public string UnitOfMeasure { get; set; }
        public Nullable<int> UnitContent { get; set; }
        public Nullable<int> SSM { get; set; }
        public Nullable<decimal> UnitWeight { get; set; }
        public string DependantTable { get; set; }
        public string ItemDescription { get; set; }
        public Nullable<bool> Hazardous { get; set; }
        public Nullable<bool> Calibration { get; set; }
        public Nullable<decimal> ItemCost { get; set; }
        public Nullable<int> No { get; set; }
        public Nullable<decimal> unitConversionId { get; set; }
        public Nullable<decimal> deliveryNoteDetailsId { get; set; }
        public Nullable<int> quotationDetailsId { get; set; }
        public Nullable<decimal> SaleOrderID { get; set; }
        public Nullable<int> SentItemQuantity { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DeliveryNoteDetail> DeliveryNoteDetails { get; set; }
        public virtual QuotationDetail QuotationDetail { get; set; }
        public virtual SaleOrder SaleOrder { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SalesDetail> SalesDetails { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SalesReturnDetail> SalesReturnDetails { get; set; }
    }
}
