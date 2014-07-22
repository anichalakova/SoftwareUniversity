using System;

class QuadraticEquation
{
    static void Main()
    {
        Console.WriteLine("axx + bx + c = 0     D = b*b - 4ac");
        Console.WriteLine();
        Console.Write("a = ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("b = ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("c = ");
        double c = double.Parse(Console.ReadLine());
        double des = (b * b) - (4 * a * c);
        if (des < 0)
        {
            Console.WriteLine("There is no real roots.");
        }
        if (des > 0)
        {
            Console.WriteLine("X1 = {0}", (-b - Math.Sqrt(des)) / (2 * a));
            Console.WriteLine("X2 = {0}", (-b + Math.Sqrt(des)) / (2 * a));
        }
        if (des == 0)
        {
            Console.WriteLine("X1 = X2 = {0}", -b / (2 * a));
        }
    }
}