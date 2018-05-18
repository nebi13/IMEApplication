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
    
    public partial class OrderAcknowledgement
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OrderAcknowledgement()
        {
            this.OrderAcknowledgementDetails = new HashSet<OrderAcknowledgementDetail>();
        }
    
        public int ID { get; set; }
        public string CountryCode { get; set; }
        public string OrderDate { get; set; }
        public string OrderTime { get; set; }
        public string SupplierTelephoneNumber { get; set; }
        public string CustomerDistOrderReference { get; set; }
        public string ShippingCondition { get; set; }
        public string CustomerPONumber { get; set; }
        public string SupplyingECCompany { get; set; }
        public string CustomerReference { get; set; }
        public string HeaderDeliveryBlock { get; set; }
        public string RSLSalesOrderNumber { get; set; }
        public string ScheduleLineConfirmedQuantity { get; set; }
        public string ScheduleLineControl { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderAcknowledgementDetail> OrderAcknowledgementDetails { get; set; }
    }
}
