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

    //Person creator
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public Purchase PersonsPurchase { get; set; }
    }

    //Purchase creator
    class Purchase
    {
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }
    }


    //Tax class with Calculate tax method
    class Tax
    {
        public static decimal Calculate(Person shopper)
        {
            string FirstName = shopper.FirstName.ToLower();
            string LastName = shopper.LastName.ToLower();
            decimal Cost = shopper.PersonsPurchase.ProductPrice;
            decimal BaseTax = .08m;

            DateTime CurrentDay = new DateTime();
            string today = CurrentDay.DayOfWeek.ToString();


            if (FirstName[0] == 'j')
            {
                Cost = (BaseTax * 2) * Cost + Cost;
                return Cost;
            }

            if (today == "Thursday")
            {
                Cost = (BaseTax * 2) * Cost + Cost;
                return Cost;
            }

            if (LastName[0] == 'w')
            {
                Cost = ((BaseTax * 2) * Cost) - 1 + Cost;
                return Cost;
            }

            if (shopper.Age <= 5)
            {
                return Cost = shopper.PersonsPurchase.ProductPrice;
            }

            return Cost;
        }
    }
}
