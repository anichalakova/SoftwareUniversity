using System;

    class CheckABit
    {
        static void Main()
        {
            Console.Write("Please enter a number: ");
            int num = int.Parse(Console.ReadLine());
            Console.Write("Please enter the number of the bit that you want to check: ");
            int p = int.Parse(Console.ReadLine());
            int nRightP = num >> p;
            int bit = nRightP & 1;

            Console.WriteLine((bit == 1) ? "True" : "False");
        }
    }