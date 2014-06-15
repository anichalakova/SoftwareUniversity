using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telerik.Eggcelent
{
    class Eggcelent
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int eggHeight = n * 2;
            int eggWidth = (3 * n) - 1;
            int totalWidth = (3 * n) + 1;
            int topAndBottom = n - 1;

            char egg = '*';
            char crack = '@';
            char empty = '.';
            //First to make the top of the egg.
            for (int i = 0; i < 1; i++)
            {
                int dotsBeforeAndAfter = (totalWidth - topAndBottom) / 2;
                string dotsOutside = new string(empty, dotsBeforeAndAfter);
                string topSymbols = new string(egg, topAndBottom);
                string topAndBottomLine = dotsOutside + topSymbols + dotsOutside;
                Console.WriteLine(topAndBottomLine);
            }
            //First part of the egg.
            int body = (eggHeight / 2) - 2;
            int dotsOutsideEgg = n - 2;
            int dotsInsideEgg = n + 1;
            for (int i = 0; i < body; i++)
            {
                string dotsOutside = new string(empty, dotsOutsideEgg);
                string dotsInside = new string(empty, dotsInsideEgg);
                string line = (empty + dotsOutside + egg + dotsInside + egg + dotsOutside + empty);
                Console.WriteLine(line);
                dotsOutsideEgg -= 1;
                dotsInsideEgg += 2;
            }
            //The cracked part of the egg.

        }
    }
}
