using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Eclipse
{
    class Eclipse
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int height = n;

            char symbol = '*';
            char glass = '/';
            char bridgeSym = '-';

            int topFrame = (n * 2) - 2;
            int bridgeLength = n - 1;

            string firstAndLastRowFrame = new string(symbol, topFrame);
            string empty = new string(' ', bridgeLength);
            string firstAndLastRow = ' ' + firstAndLastRowFrame + ' ' + empty + ' ' + firstAndLastRowFrame + ' ';
            Console.WriteLine(firstAndLastRow);

            string bridge = new string(bridgeSym, bridgeLength);
            string lenses = new string(glass, topFrame);
            for (int i = 0; i < n - 2; i++)
            {
                if (i == (n - 2) / 2)
                {
                    string midRow = symbol + lenses + symbol + bridge + symbol + lenses + symbol;
                    Console.WriteLine(midRow);
                }
                else if (true)
                {
                    string bodyRow = symbol + lenses + symbol + empty + symbol + lenses + symbol;
                    Console.WriteLine(bodyRow);
                }
            }
            Console.WriteLine(firstAndLastRow);
        }
    }
}
