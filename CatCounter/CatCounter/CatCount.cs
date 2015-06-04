using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatCounter
{
    public class CatCount
    {

        public static int CatCountMethod(string s)
        {
            //strips punctuation and splits to array by spaces
            string[] cats = s.StripPunctuation().Split(' ');
            int counter = 0;

            //runs through the array and counts each cat
            foreach (string word in cats)
            {
                string w = word.ToLower();
                if (w == "cat")
                {
                    counter++;
                }
                if (w == "cats")
                {
                    counter++;
                }
                else
                {

                }

            }

            return counter;
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
