using System;

    class Trapezoids
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program will calculate the area of a trapezoid");
            Console.Write("Please insert the first side's length: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Please insert the second side's length: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Insert the height of the trapezoid: ");
            double h = double.Parse(Console.ReadLine());
            double area = ((a + b) / 2) * h;

            Console.WriteLine();
            Console.WriteLine("The area is: {0}", area);
           
        }
    }