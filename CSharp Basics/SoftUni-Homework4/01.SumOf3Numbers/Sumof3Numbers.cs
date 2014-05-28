using System;

    class SumOf3Numbers
    {
        static void Main()
        {
            Console.Write("Please insert a number: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Please insert another number: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Please insert the last number: ");
            int c = int.Parse(Console.ReadLine());
            int sum = a + b + c;

            Console.WriteLine("The sum of {0}, {1} and {2} is equal to {3}", a, b, c, sum);
        }
    }
