using System;

class DecimalToBinaryNumber
{
    static void Main()
    {
        Console.Write("Enter Decimal number : ");
        long dec = long.Parse(Console.ReadLine());

        long rest;
        string binary = string.Empty;

        while (dec > 0)
        {
            rest = dec % 2;
            dec = dec / 2;
            binary = rest.ToString() + binary;
        }
        Console.WriteLine("Binary result : {0}", binary);
    }
}