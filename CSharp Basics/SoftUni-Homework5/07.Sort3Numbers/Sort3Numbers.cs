using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Sort3Numbers
{
    class Sort3Numbers
    {
        static void Main(string[] args)
        {
            List<int> newList = new List<int> { };
            for (int i = 0; i < 3; i++)
            {
                newList.Add(int.Parse(Console.ReadLine()));
            }
            newList.Sort();
            foreach (var item in newList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
