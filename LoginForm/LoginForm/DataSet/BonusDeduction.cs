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
    
    public partial class BonusDeduction
    {
        public decimal bonusDeductionId { get; set; }
        public Nullable<int> WorkerID { get; set; }
        public Nullable<System.DateTime> date { get; set; }
        public Nullable<System.DateTime> month { get; set; }
        public Nullable<decimal> bonusAmount { get; set; }
        public Nullable<decimal> deductionAmount { get; set; }
        public string narration { get; set; }
    
        public virtual Worker Worker { get; set; }
    }
}
