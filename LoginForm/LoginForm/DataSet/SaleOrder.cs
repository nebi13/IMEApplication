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
        public string SaleOrderNo { get; set; }
        public System.DateTime SaleDate { get; set; }
        public string CurrenyName { get; set; }
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
    
        public virtual Customer Customer { get; set; }
        public virtual CustomerAddress CustomerAddress { get; set; }
        public virtual CustomerAddress CustomerAddress1 { get; set; }
        public virtual CustomerWorker CustomerWorker { get; set; }
        public virtual CustomerWorker CustomerWorker1 { get; set; }
        public virtual CustomerWorker CustomerWorker2 { get; set; }
        public virtual PaymentMethod PaymentMethod { get; set; }
        public virtual PaymentTerm PaymentTerm { get; set; }
        public virtual Worker Worker { get; set; }
    }
}
