using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

//This is acting as the Repository!!

namespace CustomerShoppingLists.Models
{
    public class ShoppingListService
    {
        private IList<Product> _products = new List<Product>() 
        //{ 
        //    new Product { Name = "Laptop", Price = 300},
        //    new Product { Name = "", Price = 20 },
        //    new Product { Name = "", Price = 15 }
        //}
        ;

        public IList<Product> GetItems()
        {
            _products.Add(new Product { Name = "Laptop", Price = 300 });
            _products.Add(new Product { Name = "Notebook", Price = 20 });

            return _products;
        }

    }
}