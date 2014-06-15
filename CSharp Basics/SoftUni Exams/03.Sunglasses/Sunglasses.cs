using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Sunglasses
{
    class Sunglasses
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int frame = n * 2;
            int bridge = n;

            char symbol = '*';
            char lenses = '/';
            char bridgeSymbol = '|';

            string fullFrame = new string(symbol, frame);
            string empty = new string(' ', n);
            Console.Write(fullFrame);
            Console.Write(empty);
            Console.WriteLine(fullFrame);

            string bodyLenses = new string(lenses, frame - 2);
            string bodyFrame = symbol + bodyLenses + symbol;

            for (int i = 0; i < (n - 3) / 2; i++)
            {
                Console.WriteLine(bodyFrame + empty + bodyFrame);
            }

            string glassesBridge = new string(bridgeSymbol, n);
            Console.Write(bodyFrame);
            Console.Write(glassesBridge);
            Console.WriteLine(bodyFrame);

            for (int i = 0; i < (n - 3) / 2; i++)
            {
                Console.WriteLine(bodyFrame + empty + bodyFrame);
            }

            Console.Write(fullFrame);
            Console.Write(empty);
            Console.WriteLine(fullFrame);
        }
    }
}
