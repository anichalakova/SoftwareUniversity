using System;

    class ExchangeValyes
    {
        static void Main()
        {
            int var1 = 5;
            int var2 = 10;
            int helper;

            helper = var1;
            var1 = var2;
            var2 = helper;

            Console.WriteLine(var1);
            Console.WriteLine(var2);
        }
    }