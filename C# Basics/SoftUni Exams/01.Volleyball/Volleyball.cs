using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Volleyball
{
    class Volleyball
    {
        static void Main(string[] args)
        {
            string yearType = Console.ReadLine();
            int p = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());

            int totalWeekends = 48;
            int normalWeekends = totalWeekends - h;
            double playableWeekends = (normalWeekends / 4d) * 3d;
            double playableHolidays = (p / 3d) * 2d;
            double playableHometown = h;

            double sum = (playableWeekends + playableHometown + playableHolidays);

            if (yearType == "leap")
            {
                sum = sum + sum * 0.15d;
            }
            Console.WriteLine((int)sum);
        }
    }
}
