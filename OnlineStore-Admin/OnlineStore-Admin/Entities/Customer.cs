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
        public int CustomerId { get; set; }
        public Nullable<int> TitleId { get; set; }
        public Nullable<int> OrderId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string StreetAddress { get; set; }
        public string StateAddress { get; set; }
        public string SuburbAddress { get; set; }
        public string CountryAddress { get; set; }
        public Nullable<bool> IsSubcribed { get; set; }
        public string StreetShippingAddress { get; set; }
        public string StateShippingAddress { get; set; }
        public string SuburbShippingAddress { get; set; }
        public string CountryShippingAddress { get; set; }
    }
}
