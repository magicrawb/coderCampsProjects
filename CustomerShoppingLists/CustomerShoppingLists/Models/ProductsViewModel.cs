using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CustomerShoppingLists.Models
{
    public class ProductsViewModel
    {
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public IList<Product> Products { get; set; }
        public decimal Total { get; set; }
    }
}