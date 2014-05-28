using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.WorkHours
{
    class WorkHours
    {
        static void Main(string[] args)
        {
            double h = double.Parse(Console.ReadLine());
            double d = double.Parse(Console.ReadLine());
            double p = double.Parse(Console.ReadLine());

            double availableTime = d - d * 0.1d;
            double maxWorkingHours = availableTime * 12d;
            double actualWorkingHours = maxWorkingHours * p / 100d;

            if (actualWorkingHours > h)
            {
                Console.WriteLine("Yes");
                Console.WriteLine((int)actualWorkingHours - (int)h);
            }
            else if (h > actualWorkingHours)
            {
                Console.WriteLine("No");
                Console.WriteLine("-{0}", (int)h - (int)actualWorkingHours);
            }
            else
            {
                Console.WriteLine("Yes");
                Console.WriteLine("0");
            }

        }
    }
}
