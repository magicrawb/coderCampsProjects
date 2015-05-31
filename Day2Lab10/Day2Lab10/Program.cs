using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2Lab10
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee rob = new Employee();
            rob.FirstName = "Rob";
            rob.LastName = "Greenlee";

            Employee[] employees = new Employee[] 
            { 
                rob, 
                new Employee
                { 
                    FirstName = "Alex", 
                    LastName = "Isaac"
                },
                new Employee
                {
                    FirstName = "Keenan",
                    LastName = "Silver"
                }
            };

            Array.Sort(employees, new LastFirstComparer());

            foreach (var employee in employees)
            {
                Console.WriteLine(employee.FirstName + " " + employee.LastName);
            }

            //var colors = new string[] { "Red", "Green", "Blue" };
            //Array.Sort(colors);

            //foreach (var color in colors)
            //{
            //    Console.WriteLine(color);
            //}

            Console.ReadLine();
        }
    }
}
