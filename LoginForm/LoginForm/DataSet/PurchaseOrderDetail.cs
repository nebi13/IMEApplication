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
    
    public partial class PurchaseOrderDetail
    {
        public int ID { get; set; }
        public string QuotationNo { get; set; }
        public string SaleOrderNo { get; set; }
        public string ItemCode { get; set; }
        public Nullable<int> SendQty { get; set; }
        public string FrtType { get; set; }
        public string FicheNo { get; set; }
        public string SaleOrderNature { get; set; }
        public string ItemDescription { get; set; }
        public bool Hazardous { get; set; }
        public bool Calibration { get; set; }
        public Nullable<decimal> UnitPrice { get; set; }
        public string Unit { get; set; }
    
        public virtual PurchaseOrder PurchaseOrder { get; set; }
        public virtual SaleOrder SaleOrder { get; set; }
    }
}
