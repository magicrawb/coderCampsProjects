using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2Lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            string cleaned = Utility.CleanUserInput("   aswefae    ");

            Console.WriteLine("Please type any sentence.");
            Counter.WordCount(Console.ReadLine());
                
        }
    }
}
