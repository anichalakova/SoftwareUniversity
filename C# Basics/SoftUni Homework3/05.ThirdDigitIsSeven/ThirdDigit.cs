using System;

    class ThirdDigit
    {
        static void Main(string[] args)
        {
            Console.Write("Insert number: ");
            int num = int.Parse(Console.ReadLine());

            if ((num / 100) % 10 == 7)
            {
                Console.WriteLine("The third digit is seven");
            }
            else
            {
                Console.WriteLine("The third digit is not seven");
            }
        }
    }