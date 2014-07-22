using System;

class Calculate
{
    static void Main()
    {
        Console.Write("n = ");
        int n = Int32.Parse(Console.ReadLine());
        Console.Write("x = ");
        int x = Int32.Parse(Console.ReadLine());

        double factorial = 1;
        double multiX = 1;
        double result = 1;

        for (int i = 1; i <= n; i++)
        {
            factorial = factorial * i;
            multiX = multiX * x;
            result = result + factorial / multiX;
        }

        Console.WriteLine("{0:F5}", result);
    }
}