using OnlineStore_Admin.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineStore_Admin.ViewModels
{
    public class ProductFormVM
    {
        public Product Product { get; set; }
        public List<RefCategory>   Categories { get; set; }
    }
}