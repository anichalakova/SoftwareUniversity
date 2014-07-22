using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telerik.SubsequentSums
{
    class SubsequentSums
    {
        static void Main(string[] args)
        {
            int s = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            List<int> numbers = new List<int> { };

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                numbers.Add(num);
            }

            int listLength = numbers.Count;
            int counter = 0;
            for (int i = 0; i < listLength; i++)
            {
                int sum = 0;
                for (int j = i; j < listLength; j++)
                {
                    sum += numbers[j];

                    if (sum == s)
                    {
                        counter++;
                    }
                }
            }
            Console.WriteLine(counter);
        }
    }
}
