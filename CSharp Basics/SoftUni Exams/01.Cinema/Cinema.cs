using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Cinema
{
    class Cinema
    {
        static void Main(string[] args)
        {
            string projectionType = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());
            double sum = 0;

            int people = rows * columns;

            if (projectionType == "Premiere")
            {
                sum = 12d * people;
            }
            else if (projectionType == "Normal")
            {
                sum = 7.50d * people;
            }
            else if (projectionType == "Discount")
            {
                sum = 5d * people;
            }

            Console.WriteLine("{0:0.00} leva", sum);
        }
    }
}
