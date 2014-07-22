using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telerik.QuadronacciRectangle
{
    class QuadronacciRectangle
    {
        static void Main(string[] args)
        {
            long first = long.Parse(Console.ReadLine());
            long second = long.Parse(Console.ReadLine());
            long third = long.Parse(Console.ReadLine());
            long fourth = long.Parse(Console.ReadLine());

            int r = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            while (r >= 20 || r <= 1)
            {
                r = int.Parse(Console.ReadLine());
            }
            while (c >= 20 || c <= 4)
            {
                c = int.Parse(Console.ReadLine());
            }

            int counter = 0;
            int maxNumbers = r * c;

            Console.Write(first + " "); Console.Write(second + " "); Console.Write(third + " "); Console.Write(fourth + " ");

            for (int i = 0; i < maxNumbers - 4; i++)
            {
                long newNumber = first + second + third + fourth;
                first = second;
                second = third;
                third = fourth;
                fourth = newNumber;

                Console.Write(fourth + " ");

                counter++;
                if (counter == c - 4)
                {
                    Console.WriteLine();
                }
            }
        }
    }
}
