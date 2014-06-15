using System;

    class AreaAndPerimeter
    {
        static void Main(string[] args)
        {
            Console.Write("Please insert radius: ");
            double r = double.Parse(Console.ReadLine());
            double pi = 3.14;

            double area = pi * r * r;
            double perimeter = 2 * pi * r;

            Console.WriteLine("The area is {0}", area);
            Console.WriteLine("The perimeter is {0}", perimeter);
        }
    }
