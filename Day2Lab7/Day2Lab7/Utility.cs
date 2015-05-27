using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2Lab7
{
    class Utility
    {
        public static string CleanUserInput(string input)
        {
            return input.ToLower().Trim();
        }
    }


    public class Product
    {
        public decimal Price { get; set; }

        public static Product Create(decimal price)
        {
            return new Product();
        }
    }

    public class Counter
    {
        public static Counter WordCount(string userInput)
        {
            var array = userInput.Split(' ');
        }
    }
}
