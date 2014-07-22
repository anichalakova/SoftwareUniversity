using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.RandomNumbersInGivenRange
{
    class RandomNumbersInGivenRange
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int min = int.Parse(Console.ReadLine());
            int max = int.Parse(Console.ReadLine());
            Random r = new Random();

            for (int i = 0; i < n; i++)
            {
                int randomInt = r.Next(min, max);
                Console.WriteLine(randomInt);
            }
        }
    }
}
