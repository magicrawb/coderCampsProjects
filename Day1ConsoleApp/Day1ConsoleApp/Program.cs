using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Day1ConsoleApp
{
    /// <summary>
    /// 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        { 
            for (int i = 0; i <= 100; i++)
            {
                if (i % 7 == 0)
                {
                    Console.WriteLine(i);
                }
                else
                {
                    
                }
            }

            Random rndTwo = new Random();
            int rndInt = rndTwo.Next(1, 16);

            switch (rndInt)
            {
                case 1:
                    
                case 2:
                    
                case 3:
                    
                case 4:

                case 5:
                    Console.WriteLine(rndInt + " Martians Attack!");
                    break;
                case 6:

                case 7:

                case 8:

                case 9:

                case 10:
                    Console.WriteLine(rndInt + " Seahawks Win The Superbowl!");
                    break;
                case 11:

                case 12:

                case 13:

                case 14:

                case 15:
                    Console.WriteLine(rndInt + " Hey Hey Hey");
                    break;
            }


            Console.WriteLine("Enter today's date!");
            string entry = Console.ReadLine();
            DateTime enteredDate = DateTime.Parse(entry);
            Console.WriteLine(enteredDate.ToLongDateString());


            //SmtpClient client = new SmtpClient();

            //MailMessage message = new MailMessage();
            //message.Subject = "Hello!";
            //Console.WriteLine(message2.Subject);
            //message2.Subject = "got ya";
            //Console.WriteLine(message.Subject);

            Random rnd = new Random();
            var result = rnd.Next(10);

            Console.WriteLine(DateTime.Now.ToShortTimeString());

            // C# Data Types
            // bool isTodayTuesday = true;
            // int number = 12345; // could be int32 or int64
            // long biggerNumber = 23461; // use 'long' for int64 (can store bigger numbers)
            // float fl = 3.342f;
            // double db = 32.34; 
            // decimal dec = 234.346m; // 128 bit
            // string test = "asdfas";
            // DateTime date;



            Console.WriteLine("Enter a number");
            string input = Console.ReadLine();

            int num = 0;

            if (int.TryParse(input, out num))
            {
                int doubledNumber = num + num;
                Console.WriteLine(doubledNumber);
            }
            else
            {
                Console.WriteLine("You suck, try again.");
            }

            //try
            //{
            //    int num = int.Parse(input);
            //    int doubledNumber = num + num;
            //    Console.WriteLine(doubledNumber);
            //}
            //catch
            //{
            //    Console.WriteLine("You suck, try again.");
            //} 


            MailMessage message = new MailMessage();
            message.Subject = "Starting subject";
            
            // write subject before
            Console.WriteLine(message.Subject);

            // change the subject
            ChangeSubject(message);
            
            // write the new subject
            Console.WriteLine(message.Subject);

            Console.ReadLine();
            
        }

        public static void ChangeSubject(MailMessage message)
        {
            message.Subject = "This is the new subject";
        }
    }
}
