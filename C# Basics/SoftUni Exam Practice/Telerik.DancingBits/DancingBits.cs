using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telerik.DancingBits
{
    class DancingBits
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            string bin = string.Empty;
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                string number = Convert.ToString(num, 2);
                bin += number;
            }
            Console.WriteLine(bin);
        }
    }
}
