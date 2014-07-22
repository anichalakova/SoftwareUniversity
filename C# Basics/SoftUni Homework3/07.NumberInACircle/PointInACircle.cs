using System;

    class PointInACircle
    {
        static void Main(string[] args)
        {
            double xCircle = 1;
            double yCircle = 1;
            double r = 2;
            double d = 2 * r;

            Console.Write("Write the point X: ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Write the point Y: ");
            double y = double.Parse(Console.ReadLine());

            bool isInsideTheCircle = Math.Pow(x - xCircle, 2) + Math.Pow(y - yCircle, 2) <= d * d;
            if (isInsideTheCircle == true)
            {
                Console.WriteLine("The given points are inside the circle");
            }
            else
            {
                Console.WriteLine("The points are not inside the circle");
            }
        }
    }