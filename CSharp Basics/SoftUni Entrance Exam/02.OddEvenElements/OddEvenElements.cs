using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.OddEvenElements
{
    class OddEvenElements
    {
        static void Main(string[] args)
        {
            string numbers = Console.ReadLine();
            List<double> evenIndexes = new List<double> { };
            List<double> oddIndexes = new List<double> { };

            if (numbers.Length == 1)
            {
                int n = Convert.ToInt32(numbers);
                oddIndexes.Add(n);

            }
            else if (numbers.Length == 0)
            {
                Console.WriteLine("OddSum=No, OddMin=No, OddMax=No, EvenSum=No, EvenMin=No, EvenMax=No");
                return;
            }
            else if (numbers.Length > 1)
            {
                var nums = numbers.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                  .Select(i => double.Parse(i))
                                  .ToList();
                int count = 0;
                for (int i = 0; i < nums.Count; i++)
                {
                    if (count % 2 == 0)
                    {
                        oddIndexes.Add(nums[i]);
                    }
                    else
                    {
                        evenIndexes.Add(nums[i]);
                    }
                    count++;
                }
            }

            
            if (oddIndexes.Count != 0 && evenIndexes.Count != 0)
            {
                double oddSum = oddIndexes.Sum();
                double oddMin = oddIndexes.Min();
                double oddMax = oddIndexes.Max();

                double evenSum = evenIndexes.Sum();
                double evenMin = evenIndexes.Min();
                double evenMax = evenIndexes.Max();

                Console.WriteLine("OddSum={0}, OddMin={1}, OddMax={2}, EvenSum={3}, EvenMin={4}, EvenMax={5}",
                                    oddSum, oddMin, oddMax, evenSum, evenMin, evenMax);    
            }
            else if (oddIndexes.Count < 1)
            {
                double evenSum = evenIndexes.Sum();
                double evenMin = evenIndexes.Min();
                double evenMax = evenIndexes.Max();

                Console.WriteLine("OddSum=No, OddMin=No, OddMax=No, EvenSum={0}, EvenMin={1}, EvenMax={2}"
                                    , evenSum, evenMin, evenMax); 
            }
            else if (evenIndexes.Count < 1)
            {
                double oddSum = oddIndexes.Sum();
                double oddMin = oddIndexes.Min();
                double oddMax = oddIndexes.Max();

                Console.WriteLine("OddSum={0}, OddMin={1}, OddMax={2}, EvenSum=No, EvenMin=No, EvenMax=No",
                                oddSum, oddMin, oddMax); 
            }
        }
    }
}
