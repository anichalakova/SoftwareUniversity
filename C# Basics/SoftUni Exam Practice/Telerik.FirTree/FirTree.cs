using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telerik.FirTree
{
    class FirTree
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int height = n;
            int width = (2 * n) - 3;
            char star = '*';
            char dot = '.';
            int symbolsOnRow = 1;
            int dotsBeforeAndAfter = (width - symbolsOnRow) / 2;

            for (int i = 0; i < height - 1; i++)
            {
            string stars = new string(star, symbolsOnRow);
            string dots = new string(dot, dotsBeforeAndAfter);
            string row = dots + stars + dots;
            Console.WriteLine(row);
            dotsBeforeAndAfter -= 1;
            symbolsOnRow += 2;
            }

            symbolsOnRow = 1;
            dotsBeforeAndAfter = (width - symbolsOnRow) / 2;
            Console.Write(new string(dot, dotsBeforeAndAfter));
            Console.Write(star);
            Console.Write(new string(dot, dotsBeforeAndAfter));
            Console.WriteLine();
        }
    }
}
