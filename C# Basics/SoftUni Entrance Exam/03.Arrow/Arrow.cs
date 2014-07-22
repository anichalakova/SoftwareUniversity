using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Arrow
{
    class Arrow
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int width = n;
            int totalWidth = width + width - 1;
            int height = (2 * n) - 1;
            int dotsBeforeAndAfter = n / 2;

            char symbol = '#';
            char dot = '.';

            string dotsOnFirstLine = new string(dot, dotsBeforeAndAfter);
            string symbolsOnFirstLine = new string(symbol, n);
            string firstLine = dotsOnFirstLine + symbolsOnFirstLine + dotsOnFirstLine;
            Console.WriteLine(firstLine);

            for (int i = 0; i < height / 2 - 1; i++)
            {
                string dotsBeforeAfter = new string(dot, dotsBeforeAndAfter);
                string dotsBetween = new string(dot, n - 2);
                string row = dotsBeforeAfter + symbol + dotsBetween + symbol + dotsBeforeAfter;
                Console.WriteLine(row);
            }

            string symbolsOnMidRow = new string(symbol, dotsBeforeAndAfter + 1);
            string dotsOnMidRow = new string(dot, n - 2);
            string midRow = symbolsOnMidRow + dotsOnMidRow + symbolsOnMidRow;
            Console.WriteLine(midRow);

            int dotsBeforeAndAfterArrow = 1;
            int dotsInside = (totalWidth - 2) - (dotsBeforeAndAfterArrow * 2);
            for (int i = 0; i < height / 2 - 1; i++)
            {
                string dotsBeforeArrow = new string(dot, dotsBeforeAndAfterArrow);
                string dotsAfterArrow = new string(dot, dotsBeforeAndAfterArrow);
                string dotsInsideArrow = new string(dot, dotsInside);
                string row = dotsBeforeArrow + symbol + dotsInsideArrow + symbol + dotsAfterArrow;
                Console.WriteLine(row);
                dotsBeforeAndAfterArrow++;
                dotsInside -= 2;
                
            }
            int dotsOnLastRow = (totalWidth - 1) / 2;
            string finalDots = new string(dot, dotsOnLastRow);
            string finalRow = finalDots + symbol + finalDots;
            Console.WriteLine(finalRow);
        }
    }
}
