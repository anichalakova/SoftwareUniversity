using System;

    class FourDigitNumber
    {
        static void Main(string[] args)
        {
            Console.Write("Please insert a four-digit number: ");
            int number = int.Parse(Console.ReadLine());

            int d = number % 10;
            number /= 10;
            int c = number % 10;
            number /= 10;
            int b = number % 10;
            number /= 10;
            int a = number % 10;
            number /= 10;
            int sum = a + b + c + d;

            Console.WriteLine();
            Console.WriteLine("The sum of the digits is: {0}", sum);
            Console.WriteLine("The reverse number is: " + d + c + b + a);
            Console.WriteLine("Last number infront: "+ d + a + b + c);
            Console.WriteLine("Third number on second position: "+ a + c + b + d);
        }
    }