﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telerik.LeastMajorityMultiple
{
    class LeastMajorityMultiple
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            int e = int.Parse(Console.ReadLine());

            for (long i = 0; i < long.MaxValue; i++)
            {
                int count = 0;
                if (i % a == 0)
                {
                    count++;
                }
                if (i % b == 0)
                {
                    count++;
                }
                if (i % c == 0)
                {
                    count++;
                }
                if (i % d == 0)
                {
                    count++;
                }
                if (i % e == 0)
                {
                    count++;
                }
                if (count >= 3)
                {
                    Console.WriteLine(i);
                    break;
                }
            }
        }
    }
}
