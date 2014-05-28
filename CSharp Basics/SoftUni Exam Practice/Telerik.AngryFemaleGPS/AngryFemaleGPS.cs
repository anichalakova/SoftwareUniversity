using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telerik.AngryFemaleGPS
{
    class AngryFemaleGPS
    {
        static void Main(string[] args)
        {
            string digits = Console.ReadLine();
            int countOdd = 0;
            int countEven = 0;
            for (int i = 0; i < digits.Length; i++)
            {
                if (char.IsDigit(digits[i]))
                {
                    if (int.Parse(digits[i].ToString()) % 2 == 1)
                    {
                        countOdd += int.Parse(digits[i].ToString()); 
                    }
                    else
                    {
                        countEven += int.Parse(digits[i].ToString());
                    }
                }
            }
            if (countEven > countOdd)
            {
                Console.WriteLine("right {0}", countEven);
            }
            else if (countOdd > countEven)
            {
                Console.WriteLine("left {0}", countOdd);
            }
            else
            {
                Console.WriteLine("straight {0}", countOdd);
            }
        }
    }
}
