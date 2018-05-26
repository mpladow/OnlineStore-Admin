using OnlineStore_Admin.Entities;
using OnlineStore_Admin.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineStore_Admin.Controllers
{
    public class CustomerController : Controller
    {
        OnlineShopEntities os = new OnlineShopEntities();
        // GET: Inventory
        public ActionResult Index()
        {
            var customerList = os.Customers
                .Where(x => x.DeletedAt == null)
                .ToList();
            return View(customerList);
        }

        public ActionResult Edit(int id = 0)
        {
            var customerInDb = os.Customers
                .FirstOrDefault(x => x.CustomerId == id);
            var titles = os.RefTitles.ToList();

            if (id == 0)
            {
                //sends to new form
                CustomerFormVM vm = new CustomerFormVM()
                {
                    Titles = titles,
                    Customer = new Customer()
                };
                return View(vm);
            }
            else
            {

                CustomerFormVM vm = new CustomerFormVM
                {
                    Titles = titles,
                    Customer = customerInDb
                };
                return View(vm);
            }
        }
        [HttpPost]
        public ActionResult Save(Customer customer)
        {
            if (customer.CustomerId == 0)
            {
                os.Customers.Add(customer);
            }
            else
            {
                var customerInDb = os.Customers.FirstOrDefault(w => w.CustomerId == customer.CustomerId);

                if (customerInDb != null)
                {
                    //will be replaced with automapper
                    customerInDb.TitleId = customer.TitleId;
                    customerInDb.FirstName = customer.FirstName;
                    customerInDb.LastName = customer.LastName;
                    customerInDb.StreetAddress = customer.StreetAddress;
                    customerInDb.SuburbAddress = customer.SuburbAddress;
                    customerInDb.PostCodeAddress = customer.PostCodeAddress;
                    customerInDb.CountryAddress = customer.CountryAddress;
                    customerInDb.StreetShippingAddress = customer.StreetShippingAddress;
                    customerInDb.SuburbShippingAddress = customer.SuburbShippingAddress;
                    customerInDb.PostCodeShippingAddress = customer.PostCodeShippingAddress;
                    customerInDb.CountryShippingAddress = customer.CountryShippingAddress;
                    customerInDb.IsSubcribed = customer.IsSubcribed;

                }
                else
                {
                    return HttpNotFound();
                }
            }
            os.SaveChanges();
            return RedirectToAction("Index", "Customer");
        }
    }
}