using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Triangle
{
    class Triangle
    {
        static void Main(string[] args)
        {
            int aX = int.Parse(Console.ReadLine());
            int aY = int.Parse(Console.ReadLine());
            int bX = int.Parse(Console.ReadLine());
            int bY = int.Parse(Console.ReadLine());
            int cX = int.Parse(Console.ReadLine());
            int cY = int.Parse(Console.ReadLine());

            double distanceAB = Math.Sqrt(((bX - aX) * (bX - aX)) + ((bY - aY) * (bY - aY)));
            double distanceBC = Math.Sqrt(((cX - bX) * (cX - bX)) + ((cY - bY) * (cY - bY)));
            double distanceCA = Math.Sqrt(((aX - cX) * (aX - cX)) + ((aY - cY) * (aY - cY)));

            if (distanceAB + distanceBC > distanceCA)
            {
                if (distanceBC + distanceCA > distanceAB)
                {
                    if (distanceCA + distanceAB > distanceBC)
                    {
                        double halfP = (distanceAB + distanceBC + distanceCA) / 2;
                        Console.WriteLine("Yes");
                        Console.WriteLine("{0:0.00}", Math.Sqrt(halfP * (halfP - distanceAB) * (halfP - distanceBC) * (halfP - distanceCA)));
                    }
                    else
                    {
                        Console.WriteLine("No");
                        Console.WriteLine("{0:0.00}", distanceAB);
                    }
                }
                else
                {
                    Console.WriteLine("No");
                    Console.WriteLine("{0:0.00}", distanceAB);
                    
                }
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine("{0:0.00}", distanceAB);
                
            }
        }
    }
}
