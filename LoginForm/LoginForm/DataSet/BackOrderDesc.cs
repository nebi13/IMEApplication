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
    
    public partial class BackOrderDesc
    {
        public int ID { get; set; }
        public string description { get; set; }
        public Nullable<int> BackOrderID { get; set; }
    
        public virtual BackOrder BackOrder { get; set; }
    }
}