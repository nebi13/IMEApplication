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
    
    public partial class Company
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Company()
        {
            this.Managements = new HashSet<Management>();
            this.OtherBanchesStocks = new HashSet<OtherBanchesStock>();
        }
    
        public decimal companyId { get; set; }
        public string companyName { get; set; }
        public string mailingName { get; set; }
        public string address { get; set; }
        public string phone { get; set; }
        public string mobile { get; set; }
        public string email { get; set; }
        public string web { get; set; }
        public string country { get; set; }
        public string state { get; set; }
        public string pin { get; set; }
        public Nullable<decimal> currencyId { get; set; }
        public Nullable<System.DateTime> financialYearFrom { get; set; }
        public Nullable<System.DateTime> booksBeginingFrom { get; set; }
        public string tin { get; set; }
        public string cst { get; set; }
        public string pan { get; set; }
        public string BranchCode { get; set; }
    
        public virtual Currency Currency { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Management> Managements { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OtherBanchesStock> OtherBanchesStocks { get; set; }
    }
}
