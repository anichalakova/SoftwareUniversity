using System;

class TrailingZeroes
{
    static void Main()
    {
        Console.Write("Enter n : ");
        int n = int.Parse(Console.ReadLine());

        int factorial = 1;


        for (int i = 1; i <= n; i++)
        {
            factorial = factorial * i;
        }
        string factorialString = factorial.ToString();

        int counter = 0;

        for (int i = factorialString.Length - 1; i >= 0; i--)
        {
            if (factorialString[i] == '0')
            {
                counter++;
            }
            else
            {
                break;
            }
        }

        Console.WriteLine("trailing zeroes of n! : {0}", counter);
        Console.WriteLine("explaination : {0}", factorial);
    }
}