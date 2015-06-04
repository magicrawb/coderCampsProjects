using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Day8MVCTemplates.Models
{
    public class Product
    {
        public string Name { get; set; }

        [DataType(DataType.Currency)]
        public Decimal Price { get; set; }
        
        public decimal Weight { get; set; }
    }
}