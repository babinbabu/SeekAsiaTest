//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WolfcomGlobal.CoreLib.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class CustomerPromotion
    {
        public long PromotionId { get; set; }
        public long UserTypeId { get; set; }
        public long ProductCode { get; set; }
        public string PromotionFormula { get; set; }
        public decimal PromotionPrice { get; set; }
        public bool Status { get; set; }
        public Nullable<System.DateTime> ExpiryDate { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
    
        public virtual PrivilageCustomer PrivilageCustomer { get; set; }
        public virtual ProductDetail ProductDetail { get; set; }
    }
}
