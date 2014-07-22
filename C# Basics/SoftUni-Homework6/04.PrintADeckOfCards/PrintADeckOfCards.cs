using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.PrintADeckOfCards
{
    class PrintADeckOfCards
    {
        static void Main(string[] args)
        {
            List<string> cards = new List<string> {"A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };
            List<string> paint = new List<string> {"♠", "♥", "♣", "♦"};

            foreach (var card in cards)
            {
                foreach (var color in paint)
                {
                    Console.Write("{0}{1} ", card, color);
                }
                Console.WriteLine();
            }
        }
    }
}
