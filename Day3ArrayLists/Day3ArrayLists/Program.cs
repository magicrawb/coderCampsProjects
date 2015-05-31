using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3ArrayLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> stringList = new List<string>();
            List<int> intList = new List<int>();



            Dictionary<string, string> states = new Dictionary<string, string>();
            states.Add("TX", "Texas");
            states.Add("NY", "New York");

            Dictionary<int, string> months = new Dictionary<int, string>();
            months.Add(1, "January");
            months.Add(2, "February");
            months.Add(3, "March");
            months.Add(4, "April");
            months.Add(5, "May");
            months.Add(6, "June");
            months.Add(7, "July");
            months.Add(8, "August");
            months.Add(9, "September");
            months.Add(10, "October");
            months.Add(11, "November");
            months.Add(12, "December");





            stringList.Add("Nick");
            stringList.Add("Cookies");
            intList.Add(4);

            foreach(object item in stringList)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();

            
        }
    }
}
