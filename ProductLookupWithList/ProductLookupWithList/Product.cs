using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductLookupWithList
{
    class Product
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }

    class ProductCatalog
    {
        List<Product> _productList;
        
        public ProductCatalog()
        {
            _productList = new List<Product>();

            _productList.Add(
            new Product
                {
                    ID = "P100",
                    Name = "Peanut Butter",
                    Price = 4.43m
                },
            new Product { 
                    ID = "P101",
                    Name = "Jet Ski",
                    Price = 5896.35m
                },
            new Product { 
                    ID = "P102",
                    Name = "Sharpie",
                    Price = 1.59m
                });
        }

        public Product Lookup(string id)
        {
            Product product = null;

            foreach (Product p in _productList)
            {
                if (p.ID == id)
                {
                    return p;
                }

                return null;
            }
        }

    }
}
