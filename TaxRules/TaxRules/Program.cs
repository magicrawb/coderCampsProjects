using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxRules
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            Person john = new Person();
            john.FirstName = "John";
            john.LastName = "Williams";
            john.Age = 23;
            Purchase G3 = new Purchase();
            G3.ProductName = "LG G3";
            G3.ProductPrice = 450.0m;

            john.PersonsPurchase = G3;

            Console.WriteLine(Tax.Calculate(john));

            stopwatch.Stop();
            Console.WriteLine("Total time is {0} milliseconds", stopwatch.ElapsedMilliseconds);

            Console.ReadLine();
        }
    }

    
}
