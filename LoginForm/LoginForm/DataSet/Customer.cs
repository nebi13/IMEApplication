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
    
    public partial class Customer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Customer()
        {
            this.CustomerAddresses = new HashSet<CustomerAddress>();
            this.CustomerWorkers = new HashSet<CustomerWorker>();
            this.DiscountValues = new HashSet<DiscountValue>();
            this.ItemHistories = new HashSet<ItemHistory>();
            this.PurchaseOrders = new HashSet<PurchaseOrder>();
            this.Quotations = new HashSet<Quotation>();
            this.SaleOrders = new HashSet<SaleOrder>();
            this.SalesOperations = new HashSet<SalesOperation>();
            this.StockReserves = new HashSet<StockReserve>();
        }
    
        public string ID { get; set; }
        public string c_name { get; set; }
        public Nullable<decimal> discountrate { get; set; }
        public Nullable<int> paymentmethodID { get; set; }
        public Nullable<int> creditlimit { get; set; }
        public string webadress { get; set; }
        public Nullable<int> payment_termID { get; set; }
        public Nullable<int> representaryID { get; set; }
        public Nullable<int> customerNoteID { get; set; }
        public Nullable<int> representary2ID { get; set; }
        public Nullable<int> accountrepresentaryID { get; set; }
        public Nullable<int> isactive { get; set; }
        public Nullable<int> rateIDinvoice { get; set; }
        public string taxoffice { get; set; }
        public string taxnumber { get; set; }
        public Nullable<int> MainContactID { get; set; }
        public string CurrTypeInv { get; set; }
        public string CurrNameInv { get; set; }
        public string CurrTypeQuo { get; set; }
        public string CurrNameQuo { get; set; }
        public Nullable<int> customerAccountantNoteID { get; set; }
        public string extensionnumber { get; set; }
        public Nullable<decimal> factor { get; set; }
        public Nullable<int> creditDay { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public string telephone { get; set; }
        public string fax { get; set; }
        public Nullable<int> categoryID { get; set; }
        public Nullable<int> subcategoryID { get; set; }
        public string ThirdPartyCode { get; set; }
        public string Capital { get; set; }
        public Nullable<decimal> Debit { get; set; }
        public Nullable<decimal> Markup { get; set; }
    
        public virtual Worker Worker { get; set; }
        public virtual CustomerCategory CustomerCategory { get; set; }
        public virtual Note Note { get; set; }
        public virtual Note Note1 { get; set; }
        public virtual CustomerWorker CustomerWorker { get; set; }
        public virtual PaymentTerm PaymentTerm { get; set; }
        public virtual PaymentMethod PaymentMethod { get; set; }
        public virtual Worker Worker1 { get; set; }
        public virtual Worker Worker2 { get; set; }
        public virtual CustomerSubCategory CustomerSubCategory { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CustomerAddress> CustomerAddresses { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CustomerWorker> CustomerWorkers { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DiscountValue> DiscountValues { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ItemHistory> ItemHistories { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PurchaseOrder> PurchaseOrders { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Quotation> Quotations { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SaleOrder> SaleOrders { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SalesOperation> SalesOperations { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StockReserve> StockReserves { get; set; }
    }
}
