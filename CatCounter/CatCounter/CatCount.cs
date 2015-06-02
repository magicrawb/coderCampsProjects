using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatCounter
{
    public class CatCount
    {
        public int Counter { get; set; }

        public static int CatCountMethod(string s)
        {
            string[] cats = s.StripPunctuation().Split(' ');
            CatCount counter = new CatCount();
            counter.Counter = 0;

            foreach (string word in cats)
            {
                string w = word.ToLower();
                if (w == "cat")
                {
                    counter.Counter++;
                }
                if (w == "cats")
                {
                    counter.Counter++;
                }
                else
                {

                }

            }

            return counter.Counter;

        }
    }

    public static class StringExtension
    {
        public static string StripPunctuation(this string s)
        {
            var sb = new StringBuilder();
            foreach (char c in s)
            {
                if (!char.IsPunctuation(c))
                    sb.Append(c);
            }
            return sb.ToString();
        }
    }
}
