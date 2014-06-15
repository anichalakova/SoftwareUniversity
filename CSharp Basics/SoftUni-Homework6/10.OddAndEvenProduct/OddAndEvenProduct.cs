using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.OddAndEvenProduct
{
    class OddAndEvenProduct
    {
        static void Main(string[] args)
        {
            string nums = Console.ReadLine();
            int evenSum = 0;
            int oddSum = 0;
            var numbers = nums.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                  .Select(i => int.Parse(i))
                                  .ToList();
                int counter = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                if (counter % 2 == 0)
                {
                    evenSum += numbers[i];
                }
                else 
                {
                    oddSum += numbers[i];
                }
            }

            if (evenSum == oddSum)
            {
                Console.WriteLine("Yes");
            }
            else if (evenSum != oddSum)
            {
                Console.WriteLine("No");
            }
        }
    }
}
