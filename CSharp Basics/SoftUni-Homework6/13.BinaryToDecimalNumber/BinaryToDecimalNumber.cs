using System;

class BinaryToDecimalNumber
{
    static void Main()
    {
        Console.Write("Enter a binary integer number : ");
        string binaryNumber = Console.ReadLine();

        long dec = 0;

        for (int i = 0; i < binaryNumber.Length; i++)
        {
            if (binaryNumber[binaryNumber.Length - i - 1] == '0')
            {
                continue;
            }

            dec += (long)Math.Pow(2, i);
        }

        Console.WriteLine("Decimal : {0}", dec);
    }
}