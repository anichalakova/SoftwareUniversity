using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.TheExplorer
{
    class Explorer
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int height = n;
            int width = n;

            char star = '*';
            char line = '-';

            int starsOnRow = 1;
            int linesOnRow = (n - starsOnRow) / 2;

            string stars = new string(star, starsOnRow);
            string lines = new string(line, linesOnRow);
            string row = lines + stars + lines;
            Console.WriteLine(row);
            int linesBetweenNum = 1;
            int linesBeforeAndAfterNum = (n - 3) / 2; 

            for (int i = 0; i < n / 2; i++)
            {
                string linesBeforeAfter = new string(line, linesBeforeAndAfterNum);
                string linesBetween = new string(line, linesBetweenNum);
                string bodyRow = linesBeforeAfter + star + linesBetween + star + linesBeforeAfter;
                Console.WriteLine(bodyRow);
                linesBetweenNum += 2;
                linesBeforeAndAfterNum--;
            }
            linesBetweenNum -= 2;
            linesBeforeAndAfterNum++;
            for (int i = 0; i < n / 2 - 1; i++)
            {
                linesBetweenNum -= 2;
                linesBeforeAndAfterNum++;
                string linesBeforeAfter = new string(line, linesBeforeAndAfterNum);
                string linesBetween = new string(line, linesBetweenNum);
                string bodyRow = linesBeforeAfter + star + linesBetween + star + linesBeforeAfter;
                Console.WriteLine(bodyRow);
            }
            Console.WriteLine(row);
        }
    }
}
