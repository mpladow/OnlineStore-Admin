using OnlineStore_Admin.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineStore_ADMIN.ViewModels
{
    public class InventoryVM
    {
        public int ProductID { get; set; }
        public Nullable<int> OrderID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Nullable<int> Quantity { get; set; }
        public Nullable<System.DateTime> DeletedAt { get; set; }
        public Nullable<int> Price { get; set; }
        public bool IsStocked { get; set; }

        public string Heading { get; set; }

        public virtual ICollection<Product> Orders { get; set; }
        public virtual Product Products1 { get; set; }
        public virtual Product Product1 { get; set; }
    }
}