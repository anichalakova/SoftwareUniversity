using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.MinMaxSum
{
    class MinMaxSum
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<int> newList = new List<int> { };
            for (int i = 0; i < n; i++)
            {
                newList.Add(int.Parse(Console.ReadLine()));
            }

            Console.WriteLine("min = {0}", newList.Min());
            Console.WriteLine("max = {0}", newList.Max());
            Console.WriteLine("sum = {0}", newList.Sum());
            Console.WriteLine("average = {0:0.00}", newList.Average());
        }
    }
}
