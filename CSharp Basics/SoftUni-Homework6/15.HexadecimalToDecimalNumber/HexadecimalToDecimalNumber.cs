using System;
using System.Globalization;

class HexadecimalToDecimalNumber
{
    static void Main()
    {
        Console.Write("Enter you hexadecimal value: ");
        string hexa = Console.ReadLine();

        long dec = long.Parse(hexa, NumberStyles.HexNumber);

        Console.WriteLine("Decimal : {0}", dec);
    }
}