using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetterTryParse
{
    class Program
    {
        static void Main(string[] args)
        {
            int? num1 = TryParseAsInt("89898");
            Debug.Assert(num1 == 89898);

            int? num2 = TryParseAsInt("I am not a number");
            Debug.Assert(num2 == null);

            int? num 3 = TryParseAsInt("6.5");
            Debug.Assert(num3 == null);
        }
    }
}
