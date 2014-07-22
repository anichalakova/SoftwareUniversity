using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.BonusScore
{
    class BonusScore
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            if (num >= 1 && num <= 3)
            {
                Console.WriteLine(num * 10);
            }
            else if (num >= 4 && num <= 6)
            {
                Console.WriteLine(num * 100);
            }
            else if (num >=7 && num <= 9)
            {
                Console.WriteLine(num * 1000);
            }
            else if (num == 0 && num > 9)
            {
                Console.WriteLine("Invalid Score");
            }
        }
    }
}
