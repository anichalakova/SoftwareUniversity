using System;

    class ExtractBit
    {
        static void Main()
        {
            Console.Write("Please enter a number: ");
            int num = int.Parse(Console.ReadLine());
            int p = 3;
            int nRightP = num >> p;
            int bit = nRightP & 1;

            Console.WriteLine("The position of the bit in position 3 is: {0}", bit);
        }
    }