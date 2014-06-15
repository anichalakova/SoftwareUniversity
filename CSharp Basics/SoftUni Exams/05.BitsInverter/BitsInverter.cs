using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.BitsInverter
{
    class BitsInverter
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int step = int.Parse(Console.ReadLine());
            int index = 0;
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                for (int bit = 7; bit >= 0; bit--)
                {
                    index++;
                    if (step == 1 || index % 1 == 1)
                    {
                        num = num ^ (1 << bit);
                    }
                }
                Console.WriteLine(num);
            }
        }
    }
}
