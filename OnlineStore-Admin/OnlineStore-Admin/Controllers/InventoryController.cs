using OnlineStore_Admin.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;



namespace OnlineStore_ADMIN.Controllers
{
    public class InventoryController : Controller
    {
        OnlineShopEntities os = new OnlineShopEntities();
        // GET: Inventory
        public ActionResult Index()
        {
            var inventory = os.Products
                .Where(x => x.DeletedAt == null)
                .ToList();
            return View(inventory);
        }
        public ActionResult Edit(int id)
        {
            var productInDb = os.Products
                .FirstOrDefault(x => x.ProductId == id);
            if (productInDb == null)
            {
                return HttpNotFound();
            }
            else
            {
                //InventoryVM vm = new InventoryVM()
                //{

                //}
                return View(productInDb);
            }
        }
    }
}