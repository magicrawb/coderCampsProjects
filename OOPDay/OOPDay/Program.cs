using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDay
{
    class Program
    {
        static void Main(string[] args)
        {
            Product robsLaptop = new Product();
            robsLaptop.Name = "Acer";
            robsLaptop.Price = 350.75m;

            robsLaptop.CalculatePrice();

            Console.WriteLine("Name: {0}, Price: {1}", robsLaptop.Name, robsLaptop.PriceString);
            
            
            // Begin Customer Creation
            Customer sally = new Customer("Sally", "Williams", 23, 2028);
            Customer mike = new Customer("Mike", "Harrison", 10, 2019);

            if (sally.Age == 23)
            {
                Console.WriteLine("Sally is 23");
            }
            
            if (mike.Age == 10)
            {
                Console.WriteLine("Mike is 10");
            }
            // End Customer Creation

            int addThem = Math.AddNumbers(10, 12);


            Console.ReadLine();
        }
    }
}