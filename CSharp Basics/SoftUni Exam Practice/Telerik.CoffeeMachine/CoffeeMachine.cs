using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telerik.CoffeeMachine
{
    class CoffeeMachine
    {
        static void Main(string[] args)
        {
            double n1 = double.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine());
            double n3 = double.Parse(Console.ReadLine());
            double n4 = double.Parse(Console.ReadLine());
            double n5 = double.Parse(Console.ReadLine());
            double a = double.Parse(Console.ReadLine());
            double p = double.Parse(Console.ReadLine());

            double n1Sum = 0.05 * n1;
            double n2Sum = 0.10 * n2;
            double n3Sum = 0.20 * n3;
            double n4Sum = 0.50 * n4;
            double n5Sum = 1.00 * n5;
            double totalSum = n1Sum + n2Sum + n3Sum + n4Sum + n5Sum;
            double change = a - p;

            if (a >= p)
            {
                if (totalSum >= change)
                {
                    Console.WriteLine("Yes " + "{0:0.00}", (totalSum - change));
                }
                else if (totalSum < change)
                {
                    Console.WriteLine("No " + "{0:0.00}", (change - totalSum));
                }
            }
            else if (a < p)
            {
                Console.WriteLine("More " + "{0:0.00}", (p - a));
            }
        }
    }
}
