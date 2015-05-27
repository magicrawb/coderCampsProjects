using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day2lab5complex
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            Customer rob = new Customer();
            rob.FirstName = "Rob";
            rob.LastName = "Greenlee";

            rob.Checking.IsOpen = false;
            rob.Checking.Amount = 0.00m;
            rob.Checking.Id = rnd.Next();

            rob.Savings.IsOpen = true;
            rob.Savings.Amount = 12568.36m;
            rob.Savings.Id = rnd.Next();

            Console.ReadLine();
        }
    }
}
