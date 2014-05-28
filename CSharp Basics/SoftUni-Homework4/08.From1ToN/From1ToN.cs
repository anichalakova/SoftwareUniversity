using System;

    class From1ToN
    {
        static void Main(string[] args)
        {
            Console.Write("Insert number: ");
            int n = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 1; i <= n; i++)
            {
                sum += i;
            }
            Console.WriteLine("The sum is {0}", sum);
        }
    }
