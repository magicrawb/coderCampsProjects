using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day2lab5complex
{
    class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }


        public CheckingAccount Checking { get; set; }
        public SavingsAccount Savings { get; set; }

        public Customer()
        {
            this.Checking = new CheckingAccount();
            this.Savings = new SavingsAccount();
        }
    }
}
