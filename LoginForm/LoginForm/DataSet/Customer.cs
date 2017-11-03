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
            this.CustomerAdresses = new HashSet<CustomerAdress>();
            this.CustomerCategorySubCategories = new HashSet<CustomerCategorySubCategory>();
            this.CustomerWorkers = new HashSet<CustomerWorker>();
            this.DiscountValues = new HashSet<DiscountValue>();
            this.Quotations = new HashSet<Quotation>();
        }
    
        public string ID { get; set; }
        public string c_name { get; set; }
        public Nullable<int> discountrate { get; set; }
        public string telephone { get; set; }
        public Nullable<int> paymentmethodID { get; set; }
        public string fax { get; set; }
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
        public Nullable<int> taxnumber { get; set; }
        public Nullable<int> MainContactID { get; set; }
        public string CurrTypeInv { get; set; }
        public string CurrNameInv { get; set; }
        public string CurrTypeQuo { get; set; }
        public string CurrNameQuo { get; set; }
        public Nullable<int> customerAccountantNoteID { get; set; }
        public System.DateTime CreateDate { get; set; }
    
        public virtual Worker Worker { get; set; }
        public virtual Note Note { get; set; }
        public virtual CustomerWorker CustomerWorker { get; set; }
        public virtual PaymentMethod PaymentMethod { get; set; }
        public virtual PaymentTerm PaymentTerm { get; set; }
        public virtual Worker Worker1 { get; set; }
        public virtual Worker Worker2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CustomerAdress> CustomerAdresses { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CustomerCategorySubCategory> CustomerCategorySubCategories { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CustomerWorker> CustomerWorkers { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DiscountValue> DiscountValues { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Quotation> Quotations { get; set; }
    }
}
