using System;

    class OddOrEvenIntegers
    {
        static void Main(string[] args)
        {
            Console.Write("Please insert your number: ");
            int num = int.Parse(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine("The number is not odd");
            }
            else
            {
                Console.WriteLine("The number is odd");
            }
        }
    }