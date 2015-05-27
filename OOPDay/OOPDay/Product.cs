using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDay
{
    // Product Class
    public class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string PriceString
        {
            get { return Price.ToString("C"); }
        }

        public decimal CalculatePrice()
        {
            return CalculatePrice(0, 0);
        }

        public decimal CalculatePrice(decimal taxRate, decimal discount)
        {
            return this.Price + (this.Price * taxRate) - (this.Price * discount);
        }

        public Product(string name, decimal price)
        {
            this.Name = name;
            this.Price = price;
        }

        public Product()
        {

        }

    }
    // End Product Class
    // Customer Class
    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        private int _age;

        public int Age
        {
            get 
            { 
                return _age; 
            }
            set 
            { 
                _age = value < 0 ? 0 : value;
            }
        }
        
        public int Birthdate { get; set; }

        public Customer(string first, string last, int age, int birthdate)
        {
            this.FirstName = first;
            this.LastName = last;
            this.Age = age;
            this.Birthdate = birthdate;
        }
    }
    // End Customer Class
    // AddNumbers Class
    public class Math
    {
        public int AddNumbers(int num1, int num2)
        {
            return num1 + num2;
        }
        
        public int AddNumbers(params int[] numbers)
        {
            int result = 0;
            foreach (var num in numbers)
            {
                result += num;
            }

            return result;
        }

    }
    // End AddNumbers Class
}
