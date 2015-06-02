using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Copy and Paste ANY block of text - I'll tell you how many cats it contains!");
            String catString = Console.ReadLine();
            Console.WriteLine("The word 'Cat' appears {0} times!", CatCount.CatCountMethod(catString));

            Console.ReadLine();
        }
    }
}
