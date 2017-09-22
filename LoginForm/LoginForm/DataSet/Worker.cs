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
    
    public partial class Worker
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Worker()
        {
            this.SupplierWorkerNotes = new HashSet<SupplierWorkerNote>();
            this.AuthorizationValues = new HashSet<AuthorizationValue>();
            this.Suppliers = new HashSet<Supplier>();
            this.Customers = new HashSet<Customer>();
            this.Customers1 = new HashSet<Customer>();
            this.Customers2 = new HashSet<Customer>();
        }
    
        public int WorkerID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string EMail { get; set; }
        public string Phone { get; set; }
        public Nullable<int> WorkerNoteID { get; set; }
        public string Username { get; set; }
        public Nullable<decimal> MinMarge { get; set; }
        public Nullable<decimal> MinRate { get; set; }
        public Nullable<int> Title { get; set; }
        public Nullable<int> isActive { get; set; }
    
        public virtual Note Note { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SupplierWorkerNote> SupplierWorkerNotes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AuthorizationValue> AuthorizationValues { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Supplier> Suppliers { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Customer> Customers { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Customer> Customers1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Customer> Customers2 { get; set; }
    }
}
