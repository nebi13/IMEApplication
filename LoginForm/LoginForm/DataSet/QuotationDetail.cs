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
    
    public partial class QuotationDetail
    {
        public int ID { get; set; }
        public Nullable<int> dgNo { get; set; }
        public string ItemCode { get; set; }
        public Nullable<int> Qty { get; set; }
        public Nullable<decimal> UCUPCurr { get; set; }
        public Nullable<decimal> Disc { get; set; }
        public Nullable<decimal> Total { get; set; }
        public Nullable<decimal> TargetUP { get; set; }
        public string Competitor { get; set; }
        public string CustomerDescription { get; set; }
        public string CustomerStockCode { get; set; }
        public Nullable<int> IsDeleted { get; set; }
        public string QuotationNo { get; set; }
        public Nullable<decimal> UPIME { get; set; }
        public Nullable<decimal> Marge { get; set; }
        public string UnitOfMeasure { get; set; }
        public Nullable<int> UC { get; set; }
        public Nullable<int> SSM { get; set; }
        public Nullable<decimal> UnitWeight { get; set; }
    
        public virtual Quotation Quotation { get; set; }
    }
}
