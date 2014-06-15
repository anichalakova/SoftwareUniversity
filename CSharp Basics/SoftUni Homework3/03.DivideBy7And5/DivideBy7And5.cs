using System;

    class DivideBy7And5
    {
        static void Main()
        {
            Console.Write("What is the number that you want to check? ");
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine(((num % 5 == 0) && (num % 7 == 0)) ? "It is divideable" : "It is not divideable");

            //Console.WriteLine("What is the number that you want to check");
            //int num = int.Parse(Console.ReadLine());
            //if (num % 5 == 0)
            //{
            //    if (num % 7 == 0)
            //    {
            //        Console.WriteLine("The number is divideable");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("The number cannot be divided by both numbers");
            //}
        }
    }