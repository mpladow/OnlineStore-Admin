//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OnlineStore_Admin.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class Customer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Customer()
        {
            this.Orders = new HashSet<Order>();
        }
    
        public int CustomerId { get; set; }
        public Nullable<int> TitleId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string StreetAddress { get; set; }
        public string SuburbAddress { get; set; }
        public string PostCodeAddress { get; set; }
        public string StateAddress { get; set; }
        public string CountryAddress { get; set; }
        public string StreetShippingAddress { get; set; }
        public string SuburbShippingAddress { get; set; }
        public string PostCodeShippingAddress { get; set; }
        public string StateShippingAddress { get; set; }
        public string CountryShippingAddress { get; set; }
        public Nullable<System.DateTime> DeletedAt { get; set; }
        public bool IsSubcribed { get; set; }
    
        public virtual Customer Customer1 { get; set; }
        public virtual Customer Customer2 { get; set; }
        public virtual RefTitle RefTitle { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order> Orders { get; set; }
    }
}
