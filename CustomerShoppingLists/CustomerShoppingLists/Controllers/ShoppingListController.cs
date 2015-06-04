using CustomerShoppingLists.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CustomerShoppingLists.Controllers
{
    public class ShoppingListController : Controller
    {
        ShoppingListService _repo;


        // GET: ShoppingList
        public ActionResult Index()
        {
            IList<Product> getItemsList = _repo.GetItems();
            ProductsViewModel vm = new ProductsViewModel();
            vm.FirstName = "Rob";
            vm.LastName = "Greenlee";
            vm.Products = getItemsList;
            vm.Total = getItemsList.Sum(p => p.Price);
            return View(vm);
        }

        public ShoppingListController()
        {
            _repo = new ShoppingListService();
        }
    }
}