using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxRules
{
    
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
