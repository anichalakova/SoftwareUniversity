using System;

    class Rectangles
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program will calculate the perimeter and area of a rectangle");
            Console.Write("Insert the rectangle's width: ");
            double width = double.Parse(Console.ReadLine());
            Console.Write("Insert the rectangle's height: ");
            double height = double.Parse(Console.ReadLine());

            double perimeter = (width * 2) + (height * 2);
            double area = (width * height);

            Console.WriteLine("The perimeter is {0}", perimeter);
            Console.WriteLine("The area is {1}", area);
        }
    }