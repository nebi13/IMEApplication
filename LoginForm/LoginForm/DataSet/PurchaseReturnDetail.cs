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

    public partial class PurchaseReturnDetail
    {
        public decimal purchaseReturnDetailsId { get; set; }
        public Nullable<decimal> purchaseReturnMasterId { get; set; }
        public Nullable<decimal> productId { get; set; }
        public Nullable<decimal> qty { get; set; }
        public Nullable<decimal> rate { get; set; }
        public Nullable<decimal> unitId { get; set; }
        public Nullable<decimal> unitConversionId { get; set; }
        public Nullable<decimal> discount { get; set; }
        public Nullable<int> taxId { get; set; }
        public Nullable<decimal> batchId { get; set; }
        public Nullable<decimal> godownId { get; set; }
        public Nullable<decimal> rackId { get; set; }
        public Nullable<decimal> taxAmount { get; set; }
        public Nullable<decimal> grossAmount { get; set; }
        public Nullable<decimal> netAmount { get; set; }
        public Nullable<decimal> amount { get; set; }
        public Nullable<int> slNo { get; set; }
        public Nullable<int> purchaseDetailsId { get; set; }

        public virtual Batch Batch { get; set; }
        public virtual Godown Godown { get; set; }
        public virtual PurchaseOrderDetail PurchaseOrderDetail { get; set; }
        public virtual PurchaseReturnMaster PurchaseReturnMaster { get; set; }
        public virtual PurchaseReturnMaster PurchaseReturnMaster1 { get; set; }
        public virtual Rack Rack { get; set; }
        public virtual Tax Tax { get; set; }
        public virtual Tax Tax1 { get; set; }
        public virtual UnitConvertion UnitConvertion { get; set; }
        public virtual Unit Unit { get; set; }
    }
}
