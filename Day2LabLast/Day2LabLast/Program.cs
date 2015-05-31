using Day2LabLast.Animals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2LabLast
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal eagle = new Animal()
            {
                Name = "Eagle",
                Sound = "U.S. Freakin' A."
            };
            Animal bear = new Animal()
            {
                Name = "Bear",
                Sound = "Roar"
            };
            Animal chicken = new Animal()
            {
                Name = "Chicken",
                Sound = "Bock Bock"
            };

            AnimalUtility.DoSomething(eagle);

            Console.ReadLine();

        }
    }
}
