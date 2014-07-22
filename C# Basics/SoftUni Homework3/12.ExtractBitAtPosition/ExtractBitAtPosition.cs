using System;

    class ExtractBitAtPosition
    {
        static void Main()
        {
            Console.Write("Please enter a number: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("Please insert the number of the bit that you want to check");
            int p = int.Parse(Console.ReadLine());
            int nRightP = num >> p;
            int bit = nRightP & 1;

            Console.WriteLine("The position of the bit in position 3 is: {0}", bit);
        }
    }