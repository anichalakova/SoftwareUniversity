using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.BiggestOf5Numbers
{
    class BiggestOf5Numbers
    {
        static void Main(string[] args)
        {
            List<int> newList = new List<int> { };
            for (int i = 0; i < 5; i++)
            {
                newList.Add(int.Parse(Console.ReadLine()));
            }
            newList.Sort();
            Console.WriteLine(newList.Max());
        }
    }
}
