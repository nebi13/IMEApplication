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
    
    public partial class CustomerAddress
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CustomerAddress()
        {
            this.SaleOrders = new HashSet<SaleOrder>();
            this.SaleOrders1 = new HashSet<SaleOrder>();
        }
    
        public int ID { get; set; }
        public string CustomerID { get; set; }
        public Nullable<int> ContactID { get; set; }
        public string PostCode { get; set; }
        public string AdressDetails { get; set; }
        public Nullable<bool> isDeliveryAddress { get; set; }
        public Nullable<bool> isInvoiceAddress { get; set; }
        public Nullable<int> TownID { get; set; }
        public Nullable<int> CityID { get; set; }
        public Nullable<int> CountryID { get; set; }
        public string AdressTitle { get; set; }
        public string AddressType { get; set; }
    
        public virtual City City { get; set; }
        public virtual Country Country { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual CustomerWorker CustomerWorker { get; set; }
        public virtual Town Town { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SaleOrder> SaleOrders { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SaleOrder> SaleOrders1 { get; set; }
    }
}
