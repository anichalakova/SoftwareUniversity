using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class KaspichaniaBoats
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char symbol = '*';
            char dot = '.';
            int boatWidth = (n * 2) + 1;
            int boatHeight = 6 + ((n - 3) / 2);
            int charsOnRow = boatWidth;
            int dotsOnRow = boatWidth / 2;
            string dots = new string(dot, dotsOnRow);
            string topRow = dots + symbol + dots;
            Console.WriteLine(topRow);
            int dotsInBody = (charsOnRow / 2) - 1;
            int dotsOutsideBoat = dotsInBody;
            int dotsInsideBoat = dotsOutsideBoat - dotsInBody;
            do
            {
                string dotsOutside = new string(dot, dotsOutsideBoat);
                string dotsInside = new string(dot, dotsInsideBoat);
                string bodyRow = dotsOutside + symbol + dotsInside + symbol + dotsInside + symbol + dotsOutside;
                Console.WriteLine(bodyRow);
                dotsOutsideBoat -= 1;
                dotsInsideBoat += 1;
            }
            while (dotsOutsideBoat > 0);
            string fullLine = new string(symbol, boatWidth);
            Console.WriteLine(fullLine);
            while (dotsOutsideBoat != dotsInsideBoat)
            {
                dotsOutsideBoat += 1;
                dotsInsideBoat -= 1;
                string dotsOutside = new string(dot, dotsOutsideBoat);
                string dotsInside = new string(dot, dotsInsideBoat);
                string bodyRow = dotsOutside + symbol + dotsInside + symbol + dotsInside + symbol + dotsOutside;
                Console.WriteLine(bodyRow);
            }
            int finalDots = charsOnRow - n;
            string dotsOnLastRow = new string(dot, finalDots / 2);
            string symbolsOnLastRow = new string(symbol, n);
            Console.WriteLine(dotsOnLastRow + symbolsOnLastRow + dotsOnLastRow);
        }
    }
