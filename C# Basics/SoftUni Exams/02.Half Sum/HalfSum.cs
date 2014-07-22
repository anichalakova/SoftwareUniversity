using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Half_Sum
{
    class HalfSum
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int doubleN = n * 2;
            int counter = 0;
            int firstSum = 0;
            int secondSum = 0;
            for (int i = 0; i < doubleN; i++)
            {
                int j = int.Parse(Console.ReadLine());
                if (counter < n)
                {
                    firstSum += j;
                }
                else
                {
                    secondSum += j;
                }
                counter++;
            }
            if (firstSum == secondSum)
            {
                Console.WriteLine("Yes, sum={0}", firstSum);
            }
            else if (firstSum > secondSum)
            {
                Console.WriteLine("No, diff={0}", firstSum - secondSum);
            }
            else if (secondSum > firstSum)
            {
                Console.WriteLine("No, diff={0}", secondSum - firstSum);
            }
        }
    }
}
