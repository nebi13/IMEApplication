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
    
    public partial class SaleOrder
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SaleOrder()
        {
            this.PurchaseOrderDetails = new HashSet<PurchaseOrderDetail>();
            this.SaleOrderDetails = new HashSet<SaleOrderDetail>();
            this.SalesReturnMasters = new HashSet<SalesReturnMaster>();
        }
    
        public string SaleOrderNo { get; set; }
        public System.DateTime SaleDate { get; set; }
        public string OnlineConfirmationNo { get; set; }
        public string QuotationNos { get; set; }
        public int PaymentTermID { get; set; }
        public Nullable<System.DateTime> RequestedDeliveryDate { get; set; }
        public Nullable<decimal> Vat { get; set; }
        public decimal TotalPrice { get; set; }
        public string CustomerID { get; set; }
        public int ContactID { get; set; }
        public int DeliveryContactID { get; set; }
        public int InvoiceAddressID { get; set; }
        public int DeliveryAddressID { get; set; }
        public int RepresentativeID { get; set; }
        public int PaymentMethodID { get; set; }
        public string NoteForUs { get; set; }
        public string NoteForCustomer { get; set; }
        public Nullable<int> NoteForFinance { get; set; }
        public string SaleOrderNature { get; set; }
        public string ShippingType { get; set; }
        public string LPONO { get; set; }
        public Nullable<decimal> Factor { get; set; }
        public Nullable<decimal> SubTotal { get; set; }
        public Nullable<decimal> DiscOnSubtotal { get; set; }
        public Nullable<decimal> ExtraCharges { get; set; }
        public Nullable<decimal> TotalMargin { get; set; }
        public Nullable<decimal> VoucherId { get; set; }
        public Nullable<decimal> VoucherTypeId { get; set; }
        public Nullable<decimal> VoucherNo { get; set; }
        public Nullable<decimal> ledgerId { get; set; }
        public Nullable<bool> cancelled { get; set; }
        public string invoiceNo { get; set; }
        public Nullable<int> exchangeRateID { get; set; }
    
        public virtual AccountLedger AccountLedger { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual CustomerAddress CustomerAddress { get; set; }
        public virtual CustomerAddress CustomerAddress1 { get; set; }
        public virtual CustomerWorker CustomerWorker { get; set; }
        public virtual CustomerWorker CustomerWorker1 { get; set; }
        public virtual CustomerWorker CustomerWorker2 { get; set; }
        public virtual ExchangeRate ExchangeRate { get; set; }
        public virtual PaymentMethod PaymentMethod { get; set; }
        public virtual PaymentTerm PaymentTerm { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PurchaseOrderDetail> PurchaseOrderDetails { get; set; }
        public virtual Worker Worker { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SaleOrderDetail> SaleOrderDetails { get; set; }
        public virtual VoucherType VoucherType { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SalesReturnMaster> SalesReturnMasters { get; set; }
    }
}
