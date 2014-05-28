using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telerik.WeAllLoveBits
{
    class WeAllLoveBits
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int result = 0;
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());

                result = 0;
                while (num > 0)
                {
                    int lastBit = num & 1;
                    num = num >> 1;
                    result = result << 1;
                    result = result | lastBit;
                }
            Console.WriteLine(result);
            }
        }
    }
}
