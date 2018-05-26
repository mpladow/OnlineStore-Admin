using OnlineStore_Admin.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineStore_Admin.ViewModels
{
    public class CustomerFormVM
    {
        public Customer Customer { get; set; }
        public List<RefTitle> Titles { get; set; }
    }
}