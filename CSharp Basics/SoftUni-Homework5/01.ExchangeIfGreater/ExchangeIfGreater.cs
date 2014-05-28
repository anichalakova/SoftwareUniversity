using System;

    class ExchangeIfGreater
    {
        static void Main()
        {
            Console.Write("Insert first digit: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Insert second digit: ");
            int b = int.Parse(Console.ReadLine());
            int greater = 0;

            if (a < b)
            {
                greater = b;
                b = a;
                a = greater;
            }
            Console.WriteLine("{0} {1}", a, b);
        }
    }
