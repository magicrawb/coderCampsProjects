using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePractice
{
    
    class Program
    {
        static void Increment(int input)
        {
            input += 1;
        }
        static void Main(string[] args)
        {
            // Create a customer class and add two customers
            Customer sally = new Customer()
            {
                FirstName = "Sally",
                LastName = "Williams",
                Age = 23,
                BirthYear = 2028
            };

            Customer mike = new Customer()
            {
                FirstName = "Mike",
                LastName = "Harrison",
                Age = 10,
                BirthYear = 2019
            };

            if (sally.Age == 23)
            {
                Console.WriteLine("Sally is 23!");
            }

            if (mike.Age == 10)
            {
                Console.WriteLine("Mike is 10!");
            }

            // Increment a given number by one and print it using the
            // above Increment() method.
            Console.WriteLine("Enter any number");
            string userNumber = Console.ReadLine();
            int numConvert = Convert.ToInt32(userNumber);
            Increment(numConvert);
            Console.WriteLine(userNumber);

            // pause
            Console.ReadLine();
        }
    }
}
