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
    
    public partial class PrivilageCustomer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PrivilageCustomer()
        {
            this.CustomerPromotions = new HashSet<CustomerPromotion>();
        }
    
        public long CustomerId { get; set; }
        public string CustomerPrivilageName { get; set; }
        public bool Status { get; set; }
        public System.DateTime CreatedDate { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CustomerPromotion> CustomerPromotions { get; set; }
    }
}
