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
    
    public partial class CustomerSubCategory
    {
        public int ID { get; set; }
        public string subcategoryname { get; set; }
        public Nullable<int> categoryID { get; set; }
    
        public virtual CustomerCategory CustomerCategory { get; set; }
    }
}
