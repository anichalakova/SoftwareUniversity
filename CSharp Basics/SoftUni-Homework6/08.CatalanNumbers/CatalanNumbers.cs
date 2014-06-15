using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.CatalanNumbers
{
    class CatalanNumbers
    {
        static void Main(string[] args)
        {
            uint n = uint.Parse(Console.ReadLine());
            uint factorialN = 1;
            uint plusFactorialN = 1;
            uint multiFactorialN = 1;

            for (uint i = 1; i <= n; i++)
            {
                factorialN = factorialN * i;
            }
            for (uint j = 1; j <= n + 1; j++)
            {
                plusFactorialN = plusFactorialN * j;
            }
            for (uint k = 1; k <= n * 2; k++)
            {
                multiFactorialN = multiFactorialN * k;
            }

            uint result = multiFactorialN / (plusFactorialN * factorialN);
            Console.WriteLine(result);
        }
    }
}
