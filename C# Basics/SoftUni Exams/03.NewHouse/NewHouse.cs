using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.NewHouse
{
    class NewHouse
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int height = n;
            int width = n;

            char roofSymbol = '*';
            char emptySpace = '-';
            char wall = '|';
            int symbolsOnRoof = 1;
            int emptySpacesOnRoof = (n - symbolsOnRoof) / 2;

            for (int i = 0; i < (n / 2) + 1; i++)
            {
                string roof = new string(roofSymbol, symbolsOnRoof);
                string emptySpaces = new string(emptySpace, emptySpacesOnRoof);
                string roofrow = emptySpaces + roof + emptySpaces;
                Console.WriteLine(roofrow);
                symbolsOnRoof += 2;
                emptySpacesOnRoof -= 1;
            }

            int symbolsOnRow = n - 2;
            for (int i = 0; i < n; i++)
            {
                string bodySymbols = new string(roofSymbol, symbolsOnRow);
                Console.WriteLine(wall + bodySymbols + wall);
            }
        }
    }
}
