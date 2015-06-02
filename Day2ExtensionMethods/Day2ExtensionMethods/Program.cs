using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] newsHeadlines = {"Mars Attacks!", "Venus Explodes!", "Uranus.. Lol"};
            Console.WriteLine(newsHeadlines.GetRandom());

            Console.ReadLine();

        }
    }

    public static class Randomize
    {

        public static Z GetRandom<Z>(this Z[] arrayToExtend)
        {
            Random rnd = new Random();
            int index = rnd.Next(arrayToExtend.Length);
            return arrayToExtend[index];

            //if (randomInt == 0)
            //{
            //    return headlines.GetValue(0).ToString();
            //}
            //else if (randomInt == 1)
            //{
            //    return headlines.GetValue(1).ToString();
            //}
            //else
            //{
            //    return headlines.GetValue(2).ToString();
            //}
        }
    }
}
