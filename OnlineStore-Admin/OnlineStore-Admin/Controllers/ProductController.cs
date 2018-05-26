using OnlineStore_Admin.Entities;
using OnlineStore_Admin.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;



namespace OnlineStore_ADMIN.Controllers
{
    public class ProductController : Controller
    {
        OnlineShopEntities os = new OnlineShopEntities();
        // GET: Inventory
        public ActionResult Index()
        {
            var productList = os.Products
                .Where(x => x.DeletedAt == null)
                .ToList();
            return View(productList);
        }

        public ActionResult Edit(int id=0)
        {
            var productInDb = os.Products
                .FirstOrDefault(x => x.ProductId == id);
            var categories = os.RefCategories.ToList();

            if (id == 0)
            {
               //sends to new form
                var vm = new ProductFormVM()
                {
                    Categories = categories,
                    Product = new Product()
                };
                return View(vm);
            }
            else
            {

                ProductFormVM vm = new ProductFormVM
                {
                    Categories = categories,
                    Product = productInDb
                };
                return View(vm);
            }
        }
        [HttpPost]
        public ActionResult Save(Product product)
        {
            if (product.ProductId == 0)
            {
                os.Products.Add(product);
            }
            else
            {
                var productInDb = os.Products.FirstOrDefault(w => w.ProductId == product.ProductId);

                if(productInDb != null)
                {
                    //will be replaced with automapper
                    productInDb.Name = product.Name;
                    productInDb.Description = product.Description;
                    productInDb.CategoryId = product.CategoryId;
                    productInDb.CostPrice = product.CostPrice;
                    productInDb.SellPrice = product.SellPrice;
                    productInDb.Quantity = product.Quantity;
                    productInDb.IsStocked = product.IsStocked;
                }
                else
                {
                    return HttpNotFound();
                }
            }
            os.SaveChanges();
            return RedirectToAction("Index", "Product");
        }
    }
}