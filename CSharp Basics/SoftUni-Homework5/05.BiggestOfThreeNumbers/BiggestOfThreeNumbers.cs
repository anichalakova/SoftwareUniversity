using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.BiggestOfThreeNumbers
{
    class BiggestOfThreeNumbers
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            int greater = 0;
            if (num1 > num2 && num1 > num3)
            {
                greater = num1;
                Console.WriteLine(greater);
            }
            else if (num2 > num1 && num2 > num3)
            {
                greater = num2;
                Console.WriteLine(greater);
            }
            else if (num3 > num1 && num3 > num2)
            {
                greater = num3;
                Console.WriteLine(greater);
            }
        }
    }
}
