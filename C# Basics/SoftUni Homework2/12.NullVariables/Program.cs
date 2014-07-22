using System;

    class Program
    {
        static void Main()
        {
            int var1 = 10;
            Console.WriteLine(var1 * null);

            double var2 = 1234.56790;
            Console.WriteLine(var2 * null);

            Console.WriteLine((var1 + var2) * null);           
        }
    }