using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.OddEvenSum
{
    class OddEvenSum
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int counter = 1;
            int evenSum = 0;
            int oddSum = 0;

            for (int i = 0; i < n * 2; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (counter % 2 == 0)
                {
                    evenSum += num;
                }
                else
                {
                    oddSum += num;
                }
                counter++;
            }

            if (oddSum == evenSum)
            {
                Console.WriteLine("Yes, sum={0}", oddSum);
            }
            else if (oddSum > evenSum)
            {
                Console.WriteLine("No, diff={0}", oddSum - evenSum);
            }
            else if (evenSum > oddSum)
            {
                Console.WriteLine("No, diff={0}", evenSum - oddSum);
            }
        }
    }
}
