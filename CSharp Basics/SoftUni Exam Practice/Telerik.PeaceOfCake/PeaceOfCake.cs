using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telerik.PeaceOfCake
{
    class PeaceOfCake
    {
        static void Main(string[] args)
        {
            ulong a = ulong.Parse(Console.ReadLine());
            ulong b = ulong.Parse(Console.ReadLine());
            ulong c = ulong.Parse(Console.ReadLine());
            ulong d = ulong.Parse(Console.ReadLine());

            ulong denominator = b * d;
            a *= d;
            c *= b;

            ulong sum = a + c;
            decimal result = sum / denominator;
            if (result >= 1)
            {
                Console.WriteLine(result);
                Console.WriteLine("{0} / {1}", result, denominator);
            }
            else
            {
                decimal num = (Convert.ToDecimal(a) + Convert.ToDecimal(c) / Convert.ToDecimal(denominator));
                Console.WriteLine("{0:0.00000000000000}", num);
                Console.WriteLine("{0} / {1}", result, denominator);
            }
        }
    }
}
